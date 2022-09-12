using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Models
{
    public class Paczki
    {
        public int Id { get; set; }
        public bool PocztaDoDomu { get; set; }
        public bool PocztaDoPoczty { get; set; }
        public bool Priorytet { get; set; }
        public Rozmiary Rozmiar { get; set; }


    }
    public enum Rozmiary
    {
        mala,
        srednia,
        duza

    }
}
