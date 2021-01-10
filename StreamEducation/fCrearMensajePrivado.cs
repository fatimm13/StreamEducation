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
    public partial class fCrearMensajePrivado : Form
    {

        private Usuario destinatario;

        public fCrearMensajePrivado()
        {
            InitializeComponent();
            destinatario = null;
        }

        private void bSeleccionarUsuario_Click(object sender, EventArgs e)
        {
            fUsuariosMensajeria ventana = new fUsuariosMensajeria();
            ventana.ShowDialog();
            Usuario d = ventana.Valor;
            if (d != null)
            {
                destinatario = d;
                tDestinatario.Text = destinatario.Correo;
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (destinatario != null && tAsunto.Text != "" && tDescripcion.Text != "")
            {
                new MensajePrivado(GestorGlobal.UsuarioActivo, destinatario, tAsunto.Text, tDescripcion.Text);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros por insertar.");
                ventana.ShowDialog();
            }
        }

        private void fCrearMensajePrivado_Load(object sender, EventArgs e)
        {

        }
    }
}
