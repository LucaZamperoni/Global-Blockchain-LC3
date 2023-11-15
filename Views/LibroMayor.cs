using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Models;

namespace Views
{
    public partial class LibroMayor : Form
    {
        Blockchain bc = Program.ReadBlockchain();
        public LibroMayor()
        {
            InitializeComponent();
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {
            var persistence = Cuentas.carga_combo;
            foreach (var item in persistence)
            {
                cuentas.Items.Add(item);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibroMayorTotal total = new LibroMayorTotal();
            total.Show();
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            try
            {
                string acc = cuentas.SelectedItem.ToString();
                List<CuentaMayor> accounts = new List<CuentaMayor>();
            
                DateTime from = dateTimePicker1.Value.Date;
                DateTime to = dateTimePicker2.Value.Date;
                if (from > to || acc == null) MessageBox.Show("Introduzca bien los valores");
                else
                {
                    for (int i = 0; i < bc.Blocks.Count; i++)
                    {
                        if (bc.Blocks[i].seat._Date >= from && bc.Blocks[i].seat._Date <= to)
                        {
                            for (int j = 0; j < bc.Blocks[i].seat._Account.Count; j++)
                            {
                                if (bc.Blocks[i].seat._Account[j]._Nombre == acc)
                                {
                                    accounts.Add(new CuentaMayor(bc.Blocks[i].seat._Account[j]._Debe, bc.Blocks[i].seat._Account[j]._Haber));
                                }
                            }
                        }
                    }

                    dataview.DataSource = accounts;
                    int sumaDebe = 0;
                    int sumaHaber = 0;
                    int total = 0;
                    for (int i = 0; i < dataview.Rows.Count; i++)
                    {
                        sumaDebe += Convert.ToInt32(dataview.Rows[i].Cells[0].FormattedValue);
                        sumaHaber += Convert.ToInt32(dataview.Rows[i].Cells[1].FormattedValue);
                    }

                    total = sumaDebe - sumaHaber;
                    textBox1.Text = sumaDebe.ToString();
                    textBox2.Text = sumaHaber.ToString();
                    textBox3.Text = total.ToString();
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
        }
    }
}