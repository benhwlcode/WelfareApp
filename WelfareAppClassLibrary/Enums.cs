﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary
{
    public enum ApplicationProgress { ongoing, closed, completed }
    public enum EligibilityStatus { pending, eligible, ineligible}
    public enum ApprovalStatus { pending, approved, rejected}
    public enum PaymentStatus { pending, sent, received}

    public enum ProgramStatus { open, closed, paused }
    public enum PaymentForm { cash, wire, cheque, chargeup }
    public enum PaymentType { flat, percentage }

    public enum AgencyType { welfare, medical, food, tuition }
    public enum AgencyJurisdiction { global, federal, provincial, city }

    public enum DocumentStatus { waiting, received, checking, approved }

    public enum GenderType { male, female, undisclosed }
    public enum MaritalStatus { single, married, divorced, widowed }
    public enum ProvinceName { AB, BC, MB, NB, NL, NS, NT, NU, ON, PR, SK, QC, YT, }
    public enum ResidenceStatus { homeowner, mortgaging, renting, guest }
    public enum EmploymentType { fulltime, parttime, unemployed, freelance, contractor, retired }

}