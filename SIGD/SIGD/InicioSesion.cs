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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalida_MouseEnter(object sender, EventArgs e)
        {
            btnSalida.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnSalida_MouseLeave(object sender, EventArgs e)
        {
            btnSalida.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }

        private void cbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMC.Checked)
            {
                txtPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        private void lblPwd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringsgobales.recuperacion);
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Complete correctamente los campos de ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
    }
}
