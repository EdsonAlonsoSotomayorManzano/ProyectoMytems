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
        DataTable dt;

        public MainWindow()
        {
       
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb";
         
        }
        

        private void btnFPass_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mytems.com.mx/forgot-your-password-");
            con.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)

        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            string User = this.txtUsarname.Text;
            string Password = this.passbd.Password;
            if (User == "" || Password == "")
            {
                MessageBox.Show("Insert User Name and Password");
                this.txtUsarname.Focus();
                return;
            }
            else
            {
                if (txtUsarname.Text != "")
                {
                    if (txtUsarname.IsEnabled == true)
                    {
                        cmd.CommandText = "Select * from Register where Us = '" + txtUsarname.Text.Trim() + "'";
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        if (dt.Rows.Count>0)
                        {
                            if (passbd.Password != dt.Rows[0]["Pass"].ToString().Trim())
                            {
                                MessageBox.Show("The Password is incorrect");
                            }
                            else
                            {
                                Home Home = new Home();
                                this.Hide();
                                Home.Show();
                                MessageBox.Show("Welcome Pleyer :D", "Mytems",MessageBoxButton.OK,MessageBoxImage.Asterisk);
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The Username is incorrect");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty field");
                }

            }
            con.Close();
        }
        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register Regiswindow = new Register();
            Regiswindow.Show();
            this.Close();
        }


    }


     
    
}
