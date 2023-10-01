using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AndreevVY.Sprint0.Task5.V0.Lib;

namespace Tyuiu.AndreevVY.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(2, 3));
            Console.WriteLine("A - B = " + DataService.Subtraction(10, 3));
            Console.WriteLine("A * b = " + DataService.Multiplicaton(12, 2));
            Console.WriteLine("A / B = " + DataService.Division(10, 5));

            Console.ReadKey();
        }
    }
}
