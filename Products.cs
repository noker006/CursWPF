using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CursWPF
{
    public class Products
    {
        public Car ProductCar { get; set; }

        public Phone ProductPhone { get; set; }

        public ObservableCollection<string> NameProduct = new ObservableCollection<string>();

    }
}
