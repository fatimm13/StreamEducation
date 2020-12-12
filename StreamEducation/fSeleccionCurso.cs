﻿using System;
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
    public partial class fSeleccionCurso : Form
    {
        private Usuario usuario;
        public fSeleccionCurso(ref Usuario user)
        {
            usuario = user;
            InitializeComponent();
        }
        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil(ref usuario);
            ventana.ShowDialog();
        }



        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            fIniciarSesion ventana = new fIniciarSesion();
            ventana.ShowDialog();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            fCrearCuenta ventana = new fCrearCuenta();
            ventana.ShowDialog();
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCurso ventana = new fCrearCurso();
            ventana.ShowDialog();
        }
    }
}
