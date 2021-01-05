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
        private string correo;
        public fRecuperarContrasena(string c)
        {
            correo = c;
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            String contrasena = Usuario.recuperarContrasena(correo, comboPregunta.SelectedIndex, tRespuesta.Text);
            if (contrasena != null)
            {
                fMostrarContrasena ventana = new fMostrarContrasena(contrasena);
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                fError ventana = new fError("Los datos introducidos no son correctos.");
                ventana.ShowDialog();
            }
        }

    }
}
