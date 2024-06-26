﻿using System;
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

        public int Id
        {
            get
            {
                return input.applicantId;
            }
        }

        public string Applicant
        {
            get
            {
                return $"{input.firstName} {input.lastName}";
            }
        }

        public string Birthday
        {
            get
            {
                return $"{input.birthday} (age {GetAge()})";
            }
        }

        public string Spouse
        {
            get
            {
                if (input.spouseId != null)
                {
                    return $"{input.spouseId.firstName} {input.spouseId.lastName}";
                }

                return "";
            }
        }

        public int Children
        {
            get
            {
                return input.numberOfChildren;
            }
        }

        public string Employment
        {
            get
            {
                return input.employmentType.ToString();
            }
        }

        public string RentExpense
        {
            get
            {
                return input.rentalExpense.ToString("C2", CultureInfo.CurrentCulture);
            }
        }

        public string WorkIncome
        {
            get
            {
                return input.employmentIncome.ToString("C2", CultureInfo.CurrentCulture);
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
