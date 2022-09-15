using PocztaPrzyszlosc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.ViewModels
{
    public class ViewModelMain: ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }


        public ViewModelMain(Nadawca nadawca, Odbiorca odbiorca)
        {
            CurrentViewModel = new NadajPaczkeViewModel(nadawca, odbiorca);
        }
       
    }
}
