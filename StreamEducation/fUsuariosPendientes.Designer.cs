
namespace StreamEducation
{
    partial class fUsuariosPendientes
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
            this.lAceptar = new System.Windows.Forms.ListBox();
            this.lUsuarios = new System.Windows.Forms.ListBox();
            this.lRechazar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAceptar
            // 
            this.lAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.lAceptar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lAceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAceptar.FormattingEnabled = true;
            this.lAceptar.ItemHeight = 25;
            this.lAceptar.Location = new System.Drawing.Point(785, 148);
            this.lAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.lAceptar.Name = "lAceptar";
            this.lAceptar.Size = new System.Drawing.Size(37, 325);
            this.lAceptar.TabIndex = 4;
            this.lAceptar.SelectedIndexChanged += new System.EventHandler(this.lAceptar_SelectedIndexChanged);
            // 
            // lUsuarios
            // 
            this.lUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarios.FormattingEnabled = true;
            this.lUsuarios.ItemHeight = 25;
            this.lUsuarios.Location = new System.Drawing.Point(45, 148);
            this.lUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lUsuarios.Name = "lUsuarios";
            this.lUsuarios.Size = new System.Drawing.Size(693, 325);
            this.lUsuarios.TabIndex = 3;
            this.lUsuarios.SelectedIndexChanged += new System.EventHandler(this.lUsuarios_SelectedIndexChanged);
            // 
            // lRechazar
            // 
            this.lRechazar.BackColor = System.Drawing.SystemColors.Control;
            this.lRechazar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lRechazar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRechazar.FormattingEnabled = true;
            this.lRechazar.ItemHeight = 25;
            this.lRechazar.Location = new System.Drawing.Point(903, 148);
            this.lRechazar.Margin = new System.Windows.Forms.Padding(4);
            this.lRechazar.Name = "lRechazar";
            this.lRechazar.Size = new System.Drawing.Size(31, 325);
            this.lRechazar.TabIndex = 5;
            this.lRechazar.SelectedIndexChanged += new System.EventHandler(this.lRechazar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            //this.label2.TabIndex = 60;
            this.label2.Text = "🔍";
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(883, 490);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(73, 48);
            this.bVolver.TabIndex = 6;
            this.bVolver.Text = "↩️";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Silver;
            this.labelX.Location = new System.Drawing.Point(940, 35);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 25);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(83, 32);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(893, 32);
            this.tUsuario.TabIndex = 1;
            this.tUsuario.TextChanged += new System.EventHandler(this.tUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 25);
            //this.label3.TabIndex = 61;
            this.label3.Text = "Peticiones de inscripción al curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            //this.label1.TabIndex = 62;
            this.label1.Text = "Aceptar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(861, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            //this.label4.TabIndex = 63;
            this.label4.Text = "Rechazar";
            // 
            // fUsuariosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.lRechazar);
            this.Controls.Add(this.lAceptar);
            this.Controls.Add(this.lUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fUsuariosPendientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripciones Pendientes";
            this.Load += new System.EventHandler(this.fInscripcionesPendientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lAceptar;
        private System.Windows.Forms.ListBox lUsuarios;
        private System.Windows.Forms.ListBox lRechazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}