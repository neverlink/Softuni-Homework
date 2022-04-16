using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine()) * 100;
            double hallWidth = double.Parse(Console.ReadLine()) * 100;
            double wardrobeSide = double.Parse(Console.ReadLine()) * 100;
            double wardrobeArea = wardrobeSide * wardrobeSide;

            double hallArea = hallWidth * hallLength;
            double benchArea = hallArea / 10;
            double freeArea = hallArea - benchArea - wardrobeArea;

            double possibleDancers = freeArea / 7040;
            Console.WriteLine(Math.Floor(possibleDancers));
        }
    }
}
