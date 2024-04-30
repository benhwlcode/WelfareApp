using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;
using WelfareAppClassLibrary.Validations;

namespace WelfareApp
{
    public partial class EditProgramForm : Form
    {
        ErrorProvider error = new ErrorProvider();

        ProgramModel currentProgram;
        AgentModel currentAgent;

        List<AgencyModel> agencies = new List<AgencyModel>();
        List<OfficeModel> offices = new List<OfficeModel>();
        List<SupervisorModel> supervisors = new List<SupervisorModel>();

        AgencyModel defaultAgency = new AgencyModel();
        OfficeModel defaultOffice = new OfficeModel();
        SupervisorModel defaultSupervisor = new SupervisorModel();

        ProgramModel programToSave = new ProgramModel();

        public ProgramWorkFormNew parent;

        public EditProgramForm(ProgramModel programInput, AgentModel agentInput)
        {
            InitializeComponent();
            currentProgram = programInput;
            currentAgent = agentInput;
            InitializeBindings();
            InitializeFields();
            ConstructSummary();
        }

        private void InitializeBindings()
        {
            SqlConnector sql = new SqlConnector();

            agencies = sql.GetAllAgencies();
            agencies.Sort((x, y) => string.Compare(x.agencyName, y.agencyName));

            offices = sql.GetAllOffices();
            offices.Sort((x, y) => string.Compare(x.officeName, y.officeName));

            supervisors = sql.GetAllSupervisors();
            supervisors.Sort((x, y) => string.Compare(x.firstName, y.firstName));

            comboBoxAgencyValue.DataSource = agencies;
            comboBoxAgencyValue.DisplayMember = "agencyName";

            comboBoxOfficeValue.DataSource = offices;
            comboBoxOfficeValue.DisplayMember = "officeName";

            comboBoxSupervisorValue.DataSource = supervisors;
            comboBoxSupervisorValue.DisplayMember = "display";

            comboBoxPaymentTypeValue.DataSource = Enum.GetValues(typeof(PaymentForm));


        }

        private void InitializeFields()
        {
            textBoxProgramNameValue.Text = $"{currentProgram.programName}";

            comboBoxPaymentTypeValue.SelectedItem = (PaymentForm)currentProgram.paymentForm;

            if (currentProgram.paymentType == PaymentType.flat)
            {
                radioButtonFlatAmount.Checked = true;
            }
            else
            {
                radioButtonPercentageAmount.Checked = true;
            }


            textBoxMinPaymentValue.Text = String.Format("{0:0.00}", currentProgram.minPayment);
            textBoxMaxPaymentValue.Text = String.Format("{0:0.00}", currentProgram.maxPayment);

            foreach (AgencyModel agency in agencies)
            {
                if (agency.agencyId == currentProgram.agencyId)
                {
                    comboBoxAgencyValue.SelectedItem = agency;
                    defaultAgency = (AgencyModel)comboBoxAgencyValue.SelectedItem;
                }
            }

            foreach (OfficeModel office in offices)
            {
                if (office.officeId == currentProgram.officeId)
                {
                    comboBoxOfficeValue.SelectedItem = office;
                    defaultOffice = (OfficeModel)comboBoxOfficeValue.SelectedItem;
                }
            }

            foreach (SupervisorModel supervisor in supervisors)
            {
                if (supervisor.supervisorId == currentProgram.supervisorId)
                {
                    comboBoxSupervisorValue.SelectedItem = supervisor;
                    defaultSupervisor = (SupervisorModel)comboBoxSupervisorValue.SelectedItem;
                }
            }

            labelAgentValue.Text = $"{currentAgent.firstName} {currentAgent.lastName} " +
                $"({currentAgent.agentId})";

        }

