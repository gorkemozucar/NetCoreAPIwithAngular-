using Microsoft.EntityFrameworkCore;

namespace EXAPI.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();   
    }
}
