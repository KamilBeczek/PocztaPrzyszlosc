using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using PocztaPrzyszlosc.Models;
using PocztaPrzyszlosc.ViewModels;

namespace PocztaPrzyszlosc.Views
{
    /// <summary>
    /// Interaction logic for ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Window
    {
        private NadawcaViewModel data;
        private readonly Nadawca _nadawca;

        public ClientPage()
        {
            InitializeComponent();
            data = new NadawcaViewModel(_nadawca);
            DataContext = data;
           

        }


    }
}
