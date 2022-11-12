
using FinCalculator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Persistence
{
    public class FinCalculatorDbContext : DbContext
    {
        public FinCalculatorDbContext(DbContextOptions<FinCalculatorDbContext> options) : base(options)
        {

        }

        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<LoanMaster> LoanMasters { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioDetail> PortfolioDetails { get; set; }


    }
}
