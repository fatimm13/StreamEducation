﻿
namespace StreamEducation
{
    partial class fConfirmacion
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
            this.labelError = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bRechazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(22, 49);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(170, 18);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Confirme su acción:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bAceptar.Location = new System.Drawing.Point(194, 41);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(76, 35);
            this.bAceptar.TabIndex = 6;
            this.bAceptar.Text = "Aceptar ✔️";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bRechazar
            // 
            this.bRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bRechazar.Location = new System.Drawing.Point(284, 41);
            this.bRechazar.Margin = new System.Windows.Forms.Padding(2);
            this.bRechazar.Name = "bRechazar";
            this.bRechazar.Size = new System.Drawing.Size(76, 35);
            this.bRechazar.TabIndex = 7;
            this.bRechazar.Text = "Rechazar ❌";
            this.bRechazar.UseVisualStyleBackColor = true;
            this.bRechazar.Click += new System.EventHandler(this.bRechazar_Click);
            // 
            // fConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 132);
            this.Controls.Add(this.bRechazar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.labelError);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "fConfirmacion";
            this.ShowIcon = false;
            this.Text = "Confirmar";
            this.Load += new System.EventHandler(this.fConfirmacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bRechazar;
    }
}