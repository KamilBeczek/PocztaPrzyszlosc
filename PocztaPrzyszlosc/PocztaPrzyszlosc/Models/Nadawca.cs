using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PocztaPrzyszlosc.ViewModels;
using PocztaPrzyszlosc;


namespace PocztaPrzyszlosc.Models
{
    public class Nadawca 
    {

        public int Id { get; }
        public string Nazwa { get; }
        public string Email { get; }
        public string Ulica { get; }
        public int NumerTeleofnu { get; }
        public int KodPocztowy { get; }
        public string Miasto { get; }

        public Nadawca(string nazwa, string email, string ulica, int numertelefonu, int kodpocztowy, string Miasto)
        {
            
        }

        public Nadawca()
        {
       
        }

        public void UtworzNadawce(Nadawca nadawca)
        {
            Console.WriteLine();
        }
      






    }
}
