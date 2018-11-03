using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoTicket = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char char1 = 'B'; char1 <= 'L'; char1+=(char)2)
            {
                for (char char2 = 'f'; char2 >= 'a'; char2--)
                {
                    for (char char3 = 'A'; char3 <= 'C'; char3++)
                    {
                        for (int char4 = 1; char4 <= 10; char4++)
                        {
                            for (int char5 = 10; char5 >= 1; char5--)
                            {
                                counter++;
                                if (counter == peshoTicket)
                                {
                                    Console.WriteLine($"Ticket combination: {char1}{char2}{char3}{char4}{char5}");
                                    Console.WriteLine($"Prize: {char1 + char2 + char3 + char4 + char5} lv.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
