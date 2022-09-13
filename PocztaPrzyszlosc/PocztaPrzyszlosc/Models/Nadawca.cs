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

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Email { get; set; }
        public string Ulica { get; set; }
        public int NumerTeleofnu { get; set; }
        public int KodPocztowy { get; set; }
        public string Miasto { get; set; }

        public Nadawca(string nazwa, string email, string ulica, int numertelefonu, int kodpocztowy, string Miasto)
        {
            
        }
      






    }
}
