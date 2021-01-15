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
    public partial class fCrearMensajeNoticia : Form
    {
        public fCrearMensajeNoticia()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.UsuarioActivo != null && tNombre.Text != "" && tDescripcion.Text != "")
            {
                new Mensaje(tNombre.Text, tDescripcion.Text, GestorGlobal.UsuarioActivo, GestorGlobal.DebateActivo);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros por introducir.");
                ventana.ShowDialog();
            }
        }

        private void fCrearMensajeNoticiacs_Load(object sender, EventArgs e)
        {
            labelDebate.Text = GestorGlobal.DebateActivo.Nombre;
        }
    }
}
