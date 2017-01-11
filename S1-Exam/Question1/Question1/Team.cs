using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    abstract class Team : IComparable
    {
        public String TeamName { get; set; }
        public String Type { get; set; }
        public Player[] players;
        public static Random randomFactory = new Random();
        public String ManagerName { get; set; }

        //default constructor
        public Team()
        {

        }
        public Team(String teamName, String manager)
        {
            TeamName = teamName;
            ManagerName = manager;
        }

        //overriding ToString method
        public override string ToString()
        {
            return String.Format("{0} - {1}", TeamName, Type);
        }

        //implementing compare to method
        public int CompareTo(object obj)
        {
            Team tmp = obj as Team;
            return this.TeamName.CompareTo(tmp.TeamName);
        }

        //create an array of team playes of players length which is defined in the individual classes
        //and generate random dates & salaries for the players
        protected void CreateTeamPlayers()
        {
            for (int i = 0; i < players.Length; i++)
            {
                Player p = new Player();
               
                int value = randomFactory.Next(5, 50);

                p.Age = GenerateRandomAge(-36, -17);
                p.Value = value;
                players[i] = p;
            }
        }


        //generates a randome date time for the date of birth of the player
        //between starting and ending ranges
        public DateTime GenerateRandomAge(int startRange, int endRange)
        {
            DateTime start = DateTime.Today.AddYears(startRange);
            DateTime end = DateTime.Today.AddYears(endRange);

            int range = (end - start).Days;
            return start.AddDays(randomFactory.Next(range));
        }

        public override bool Equals(object obj)
        {
            Team tmp = obj as Team;
            return this.Type.Equals(tmp.Type);
        }


        //This method could also be declared here as below, as all sub-classes methods
        //implement the same logic, 
        public abstract void WriteInformationToFile();
        //public void WriteInformationToFile()
        //{
        //    String fileName = String.Format("Team {0} - {1}.txt", TeamName, Type);
        //    String[] lines = new String[players.Length];
        //    for (int i = 0; i < players.Length; i++)
        //    {
        //        Player p = players[i];
        //        String s = String.Format("{0},{1:dd/MM/yyyy},{2}", p.Name, p.Age, p.Value);
        //        lines[i] = s;
        //    }

        //    File.WriteAllLines(fileName, lines);
        //}

    }

    

   

    
}
