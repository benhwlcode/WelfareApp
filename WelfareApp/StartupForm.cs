using Microsoft.Data.SqlClient;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class StartupForm : Form
    {
        AgentModel userAgent;

        List<ProgramModel> programs= new List<ProgramModel>();
        ProgramModel selectedProgram = new ProgramModel();

        public StartupForm(AgentModel agentInput)
        {
            InitializeComponent();

            userAgent = agentInput;

            InitializeList();
            UpdateBinding();
        }

        private void buttonCreateNewProgram_Click(object sender, EventArgs e)
        {
            CreateNewProgramNew createNewProgramNew
                = new CreateNewProgramNew(userAgent);
            createNewProgramNew.Show();
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

            ProgramWorkFormNew programWorkForm
                = new ProgramWorkFormNew(selectedProgram);
            programWorkForm.Show();
        }

        private void InitializeList()
        {
            SqlConnector sql = new SqlConnector();

            programs = sql.GetAllPrograms();

            
        }

        private void UpdateBinding()
        {
            listBoxListOfPrograms.DataSource = programs;
            listBoxListOfPrograms.DisplayMember = "programName";
        }

    }
}