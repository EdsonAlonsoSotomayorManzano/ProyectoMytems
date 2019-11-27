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
using System.Windows.Shapes;

namespace Mytems
{
    /// <summary>
    /// Lógica de interacción para Coins.xaml
    /// </summary>
    public partial class Coins : Window
    {
        public Coins()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PayMyCoinOxxo payMyCoinOxxo = new PayMyCoinOxxo();
            payMyCoinOxxo.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PayMyCoinOxxo payMyCoinOxxo = new PayMyCoinOxxo();
            payMyCoinOxxo.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PayMyCoinOxxo payMyCoinOxxo = new PayMyCoinOxxo();
            payMyCoinOxxo.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PayMyCoinOxxo payMyCoinOxxo = new PayMyCoinOxxo();
            payMyCoinOxxo.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PayMyCoinOxxo payMyCoinOxxo = new PayMyCoinOxxo();
            payMyCoinOxxo.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PayMyCoinOxxo payMyCoinOxxo = new PayMyCoinOxxo();
            payMyCoinOxxo.Show();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }
    }
}
