using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelfareAppClassLibrary.Validations;

namespace WelfareAppClassLibrary.Models
{
    public class SpouseModel
    {
        public int spouseId { get; set; }

        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string lastName { get; set; }

        [DisplayName("Spouse Sin Card")]
        [RegularExpression(@"^[+]?\d*$", ErrorMessage = "{0} must be numbers only.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "{0} can only be 10 digits.")]
        public string sinCard { get; set; }

        public MaritalStatus maritalStatus { get; set; }

        [CustomValidation(typeof(AdultOnly), nameof(AdultOnly.Validate),
            ErrorMessage = "Spouse must be of legal adulthood.")]
        public string birthday { get; set; }

        public GenderType gender { get; set; }

        [DisplayName("Spouse Email Address")]
        [EmailAddress(ErrorMessage = "{0} must be a valid input.")]
        public string email { get; set; }

        [DisplayName("Applicant Phone Number")]
        [Phone(ErrorMessage = "{0} must have a valid input.")]
        [MinLength(10, ErrorMessage = "{0} must be at least 10 digits.")]
        public string phone { get; set; }

        [DisplayName("Spouse Is Citizen")]
        [Required(ErrorMessage = "{0} field must not be left blank.")]
        public bool isCitizen { get; set; }

        [DisplayName("Spouse Is Indigenous")]
        [Required(ErrorMessage = "{0} field must not be left blank.")]
        public bool isIndigenous{ get; set; }

        [DisplayName("Spouse Is Disabled")]
        [Required(ErrorMessage = "{0} field must not be left blank.")]
        public bool isDisabled { get; set; }

    }
}
