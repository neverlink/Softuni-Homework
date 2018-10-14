using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
