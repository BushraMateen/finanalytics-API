using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Persistence.Repositories
{
    public class PortfolioRepository : BaseRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(FinCalculatorDbContext dbContext) : base(dbContext)
        {
        }
    }
}
