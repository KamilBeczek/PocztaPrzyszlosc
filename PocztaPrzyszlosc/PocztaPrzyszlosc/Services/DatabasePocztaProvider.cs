using Microsoft.EntityFrameworkCore;
using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Services
{
    public class DatabasePocztaProvider : IOdbiorcaProvider
    {
        private readonly PocztaPrzyszloscDbContextFactory _dbContextFactory;

        public DatabasePocztaProvider(PocztaPrzyszloscDbContextFactory dbcontextFactory)
        {
            _dbContextFactory = dbcontextFactory;
        }

        public async Task<IEnumerable<Odbiorca>> GetAllOdbiorca()
        {
            using (PocztaPrzyszloscDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<OdbiorcaDTO> odbiorcaDTOs = await context.OdbiorcaDTO.ToListAsync();

                return odbiorcaDTOs.Select(r => ToOdbiorca(r));

            }


        }

        private static Odbiorca ToOdbiorca (OdbiorcaDTO r)
        {
            return new Odbiorca(r.Nazwa,r.Email, r.Ulica, r.NumerTeleofnu, r.KodPocztowy, r.Miasto);
        }
    }
}
