using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class LoadApplicantForm : Form
    {

        public CreateNewApplicationForm parentCreateNewApp = new CreateNewApplicationForm();
        public ApplicantModel outputApplicant = new ApplicantModel();

        List<ApplicantModel> selectionList = new List<ApplicantModel>();


        public LoadApplicantForm()
        {
            InitializeComponent();
            SqlConnector sql = new SqlConnector();
            selectionList = sql.GetAllApplicants();
            UpdateBindings();

            buttonTestList.Visible = false;
        }

        private void buttonLoadApplicant_Click(object sender, EventArgs e)
        {
            parentCreateNewApp.loadedApplicant = (ApplicantModel)listBoxListOfApplicants.SelectedItem;
            parentCreateNewApp.LoadApplicantAndSpouseInfo();

            this.Close();
        }


        private void buttonTestList_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateBindings()
        {
            selectionList.Sort((x, y) => string.Compare(x.firstName, y.firstName));

            listBoxListOfApplicants.DataSource = null;
            listBoxListOfApplicants.DataSource = selectionList;
            listBoxListOfApplicants.DisplayMember = "CustomDisplay";
        }

        


    }
}
