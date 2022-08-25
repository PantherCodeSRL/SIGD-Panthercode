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
    public partial class FF : Form
    {
        public FF()
        {
            InitializeComponent();
        }

        Rectangle panelIOriginalRect;

        private void btnH_Click(object sender, EventArgs e)
        {
            Form fh = new FrmFixtures() { Owner = this.Owner };
            fh.Show();
            this.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Form fb = new FB() { Owner = this.Owner };
            fb.Show();
            this.Close();
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            int newX = (int)(OriginalControlRect.X);
            int newY = (int)(OriginalControlRect.Y);

            int newWidth = (int)(OriginalControlRect.Width);
            int newHeight = (int)(OriginalControlRect.Height);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        bool res = false;
        private void btnResH_Click(object sender, EventArgs e)
        {
            if (res==false)
            {
                btnResH.BackgroundImage = SIGD.Properties.Resources.caret_left_solid;
                panelIOriginalRect = new Rectangle(panelI.Location.X, panelI.Location.Y, this.Width / 2, panelI.Height);
                resizeControl(panelIOriginalRect, panelI);
                panelI.AutoScroll = true;
                res = true;
            }
            else
            {
                btnResH.BackgroundImage = SIGD.Properties.Resources.caret_right_solid;
                panelIOriginalRect = new Rectangle(panelI.Location.X, panelI.Location.Y, -(this.Width / 2) , panelI.Height);
                resizeControl(panelIOriginalRect, panelI);
                panelI.AutoScroll = false;
                res = false;
            }
        }

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

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
