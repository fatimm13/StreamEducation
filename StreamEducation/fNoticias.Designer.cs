
namespace StreamEducation
{
    partial class fNoticias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lComentarios = new System.Windows.Forms.ListBox();
            this.lCreador = new System.Windows.Forms.ListBox();
            this.bAddDebate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRecurso = new System.Windows.Forms.Label();
            this.lNoticias = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lComentarios
            // 
            this.lComentarios.BackColor = System.Drawing.SystemColors.Control;
            this.lComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lComentarios.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComentarios.FormattingEnabled = true;
            this.lComentarios.ItemHeight = 17;
            this.lComentarios.Location = new System.Drawing.Point(898, 203);
            this.lComentarios.Name = "lComentarios";
            this.lComentarios.Size = new System.Drawing.Size(118, 374);
            this.lComentarios.TabIndex = 53;
            // 
            // lCreador
            // 
            this.lCreador.BackColor = System.Drawing.SystemColors.Control;
            this.lCreador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lCreador.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCreador.FormattingEnabled = true;
            this.lCreador.ItemHeight = 17;
            this.lCreador.Location = new System.Drawing.Point(650, 202);
            this.lCreador.Name = "lCreador";
            this.lCreador.Size = new System.Drawing.Size(232, 374);
            this.lCreador.TabIndex = 52;
            // 
            // bAddDebate
            // 
            this.bAddDebate.Location = new System.Drawing.Point(930, 119);
            this.bAddDebate.Name = "bAddDebate";
            this.bAddDebate.Size = new System.Drawing.Size(86, 23);
            this.bAddDebate.TabIndex = 51;
            this.bAddDebate.Text = "Añadir Noticia";
            this.bAddDebate.UseVisualStyleBackColor = true;
            this.bAddDebate.Click += new System.EventHandler(this.bAddDebate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(895, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Comentarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Publicada por";
            // 
            // labelRecurso
            // 
            this.labelRecurso.AutoSize = true;
            this.labelRecurso.BackColor = System.Drawing.SystemColors.Control;
            this.labelRecurso.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecurso.Location = new System.Drawing.Point(327, 109);
            this.labelRecurso.Name = "labelRecurso";
            this.labelRecurso.Size = new System.Drawing.Size(120, 32);
            this.labelRecurso.TabIndex = 47;
            this.labelRecurso.Text = "Noticias";
            // 
            // lNoticias
            // 
            this.lNoticias.BackColor = System.Drawing.SystemColors.Control;
            this.lNoticias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lNoticias.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoticias.FormattingEnabled = true;
            this.lNoticias.ItemHeight = 17;
            this.lNoticias.Location = new System.Drawing.Point(329, 202);
            this.lNoticias.Name = "lNoticias";
            this.lNoticias.Size = new System.Drawing.Size(289, 374);
            this.lNoticias.TabIndex = 46;
            this.lNoticias.SelectedIndexChanged += new System.EventHandler(this.lForo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(1034, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 599);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calendario";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 599);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // tDescripcion
            // 
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(9, 132);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(259, 462);
            this.tDescripcion.TabIndex = 5;
            this.tDescripcion.Text = "No hay descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción:";
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(52, 28);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(143, 56);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Volver ↩️";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Noticias";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCerrarSesion);
            this.panel1.Controls.Add(this.bPerfil);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bRegistrarse);
            this.panel1.Controls.Add(this.bIniciarSesion);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 56);
            this.panel1.TabIndex = 44;
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Location = new System.Drawing.Point(1087, 13);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(78, 31);
            this.bCerrarSesion.TabIndex = 6;
            this.bCerrarSesion.Text = "Cerrar Sesion";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(1185, 11);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(39, 34);
            this.bPerfil.TabIndex = 5;
            this.bPerfil.Text = "Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "🌍 Stream Education";
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Location = new System.Drawing.Point(1149, 13);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(75, 31);
            this.bRegistrarse.TabIndex = 1;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Location = new System.Drawing.Point(1048, 13);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(78, 31);
            this.bIniciarSesion.TabIndex = 0;
            this.bIniciarSesion.Text = "Iniciar Sesion";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // fNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lComentarios);
            this.Controls.Add(this.lCreador);
            this.Controls.Add(this.bAddDebate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRecurso);
            this.Controls.Add(this.lNoticias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fNoticias";
            this.ShowIcon = false;
            this.Text = "Noticias";
            this.Load += new System.EventHandler(this.fNoticias_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lComentarios;
        private System.Windows.Forms.ListBox lCreador;
        private System.Windows.Forms.Button bAddDebate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRecurso;
        private System.Windows.Forms.ListBox lNoticias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Button bIniciarSesion;
    }
}