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
        public static string NameBtn;

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
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("Images/header_586x192.jpg", UriKind.Relative);
                        bi3.EndInit();
                        ImageGame.Stretch = Stretch.Fill;
                        ImageGame.Source = bi3;
                        cmd.CommandText = "Select * from CSGO";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 2:
                    {
                        ImageGame.Width = 400;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("Images/p1_2348574_cdf2effa.jpg", UriKind.Relative);
                        bi3.EndInit();
                        ImageGame.Stretch = Stretch.Fill;
                        ImageGame.Source = bi3;
                        cmd.CommandText = "Select * from Minecraft";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 3:
                    {
                        ImageGame.Width = 450;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("Images/450_1000 (1).jpg", UriKind.Relative);
                        bi3.EndInit();
                        ImageGame.Stretch = Stretch.Fill;
                        ImageGame.Source = bi3;
                        cmd.CommandText = "Select * from Lol";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 4:
                    {
                        ImageGame.Width = 310;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("Images/poke crianza2.0.jpg", UriKind.Relative);
                        bi3.EndInit();
                        ImageGame.Stretch = Stretch.Fill;
                        ImageGame.Source = bi3;
                        cmd.CommandText = "Select * from Pokemon";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 5:
                    {
                        ImageGame.Width = 470;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("Images/450_1000.jpg", UriKind.Relative);
                        bi3.EndInit();
                        ImageGame.Stretch = Stretch.Fill;
                        ImageGame.Source = bi3;
                        cmd.CommandText = "Select * from Warcraft";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        CreatingStackPanel(cmd);
                        break;
                    }
                case 6:
                    {
                        ImageGame.Width = 460;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("Images/Fortnite_battle-pass_season-x_S10_KeyArt_LineUp_Logo_1920x1080-1920x1080-4deed5e28027cea2c5d6ab36321f3eaa32b8f6ce.jpg", UriKind.Relative);
                        bi3.EndInit();
                        ImageGame.Stretch = Stretch.Fill;
                        ImageGame.Source = bi3;
                        cmd.CommandText = "Select * from Fortnite";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmd.ExecuteNonQuery();
                        CreatingStackPanel(cmd);
                        break;
                    }

            }
        }

        private void CreatingStackPanel(OleDbCommand cmd)
        {
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                { 
                    StackPanel stack = new StackPanel
                    {
                       Name = "stackpanel" + i.ToString()
                    };
                    spitem.Children.Add(stack);

                    //Image imageObj = new Image();
                    //imageObj.Name = "imageObj" + i.ToString();
                    //imageObj.Height = 100;
                    //imageObj.Width = 200;
//
                    //stack.Children.Add(imageObj);

                    stack.Children.Add(new TextBlock
                    {
                        Name = "TitleObj" + i.ToString(),
                        Text = dt.Rows[i]["Objectname"].ToString().Trim(),
                        Margin = new Thickness(236, 30, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 30,
                        Width = 700,
                        FontSize = 20,
                        FontWeight = FontWeights.SemiBold
                    }); ;
                    stack.Children.Add(new TextBlock
                    {
                        Name = "ColorObj" + i.ToString(),
                        Text = dt.Rows[i]["Color"].ToString().Trim(),
                        Margin = new Thickness(236, 0, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 18,
                        Width = 164,
                        FontSize = 14
                    });
                    stack.Children.Add(new TextBlock
                    {
                        Name = "PriceObj" + i.ToString(),
                        Text = dt.Rows[i]["Price"].ToString().Trim(),
                        Margin = new Thickness(236, 0, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 18,
                        Width = 164,
                        FontSize = 14
                    });
                    stack.Children.Add(new TextBlock
                    {
                        Name = "DescObj" + i.ToString(),
                        Text = dt.Rows[i]["Description"].ToString().Trim(),
                        Margin = new Thickness(236, 0, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height = 35,
                        Width = 1350,
                        FontSize = 12
                    });

                    Button btnBuy = new Button();
                    btnBuy.Name = "btn" + i.ToString();
                    btnBuy.Content = "Buy";
                    btnBuy.Margin = new Thickness(429, 0, 0, 0);
                    btnBuy.HorizontalAlignment = HorizontalAlignment = HorizontalAlignment.Left;
                    btnBuy.VerticalAlignment = VerticalAlignment = VerticalAlignment.Top;
                    btnBuy.Height = Height = 27;
                    btnBuy.Width = Width = 157;
                    btnBuy.Background = Brushes.Cyan;

                    btnBuy.Click += new RoutedEventHandler(this.button_click);

                stack.Children.Add(btnBuy);

                    stack.Children.Add(new Label
                    {
                        Name = "SeparatorObj" + i.ToString(),
                        Margin = new Thickness(0, 10, 0, 0),
                        Height = 1,
                        Width = 1600,
                        Background = Brushes.Black
                    });
                }
                reader.Close();
                con.Close();
            }
            reader.Close();
            con.Close();
         }

        void button_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            string ReplaceName = btn.Name;
            NameBtn = ReplaceName.Replace("btn", "");
            VentanaCompras buyit = new VentanaCompras();
            buyit.Show();
            this.Hide();
        }

        private static BitmapImage BytesToImage(byte[] bytes)
        {
            BitmapImage bm = new BitmapImage();
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
            this.Close();
            Home.Show();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Items_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
