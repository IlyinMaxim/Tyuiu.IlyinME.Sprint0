using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IlyinME.Sprint0.Task4.V0.Lib;

namespace Tyuiu.IlyinME.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(11, 7));
            Console.WriteLine(DataService.Subtraction(11, 7));
            Console.WriteLine(DataService.Multiplication(7, 11));
            Console.WriteLine(DataService.Division(77, 11));

            Console.ReadKey();
        }
    }
}
