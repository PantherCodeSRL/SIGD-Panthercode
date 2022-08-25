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
    public partial class FrmFixtures : Form
    {
        public FrmFixtures()
        {
            InitializeComponent();
        }

        public bool principal = false;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            FB fb= new FB() { Owner = this.Owner };
            fb.Show();
            this.Close();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            FF ff = new FF() { Owner = this.Owner };
            ff.Show();
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
