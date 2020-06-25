using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesafioBahia.Domain.Models;

namespace DesafioBahia.Persistence.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Ordem> Ordens { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Ativo>().ToTable("Ativos");

            builder.Entity<Ativo>().HasKey(p => p.Id);

            builder.Entity<Ativo>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Ativo>().Property(p => p.descricao).IsRequired().HasMaxLength(30);
            builder.Entity<Ativo>().Property(p => p.lote_minimo).IsRequired();

            builder.Entity<Ativo>().HasMany(p => p.Ordens).WithOne(c => c.ativo).HasForeignKey(d => d.id_ativo);


            builder.Entity<Ordem>().ToTable("Ordens");

            builder.Entity<Ordem>().HasKey(p => p.id);

            builder.Entity<Ordem>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Ordem>().Property(p => p.quantidade).IsRequired();
            builder.Entity<Ordem>().Property(p => p.preco).IsRequired();
            builder.Entity<Ordem>().Property(p => p.data).IsRequired();
            builder.Entity<Ordem>().Property(p => p.classe_negociacao).IsRequired();

            builder.Entity<Ativo>().HasData
            (
                new Ativo { Id = 1, descricao = "Petrobras", lote_minimo = 100},
                new Ativo { Id = 2, descricao = "Oi", lote_minimo = 50}
            );

            this.Database.EnsureCreated();

        }
    }
}
