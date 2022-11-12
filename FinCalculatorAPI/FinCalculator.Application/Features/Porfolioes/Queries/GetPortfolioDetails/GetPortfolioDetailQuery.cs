using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioDetails
{
    public class GetPortfolioDetailQuery : IRequest<PortfolioDetailVm>
    {
        public int Id { get; set; }
    }
}
