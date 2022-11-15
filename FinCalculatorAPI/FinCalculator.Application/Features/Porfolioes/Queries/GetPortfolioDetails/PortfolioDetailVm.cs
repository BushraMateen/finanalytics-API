using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioDetails
{
    public class PortfolioDetailVm
    {
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
