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

namespace WelfareApp
{
    public partial class CreateNewProgramForm : Form
    {
        List<AgencyModel> agencies = new List<AgencyModel>();
        List<OfficeModel> offices = new List<OfficeModel>();
        List<SupervisorModel> supervisors = new List<SupervisorModel>();
        List<DocumentModel> documents = new List<DocumentModel>();

        AgentModel userAgent = new AgentModel();
        ProgramModel programToSave = new ProgramModel();

        public CreateNewProgramForm(AgentModel agentInput)
        {
            InitializeComponent();

            userAgent = agentInput;

            InitializeLists();
            UpdateInitialBindings();
            GetListOfDocuments();

        }

        public void InitializeLists()
        {
            SqlConnector sql = new SqlConnector();

            agencies = sql.GetAllAgencies();
            offices = sql.GetAllOffices();
            supervisors = sql.GetAllSupervisors();
        }

        private void buttonCreateProgram_Click(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();

            programToSave = FillProgramInfo();
            sql.SaveToProgram(programToSave);

        }

        public void UpdateInitialBindings()
        {
            comboBoxManagingAgencyValue.DataSource = agencies;
            comboBoxManagingAgencyValue.DisplayMember = "agencyName";

            comboBoxOfficeValue.DataSource = offices;
            comboBoxOfficeValue.DisplayMember = "officeName";

            comboBoxSupervisorValue.DataSource = supervisors;
            comboBoxSupervisorValue.DisplayMember = "firstName";

            comboBoxPaymentTypeValue.DataSource = Enum.GetValues(typeof(PaymentForm));

            labelAgentNameValue.Text = $"{userAgent.firstName} {userAgent.lastName}";


        }

        private void GetListOfDocuments()
        {
            Helper helper = new Helper();

            string source = helper.ListOfAllDocumentsJson();
            documents = JsonSerializer.Deserialize<List<DocumentModel>>(source);

            checkedListBoxListOfRequiredDocuments.DataSource = documents;
            checkedListBoxListOfRequiredDocuments.DisplayMember = "name";

        }

        private ProgramModel FillProgramInfo()
        {
            AgencyModel selectedAgency = (AgencyModel)comboBoxManagingAgencyValue.SelectedItem;
            OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeValue.SelectedItem;
            SupervisorModel selectedSupervisor = (SupervisorModel)comboBoxSupervisorValue.SelectedItem;
            PaymentType selectedPayment = new PaymentType();
            List<DocumentModel> selectedDocuments = new List<DocumentModel>();

            if (radioButtonFlatPayment.Checked)
            {
                selectedPayment = PaymentType.flat;
            }
            else if (radioButtonPercentagePayment.Checked)
            {
                selectedPayment = PaymentType.percentage;
            }

            foreach (DocumentModel p in checkedListBoxListOfRequiredDocuments.CheckedItems)
            {
                selectedDocuments.Add(p);
            }

            string json = JsonSerializer.Serialize(selectedDocuments);


            ProgramModel output = new ProgramModel();



            output.programId = 0;
            output.programName = textBoxProgramNameValue.Text;
            output.programStatus = ProgramStatus.open;

            output.agencyId = selectedAgency.agencyId;
            output.agentId = userAgent.agentId;
            output.officeId = selectedOffice.officeId;
            output.supervisorId = selectedSupervisor.supervisorId;

            output.paymentForm = (PaymentForm)comboBoxPaymentTypeValue.SelectedItem;
            output.paymentType = selectedPayment;
            output.minPayment = Int32.Parse(textBoxMinPaymentValue.Text);
            output.maxPayment = Int32.Parse(textBoxMaxPaymentValue.Text);

            output.listOfDocuments = json;

            return output;
        }

        
        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxListOfRequiredDocuments.Items.Count; i++)
            {
                checkedListBoxListOfRequiredDocuments.SetItemChecked(i, true);
            }
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxListOfRequiredDocuments.Items.Count; i++)
            {
                checkedListBoxListOfRequiredDocuments.SetItemChecked(i, false);
            }
        }
    }
}
