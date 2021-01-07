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
    public partial class fMostrarMensajePrivado : Form
    {

        MensajePrivado mensaje;

        public fMostrarMensajePrivado(MensajePrivado m)
        {
            InitializeComponent();
            mensaje = m;
        }

        private void fMostrarMensajePrivado_Load(object sender, EventArgs e)
        {
            labelNombre.Text = mensaje.Asunto;
            labelCreador.Text = mensaje.Emisor.Nombre;
            labelFecha.Text = mensaje.Fecha;
            tMensaje.Text = mensaje.Mensaje;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
