using AutoMapper;
using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



using FinCalculator.Application.Exceptions;

namespace FinCalculator.Application.Features.Porfolioes.Commands.UpdatePortfolio
{
    public class UpdatePortfolioCommandHandlers : IRequestHandler<UpdatePortfolioCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;

        public UpdatePortfolioCommandHandlers(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }
        public async Task<Unit> Handle(UpdatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var portfolioToUpdate = await _portfolioRepository.GetByIdAsync(request.PortfolioId);

            if (portfolioToUpdate == null)
            {
                throw new NotFoundException(nameof(Portfolio), request.PortfolioId.ToString());

            }

            var validator = new UpdatePortfolioCommandValidator();
            var validateResult = await validator.ValidateAsync(request);

            if (validateResult.Errors.Count > 0)
            {
                throw new ValidationException(validateResult);
            }

            _mapper.Map(request, portfolioToUpdate, typeof(UpdatePortfolioCommand), typeof(Portfolio));

            await _portfolioRepository.UpdateAsync(portfolioToUpdate);

            return Unit.Value;


        }
    }
}
