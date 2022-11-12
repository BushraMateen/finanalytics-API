using AutoMapper;
using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioList
{
    public class GetPortfolioListQueryHandler : IRequestHandler<GetPortfolioListQuery, List<PortfolioListVm>>
    {
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;
        private readonly IMapper _mapper;
        public GetPortfolioListQueryHandler(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }
        public async Task<List<PortfolioListVm>> Handle(GetPortfolioListQuery request, CancellationToken cancellationToken)
        {
            var allPortfolioes = (await _portfolioRepository.ListAllAsync());
            return _mapper.Map<List<PortfolioListVm>>(allPortfolioes);
        }
    }
}
