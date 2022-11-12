using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Contracts.Persistance
{
    public interface ILoanMasterRepository : IAsyncRepository<LoanMaster>
    {
    }
}
