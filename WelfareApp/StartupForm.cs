namespace WelfareApp
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void buttonCreateNewProgram_Click(object sender, EventArgs e)
        {
            CreateNewProgramForm createNewProgramForm
                = new CreateNewProgramForm();
            createNewProgramForm.Show();
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
            ProgramWorkForm programWorkForm 
                = new ProgramWorkForm();
            programWorkForm.Show();
        }
    }
}