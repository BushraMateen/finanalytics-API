using AutoMapper;
using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Application.Exceptions;
using FinCalculator.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FinCalculator.Application.Features.Porfolioes.Commands.DeletePortfolio
{
    public class DeletePortfolioCommandHandler : IRequestHandler<DeletePortfolioCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;

        public DeletePortfolioCommandHandler(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }

        public async Task<Unit> Handle(DeletePortfolioCommand request, CancellationToken cancellationToken)
        {
            var portfolioToDelete = await _portfolioRepository.GetByIdAsync(request.PortfolioId);

            if (portfolioToDelete == null)
            {
                throw new NotFoundException(nameof(Portfolio), request.PortfolioId.ToString());
            }

            await _portfolioRepository.DeleteAsync(portfolioToDelete);

            return Unit.Value;
        }
    }
}
