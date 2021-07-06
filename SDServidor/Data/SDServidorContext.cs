using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SDServidor.Models;

#nullable disable

namespace SDServidor.Data
{
    public partial class SDServidorContext : DbContext
    {
        public SDServidorContext()
        {
        }

        public SDServidorContext(DbContextOptions<SDServidorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ModelApostum> ModelAposta { get; set; }
        public virtual DbSet<ModelUtilizador> ModelUtilizadors { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("name=SDServidorContext");
        //    }
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<ModelApostum>(entity =>
        //    {
        //        entity.HasOne(d => d.Utilizador)
        //            .WithMany(p => p.ModelAposta)
        //            .HasForeignKey(d => d.UtilizadorId)
        //            .HasConstraintName("FK__ModelApos__utili__25869641");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
