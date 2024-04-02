using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class ApplicationDisplay
    {
        public ApplicationModel application { get; set; }
        public ApplicantModel applicant { get; set; }

        public int Application { get { return application.applicationId; } }
        public EligibilityStatus Eligibility {get {return application.eligibilityStatus;} }
        public ApplicationProgress Progress { get { return application.applicationProgress;} }

        public int Applicant { get { return applicant.applicantId; } }
        public string FirstName { get { return applicant.firstName; } }
        public string LastName { get { return applicant.lastName; } }

        public int Spouse { get { return applicant.spouseId.spouseId; } }   
        public string SpouseName 
        { get { return $"{applicant.spouseId.firstName} {applicant.spouseId.lastName}"; } }









    }
}
