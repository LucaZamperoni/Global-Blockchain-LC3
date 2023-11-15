using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Models;

namespace Views
{
    public partial class LibroDiario : Form
    {
        Blockchain bc = Program.ReadBlockchain();
        public LibroDiario()
        {
            InitializeComponent();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;
            List<Seat> seats = new List<Seat>();

            if (from > to) MessageBox.Show("Introduzca bien las fechas");
            else
            {
                for (int i = 0; i < bc.Blocks.Count; i++)
                {
                    if (bc.Blocks[i].seat._Date >= from && bc.Blocks[i].seat._Date <= to) seats.Add(bc.Blocks[i].seat);
                }

                asiento.DataSource = seats;
            }
            DataGridViewColumn hashColumn = asiento.Columns["_HashSeat"];
            if (hashColumn != null)
            {
                hashColumn.Visible = false;
            }
        }
        private void asiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void asiento_SelectionChanged(object sender, EventArgs e)
        {
            Seat s = (Seat)asiento.CurrentRow.DataBoundItem;
            movimientos.DataSource = s._Account;
        }
    }
}