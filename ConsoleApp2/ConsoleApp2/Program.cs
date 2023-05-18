using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3х значное число:");
            int num = int.Parse(Console.ReadLine());
            int change = num % 10;
            change += num / 100 * 10;
            change += num / 10 % 10 * 100;
            Console.WriteLine(change);
        }
    }
}
