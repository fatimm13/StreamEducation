using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamEducation
{
    public partial class fRecuperarContrasena : Form
    {
        private string nombre;
        public fRecuperarContrasena(string n)
        {
            nombre = n;
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string CONNECTION = Properties.Settings.Default.COMPLETE;
            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT contrasena FROM tUsuario WHERE correo = '" + nombre + "' and pregunta ='"+comboPregunta.SelectedIndex+"'and upper(respuesta) = '"+tNombre.Text.ToUpper()+"';";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                
                string c = (string)rdr[0];
                fMostrarContrasena ventana = new fMostrarContrasena(c);
                rdr.Close();
                miBD.Close();
                ventana.ShowDialog();
                this.Close();

            }
            else
            {
                rdr.Close();
                miBD.Close();
                fError ventana = new fError("Respuesta incorrecta.");
                ventana.ShowDialog();

            }
            
        }
    }
}
