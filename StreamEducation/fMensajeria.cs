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
    public partial class fMensajeria : Form
    {
        public fMensajeria()
        {
            InitializeComponent();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            fCrearMensajePrivado ventana = new fCrearMensajePrivado();
            ventana.ShowDialog();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
