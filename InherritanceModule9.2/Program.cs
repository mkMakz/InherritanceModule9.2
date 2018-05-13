using InherritanceModule9._2.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator creator = new Creator();

            creator.GenerateToys();
            creator.GenerateBooks();
            creator.GenerateSportEquipments();

            creator.PrintAll();

        }
    }
}
