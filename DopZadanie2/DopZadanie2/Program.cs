using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopZadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите год");
            int year = int.Parse(Console.ReadLine()) / 100 + 1;
            Console.WriteLine($"{year} столетие") ;

        }
    }
}
