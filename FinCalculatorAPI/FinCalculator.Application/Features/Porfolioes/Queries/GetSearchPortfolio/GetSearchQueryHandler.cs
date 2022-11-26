using FinCalculator.Application.Contracts.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetSearchPortfolio
{
    public class GetSearchQueryHandler : IRequestHandler<GetSearchQuery, List<string>>
    {
        private readonly IDealRepository _dealRepository;

        public GetSearchQueryHandler(IDealRepository dealRepository)
        {
            _dealRepository = dealRepository;
        }


        public async Task<List<string>> Handle(GetSearchQuery request, CancellationToken cancellationToken)
        {
            var lst = await _dealRepository.ListAllAsync();
            return lst.Select(x => x.DealName).Where(x => x.Contains(request.Query)).ToList();

        }
    }
}
