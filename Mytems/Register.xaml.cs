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
using Mytems.Clases;
using SQLite;

namespace Mytems
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro()
            {
                Name = txtFNAME.Text,
                Lastname = txtLNAME.Text,
                Username = txtUsarname.Text,
                Password = txtPass.Text,
                Email = txtEmail.Text
            };

            using (SQLiteConnection conexion = new  SQLiteConnection(App.databasePath))
            {
                conexion.CreateTable<Registro>();
                conexion.Insert(registro);
            }

            MainWindow login =  new MainWindow();
            login.Show();
            this.Close(); 
        }
    }
}
