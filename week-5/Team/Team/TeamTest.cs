using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class TeamTest
    {
        static void Main(string[] args)
        {
            Team SligoRovers = new Team("Sligo Rovers", "Some Guy");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("Derry City");
            Team Dundalk = new Team("Dundalk");

            Team[] teams = new Team[5];
            teams[0] = SligoRovers;
            teams[1] = FinnHarps;
            teams[2] = GalwayUnited;
            teams[3] = DerryCity;
            teams[4] = Dundalk;

            printTeams(teams);

            SligoRovers.AddResult(Team.Result.Win);
            FinnHarps.AddResult(Team.Result.Lose);
            FinnHarps.AddResult(Team.Result.Draw);
            GalwayUnited.AddResult(Team.Result.Win);
            Dundalk.AddResult(Team.Result.Lose);

            printTeams(teams);

            Array.Sort(teams);
            Array.Reverse(teams);
            printTeams(teams);

        }

        private static void printTeams(Team[] teams)
        {
            Console.WriteLine("{0,-20}{6,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "Team Name", "Points", "Wins", "Draws", "Losses", "Played", "Manager");
            foreach (Team t in teams)
            {
                Console.WriteLine("{0,-20}{6,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", t.TeamName, t.Points, t.NoOfWins, t.NoOfDraws, t.NoOfLosses, t.TotalGames, t.ManagerName);
            }
            Console.WriteLine();
        }
    }
}
