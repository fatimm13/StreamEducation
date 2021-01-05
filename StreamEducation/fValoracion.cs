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
    public partial class fValoracion : Form
    {
        public fValoracion()
        {
            InitializeComponent();
        }

        private void fValoracion_Load(object sender, EventArgs e)
        {
            labelCurso.Text = GestorGlobal.CursoActivo.Nombre;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.CursoActivo != null && comboRol.SelectedIndex >= 0 && tDescripcion.Text != "")
            {
                GestorGlobal.CursoActivo.valorar(comboRol.SelectedIndex + 1, tDescripcion.Text);
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
