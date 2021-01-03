
namespace StreamEducation
{
    partial class fCrearDebate
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
            this.tDebate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelForo = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Foro:";
            // 
            // tDebate
            // 
            this.tDebate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDebate.Location = new System.Drawing.Point(171, 150);
            this.tDebate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDebate.Name = "tDebate";
            this.tDebate.Size = new System.Drawing.Size(487, 32);
            this.tDebate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Debate:";
            // 
            // labelForo
            // 
            this.labelForo.AutoSize = true;
            this.labelForo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForo.Location = new System.Drawing.Point(165, 52);
            this.labelForo.Name = "labelForo";
            this.labelForo.Size = new System.Drawing.Size(235, 34);
            this.labelForo.TabIndex = 13;
            this.labelForo.Text = "___________";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(686, 412);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(86, 34);
            this.bAceptar.TabIndex = 16;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(57, 265);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(601, 183);
            this.tDescripcion.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripción:";
            // 
            // fCrearDebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelForo);
            this.Controls.Add(this.tDebate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fCrearDebate";
            this.ShowIcon = false;
            this.Text = "Crear Debate";
            this.Load += new System.EventHandler(this.fCrearDebate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDebate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelForo;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label3;
    }
}