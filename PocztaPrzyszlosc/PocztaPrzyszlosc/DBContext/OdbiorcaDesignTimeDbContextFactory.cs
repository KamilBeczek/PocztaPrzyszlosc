using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Design.Internal;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.DBContext
{
    public class OdbiorcaDesignTimeDbContextFactory : IDesignTimeDbContextFactory<PocztaPrzyszloscDbContext>
    {
        public PocztaPrzyszloscDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer("test").Options;

            return new PocztaPrzyszloscDbContext(options);
        }
    }
}
