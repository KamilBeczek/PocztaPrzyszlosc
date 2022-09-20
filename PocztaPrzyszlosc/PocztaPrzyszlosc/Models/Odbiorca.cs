using PocztaPrzyszlosc.Services;
using PocztaPrzyszlosc.Services.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Models
{

    public class Odbiorca
    {
        private readonly IOdbiorcaProvider _pocztaProvider;
        private readonly IPocztaPrzyszloscCreator _odbiorcaCreator;

        public int Id { get; }
        public string Nazwa { get; }
        public string Email {get; }
        public string Ulica {get; }
        public int NumerTeleofnu { get; }
        public int KodPocztowy { get; }
        public string Miasto { get; }

        public Odbiorca(IOdbiorcaProvider pocztaProvider, IPocztaPrzyszloscCreator odbiorcaCreator)
        {
            _pocztaProvider = pocztaProvider;
            _odbiorcaCreator = odbiorcaCreator;
        }

        public async Task<IEnumerable<Odbiorca>> GetAllReservations()
        {
            return await _pocztaProvider.GetAllOdbiorca();
        }

        public Odbiorca(string nazwa, string email, string ulica, int numertelefonu, int kodpocztowy, string miasto)
        {
            Nazwa = nazwa;
            Email = email;
            Ulica = ulica;
            NumerTeleofnu = numertelefonu;
            KodPocztowy = kodpocztowy;
            Miasto = miasto;


        }
        public async Task DodajOdbiorce(Odbiorca odbiorca)
        {
            await _odbiorcaCreator.CreateOdbiorca(odbiorca);
        }

    }
}
