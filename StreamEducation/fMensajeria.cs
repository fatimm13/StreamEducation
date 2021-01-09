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
        private List<(int, string)> mensajes;
        public fMensajeria()
        {
            InitializeComponent();
        }

        private void fMensajeria_Load(object sender, EventArgs e)
        {
            Recarga();
            foreach (string n in GestorGlobal.UsuarioActivo.getNotificaciones()) lNotificaciones.Items.Add(n);
        }

        private void Recarga()
        {
            mensajes = GestorGlobal.UsuarioActivo.getMensajePrivado();
            lMensajes.Items.Clear();
            foreach ((int, string) m in mensajes) lMensajes.Items.Add(m.Item2);
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            fCrearMensajePrivado ventana = new fCrearMensajePrivado();
            ventana.ShowDialog();
            Recarga();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lMensajes.SelectedIndex >= 0)
            {
                int id = mensajes[lMensajes.SelectedIndex].Item1;
                fMostrarMensajePrivado ventana = new fMostrarMensajePrivado(new MensajePrivado(id));
                ventana.ShowDialog();
            }
        }

    }
}
