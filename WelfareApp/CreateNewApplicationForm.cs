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
    public partial class CreateNewApplicationForm : Form
    {
        uEditApplicant applicantInput = new uEditApplicant();

        List<ProgramModel> programs = new List<ProgramModel>();
        List<AgentModel> agents = new List<AgentModel>();
        List<OfficeModel> offices = new List<OfficeModel>();
        List<SupervisorModel> supervisors = new List<SupervisorModel>();
        List<DocumentModel> documents = new List<DocumentModel>();

        ApplicationModel applicationToSave = new ApplicationModel();
        ApplicantModel applicantToSave = new ApplicantModel();
        SpouseModel spouseToSave = new SpouseModel();


        public CreateNewApplicationForm()
        {
            InitializeComponent();

            
            panelPlaceholder.Controls.Clear();
            panelPlaceholder.Controls.Add(applicantInput);

            InitializeLists();
            UpdateInitialBindings();
            GetDocumentsList();


        }

        private void buttonLoadApplicantData_Click(object sender, EventArgs e)
        {
            LoadApplicantForm loadApplicantForm
                = new LoadApplicantForm();

            loadApplicantForm.Show();
        }

        public void InitializeLists()
        {
            SqlConnector sql = new SqlConnector();

            programs = sql.GetAllPrograms();
            agents = sql.GetAllAgents();
            offices = sql.GetAllOffices();
            supervisors = sql.GetAllSupervisors();
        }

        public void UpdateInitialBindings()
        {
            comboBoxProgramValue.DataSource = programs;
            comboBoxProgramValue.DisplayMember = "programName";

            comboBoxAgentValue.DataSource = agents;
            comboBoxAgentValue.DisplayMember = "firstName";

            comboBoxOfficeValue.DataSource = offices;
            comboBoxOfficeValue.DisplayMember = "officeName";

            comboBoxSupervisorValue.DataSource = supervisors;
            comboBoxSupervisorValue.DisplayMember = "firstName";
        }

        public void GetDocumentsList()
        {
            ProgramModel selectedProgram = (ProgramModel)comboBoxProgramValue.SelectedItem;
            string documentsJson = "";

            SqlConnector sql = new SqlConnector();
            documentsJson = sql.RetriveRequiredList(selectedProgram);

            documents.Clear();
            documents = JsonSerializer.Deserialize<List<DocumentModel>>(documentsJson);


            checkedListBoxListOfDocumentsReceived.DataSource = null;
            checkedListBoxListOfDocumentsReceived.DataSource = documents;
            checkedListBoxListOfDocumentsReceived.DisplayMember = "name";

            
        }

        private void comboBoxProgramValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDocumentsList();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxListOfDocumentsReceived.Items.Count; i++)
            {
                checkedListBoxListOfDocumentsReceived.SetItemChecked(i, true);
            }


        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxListOfDocumentsReceived.Items.Count; i++)
            {
                checkedListBoxListOfDocumentsReceived.SetItemChecked(i, false);
            }
        }

        private void buttonCreateNewApplication_Click(object sender, EventArgs e)
        {
            applicationToSave = FillApplicationToSaveInfo();
            applicantToSave = FillApplicantToSaveInfo();
            spouseToSave = FillSpouseToSaveInfo();

            SqlConnector sql = new SqlConnector();
            sql.SaveToApplication(applicationToSave, applicantToSave, spouseToSave);
            

        }

        private ApplicationModel FillApplicationToSaveInfo()
        {
            ProgramModel selectedProgram = (ProgramModel)comboBoxProgramValue.SelectedItem;
            AgentModel selectedAgent = (AgentModel)comboBoxAgentValue.SelectedItem; 
            OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeValue.SelectedItem;
            SupervisorModel selectedSupervisor = (SupervisorModel)comboBoxSupervisorValue.SelectedItem;

            ApplicationModel output = new ApplicationModel();

            output.applicationId = 0;
            output.applicantId = 0;

            output.programId = selectedProgram.programId;
            output.agentId = selectedAgent.agentId;
            output.officeId = selectedOffice.officeId;  
            output.supervisorId = selectedSupervisor.supervisorId;

            output.applicationProgress = ApplicationProgress.ongoing;
            output.eligibilityStatus = EligibilityStatus.pending;
            output.approvalStatus = ApprovalStatus.pending;
            output.paymentStatus = PaymentStatus.pending;

            output.signatureSigned = true;
            output.acceptedDate = DateOnly.FromDateTime(DateTime.Now).ToString();
                        

            foreach (DocumentModel p in checkedListBoxListOfDocumentsReceived.SelectedItems)
            {
                p.status = DocumentStatus.received;
            }

            output.listOfDocuments = JsonSerializer.Serialize(documents);     

            return output;

        }

        private ApplicantModel FillApplicantToSaveInfo()
        {
            ApplicantModel output = new ApplicantModel();

            output.applicantId = Int32.Parse(labelApplicantIdValue.Text);

            output.firstName = applicantInput.applicantFirstName;
            output.lastName = applicantInput.applicationlicantLastName;
            output.gender = applicantInput.applicantGender;
            output.birthday = DateOnly.FromDateTime(applicantInput.applicantBirthday).ToString();
            output.sinCard = applicantInput.applicantSinCard;
            output.maritalStatus = applicantInput.applicantMaritalStatus;
            output.phone = applicantInput.applicantPhone;
            output.email = applicantInput.applicantEmail;
            output.isCitizen = applicantInput.applicantIsCitizen;
            output.isIndigenous = applicantInput.applicantIsIndigenous;
            output.isDisabled = applicantInput.applicantIsDisabled;

            output.spouseId = null;

            output.residenceStatus = applicantInput.residence;
            output.streetAddress = applicantInput.address;
            output.city = applicantInput.city;
            output.province = applicantInput.province;
            output.moveInDate = DateOnly.FromDateTime(applicantInput.moveInDate).ToString();

            output.familySize = Int32.Parse(applicantInput.familySize);
            output.numberOfAdults = Int32.Parse(applicantInput.numberOfAdults);
            output.numberOfChildren = Int32.Parse(applicantInput.numberOfChildren);
            output.numberOfElderly = Int32.Parse(applicantInput.numberOfElderly);

            output.rentalExpense = Int32.Parse(applicantInput.rentExpense);
            output.utilityExpense = Int32.Parse(applicantInput.utilitiesExpense);
            output.foodExpense = Int32.Parse(applicantInput.foodExpense);
            output.tuitionExpense = Int32.Parse(applicantInput.tuitionExpense);

            output.employmentType = applicantInput.employment;
            output.employer = applicantInput.employer;
            output.position = applicantInput.position;
            output.employmentStartDate = DateOnly.FromDateTime(applicantInput.startOfEmployment).ToString();

            output.employmentIncome = Int32.Parse(applicantInput.employmentIncome);
            output.spouseIncome = Int32.Parse(applicantInput.spouseIncome);
            output.donationIncome = Int32.Parse(applicantInput.donationIncome);
            output.cashSavings = Int32.Parse(applicantInput.cashSavings);



            return output;
        }

        private SpouseModel FillSpouseToSaveInfo()
        {
            SpouseModel output = new SpouseModel();

            if (applicantInput.applicantMaritalStatus == MaritalStatus.married)
            {
                output.firstName = applicantInput.spouseFirstName;
                output.lastName = applicantInput.spouseLastName;
                output.gender = applicantInput.spouseGender;
                output.birthday = DateOnly.FromDateTime(applicantInput.spouseBirthday).ToString();
                output.sinCard = applicantInput.spouseSinCard;

                output.maritalStatus = applicantInput.applicantMaritalStatus;

                output.phone = applicantInput.spousePhone;
                output.email = applicantInput.spouseEmail;
                output.isCitizen = applicantInput.spouseIsCitizen;
                output.isIndigenous = applicantInput.spouseIsIndigenous;
                output.isDisabled = applicantInput.spouseIsDisabled;


                return output;
            }

            else
            {
                return output;
            }

            
        }
    }
}
