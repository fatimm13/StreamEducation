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
    public partial class fCrearForo : Form
    {


        public fCrearForo()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (GestorGlobal.UsuarioActivo != null && tForo.Text != "")
            {
                new Foro(tForo.Text, tDescripcion.Text, GestorGlobal.UsuarioActivo, GestorGlobal.CursoActivo);
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
