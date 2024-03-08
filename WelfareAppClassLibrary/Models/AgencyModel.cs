using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class AgencyModel
    {
        public int agencyId { get; set; }
        public string agencyCode { get; set; }

        public string agencyName { get; set; }

        public AgencyType agencyType { get; set; }
        public AgencyJurisdiction agencyJurisdiction { get; set;}

        // insert other non essential information

    }
}
