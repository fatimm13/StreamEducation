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
    public partial class fCrearMensaje : Form
    {

        public fCrearMensaje()
        {
            InitializeComponent();
        }

        private void fCrearMensaje_Load(object sender, EventArgs e)
        {
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
            labelDebate.Text = GestorGlobal.DebateActivo.Nombre;
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
    }
}
