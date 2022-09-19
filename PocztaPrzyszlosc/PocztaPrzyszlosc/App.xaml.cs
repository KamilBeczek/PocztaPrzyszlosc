using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.Stores;
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

        private readonly NavigationStore _navigationStore;

        public App()
        {
            _odbiorca = new Odbiorca();
            _nadawca = new Nadawca();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new NadajPaczkeViewModel(_nadawca, _odbiorca, _navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new ViewModelMain(_navigationStore)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
