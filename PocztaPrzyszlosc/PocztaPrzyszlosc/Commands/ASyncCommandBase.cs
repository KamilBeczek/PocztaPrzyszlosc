using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc.Commands
{
    public abstract class ASyncCommandBase : CommandBase

    {
        private bool _isExectuing;

        public bool IsExectuing
        {
            get 
            {  
                return _isExectuing; 
            }

            set 
            { 
                _isExectuing = value;
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !IsExectuing && base.CanExecute(parameter);
        }

        public override async void Execute(object parameter)
        {
            IsExectuing = true;

            try
            {
              await ExecuteAsync(parameter);
            }

            finally
            {
                IsExectuing = false;
            }

        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
