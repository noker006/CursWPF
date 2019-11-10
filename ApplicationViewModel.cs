using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;


namespace CursWPF
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
    //    private Phone selectedPhone;

    //    private Car selectedCar;

    //public ObservableCollection<Car> Cars { get; set; }
    //public ObservableCollection<Phone> Phones { get; set; }

    //public Car SelectedCar
    //{
    //    get { return selectedCar; }
    //    set
    //    {
    //        selectedCar = value;
    //        OnPropertyChanged("SelectedPhone");
    //    }
    //}

    //public Phone SelectedPhone
    //    {
    //        get { return selectedPhone; }
    //        set
    //        {
    //            selectedPhone = value;
    //            OnPropertyChanged("SelectedPhone");
    //        }
    //    }

    public ObservableCollection<Products> Products { get; set; }
    public ApplicationViewModel()
            {
                Phones = new ObservableCollection<Phone>
            {
                new Phone { Title="iPhone 7", Company="Apple", Price=56000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                new Phone {Title="Elite x3", Company="HP", Price=56000 },
                new Phone {Title="Mi5S", Company="Xiaomi", Price=35000 }
            };
            Cars = new ObservableCollection<Car>
            {
                new Car { Title="MACHINBmw", Company="BMW", Price=56000 },
                new Car {Title="GalaxyAudi", Company="AUDI", Price =60000 },
                new Car {Title="weReno", Company="RENO", Price=56000 },
                new Car {Title="MiMan", Company="MAN", Price=35000 }
            };

            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName]string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    
}
