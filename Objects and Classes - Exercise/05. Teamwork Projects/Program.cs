using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string creator, string teamName)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();
        }
        public void AddMember(string memberToAdd)
        {
            this.Members.Add(memberToAdd);
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            List<string> createdTeams = new List<string>();
            List<string> creatorNames = new List<string>();
            List<string> memberNames = new List<string>();

            List<Team> teamsToDisband = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string command = Console.ReadLine();

                string[] commandToken = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = commandToken[0];
                string teamName = commandToken[1];
                if (creatorNames.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {

                    if (createdTeams.Contains(teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                    else
                    {
                        createdTeams.Add(teamName);
                        creatorNames.Add(creator);
                        memberNames.Add(creator);
                        Team team = new Team(creator, teamName);
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
            }
            string commandForWhile = Console.ReadLine();
            while (commandForWhile != "end of assignment")
            {
                string[] commandToken = commandForWhile.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string memberToAdd = commandToken[0];
                string teamToBeAddedTo = commandToken[1];

                if (!createdTeams.Contains(teamToBeAddedTo))
                {
                    Console.WriteLine($"Team {teamToBeAddedTo} does not exist!");
                }
                else
                {
                    if (memberNames.Contains(memberToAdd))
                    {
                        Console.WriteLine($"Member {memberToAdd} cannot join team {teamToBeAddedTo}!");
                    }
                    else
                    {
                        memberNames.Add(memberToAdd);
                        foreach (var team in teams)
                        {
                            if (team.TeamName == teamToBeAddedTo)
                            {
                                team.AddMember(memberToAdd);
                            }
                        }
                    }
                }
                commandForWhile = Console.ReadLine();
            }
            List<Team> teamsOrdered = teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            foreach (Team team in teamsOrdered)
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.Creator}");
                    team.Members.Sort();
                    foreach (var member in team.Members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
                else
                {
                    teamsToDisband.Add(team);
                }
            }
            teamsToDisband = teamsToDisband
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            Console.WriteLine("Teams to disband:");
            if (teamsToDisband.Count > 0)
            {
                foreach (var team in teamsToDisband)
                {
                    Console.WriteLine($"{team.TeamName}");
                }
            }
        }
    }
}
