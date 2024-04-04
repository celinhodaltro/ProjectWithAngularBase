using Microsoft.EntityFrameworkCore;

namespace App.Providers
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options)
             : base(options) { }

        //public DbSet<Teste> teste { get; set; }

    }
}
