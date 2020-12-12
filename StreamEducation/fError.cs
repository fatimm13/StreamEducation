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
    public partial class fError : Form
    {
        public fError(string v)
        {
            InitializeComponent();
            labelError.Text = v;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
