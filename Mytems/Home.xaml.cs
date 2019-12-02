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
{    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public static int selected;
        public Home()
        {
            InitializeComponent();
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selected = 1;
            Items ItemWindow = new Items();
            ItemWindow.Show();
            this.Close();
        }

        private void btnminecraft_Click(object sender, RoutedEventArgs e)
        {
            selected = 2;
            Items ItemWindow = new Items();
            ItemWindow.Show();
            this.Close();
        }

        private void btnLol_Click(object sender, RoutedEventArgs e)
        {
            selected = 3;
            Items ItemWindow = new Items();
            ItemWindow.Show();
            this.Close();
        }

        private void btnpokemon_Click(object sender, RoutedEventArgs e)
        {
            selected = 4;
            Items ItemWindow = new Items();
            ItemWindow.Show();
            this.Close();
        }

        private void btnwarcraft_Click(object sender, RoutedEventArgs e)
        {
            selected = 5;
            Items ItemWindow = new Items();
            ItemWindow.Show();
            this.Close();
        }

        private void btnFortnite_Click(object sender, RoutedEventArgs e)
        {
            selected = 6;
            Items ItemWindow = new Items();
            ItemWindow.Show();
            this.Close();
        }

        private void MYCOINS_Click(object sender, RoutedEventArgs e)
        {
            Coins coinswindows = new Coins();
            coinswindows.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShopCar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbAcc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to leave?", "Mytems",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
                MainWindow login = new MainWindow();
                login.Show();
                this.Close();
            }
           
        }
    }
}
