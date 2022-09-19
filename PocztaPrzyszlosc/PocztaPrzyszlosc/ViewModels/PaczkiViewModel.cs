using PocztaPrzyszlosc.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PocztaPrzyszlosc.ViewModels
{
    public class PaczkiViewModel : ViewModelBase
    {
        public ICommand NadajPaczkeCommand { get; }

        public PaczkiViewModel()
        {
           
        }
    }
}
