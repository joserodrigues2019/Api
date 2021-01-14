using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ContasPagarEntity> ContasPagar { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ContasPagarEntity>().ToTable("ContasPagar");
            builder.Entity<ContasPagarEntity>().HasKey(p => p.IdConta);

        }
    }
}
