using System;
using System.Collections.Generic;

namespace P_03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> messages = new List<string>();

            while (input != "end")
            {
                string[] cmdArgs = input.Split();
                string cmd = cmdArgs[0];

                if (cmd == "Chat")
                {
                    messages.Add(cmdArgs[1]);
                }
                else if (cmd == "Delete")
                {
                    messages.Remove(cmdArgs[1]);
                }
                else if (cmd == "Edit")
                {
                    int indexToReplace = messages.IndexOf(cmdArgs[1]);
                    messages.Insert(indexToReplace, cmdArgs[2]);
                    messages.RemoveAt(indexToReplace + 1);
                }
                else if (cmd == "Pin")
                {
                    if (messages.Contains(cmdArgs[1]))
                    {
                        messages.Add(cmdArgs[1]);
                        messages.Remove(cmdArgs[1]);
                    }
                }
                else if (cmd == "Spam")
                {
                    messages.AddRange(cmdArgs[1..]);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, messages));
        }
    }
}
