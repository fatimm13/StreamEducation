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
    public partial class fInscripcion : Form
    {

        private bool confirmado;

        public bool Valor { get { return confirmado; } }

        public fInscripcion()
        {
            InitializeComponent();
        }

        private void fInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            confirmado = true;
            this.Close();
        }

        private void bRechazar_Click(object sender, EventArgs e)
        {
            confirmado = false;
            this.Close();
        }
    }
}
