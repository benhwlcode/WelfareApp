﻿using System.Security.Principal;

namespace WelfareAppClassLibrary.Models
{


    public class ApplicationModel
    {

        public int applicationId { get; set; }
        public int applicationCode { get; set; }

        public int programId { get; set; }
        public int applicantId { get; set; }


        public int agentId { get; set; }
        public int officeId { get; set; }
        public int supervisorId { get; set; }

        public ApplicationProgress applicationProgress { get; set; }
        public EligibilityStatus eligibilityStatus { get; set; }
        public ApprovalStatus approvalStatus { get; set; }
        public PaymentStatus paymentStatus { get; set; }

        public bool signatureSigned { get; set; }
        public DateOnly signatureDate { get; set; }

        public List<DocumentModel> listOfDocuments { get; set; }

    }
}