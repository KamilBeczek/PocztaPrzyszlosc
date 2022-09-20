using Microsoft.EntityFrameworkCore;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Services
{
    public class PocztaPrzyszloscDbContextFactory
    {
        private readonly string _connectionString;
        
        public PocztaPrzyszloscDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PocztaPrzyszloscDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(_connectionString).Options;

            return new PocztaPrzyszloscDbContext(options);
        }
    }
}
