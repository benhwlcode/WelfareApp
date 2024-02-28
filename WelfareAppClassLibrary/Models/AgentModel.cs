using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class AgentModel
    {
        public int agentId { get; set; }
        public int agentCode { get; set; }

        public string agentFirstName { get; set; }
        public string agentLastName { get; set; }

        public string agentLogin { get; set; }
        public string agentPassword { get; set; }

        // insert other non essential information


    }
}
