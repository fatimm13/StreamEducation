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
        public fError(string error)
        {
            InitializeComponent();
            labelError.Text = error;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fError_Load(object sender, EventArgs e)
        {

        }
    }
}
