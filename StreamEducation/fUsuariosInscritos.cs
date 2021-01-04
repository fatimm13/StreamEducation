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
    public partial class fUsuariosInscritos : Form
    {
        public fUsuariosInscritos()
        {
            InitializeComponent();
            foreach (Usuario u in GestorGlobal.CursoActivo.getUsuarios())
            {
                lUsuarios.Items.Add(u);
                lExpulsar.Items.Add("🚫");
            }
        }

        private void lExpulsar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lExpulsar.SelectedIndex >= 0)
            {
                Usuario us = (Usuario)lUsuarios.Items[lExpulsar.SelectedIndex];
                us.expulsar(GestorGlobal.CursoActivo.Id);
                lUsuarios.Items.Clear();
                lExpulsar.Items.Clear();
                foreach (Usuario u in GestorGlobal.CursoActivo.getUsuarios())
                {
                    lUsuarios.Items.Add(u);
                    lExpulsar.Items.Add("🚫");
                }
            }
            
        }
    }
}
