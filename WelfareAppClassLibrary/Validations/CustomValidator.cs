using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Validations
{
    
    public class AdultOnly : ValidationAttribute
    {
        public static string ErrorMessage { get; set; } = string.Empty;

        public static ValidationResult? Validate(DateTime date)
        {
            ErrorMessage ??= "Applicant must be at least 18 years old.";

            DateTime currentDate = DateTime.Today.AddYears(-18);

            if (currentDate < date)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;

        }
    }

    public class FamilyMemberTotal : ValidationAttribute
    {
        public FamilyMemberTotal(string adultInput, string childInput, string elderlyInput)
        {
            _adultInput = adultInput;
            _childInput = childInput;
            _elderInput = elderlyInput;
        }

        private readonly string _adultInput;
        private readonly string _childInput;
        private readonly string _elderInput;

        protected override ValidationResult? IsValid(object? value, ValidationContext vc)
        {
            if (value != null)
            {
                int currentValue = (int)value;
                PropertyInfo? pAdult = vc.ObjectType.GetProperty(_adultInput);
                PropertyInfo? pChild = vc.ObjectType.GetProperty(_childInput);
                PropertyInfo? pElder = vc.ObjectType.GetProperty(_elderInput);
                object? compAdult = pAdult?.GetValue(vc.ObjectInstance, null);
                object? compChild = pChild?.GetValue(vc.ObjectInstance, null);
                object? compElder = pElder?.GetValue(vc.ObjectInstance, null);
                string displayName = vc.DisplayName;

                if(compAdult != null && compChild != null && compElder != null)
                {
                    if (currentValue != (int)compAdult + (int)compChild + (int)compElder)
                    {
                        if (string.IsNullOrEmpty(ErrorMessage))
                        {
                            ErrorMessage = $"The total number of {displayName} must " +
                                $"be the combined sum of all adult, children, and elderly members.";
                        }


                        return new ValidationResult(ErrorMessage,
                            new[] { vc.MemberName ?? "UnknownProperty" });
                    }
                }


            }

            return ValidationResult.Success;

        }

       
            
    }

    public class NoFutureDateAttribute : ValidationAttribute
    {


        public NoFutureDateAttribute()
        {

        }

        
        protected override ValidationResult? IsValid(object? value, ValidationContext vc)
        {

            DateTime chosenDate = DateTime.ParseExact((string)value, "yyyy-MM-dd", 
                System.Globalization.CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.Today;

            string displayName = vc.DisplayName;

            if (chosenDate > currentDate)
            {
                if (string.IsNullOrEmpty(ErrorMessage))
                {
                    ErrorMessage = $"{displayName} must be before " +
                        $"the current date of {currentDate:yyyy/MM/dd}.";

                }

                return new ValidationResult(ErrorMessage,
                        new[] { vc.MemberName ?? "UnknownProperty" });
            }

            return ValidationResult.Success;
        }



    }

}
