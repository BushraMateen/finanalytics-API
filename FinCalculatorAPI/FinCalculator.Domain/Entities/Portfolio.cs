using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Domain.Entities
{
   public class Portfolio
    {
        public int PortfolioId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string PortfolioName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
     

    }
}
