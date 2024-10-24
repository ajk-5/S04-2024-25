using Microsoft.EntityFrameworkCore;
using webApi.Models;
namespace webApi.Data
{
    public class AppDbContext:DbContext
    {
        protected readonly IConfiguration? Configuration; //attribut configuration

        public AppDbContext(IConfiguration configuration) 
        {
        Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration?.GetConnectionString("bdd"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Boat> Boats { get; set; }
    }
}
