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

        private int usuario;
        private int curso;
        public fInscripcion(int c,int u)
        {
            InitializeComponent();
            usuario = u;
            curso = c;
        }

        private void fInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string CONNECTION = Properties.Settings.Default.COMPLETE;
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tInscripcion (curso,usuario) VALUES(" + curso+ ", '"
                    + usuario + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                
            }
            catch
            {
                fError ventana = new fError("Error al inscribirse.");
                ventana.ShowDialog();
                this.Close();
            }
            this.Close();
        }

        private void bRechazar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
