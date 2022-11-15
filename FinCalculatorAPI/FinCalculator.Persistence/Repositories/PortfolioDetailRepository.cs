using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Persistence.Repositories
{
    public class PortfolioDetailRepository : BaseRepository<PortfolioDetail>, IPortfolioDetailRepository
    {
        public PortfolioDetailRepository(FinCalculatorContext dbContext) : base(dbContext)
        {
        }
    }
}
