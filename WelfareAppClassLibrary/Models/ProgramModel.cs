using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class ProgramModel
    {
        public int programId { get; set; }
        public int programCode { get; set; }

        public string programName { get; set; }
        public ProgramStatus programStatus { get; set; }

        public int agencyId { get; set; }
        public int agentId { get; set; }
        public int officeId { get; set; }
        public int supervisorId { get; set; }

        public PaymentForm paymentForm { get; set; }
        public PaymentType paymentType { get; set; }
        public decimal minPayment { get; set; }
        public decimal maxPayment { get; set; }

        public List<DocumentModel> listOfDocumentsRequired { get; set; }

    }
}
