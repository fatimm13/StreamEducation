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
    public partial class fCrearCurso : Form
    {
        
        public fCrearCurso()
        {
            InitializeComponent();
        }

        private void fCrearCurso_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.UsuarioActivo !=null && tNombre.Text != "")
            {
                DateTime fechaElegida = dateTimePicker.Value;
                string fecha = fechaElegida.ToString("dd-MM-yyyy");
                new Curso(GestorGlobal.UsuarioActivo, tNombre.Text, tDescripcion.Text, cbPublico.Checked, fecha);
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
