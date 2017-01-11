using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Team> teams;
        HashSet<String> filterList;
        public MainWindow()
        {
            InitializeComponent();
        }

        //onload method. creates what objects are needed to display the main page
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            teams = new List<Team>();
            //Team t1 = new Team("LiverPool", "Some Guy");
            //Team t2 = new Team("Manchester United", "Jose");
            //Team t3 = new Team("Leinster", "Tom Thumb");
            //Team t4 = new Team("Chicago Bulls", "Joe Bloggs");
            //Team t5 = new Team("New York Nicks", "Cecil B Demille");
            //Team t6 = new Team("Connacht", "Mike Wasawski");

            Team t1 = new SoccerTeam("LiverPool", "Jurgen Klopp");
            Team t2 = new SoccerTeam("Manchester United", "Jose Marinho");
            Team t3 = new RugbyTeam("Leinster", "Tom Thumb");
            Team t4 = new BasketBallTeam("Chicago Bulls", "Cecil B Demille");
            Team t5 = new BasketBallTeam("New York Nicks", "Joe Bloggs");
            Team t6 = new RugbyTeam("Connacht", "Mike Wasawski");

            teams.Add(t1);
            teams.Add(t2);
            teams.Add(t3);
            teams.Add(t4);
            teams.Add(t5);
            teams.Add(t6);

            teams.Sort();
            lbxTeams.ItemsSource = teams;

            //Using HashSet as it will filter unique values only, so the list will have no duplicates
            HashSet<String> filterList = new HashSet<string>();
            filterList.Add("All");
            foreach (var team in teams)
            {
                filterList.Add(team.Type);
            }
            cbxFilterList.ItemsSource = filterList;
        }

        //change listner for the teams list box selection change
        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team team = lbxTeams.SelectedItem as Team;
            if (team != null)
            {
                lblManager.Content = team.ManagerName;
                lbxPlayers.ItemsSource = team.players;
            }
        }


        //change listner for the combo box filter change
        private void cbxFilterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selected = cbxFilterList.SelectedItem as String;
            lbxPlayers.ItemsSource = "";
            lblManager.Content = "";

            if (selected == "All")
            {
                lbxTeams.ItemsSource = teams;
            }
            else
            {
                List<Team> filteredTeams = new List<Team>();
                foreach (var item in teams)
                {
                    if (item.Type.Equals(selected))
                    {
                        filteredTeams.Add(item);
                    }
                }
                lbxTeams.ItemsSource = filteredTeams;
            }
        }


        //listner for the save button
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Team team = lbxTeams.SelectedItem as Team;
            if (team != null)
            {
                team.WriteInformationToFile();
            }
        }
    }
}
