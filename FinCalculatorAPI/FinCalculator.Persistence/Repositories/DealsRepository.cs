using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Persistence.Repositories
{
    public class DealsRepository : BaseRepository<Deal>, IDealRepository

    {
        public DealsRepository (FinCalculatorContext dbContext) : base(dbContext)
        {

        }
    }
}
