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
    public partial class ListOfAppsForm : Form
    {
        BindingSource bindApps = new BindingSource();
        BindingSource bindPeople = new BindingSource();

        List<ApplicationModel> apps = new List<ApplicationModel>();
        List<ApplicantModel> people = new List<ApplicantModel>();

        List<ListAppsDisplay> appsDisplay = new List<ListAppsDisplay>();
        List<ListPeopleDisplay> peopleDisplay = new List<ListPeopleDisplay>();

        List<ListAppsDisplay> appsAll = new List<ListAppsDisplay>();
        List<ListPeopleDisplay> peopleAll = new List<ListPeopleDisplay>();

        public ListOfAppsForm()
        {
            InitializeComponent();
            GetInitialLists();
            ModifyDisplayGrid();
            UpdateBindingSource();
            UpdateGridSource();
        }


        public void GetInitialLists()
        {
            SqlConnector sql = new SqlConnector();
            apps = sql.ListAllApplications();
            people = sql.GetAllApplicants();

            FillDisplays(apps, people);
        }

        public void FillDisplays(List<ApplicationModel> appsInput, List<ApplicantModel> peopleInput)
        {
            foreach (ApplicationModel a in appsInput)
            {

                if (a.applicationId != null)
                {
                    SqlConnector sql = new SqlConnector();

                    ListAppsDisplay output = new ListAppsDisplay();
                    output.input = a;

                    output.AppliedProgram = sql.GetProgramName(a.applicationId);
                    output.ManagingAgency = sql.GetAgencyName(a.applicationId);
                    output.ReceivedByAgent = sql.GetAgentName(a.applicationId);
                    output.ReceivedByOffice = sql.GetOfficeName(a.applicationId);
                    output.SupervisorName = sql.GetSupervisorName(a.applicationId);

                    appsAll.Add(output);
                }
            }

            foreach (ApplicantModel p in peopleInput)
            {
                ListPeopleDisplay output = new ListPeopleDisplay();
                output.input = p;

                peopleAll.Add(output);
            }
        }

        public void ModifyDisplayGrid()
        {
            appsDisplay.Clear();
            peopleDisplay.Clear();
            appsDisplay = appsAll;
            peopleDisplay = peopleAll;

        }

        public void UpdateBindingSource()
        {
            bindApps.DataSource = null;
            bindPeople.DataSource = null;
            bindApps.DataSource = appsDisplay;
            bindPeople.DataSource = peopleDisplay;
        }

        public void UpdateGridSource()
        {
            dataGridViewApps.DataSource = null;
            dataGridViewPeople.DataSource = null;
            dataGridViewPeople.DataSource = bindPeople;
            dataGridViewApps.DataSource = bindApps;

            HideColumns();
        }

        private void HideColumns()
        {
            dataGridViewApps.Columns["input"].Visible = false;
            dataGridViewPeople.Columns["input"].Visible = false;
        }

        private void checkBoxAdultsBelowSixtyFive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAdultsAboveSixtyFive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSingle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxEmployed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxUnemployed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxWithChildren_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxWithoutChildren_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
