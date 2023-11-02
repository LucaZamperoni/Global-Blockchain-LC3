using System;
using System.Windows.Forms;
using Data;

namespace Views
{
    public partial class Asiento : Form
    {
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
    }
}