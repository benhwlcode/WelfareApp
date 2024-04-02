using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class AgentModel
    {
        public int agentId { get; set; }

        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string lastName { get; set; }

        [MaxLength(50)]
        public string login { get; set; }

        [MaxLength(50)]
        public string password { get; set; }

        // insert other non essential information


    }
}
