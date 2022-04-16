using System;
using System.Collections.Generic;
using System.Linq;

namespace P_03._Hero_Recruitment
{
    internal class Program
    {
        static readonly List<Hero> heroes = new List<Hero>();

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandParams = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                string commandName = commandParams[0];

                if (commandName == "Enroll")
                {
                    EnrollHero(commandParams[1]);
                }
                else
                {
                    string heroName = commandParams[1];
                    string spellName = commandParams[2];

                    Hero currHero = heroes.FirstOrDefault(x => x.Name == heroName);

                    if (currHero == null)
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (commandName == "Learn")
                    {
                        currHero.LearnSpell(spellName);
                    }
                    else
                    {
                        currHero.UnlearnSpell(spellName);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Name}: {string.Join(", ", hero.spells)}");
            }
        }

        static public void EnrollHero(string heroName)
        {
            if (heroes.Any(x => x.Name == heroName))
            {
                Console.WriteLine($"{heroName} is already enrolled.");
            }
            else
            {
                heroes.Add(new Hero(heroName));
            }
        }
    }

    class Hero
    {
        public string Name { get; set; }

        public List<string> spells { get; set; }

        public Hero(string name)
        {
            this.Name = name;
            this.spells = new List<string>();
        }
        public bool IsLearnt(string spellName)
        {
            return spells.Contains(spellName);
        }

        public void LearnSpell(string spellName)
        {
            if (IsLearnt(spellName))
            {
                Console.WriteLine($"{this.Name} has already learnt {spellName}.");
            }
            else
            {
                spells.Add(spellName);
            }
        }

        public void UnlearnSpell(string spellName)
        {
            if (IsLearnt(spellName))
            {
                spells.Remove(spellName);
            }
            else
            {
                Console.WriteLine($"{this.Name} has already learnt {spellName}.");
            }
        }
    }
}