using PocztaPrzyszlosc.Commands;
using PocztaPrzyszlosc.Models;
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
        private string _nadawcaEmail;
        private int _nadawcaNumerTelefonu;
        private string _nadawcaAdres;
        private int _nadawcaKodPocztowy;
        private string _nadawcaMiasto;


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


        public string NadawcaEmail
        {
            get
            {
                return _nadawcaEmail;
            }

            set
            {

                _nadawcaEmail = value;
                OnPropertyChanged(nameof(NadawcaEmail));
            }
        }
        public int NadawcaNumerTelefonu
        {
            get
            {
                return _nadawcaNumerTelefonu;
            }

            set
            {

                _nadawcaNumerTelefonu = value;
                OnPropertyChanged(nameof(NadawcaNumerTelefonu));
            }
        }
        public string NadawcaAdres
        {
            get
            {
                return _nadawcaAdres;
            }

            set
            {

                _nadawcaAdres = value;
                OnPropertyChanged(nameof(NadawcaAdres));
            }
        }
        public int NadawcaKodPocztowy
        {
            get
            {
                return _nadawcaKodPocztowy;
            }

            set
            {

                _nadawcaKodPocztowy = value;
                OnPropertyChanged(nameof(NadawcaKodPocztowy));
            }
        }
        public string NadawcaMiasto
        {
            get
            {
                return _nadawcaMiasto;
            }

            set
            {

                _nadawcaMiasto = value;
                OnPropertyChanged(nameof(NadawcaMiasto));
            }

        }



        public ICommand SubmitCommand { get; }

        public NadawcaViewModel(Nadawca nadawca)
        {
            SubmitCommand = new CreateNadawcaCommand(this, nadawca);
        }


        


    


    }
}
