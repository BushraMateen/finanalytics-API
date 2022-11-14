using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Commands.UpdatePortfolio
{
    public class UpdatePortfolioCommand : IRequest
    {
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
