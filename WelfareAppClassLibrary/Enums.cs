using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary
{
    public enum ApplicationProgress { ongoing, closed, completed }
    public enum EligibilityStatus { pending, eligible, ineligible }
    public enum ApprovalStatus { pending, approved, rejected }
    public enum PaymentStatus { pending, sent, received }

    public enum ProgramStatus { open, closed, paused }
    public enum PaymentForm { cash, wire, cheque, chargeup }
    public enum PaymentType { flat, percentage }

    public enum AgencyType { welfare, medical, food, tuition }
    public enum AgencyJurisdiction { global, federal, provincial, city }

    public enum DocumentStatus { waiting, received, checking, approved }

    public enum GenderType { Male, Female, Undisclosed, Other }
    public enum MaritalStatus { Single, Married, Divorced, Widowed }
    public enum ProvinceName { AB, BC, MB, NB, NL, NS, NT, NU, ON, PR, SK, QC, YT, }
    public enum ResidenceStatus { homeowner, mortgaging, renting, guest }
    public enum EmploymentType { fulltime, parttime, unemployed, freelance, contractor, retired, none }

    public enum ApplicantSpouse { applicant, spouse}
    public enum QueryProperty 
        { 
        rentalexpense, utilityexpense, foodexpense, tuitionexpense,
        iscitizen, isindigenous, isdisabled, 
        numberofchildren, numberofelderly, 
        employmenttype, employmentincome, spouseincome, donationincome, cashsavings,
        spouseId
        }
    public enum TrueFalse { False, True }

    public enum AgeFilter { All, Adult, Elderly, Both}

}
