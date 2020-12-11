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
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        private void bCurso_Click(object sender, EventArgs e)
        {
            fSeleccionCurso ventana= new fSeleccionCurso();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}
