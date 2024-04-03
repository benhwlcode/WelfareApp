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
    public partial class ProgramWorkFormNew : Form
    {
        ProgramModel currentProgram = new ProgramModel();

        List<ApplicationDisplay> programApplications = new List<ApplicationDisplay>();

        ApplicationDisplay selectedDisplay = new ApplicationDisplay();
        ApplicationModel selectedApplication = new ApplicationModel();
        List<DocumentModel> selectedDocuments = new List<DocumentModel>();      

        List<ApplicationModel> testList = new List<ApplicationModel>();
        ApplicationDisplay testApp = new ApplicationDisplay();

        public ProgramWorkFormNew(ProgramModel selectedProgram)
        {
            InitializeComponent();
            currentProgram = selectedProgram;

            InitializeBindings();
            UpdateApplicationsBinding();


            // TODO: sp that gets one app based on display appId
            // TODO: sp that updates app doc 
            // TODO: sp that updates app status depending on check
        }

        private void dataGridViewAppDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDisplay = dataGridViewAppDisplay.SelectedRows[0].DataBoundItem as ApplicationDisplay;
            selectedApplication = selectedDisplay.inputApplication;

            selectedDocuments = GetDocuments(selectedApplication.applicationId);
            UpdateDocumentsBinding();

            UpdateWorkLabels(selectedApplication);
            



        }



        private void buttonTest_Click(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();
            testList = sql.GetAllApplications(4012);

            foreach (ApplicationModel app in testList)
            {
                ApplicationDisplay display = new ApplicationDisplay();
                display.inputApplication = app;
                display.inputApplicant = app.applicant;

                programApplications.Add(display);
            }

            dataGridViewAppDisplay.DataSource = null;
            dataGridViewAppDisplay.DataSource = programApplications;

            HideColumns();

            testApp = dataGridViewAppDisplay.SelectedRows[0].DataBoundItem as ApplicationDisplay;

            if (testApp.inputApplicant.spouseId != null)
            {
                richTextBoxTest.Text = testApp.inputApplicant.spouseId.firstName;
            }
            else
            {
                richTextBoxTest.Text = "No Spouse";
            }


        }

        private void InitializeBindings()
        {
            SqlConnector sql = new SqlConnector();
            List<ApplicationModel> apps = sql.GetAllApplications(currentProgram.programId);

            foreach (ApplicationModel app in apps)
            {
                ApplicationDisplay display = new ApplicationDisplay();
                display.inputApplication = app;
                display.inputApplicant = app.applicant;

                programApplications.Add(display);
            }

            comboBoxDocumentStatus.DataSource = Enum.GetValues(typeof(DocumentStatus)); 

            
        }

        private List<DocumentModel> GetDocuments(int applicationId)
        {
            List<DocumentModel> output = new List<DocumentModel>();

            SqlConnector sql = new SqlConnector();
            string json = sql.GetDocuments(applicationId);

            output = JsonSerializer.Deserialize<List<DocumentModel>>(json);           

            return output;

        }


        private void UpdateApplicationsBinding()
        {
            dataGridViewAppDisplay.DataSource = null;
            dataGridViewAppDisplay.DataSource = programApplications;

            HideColumns();
        }

        private void UpdateDocumentsBinding()
        {
            checkedListBoxDocuments.DataSource = null;
            checkedListBoxDocuments.DataSource = selectedDocuments;
            checkedListBoxDocuments.DisplayMember = "name";

        }

        private void UpdateWorkLabels(ApplicationModel appInput)
        {
            labelAppInfo.Text = $"{appInput.applicant.firstName} {appInput.applicant.lastName} " +
                $"({appInput.applicationId.ToString()})";

            labelAppProgress.Text = appInput.applicationProgress.ToString();
            labelEligibility.Text = appInput.eligibilityStatus.ToString();
            labelApprovalStatus.Text = appInput.approvalStatus.ToString();
            labelPayment.Text = appInput.paymentStatus.ToString();



        }


        private void HideColumns()
        {
            dataGridViewAppDisplay.Columns["inputApplication"].Visible = false;
            dataGridViewAppDisplay.Columns["inputApplicant"].Visible = false;
        }


    }
}
