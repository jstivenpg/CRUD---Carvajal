
using CRUD___CARVAJAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD___CARVAJAL.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        internal Usuario Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
