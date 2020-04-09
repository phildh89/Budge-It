using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BudgeIt.Models
{
    public partial class BudgeItDatabaseContext : DbContext
    {
        public BudgeItDatabaseContext()
        {
        }

        public BudgeItDatabaseContext(DbContextOptions<BudgeItDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountInfo> AccountInfo { get; set; }
        public virtual DbSet<Calculator> Calculator { get; set; }
        public virtual DbSet<Checkings> Checkings { get; set; }
        public virtual DbSet<Debt> Debt { get; set; }
        public virtual DbSet<Savings> Savings { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BudgeItDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__AccountI__F267251E2DA8C4F3");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnName("accountName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("accountType")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apr)
                    .HasColumnName("apr")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.InitialBal)
                    .HasColumnName("initialBal")
                    .HasColumnType("money");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.AccountInfo)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_dbo.AccountInfo_dbo.UserInfo_custID");
            });

            modelBuilder.Entity<Calculator>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Apr)
                    .HasColumnName("apr")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.IsSavingsCalc).HasColumnName("isSavingsCalc");

                entity.Property(e => e.MonthlyPayment)
                    .HasColumnName("monthlyPayment")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PayOffTime).HasColumnName("payOffTime");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Calculator)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_dbo.Calculator_dbo.UserInfo_custID");
            });

            modelBuilder.Entity<Checkings>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Checking__9B57CF72E1DF28A0");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transactionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Checkings)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_dbo.Checkings_dbo.UserInfo_custID");
            });

            modelBuilder.Entity<Debt>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Debt__9B57CF72A50C6D90");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transactionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Savings>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Savings__9B57CF720BA2EF68");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transactionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__UserInfo__9725F2C65FA04A12");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
