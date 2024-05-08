using Microsoft.Data.SqlClient;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class StartupForm : Form
    {
        AgentModel userAgent;

        List<ProgramModel> programs = new List<ProgramModel>();
        ProgramModel selectedProgram = new ProgramModel();

        public StartupForm(AgentModel agentInput)
        {
            InitializeComponent();

            userAgent = agentInput;

            InitializeList();
            UpdateBinding();

            this.Text = "Dashboard";
        }

        private void buttonCreateNewProgram_Click(object sender, EventArgs e)
        {
            CreateNewProgramNew createNewProgramNew
                = new CreateNewProgramNew(userAgent);
            createNewProgramNew.Show();

            createNewProgramNew.FormClosed += CreateNewProgramNew_FormClosed;
        }

        private void CreateNewProgramNew_FormClosed(object? sender, FormClosedEventArgs e)
        {
            InitializeList();
            UpdateBinding();
        }

        private void buttonCreateNewApplication_Click(object sender, EventArgs e)
        {
            CreateNewApplicationForm createNewApplicationForm
                = new CreateNewApplicationForm();
            createNewApplicationForm.Show();
        }

        private void buttonListOfApplications_Click(object sender, EventArgs e)
        {
            ListOfAppsForm listOfAppsForm
                = new ListOfAppsForm();
            listOfAppsForm.Show();
        }

        private void listBoxListOfPrograms_DoubleClick(object sender, EventArgs e)
        {
            selectedProgram = (ProgramModel)listBoxListOfPrograms.SelectedItem;

            ProgramWorkFormNew form
                = new ProgramWorkFormNew(selectedProgram, userAgent);
            form.parent = this;
            form.Show();

        }

        private void InitializeList()
        {
            SqlConnector sql = new SqlConnector();

            programs = sql.GetAllPrograms();

        }

        private void UpdateBinding()
        {
            programs.Sort((x, y) => string.Compare(x.programName, y.programName));

            listBoxListOfPrograms.DataSource = null;
            listBoxListOfPrograms.DataSource = programs;
            listBoxListOfPrograms.DisplayMember = "programName";
        }

        public void ChildCall()
        {
            InitializeList();
            UpdateBinding();
        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();
            programs = sql.ProgramSearch(textBoxSearchValue.Text);

            UpdateBinding();
        }       

    }
}