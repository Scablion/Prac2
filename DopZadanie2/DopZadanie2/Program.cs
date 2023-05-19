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
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер столетия =" + (year / 100 + 1));
        }
    }
}
