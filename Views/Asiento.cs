using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Models;

namespace Views
{
    public partial class Asiento : Form
    {
        Program Base = new Program();
        public Asiento()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
        

        private void Asiento_Load(object sender, EventArgs e)
        {
            var persistence = Cuentas.carga_combo;

            foreach (string item in persistence)
                Column1.Items.Add(item);

            Column2.Items.Add("Debe");
            Column2.Items.Add("Haber");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCargarAsiento_Click(object sender, EventArgs e)
        {
            List<Account> listaCuentas = new List<Account>();



            try
            {
                if (string.IsNullOrEmpty(textBox1.Text)) { throw new InvalidOperationException(""); }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Account account = new Account();

                    account._Nombre = (string)dataGridView1.Rows[i].Cells[0].FormattedValue;

                    if (dataGridView1.Rows[i].Cells[1].FormattedValue.Equals("Debe"))
                    {
                        account._Debe = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].FormattedValue);
                        account._Haber = 0;
                    }
                    else if (dataGridView1.Rows[i].Cells[1].FormattedValue.Equals("Haber"))
                    {
                        account._Haber = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].FormattedValue);
                        account._Debe = 0;
                    }
                    else
                    {
                        throw new InvalidOperationException("");
                    }

                    listaCuentas.Add(account);
                }
                Blockchain blockchain = Program.ReadBlockchain();
                List<String> accountNames = Cuentas.carga_combo;
                Seat seat = new Seat(dateTimePicker1.Value.Date, textBox1.Text, listaCuentas);
                if (Miner.Validator(seat, blockchain, accountNames))
                {
                    Block block = new Block(seat, blockchain);

                    blockchain.Blocks.Add(block);

                    Program.PersistBlockchain(blockchain);
                    MessageBox.Show("Carga exitosa");
                }
                else
                {
                    MessageBox.Show("Datos erroneos");
                }

            }
            catch
            {
                MessageBox.Show("Hay una celda vacia");
            }

        }
    }
}