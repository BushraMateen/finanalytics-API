using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioList
{
    public class GetPortfolioListQuery : IRequest<List<PortfolioListVm>>
    {
    }
}
