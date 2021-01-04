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
    public partial class fValoraciónActividad : Form
    {
        public fValoraciónActividad()
        {
            InitializeComponent();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if(GestorGlobal.ActividadActiva!=null && comboRol.SelectedIndex>= 0 && tDescripcion.Text!="")
            {
                GestorGlobal.ActividadActiva.valorar(comboRol.SelectedIndex + 1, tDescripcion.Text);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros.");
                ventana.ShowDialog();
            }
        }

        private void fValoraciónActividad_Load(object sender, EventArgs e)
        {
            labelCurso.Text = GestorGlobal.ActividadActiva.Nombre;
        }
    }
}
