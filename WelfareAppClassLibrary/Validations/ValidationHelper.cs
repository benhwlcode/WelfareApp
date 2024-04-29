using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Validations
{
    public static class ValidationHelper
    {
        public static List<ValidationResult> Validate<T>(T input) where T : class
        {           


            List<ValidationResult> output = new List<ValidationResult>();

            if (input == null)
            {
                return output;
            }

            ValidationContext context = new(input);
            Validator.TryValidateObject(input, context, output, true);


            return output;
        }
        public class ValidationMessage
        {
            public string PropertyName { get; set; } = string.Empty;
            public string ErrorMessage { get; set; } = string.Empty;

            public override string ToString()
            {
                return $"{ErrorMessage}";
            }
        }


    }
}
