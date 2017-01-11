using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class BasketBallTeam : Team
    {

        //default no args constructor
        public BasketBallTeam()
        {

        }
        //2 args constructor, also calling parent constructor
        public BasketBallTeam(String name, String manager) : base(name, manager)
        {
            Type = "BasketBall";
            players = new Player[5];
            CreateTeamPlayers();
            players[0].Name = "John";
            players[1].Name = "Frank";
        }

        //writing specific team information to file
        //create an array of strings and write them as lines to the file
        public override void WriteInformationToFile()
        {
            String fileName = String.Format("Team {0} - {1}.txt", TeamName, Type);
            String[] lines = new String[players.Length];
            for (int i = 0; i < players.Length; i++)
            {
                Player p = players[i];
                String s = String.Format("{0},{1:dd/MM/yyyy},{2}", p.Name, p.Age, p.Value);
                lines[i] = s;
            }

            File.WriteAllLines(fileName, lines);
        }
    }

}
