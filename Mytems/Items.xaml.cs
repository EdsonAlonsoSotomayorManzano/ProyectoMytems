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
    /// Lógica de interacción para CSGO.xaml
    /// </summary>
    public partial class Items : Window
    {
        OleDbConnection con;
        DataTable dt;
        OleDbDataAdapter da;

        public Items()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb";
            LoadGame();

        }
        private void LoadGame()
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            switch (Home.selected)
            {
                case 1:
                    {
                        cmd.CommandText = "Select * from CSGO";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText = "Select * from Minecraft";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        break;
                    }
                case 3:
                    {
                        cmd.CommandText = "Select * from Lol";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        break;
                    }
                case 4:
                    {
                        cmd.CommandText = "Select * from Pokemon";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        break;
                    }
                case 5:
                    {
                        cmd.CommandText = "Select * from Warcraft";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        break;
                    }
                case 6:
                    {
                        cmd.CommandText = "Select * from Fortnite";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        CreatingStackPanel();
                        break;
                    }

            }
        }

        private void CreatingStackPanel()
        {
            string ola;
            int create = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i >= create; i++)
                { 
                    StackPanel stack = new StackPanel();
                    {
                       Name = "stackpanel" + i;
                        Button btnBuyObj = new Button();
                        {
                            Name = "btnBuyObj" + i;
                            Content = "Buy";
                            Margin = new Thickness(429, 0, 0, 0);
                            HorizontalAlignment =HorizontalAlignment.Left;
                            VerticalAlignment = VerticalAlignment.Top;
                            Height = 27;
                            Width = 157;
                            Background = new SolidColorBrush(Color.FromRgb(54, 182, 255));
                            Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                        }
                        TextBlock NameObj = new TextBlock();
                        {
                            Name = "TitleObj" + i;
                            Content = dt.Rows[i]["Objectname"].ToString().Trim();
                            Margin = new Thickness(236, 60, 0, 0);
                            HorizontalAlignment = HorizontalAlignment.Left;
                        }
                    }
                    
                }
            }
         }
            
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CbAcc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnBuyAWP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBuyKnife_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
