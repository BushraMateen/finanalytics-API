using System;
using System.Collections.Generic;


namespace FinCalculator.Domain.Entities
{
    public partial class Deal
    {
        public int? DealId { get; set; }
        public string TreppDealName { get; set; }
        public string DealName { get; set; }
        public DateTime? DealVintage { get; set; }
        public string LongDealName { get; set; }
        public string IssuerName { get; set; }
        public string TrusteeName { get; set; }
        public int? PaymentDay { get; set; }
        public bool? IsNonTreppPortfolio { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string AlternateName1 { get; set; }
        public string BloombergName { get; set; }
    }
}
