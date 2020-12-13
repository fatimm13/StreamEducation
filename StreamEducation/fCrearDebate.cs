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
    public partial class fCrearDebate : Form
    {
        public Debate debate;

        public Debate Valor { get { return debate; } }

        public fCrearDebate()
        {
            InitializeComponent();
            debate = null;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.UsuarioActivo != null && tDebate.Text != "")
            {
                debate = new Debate(tDebate.Text, tDescripcion.Text, GestorGlobal.UsuarioActivo, GestorGlobal.ForoActivo);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros.");
                ventana.ShowDialog();
            }
        }

        private void fCrearDebate_Load(object sender, EventArgs e)
        {
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
        }
    }
}
