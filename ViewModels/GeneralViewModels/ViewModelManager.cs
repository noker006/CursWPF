using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursWPF.ViewModels.GeneralViewModels
{
    class ViewModelManager:MainViewModel
    {
        public RootVM()
        {
           
        }

        public object CurrentVM
        {
            //тут и происходит магия смены VM
            get
            {
                if (_currentVM == null)
                {
                    _currentVM = _viewModels[0];
                    CurrentVM = _currentVM;
                }

                if (_currentVM == this)
                {
                    System.Windows.Application.Current.Shutdown();
                }

                return _currentVM;
            }
            set
            {
                _currentVM = value;
                OnPropertyChanged("CurrentVM");
            }
        }
    }
}
