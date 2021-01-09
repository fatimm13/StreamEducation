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
    public partial class fEventos : Form
    {

        private DateTime fecha;
        private List<string> eventos;

        public fEventos(DateTime date, List<string> ev)
        {
            InitializeComponent();
            fecha = date;
            eventos = ev;
        }

        private void fEventos_Load(object sender, EventArgs e)
        {
            labelFecha.Text = fecha.ToString("dd-MM-yyyy");
            foreach (string evento in eventos) lEventos.Items.Add(evento);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
