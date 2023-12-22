using System;
using System.Collections.Generic;
using System.Linq;

namespace P_05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string teamFounder = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Founder == teamFounder))
                {
                    Console.WriteLine($"{teamFounder} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(teamName, teamFounder));
                    Console.WriteLine($"Team {teamName} has been created by {teamFounder}!");
                }
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] joinArgs = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string member = joinArgs[0];
                string teamName = joinArgs[1];

                Team currentTeam = teams.FirstOrDefault(t => t.Name == teamName);

                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(member)) || teams.Any(t => t.Founder == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    currentTeam.AddMember(member);
                }
                input = Console.ReadLine();
            }

            List<Team> populatedTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            foreach (var team in populatedTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Founder}");

                team.Members.Sort();
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public Team(string name, string owner)
        {
            this.Name = name;
            this.Founder = owner;
            this.Members = new List<string>();
        }

        public string Name { get; set; }

        public string Founder { get; set; }

        public List<string> Members = new List<string>();

        public void AddMember(string name)
        {
            this.Members.Add(name);
        }
    }
}
