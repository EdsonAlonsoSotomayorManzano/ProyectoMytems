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
using System.Data.OleDb;
using System.Data;

namespace Mytems
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Register : Window
    {
        
        OleDbConnection con;
        DataTable dt;
        public Register()
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
            dt = new DataTable();
            da.Fill(dt);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
             if (txtFNAME.Text !="")
            {
                if (txtFNAME.IsEnabled==true)
                {
                    cmd.CommandText = "insert into Register (Firstname, Lastname, Us, Email, Pass, ConfirmPassword)  Values('" + txtFNAME.Text +
                     "','" + txtLNAME.Text + "','" + txtUsarname.Text + "','" + txtEmail.Text + "','" + pass.Password + "','" + confpass.Password + "')";
                    cmd.ExecuteNonQuery();
                    MostrarDatos();
                    if (confpass.Password != pass.Password)
                    {
                        MessageBox.Show("The Password is not the same");
                    }
                    else
                    {
                        MessageBox.Show("User Registered Succesfully");
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty field");
            }

            

            MainWindow login =  new MainWindow();
            login.Show();
            this.Close();

           
        }

        private void TxtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
