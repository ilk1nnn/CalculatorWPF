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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double val = 0;
        string op = string.Empty;
        bool operator_pressed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            txtbox.Text = txtbox.Text + btn.Content.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtbox.Text = String.Empty;
        }

        private void DivideBtnClick(object sender, RoutedEventArgs e)
        {
            double digit = double.Parse(txtbox.Text);
            txtbox.Text = string.Empty;
            op = "/";
            val = digit;
            operator_pressed = true;
        }

        private void MultBtnClick(object sender, RoutedEventArgs e)
        {
            double digit = double.Parse(txtbox.Text);
            txtbox.Text = string.Empty;
            op = "*";
            val = digit;
            operator_pressed = true;
        }

        private void MinusBtnClick(object sender, RoutedEventArgs e)
        {
            double digit = double.Parse(txtbox.Text);
            txtbox.Text = string.Empty;
            op = "-";
            val = digit;
            operator_pressed = true;
        }

        private void PlusBtnClick(object sender, RoutedEventArgs e)
        {
            double digit = double.Parse(txtbox.Text);
            txtbox.Text = string.Empty;
            op = "+";
            val = digit;
            operator_pressed = true;
        }

        private void EqualBtnClick(object sender, RoutedEventArgs e)
        {
            if(op=="+")
            {
                txtbox.Text = (val+double.Parse(txtbox.Text)).ToString();
            }
            else if (op == "-")
            {
                txtbox.Text = (val - double.Parse(txtbox.Text)).ToString();
            }
            else if (op == "*")
            {
                txtbox.Text = (val * double.Parse(txtbox.Text)).ToString();
            }
            else if (op == "/")
            {
                if(double.Parse(txtbox.Text) == 0)
                {
                    MessageBox.Show("Cannot Divide TO Zero(0)!");
                }
                txtbox.Text = (val / double.Parse(txtbox.Text)).ToString();
            }
            else
            {
                operator_pressed = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double digit = double.Parse(txtbox.Text);
            txtbox.Text = string.Empty;
            txtbox.Text = "-"+(digit).ToString();
        }

        private void PercentBtnClick(object sender, RoutedEventArgs e)
        {
            double digit = double.Parse(txtbox.Text);
            txtbox.Text = string.Empty;
            txtbox.Text = (digit / 100).ToString();
        }
    }
}
