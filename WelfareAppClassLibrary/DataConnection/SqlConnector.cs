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
        public bool CheckPassword(AgentModel agentInput, string passwordInput)
        {
            if (agentInput.password == passwordInput)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

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

        public string RetriveRequiredList(ProgramModel programInput)
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

        public void TestFunction()
        {

        }
    }
}
