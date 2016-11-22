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

namespace TestScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int TotalScore { get; set; }
        public int ScoreCount { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtScoreIn.Focus();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int score = Convert.ToInt32(txtScoreIn.Text);
            ScoreCount++;
            TotalScore += score;

            txtScoreCount.Text = ScoreCount.ToString();
            txtScoreTotal.Text = TotalScore.ToString();
            double average = (double)TotalScore / ScoreCount;
            txtScoreAverage.Text = average.ToString("0.00");

            txtScoreIn.Text = "";
            txtScoreIn.Focus();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtScoreCount.Text = txtScoreTotal.Text = txtScoreAverage.Text = "";
            TotalScore = ScoreCount = 0;
            txtScoreIn.Focus();
        }
    }
}
