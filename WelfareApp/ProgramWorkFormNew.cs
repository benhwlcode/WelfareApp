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

        ApplicantModel selectedApplicant = new ApplicantModel();

        public string customQuery = "";



        public string testQuery = "";

        // TODO: sp that gets one app based on display appId v
        // TODO: sp that updates app doc v
        // TODO: sp that updates app status depending on check v?

        public ProgramWorkFormNew(ProgramModel selectedProgram)
        {
            InitializeComponent();
            currentProgram = selectedProgram;

            InitializeComboBox();
            UpdateGrid();
        }

        private void InitializeComboBox()
        {
            comboBoxDocumentStatus.DataSource = Enum.GetValues(typeof(DocumentStatus));

        }

        private void UpdateGrid()
        {
            SqlConnector sql = new SqlConnector();
            List<ApplicationModel> apps = sql.GetAllApplications(currentProgram.programId);

            programApplications.Clear();

            foreach (ApplicationModel app in apps)
            {
                ApplicationDisplay display = new ApplicationDisplay();
                display.inputApplication = app;
                display.inputApplicant = app.applicant;

                programApplications.Add(display);
            }

            UpdateApplicationsBinding();
            GridHighlight();

        }

        private void UpdateApplicationsBinding()
        {
            dataGridViewAppDisplay.DataSource = null;
            dataGridViewAppDisplay.DataSource = programApplications;

            HideColumns();
        }

        private void GridHighlight()
        {
            foreach (DataGridViewRow r in dataGridViewAppDisplay.Rows)
            {
                if (r.Cells[3].Value.ToString() == EligibilityStatus.eligible.ToString())
                {
                    r.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void dataGridViewAppDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDisplay = dataGridViewAppDisplay.SelectedRows[0].DataBoundItem as ApplicationDisplay;
            selectedApplication = selectedDisplay.inputApplication;

            selectedDocuments = GetDocuments(selectedApplication.applicationId);
            UpdateDocumentsBinding();

            UpdateWorkLabels(selectedApplication);
            TestUpdate(selectedDocuments);

        }

        private void checkBoxShowEligible_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxUpdate();
        }

        private void CheckBoxUpdate()
        {
            CurrencyManager m = (CurrencyManager)BindingContext[dataGridViewAppDisplay.DataSource];
            m.SuspendBinding();

            if (checkBoxShowEligible.Checked)
            {
                foreach (DataGridViewRow r in dataGridViewAppDisplay.Rows)
                {
                    if (r.Cells[3].Value.ToString() != EligibilityStatus.eligible.ToString())
                    {
                        r.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow r in dataGridViewAppDisplay.Rows)
                {
                    r.Visible = true;
                }
            }

            m.ResumeBinding();
        }

        private void buttonUpdateSelected_Click(object sender, EventArgs e)
        {
            foreach (DocumentModel p in checkedListBoxDocuments.CheckedItems)
            {
                p.status = (DocumentStatus)comboBoxDocumentStatus.SelectedItem;
            }

            selectedApplication.listOfDocuments = SerializeDocuments(selectedDocuments);
            CheckDocs(selectedDocuments);

            SqlConnector sql = new SqlConnector();
            sql.UpdateApplication(selectedApplication);

            UpdateWorkLabels(selectedApplication);
            TestUpdate(selectedDocuments);

            UpdateGrid();
            UpdateDocumentsBinding();

        }

        private List<DocumentModel> GetDocuments(int applicationId)
        {
            List<DocumentModel> output = new List<DocumentModel>();

            SqlConnector sql = new SqlConnector();
            string json = sql.GetDocuments(applicationId);

            output = JsonSerializer.Deserialize<List<DocumentModel>>(json);

            return output;

        }

        private string SerializeDocuments(List<DocumentModel> docInput)
        {
            string output = JsonSerializer.Serialize(docInput);

            return output;
        }




        private void UpdateDocumentsBinding()
        {
            checkedListBoxDocuments.DataSource = null;
            checkedListBoxDocuments.DataSource = selectedDocuments;
            checkedListBoxDocuments.DisplayMember = "display";

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

        private void CheckDocs(List<DocumentModel> docInput)
        {
            foreach (DocumentModel d in docInput)
            {
                if (d.status != DocumentStatus.approved)
                {
                    selectedApplication.approvalStatus = ApprovalStatus.pending;
                    return;
                }
            }

            selectedApplication.approvalStatus = ApprovalStatus.approved;

        }




        private void TestUpdate(List<DocumentModel> input)
        {
            string output = "";

            foreach (DocumentModel d in input)
            {
                output += $"{d.name}: {d.status.ToString()}. ";
            }

            richTextBoxTest.Text = output;

        }

        private void buttonEditEligibility_Click(object sender, EventArgs e)
        {
            EditEligibilityForm edit = new EditEligibilityForm(this);
            edit.Show();
        }



        public void ApplyEligibility()
        {
            SqlConnector sql = new SqlConnector();
            sql.UpdateEligibility(currentProgram.programId, customQuery);
            UpdateGrid();
        }

        public void TestText(string input)
        {
            richTextBoxTest.Text = input;
        }

        private void buttonEditApplicant_Click(object sender, EventArgs e)
        {
            selectedApplicant = selectedApplication.applicant;

            if (selectedApplicant== null)
            {
                return;
            }

            EditApplicantForm editApplicant = new EditApplicantForm(selectedApplicant);
            editApplicant.Show();
        }
    }
}
