using AutoMapper;
using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioInfo
{
    public class GetPortfolioInfoQueryHandler : IRequestHandler<GetPortfolioInfoQuery, List<PortfolioInfoVm>>
    {
        private readonly IAsyncRepository<PortfolioDetail> _portfolioDetailRepository;
        private readonly IMapper _mapper;
        public GetPortfolioInfoQueryHandler(IMapper mapper, IAsyncRepository<PortfolioDetail> portfolioDetailRepository)
        {
            _mapper = mapper;
            _portfolioDetailRepository = portfolioDetailRepository;
        }
        public async Task<List<PortfolioInfoVm>> Handle(GetPortfolioInfoQuery request, CancellationToken cancellationToken)
        {
            var allPortfolioes = await _portfolioDetailRepository.ListAllAsync();
            return _mapper.Map<List<PortfolioInfoVm>>(allPortfolioes);
        }
    }
}
