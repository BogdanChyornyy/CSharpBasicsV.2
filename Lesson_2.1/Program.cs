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

            //3.Проверка числа на четность.

            Console.WriteLine("Введите число для проверки на четность: ");
            int number = int.Parse(Console.ReadLine());
            int divis = number % 2;
            if (divis == 0)
            {
                Console.WriteLine("Число " + number + " - четное.");
            }
            else
            {
                Console.WriteLine("Число " + number + " - не четное.");
            }

        }
    }
}