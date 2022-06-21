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

        private double Num1 = 0;
        private double Num2 = 0;
        private double count = 0;
        bool PrcntBtnActive = false;
        bool MultInvBtnActive = false;
        bool PwrBtnActive = false;
        bool SqrtBtnActive = false;
        bool DevBtnActive = false;
        bool TimesBtnActive = false;
        bool MinusBtnActive = false;
        bool AddBtnActive = false;
        bool ReverseBtnActive = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyFunction(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                Btn0_Click(sender, e);
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                Btn1_Click(sender, e);
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                Btn2_Click(sender, e);
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                Btn3_Click(sender, e);
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                Btn4_Click(sender, e);
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                Btn5_Click(sender, e);
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                Btn6_Click(sender, e);
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                Btn7_Click(sender, e);
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                Btn8_Click(sender, e);
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                Btn9_Click(sender, e);
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length > 0)
            {
                if (count >= 3)
                {
                    input.Text += ",0";
                    count = 1;
                }
                else
                {
                    input.Text += "0";
                    count++;
                }
            }
            else
            {
                return;
            }
            
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",1";
                count = 1;
            }
            else
            {
                input.Text += "1";
                count++;
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",2";
                count = 1;
            }
            else
            {
                input.Text += "2";
                count++;
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",3";
                count = 1;
            }
            else
            {
                input.Text += "3";
                count++;
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",4";
                count = 1;
            }
            else
            {
                input.Text += "4";
                count++;
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",5";
                count = 1;
            }
            else
            {
                input.Text += "5";
                count++;
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",6";
                count = 1;
            }
            else
            {
                input.Text += "6";
                count++;
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",7";
                count = 1;
            }
            else
            {
                input.Text += "7";
                count++;
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",8";
                count = 1;
            }
            else
            {
                input.Text += "8";
                count++;
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 3)
            {
                input.Text += ",9";
                count = 1;
            }
            else
            {
                input.Text += "9";
                count++;
            }
        }

        private void BtnPnt_Click(object sender, RoutedEventArgs e)
        {
            
                input.Text += ".";
                
        }

        private void PrcntBtn(object sender, RoutedEventArgs e)
        {

        }

        private void MultInvBtn(object sender, RoutedEventArgs e)
        {

        }

        private void PwrBtn(object sender, RoutedEventArgs e)
        {

        }

        private void SqrtBtn(object sender, RoutedEventArgs e)
        {

        }

        private void DevBtn(object sender, RoutedEventArgs e)
        {

        }

        private void TimesBtn(object sender, RoutedEventArgs e)
        {

        }

        private void MinusBtn(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn(object sender, RoutedEventArgs e)
        {
            Num1 = Num1
        }

        private void ResultBtn(object sender, RoutedEventArgs e)
        {

        }

        private void CnslEntBtn(object sender, RoutedEventArgs e)
        {

        }

        private void ClearBtn(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {

        }

        private void ReverseBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
