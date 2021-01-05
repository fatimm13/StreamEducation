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

        Mensaje mensaje;

        public fMostrarMensajePrivado(Mensaje m)
        {
            InitializeComponent();
            mensaje = m;
        }

        private void fMostrarMensajePrivado_Load(object sender, EventArgs e)
        {
            labelNombre.Text = mensaje.Nombre;
            labelCreador.Text = mensaje.Creador.Nombre;
            labelFecha.Text = mensaje.Fecha;
            tMensaje.Text = mensaje.Descripcion;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
