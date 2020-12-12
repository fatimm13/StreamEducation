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
    public partial class fConfirmacion : Form
    {
        private bool confirmado;
        public bool Valor { get { return confirmado; } }
        public fConfirmacion()
        {
            InitializeComponent();
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

        private void fConfirmacion_Load(object sender, EventArgs e)
        {

        }
    }
}
