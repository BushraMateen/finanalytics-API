using System;
using System.Collections.Generic;


namespace FinCalculator.Domain.Entities
{
    public partial class Portfolio
    {
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
