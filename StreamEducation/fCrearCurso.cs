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
        private Curso curso;

        public Curso Valor { get { return curso; } }
        public fCrearCurso()
        {
            InitializeComponent();
            curso = null;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.UsuarioActivo !=null && tNombre.Text != "")
            {
                curso = new Curso(GestorGlobal.UsuarioActivo,tNombre.Text,tDescripcion.Text);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros.");
                ventana.ShowDialog();
            }
        }
    }
}
