
namespace StreamEducation
{
    partial class fMostrarNoticia
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
            this.label3 = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bAddMensaje = new System.Windows.Forms.Button();
            this.labelNoticia = new System.Windows.Forms.Label();
            this.labelRecurso = new System.Windows.Forms.Label();
            this.lMensajes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bInicio = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 501);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Comentarios:";
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(1169, 147);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(201, 37);
            this.bBorrar.TabIndex = 62;
            this.bBorrar.Text = "Borrar noticia";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bAddMensaje
            // 
            this.bAddMensaje.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddMensaje.Location = new System.Drawing.Point(1169, 498);
            this.bAddMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.bAddMensaje.Name = "bAddMensaje";
            this.bAddMensaje.Size = new System.Drawing.Size(201, 32);
            this.bAddMensaje.TabIndex = 59;
            this.bAddMensaje.Text = "💬  Comentar";
            this.bAddMensaje.UseVisualStyleBackColor = true;
            this.bAddMensaje.Click += new System.EventHandler(this.bAddMensaje_Click);
            // 
            // labelNoticia
            // 
            this.labelNoticia.AutoSize = true;
            this.labelNoticia.BackColor = System.Drawing.SystemColors.Control;
            this.labelNoticia.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoticia.Location = new System.Drawing.Point(595, 144);
            this.labelNoticia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoticia.Name = "labelNoticia";
            this.labelNoticia.Size = new System.Drawing.Size(268, 41);
            this.labelNoticia.TabIndex = 58;
            this.labelNoticia.Text = "NombreNoticia";
            // 
            // labelRecurso
            // 
            this.labelRecurso.AutoSize = true;
            this.labelRecurso.BackColor = System.Drawing.SystemColors.Control;
            this.labelRecurso.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecurso.Location = new System.Drawing.Point(415, 143);
            this.labelRecurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecurso.Name = "labelRecurso";
            this.labelRecurso.Size = new System.Drawing.Size(166, 41);
            this.labelRecurso.TabIndex = 57;
            this.labelRecurso.Text = "Noticia:";
            // 
            // lMensajes
            // 
            this.lMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.lMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lMensajes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.FormattingEnabled = true;
            this.lMensajes.ItemHeight = 25;
            this.lMensajes.Location = new System.Drawing.Point(447, 548);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(4);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(924, 250);
            this.lMensajes.TabIndex = 56;
            this.lMensajes.SelectedIndexChanged += new System.EventHandler(this.lMensajes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(1379, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(289, 737);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calendario";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 31);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Location = new System.Drawing.Point(17, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 737);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 300);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 259);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Este es el interior de la noticia.\r\n\r\nAquí podrás enterarte mejor sobre el tema y" +
    " preguntar tus dudas personales.\r\n\r\n¡¡Que nada te impida aprender!!";
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(69, 104);
            this.bInicio.Margin = new System.Windows.Forms.Padding(4);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(191, 69);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Volver ↩️";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(447, 273);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(923, 194);
            this.tDescripcion.TabIndex = 11;
            this.tDescripcion.Text = "No hay descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCerrarSesion);
            this.panel1.Controls.Add(this.bPerfil);
            this.panel1.Controls.Add(this.bRegistrarse);
            this.panel1.Controls.Add(this.bIniciarSesion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 68);
            this.panel1.TabIndex = 55;
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrarSesion.Location = new System.Drawing.Point(1299, 10);
            this.bCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(181, 47);
            this.bCerrarSesion.TabIndex = 46;
            this.bCerrarSesion.Text = "Cerrar Sesion";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerfil.Location = new System.Drawing.Point(1507, 11);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(125, 46);
            this.bPerfil.TabIndex = 45;
            this.bPerfil.Text = "Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrarse.Location = new System.Drawing.Point(1468, 10);
            this.bRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(165, 47);
            this.bRegistrarse.TabIndex = 44;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciarSesion.Location = new System.Drawing.Point(1264, 10);
            this.bIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(187, 46);
            this.bIniciarSesion.TabIndex = 43;
            this.bIniciarSesion.Text = "Iniciar Sesion";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "🌍 Stream Education";
            // 
            // fMostrarNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAddMensaje);
            this.Controls.Add(this.labelNoticia);
            this.Controls.Add(this.labelRecurso);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fMostrarNoticia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Noticia";
            this.Load += new System.EventHandler(this.fMostrarNoticia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bAddMensaje;
        private System.Windows.Forms.Label labelNoticia;
        private System.Windows.Forms.Label labelRecurso;
        private System.Windows.Forms.ListBox lMensajes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}