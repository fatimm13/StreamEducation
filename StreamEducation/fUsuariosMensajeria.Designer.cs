
namespace StreamEducation
{
    partial class fUsuariosMensajeria
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
            this.label2 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.lUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Elige un destinatario para el mensaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "🔍";
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(905, 484);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(73, 48);
            this.bVolver.TabIndex = 69;
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
            this.labelX.Location = new System.Drawing.Point(942, 29);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 25);
            this.labelX.TabIndex = 68;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(85, 26);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(893, 32);
            this.tUsuario.TabIndex = 67;
            this.tUsuario.TextChanged += new System.EventHandler(this.tUsuario_TextChanged);
            // 
            // lUsuarios
            // 
            this.lUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarios.FormattingEnabled = true;
            this.lUsuarios.ItemHeight = 25;
            this.lUsuarios.Location = new System.Drawing.Point(47, 132);
            this.lUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lUsuarios.Name = "lUsuarios";
            this.lUsuarios.Size = new System.Drawing.Size(931, 325);
            this.lUsuarios.TabIndex = 64;
            this.lUsuarios.SelectedIndexChanged += new System.EventHandler(this.lUsuarios_SelectedIndexChanged);
            // 
            // fUsuariosMensajeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.lUsuarios);
            this.MaximizeBox = false;
            this.Name = "fUsuariosMensajeria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios Mensajes";
            this.Load += new System.EventHandler(this.fUsuariosMensajeria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.ListBox lUsuarios;
    }
}