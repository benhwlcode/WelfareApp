using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class ListPeopleDisplay
    {
        public ApplicantModel input {  get; set; }

        public int ApplicantId
        {
            get
            {
                return input.applicantId;
            }
        }

        public string ApplicantName
        {
            get
            {
                return $"{input.firstName} {input.lastName}";
            }
        }

        public string SpouseName
        {
            get
            {
                if (input.spouseId != null)
                {
                    return $"{input.spouseId.firstName} {input.spouseId.lastName}";
                }

                return "no spouse";
            }
        }

        public string TestValue
        {
            get
            {
                string output = $"{input.employmentType}, age {GetAge()}, " +
                    $"with {input.numberOfChildren} children";

                return output;
            }
        }

        public string GetAge()
        {
            DateTime birthday = DateTime.ParseExact(input.birthday, "yyyy-MM-dd",
                        CultureInfo.InvariantCulture);
            DateTime today = DateTime.Now;
            int age = today.Year - birthday.Year;

            if (birthday.Month > today.Month)
            {
                return age.ToString();
            }
            if (birthday.Month == today.Month && birthday.Day >= today.Day)
            {
                return age.ToString();
            }

            return (age - 1).ToString();
        }

    }
}
