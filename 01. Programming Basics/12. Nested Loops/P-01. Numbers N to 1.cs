﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01._Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
