using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Domain.Entities
{
    public class Bond
    {
        public int BondId { get; set; }
        public string BondName { get; set; }
        public string TrancheName { get; set; }
        public int OriginalBalance { get; set; }
        public int CurrentBalance { get; set; }
        public string CurrentsnPRating { get; set; }
        public int CurrentFitchRating { get; set; }
        public string CurrentMoodysRating { get; set; }
        public int DealId { get; set; }
        public string FaceHeld { get; set; }
        public int Coupon { get; set; }
        public int Factor { get; set; }
        public DateTime FactorDate { get; set; }
        public int OrigOtstandingPar { get; set; }
        public bool IsNonTreoPortfolio { get; set; }
        public int CapitalStructurePosition { get; set; }
        public string Class { get; set; }
        public string ClassType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }

    }
}
