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
    public partial class fCrearRecurso : Form
    {
        public fCrearRecurso()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tNombre.Text != "" && tEnlace.Text != "" && comboRecurso.SelectedIndex >= 0)
            {
                new Recurso(GestorGlobal.CursoActivo, comboRecurso.SelectedItem + " " + tNombre.Text, tEnlace.Text);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros.");
                ventana.ShowDialog();
            }
        }

        private void fCrearRecurso_Load(object sender, EventArgs e)
        {
            labelCurso.Text = GestorGlobal.CursoActivo.Nombre;
        }
    }
}
