using Microsoft.Identity.Client.NativeInterop;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;
using WelfareAppClassLibrary.Validations;

namespace WelfareApp
{
    public partial class CreateNewProgramNew : Form
    {
        ErrorProvider error = new ErrorProvider();

        List<AgencyModel> agencies = new List<AgencyModel>();
        List<OfficeModel> offices = new List<OfficeModel>();
        List<SupervisorModel> supervisors = new List<SupervisorModel>();
        List<DocumentModel> documents = new List<DocumentModel>();

        AgentModel userAgent = new AgentModel();
        ProgramModel programToSave = new ProgramModel();

        public CreateNewProgramNew(AgentModel agentInput)
        {
            InitializeComponent();

            userAgent = agentInput;

            InitializeLists();
            UpdateInitialBindings();
            GetListOfDocuments();

            this.Text = "Create New Program";
            radioButtonFlat.Checked = true;
        }

        public void InitializeLists()
        {
            SqlConnector sql = new SqlConnector();

            agencies = sql.GetAllAgencies();
            offices = sql.GetAllOffices();
            supervisors = sql.GetAllSupervisors();
        }

        private void buttonCreateNewProgram_Click(object sender, EventArgs e)
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


            SqlConnector sql = new SqlConnector();

            programToSave = FillProgramInfo();
            sql.SaveToProgram(programToSave);

            this.Close();
        }
        

        public void UpdateInitialBindings()
        {
            comboBoxManagingAgency.DataSource = agencies;
            comboBoxManagingAgency.DisplayMember = "agencyName";

            comboBoxOffice.DataSource = offices;
            comboBoxOffice.DisplayMember = "officeName";

            comboBoxSupervisor.DataSource = supervisors;
            comboBoxSupervisor.DisplayMember = "firstName";

            comboBoxPaymentType.DataSource = Enum.GetValues(typeof(PaymentForm));

            labelAgentValue.Text = $"{userAgent.firstName} {userAgent.lastName}";
        }



        private void GetListOfDocuments()
        {
            Helper helper = new Helper();

            string source = helper.ListOfAllDocumentsJson();
            documents = JsonSerializer.Deserialize<List<DocumentModel>>(source);

            checkedListBoxRequiredDocuments.DataSource = documents;
            checkedListBoxRequiredDocuments.DisplayMember = "name";

        }


        private ProgramModel FillProgramInfo()
        {

            AgencyModel selectedAgency = (AgencyModel)comboBoxManagingAgency.SelectedItem;
            OfficeModel selectedOffice = (OfficeModel)comboBoxOffice.SelectedItem;
            SupervisorModel selectedSupervisor = (SupervisorModel)comboBoxSupervisor.SelectedItem;
            PaymentType selectedPayment = new PaymentType();
            List<DocumentModel> selectedDocuments = new List<DocumentModel>();

            if (radioButtonFlat.Checked)
            {
                selectedPayment = PaymentType.flat;
            }
            else if (radioButtonPercentage.Checked)
            {
                selectedPayment = PaymentType.percentage;
            }

            foreach (DocumentModel p in checkedListBoxRequiredDocuments.CheckedItems)
            {
                selectedDocuments.Add(p);
            }

            string json = JsonSerializer.Serialize(selectedDocuments);


            ProgramModel output = new ProgramModel();

            output.programId = 0;
            output.programName = textBoxProgramName.Text;
            output.programStatus = ProgramStatus.open;

            output.agencyId = selectedAgency.agencyId;
            output.agentId = userAgent.agentId;
            output.officeId = selectedOffice.officeId;
            output.supervisorId = selectedSupervisor.supervisorId;

            output.paymentForm = (PaymentForm)comboBoxPaymentType.SelectedItem;
            output.paymentType = selectedPayment;

            //decimal min = 0;
            //Decimal.TryParse(textBoxMinAmount.Text, out min);

            //decimal max = 0;
            //Decimal.TryParse(textBoxMaxAmount.Text, out max);

            output.minPayment = Int32.Parse(textBoxMinAmount.Text);
            output.maxPayment = Int32.Parse(textBoxMaxAmount.Text);

            output.listOfDocuments = json;

            return output;
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxRequiredDocuments.Items.Count; i++)
            {
                checkedListBoxRequiredDocuments.SetItemChecked(i, true);
            }
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxRequiredDocuments.Items.Count; i++)
            {
                checkedListBoxRequiredDocuments.SetItemChecked(i, false);
            }
        }

        private void ConstructSummary()
        {
            AgencyModel agency = (AgencyModel)comboBoxManagingAgency.SelectedItem;
            SupervisorModel supervisor = (SupervisorModel)comboBoxSupervisor.SelectedItem;
            OfficeModel office = (OfficeModel)comboBoxOffice.SelectedItem;

            string currentDate = DateTime.Now.ToString("yyyy/MM/dd");

            string output = "";

            output += $"Program details drafted by {userAgent.firstName} {userAgent.lastName} " +
                $"(id:{userAgent.agentId}) on {currentDate}. \r\n \r\n";

            if (agency != null && supervisor != null && office != null)
            {
                output += $"{agency.agencyName} program {textBoxProgramName.Text} will be supervised " +
                    $"by {supervisor.firstName} {supervisor.lastName} and its applications " +
                    $"sent to {office.officeName}. \r\n \r\n";
            }

            if (!radioButtonFlat.Checked && !radioButtonPercentage.Checked)
            {
                output += $"[please set payment details] \r\n \r\n";
            }

            if (radioButtonFlat.Checked)
            {
                output += $"The payout is a flat amount with a minimum of {textBoxMinAmount.Text} " +
                    $"and a maximum of {textBoxMaxAmount.Text}. \r\n \r\n";
            }

            if (radioButtonPercentage.Checked)
            {
                output += $"The payout is a percentage amount with a minimum of {textBoxMinAmount.Text} " +
                    $"and a maximum of {textBoxMaxAmount.Text}. \r\n \r\n";
            }

            output += $"By clicking [Create New Program] the agent confirms the summary details to be correct " +
                $"and understands this note will be sent to your supervisor.";

            richTextBoxSummary.Text = output;
        }

        private void textBoxProgramName_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxProgramName, InputValidation.ValidLength(textBoxProgramName.Text));
            ConstructSummary();
        }

        private void comboBoxManagingAgency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void comboBoxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void comboBoxSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void radioButtonFlat_CheckedChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void radioButtonPercentage_CheckedChanged(object sender, EventArgs e)
        {
            ConstructSummary();
        }

        private void textBoxMinAmount_TextChanged(object sender, EventArgs e)
        {
            ConstructSummary();
            error.SetError(textBoxMinAmount, InputValidation.OnlyTwoDecimals(textBoxMinAmount.Text));
        }

        private void textBoxMaxAmount_TextChanged(object sender, EventArgs e)
        {
            ConstructSummary();
            error.SetError(textBoxMaxAmount, InputValidation.OnlyTwoDecimals(textBoxMaxAmount.Text));
        }

    }
}
