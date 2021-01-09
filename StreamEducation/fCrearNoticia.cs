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
    public partial class fCrearNoticia : Form
    {
        public fCrearNoticia()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.UsuarioActivo != null && tDebate.Text != "")
            {
                new Debate(tDebate.Text, tDescripcion.Text, GestorGlobal.UsuarioActivo, GestorGlobal.ForoActivo);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros por introducir.");
                ventana.ShowDialog();
            }
        }

        private void fCrearNoticia_Load(object sender, EventArgs e)
        {

        }
    }
}
