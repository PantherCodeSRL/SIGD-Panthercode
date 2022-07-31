using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGD
{
    public partial class FrmEquipos : Form
    {
        public FrmEquipos()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form Form1 = new FormP();
            Form1.Show();
            this.Hide();

        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            Form FrmJugadores = new FrmJugadores();
            FrmJugadores.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
