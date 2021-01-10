
using System;

namespace StreamEducation
{
    partial class fValoracion
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
            this.bEnviar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            //this.label3.TabIndex = 33;
            this.label3.Text = "Valoración:";
            // 
            // bEnviar
            // 
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(651, 414);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(108, 43);
            this.bEnviar.TabIndex = 3;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(85, 263);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(527, 194);
            this.tDescripcion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            //this.label4.TabIndex = 29;
            this.label4.Text = "Reseña:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.Location = new System.Drawing.Point(207, 48);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(195, 34);
            //this.labelCurso.TabIndex = 28;
            this.labelCurso.Text = "__________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            //this.label1.TabIndex = 26;
            this.label1.Text = "Curso:";
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "☹️",
            "🙁",
            "😐",
            "🙂",
            "😃"});
            this.comboRol.Location = new System.Drawing.Point(271, 134);
            this.comboRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(101, 56);
            this.comboRol.TabIndex = 1;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // fValoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fValoracion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Valoracion";
            this.Load += new System.EventHandler(this.fValoracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRol;
    }
}