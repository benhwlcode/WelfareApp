using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class ApplicationDisplay
    {
        public ApplicationModel inputApplication { get; set; }
        public ApplicantModel inputApplicant { get; set; }

        public int Application { get { return inputApplication.applicationId; } }
        public EligibilityStatus Eligibility {get {return inputApplication.eligibilityStatus;} }
        public ApplicationProgress Progress { get { return inputApplication.applicationProgress;} }
        public ApprovalStatus Approval { get { return inputApplication.approvalStatus;} }

        public int Applicant { get { return inputApplication.applicantId; } }
        public string FirstName { get { return inputApplicant.firstName; } }
        public string LastName { get { return inputApplicant.lastName; } }

        public int Spouse
        {
            get
            {
                if (inputApplicant.spouseId != null)
                {
                    return inputApplicant.spouseId.spouseId;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string SpouseName
        {
            get
            {
                if (inputApplicant.spouseId != null)
                {
                    return $"{inputApplicant.spouseId.firstName} {inputApplicant.spouseId.lastName}";
                }
                else
                {
                    return "No Spouse";
                }
            }
        }










    }
}
