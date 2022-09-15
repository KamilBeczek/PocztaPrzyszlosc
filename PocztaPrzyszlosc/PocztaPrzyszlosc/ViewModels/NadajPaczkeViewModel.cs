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
    public class NadajPaczkeViewModel : ViewModelBase
    {
        private string _nadwacaImie;
        private string _nadawcaEmail;
        private int _nadawcaNumerTelefonu;
        private string _nadawcaAdres;
        private int _nadawcaKodPocztowy;
        private string _nadawcaMiasto;

        private string _odbiorcaImie;
        private string _odbiorcaEmail;
        private int _odbiorcaNumerTelefonu;
        private string _odbiorcaAdres;
        private int _odbiorcaKodPocztowy;
        private string _odbiorcaMiasto;



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

        public string OdbiorcaImie
        {
            get
            {
                return _odbiorcaImie;
            }

            set
            {

                _odbiorcaImie = value;
                OnPropertyChanged(nameof(OdbiorcaImie));
            }
        }


        public string OdbiorcaEmail
        {
            get
            {
                return _odbiorcaEmail;
            }

            set
            {

                _odbiorcaEmail = value;
                OnPropertyChanged(nameof(OdbiorcaEmail));
            }
        }
        public int OdbiorcaNumerTelefonu
        {
            get
            {
                return _odbiorcaNumerTelefonu;
            }

            set
            {

                _odbiorcaNumerTelefonu = value;
                OnPropertyChanged(nameof(OdbiorcaNumerTelefonu));
            }
        }
        public string OdbiorcaAdres
        {
            get
            {
                return _odbiorcaAdres;
            }

            set
            {

                _odbiorcaAdres = value;
                OnPropertyChanged(nameof(OdbiorcaAdres));
            }
        }
        public int OdbiorcaKodPocztowy
        {
            get
            {
                return _odbiorcaKodPocztowy;
            }

            set
            {

                _odbiorcaKodPocztowy = value;
                OnPropertyChanged(nameof(OdbiorcaKodPocztowy));
            }
        }
        public string OdbiorcaMiasto
        {
            get
            {
                return _odbiorcaMiasto;
            }

            set
            {

                _odbiorcaMiasto = value;
                OnPropertyChanged(nameof(OdbiorcaMiasto));
            }

        }



        public ICommand SubmitCommand { get; }

        public NadajPaczkeViewModel(Nadawca nadawca, Odbiorca odbiorca)
        {
            SubmitCommand = new CreateNadawcaCommand(this, nadawca);
            SubmitCommand = new CreateOdbiorcaCommand(this, odbiorca);

        }


        


    


    }
}
