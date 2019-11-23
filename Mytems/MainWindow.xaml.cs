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

     
        
        public MainWindow()
        {
            InitializeComponent();
           
        }
        OleDbConnection Conexion = new OleDbConnection ("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb");

        private void btnFPass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)

        {
                                                  
            Conexion.Open();

            //: Aquí especificamos los campos a tomar con sus textbox correspondientes
            String Consulta = "select Pass, Email from Registrer where txtPassword ='" + txtPassword.Text + "' and txtUsarname ='" + txtUsarname.Text + "'";

            //: Aquí Creamos una variable para unir la consulta y la conexion
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

            //:Creamos una variable para leer los datos
            OleDbDataReader LectorDatos;

            //: Aquí ejecutamos el lector de datos
            LectorDatos = Comando.ExecuteReader();

            //: Aquí creamos una variable booleana para ver si existe el registro
            bool ExistenciaRegistros = LectorDatos.HasRows;
            if (ExistenciaRegistros)
            {
                //: SI existe el registro mostrar el form siguiente
                MessageBox.Show("Bienvenido " + txtUsarname.Text);


                Register Regiswindow = new Register();
                Regiswindow.Show();
                this.Close();
            }

            else
            {

                //: SI no existe volver al paso de logueo
                MessageBox.Show("Acceso denegado " + txtUsarname.Text, "Usuario NO encontrado");


                return;

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
