﻿using System;
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
            int[,] matrix = new int[5, 5];
            int x = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == x && j == x)
                    {
                        x++;
                        matrix[i, j] = 1;
                        Console.Write($"{matrix[i, j]} ");
                    }
                    else
                        System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}