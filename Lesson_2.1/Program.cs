using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_enter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string greeting = Console.ReadLine();
            
            for (int i = greeting.Length - 1; i >= 0; i--)
            {
                Console.Write(greeting[i]);
            }
        }
    }
}

