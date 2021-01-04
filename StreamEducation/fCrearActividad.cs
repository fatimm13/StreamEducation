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
    public partial class fCrearActividad : Form
    {
        public fCrearActividad()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker.Value;
            string sqldate = fecha.ToString("yyyy-MM-dd");
        }

        private void fCrearActividad_Load(object sender, EventArgs e)
        {

        }
    }
}
