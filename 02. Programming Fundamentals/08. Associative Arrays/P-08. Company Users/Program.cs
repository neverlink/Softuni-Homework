using System;
using System.Collections.Generic;

namespace P_08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] splitParams = input.Split(" -> ",
                    StringSplitOptions.RemoveEmptyEntries);

                string companyName = splitParams[0];
                string employeeId = splitParams[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>() { employeeId });
                }

                input = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (string employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}

