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
    public partial class CreateNewProgramNew : Form
    {

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
            SqlConnector sql = new SqlConnector();

            programToSave = FillProgramInfo();
            sql.SaveToProgram(programToSave);
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
    }
}
