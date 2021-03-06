using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LaerteTeste2020.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Plano> PLano { get; set; }
        public DbSet<Beneficiario> Beneficiario { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plano>().Property(x => x.Mensalidade).HasPrecision(16, 2);

        }
    }
}
