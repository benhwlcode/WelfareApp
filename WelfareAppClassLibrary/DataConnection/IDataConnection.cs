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

              
    }
}
