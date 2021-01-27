using CodeChallenge.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Animal> Animales { get; set; }

    }
}
