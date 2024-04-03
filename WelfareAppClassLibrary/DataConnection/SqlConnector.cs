using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using WelfareAppClassLibrary.Models;

namespace WelfareAppClassLibrary.DataConnection
{
    public class SqlConnector : IDataConnection
    {        
        public AgentModel GetAgent(string userInput)
        {
            AgentModel output = new AgentModel();



            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var p = new { login = userInput };

                var selected = connection.Query<AgentModel>("dbo.spAgent_GetUserInfo @login", 
                    p).ToList();
                output = selected[0];


                return output;
            }

                
        }

        public List<AgencyModel> GetAllAgencies()
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var output = connection.Query<AgencyModel>("dbo.spAgency_GetAll").ToList();

                return output;
            }
        }

        public List<AgentModel> GetAllAgents()
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var output = connection.Query<AgentModel>("dbo.spAgent_GetAll").ToList();

                return output;
            }
        }

        public List<OfficeModel> GetAllOffices()
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var output = connection.Query<OfficeModel>("dbo.spOffice_GetAll").ToList();

                return output;
            }
        }

        public List<ProgramModel> GetAllPrograms()
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var output = connection.Query<ProgramModel>("dbo.spProgram_GetAll").ToList();

                return output;
            }
        }

        public List<SupervisorModel> GetAllSupervisors()
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var output = connection.Query<SupervisorModel>("dbo.spSupervisor_GetAll").ToList();

                return output;
            }
        }

        public List<ApplicantModel> GetAllApplicants()
        {
            List<ApplicantModel> output = new List<ApplicantModel>();

            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                string sql = $"dbo.spApplicant_ReturnAll";


                var selected = connection.Query<ApplicantModel, SpouseModel, ApplicantModel>(sql,
                    (app, spo) => { app.spouseId = spo; return app; },
                    splitOn: "spouseId");

                foreach (var p in selected)
                {                    
                    output.Add(p);
                }

                return output;
            }                          
            
        }

        public List<ApplicationModel> GetAllApplications(int programId)
        {
            List<ApplicationModel> output = new List<ApplicationModel>();


            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                string sql = "dbo.spApplication_ReturnAll @programId";

                var id = new {programId = programId};


                var selected = connection.Query<ApplicationModel, ApplicantModel, SpouseModel,
                    ApplicationModel>(sql, (app, ap, spo) => 
                    { app.applicantId = ap.applicantId;  app.applicant = ap;
                        app.applicant.spouseId = spo;  return app; }, id,
                        splitOn: "applicantId, spouseId");



                /*var selected = connection.Query<ApplicationModel, ApplicantModel, SpouseModel,
                    ApplicationModel>(sql, (app, ap, spo) =>
                    { app.applicantId = ap.applicantId, ap.spouseId = spo; return app; },
                    splitOn: "applicantId", "spouseId");*/

                foreach (var p in selected)
                {
                    output.Add(p);
                }

                return output;

            }
        }

        public void SaveToProgram(ProgramModel model)
        {


            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var p = new
                {
                    programName = model.programName,
                    programStatus = model.programStatus,
                    agencyId = model.agencyId,
                    agentId = model.agentId,
                    officeId = model.officeId,
                    supervisorId = model.supervisorId,
                    paymentForm = model.paymentForm,
                    paymentType = model.paymentType,                    
                    minPayment = model.minPayment,
                    maxPayment = model.maxPayment,
                    listOfDocuments = model.listOfDocuments
                };

                connection.Execute($"dbo.spProgram_Insert @programName, @programStatus, " +
                    $"@agencyId, @agentId, @officeId, @supervisorId, " +
                    $"@paymentForm, @paymentType, @minPayment, @maxPayment, " +
                    $"@listOfDocuments", p);
            }
        }

        public void SaveToApplication(ApplicationModel applicationModel, 
            ApplicantModel applicantModel, SpouseModel spouseModel)
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                int applicantIdGet = SaveToApplicant(applicantModel, spouseModel);

                var p = new
                {
                    programId = applicationModel.programId,
                    applicantId = applicantIdGet,
                    agentId = applicationModel.agentId,
                    officeId = applicationModel.officeId,
                    supervisorId = applicationModel.supervisorId,
                    applicationProgress = applicationModel.applicationProgress,
                    eligibilityStatus = applicationModel.eligibilityStatus,
                    approvalStatus = applicationModel.approvalStatus,
                    paymentStatus = applicationModel.paymentStatus,
                    signatureSigned = applicationModel.signatureSigned,
                    acceptedDate = applicationModel.acceptedDate,
                    listOfDocuments = applicationModel.listOfDocuments,
                };

                connection.Execute($"dbo.spApplication_Insert @programId, @applicantId, @agentId, " +
                    $"@officeId, @supervisorId, @applicationProgress, @eligibilityStatus, " +
                    $"@approvalStatus, @paymentStatus, @signatureSigned, @acceptedDate, " +
                    $"@listOfDocuments", p);

                //TODO this


            }
        }


        public int SaveToApplicant(ApplicantModel applicantModel, SpouseModel spouseModel)
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                int spouseIdGet = 0;

                if (spouseModel != null)
                {
                    spouseIdGet = SaveToSpouse(spouseModel);
                }
                

                var p = new
                {
                    firstName = applicantModel.firstName,
                    lastName = applicantModel.lastName,
                    gender = applicantModel.gender,
                    birthday = applicantModel.birthday,
                    sinCard = applicantModel.sinCard,
                    maritalStatus = applicantModel.maritalStatus,
                    email = applicantModel.email,
                    phone = applicantModel.phone,
                    isCitizen = applicantModel.isCitizen,
                    isIndigenous = applicantModel.isIndigenous,
                    isDisabled = applicantModel.isDisabled,
                    spouseId = spouseIdGet,
                    residenceStatus = applicantModel.residenceStatus,
                    streetAddress = applicantModel.streetAddress,
                    city = applicantModel.city,
                    province = applicantModel.province,
                    moveInDate = applicantModel.moveInDate,
                    familySize = applicantModel.familySize,
                    numberOfAdults = applicantModel.numberOfAdults,
                    numberOfChildren = applicantModel.numberOfChildren, 
                    numberOfElderly = applicantModel.numberOfElderly,
                    rentalExpense = applicantModel.rentalExpense,
                    utilityExpense = applicantModel.utilityExpense,
                    foodExpense = applicantModel.foodExpense,
                    tuitionExpense = applicantModel.tuitionExpense,
                    employmentType = applicantModel.employmentType,
                    employer = applicantModel.employer,
                    position = applicantModel.position,
                    employmentStartDate = applicantModel.employmentStartDate,
                    employmentIncome = applicantModel.employmentIncome,
                    spouseIncome = applicantModel.spouseIncome,
                    donationIncome = applicantModel.donationIncome,
                    cashSavings = applicantModel.cashSavings
                };

                int output = connection.QuerySingle<int>($"dbo.spApplicant_InsertAndGetId @firstName, " +
                    $"@lastName, @gender, @birthday, @sinCard, @maritalStatus, @email, @phone, " +
                    $"@isCitizen, @isIndigenous, @isDisabled, @spouseId, @residenceStatus, " +
                    $"@streetAddress, @city, @province, @moveInDate, @familySize, @numberOfAdults, " +
                    $"@numberOfChildren, @numberOfElderly, @rentalExpense, @utilityExpense, " +
                    $"@foodExpense, @tuitionExpense, @employmentType, @employer, @position, " +
                    $"@employmentStartDate, @employmentIncome, @spouseIncome, @donationIncome, " +
                    $"@cashSavings", p);

                return output;


            }
        }

        public int SaveToSpouse(SpouseModel spouseModel)
        {

            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var p = new
                {
                    firstName = spouseModel.firstName,
                    lastName = spouseModel.lastName,
                    sinCard = spouseModel.sinCard,
                    maritalStatus = spouseModel.maritalStatus,
                    birthday = spouseModel.birthday,
                    gender = spouseModel.gender,
                    email = spouseModel.email,
                    phone = spouseModel.phone,
                    isCitizen = spouseModel.isCitizen,
                    isIndigenous = spouseModel.isIndigenous,
                    isDisabled = spouseModel.isDisabled
                };

                int output = connection.QuerySingle<int>($"dbo.spSpouse_InsertAndGetId @firstName, " +
                    $"@lastName, @sinCard, @maritalStatus, @birthday, @gender, @email, @phone, " +
                    $"@isCitizen, @isIndigenous, @isDisabled", p);

                return output;
            }

        }

        public string RetrieveRequiredList(ProgramModel programInput)
        {
            List<ProgramModel> selectedProgram = new List<ProgramModel>();
            var p = new
            {
                programId = programInput.programId
            };


            string output = "";

            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                selectedProgram = connection.Query<ProgramModel>($"dbo.spProgram_GetProgramById " +
                    $"@programId", p).ToList();
            }

            output = selectedProgram[0].listOfDocuments;
            return output;

        }

        public void UpdateApplicantEntry(ApplicantModel applicantModel, SpouseModel spouseModel)
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                int spouseGetId;

                if (spouseModel != null && spouseModel.spouseId != 0)
                {
                    spouseGetId = spouseModel.spouseId;
                    UpdateSpouseEntry(spouseModel);
                }
                else if (spouseModel != null && spouseModel.spouseId == 0)
                {
                    spouseGetId = SaveToSpouse(spouseModel);
                }
                else
                {
                    spouseGetId = 0;
                }

                var p = new
                {
                    applicantId = applicantModel.applicantId,
                    firstName = applicantModel.firstName,
                    lastName = applicantModel.lastName,
                    gender = applicantModel.gender,
                    birthday = applicantModel.birthday,
                    sinCard = applicantModel.sinCard,
                    maritalStatus = applicantModel.maritalStatus,
                    email = applicantModel.email,
                    phone = applicantModel.phone,
                    isCitizen = applicantModel.isCitizen,
                    isIndigenous = applicantModel.isIndigenous,
                    isDisabled = applicantModel.isDisabled,
                    spouseId = spouseGetId,
                    residenceStatus = applicantModel.residenceStatus,
                    streetAddress = applicantModel.streetAddress,
                    city = applicantModel.city,
                    province = applicantModel.province,
                    moveInDate = applicantModel.moveInDate,
                    familySize = applicantModel.familySize,
                    numberOfAdults = applicantModel.numberOfAdults,
                    numberOfChildren = applicantModel.numberOfChildren,
                    numberOfElderly = applicantModel.numberOfElderly,
                    rentalExpense = applicantModel.rentalExpense,
                    utilityExpense = applicantModel.utilityExpense,
                    foodExpense = applicantModel.foodExpense,
                    tuitionExpense = applicantModel.tuitionExpense,
                    employmentType = applicantModel.employmentType,
                    employer = applicantModel.employer,
                    position = applicantModel.position,
                    employmentStartDate = applicantModel.employmentStartDate,
                    employmentIncome = applicantModel.employmentIncome,
                    spouseIncome = applicantModel.spouseIncome,
                    donationIncome = applicantModel.donationIncome,
                    cashSavings = applicantModel.cashSavings
                };

                connection.Execute($"dbo.spApplicant_UpdateEntry @applicantId, @firstName, " +
                    $"@lastName, @gender, @birthday, @sinCard, @maritalStatus, @email, @phone, " +
                    $"@isCitizen, @isIndigenous, @isDisabled, @spouseId, @residenceStatus, " +
                    $"@streetAddress, @city, @province, @moveInDate, @familySize, @numberOfAdults, " +
                    $"@numberOfChildren, @numberOfElderly, @rentalExpense, @utilityExpense, " +
                    $"@foodExpense, @tuitionExpense, @employmentType, @employer, @position, " +
                    $"@employmentStartDate, @employmentIncome, @spouseIncome, @donationIncome, " +
                    $"@cashSavings", p);


            }
        }

        public void UpdateSpouseEntry(SpouseModel spouseModel)
        {
                using (IDbConnection connection =
                    new Microsoft.Data.SqlClient
                    .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
                {
                    var p = new
                    {
                        spouseId = spouseModel.spouseId,
                        firstName = spouseModel.firstName,
                        lastName = spouseModel.lastName,
                        sinCard = spouseModel.sinCard,
                        maritalStatus = spouseModel.maritalStatus,
                        birthday = spouseModel.birthday,
                        gender = spouseModel.gender,
                        email = spouseModel.email,
                        phone = spouseModel.phone,
                        isCitizen = spouseModel.isCitizen,
                        isIndigenous = spouseModel.isIndigenous,
                        isDisabled = spouseModel.isDisabled
                    };

                    connection.Execute($"dbo.spSpouse_UpdateEntry @spouseId, @firstName, " +
                    $"@lastName, @sinCard, @maritalStatus, @birthday, @gender, @email, @phone, " +
                    $"@isCitizen, @isIndigenous, @isDisabled", p);

                }
        }

        public void SaveToApplicationWithReturner(ApplicationModel applicationModel, int applicantId)
        {

            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {

                int applicantIdGet = applicantId;

                var p = new
                {
                    programId = applicationModel.programId,
                    applicantId = applicantIdGet,
                    agentId = applicationModel.agentId,
                    officeId = applicationModel.officeId,
                    supervisorId = applicationModel.supervisorId,
                    applicationProgress = applicationModel.applicationProgress,
                    eligibilityStatus = applicationModel.eligibilityStatus,
                    approvalStatus = applicationModel.approvalStatus,
                    paymentStatus = applicationModel.paymentStatus,
                    signatureSigned = applicationModel.signatureSigned,
                    acceptedDate = applicationModel.acceptedDate,
                    listOfDocuments = applicationModel.listOfDocuments,
                };

                connection.Execute($"dbo.spApplication_Insert @programId, @applicantId, @agentId, " +
                    $"@officeId, @supervisorId, @applicationProgress, @eligibilityStatus, " +
                    $"@approvalStatus, @paymentStatus, @signatureSigned, @acceptedDate, " +
                    $"@listOfDocuments", p);
            }
        }

        public string GetDocuments(int applicationId)
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                string output = "";

                var p = new { applicationId = applicationId };


                output = connection.QuerySingle<string>($"dbo.spApplication_GetListOfDocuments " +
                    $"@applicationId", p);

                return output;

            }
        }
    }
}
