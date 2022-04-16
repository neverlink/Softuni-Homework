using System;

namespace P_04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidatePassword(Console.ReadLine());
        }

        static void ValidatePassword(string password)
        {
            bool fulfillsLength = isRequiredLength(password);
            bool fulfillsChars = containsEnoughDigits(password);
            if (fulfillsLength && fulfillsChars)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool isRequiredLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        static bool containsEnoughDigits(string password)
        {
            int digitCount = 0;
            bool isValid = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    digitCount++;
                    continue;
                }
                else if (!Char.IsLetterOrDigit(password[i]))
                {
                    isValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }
            if (digitCount < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            return isValid;
        }
    }
}
