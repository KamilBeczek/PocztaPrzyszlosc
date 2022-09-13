using PocztaPrzyszlosc.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PocztaPrzyszlosc.ViewModels
{
    public class NadawcaViewModel : ViewModelMain 
    {
        private string _nadwacaImie;

        public string NadawcaImie
        {
            get
            {
                return _nadwacaImie;
            }

            set
            {

                _nadwacaImie = value;
                OnPropertyChanged(nameof(NadawcaImie));
            }
        }



        public ICommand SubmitCommand { get; }

        public NadawcaViewModel()
        {
            SubmitCommand = new CreateNadawcaCommand();
        }


        


    


    }
}
