using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PocztaPrzyszlosc.Commands
{
    public class CreateOdbiorcaCommand : CommandBase
    {
        private readonly Odbiorca _odbiorca;
        private readonly NadajPaczkeViewModel _nadajPaczkeViewModel;

        public CreateOdbiorcaCommand(NadajPaczkeViewModel nadajPaczkeViewModel, Odbiorca odbiorca)
        {
            _nadajPaczkeViewModel = nadajPaczkeViewModel;
            _odbiorca = odbiorca;
        }

        public override void Execute(object parameter)
        {
            Odbiorca odbiorca = new Odbiorca(
                _nadajPaczkeViewModel.OdbiorcaImie,
                _nadajPaczkeViewModel.OdbiorcaEmail,
                _nadajPaczkeViewModel.OdbiorcaAdres,
                _nadajPaczkeViewModel.OdbiorcaNumerTelefonu,
                _nadajPaczkeViewModel.OdbiorcaKodPocztowy,
                _nadajPaczkeViewModel.OdbiorcaMiasto

                );

            MessageBox.Show("Dodano Nadawce");

        }
    }
}
