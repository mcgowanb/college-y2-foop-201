using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBoxNumber.Focus();
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);

        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(txtBoxNumber.Text);

            string grade = GetGradeFromNumber(number);
            txtBoxLetter.Text = grade;
            txtBoxNumber.Focus();
            txtBoxNumber.SelectAll();
        }

        private string GetGradeFromNumber(int numberGrade)
        {
            String letterGrade;
            if (numberGrade >= 88)
            {
                letterGrade = "A";
            } else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            } else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            } else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            } else
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
    }
}
