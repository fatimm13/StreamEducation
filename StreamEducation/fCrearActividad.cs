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
    public partial class fCrearActividad : Form
    {
        public fCrearActividad()
        {
            InitializeComponent();
        }

        private void fCrearActividad_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            
            if (GestorGlobal.UsuarioActivo != null && tNombre.Text != "")
            {
                DateTime fechaElegida = dateTimePicker.Value;
                string fecha = fechaElegida.ToString("dd-MM-yyyy");
                new Actividad(GestorGlobal.UsuarioActivo, tNombre.Text, tDescripcion.Text, fecha);
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
