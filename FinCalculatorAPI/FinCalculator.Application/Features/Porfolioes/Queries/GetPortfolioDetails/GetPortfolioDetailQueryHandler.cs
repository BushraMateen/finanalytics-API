using AutoMapper;
using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioDetails
{
    public class GetPortfolioDetailQueryHandler : IRequestHandler<GetPortfolioDetailQuery, PortfolioDetailVm>
    {
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;
        private readonly IMapper _mapper;
        public GetPortfolioDetailQueryHandler(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }
        public async Task<PortfolioDetailVm> Handle(GetPortfolioDetailQuery request, CancellationToken cancellationToken)
        {
            var @Portfolio = await _portfolioRepository.GetByIdAsync(request.Id);
            var portfolioDetailDto = _mapper.Map<PortfolioDetailVm>(@Portfolio);

            return portfolioDetailDto;
        }
    }
}
