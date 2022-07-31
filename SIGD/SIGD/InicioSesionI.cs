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
    public partial class InicioSesionI : Form
    {
        public InicioSesionI()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMC.Checked)
            {
                txtbxC.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxC.UseSystemPasswordChar = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact a administrator to recover your password");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InicioSesionI_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || txtbxC.Text == "") { MessageBox.Show("Fill the blank spaces correctly"); }
            Close();
            
        }
    }
}
