using PocztaPrzyszlosc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Services.Creator
{
    public interface IPocztaPrzyszloscCreator
    {
        Task CreateOdbiorca(Odbiorca odbiorca);
    }
}
