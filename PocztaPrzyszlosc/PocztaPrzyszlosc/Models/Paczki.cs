using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Models
{
    public class Paczki
    {
        public int Id { get; }
        public bool PocztaDoDomu { get; }
        public bool PocztaDoPoczty { get; }
        public bool Priorytet { get; }
        public Rozmiary Rozmiar { get; }


    }
    public enum Rozmiary
    {
        mala,
        srednia,
        duza

    }
}
