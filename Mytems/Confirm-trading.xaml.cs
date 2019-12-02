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
    /// Lógica de interacción para Confirm_trading.xaml
    /// </summary>
    public partial class Confirm_trading : Window
    {
        public static int buyer = 0;
        public static int seller = 0;
        public Confirm_trading()
        {
            InitializeComponent();
            VentanaCompras ventana = new VentanaCompras();
            txtNameObj.Text = ventana.TxtNameItem.Text;
            txtDescObj.Text = ventana.txtDescItem.Text;
        }

        private void TxtSerch_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CbAcc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnShopCar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MYCOINS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnConfirmBuyer_Click(object sender, RoutedEventArgs e)
        {
            buyer = 1;
            if (buyer == 1 && seller == 1)
            {
                MessageBox.Show("Successful purchase");
                Home Home = new Home();
                this.Hide();
                Home.Show();

            }
        }

            private void BtnConfirmSeller_Click(object sender, RoutedEventArgs e)
        {
            seller = 1;
            if (buyer == 1 && seller == 1)
            {
                MessageBox.Show("Successful purchase");
                Home Home = new Home();
                this.Hide();
                Home.Show();
            }
                
                
        }

        private void ConfirmTrading_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VentanaCompras compras = new VentanaCompras();
            this.Hide();
            compras.Show();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }
    }
}
