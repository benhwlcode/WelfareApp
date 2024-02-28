using System;
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
        public int applicantCode { get; set; }

        public string applicantFirstName { get; set; }
        public string applicantLastName { get; set; }
        public int applicantSinCardNumber { get; set; }
        public MaritalStatus applicantMaritalStatus { get; set; }
        public DateOnly applicantBirthday { get; set; }
        public GenderType applicantGender { get; set; }
        public string applicantEmail { get; set; }
        public string applicantPhoneNumber { get; set; }

        public bool applicantIsCanadianResidence { get; set; }
        public bool applicantIsIndigenousPerson { get; set; }
        public bool applicantIsDisabledPerson { get; set; }


        public int spouseId { get; set; }

        public string spouseFirstName { get; set; }
        public string spouseLastName { get; set; }
        public int spouseSinCardNumber { get; set; }
        public MaritalStatus spouseMaritalStatus { get; set; }
        public DateOnly spouseBirthday { get; set; }
        public GenderType spouseGender { get; set; }
        public string spouseEmail { get; set; }
        public string spousePhoneNumber { get; set; }

        public bool spouseIsCanadianResidence { get; set; }
        public bool spouseIsIndigenousPerson { get; set; }
        public bool spouseIsDisabledPerson { get; set; }

        public ResidenceStatus residenceStatus { get; set; }
        public string streetAddress { get; set; }
        public string cityName { get; set; }
        public ProvinceName provinceName { get; set; }
        public DateOnly moveInDate { get; set; }

        public int familySize { get; set; }
        public int numberOfAdults { get; set; }
        public int numberOfChildren { get; set; }
        public int numberOfElderly { get; set; }

        public decimal rentalExpense { get; set; }
        public decimal utilityExpense { get; set; }
        public decimal foodExpense { get; set; }
        public decimal tuitionExpense { get; set; }

        public EmploymentType employmentType { get; set; }
        public string employerName { get; set; }
        public string positionName { get; set; }
        public decimal employmentIncome { get; set; }
        public DateOnly employmentStartDate { get; set; }

        public decimal spouseIncome { get; set; }
        public decimal donationIncome { get; set; }
        public decimal cashSavings { get; set; }







    }
}
