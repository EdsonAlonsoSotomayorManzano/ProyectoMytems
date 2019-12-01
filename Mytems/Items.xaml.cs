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
using System.Media;
using System.Resources;
using System.IO;


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
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 2:
                    {
                        cmd.CommandText = "Select * from Minecraft";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 3:
                    {
                        cmd.CommandText = "Select * from Lol";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 4:
                    {
                        cmd.CommandText = "Select * from Pokemon";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 5:
                    {
                        cmd.CommandText = "Select * from Warcraft";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 6:
                    {
                        cmd.CommandText = "Select * from Fortnite";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        CreatingStackPanel(cmd);
                        break;
                    }

            }
        }

        private void CreatingStackPanel(OleDbCommand cmd)
        {
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int create = dt.Rows.Count;
            svItems.Height = create * 271;
            spitem.Height = create * 271;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= create - 1; i++)
                { 
                    StackPanel stack = new StackPanel
                    {
                       Name = "stackpanel" + i.ToString()
                    };
                    spitem.Children.Add(stack);
                    stack.Children.Add(new TextBlock
                    {
                        Name = "TitleObj" + i.ToString(),
                        Text = dt.Rows[i]["Objectname"].ToString().Trim(),
                        Margin = new Thickness(236, 60, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 46,
                        Width = 363,
                        FontSize = 20
                    });
                    stack.Children.Add(new TextBlock
                    {
                        Name = "ColorObj" + i.ToString(),
                        Text = dt.Rows[i]["Color"].ToString().Trim(),
                        Margin = new Thickness(236, 0, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 27,
                        Width = 164,
                        FontSize = 12
                    });
                    stack.Children.Add(new TextBlock
                    {
                        Name = "PriceObj" + i.ToString(),
                        Text = dt.Rows[i]["Price"].ToString().Trim(),
                        Margin = new Thickness(236, 0, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 27,
                        Width = 164,
                        FontSize = 12
                    });
                    stack.Children.Add(new Button
                    {
                        Name = "btnBuyObj" + i.ToString(),
                        Content = "Buy",
                        Margin = new Thickness(429, 0, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top,
                        Height = 27,
                        Width = 157,
                        Background = new SolidColorBrush(Color.FromRgb(54, 182, 255)),
                        Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0))
                    });
                }
            }
            reader.Close();
            con.Close();
         }

        private static BitmapImage BytesToImage(byte[] bytes)
        {
            var bm = new BitmapImage();
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                stream.Position = 0;
                bm.BeginInit();
                bm.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                bm.CacheOption = BitmapCacheOption.OnLoad;
                bm.UriSource = null;
                bm.StreamSource = stream;
                bm.EndInit();
            }
            return bm;
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
