using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace CA_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare class level variables
        private List<Member> members;
        private static Random randomFactory;
        public MainWindow()
        {
            InitializeComponent();
        }

        //window loaded, initialise list of members & combobox
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            randomFactory = new Random();
            members = new List<Member>();

            //create type objects
            MembershipType full = new MembershipType("Full");
            MembershipType offPeak = new MembershipType("Off Peak");
            MembershipType student = new MembershipType("Student");
            MembershipType oap = new MembershipType("OAP");

            //creating members using constructors
            Member m1 = new Member(
                "Ted Crilly",
                "087 123 4567",
                "1 O Connell St. Sligo",
                full,
                GenerateRandomDate(16, 1)
                );
            members.Add(m1);

            Member m2 = new Member(
               "Dougal Maguire",
               "087 321 6547",
               "1 Main St. Sligo",
               student,
               GenerateRandomDate(16, 1)
               );
            members.Add(m2);

            Member m3 = new Member(
               "Jack Hackett",
               "087 123 4567",
               "27 Caltragh Heights Sligo",
               oap,
               GenerateRandomDate(16, 1)
               );
            members.Add(m3);

            Member m4 = new Member(
               "Jesse Bloggs",
               "087 788 1441",
               "33 Diagon Alley Sligo",
               oap,
               GenerateRandomDate(16, 1)
               );
            members.Add(m4);

            Member m5 = new Member(
              "Mrs Doyle",
              "087 788 1441",
              "33 Wizard Lane",
              offPeak,
              GenerateRandomDate(16, 1)
              );
            members.Add(m5);

            //set source of list box
            lbxMembers.ItemsSource = members;
            //set source of combo box
            cbxMemberType.ItemsSource = GetMemberhipTypes();
        }

        //generating a list of membership types for the combobox
        //using HashSet as it will only hold unique values
        private HashSet<String> GetMemberhipTypes()
        {
            HashSet<String> list = new HashSet<string>();
            //addng all as an option to view all members
            list.Add("All");
            foreach (var m in members)
            {
                list.Add(m.MemberShipType.ToString());
            }
            return list;
        }


        //random year generator between two years
        private static int GenerateRandomDate(int year1, int year2)
        {
            DateTime today = DateTime.Now;
            DateTime startDate = today.AddYears(-year1);
            DateTime endDate = today.AddYears(-year2);
            TimeSpan ts = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, randomFactory.Next(0, (int)ts.TotalMinutes), 0);
            DateTime newDate = startDate + newSpan;
            return newDate.Year;
        }


        //display member details once selected in list box
        private void lbxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member member = lbxMembers.SelectedItem as Member;
            // chech for null, and only use the member object if not null
            if (member != null)
            {
                txtMemberDetails.Text = member.DisplayMemberDetails();
            }
            else txtMemberDetails.Text = "";
            
        }

        //combo box change
        private void cbxMemberType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selectedItem = cbxMemberType.SelectedItem as String;
            lbxMembers.ItemsSource = FilterMembersByType(selectedItem);
        }

        //searches the members list and returns a list of matches 
        //for the query passed in
        private List<Member> FilterMembersByType(String query)
        {
            //if all is the option selected, return all members
            if (query.Equals("All"))
            {
                return members;
            }

            List<Member> list = new List<Member>();
            foreach (var m in members)
            {
                if (m.MemberShipType.Equals(query))
                {
                    list.Add(m);
                }
            }
            return list;
        }

        //search button pressed
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //set combobox to all, as we are only filtering by either combobox or text field
            cbxMemberType.SelectedItem = "All";
            String query = txtSearch.Text;
            lbxMembers.ItemsSource = FilterMembersByName(query);
        }


        //search member list by first or last name
        private List<Member> FilterMembersByName(String query)
        {
            List<Member> list = new List<Member>();
            foreach (var m in members)
            {
                if (m.Name.Contains(query))
                {
                    list.Add(m);
                }
            }
            return list;
        }
    }
}
