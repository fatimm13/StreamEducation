﻿
namespace StreamEducation
{
    partial class fCrearRecurso
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
            this.labelCurso = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tEnlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.comboRecurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.Location = new System.Drawing.Point(156, 56);
            this.labelCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(166, 26);
            this.labelCurso.TabIndex = 17;
            this.labelCurso.Text = "___________";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(160, 194);
            this.tNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(375, 27);
            this.tNombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Curso:";
            // 
            // tEnlace
            // 
            this.tEnlace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEnlace.Location = new System.Drawing.Point(160, 271);
            this.tEnlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tEnlace.Name = "tEnlace";
            this.tEnlace.Size = new System.Drawing.Size(375, 27);
            this.tEnlace.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enlace:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(437, 336);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(98, 31);
            this.bAceptar.TabIndex = 20;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // comboRecurso
            // 
            this.comboRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecurso.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRecurso.FormattingEnabled = true;
            this.comboRecurso.Items.AddRange(new object[] {
            "🖼️",
            "🎞️",
            "📄",
            "🔗"});
            this.comboRecurso.Location = new System.Drawing.Point(437, 113);
            this.comboRecurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboRecurso.Name = "comboRecurso";
            this.comboRecurso.Size = new System.Drawing.Size(98, 46);
            this.comboRecurso.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tipo de recurso:";
            // 
            // fCrearRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRecurso);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tEnlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "fCrearRecurso";
            this.ShowIcon = false;
            this.Text = "Crear Recurso";
            this.Load += new System.EventHandler(this.fCrearRecurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tEnlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.ComboBox comboRecurso;
        private System.Windows.Forms.Label label4;
    }
}