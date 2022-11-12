using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Contracts.Persistance
{
    public interface IPortfolioRepository : IAsyncRepository<Portfolio>
    {
    }
}