        private void ConstructSummary()
        {
            AgencyModel agency = (AgencyModel)comboBoxAgencyValue.SelectedItem;
            SupervisorModel supervisor = (SupervisorModel)comboBoxSupervisorValue.SelectedItem;
            OfficeModel office = (OfficeModel)comboBoxOfficeValue.SelectedItem;

            if (agency == null || office == null || supervisor == null)
            {
                return;
            }


            string currentDate = DateTime.Now.ToString("yyyy/MM/dd");

            string output = "";


            output = $"Program details edit initiated " +
                $"by {currentAgent.firstName} {currentAgent.lastName} ({currentAgent.agentId}) " +
                $"on {currentDate}. \r\n \r\n";

            output += $"Details and Edit: \r\n \r\n";

            output += $"Program Name: \r\n{currentProgram.programName}" +
                $" \r\n => {textBoxProgramNameValue.Text} \r\n \r\n";

            output += $"Managing Agency: \r\n{defaultAgency.agencyName} ({defaultAgency.agencyCode})" +
                $" \r\n => {agency.agencyName} ({agency.agencyCode}) \r\n \r\n";

            output += $"Office: \r\n{defaultOffice.officeName}" +
                $" \r\n => {office.officeName} \r\n \r\n";

            output += $"Supervisor: \r\n{defaultSupervisor.firstName} {defaultSupervisor.lastName}" +
                $" \r\n => {supervisor.firstName} {supervisor.lastName} \r\n \r\n";

            output += $"Payment: \r\n{currentProgram.paymentType} {currentProgram.paymentForm} " +
                $"(min: {currentProgram.minPayment:C2} max: {currentProgram.maxPayment:C2})";

            if (radioButtonFlatAmount.Checked)
            {
                output += $"\r\n => flat {comboBoxPaymentTypeValue.SelectedItem} " +
                    $"(min: {textBoxMinPaymentValue.Text:C2} max: {textBoxMaxPaymentValue.Text:C2}) \r\n \r\n";
            }
            if (radioButtonPercentageAmount.Checked)
            {
                output += $"\r\n => percentage {comboBoxPaymentTypeValue.SelectedItem} " +
                    $"(min: {textBoxMinPaymentValue.Text:C2} max: {textBoxMaxPaymentValue.Text:C2}) \r\n \r\n";
            }

            richTextBoxSummary.Text = output;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool isEmpty = FormSubmissionCheck.CheckEmptyTextBox(this.Controls);

            if (isEmpty)
            {
                return;
            }

            bool isError = FormSubmissionCheck.CheckErrorProvider(this.Controls, error);

            if (isError)
            {
                return;
            }


            FillSaveInfo();

            SqlConnector sql = new SqlConnector();
            sql.UpdateProgram(programToSave);
            parent.Text = programToSave.programName;


            this.Close();
        }

        private void FillSaveInfo()
        {
            AgencyModel agency = (AgencyModel)comboBoxAgencyValue.SelectedItem;
            SupervisorModel supervisor = (SupervisorModel)comboBoxSupervisorValue.SelectedItem;
            OfficeModel office = (OfficeModel)comboBoxOfficeValue.SelectedItem;

            programToSave.programId = currentProgram.programId;

            programToSave.programName = textBoxProgramNameValue.Text;
            programToSave.agencyId = agency.agencyId;
            programToSave.agentId = currentAgent.agentId;
            programToSave.officeId = office.officeId;
            programToSave.supervisorId = supervisor.supervisorId;
            programToSave.paymentForm = (PaymentForm)comboBoxPaymentTypeValue.SelectedItem;

            if (radioButtonFlatAmount.Checked)
            {
                programToSave.paymentType = PaymentType.flat;
            }
            if (radioButtonPercentageAmount.Checked)
            {
                programToSave.paymentType = PaymentType.percentage;
            }

            decimal min = 0;
            decimal max = 0;

            if (Decimal.TryParse(textBoxMinPaymentValue.Text, out min))
            {
                programToSave.minPayment = min;
            }
            else
            {
                programToSave.minPayment = currentProgram.minPayment;
            }


            if (Decimal.TryParse(textBoxMinPaymentValue.Text, out max))
            {
                programToSave.maxPayment = max;
            }
            else
            {
                programToSave.maxPayment = currentProgram.maxPayment;
            }



        }

        private void textBoxProgramNameValue_TextChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void comboBoxAgencyValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void comboBoxPaymentTypeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void textBoxMinPaymentValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxMinPaymentValue, 
                InputValidation.OnlyTwoDecimals(textBoxMinPaymentValue.Text));

            ConstructSummary();
        }

        private void textBoxMaxPaymentValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxMaxPaymentValue,
                InputValidation.OnlyTwoDecimals(textBoxMaxPaymentValue.Text));

            ConstructSummary();
        }

        private void comboBoxOfficeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void comboBoxSupervisorValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void radioButtonFlatAmount_CheckedChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void radioButtonPercentageAmount_CheckedChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }
    }
}
