
using Microsoft.EntityFrameworkCore;
using PocztaPrzyszlosc.Models;
using System.ComponentModel;

namespace PocztaPrzyszlosc.ViewModels
{
    public class PocztaPrzyszloscDbContext : DbContext
    {

     
        public PocztaPrzyszloscDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<OdbiorcaDTO> OdbiorcaDTO { get; set; }

    }
}
            
        




