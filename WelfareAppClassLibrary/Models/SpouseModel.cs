using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class SpouseModel
    {
        public int spouseId { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string sinCard { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public DateOnly birthday { get; set; }
        public GenderType gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public bool isCitizen { get; set; }
        public bool isIndigenous{ get; set; }
        public bool isDisabled { get; set; }

    }
}
