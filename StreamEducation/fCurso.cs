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
    public partial class fCurso : Form
    {
        
        public fCurso()
        {
            InitializeComponent();
        }

        private void fCurso_Load(object sender, EventArgs e)
        {
            if (GestorGlobal.CursoActivo != null)
            {
                foreach (Recurso r in GestorGlobal.CursoActivo.getRecursos()) lRecursos.Items.Add(r);
                foreach (Foro f in GestorGlobal.CursoActivo.getForos()) lForos.Items.Add(f);
            }
            labelProfesor.Text = GestorGlobal.CursoActivo.Profesor.Nombre;
            labelFecha.Text = GestorGlobal.CursoActivo.Fecha;
            labelCurso.Text = GestorGlobal.CursoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.CursoActivo.Descripcion;
            Recarga();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bValorar.Visible = usuarioIniciado;
            bool usuarioPoder = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.CursoActivo.Profesor.Id || GestorGlobal.UsuarioActivo.RolAdmin);
            bCrearForo.Visible = usuarioPoder;
            bCrearRecurso.Visible = usuarioPoder;
            bBorrar.Visible = usuarioPoder;
            lBorrar.Visible = usuarioPoder;
            bCrearTest.Visible = usuarioPoder;
            labelInscritos.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            labelPeticion.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            bInscritos.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            bPeticiones.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            lBorrar.Items.Clear();
            if (usuarioPoder)
            {
                foreach (Recurso r in GestorGlobal.CursoActivo.getRecursos()) lBorrar.Items.Add("🗑️ Borrar");
            }
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil();
            ventana.ShowDialog();
            Recarga();
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.UsuarioActivo = null;
                Recarga();
            }
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            fIniciarSesion ventana = new fIniciarSesion();
            ventana.ShowDialog();
            Recarga();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            fCrearCuenta ventana = new fCrearCuenta();
            ventana.ShowDialog();
            Recarga();
        }

        private void bValorar_Click(object sender, EventArgs e)
        {
            fValoracion ventana = new fValoracion();
            ventana.ShowDialog();
        }

        private void bInscritos_Click(object sender, EventArgs e)
        {
            fUsuariosInscritos ventana = new fUsuariosInscritos();
            ventana.ShowDialog();
        }

        private void bPeticiones_Click(object sender, EventArgs e)
        {
            fUsuariosPendientes ventana = new fUsuariosPendientes();
            ventana.ShowDialog();
        }

        private void bCrearTest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/u/0/");
        }

        private void bCrearForo_Click(object sender, EventArgs e)
        {
            fCrearForo ventana = new fCrearForo();
            ventana.ShowDialog();
            lForos.Items.Clear();
            foreach (Foro f in GestorGlobal.CursoActivo.getForos()) lForos.Items.Add(f);
        }

        private void bCrearRecurso_Click(object sender, EventArgs e)
        {
            fCrearRecurso ventana = new fCrearRecurso();
            ventana.ShowDialog();
            lRecursos.Items.Clear();
            lBorrar.Items.Clear();
            foreach (Recurso r in GestorGlobal.CursoActivo.getRecursos())
            {
                lRecursos.Items.Add(r);
                lBorrar.Items.Add("🗑️ Borrar");
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.CursoActivo.Borrar();
                GestorGlobal.CursoActivo = null;
                this.Close();
            }
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lForos.SelectedIndex >= 0)
            {
                GestorGlobal.ForoActivo = (Foro)lForos.SelectedItem;
                fForo ventana = new fForo();
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
                GestorGlobal.ForoActivo = null;
                Recarga();
                lForos.Items.Clear();
                foreach (Foro f in GestorGlobal.CursoActivo.getForos()) lForos.Items.Add(f);
            }
        }

        private void lRecursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRecursos.SelectedIndex >= 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(((Recurso)lRecursos.SelectedItem).Link);
                }
                catch
                {
                    fError ventana = new fError("El recurso no se encuentra disponible actualmente.");
                    ventana.ShowDialog();
                }
            }
        }

        private void lBorrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lBorrar.SelectedIndex;
            if (index >= 0)
            {
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
                    Recurso recurso = (Recurso)lRecursos.Items[index];
                    recurso.Borrar();
                    lRecursos.Items.Clear();
                    lBorrar.Items.Clear();
                    foreach (Recurso r in GestorGlobal.CursoActivo.getRecursos())
                    {
                        lRecursos.Items.Add(r);
                        lBorrar.Items.Add("🗑️ Borrar");
                    }
                }
            }
        }

    }
}
