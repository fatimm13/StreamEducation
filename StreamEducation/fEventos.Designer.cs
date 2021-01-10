
namespace StreamEducation
{
    partial class fEventos
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
            this.lEventos = new System.Windows.Forms.ListBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lEventos
            // 
            this.lEventos.BackColor = System.Drawing.SystemColors.Window;
            this.lEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lEventos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEventos.FormattingEnabled = true;
            this.lEventos.ItemHeight = 25;
            this.lEventos.Location = new System.Drawing.Point(50, 141);
            this.lEventos.Margin = new System.Windows.Forms.Padding(4);
            this.lEventos.Name = "lEventos";
            this.lEventos.Size = new System.Drawing.Size(539, 277);
            //this.lEventos.TabIndex = 48;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(362, 60);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(235, 34);
            //this.labelFecha.TabIndex = 47;
            this.labelFecha.Text = "___________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 36);
            //this.label6.TabIndex = 46;
            this.label6.Text = "🗓️";
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(636, 370);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(73, 48);
            this.bVolver.TabIndex = 1;
            this.bVolver.Text = "↩️";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            //this.label1.TabIndex = 61;
            this.label1.Text = "Eventos del dia";
            // 
            // fEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.lEventos);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "fEventos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.fEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lEventos;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label label1;
    }
}