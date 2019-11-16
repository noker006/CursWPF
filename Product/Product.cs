using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CursWPF
{
    [Serializable]
    public class Product
    {

        public string nameProduct;

        public Car productCar = new Car();
        public Car ProductCar { get { return productCar; } set{ productCar = value; } }

        protected Phone productPhone = new Phone(); 
        public Phone ProductPhone { get { return productPhone; } set { productPhone = value; } }


        
    }
}
