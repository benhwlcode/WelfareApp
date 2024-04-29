using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace WelfareAppClassLibrary.Validations
{
    public static class InputValidation
    {
        public static string ValidLength(string input)
        {
            if (input.Trim().Length < 1)
            {
                return "Field must have at least 1 character.";
            }

            if (input.Length > 50)
            {
                return "Field must be within 50 characters or less.";
            }

            return null;
        }

        /*public static string ValidNameInput(string input)
        {
            Regex regex = new Regex("^[a-zA-Z0-9\\s\\'\\-]*$");

            string lengthCheck = ValidLength(input);

            if(lengthCheck != null)
            {
                return lengthCheck;
            }

            if (!regex.IsMatch(input))
            {
                return "Field only accepts ' and - as special characters.";
            }

            return null;
        }*/

        /*public static string ValidSpecialNameInput(string input)
        {
            Regex regex = new Regex("^[a-zA-Z0-9\\s\\'\\-\\,\\.\\\"]*$");

            string lengthCheck = ValidLength(input);

            if (lengthCheck != null)
            {
                return lengthCheck;
            }

            if (!regex.IsMatch(input))
            {
                return "Field only accepts the following special characters: , . ' - \".";
            }

            return null;
        } */

        public static string MustBeNumber(string input)
        {
            if (!Double.TryParse(input, out double result))
            {
                return "Field must only be numbers.";
            }

            return null;
        }

        public static string MustBeTenDigits(string input)
        {

            if (MustBeNumber(input) != null)
            {
                if (input.Length > 10)
                {
                    return "Field must be 10 digits.";
                }

                return "Field must only be numbers.";
            }

            if (input.Length != 10)
            {
                return "Field must be 10 digits.";
            }

            return null;

        }

        public static string ValidPhoneNumber(string input)
        {
            Phone phone = new Phone();
            phone.PhoneNumber = input;

            List<ValidationResult> results = ValidationHelper.Validate(phone);

            if (results.Count != 0)
            {
                return "Must be a valid phone number.";
            }

            return null;
        }

        public static string ValidEmailAddress(string input)
        {
            Email email = new Email();
            email.EmailAddress = input;

            List<ValidationResult > results = ValidationHelper.Validate(email);

            if (results.Count != 0)
            {
                return "Must be a valid email address";
            }

            return null;
        }

        public static string TotalFamilySize(string familySize, string adultNumber,
            string childNumber, string elderlyNumber)
        {
            if (MustBeNumber(familySize) != null)
            {
                return "Field must only be numbers.";
            }

            int total = 0;
            Int32.TryParse(familySize, out total);

            int adults = 0;
            Int32.TryParse(adultNumber, out adults);

            int children = 0;
            Int32.TryParse(childNumber, out children);

            int elderly = 0;
            Int32.TryParse(elderlyNumber, out elderly);

            if (adults + children + elderly != total)
            {
                return "Family size must match the total of members within.";
            }

            return null;
        }

        public static string OnlyTwoDecimals(string input)
        {

            string[] sets = input.Split('.');

            for (int i = 0; i < sets.Length; i++)
            {
                if (MustBeNumber(sets[i]) != null)
                {
                    return "Field must only be numbers.";
                }
            }

            if (sets.Length > 2)
            {
                return "Field can only have one decimal point.";
            }

            if (sets.Length == 2 && sets[1].Length > 2)
            {
                return "Field can only have two digits behind the decimal point.";
            }


            return null;
        }

        public static string NoFutureDates(DateTime input)
        {
            if (input > DateTime.Now)
            {
                return "Date selection must be prior to present date.";
            }

            return null;
        }

        public static string AdultsOnly(DateTime input)
        {
            if (NoFutureDates(input) != null)
            {
                return "Date selection must be prior to present date.";
            }

            if (input > DateTime.Now.AddYears(-18))
            {
                return "Date selection must be at least 18 years old.";
            }

            return null;

        }

    }

    public class Phone
    {
        [Phone()]
        public string PhoneNumber { get; set; }
    }

    public class Email
    {
        [EmailAddress()]
        public string EmailAddress
        {
            get; set;
        }

    }
}
