using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._2.Modules
{
    public enum SportsEq { Cycle, Scooter, Rollers, Skateboard }

    public class SportsEquipment : Product
    {

        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name {Name}\n Price {Price}\n Manufacturer {Manufacturer}\n Age {Age}\n");
        }
    }
}
