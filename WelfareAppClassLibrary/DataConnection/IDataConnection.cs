using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelfareAppClassLibrary.Models;

namespace WelfareAppClassLibrary.DataConnection
{
    public interface IDataConnection
    {
        public List<ProgramModel> GetAllPrograms();
        public List<AgencyModel> GetAllAgencies();
        public List<AgentModel> GetAllAgents();
        public List<OfficeModel> GetAllOffices();
        public List<SupervisorModel> GetAllSupervisors();
        public List<ApplicantModel> GetAllApplicants();

        public AgentModel GetAgent(string userinput);

        public void SaveToProgram (ProgramModel programModel);
        public void SaveToApplication(ApplicationModel applicationModel, 
            ApplicantModel applicantModel, SpouseModel spouseModel);
        public void SaveToApplicationWithReturner(ApplicationModel applicationModel, int applicantId);
        public int SaveToApplicant(ApplicantModel applicantModel, SpouseModel spouseModel);
        public int SaveToSpouse(SpouseModel spouseModel);

        public void UpdateApplicantEntry(ApplicantModel applicantModel, SpouseModel spouseModel);
        public void UpdateSpouseEntry(SpouseModel spouseModel);



        public string RetrieveRequiredList(ProgramModel programModel);

        public List<ApplicationModel> GetAllApplications(int programId);

        public string GetDocuments(int applicationId);

        public void UpdateApplication(ApplicationModel applicationModel);

        public void UpdateEligibility(int programIdInput, string conditionInput);

        public void ResetEligibility(int programIdInput);

        public List<ApplicationModel> ListAllApplications();

        public string GetProgramName(int appIdInput);

        public string GetAgencyName(int appIdInput);
        public string GetAgentName(int appIdInput);
        public string GetOfficeName(int appIdInput);
        public string GetSupervisorName(int appIdInput);

        public List<ApplicationModel> GetAppsAdults();
        public List<ApplicantModel> GetPeopleAdults();

        public List<ApplicationModel> GetAppsElderly();
        public List<ApplicantModel> GetPeopleElderly();

        public List<ApplicationModel> GetAppsSingle();
        public List<ApplicantModel> GetPeopleSingle();

        public List<ApplicationModel> GetAppsMarried();
        public List<ApplicantModel> GetPeopleMarried();

        public List<ApplicationModel> GetAppsEmployed();
        public List<ApplicantModel> GetPeopleEmployed();

        public List<ApplicationModel> GetAppsUnemployed();
        public List<ApplicantModel> GetPeopleUnemployed();

        public List<ApplicationModel> GetAppsWithChildren();
        public List<ApplicantModel> GetPeopleWithChildren ();

        public List<ApplicationModel> GetAppsWithoutChildren();
        public List<ApplicantModel> GetPeopleWithoutChildren();



    }
}
