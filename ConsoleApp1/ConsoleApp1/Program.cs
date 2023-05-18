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
            string num = Console.ReadLine();
            string reverse = "";
            reverse += num[1];
            reverse += num[2];
            reverse += num[0];
            Console.WriteLine(reverse);
        }
    }
}
