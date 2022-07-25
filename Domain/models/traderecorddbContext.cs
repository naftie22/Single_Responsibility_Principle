using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.models
{
    public partial class traderecorddbContext : DbContext
    {
        public traderecorddbContext()
        {
        }

        public traderecorddbContext(DbContextOptions<traderecorddbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Traderecord> Traderecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=traderecorddb;user=nafti;pwd=password", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8mb3");

            modelBuilder.Entity<Traderecord>(entity =>
            {
                entity.ToTable("traderecord");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(6);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TotalPrice).HasPrecision(10);

                entity.Property(e => e.UnitPrice).HasPrecision(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
