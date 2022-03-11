using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_enter
{
    internal class Program
    {        
        [Flags]
        public enum DayOfWeek
        {
            monday = 0b_0000001,
            tuesday = 0b_0000010,
            wednesday = 0b_0000100,
            thursday = 0b_0001000,
            friday = 0b_0010000,
            saturday = 0b_0100000,
            sunday = 0b_1000000

        }

        static void Main(string[] args)
        {
            //Работает без выходных:
            DayOfWeek type1 = DayOfWeek.monday | DayOfWeek.tuesday | DayOfWeek.wednesday | DayOfWeek.thursday | DayOfWeek.friday | DayOfWeek.saturday | DayOfWeek.sunday;
            //Работает 5/2:
            DayOfWeek type2 = DayOfWeek.monday | DayOfWeek.tuesday | DayOfWeek.wednesday | DayOfWeek.thursday | DayOfWeek.friday;
            //Работает 4/3:
            DayOfWeek type3 = DayOfWeek.monday | DayOfWeek.tuesday | DayOfWeek.wednesday | DayOfWeek.thursday;

            DayOfWeek everyDayOfWeek = (DayOfWeek)0b_1111111;           

            DayOfWeek office1 = everyDayOfWeek & type1;
            DayOfWeek office2 = everyDayOfWeek & type2;
            DayOfWeek office3 = everyDayOfWeek & type3;

            bool isNoWeekend = office1 == type1;
            bool isFiveToTwo = office2 == type2;
            bool isFourToThree = office3 == type3;            

            if (isNoWeekend)
            {
                Console.WriteLine("Work days of first corp: " + office1);
            }
            if (isFiveToTwo)
            {
                Console.WriteLine("Work days of second corp: " + office2);
            }
            if (isFourToThree)
            {
                Console.WriteLine("Work days of third corp: " + office3);
            }            
        }            
    }
}

