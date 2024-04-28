using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Правды д.1", 10, 20, 30);
            MultiBuilding multiBuilding = new MultiBuilding("ул. Правды д.1", 10, 20, 30, 9);

            Console.WriteLine(building.Print());
            Console.WriteLine();
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
