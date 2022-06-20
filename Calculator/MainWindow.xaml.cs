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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long Num1 = 0;
        long Num2 = 0;
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyFunction(object sender, KeyEventArgs e)
        {
            switch (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
            {
                case Key.NumPad0:
                    Btn0_Click(sender, e);
                    break;
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10);
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10);
                input.Text = Num2.ToString();
            }
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 1;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 1;
                input.Text = Num2.ToString();
            }
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 2;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 2;
                input.Text = Num2.ToString();
            }
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 3;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 3;
                input.Text = Num2.ToString();
            }
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 4;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 4;
                input.Text = Num2.ToString();
            }
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 5;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 5;
                input.Text = Num2.ToString();
            }
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 6;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 6;
                input.Text = Num2.ToString();
            }
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 7;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 7;
                input.Text = Num2.ToString();
            }
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 8;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 8;
                input.Text = Num2.ToString();
            }
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                Num1 = (Num1 * 10) + 9;
                input.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 9;
                input.Text = Num2.ToString();
            }
        }

        private void ResultBtn(object sender, RoutedEventArgs e)
        {

        }

        private void OperatorBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
