using Microsoft.EntityFrameworkCore;

namespace Carta.Models
{
    public class AnimalContext:DbContext
    {
        public DbSet<Animal> animals { get; set; }
        public DbSet<Cart> Carts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //new ConfigurationBuilder().AddUserSecrets<AnimalContext>()
            //.Build()
            //.Providers
            //.First()
            //.TryGet("connStr", out var connStr);
            //optionsBuilder.UseSqlServer("Data Source=SQL5107.site4now.net;Initial Catalog=db_a8eeb3_dimon;User Id=db_a8eeb3_dimon_admin;Password=********");
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Carta;Trusted_Connection=True;");
        }

    }
}
