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
using System.Data.OleDb;
using System.Data;

namespace Mytems
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OleDbConnection con;
        
        public MainWindow()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb";
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = " Select * from Register";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            
        }

        private void btnFPass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            
            {
                string constring = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb";
                string comandText = "select Count(*) from Login where txtUsarname=? and [txtPassword]=?";
                using (OleDbConnection con = new OleDbConnection(constring))
                using (OleDbCommand command = new OleDbCommand(comandText, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@p1", txtUsarname.Text);
                    cmd.Parameters.AddWithValue("@p2", txtPassword.Text);  // <- is this a variable or a textbox?
                    int result = (int)cmd.ExecuteScalar();
                    if (result <0)
                    {
                        Register Regiswindow = new Register();
                        Regiswindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials, Please Re-Enter");
                    }
                }
            }

           





        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register Regiswindow = new Register();
            Regiswindow.Show();
            this.Close();
        }
    }
}
