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

namespace MovingButtonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnMoveMe.MouseMove += BtnMoveMe_MouseMove;
            BtnMoveMe.Click += BtnMoveMe_Click;
        }

        private void BtnMoveMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je hebt me te pakken");
        }

        private async Task MoveButton(Thickness th)
        {
            await Task.Delay(300);
            BtnMoveMe.Margin = th;
            BtnMoveMe.MouseMove += BtnMoveMe_MouseMove;
        }

        private void BtnMoveMe_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Thickness th = new Thickness();
            Random random = new Random();
            int w = random.Next(0, (int)MyGrid.ActualWidth - (int)btn.ActualWidth);
            int t = random.Next(0, (int)MyGrid.ActualHeight - (int)btn.ActualHeight);
            BtnMoveMe.MouseMove -= BtnMoveMe_MouseMove;
            th.Left = w;
            th.Top = t;
            _ = MoveButton(th);
        }

    }
}
