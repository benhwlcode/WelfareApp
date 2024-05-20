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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WelfareApp
{
    public partial class ProgramWorkFormNew : Form
    {
        public EditProgramForm editPro;
        public StartupForm parent;

        BindingSource bindApps = new BindingSource();

        ProgramModel currentProgram = new ProgramModel();
        AgentModel currentAgent = new AgentModel();

        List<ApplicationDisplay> programApplications = new List<ApplicationDisplay>();

        ApplicationDisplay selectedDisplay = new ApplicationDisplay();
        ApplicationModel selectedApplication = new ApplicationModel();
        List<DocumentModel> selectedDocuments = new List<DocumentModel>();

        ApplicantModel selectedApplicant = new ApplicantModel();

        public string customQuery = "";
        public List<uEligibilityCondition> sessionConditions = new List<uEligibilityCondition>();

        public string testQuery = "";


        public ProgramWorkFormNew(ProgramModel selectedProgram, AgentModel userAgent)
        {
            currentProgram = selectedProgram;
            currentAgent = userAgent;
            InitializeComponent();
            InitializeComboBox();
            UpdateGrid();
            HideTestElements();

            this.Text = $"{currentProgram.programName} ({currentProgram.programId})";

            SetStartPosition();

        }

        private void SetStartPosition()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(40, 80);
        }

        private void dataGridViewAppDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDisplayAsApplication();

            selectedDocuments = GetDocuments(selectedApplication.applicationId);
            UpdateDocumentsBinding();

            UpdateWorkLabels(selectedApplication);

        }

        private void checkBoxShowEligible_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxUpdate();
        }

        private void buttonUpdateSelected_Click(object sender, EventArgs e)
        {
            if (labelAppInfo.Text == "no selection")
            {
                MessageBox.Show("Please select application to update.");
                return;
            }



            foreach (DocumentModel p in checkedListBoxDocuments.CheckedItems)
            {
                p.status = (DocumentStatus)comboBoxDocumentStatus.SelectedItem;
            }

            selectedApplication.listOfDocuments = SerializeDocuments(selectedDocuments);
            CheckDocs(selectedDocuments);

            SqlConnector sql = new SqlConnector();
            sql.UpdateApplication(selectedApplication);

            UpdateWorkLabels(selectedApplication);

            FullRefreshGridAndUpdateInfo();

        }

        private void buttonEditEligibility_Click(object sender, EventArgs e)
        {
            EditEligibilityForm edit = new EditEligibilityForm(this, sessionConditions);
            edit.Show();
        }

        private void buttonEditProgram_Click(object sender, EventArgs e)
        {
            editPro = new EditProgramForm(currentProgram, currentAgent);
            editPro.parent = this;
            editPro.Show();
        }

        private void buttonEditApplicant_Click(object sender, EventArgs e)
        {
            selectedApplicant = selectedApplication.applicant;

            if (selectedApplicant == null)
            {
                return;
            }

            EditApplicantForm editApplicant = new EditApplicantForm(selectedApplicant);
            editApplicant.Show();
            editApplicant.FormClosed += EditApplicant_FormClosed;
        }

        private void EditApplicant_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FullRefreshGridAndUpdateInfo();
            GetDisplayAsApplication();
            UpdateWorkLabels(selectedApplication);

            if (customQuery != "")
            {
                ApplyEligibility();
            }

        }

        private void dataGridViewAppDisplay_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridHighlight();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void HideTestElements()
        {
            richTextBoxTest.Hide();
            buttonTest.Hide();
        }

        private void InitializeComboBox()
        {
            comboBoxDocumentStatus.DataSource = Enum.GetValues(typeof(DocumentStatus));
        }

        public void UpdateGrid()
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

            // customObjects.Sort((obj1, obj2) => obj1.Age.CompareTo(obj2.Age));
            // customObjects.Sort((x, y) => x.Age.CompareTo(y.Age));

            programApplications.Sort((x, y) 
                => x.inputApplication.applicationId.CompareTo(y.inputApplication.applicationId));

            UpdateApplicationsBinding();
            GridHighlight();
        }

        private void UpdateApplicationsBinding()
        {
            bindApps.DataSource = null;
            bindApps.DataSource = programApplications;


            dataGridViewAppDisplay.DataSource = null;
            dataGridViewAppDisplay.DataSource = bindApps;

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
                else
                {
                    // no need to highlight 
                    // r.DefaultCellStyle.BackColor = Color.LightPink;
                }

                if (r.Cells[3].Value.ToString() == EligibilityStatus.eligible.ToString() &&
                    r.Cells[5].Value.ToString() == ApprovalStatus.approved.ToString())
                {
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

        private void GetDisplayAsApplication()
        {
            selectedDisplay = dataGridViewAppDisplay.SelectedRows[0].DataBoundItem as ApplicationDisplay;
            selectedApplication = selectedDisplay.inputApplication;
        }

        public void CheckBoxUpdate()
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

        public void UpdateDocumentsBinding()
        {
            checkedListBoxDocuments.DataSource = null;
            checkedListBoxDocuments.DataSource = selectedDocuments;
            checkedListBoxDocuments.DisplayMember = "display";

        }

        private void UpdateWorkLabels(ApplicationModel appInput)
        {
            labelAppInfo.Text = $"{appInput.applicant.firstName} {appInput.applicant.lastName} " +
                $"({appInput.applicationId.ToString()})";

            labelAppProgress.Text = $"{appInput.applicationProgress.ToString()}";
            labelEligibility.Text = $"{appInput.eligibilityStatus.ToString()}";
            labelApprovalStatus.Text = $"{appInput.approvalStatus.ToString()}";
            labelPayment.Text = $"{appInput.paymentStatus.ToString()}";

        }

        private void HideColumns()
        {
            dataGridViewAppDisplay.Columns["inputApplication"].Visible = false;
            dataGridViewAppDisplay.Columns["inputApplicant"].Visible = false;

            ResizeColumns();
        }

        private void ResizeColumns()
        {
            for (int i = 0; i < dataGridViewAppDisplay.ColumnCount; i++)
            {
                dataGridViewAppDisplay.Columns[i].AutoSizeMode
                    = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
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


        public void ApplyEligibility()
        {
            SqlConnector sql = new SqlConnector();
            sql.UpdateEligibility(currentProgram.programId, customQuery);
            UpdateGrid();

            UpdateDocumentsBinding();
            CheckBoxUpdate();
        }

        public void TestText(string input)
        {
            richTextBoxTest.Text = input;
        }

        private void FullRefreshGridAndUpdateInfo()
        {
            UpdateGrid();
            UpdateDocumentsBinding();
            CheckBoxUpdate();
        }

        
    }
}
