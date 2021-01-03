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
        private static bool esCorreoValido(String inputEmail)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(inputEmail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tNombre.Text!="" && tCorreo.Text != "" && tContrasena1.Text != "" && tContrasena2.Text != "" && comboRol.SelectedIndex >= 0 && comboPregunta.SelectedIndex >= 0 && tRespuesta.Text != "")
            {
                if (!esCorreoValido(tCorreo.Text))
                {
                    fError ventana = new fError("Formato de correo inválido.");
                    ventana.ShowDialog();
                }
                else
                {
                    if (tContrasena1.Text.Equals(tContrasena2.Text))
                    {
                        bool profesor = false;
                        bool admin = false;
                        if (comboRol.SelectedIndex == 1) {
                            profesor = true;
                        } else if (comboRol.SelectedIndex == 2)
                        {
                            admin = true;
                        }
                        new Usuario(tNombre.Text, tCorreo.Text, tContrasena1.Text, profesor, admin, comboPregunta.SelectedIndex, tRespuesta.Text);
                        this.Close();
                    }
                    else
                    {
                        fError ventana = new fError("Las contraseñas no coinciden.");
                        ventana.ShowDialog();
                    }
                }
            }
            else
            {
                fError ventana = new fError("Faltan parametros.");
                ventana.ShowDialog();
            }
        }

        private void fCrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
