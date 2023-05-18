using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3х значное число: ");
            int num = int.Parse(Console.ReadLine());
            int reverse = num % 100;
            reverse = num / 100 + reverse * 10;
            Console.WriteLine(reverse);
        }
    }
}
