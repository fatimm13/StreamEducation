using MySql.Data.MySqlClient;
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

        private int curso;

        public fInscripcion(int c)
        {
            InitializeComponent();
            curso = c;
        }

        private void fInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void bRechazar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            GestorGlobal.UsuarioActivo.pedirInscripcion(curso);
            this.Close();
        }

    }
}
