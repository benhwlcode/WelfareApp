﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class ApplicantModel
    {
        public int applicantId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string sinCard { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public string birthday { get; set; }
        public GenderType gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public bool isCitizen { get; set; }
        public bool isIndigenous { get; set; }
        public bool isDisabled { get; set; }


        public SpouseModel spouseId { get; set; }
               

        public ResidenceStatus residenceStatus { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public ProvinceName province { get; set; }
        public string moveInDate { get; set; }

        public int familySize { get; set; }
        public int numberOfAdults { get; set; }
        public int numberOfChildren { get; set; }
        public int numberOfElderly { get; set; }

        public double rentalExpense { get; set; }
        public double utilityExpense { get; set; }
        public double foodExpense { get; set; }
        public double tuitionExpense { get; set; }

        public EmploymentType employmentType { get; set; }
        public string employer { get; set; }
        public string position { get; set; }
        public double employmentIncome { get; set; }
        public string employmentStartDate { get; set; }

        public double spouseIncome { get; set; }
        public double donationIncome { get; set; }
        public double cashSavings { get; set; }







    }
}