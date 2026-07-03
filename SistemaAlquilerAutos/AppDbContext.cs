using Microsoft.EntityFrameworkCore;

namespace SistemaAlquilerAutos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AlquilerAutosDB;Trusted_Connection=True;",
                sqlServerOptions => sqlServerOptions.EnableRetryOnFailure());
        }
    }
}