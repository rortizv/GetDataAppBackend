using GetDataApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDataApp
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
