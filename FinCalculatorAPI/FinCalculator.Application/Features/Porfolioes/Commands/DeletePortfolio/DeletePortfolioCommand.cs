using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Commands.DeletePortfolio
{
    public class DeletePortfolioCommand : IRequest
    {
        public int PortfolioId { get; set; }
    }
}
