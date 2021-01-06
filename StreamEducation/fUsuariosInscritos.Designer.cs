
namespace StreamEducation
{
    partial class fUsuariosInscritos
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
            this.lUsuarios = new System.Windows.Forms.ListBox();
            this.lExpulsar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lUsuarios
            // 
            this.lUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarios.FormattingEnabled = true;
            this.lUsuarios.ItemHeight = 25;
            this.lUsuarios.Location = new System.Drawing.Point(42, 148);
            this.lUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lUsuarios.Name = "lUsuarios";
            this.lUsuarios.Size = new System.Drawing.Size(823, 325);
            this.lUsuarios.TabIndex = 48;
            this.lUsuarios.SelectedIndexChanged += new System.EventHandler(this.lUsuarios_SelectedIndexChanged);
            // 
            // lExpulsar
            // 
            this.lExpulsar.BackColor = System.Drawing.SystemColors.Control;
            this.lExpulsar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lExpulsar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExpulsar.FormattingEnabled = true;
            this.lExpulsar.ItemHeight = 25;
            this.lExpulsar.Location = new System.Drawing.Point(900, 148);
            this.lExpulsar.Margin = new System.Windows.Forms.Padding(4);
            this.lExpulsar.Name = "lExpulsar";
            this.lExpulsar.Size = new System.Drawing.Size(46, 325);
            this.lExpulsar.TabIndex = 51;
            this.lExpulsar.SelectedIndexChanged += new System.EventHandler(this.lExpulsar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "🔍";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Silver;
            this.labelX.Location = new System.Drawing.Point(937, 43);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 25);
            this.labelX.TabIndex = 53;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(80, 40);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(893, 32);
            this.tUsuario.TabIndex = 52;
            this.tUsuario.TextChanged += new System.EventHandler(this.tUsuario_TextChanged);
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(890, 490);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(73, 48);
            this.bVolver.TabIndex = 55;
            this.bVolver.Text = "↩️";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Expulsar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Usuarios inscritos en el curso:";
            // 
            // fUsuariosInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.lExpulsar);
            this.Controls.Add(this.lUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fUsuariosInscritos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios Inscritos";
            this.Load += new System.EventHandler(this.fUsuariosInscritos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lUsuarios;
        private System.Windows.Forms.ListBox lExpulsar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}