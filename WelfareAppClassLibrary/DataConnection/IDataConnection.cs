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

        public AgentModel GetAgent(string userinput);
        public bool CheckPassword(AgentModel agentInput, string passwordInput);

        public void SaveToProgram (ProgramModel model);

              
    }
}
