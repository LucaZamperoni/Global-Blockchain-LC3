using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CargarAsiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asiento asiento = new Asiento();
            asiento.Show();
        }

        private void LibroDiario_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibroDiario librodiario = new LibroDiario();
            librodiario.Show();
        }

        private void LibroMayor_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibroMayor libromayor = new LibroMayor();
            libromayor.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}