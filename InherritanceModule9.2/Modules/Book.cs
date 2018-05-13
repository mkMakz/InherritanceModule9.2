using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._2.Modules
{
    public enum Authors { Pushkin, Chehov, Dostaevskiy, Bulgakov }
    public enum Boooks { FairyTale, Fantasy, Poetry, Poem }

    public class Book : Product
    {
        private Random rand = new Random();
        public Authors Author { get; set; }


        public Book()
        {
            Author = (Authors)rand.Next(0, 3);
        }

        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name {Name}\n Author {Author}\n Price {Price}\n Manufacturer {Manufacturer}\n Age {Age}\n");

        }


    }
}
