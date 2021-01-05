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
    public partial class fCrearRecursoActividad : Form
    {
        public fCrearRecursoActividad()
        {
            InitializeComponent();
        }

        private void fCrearRecursoActividad_Load(object sender, EventArgs e)
        {
            labelActividad.Text = GestorGlobal.ActividadActiva.Nombre;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tNombre.Text != "" && tEnlace.Text != "" && comboRecurso.SelectedIndex >= 0)
            {
                new RecursoActividad(GestorGlobal.ActividadActiva, comboRecurso.SelectedItem + " " + tNombre.Text, tEnlace.Text);
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
