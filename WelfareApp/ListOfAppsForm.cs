using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary;
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

        List<ApplicationModel> appsFilter = new List<ApplicationModel>();

        List<string> searchConditions = new List<string>();
        string searchQuery = "";

        List<string> filterConditions = new List<string>();
        string filterQuery = "";

        public string filterCustom = "";

        string fullQuery = "";

        AgeFilter ageFilter = AgeFilter.All;

        public ListOfAppsForm()
        {
            InitializeComponent();
            GetInitialLists();
            ModifyDisplayGrid();
            UpdateBindingSource();
            UpdateGridSource();

            this.Text = "List of Apps";
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
            dataGridViewApps.DataSource = bindApps;
            dataGridViewPeople.DataSource = bindPeople;


            HideColumns();
        }

        private void HideColumns()
        {
            dataGridViewApps.Columns["input"].Visible = false;
            dataGridViewPeople.Columns["input"].Visible = false;

            ResizeDataGrid();
        }

        public void ResizeDataGrid()
        {
            for (int i = 0; i < dataGridViewApps.ColumnCount; i++)
            {
                dataGridViewApps.Columns[i].AutoSizeMode
                    = DataGridViewAutoSizeColumnMode.DisplayedCells;

                // AllowDgvAppResize(i);
            }

            for (int i = 0; i < dataGridViewPeople.ColumnCount; i++)
            {
                dataGridViewPeople.Columns[i].AutoSizeMode
                    = DataGridViewAutoSizeColumnMode.DisplayedCells;

                // AllowDgvPeopleResize(i);

            }
        }

        public void AllowDgvAppResize(int i)
        {

            // put code below in forloop for dataGridViewApps

            int appsWidth = dataGridViewApps.Columns[i].Width;
            dataGridViewApps.Columns[i].AutoSizeMode
                    = DataGridViewAutoSizeColumnMode.None;
            dataGridViewApps.Columns[i].Width = appsWidth;

        }

        public void AllowDgvPeopleResize(int i)
        {
            // put code below in forloop for dataGridViewPeople

            int peopleWidth = dataGridViewPeople.Columns[i].Width;
            dataGridViewPeople.Columns[i].AutoSizeMode
                    = DataGridViewAutoSizeColumnMode.None;
            dataGridViewPeople.Columns[i].Width = peopleWidth;
        }


        private void checkBoxAdultsBelowSixtyFive_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxAdultsAboveSixtyFive_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxSingle_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxMarried_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxEmployed_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxUnemployed_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxWithChildren_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxWithoutChildren_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxUseCustomFilter_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        public void FilterDisplays(List<ApplicationModel> input)
        {
            appsDisplay.Clear();
            peopleDisplay.Clear();

            foreach (var a in input)
            {
                SqlConnector sql = new SqlConnector();

                ListAppsDisplay output = new ListAppsDisplay();
                output.input = a;

                output.AppliedProgram = sql.GetProgramName(a.applicationId);
                output.ManagingAgency = sql.GetAgencyName(a.applicationId);
                output.ReceivedByAgent = sql.GetAgentName(a.applicationId);
                output.ReceivedByOffice = sql.GetOfficeName(a.applicationId);
                output.SupervisorName = sql.GetSupervisorName(a.applicationId);

                appsDisplay.Add(output);
            }

            foreach (var a in input)
            {
                ListPeopleDisplay output = new ListPeopleDisplay();
                output.input = a.applicant;

                peopleDisplay.Add(output);
            }

        }

        public void CheckSearchConditions()
        {
            searchConditions.Clear();

            string value = textBoxSearchValue.Text;

            if (checkBoxAll.Checked || checkBoxProgramName.Checked)
            {
                string pro = $"pro.programName LIKE '%{value}%'";
                searchConditions.Add(pro);
            }
            if (checkBoxAll.Checked || checkBoxManagingAgency.Checked)
            {
                string agg = $"agg.agencyName LIKE '%{value}%'";
                searchConditions.Add(agg);
            }
            if (checkBoxAll.Checked || checkBoxAgent.Checked)
            {
                string ag = $"CONCAT(ag.firstName, ' ', ag.lastName) LIKE '%{value}%'";
                searchConditions.Add(ag);
            }
            if (checkBoxAll.Checked || checkBoxOffice.Checked)
            {
                string ofc = $"ofc.officeName LIKE '%{value}%'";
                searchConditions.Add(ofc);
            }
            if (checkBoxAll.Checked || checkBoxSupervisor.Checked)
            {
                string sup = $"CONCAT(sup.firstName, ' ', sup.lastName) LIKE '%{value}%'";
                searchConditions.Add(sup);
            }
            if (checkBoxAll.Checked || checkBoxApplicant.Checked)
            {
                string ap = $"CONCAT(ap.firstName, ' ', ap.lastName) LIKE '%{value}%'";
                searchConditions.Add(ap);
            }
        }

        public void CheckFilterConditions()
        {
            filterConditions.Clear();

            ageFilter = AgeFilter.All;

            if (checkBoxAdultsBelowSixtyFive.Checked)
            {
                ageFilter = AgeFilter.Adult;

            }

            if (checkBoxAdultsAboveSixtyFive.Checked)
            {
                ageFilter = AgeFilter.Elderly;
            }

            if (checkBoxAdultsBelowSixtyFive.Checked && checkBoxAdultsAboveSixtyFive.Checked)
            {
                ageFilter = AgeFilter.Both;
            }

            if (checkBoxSingle.Checked)
            {
                string output = $"ap.maritalStatus != 1";
                filterConditions.Add(output);
            }

            if (checkBoxMarried.Checked)
            {
                string output = $"ap.maritalStatus = 1";
                filterConditions.Add(output);
            }

            if (checkBoxEmployed.Checked)
            {
                string output = $"(ap.employmentType = 0  OR ap.employmentType = 1 " +
                    $"OR ap.employmentType = 3  OR ap.employmentType = 4)";
                filterConditions.Add(output);
            }

            if (checkBoxUnemployed.Checked)
            {
                string output = $"(ap.employmentType = 2 OR ap.employmentType = 5 " +
                    $"OR ap.employmentType = 6)";
                filterConditions.Add(output);
            }

            if (checkBoxWithChildren.Checked)
            {
                string output = $"ap.numberOfChildren > 0";
                filterConditions.Add(output);
            }

            if (checkBoxWithoutChildren.Checked)
            {
                string output = $"ap.numberOfChildren = 0";
                filterConditions.Add(output);
            }

            if (checkBoxUseCustomFilter.Checked && filterCustom != "")
            {
                string output = filterCustom;
                filterConditions.Add(output);
            }
        }

        public string ReturnSearchQuery(List<string> input)
        {
            string output = "";

            output = String.Join(" OR ", input);

            return output;

        }

        public string ReturnFilterQuery(List<string> input)
        {
            string output = "";

            output = String.Join(" AND ", input);

            return output;
        }

        public string ReturnFullQuery(string search, string filter)
        {

            if (search == "" && filter == "")
            {
                return "";
            }

            if (search == "")
            {
                return $"WHERE {filter}";
            }

            if (filter == "")
            {
                return $"WHERE {search}";
            }

            return $"WHERE ({search}) AND {filter}";
        }

        private void buttonEditCustomFilter_Click(object sender, EventArgs e)
        {
            EditFilterForm edit = new EditFilterForm(this);
            edit.Show();

            edit.FormClosed += Form_FormClosed;
        }



        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchValue.Text.Length == 0)
            {
                GetInitialAll();
            }

            if (textBoxSearchValue.Text.Length > 2)
            {
                ApplyQuery();
            }


        }

        public void GetInitialAll()
        {
            appsFilter = apps;

            FilterDisplays(appsFilter);
            UpdateBindingSource();
            UpdateGridSource();
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxProgramName_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxManagingAgency_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxAgent_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxOffice_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void checkBoxApplicant_CheckedChanged(object sender, EventArgs e)
        {
            ApplyQuery();
        }

        private void ApplyQuery()
        {
            CheckSearchConditions();
            searchQuery = ReturnSearchQuery(searchConditions);

            CheckFilterConditions();
            filterQuery = ReturnFilterQuery(filterConditions);

            fullQuery = ReturnFullQuery(searchQuery, filterQuery);

            SqlConnector sql = new SqlConnector();
            appsFilter = sql.AppsSearch(fullQuery, ageFilter);

            FilterDisplays(appsFilter);
            UpdateBindingSource();
            UpdateGridSource();
        }


        private void TextBoxChange()
        {
            if (textBoxSearchValue.Text.Length >= 3)
            {
                CheckSearchConditions();
                searchQuery = ReturnSearchQuery(searchConditions);

                SqlConnector sql = new SqlConnector();
                appsFilter = sql.AppsSearch(searchQuery, ageFilter);

                FilterDisplays(appsFilter);
                UpdateBindingSource();
                UpdateGridSource();
            }
        }

        private void dataGridViewApps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListAppsDisplay app = new ListAppsDisplay();
            app = dataGridViewApps.SelectedRows[0].DataBoundItem as ListAppsDisplay;

            ApplicantModel input = app.input.applicant;

            EditApplicantForm form = new EditApplicantForm(input);
            form.Show();

            form.FormClosed += Form_FormClosed;
        }

        private void dataGridViewPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListPeopleDisplay person = new ListPeopleDisplay();
            person = dataGridViewPeople.SelectedRows[0].DataBoundItem as ListPeopleDisplay;

            ApplicantModel input = person.input;

            EditApplicantForm form = new EditApplicantForm(input);
            form.Show();

            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ApplyQuery();
        }

        
    }
}
