using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double avgPassesngerHeight = double.Parse(Console.ReadLine());

            double shipSpace = width * length * height;
            double roomSpace = 2 * 2 * (avgPassesngerHeight + 0.40);
            int humanCapacity = (int)(shipSpace / roomSpace);
            if (humanCapacity >= 3 && humanCapacity <= 10)
            {
                Console.WriteLine($"The spacecraft holds {humanCapacity} astronauts.");
            }
            else if (humanCapacity < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
