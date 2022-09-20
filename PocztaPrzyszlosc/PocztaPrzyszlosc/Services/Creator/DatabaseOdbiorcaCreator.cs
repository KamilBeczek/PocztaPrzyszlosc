using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Services.Creator
{
    public class DatabaseOdbiorcaCreator : IPocztaPrzyszloscCreator
    {
        private readonly PocztaPrzyszloscDbContextFactory _dbContextFactory;

        public DatabaseOdbiorcaCreator(PocztaPrzyszloscDbContextFactory dbcontextFactory)
        {
            _dbContextFactory = dbcontextFactory;
        }

        public async Task CreateOdbiorca(Odbiorca odbiorca)
        {
            using (PocztaPrzyszloscDbContext context = _dbContextFactory.CreateDbContext())
            {
                OdbiorcaDTO odbiorcaDTO = ToOdbiorcaDTO(odbiorca);

                context.OdbiorcaDTO.Add(odbiorcaDTO);
                await context.SaveChangesAsync();
            }
        }

        private OdbiorcaDTO ToOdbiorcaDTO(Odbiorca odbiorca)
        {
            return new OdbiorcaDTO()
            {
                Nazwa = odbiorca.Nazwa,
                Email = odbiorca.Email,
                Ulica = odbiorca.Ulica,
                NumerTeleofnu = odbiorca.NumerTeleofnu,
                KodPocztowy = odbiorca.KodPocztowy,
                Miasto = odbiorca.Miasto
            };

        }
    }
}
