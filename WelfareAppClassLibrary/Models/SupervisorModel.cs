using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class SupervisorModel
    {
        public int supervisorId { get; set; }

        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string lastName { get; set; }

        public string display
        {
            get
            {
                return $"{firstName} {lastName} ({supervisorId})";
            }
        }

        // insert other non essential information


    }
}
