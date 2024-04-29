using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelfareAppClassLibrary.Validations;

namespace WelfareAppClassLibrary.Models
{
    public class ApplicantModel
    {
        public int applicantId { get; set; }

        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string lastName { get; set; }

        [DisplayName("Applicant Sin Card")]
        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "{0} can only be 10 digits.")]
        public string sinCard { get; set; }

        public MaritalStatus maritalStatus { get; set; }

        [CustomValidation(typeof(AdultOnly), nameof(AdultOnly.Validate),
            ErrorMessage = "Only adults can submit application")]
        public string birthday { get; set; }

        public GenderType gender { get; set; }

        [DisplayName("Applicant Email Address")]
        [EmailAddress(ErrorMessage = "{0} must be a valid input.")]
        public string email { get; set; }

        [DisplayName("Applicant Phone Number")]
        [Phone(ErrorMessage = "{0} must have a valid input.")]
        [MinLength(10, ErrorMessage = "{0} must be at least 10 digits.")]
        public string phone { get; set; }

        [DisplayName("Applicant Is Citizen")]
        [Required(ErrorMessage = "{0} field must not be left blank.")]
        public bool isCitizen { get; set; }

        [DisplayName("Applicant Is Indigenous")]
        [Required(ErrorMessage = "{0} field must not be left blank.")]
        public bool isIndigenous { get; set; }

        [DisplayName("Applicant Is Disabled")]
        [Required(ErrorMessage = "{0} field must not be left blank.")]
        public bool isDisabled { get; set; }


        public SpouseModel spouseId { get; set; }
               

        public ResidenceStatus residenceStatus { get; set; }

        [MaxLength(50)]
        public string streetAddress { get; set; }

        [MaxLength(50)]
        public string city { get; set; }

        public ProvinceName province { get; set; }

        [DisplayName("Move In Date")]
        [NoFutureDate]
        public string moveInDate { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        [FamilyMemberTotal(nameof(ApplicantModel.numberOfAdults), 
            nameof(ApplicantModel.numberOfChildren), nameof(ApplicantModel.numberOfElderly))]
        public int familySize { get; set; }

        
        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public int numberOfAdults { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public int numberOfChildren { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public int numberOfElderly { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double rentalExpense { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double utilityExpense { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double foodExpense { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double tuitionExpense { get; set; }

        public EmploymentType employmentType { get; set; }

        [MaxLength(50)]
        public string employer { get; set; }

        [MaxLength(50)]
        public string position { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double employmentIncome { get; set; }

        [DisplayName("Employment Start/Latest Date")]
        [NoFutureDate]
        public string employmentStartDate { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double spouseIncome { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double donationIncome { get; set; }

        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        public double cashSavings { get; set; }


        public string CustomDisplay
        {
            get
            {
                return $"{this.firstName} {this.lastName}: {this.sinCard}";
            }
        }




    }
}
