
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
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Calificación:";
            // 
            // bEnviar
            // 
            this.bEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bEnviar.Location = new System.Drawing.Point(523, 343);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(56, 28);
            this.bEnviar.TabIndex = 31;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(43, 155);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(452, 217);
            this.tDescripcion.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Reseña:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.Location = new System.Drawing.Point(111, 39);
            this.labelCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(172, 26);
            this.labelCurso.TabIndex = 28;
            this.labelCurso.Text = "__________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Curso:";
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboRol.Location = new System.Drawing.Point(140, 79);
            this.comboRol.Margin = new System.Windows.Forms.Padding(2);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(261, 26);
            this.comboRol.TabIndex = 34;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // fValoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 410);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "fValoracion";
            this.ShowIcon = false;
            this.Text = "Valoracion";
            this.Load += new System.EventHandler(this.fValoracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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