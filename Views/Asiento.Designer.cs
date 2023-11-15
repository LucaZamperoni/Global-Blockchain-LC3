using System.ComponentModel;

namespace Views
{
    partial class Asiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nombre = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.btnCargarAsiento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(28, 18);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(114, 20);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Fecha del asiento";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(12, 55);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(148, 23);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "Descripción";
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 23);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Info;
            this.back.Location = new System.Drawing.Point(28, 328);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 32);
            this.back.TabIndex = 4;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnCargarAsiento
            // 
            this.btnCargarAsiento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAsiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAsiento.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCargarAsiento.Location = new System.Drawing.Point(375, 328);
            this.btnCargarAsiento.Name = "btnCargarAsiento";
            this.btnCargarAsiento.Size = new System.Drawing.Size(132, 32);
            this.btnCargarAsiento.TabIndex = 5;
            this.btnCargarAsiento.Text = "Cargar asiento";
            this.btnCargarAsiento.UseVisualStyleBackColor = false;
            this.btnCargarAsiento.Click += new System.EventHandler(this.btnCargarAsiento_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column2, this.Column3 });
            this.dataGridView1.Location = new System.Drawing.Point(28, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 215);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Cuentas";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Debe / Haber";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Monto";
            this.Column3.Name = "Column3";
            // 
            // Asiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(533, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCargarAsiento);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Name = "Asiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asiento";
            this.Load += new System.EventHandler(this.Asiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnCargarAsiento;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label descripcion;

        private System.Windows.Forms.Label nombre;

        #endregion
    }
}