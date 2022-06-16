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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumBtn(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            input.Text = btn.Content.ToString();
        }

        private void OperatorBtn(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            input.Text = bt.Content.ToString();
        }

        private void ClearBtn(object sender, RoutedEventArgs e)
        {

        }

        private void ReverseBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
