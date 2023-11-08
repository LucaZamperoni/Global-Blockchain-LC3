using System;
using System.ComponentModel;

namespace Views
{
    partial class LibroDiario
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
            this.desde = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Ver = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.asiento = new System.Windows.Forms.DataGridView();
            this.movimientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.asiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // desde
            // 
            this.desde.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde.Location = new System.Drawing.Point(12, 17);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(76, 26);
            this.desde.TabIndex = 0;
            this.desde.Text = "DESDE";
            this.desde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hasta
            // 
            this.hasta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.Location = new System.Drawing.Point(359, 17);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(66, 23);
            this.hasta.TabIndex = 1;
            this.hasta.Text = "HASTA";
            this.hasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(431, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(257, 25);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // Ver
            // 
            this.Ver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver.Location = new System.Drawing.Point(697, 14);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(75, 27);
            this.Ver.TabIndex = 4;
            this.Ver.Text = "Ver";
            this.Ver.UseVisualStyleBackColor = true;
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(13, 301);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 34);
            this.back.TabIndex = 5;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // asiento
            // 
            this.asiento.AllowUserToAddRows = false;
            this.asiento.AllowUserToDeleteRows = false;
            this.asiento.AllowUserToOrderColumns = true;
            this.asiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.asiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.asiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiento.Location = new System.Drawing.Point(13, 61);
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            this.asiento.Size = new System.Drawing.Size(370, 216);
            this.asiento.TabIndex = 6;
            this.asiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiento_CellContentClick);
            this.asiento.SelectionChanged += new System.EventHandler(this.asiento_SelectionChanged);
            // 
            // movimientos
            // 
            this.movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movimientos.Location = new System.Drawing.Point(403, 61);
            this.movimientos.Name = "movimientos";
            this.movimientos.Size = new System.Drawing.Size(369, 216);
            this.movimientos.TabIndex = 7;
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 347);
            this.Controls.Add(this.movimientos);
            this.Controls.Add(this.asiento);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.desde);
            this.Name = "LibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibroDiario";
            ((System.ComponentModel.ISupportInitialize)(this.asiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView movimientos;

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView asiento;

        private System.Windows.Forms.Button Ver;

        private System.Windows.Forms.DateTimePicker dateTimePicker2;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Label hasta;

        private System.Windows.Forms.Label desde;

        #endregion
    }
}