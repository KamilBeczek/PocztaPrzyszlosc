using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.Services;
using PocztaPrzyszlosc.Services.Creator;
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
        private const string CONNECTION_STRING = "Server=DESKTOP-C9V743L\\SQLEXPRESS;Database=PocztaPrzyszlosc;Trusted_Connection=True;";

        private readonly NavigationStore _navigationStore;
        private readonly PocztaPrzyszloscDbContextFactory _pocztaPrzyszloscDbContextFactory;

        public App()
        {
            _pocztaPrzyszloscDbContextFactory = new PocztaPrzyszloscDbContextFactory(CONNECTION_STRING);
            IOdbiorcaProvider odbiorcaProvider = new DatabasePocztaProvider(_pocztaPrzyszloscDbContextFactory);
            IPocztaPrzyszloscCreator odbiorcaCreator = new DatabaseOdbiorcaCreator(_pocztaPrzyszloscDbContextFactory);
            Odbiorca odbiorca = new Odbiorca(odbiorcaProvider, odbiorcaCreator);
            _nadawca = new Nadawca();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(CONNECTION_STRING).Options;
            using (PocztaPrzyszloscDbContext dbContext = _pocztaPrzyszloscDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }

            _navigationStore.CurrentViewModel = CreaateNadajPaczkeViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new ViewModelMain(_navigationStore)
            };

            MainWindow.Show();
            base.OnStartup(e);

        }

        private NadajPaczkeViewModel CreaateNadajPaczkeViewModel()
        {
            return new NadajPaczkeViewModel(_nadawca, _odbiorca, _navigationStore, CreatrePaczkiViewModel);
        }

        private PaczkiViewModel CreatrePaczkiViewModel()
        {
            return new PaczkiViewModel(_navigationStore, CreaateNadajPaczkeViewModel);
        }
    }
}
