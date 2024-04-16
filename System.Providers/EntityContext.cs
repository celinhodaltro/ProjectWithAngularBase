using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Entities.Logs;
using System.Providers;


namespace System.Providers
{

    public class EntityContext : DbContext
    {

        public string ConnectionString = "Server=DESKTOP-SR3QBMC;Database=Source;User=joaom;Integrated Security=True;";
        public EntityContext(DbContextOptions<EntityContext> options)
             : base(options) { }

        public DbSet<Log> Log { get; set; }



    }



}



