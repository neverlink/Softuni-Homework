using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01.Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int area = sideA * sideA;
            Console.WriteLine(area);
        }
    }
}
