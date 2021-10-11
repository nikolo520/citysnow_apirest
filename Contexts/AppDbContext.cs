using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest_webapp.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Entities.Articulo> Articulo { get; set; }

        public DbSet<Entities.Clima> Clima { get; set; }

        public DbSet<Entities.History> History { get; set; }
    }
}
