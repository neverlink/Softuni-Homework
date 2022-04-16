using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_08.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = 1;

            while(num <= input)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
