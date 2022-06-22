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
        private double Count = 0;
        private double ComCount = 0;
        bool PntBtnActive = false;
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
            else if (e.Key == Key.Decimal)
            {
                BtnPnt_Click(sender, e);
            }
            else if (e.Key == Key.Back)
            {
                BackBtn(sender, e);
            }
            else if (e.Key == Key.Delete)
            {
                CansEntrBtn(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
               ResultBtn(sender, e); 
            }
            else if (e.Key == Key.Divide)
            {
                DevBtn(sender, e);
            }
            else if (e.Key == Key.Multiply)
            {
                TimesBtn(sender, e);
            }
            else if (e.Key == Key.Subtract)
            {
                MinusBtn(sender, e);
            }
            else if (e.Key == Key.Add)
            {
                AddBtn(sender, e);
            }

        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length > 0)
            {
                if (ComCount >= 3 && Count <= 14)
                {
                    input.Text += ",0";
                    ComCount = 1;
                    Count++;
                }
                else if (Count <= 14)
                {
                    input.Text += "0";
                    ComCount++;
                    Count++;
                }
            }
            
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",1";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "1";
                ComCount++;
                Count++;
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",2";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "2";
                ComCount++;
                Count++;
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",3";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "3";
                ComCount++;
                Count++;
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",4";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "4";
                ComCount++;
                Count++;
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",5";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "5";
                ComCount++;
                Count++;
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",6";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "6";
                ComCount++;
                Count++;
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",7";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14) if(Count <= 15)
            {
                input.Text += "7";
                ComCount++;
                Count++;
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",8";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "8";
                ComCount++;
                Count++;
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (ComCount >= 3 && Count <= 14)
            {
                input.Text += ",9";
                ComCount = 1;
                Count++;
            }
            else if(Count <= 14)
            {
                input.Text += "9";
                ComCount++;
                Count++;
            }
        }

        private void BtnPnt_Click(object sender, RoutedEventArgs e)
        {
            if (PntBtnActive == false)
            {
                input.Text +=".";
                PntBtnActive = true;
                Count = 0;
            }
        }

        private void MultInvBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text);
                calculation.Text = "1/(" + input.Text + ")";
                Num2 = 1 / Num1;
                input.Text = Num2.ToString();
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = true;
                PwrBtnActive = false;
                SqrtBtnActive = false;
                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
                ReverseBtnActive = false;
            }
        }

        private void PwrBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text);
                calculation.Text = "sqr(" + input.Text + ")";
                Num2 = Num1 * Num1;
                input.Text = Num2.ToString();
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = false;
                PwrBtnActive = true;
                SqrtBtnActive = false;
                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
                ReverseBtnActive = false;
            }
        }

        private void SqrtBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != null)
            {
                Num1 = double.Parse(input.Text);
                calculation.Text = "\u221A(" + input.Text + ")";
                Num2 = Math.Sqrt(Num1);
                input.Text = Num2.ToString();
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = false;
                PwrBtnActive = false;
                SqrtBtnActive = true;
                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
                ReverseBtnActive = false;
            }
        }

        private void DevBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != null)
            {
                Num1 = Double.Parse(input.Text);
                calculation.Text = input.Text + "/";
                input.Text = "";
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = false;
                PwrBtnActive = false;
                SqrtBtnActive = false;
                DevBtnActive = true;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
                ReverseBtnActive = false;
            }
        }

        private void TimesBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text);
                calculation.Text = input.Text + "x";
                input.Text = "";
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = false;
                PwrBtnActive = false;
                SqrtBtnActive = false;
                DevBtnActive = false;
                TimesBtnActive = true;
                MinusBtnActive = false;
                AddBtnActive = false;
                ReverseBtnActive = false;
            }
        }

        private void MinusBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text);
                calculation.Text = input.Text + "-";
                input.Text = "";
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = false;
                PwrBtnActive = false;
                SqrtBtnActive = false;
                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = true;
                AddBtnActive = false;
                ReverseBtnActive = false;
            }
        }

        private void AddBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text);
                calculation.Text = input.Text + "+";
                input.Text = "";
                Count = 0;
                ComCount = 0;

                MultInvBtnActive = false;
                PwrBtnActive = false;
                SqrtBtnActive = false;
                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = true;
                ReverseBtnActive = false;
            }
        }

        private void ResultBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                if ( DevBtnActive == true)
                {
                    Num2 = Num1 / double.Parse(input.Text);
                    calculation.Text = Num1 + "/" + input.Text;
                    input.Text = Num2.ToString();
                }
                else if ( TimesBtnActive == true)
                {
                    Num2 = Num1 * double.Parse(input.Text);
                    calculation.Text = Num1 + "x" + input.Text;
                    input.Text = Num2.ToString();
                }
                else if ( MinusBtnActive == true)
                {
                    Num2 = Num1 - double.Parse(input.Text);
                    calculation.Text = Num1 + "-" + input.Text;
                    input.Text = Num2.ToString();
                }
                else if ( AddBtnActive == true)
                {
                    Num2 = Num1 + double.Parse(input.Text);
                    calculation.Text = Num1 + "+" + input.Text;
                    input.Text = Num2.ToString();
                }
            }
            else if (input.Text == "")
            {
                input.Text = "Can't calculate with zero or nothing";
            }
        }

        private void CansEntrBtn(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            Count = 0;
            ComCount = 0;

            PntBtnActive = false;
        }

        private void ClearBtn(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            calculation.Text = "";
            Count = 0;
            ComCount = 0;

            PntBtnActive = false;
            MultInvBtnActive = false;
            PwrBtnActive = false;
            SqrtBtnActive = false;
            DevBtnActive = false;
            TimesBtnActive = false;
            MinusBtnActive = false;
            AddBtnActive = false;
            ReverseBtnActive = false;
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                input.Text = input.Text.Remove(input.Text.Length - 1);
                if (ComCount == 1)
                {
                    input.Text = input.Text.Remove(input.Text.Length - 1);
                    ComCount = 3;
                    Count--;
                }
                else
                {
                    ComCount--;
                    Count--;
                }
            }
        }

        private void ReverseBtn(object sender, RoutedEventArgs e)
        {
            Num1 = 2 * double.Parse(input.Text);
            Num2 = double.Parse(input.Text) - Num1;
            input.Text = Num2.ToString();
        }
    }
}
