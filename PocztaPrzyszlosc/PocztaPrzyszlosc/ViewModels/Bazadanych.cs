
using Microsoft.EntityFrameworkCore;
using PocztaPrzyszlosc.Models;
using System.ComponentModel;

namespace PocztaPrzyszlosc.ViewModels
{
    public class Bazadanych
    {
        public class BazaDanychDbContext : DbContext
        {
            public DbSet<Nadawca> Nadawca { get; set; }
            public DbSet<Odbiorcy> Odbiorca { get; set; }
            public DbSet<Paczki> Paczka { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-C9V743L\\SQLEXPRESS;Database=PocztaPrzyszlosc;Trusted_Connection=True;");
                base.OnConfiguring(optionsBuilder);
                
            }
            
        }


    }
}
