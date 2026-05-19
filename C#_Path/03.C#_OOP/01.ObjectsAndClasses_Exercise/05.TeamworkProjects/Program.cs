using System.Text;

class Program
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Name}");
            result.AppendLine($"- {Creator}");

            Members = Members.OrderBy(m => m).ToList();

            foreach (string member in Members)
            {
                result.AppendLine($"-- {member}");
            }

            return result.ToString().Trim();
        }
    }

    static void Main()
    {
        List<Team> teams = new List<Team>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] teamCommand = Console.ReadLine().Split("-");
            string teamCreator = teamCommand[0];
            string teamName = teamCommand[1];

            bool teamNameExists = teams.Exists(t => t.Name == teamName);
            if (teamNameExists)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            Team teamCreatorFound = teams.FirstOrDefault(t => t.Creator == teamCreator);
            if (teamCreatorFound != null)
            {
                Console.WriteLine($"{teamCreator} cannot create another team!");
                continue;
            }

            Team newTeam = new Team(teamName, teamCreator);
            teams.Add(newTeam);
            Console.WriteLine($"Team {newTeam.Name} has been created by {newTeam.Creator}!");
        }

        string command = "";
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] args = command.Split("->");
            string joinerName = args[0];
            string teamName = args[1];

            bool anyTeam = teams.Any(t => t.Name == teamName);
            if (!anyTeam)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (teams.Any(t => t.Creator == joinerName) || teams.Any(t => t.Members.Contains(joinerName)))
            {
                Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                continue;
            }

            Team foundTeam = teams.Find(t => t.Name == teamName);
            foundTeam.Members.Add(joinerName);
        }

        List<Team> leftTeams = teams.FindAll(t => t.Members.Count > 0).ToList();

        List<Team> orderedTeams = leftTeams
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name)
            .ToList();

        orderedTeams.ForEach(t => Console.WriteLine(t.Print()));

        Console.WriteLine("Teams to disband:");
        List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0).ToList();
        orderedTeams = disbandTeams.OrderBy(t => t.Name).ToList();

        orderedTeams.ForEach(t => Console.WriteLine(t.Name));
    }
}