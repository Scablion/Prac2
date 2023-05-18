using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.Write("day =");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k >= 1 && k <= 365)
            { for (int i = 7; k >= i;) { k = k - i; } }
            count = k;
            if (count == 0) { Console.WriteLine("номер дня недели 1"); }
            else if (count == 1) { Console.WriteLine("номер дня недели 2"); }
            else if (count == 2) { Console.WriteLine("номер дня недели 3"); }
            else if (count == 3) { Console.WriteLine("номер дня недели 4"); }
            else if (count == 4) { Console.WriteLine("номер дня недели 5"); }
            else if (count == 5) { Console.WriteLine("номер дня недели 6"); }
            else if (count == 6) { Console.WriteLine("номер дня недели 0"); }
        }
    }
}
