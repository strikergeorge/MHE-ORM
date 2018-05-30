using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Entities
{
    public partial class ApprovalRequestsDBContext : DbContext
    {
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Businesses> Businesses { get; set; }
        public virtual DbSet<RequestHistory> RequestHistory { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Server=localhost\sql2014;database=ApprovalRequestsDB;Integrated Security=true;user id=qiaozhi.yang;password=Wow.659465-");
        //            }
        //        }
        public ApprovalRequestsDBContext(DbContextOptions<ApprovalRequestsDBContext> options)
        : base(options)
        { }

        public static class ApprovalRequestsDBContextFactory
        {
            public static ApprovalRequestsDBContext Create(string connectionString)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApprovalRequestsDBContext>();
                optionsBuilder.UseSqlServer(connectionString);

                var context = new ApprovalRequestsDBContext(optionsBuilder.Options);
                context.Database.EnsureCreated();

                return context;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applications>(entity =>
            {
                entity.HasKey(e => e.AirId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.AirId)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationName).HasMaxLength(20);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Businesses>(entity =>
            {
                entity.HasKey(e => new { e.AirId, e.BusinessCode })
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.AirId).HasMaxLength(10);

                entity.Property(e => e.BusinessCode).HasMaxLength(3);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.ResponseEndPoint).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequestHistory>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AirId).HasMaxLength(10);

                entity.Property(e => e.ApplicationName).HasMaxLength(20);

                entity.Property(e => e.ApproverPeoplekey).HasMaxLength(50);

                entity.Property(e => e.BusinessCode).HasMaxLength(3);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FromEnterpriseId).HasMaxLength(50);

                entity.Property(e => e.OtherJsonDetails).HasMaxLength(255);

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);
            });
        }
    }
}
