using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Commands
{
    public class CreateNadawcaCommand : CommandBase
    {
        private readonly Nadawca _nadawca;
        private readonly NadawcaViewModel _nadawcaViewModel;


        public CreateNadawcaCommand(Nadawca nadawca)
        {
            _nadawca = nadawca;
        }

        public CreateNadawcaCommand(NadawcaViewModel nadawcaViewModel, Nadawca nadawca)
        {
            _nadawcaViewModel = nadawcaViewModel;
            _nadawca = nadawca;
        }

        public override void Execute(object parameter)
        {
            Nadawca nadawca = new Nadawca(
                _nadawcaViewModel.NadawcaImie
                );
            
        }
    }
}
