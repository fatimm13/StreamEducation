
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
            this.SuspendLayout();
            // 
            // lAceptar
            // 
            this.lAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.lAceptar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lAceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAceptar.FormattingEnabled = true;
            this.lAceptar.ItemHeight = 25;
            this.lAceptar.Location = new System.Drawing.Point(808, 98);
            this.lAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.lAceptar.Name = "lAceptar";
            this.lAceptar.Size = new System.Drawing.Size(80, 400);
            this.lAceptar.TabIndex = 55;
            this.lAceptar.SelectedIndexChanged += new System.EventHandler(this.lAceptar_SelectedIndexChanged);
            // 
            // lUsuarios
            // 
            this.lUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarios.FormattingEnabled = true;
            this.lUsuarios.ItemHeight = 25;
            this.lUsuarios.Location = new System.Drawing.Point(31, 98);
            this.lUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lUsuarios.Name = "lUsuarios";
            this.lUsuarios.Size = new System.Drawing.Size(769, 400);
            this.lUsuarios.TabIndex = 52;
            this.lUsuarios.SelectedIndexChanged += new System.EventHandler(this.lUsuarios_SelectedIndexChanged);
            // 
            // lRechazar
            // 
            this.lRechazar.BackColor = System.Drawing.SystemColors.Control;
            this.lRechazar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lRechazar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRechazar.FormattingEnabled = true;
            this.lRechazar.ItemHeight = 25;
            this.lRechazar.Location = new System.Drawing.Point(896, 98);
            this.lRechazar.Margin = new System.Windows.Forms.Padding(4);
            this.lRechazar.Name = "lRechazar";
            this.lRechazar.Size = new System.Drawing.Size(80, 400);
            this.lRechazar.TabIndex = 56;
            this.lRechazar.SelectedIndexChanged += new System.EventHandler(this.lRechazar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "🔍";
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(903, 489);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(73, 48);
            this.bVolver.TabIndex = 59;
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
            this.labelX.TabIndex = 58;
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
            this.tUsuario.TabIndex = 57;
            this.tUsuario.TextChanged += new System.EventHandler(this.tUsuario_TextChanged);
            // 
            // fUsuariosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
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
    }
}