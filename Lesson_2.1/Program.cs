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

            //4.Создание чека.

            string name_of_owner = "ИП Чёрный Б.К.";
            string defolt = "Кассовый чек";
            string IE = "ИП ЧЁРНЫЙ БОГДАН КОНСТАНТИНОВИЧ";
            string cashier = "Иванов И.И.";
            string location = "Калининградская обл. г. Калининград ул. Нарвская д. 12.";
            string place = "Кофейня";

            Console.WriteLine("Приветствуем вас в нашей кофейне!");
            Console.WriteLine("Укажите номер напитка: ");
            Console.WriteLine("1. Капучино 100р");
            Console.WriteLine("2. Латте 100р");
            Console.WriteLine("3. Эспрессо 80р");
            string[] choice = { "Капучино", "Латте", "Эспрессо" };

            int coffee_number = int.Parse(Console.ReadLine());
            int real_number = coffee_number -= 1;

            int[] coffee_price = { 100, 100, 80 };
            int coffee_price_numder = real_number;

            Console.WriteLine("Сколько чашек кофе вы желаете?");
            int quontity_coffee = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько пакетиков сахара вам положить?");
            Console.WriteLine("Один пакетик сахара 5р.");
            int sugar = int.Parse(Console.ReadLine());
            int sugar_price = 5;

            int type = real_number;
            int total = sugar * sugar_price + quontity_coffee * coffee_price[coffee_price_numder];

            Console.WriteLine(name_of_owner);
            Console.WriteLine(defolt);
            Console.WriteLine(choice[type] + " *" + quontity_coffee + " =" + quontity_coffee * coffee_price[coffee_price_numder]);
            Console.WriteLine("НДС не облагается");
            Console.WriteLine("Сахар " + " *" + sugar + " =" + sugar * sugar_price);
            Console.WriteLine("НДС не облагается");
            Console.WriteLine("------------------------");
            Console.WriteLine("ИТОГ " + " =" + total);
            Console.WriteLine("------------------------");
            Console.WriteLine("СУММА БЕЗ НДС " + " =" + total);
            Console.WriteLine("Кассир " + cashier);
            Console.WriteLine(IE);
            Console.WriteLine(location);
            Console.WriteLine("Место расчетов " + place);
            Console.WriteLine("СПАСИБО ЗА ПОКУПКУ!");
        }
    }
}