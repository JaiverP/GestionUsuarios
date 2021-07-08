using Microsoft.EntityFrameworkCore;
using PruebaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDatos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base (options)
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }


    }
}
