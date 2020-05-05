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
        public virtual DbSet<AccountType> AccountType { get; set; }
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
                    .HasName("PK__tmp_ms_x__F267251E88AFCD16");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountDescription)
                    .IsRequired()
                    .HasColumnName("accountDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountType).HasColumnName("accountType");

                entity.Property(e => e.Apr)
                    .HasColumnName("apr")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InitialBal)
                    .HasColumnName("initialBal")
                    .HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountInfo)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AccountInfo_dbo.UserInfo_userId");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.AccountType1)
                    .HasName("PK__AccountT__2EAE53D7799B07CD");

                entity.Property(e => e.AccountType1)
                    .HasColumnName("accountType")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnName("accountName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Calculator>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Apr)
                    .HasColumnName("apr")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsSavingsCalc).HasColumnName("isSavingsCalc");

                entity.Property(e => e.MonthlyPayment)
                    .HasColumnName("monthlyPayment")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PayOffTime).HasColumnName("payOffTime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Calculator)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Calculator_dbo.UserInfo_userId");
            });

            modelBuilder.Entity<Checkings>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__tmp_ms_x__9B57CF72A412E9B0");

                entity.Property(e => e.TransactionId).HasColumnName("transactionId");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Checkings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Checkings_dbo.UserInfo_userId");
            });

            modelBuilder.Entity<Debt>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__tmp_ms_x__9B57CF7248C7748B");

                entity.Property(e => e.TransactionId).HasColumnName("transactionId");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Savings>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__tmp_ms_x__9B57CF729EED9213");

                entity.Property(e => e.TransactionId).HasColumnName("transactionId");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tmp_ms_x__CB9A1CFF0A3A786D");

                entity.Property(e => e.UserId).HasColumnName("userId");

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
