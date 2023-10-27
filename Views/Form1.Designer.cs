namespace Views
{
    partial class Form1
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
            this.TituloFormularioAsiento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloFormularioAsiento
            // 
            this.TituloFormularioAsiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TituloFormularioAsiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormularioAsiento.Location = new System.Drawing.Point(12, 17);
            this.TituloFormularioAsiento.Name = "TituloFormularioAsiento";
            this.TituloFormularioAsiento.Size = new System.Drawing.Size(251, 36);
            this.TituloFormularioAsiento.TabIndex = 0;
            this.TituloFormularioAsiento.Text = "Formulario de Asiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TituloFormularioAsiento);
            this.Name = "Form1";
            this.Text = "Programa Contable";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label TituloFormularioAsiento;

        #endregion
    }
}