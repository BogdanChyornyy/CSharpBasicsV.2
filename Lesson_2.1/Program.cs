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

            //2.Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            Console.WriteLine("Введите порядковый номер месяца (от 1 до 12): ");
            int indexmont = int.Parse(Console.ReadLine());
            if (indexmont < 1 || indexmont > 12)
            {
                Console.WriteLine("Некоректный ввод данных!");
                Console.WriteLine("Введите порядековый номер месяца: ");
                indexmont = int.Parse(Console.ReadLine());
                int realmonth = indexmont -= 1;
                Console.WriteLine(month[realmonth]);
            }
            else
            {
                int realmonth = indexmont -= 1;
                Console.WriteLine(month[realmonth]);
            }

        }
    }
}