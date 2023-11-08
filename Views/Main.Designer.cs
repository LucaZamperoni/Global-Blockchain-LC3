namespace Views
{
    partial class Main
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
            this.CargarAsiento = new System.Windows.Forms.Button();
            this.LibroDiario = new System.Windows.Forms.Button();
            this.LibroMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargarAsiento
            // 
            this.CargarAsiento.Location = new System.Drawing.Point(80, 49);
            this.CargarAsiento.Margin = new System.Windows.Forms.Padding(2);
            this.CargarAsiento.Name = "CargarAsiento";
            this.CargarAsiento.Size = new System.Drawing.Size(172, 35);
            this.CargarAsiento.TabIndex = 1;
            this.CargarAsiento.Text = "Cargar Asiento";
            this.CargarAsiento.UseVisualStyleBackColor = true;
            this.CargarAsiento.Click += new System.EventHandler(this.CargarAsiento_Click);
            // 
            // LibroDiario
            // 
            this.LibroDiario.Location = new System.Drawing.Point(80, 142);
            this.LibroDiario.Margin = new System.Windows.Forms.Padding(2);
            this.LibroDiario.Name = "LibroDiario";
            this.LibroDiario.Size = new System.Drawing.Size(172, 35);
            this.LibroDiario.TabIndex = 2;
            this.LibroDiario.Text = "Libro Diario";
            this.LibroDiario.UseVisualStyleBackColor = true;
            this.LibroDiario.Click += new System.EventHandler(this.LibroDiario_Click);
            // 
            // LibroMayor
            // 
            this.LibroMayor.Location = new System.Drawing.Point(80, 238);
            this.LibroMayor.Margin = new System.Windows.Forms.Padding(2);
            this.LibroMayor.Name = "LibroMayor";
            this.LibroMayor.Size = new System.Drawing.Size(172, 35);
            this.LibroMayor.TabIndex = 3;
            this.LibroMayor.Text = "Libro Mayor";
            this.LibroMayor.UseVisualStyleBackColor = true;
            this.LibroMayor.Click += new System.EventHandler(this.LibroMayor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(329, 325);
            this.Controls.Add(this.LibroMayor);
            this.Controls.Add(this.LibroDiario);
            this.Controls.Add(this.CargarAsiento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Contable";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button LibroDiario;
        private System.Windows.Forms.Button LibroMayor;

        private System.Windows.Forms.Button CargarAsiento;

        #endregion
    }
}