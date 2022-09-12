using Microsoft.EntityFrameworkCore;
using PocztaPrzyszlosc.Model;
using PocztaPrzyszlosc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.EntityFramework
{
    public class BazaDanychDbContext : DbContext
    {
        public DbSet<Nadawcy> Nadawca {get; set;}
        public DbSet<Odbiorcy> Odbiorca { get; set; }
        public DbSet<Paczki> Paczka { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=DESKTOP-C9V743L\\SQLEXPRESS;Database=PocztaPrzyszlosc;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
