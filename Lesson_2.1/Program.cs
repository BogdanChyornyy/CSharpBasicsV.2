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
            string[,] directory = new string[5, 2];
            string[] name = { "John", "Sarah", "Tony", "Nick", "Taylor"};
            string[] number = { "89111111111", "89222222222", "89333333333", "89444444444", "89555555555"};
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++) 
                {
                    if (j == 0) 
                    {
                    directory[i, j] = name[i];
                    System.Console.Write($"{directory[i, j]} ");
                    }
                    else
                    {
                    directory[i, j] = number[i];
                    System.Console.Write($"{directory[i, j]} ");
                    }
                    
                }
                System.Console.WriteLine();
            }

        }
    }
}