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
    public class CreateNadawcaCommand : CommandBase
    {
        private readonly Nadawca _nadawca;
        private readonly NadajPaczkeViewModel _nadajPaczkeViewModel;

        public CreateNadawcaCommand(NadajPaczkeViewModel nadajPaczkeViewModel, Nadawca nadawca)
        {
            _nadajPaczkeViewModel = nadajPaczkeViewModel;
            _nadawca = nadawca;
        }

        public override void Execute(object parameter)
        {
            Nadawca nadawca = new Nadawca(
                _nadajPaczkeViewModel.NadawcaImie,
                _nadajPaczkeViewModel.NadawcaEmail,
                _nadajPaczkeViewModel.NadawcaAdres,
                _nadajPaczkeViewModel.NadawcaNumerTelefonu,
                _nadajPaczkeViewModel.NadawcaKodPocztowy,
                _nadajPaczkeViewModel.NadawcaMiasto
                );

            MessageBox.Show("Dodano Nadawce");

        }
    }
}
