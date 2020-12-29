using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebAPI.Domain.Entities;

namespace WebAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(){ }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataDeCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataDeCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}