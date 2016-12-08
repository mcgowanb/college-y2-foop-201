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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            txtOperand1.Focus();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal one = Convert.ToDecimal(txtOperand1.Text);
            decimal two = Convert.ToDecimal(txtOperand2.Text);
            txtResult.Text = Calculate(
                Convert.ToDecimal(txtOperand1.Text),
                txtOperator.Text,
                Convert.ToDecimal(txtOperand2.Text)
                ).ToString();
            txtOperand1.Focus();
        }

        private decimal Calculate(decimal op1, string operand, decimal op2)
        {
            switch (operand)
            {
                case "+":
                    return op1 + op2;
                case "-":
                    return op1 - op2;
                case "/":
                    return op1 / op2;
                case "*":
                    return op1 * op2;
                case "%":
                    return op1 % op2;
                default:
                    return 0;
            }
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtResult.Text = "";
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The New command was invoked");
        }
    }
}
