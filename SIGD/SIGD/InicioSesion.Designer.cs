namespace SIGD
{
    partial class InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.Button();
            this.cbxMC = new System.Windows.Forms.CheckBox();
            this.btnInvitado = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPwd = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.Name = "txtUser";
            this.txtUser.TabStop = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.Window;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtPwd, "txtPwd");
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.TabStop = false;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // lblPwd
            // 
            resources.ApplyResources(this.lblPwd, "lblPwd");
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Click += new System.EventHandler(this.lblPwd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnSalida);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.Transparent;
            this.btnSalida.BackgroundImage = global::SIGD.Properties.Resources.circle_xmark_solid;
            resources.ApplyResources(this.btnSalida, "btnSalida");
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.TabStop = false;
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            this.btnSalida.MouseEnter += new System.EventHandler(this.btnSalida_MouseEnter);
            this.btnSalida.MouseLeave += new System.EventHandler(this.btnSalida_MouseLeave);
            // 
            // cbxMC
            // 
            resources.ApplyResources(this.cbxMC, "cbxMC");
            this.cbxMC.Name = "cbxMC";
            this.cbxMC.UseVisualStyleBackColor = true;
            this.cbxMC.CheckedChanged += new System.EventHandler(this.cbxMC_CheckedChanged);
            // 
            // btnInvitado
            // 
            this.btnInvitado.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.btnInvitado, "btnInvitado");
            this.btnInvitado.FlatAppearance.BorderSize = 0;
            this.btnInvitado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnInvitado.Name = "btnInvitado";
            this.btnInvitado.UseVisualStyleBackColor = false;
            this.btnInvitado.Click += new System.EventHandler(this.btnInvitado_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbUser
            // 
            this.pbUser.ErrorImage = global::SIGD.Properties.Resources.lock_solid;
            this.pbUser.Image = global::SIGD.Properties.Resources.user_solid;
            resources.ApplyResources(this.pbUser, "pbUser");
            this.pbUser.Name = "pbUser";
            this.pbUser.TabStop = false;
            // 
            // pbPwd
            // 
            this.pbPwd.ErrorImage = global::SIGD.Properties.Resources.lock_solid;
            this.pbPwd.Image = global::SIGD.Properties.Resources.lock_solid;
            resources.ApplyResources(this.pbPwd, "pbPwd");
            this.pbPwd.Name = "pbPwd";
            this.pbPwd.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.ErrorImage = global::SIGD.Properties.Resources.lock_solid;
            this.pbLogin.Image = global::SIGD.Properties.Resources.user_regular;
            resources.ApplyResources(this.pbLogin, "pbLogin");
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.TabStop = false;
            // 
            // InicioSesion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnInvitado);
            this.Controls.Add(this.cbxMC);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPwd;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxMC;
        private System.Windows.Forms.Button btnInvitado;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPwd;
    }
}