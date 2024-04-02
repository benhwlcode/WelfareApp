using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
using WelfareAppClassLibrary.Validations;

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
        List<ValidationResult> results = new List<ValidationResult>();

        ApplicationModel applicationToSave = new ApplicationModel();
        ApplicantModel applicantToSave = new ApplicantModel();
        SpouseModel spouseToSave = new SpouseModel();

        public ApplicantModel loadedApplicant = new ApplicantModel();


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
            LoadApplicantForm loadApplicantForm = new LoadApplicantForm();
            loadApplicantForm.parentCreateNewApp = this;

            loadApplicantForm.Show();
        }

        public void InitializeLists()
        {
            SqlConnector sql = new SqlConnector();

            programs = sql.GetAllPrograms();
            agents = sql.GetAllAgents();
            offices = sql.GetAllOffices();
            supervisors = sql.GetAllSupervisors();

            labelApplicantIdValue.Text = "0";
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
            documentsJson = sql.RetrieveRequiredList(selectedProgram);

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
            Logic logic = new Logic();

            applicationToSave = FillApplicationToSaveInfo();
            applicantToSave = FillApplicantToSaveInfo();
            spouseToSave = FillSpouseToSaveInfo();

            results.Clear();

            results.AddRange(ValidationHelper.Validate(applicantToSave));
            results.AddRange(ValidationHelper.Validate(spouseToSave));

            if (results.Count != 0)
            {
                Helper helper = new Helper();
                string errors = helper.TestingCheckValidation(results);
                                
                MessageBox.Show(errors);

                return;
            }


            logic.ApplicationInsertAndUpdate(labelApplicantIdValue.Text, applicationToSave,
                applicantToSave, spouseToSave, loadedApplicant);
            
        }

        private void buttonClickOldLogic()
        {
            SqlConnector sql = new SqlConnector();


            if (labelApplicantIdValue.Text == "0")
            {
                applicationToSave = FillApplicationToSaveInfo();
                applicantToSave = FillApplicantToSaveInfo();
                spouseToSave = FillSpouseToSaveInfo();

                sql.SaveToApplication(applicationToSave, applicantToSave, spouseToSave);
            }
            else
            {
                applicationToSave = FillApplicationToSaveInfo();
                applicantToSave = FillApplicantToSaveInfo();
                spouseToSave = FillSpouseToSaveInfo();

                applicantToSave.applicantId = loadedApplicant.applicantId;

                sql.SaveToApplicationWithReturner(applicationToSave, applicantToSave.applicantId);


                if (spouseToSave != null && loadedApplicant.spouseId != null)
                {
                    spouseToSave.spouseId = loadedApplicant.spouseId.spouseId;
                    sql.UpdateApplicantEntry(applicantToSave, spouseToSave);
                }
                else if (spouseToSave != null && loadedApplicant.spouseId == null)
                {
                    spouseToSave.spouseId = 0;
                    sql.UpdateApplicantEntry(applicantToSave, spouseToSave);
                }
                else
                {
                    sql.UpdateApplicantEntry(applicantToSave, spouseToSave);
                }

            }

        }

        private void buttonClickNewLogic()
        {
            SqlConnector sql = new SqlConnector();

            applicationToSave = FillApplicationToSaveInfo();
            applicantToSave = FillApplicantToSaveInfo();
            spouseToSave = FillSpouseToSaveInfo();

            if (labelApplicantIdValue.Text == "0")
            {
                sql.SaveToApplication(applicationToSave, applicantToSave, spouseToSave);
                return;
            }

            applicantToSave.applicantId = loadedApplicant.applicantId;
            
            sql.SaveToApplicationWithReturner(applicationToSave, applicantToSave.applicantId);

            if (spouseToSave != null && loadedApplicant.spouseId != null)
            {
                spouseToSave.spouseId = loadedApplicant.spouseId.spouseId;
            }

            if (spouseToSave != null && loadedApplicant.spouseId == null)
            {
                spouseToSave.spouseId = 0;
            }

            sql.UpdateApplicantEntry(applicantToSave, spouseToSave);

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

            if (applicantInput.applicantMaritalStatus == MaritalStatus.Married)
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
                output = null;
                return output;
            }

            
        }

        public void LoadApplicantAndSpouseInfo()
        {
            labelApplicantIdValue.Text = loadedApplicant.applicantId.ToString();

            applicantInput.applicantFirstName = loadedApplicant.firstName;
            applicantInput.applicationlicantLastName = loadedApplicant.lastName;
            applicantInput.applicantGender = loadedApplicant.gender;
            applicantInput.applicantBirthday = DateTime.Parse(loadedApplicant.birthday);
            applicantInput.applicantSinCard = loadedApplicant.sinCard;
            applicantInput.applicantMaritalStatus = loadedApplicant.maritalStatus;
            applicantInput.applicantPhone = loadedApplicant.phone;
            applicantInput.applicantEmail = loadedApplicant.email;
            applicantInput.applicantIsCitizen = loadedApplicant.isCitizen;
            applicantInput.applicantIsIndigenous = loadedApplicant.isIndigenous;
            applicantInput.applicantIsDisabled = loadedApplicant.isDisabled;

            if (loadedApplicant.spouseId != null)
            {
                applicantInput.spouseFirstName = loadedApplicant.spouseId.firstName;
                applicantInput.spouseLastName = loadedApplicant.spouseId.lastName;
                applicantInput.spouseGender = loadedApplicant.spouseId.gender;
                applicantInput.spouseBirthday = DateTime.Parse(loadedApplicant.spouseId.birthday);
                applicantInput.spouseSinCard = loadedApplicant.spouseId.sinCard;
                applicantInput.applicantMaritalStatus = loadedApplicant.spouseId.maritalStatus;
                applicantInput.spousePhone = loadedApplicant.spouseId.phone;
                applicantInput.spouseEmail = loadedApplicant.spouseId.email;
                applicantInput.spouseIsCitizen = loadedApplicant.spouseId.isCitizen;
                applicantInput.spouseIsIndigenous = loadedApplicant.spouseId.isIndigenous;
                applicantInput.spouseIsDisabled = loadedApplicant.spouseId.isDisabled;
            }

            applicantInput.residence = loadedApplicant.residenceStatus;
            applicantInput.address = loadedApplicant.streetAddress;
            applicantInput.city = loadedApplicant.city;
            applicantInput.province = loadedApplicant.province;
            applicantInput.moveInDate = DateTime.Parse(loadedApplicant.moveInDate);

            applicantInput.familySize = loadedApplicant.familySize.ToString();
            applicantInput.numberOfAdults = loadedApplicant.numberOfAdults.ToString();
            applicantInput.numberOfChildren = loadedApplicant.numberOfChildren.ToString();
            applicantInput.numberOfElderly = loadedApplicant.numberOfElderly.ToString();

            applicantInput.rentExpense = loadedApplicant.rentalExpense.ToString();
            applicantInput.utilitiesExpense = loadedApplicant.utilityExpense.ToString();
            applicantInput.foodExpense = loadedApplicant.foodExpense.ToString();
            applicantInput.tuitionExpense = loadedApplicant.tuitionExpense.ToString();

            applicantInput.employment = loadedApplicant.employmentType;
            applicantInput.employer = loadedApplicant.employer;
            applicantInput.position = loadedApplicant.position;
            applicantInput.startOfEmployment = DateTime.Parse(loadedApplicant.employmentStartDate);

            applicantInput.employmentIncome = loadedApplicant.employmentIncome.ToString();
            applicantInput.spouseIncome = loadedApplicant.spouseIncome.ToString();
            applicantInput.donationIncome = loadedApplicant.donationIncome.ToString();
            applicantInput.cashSavings = loadedApplicant.cashSavings.ToString();



        }
    }
}
