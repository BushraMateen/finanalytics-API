using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Domain.Entities
{
    public class LoanMaster
    {
        public int LoanMasterId { get; set; }
        public int TreppLoanMasterId { get; set; }
        public int TreppTrusteeId { get; set; }
        public string CollateralName { get; set; }

        public string TrepDealTag { get; set; }
        public string Trustee { get; set; }
        public int ProspectusId { get; set; }

        public int CollateralId { get; set; }
        public int NoteNumber { get; set; }

        public DateTime MaturityDate { get; set; }
        public DateTime LoanOrignationDate { get; set; }

        public DateTime PaidOffDate { get; set; }
        public int WholeLoanId { get; set; }
        public bool IsLead { get; set; }
        public string SpecialServicer { get; set; }
        public string RealizesLossToTrust { get; set; }

    }
}
