using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._2.Modules
{
    public abstract class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Manufacturer { get; set; }
        public int Age { get; set; }


        public abstract void PrintInfo();
        public abstract void Check(Type type);

    }
}
