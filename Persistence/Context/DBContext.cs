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
        public DbSet<Ativo> Ativo { get; set; }
        public DbSet<Ordem> Ordem { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Ativo>().ToTable("Ativo");

            builder.Entity<Ativo>().HasKey(p => p.Id_ativo);

            builder.Entity<Ativo>().Property(p => p.Id_ativo).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Ativo>().Property(p => p.Descricao).IsRequired().HasMaxLength(30);
            builder.Entity<Ativo>().Property(p => p.Lote_minimo).IsRequired();

            builder.Entity<Ativo>().HasMany(p => p.Ordens).WithOne(c => c.Ativo).HasForeignKey(d => d.Fk_id_ativo);


            builder.Entity<Ordem>().ToTable("Ordem");

            builder.Entity<Ordem>().HasKey(p => p.Id_ordem);

            builder.Entity<Ordem>().Property(p => p.Id_ordem).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Ordem>().Property(p => p.Quantidade).IsRequired();
            builder.Entity<Ordem>().Property(p => p.Preco).IsRequired();
            builder.Entity<Ordem>().Property(p => p.Data).IsRequired();

        }
    }
}
