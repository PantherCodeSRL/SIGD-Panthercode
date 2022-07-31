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
    public partial class FrmJugadoresI : Form
    {
        public FrmJugadoresI()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            Form FrmEquiposI = new FrmEquiposI();
            FrmEquiposI.Show();
            this.Hide();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            Form Form1I = new Form1I();
            Form1I.Show();
            this.Hide();
        }
    }
}
