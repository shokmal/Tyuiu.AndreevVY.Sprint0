using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AndreevVY.Sprint0.Task4.V0.Lib;

namespace Tyuiu.AndreevVY.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(2, 3));
            Console.WriteLine(DataService.Subtraction(10, 2));
            Console.WriteLine(DataService.Multiplicaton(3, 8));
            Console.WriteLine(DataService.Division(6, 3));

            Console.ReadKey();
        }
    }
}
