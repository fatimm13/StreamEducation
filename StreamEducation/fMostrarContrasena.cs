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
    public partial class fMostrarContrasena : Form
    {
        public fMostrarContrasena(string c)
        {
            InitializeComponent();
            labelConstrasena.Text = c;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
