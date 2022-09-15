using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PocztaPrzyszlosc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Nadawca _nadawca;
        private readonly Odbiorca _odbiorca;

        public App()
        {
            _odbiorca = new Odbiorca();
            _nadawca = new Nadawca();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ViewModelMain(_nadawca, _odbiorca)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
