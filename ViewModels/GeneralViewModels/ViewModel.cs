using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursWPF.ViewModels.GeneralViewModels
{
    class ViewModel
    {
        protected RelayCommand _command;
        public string Name { set; get; }
        public ViewModelManager Root { set; get; }

        public ViewModel(string name, RootVM root)
        {
            Name = name;
            Root = root;
        }

        public object GoTo
        {
            get
            {
                return _command ??
                    (_command = new RelayCommand(obj =>
                    {
                        string needOpen = obj as string;
                        Root.GoToWindow(needOpen);
                    }));
            }
        }
    }
}
