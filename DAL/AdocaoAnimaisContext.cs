using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AdocaoAnimaisApi.Domain.Entity;

namespace AdocaoAnimaisApi.DAL
{
    public partial class AdocaoAnimaisContext : DbContext
    {
        public AdocaoAnimaisContext(DbContextOptions<AdocaoAnimaisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adocao> Adocoes { get; set; } = null!;
        public virtual DbSet<Especie> Especies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adocao>(entity =>
            {
                entity.HasKey(e => e.IdAdocao);

                entity.ToTable("Adocao");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Imagem)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEspecieNavigation)
                    .WithMany(p => p.Adocoes)
                    .HasForeignKey(d => d.IdEspecie)
                    .HasConstraintName("FK_AdocaoEspecie");
            });

            modelBuilder.Entity<Especie>(entity =>
            {
                entity.HasKey(e => e.IdEspecie);

                entity.ToTable("Especie");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
