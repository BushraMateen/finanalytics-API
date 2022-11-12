using System;
using System.Collections.Generic;


namespace FinCalculator.Domain.Entities
{
    public partial class LoanMaster
    {
        public int? LoanMasterId { get; set; }
        public int? TreppMasterLoanId { get; set; }
        public string TreppTrusteeId { get; set; }
        public string CollateralName { get; set; }
        public string TreppDealTag { get; set; }
        public string Trustee { get; set; }
        public int? ProspectusId { get; set; }
        public int? CollateralId { get; set; }
        public int? NoteNumber { get; set; }
        public string MaturityDate { get; set; }
        public string LoanOriginationDate { get; set; }
        public DateTime? PaidOffDate { get; set; }
        public int? WholeLoanId { get; set; }
        public bool? IsLead { get; set; }
        public string SpecialServicer { get; set; }
        public string RealizedLossToTrust { get; set; }
    }
}
