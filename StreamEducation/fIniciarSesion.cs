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
    public partial class fIniciarSesion : Form
    {
        public fIniciarSesion()
        {
            InitializeComponent();
        }

        private void fIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void bRecuperar_Click(object sender, EventArgs e)
        {
            if (tCorreo.Text != "")
            {
                fRecuperarContrasena ventana = new fRecuperarContrasena(tCorreo.Text);
                ventana.ShowDialog();
            }
            else
            {
                fError ventana = new fError("Introduzca su correo para recuperarla.");
                ventana.ShowDialog();
            }

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tCorreo.Text != "" && tContrasena.Text != "")
            {
                Usuario usuario = Usuario.iniciarSesion(tCorreo.Text, tContrasena.Text);
                if (usuario != null)
                {
                    GestorGlobal.UsuarioActivo = usuario;
                    this.Close();
                }
            }
            else
            {
                fError ventana = new fError("Faltan parametros por introducir.");
                ventana.ShowDialog();
            }
        }
        
    }
}
