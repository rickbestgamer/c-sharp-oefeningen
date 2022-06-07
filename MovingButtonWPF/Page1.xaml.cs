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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            BtnMoveMe.MouseMove += BtnMoveMe_MouseMove;
        }

        private void BtnMoveMe_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Thickness th = new Thickness();
            Random random = new Random();
            int w = random.Next(0, (int)MyGrid.ActualWidth - (int)btn.ActualWidth);
            int t = random.Next(0, (int)MyGrid.ActualHeight - (int)btn.ActualHeight);
            th.Left = w;
            th.Top = t;
            btn.Margin = th;
        }
    }
}
