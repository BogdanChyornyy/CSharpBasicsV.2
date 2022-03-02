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

            /* 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру. */

            float mintemp, maxtemp;

            Console.WriteLine("Сбор данных о среднесуточной температуре.");

            Console.WriteLine("Введите минимальную температуру за день ");

            mintemp = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за день ");

            maxtemp = float.Parse(Console.ReadLine());

            float avertemp = (mintemp + maxtemp) / 2;

            Console.WriteLine("Среденесуточная температура: " + avertemp);

        }
    }
}