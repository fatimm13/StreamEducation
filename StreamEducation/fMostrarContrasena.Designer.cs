
namespace StreamEducation
{
    partial class fMostrarContrasena
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelConstrasena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "TU PINCHE CONTRAÑEA RECORCHOLIS";
            // 
            // labelConstrasena
            // 
            this.labelConstrasena.AutoSize = true;
            this.labelConstrasena.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstrasena.Location = new System.Drawing.Point(101, 63);
            this.labelConstrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConstrasena.Name = "labelConstrasena";
            this.labelConstrasena.Size = new System.Drawing.Size(188, 26);
            this.labelConstrasena.TabIndex = 34;
            this.labelConstrasena.Text = "___________";
            // 
            // fMostrarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 132);
            this.Controls.Add(this.labelConstrasena);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "fMostrarContrasena";
            this.ShowIcon = false;
            this.Text = "Recuperacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConstrasena;
    }
}