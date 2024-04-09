using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelfareAppClassLibrary.DataConnection;

namespace WelfareAppClassLibrary.Models
{
    public class ListAppsDisplay
    {
        public ApplicationModel input {  get; set; }

        public int ApplicationId
        {
            get
            {
                return input.applicationId;
            }
        }

        public string AppliedProgram { get; set; }
        public string ManagingAgency { get; set; }
        public string ReceivedByAgent { get; set; }
        public string ReceivedByOffice { get; set; }    
        public string SupervisorName { get; set; }
        public string ApplicantName
        {
            get
            {
                return $"{input.applicant.firstName} {input.applicant.lastName}";
            }
        }



    }
}
