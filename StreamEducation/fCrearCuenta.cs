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
    public partial class fCrearCuenta : Form
    {
        public fCrearCuenta()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tNombre.Text!="" && tCorreo.Text != "" && tContrasena1.Text != "" && tContrasena2.Text != "")
            {
                if (tContrasena1.Text.Equals(tContrasena2.Text))
                {
                    new Usuario(tNombre.Text, tCorreo.Text, tContrasena1.Text);
                    this.Close();
                }
                else
                {
                    fError ventana = new fError("Las contraseñas no coinciden.");
                    ventana.ShowDialog();
                }
            }
            else
            {
                fError ventana = new fError("Faltan parametros.");
                ventana.ShowDialog();
            }
        }
    }
}
