using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Commands.CreatePortfolio
{
    public class CreatePortfolioCommand : IRequest<int>
    {
       
        public string PortfolioName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
