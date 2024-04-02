using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class OfficeModel
    {
        public int officeId { get; set; }

        [MaxLength(50)]
        public string officeName { get; set;}

        // insert other non essential information


    }
}
