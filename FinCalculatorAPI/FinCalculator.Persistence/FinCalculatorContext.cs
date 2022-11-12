using System;
using FinCalculator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinCalculator.Persistence
{
    public partial class FinCalculatorContext : DbContext
    {
        public FinCalculatorContext()
        {
        }

        public FinCalculatorContext(DbContextOptions<FinCalculatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bond> Bonds { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<LoanMaster> LoanMasters { get; set; }
        public virtual DbSet<Portfolio> Portfolioes { get; set; }
        public virtual DbSet<PortfolioDetail> PortfolioDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-R3MPILK;Database=FinCalculator;Trusted_Connection=True; MultipleActiveResultSets=true;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bond>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BondId).HasColumnName("BondID");

                entity.Property(e => e.BondName).HasMaxLength(50);

                entity.Property(e => e.Class).HasMaxLength(10);

                entity.Property(e => e.ClassType).HasMaxLength(50);

                entity.Property(e => e.Coupon).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasMaxLength(255);

                entity.Property(e => e.CurrentBalance).HasColumnType("money");

                entity.Property(e => e.CurrentFitchRating).HasMaxLength(10);

                entity.Property(e => e.CurrentMoodysRating).HasMaxLength(10);

                entity.Property(e => e.CurrentSnPrating)
                    .HasMaxLength(10)
                    .HasColumnName("CurrentSnPRating");

                entity.Property(e => e.DealId).HasColumnType("money");

                entity.Property(e => e.FaceHeld).HasMaxLength(255);

                entity.Property(e => e.Factor)
                    .HasColumnType("money")
                    .HasColumnName("factor");

                entity.Property(e => e.FactorDate)
                    .HasColumnType("datetime")
                    .HasColumnName("factorDate");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedOn).HasMaxLength(255);

                entity.Property(e => e.OrigOutstandingPar).HasColumnType("money");

                entity.Property(e => e.OriginalBalance).HasColumnType("money");

                entity.Property(e => e.TrancheName).HasMaxLength(10);
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AlternateName1).HasMaxLength(100);

                entity.Property(e => e.BloombergName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasMaxLength(255);

                entity.Property(e => e.DealId).HasColumnName("DealID");

                entity.Property(e => e.DealName).HasMaxLength(100);

                entity.Property(e => e.DealVintage).HasColumnType("datetime");

                entity.Property(e => e.IssuerName).HasMaxLength(100);

                entity.Property(e => e.LongDealName)
                    .HasMaxLength(100)
                    .HasColumnName("longDealName");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedOn).HasMaxLength(255);

                entity.Property(e => e.TreppDealName).HasMaxLength(10);

                entity.Property(e => e.TrusteeName).HasMaxLength(100);
            });

            modelBuilder.Entity<LoanMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoanMaster");

                entity.Property(e => e.CollateralId).HasColumnName("CollateralID");

                entity.Property(e => e.CollateralName).HasMaxLength(255);

                entity.Property(e => e.LoanMasterId).HasColumnName("LoanMasterID");

                entity.Property(e => e.LoanOriginationDate).HasMaxLength(255);

                entity.Property(e => e.MaturityDate).HasMaxLength(255);

                entity.Property(e => e.PaidOffDate).HasColumnType("datetime");

                entity.Property(e => e.ProspectusId).HasColumnName("ProspectusID");

                entity.Property(e => e.RealizedLossToTrust).HasMaxLength(255);

                entity.Property(e => e.SpecialServicer).HasMaxLength(255);

                entity.Property(e => e.TreppDealTag).HasMaxLength(100);

                entity.Property(e => e.TreppMasterLoanId).HasColumnName("TreppMasterLoanID");

                entity.Property(e => e.TreppTrusteeId)
                    .HasMaxLength(100)
                    .HasColumnName("TreppTrusteeID");

                entity.Property(e => e.Trustee).HasMaxLength(100);

                entity.Property(e => e.WholeLoanId).HasColumnName("WholeLoanID");
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.HasKey(e => e.PortfolioId)
                    .HasName("PK_portfoliosId")
                    .IsClustered(false);

                entity.Property(e => e.PortfolioId)
                    .ValueGeneratedNever()
                    .HasColumnName("PortfolioID");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(255);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PortfolioName).HasMaxLength(200);

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<PortfolioDetail>(entity =>
            {
                entity.HasKey(e => e.PortfolioDetailId)
                    .HasName("PK_portfolioId")
                    .IsClustered(false);

                entity.Property(e => e.BondId).HasColumnName("BondID");

                entity.Property(e => e.Class).HasMaxLength(10);

                entity.Property(e => e.Cusip).HasMaxLength(50);

                entity.Property(e => e.DealId).HasColumnName("DealID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.LongDealName)
                    .HasMaxLength(100)
                    .HasColumnName("longDealName");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.PortfolioName).HasMaxLength(100);

                entity.Property(e => e.TrancheName).HasMaxLength(50);

                entity.Property(e => e.TreppDealName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
