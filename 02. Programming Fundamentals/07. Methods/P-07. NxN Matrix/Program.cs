﻿using System;

namespace P_07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMatrix(int.Parse(Console.ReadLine()));
        }

        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
