using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class Team : IComparable
    {
        private string teamName;
        private int noOfWins, noOfDraws, noOfLosses, totalGames, points;
        public enum Result { Win, Draw, Lose }

        public string TeamName { get { return teamName; } }
        public int NoOfWins { get { return noOfWins; } }
        public int NoOfDraws { get { return noOfDraws; } }
        public int NoOfLosses { get { return noOfLosses; } }
        public int TotalGames { get { return totalGames; } }
        public int Points { get { return points; } }

        public String ManagerName { get; set; }

        public Team(String teamName)
        {
            this.teamName = teamName;
        }

        public Team(String teamName, String managerName) : this(teamName)
        {
            ManagerName = managerName;
        }

        public void AddResult(Result result)
        {
            switch (result)
            {
                case Result.Win:
                    points += 3;
                    totalGames++;
                    noOfWins++;
                    break;
                case Result.Draw:
                    points++;
                    noOfDraws++;
                    totalGames++;
                    break;
                default:
                    totalGames++;
                    noOfLosses++;
                    break;
            }
        }

        public int CompareTo(object obj)
        {
            Team temp = (Team)obj;
            return this.points.CompareTo(temp.points);
        }
    }
}
