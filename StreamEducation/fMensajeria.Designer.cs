
namespace StreamEducation
{
    partial class fMensajeria
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
            this.label4 = new System.Windows.Forms.Label();
            this.bEnviar = new System.Windows.Forms.Button();
            this.lMensajes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F);
            this.label4.Location = new System.Drawing.Point(38, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bandeja de Entrada";
            // 
            // bEnviar
            // 
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(43, 11);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(183, 28);
            this.bEnviar.TabIndex = 29;
            this.bEnviar.Text = "Enviar Mensaje";
            this.bEnviar.UseVisualStyleBackColor = true;
            // 
            // lMensajes
            // 
            this.lMensajes.BackColor = System.Drawing.SystemColors.Window;
            this.lMensajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMensajes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.FormattingEnabled = true;
            this.lMensajes.ItemHeight = 17;
            this.lMensajes.Location = new System.Drawing.Point(41, 95);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(691, 325);
            this.lMensajes.TabIndex = 44;
            // 
            // fMensajeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 453);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bEnviar);
            this.MaximizeBox = false;
            this.Name = "fMensajeria";
            this.ShowIcon = false;
            this.Text = "Mensajeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.ListBox lMensajes;
    }
}