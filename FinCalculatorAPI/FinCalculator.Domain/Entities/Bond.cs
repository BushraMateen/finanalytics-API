using System;
using System.Collections.Generic;


namespace FinCalculator.Domain.Entities
{
    public partial class Bond
    {
        public int? BondId { get; set; }
        public string BondName { get; set; }
        public string TrancheName { get; set; }
        public decimal? OriginalBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public string CurrentSnPrating { get; set; }
        public string CurrentFitchRating { get; set; }
        public string CurrentMoodysRating { get; set; }
        public decimal? DealId { get; set; }
        public string FaceHeld { get; set; }
        public decimal? Coupon { get; set; }
        public decimal? Factor { get; set; }
        public DateTime? FactorDate { get; set; }
        public decimal? OrigOutstandingPar { get; set; }
        public bool? IsNonTreppPortfolio { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public int? CapitalStructurePosition { get; set; }
        public string Class { get; set; }
        public string ClassType { get; set; }
    }
}
