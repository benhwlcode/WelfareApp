using System;
using System.Collections.Generic;
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



    }
}
