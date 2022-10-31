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
                //optionsBuilder.UseSqlServer(connStr);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;");
        }

    }
}
