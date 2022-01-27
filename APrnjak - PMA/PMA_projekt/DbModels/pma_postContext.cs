using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PMA_projekt.DbModels
{
    public partial class pma_postContext : DbContext
    {
        public pma_postContext()
        {
        }

        public pma_postContext(DbContextOptions<pma_postContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Objava> Objava { get; set; }
        public virtual DbSet<Objekt> Objekt { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-8LRSQV8D\\SQLEXPRESS;Database=pma_post;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grad>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Objava>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datum)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.GradId).HasColumnName("Grad_ID");

                entity.Property(e => e.ObjektId).HasColumnName("Objekt_ID");

                entity.Property(e => e.Sadrzaj)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Objava)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Objava_Grad");

                entity.HasOne(d => d.Objekt)
                    .WithMany(p => p.Objava)
                    .HasForeignKey(d => d.ObjektId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Objava_Objekt");
            });

            modelBuilder.Entity<Objekt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Objekt1)
                    .IsRequired()
                    .HasColumnName("Objekt")
                    .HasMaxLength(50);

                entity.Property(e => e.Vlasnik)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
