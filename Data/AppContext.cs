using Microsoft.EntityFrameworkCore;
using Poke.Models;

namespace Poke.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) :base(options)
        {

        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
    }

}
