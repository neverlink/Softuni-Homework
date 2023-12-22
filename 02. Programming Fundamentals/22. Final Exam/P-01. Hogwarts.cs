using System;
using System.Text;

namespace P_01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Abracadabra")
            {
                string[] commandParams = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                string commandName = commandParams[0];
                switch (commandName)
                {
                    case "Abjuration":
                        spell = Abjure(spell);
                        break;
                    case "Necromancy":
                        spell = Necromance(spell);
                        break;
                    case "Illusion":
                        spell = Illude(spell,
                            int.Parse(commandParams[1]),
                            char.Parse(commandParams[2]));
                        break;
                    case "Divination":
                        spell = Divine(spell,
                            commandParams[1],
                            commandParams[2]);
                        break;
                    case "Alteration":
                        spell = Alter(spell,
                            commandParams[1]);
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
                command = Console.ReadLine();
            }
        }
        private static string Abjure(string spell)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in spell)
            {
                sb.Append(char.ToUpper(c));
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private static string Necromance(string spell)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in spell)
            {
                sb.Append(char.ToLower(c));
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private static string Illude(string spell, int index, char letter)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(spell);

            if (index >= 0 && index < spell.Length)
            {
                sb[index] = letter;
                Console.WriteLine("Done!");
                return sb.ToString();
            }
            else
            {
                Console.WriteLine("The spell was too weak.");
                return spell;
            }
        }

        private static string Divine(string spell, string strToReplace, string replacement)
        {
            if (spell.Contains(strToReplace))
            {
                spell = spell.Replace(strToReplace, replacement);
                Console.WriteLine(spell);
            }
            return spell;
        }
        private static string Alter(string spell, string strToRemove)
        {
            if (spell.Contains(strToRemove))
            {
                spell = spell.Replace(strToRemove, string.Empty);
                Console.WriteLine(spell);
            }
            return spell;
        }
    }
}