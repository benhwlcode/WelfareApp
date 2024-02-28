using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelfareAppClassLibrary.Models;

namespace WelfareAppClassLibrary.DataConnection
{
    public class TestConnector
    {
        public TestModel CreateTest(TestModel model)
        {
            using (IDbConnection connection =
                new Microsoft.Data.SqlClient
                .SqlConnection(GlobalConfig.CnnString("WelfareApplication")))
            {
                var p = new DynamicParameters();
                p.Add("@test_name", model.testName);
                p.Add("test_id", 0, dbType: DbType.Int32,
                    direction: ParameterDirection.Output);

                connection.Execute("dbo.spTest_Insert", p,
                    commandType: CommandType.StoredProcedure);

                model.testId = p.Get<int>("@test_id");


            }

            return model;


        }

    }
}
