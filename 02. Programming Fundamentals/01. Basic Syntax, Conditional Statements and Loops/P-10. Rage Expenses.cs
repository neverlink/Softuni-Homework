using System;

namespace P_10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetsBroken = gamesLost / 2;
            int mousesBroken = gamesLost / 3;
            int keyboardsBroken = gamesLost / 6;
            int displaysBroken = keyboardsBroken / 2; 

            double expenses = headsetsBroken * headsetPrice
                            + mousesBroken * mousePrice
                            + keyboardsBroken * keyboardPrice
                            + displaysBroken * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
