using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.Services.Creator;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PocztaPrzyszlosc.Commands
{
    public class SubmitCommand : ASyncCommandBase
    {
        private readonly Nadawca _nadawca;
        private readonly NadajPaczkeViewModel _nadajPaczkeViewModel;
        private readonly Odbiorca _odbiorca;

        public SubmitCommand(NadajPaczkeViewModel nadajPaczkeViewModel, Nadawca nadawca, Odbiorca odbiorca)
        {
            _nadajPaczkeViewModel = nadajPaczkeViewModel;
            _nadawca = nadawca;
            _odbiorca = odbiorca;
        }

        public override async Task ExecuteAsync(object parameter)
        {

            Odbiorca odbiorca = new Odbiorca(
              _nadajPaczkeViewModel.OdbiorcaImie,
              _nadajPaczkeViewModel.OdbiorcaEmail,
              _nadajPaczkeViewModel.OdbiorcaAdres,
              _nadajPaczkeViewModel.OdbiorcaNumerTelefonu,
              _nadajPaczkeViewModel.OdbiorcaKodPocztowy,
              _nadajPaczkeViewModel.OdbiorcaMiasto

              );

            try
            {
                await odbiorca.DodajOdbiorce(odbiorca);
                MessageBox.Show("Done");
            }

            catch(Exception)
            {
                MessageBox.Show("Error");
            }


            

            
        }


    }
}
