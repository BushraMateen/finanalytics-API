using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetSearchPortfolio
{
    public class GetSearchQuery : IRequest<List<string>>
    {
        public string Query { get; set; }
    }
}
