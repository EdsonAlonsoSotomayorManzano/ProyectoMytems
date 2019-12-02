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
    /// Lógica de interacción para VentanaCompras.xaml
    /// </summary>
    public partial class VentanaCompras : Window
    {
        OleDbConnection con;
        DataTable dt;
        OleDbDataAdapter da;

        public VentanaCompras()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb";
            Load_Data();
        }

        private void Load_Data()
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            int idItemInt = Convert.ToInt32(Items.NameBtn) + 1;
            string idItemString = idItemInt.ToString();
            switch (Home.selected)
            {
                case 1:
                    {
                        cmd.CommandText = "Select * from CSGO WHERE Id = " + idItemInt + "";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        TxtNameItem.Text = dt.Rows[0]["Objectname"].ToString().Trim();
                        txtPriceItem.Text = dt.Rows[0]["Price"].ToString().Trim();
                        txtDescItem.Text = dt.Rows[0]["Description"].ToString().Trim();
                        break;
                    }
                case 2:
                    {
                        cmd.CommandText = "Select * from Minecraft WHERE Id = " + idItemInt + "";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        TxtNameItem.Text = dt.Rows[0]["Objectname"].ToString().Trim();
                        txtPriceItem.Text = dt.Rows[0]["Price"].ToString().Trim();
                        txtDescItem.Text = dt.Rows[0]["Description"].ToString().Trim();
                        break;
                    }
                case 3:
                    {
                        cmd.CommandText = "Select * from Lol WHERE Id = " + idItemInt + "";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        TxtNameItem.Text = dt.Rows[0]["Objectname"].ToString().Trim();
                        txtPriceItem.Text = dt.Rows[0]["Price"].ToString().Trim();
                        txtDescItem.Text = dt.Rows[0]["Description"].ToString().Trim();
                        break;
                    }
                case 4:
                    {
                        cmd.CommandText = "Select * from Pokemon WHERE Id = " + idItemInt + "";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        TxtNameItem.Text = dt.Rows[0]["Objectname"].ToString().Trim();
                        txtPriceItem.Text = dt.Rows[0]["Price"].ToString().Trim();
                        txtDescItem.Text = dt.Rows[0]["Description"].ToString().Trim();
                        break;
                    }
                case 5:
                    {
                        cmd.CommandText = "Select * from Warcraft WHERE Id = " + idItemInt + "";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        TxtNameItem.Text = dt.Rows[0]["Objectname"].ToString().Trim();
                        txtPriceItem.Text = dt.Rows[0]["Price"].ToString().Trim();
                        txtDescItem.Text = dt.Rows[0]["Description"].ToString().Trim();
                        break;
                    }
                case 6:
                    {
                        cmd.CommandText = "Select * from Fortnite WHERE Id = " + idItemInt + "";
                        da = new OleDbDataAdapter(cmd.CommandText, con.ConnectionString);
                        dt = new DataTable();
                        da.Fill(dt);
                        TxtNameItem.Text = dt.Rows[0]["Objectname"].ToString().Trim();
                        txtPriceItem.Text = dt.Rows[0]["Price"].ToString().Trim();
                        txtDescItem.Text = dt.Rows[0]["Description"].ToString().Trim();
                        break;
                    }

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CbAcc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            Confirm_trading confirmbuy = new Confirm_trading();
            confirmbuy.Show();
            this.Hide();
        }

        private void Compras_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Items items = new Items();
            items.Show();
        }
    }
}
