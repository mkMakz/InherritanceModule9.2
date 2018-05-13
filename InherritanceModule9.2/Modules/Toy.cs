using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._2.Modules
{
    public enum Materials { Plastic, Metal, Wood, Aluminum }
    public enum ForToys { Car, Doll, KubicRubic, Yula }

    public class Toy : Product
    {
        public Materials Material { get; set; }


        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name {Name}\n Price {Price}\n Manufacturer {Manufacturer}\n Material {Material}\n Age {Age}\n");
        }
    }
}
