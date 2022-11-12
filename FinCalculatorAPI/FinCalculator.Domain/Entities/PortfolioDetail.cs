using System;
using System.Collections.Generic;


namespace FinCalculator.Domain.Entities
{
    public partial class PortfolioDetail
    {
        public int? PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string Description { get; set; }
        public string LongDealName { get; set; }
        public string TreppDealName { get; set; }
        public string Class { get; set; }
        public string TrancheName { get; set; }
        public string Cusip { get; set; }
        public int? DealId { get; set; }
        public int? BondId { get; set; }
        public long PortfolioDetailId { get; set; }
    }
}
