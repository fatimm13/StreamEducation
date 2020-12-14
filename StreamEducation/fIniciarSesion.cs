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

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tCorreo.Text != "" && tContrasena.Text != "")
            {
                Usuario usuario = new Usuario(tCorreo.Text, tContrasena.Text);
                if (usuario.Id >= 0)
                {
                    GestorGlobal.UsuarioActivo = usuario;
                    this.Close();
                }
                else if (usuario.Id == -1)
                {
                    usuario = null;
                    fError ventana = new fError("Usuario no registrado.");
                    ventana.ShowDialog();
                } else if (usuario.Id == -2)
                {
                    usuario = null;
                    fError ventana = new fError("Contraseña errónea.");
                    ventana.ShowDialog();
                }
            }
            else
            {
                fError ventana = new fError("Faltan parametros");
                ventana.ShowDialog();
            }
            
        }

        private void fIniciarSesion_Load(object sender, EventArgs e)
        {
            
        }
    }
}
