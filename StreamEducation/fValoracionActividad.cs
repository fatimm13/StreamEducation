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
    public partial class fValoracionActividad : Form
    {
        public fValoracionActividad()
        {
            InitializeComponent();
        }

        private void fValoracionActividad_Load(object sender, EventArgs e)
        {
            labelCurso.Text = GestorGlobal.ActividadActiva.Nombre;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if(GestorGlobal.ActividadActiva != null && comboRol.SelectedIndex >= 0 && tDescripcion.Text != "")
            {
                GestorGlobal.ActividadActiva.valorar(comboRol.SelectedIndex + 1, tDescripcion.Text);
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
