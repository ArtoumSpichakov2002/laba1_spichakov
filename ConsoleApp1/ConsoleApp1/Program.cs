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
            string first, last;

         Console.WriteLine("Введите ваше первое имя ");
            first = Console.ReadLine();
            Console.WriteLine("Введите ваше второе имя ");
            last = Console.ReadLine();
            Console.WriteLine("Hello" + first, last);
            Console.ReadLine();
        }
    }
}
