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

            //5*. Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

            string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            Console.WriteLine("Введите порядковый номер месяца (от 1 до 12): ");
            int indexmont = int.Parse(Console.ReadLine());
                        
            if (indexmont < 1 || indexmont > 12)
            {
                Console.WriteLine("Некорректный ввод данных!");
                Console.WriteLine("Введите порядковый номер месяца: ");
                indexmont = int.Parse(Console.ReadLine());
                int realmonth = indexmont -= 1;


                float mintemp, maxtemp;
                Console.WriteLine("Введите минимальную температуру за день ");
                mintemp = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальную температуру за день ");
                maxtemp = float.Parse(Console.ReadLine());
                float avertemp = (mintemp + maxtemp) / 2;
                                

                if ((indexmont == 0 || indexmont == 1 || indexmont == 11) && avertemp > 0)
                {
                    Console.WriteLine("Выбранный месяц - " + month[realmonth]);
                    Console.WriteLine("Дождливая зима");
                }
                else
                {
                    Console.WriteLine("Выбранный месяц - " + month[realmonth]);
                }

            }
            else
            {
                int realmonth = indexmont -= 1;

                float mintemp, maxtemp;
                Console.WriteLine("Введите минимальную температуру за день ");
                mintemp = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальную температуру за день ");
                maxtemp = float.Parse(Console.ReadLine());
                float avertemp = (mintemp + maxtemp) / 2;

                if ((indexmont == 0 || indexmont == 1 || indexmont == 11) && avertemp > 0)
                {
                    Console.WriteLine("Выбранный месяц - " + month[realmonth]);
                    Console.WriteLine("Дождливая зима");
                }
                else
                {
                    Console.WriteLine("Выбранный месяц - " + month[realmonth]);
                }
            }

        }
    }
}