namespace CapaPresentacion
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCiUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.Button();
            this.cbxMC = new System.Windows.Forms.CheckBox();
            this.btnInvitado = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPwd = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.mtbCI = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.Window;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPwd.Location = new System.Drawing.Point(84, 202);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(154, 19);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.TabStop = false;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(97, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña:";
            // 
            // lblCiUser
            // 
            this.lblCiUser.AutoSize = true;
            this.lblCiUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCiUser.Location = new System.Drawing.Point(118, 121);
            this.lblCiUser.Name = "lblCiUser";
            this.lblCiUser.Size = new System.Drawing.Size(70, 20);
            this.lblCiUser.TabIndex = 2;
            this.lblCiUser.Text = "Cédula:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.lblPwd.Location = new System.Drawing.Point(85, 306);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(134, 13);
            this.lblPwd.TabIndex = 14;
            this.lblPwd.Text = "¿Olvidaste tu contraseña? ";
            this.lblPwd.Click += new System.EventHandler(this.lblPwd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnSalida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 42);
            this.panel1.TabIndex = 15;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.Transparent;
            this.btnSalida.BackgroundImage = global::CapaPresentacion.Properties.Resources.circle_xmark_solid;
            this.btnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalida.Location = new System.Drawing.Point(264, 10);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(28, 23);
            this.btnSalida.TabIndex = 13;
            this.btnSalida.TabStop = false;
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            this.btnSalida.MouseEnter += new System.EventHandler(this.btnSalida_MouseEnter);
            this.btnSalida.MouseLeave += new System.EventHandler(this.btnSalida_MouseLeave);
            // 
            // cbxMC
            // 
            this.cbxMC.AutoSize = true;
            this.cbxMC.Location = new System.Drawing.Point(92, 286);
            this.cbxMC.Name = "cbxMC";
            this.cbxMC.Size = new System.Drawing.Size(118, 17);
            this.cbxMC.TabIndex = 16;
            this.cbxMC.Text = "Mostrar Contraseña";
            this.cbxMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxMC.UseVisualStyleBackColor = true;
            this.cbxMC.CheckedChanged += new System.EventHandler(this.cbxMC_CheckedChanged);
            // 
            // btnInvitado
            // 
            this.btnInvitado.BackColor = System.Drawing.Color.SlateGray;
            this.btnInvitado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInvitado.FlatAppearance.BorderSize = 0;
            this.btnInvitado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvitado.Location = new System.Drawing.Point(0, 333);
            this.btnInvitado.Name = "btnInvitado";
            this.btnInvitado.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnInvitado.Size = new System.Drawing.Size(304, 49);
            this.btnInvitado.TabIndex = 17;
            this.btnInvitado.Text = "Invitado";
            this.btnInvitado.UseVisualStyleBackColor = false;
            this.btnInvitado.Click += new System.EventHandler(this.btnInvitado_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(225, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(70, 33);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.IntegralHeight = false;
            this.cbxRol.Items.AddRange(new object[] {
            "Administrador",
            "Administrativo",
            "Analista",
            "Árbitro",
            "C.T.",
            "Seleccionador",
            "(seleccione)"});
            this.cbxRol.Location = new System.Drawing.Point(84, 249);
            this.cbxRol.MaxDropDownItems = 6;
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(154, 21);
            this.cbxRol.TabIndex = 19;
            this.cbxRol.Click += new System.EventHandler(this.cbxRol_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRol.Location = new System.Drawing.Point(133, 227);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 20);
            this.lblRol.TabIndex = 20;
            this.lblRol.Text = "Rol:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::CapaPresentacion.Properties.Resources.lock_solid;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.user_group_solid;
            this.pictureBox1.Location = new System.Drawing.Point(59, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.ErrorImage = global::CapaPresentacion.Properties.Resources.lock_solid;
            this.pbUser.Image = global::CapaPresentacion.Properties.Resources.user_solid;
            this.pbUser.Location = new System.Drawing.Point(84, 143);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(19, 23);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 12;
            this.pbUser.TabStop = false;
            // 
            // pbPwd
            // 
            this.pbPwd.ErrorImage = global::CapaPresentacion.Properties.Resources.lock_solid;
            this.pbPwd.Image = global::CapaPresentacion.Properties.Resources.lock_solid;
            this.pbPwd.Location = new System.Drawing.Point(59, 199);
            this.pbPwd.Name = "pbPwd";
            this.pbPwd.Size = new System.Drawing.Size(19, 23);
            this.pbPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPwd.TabIndex = 12;
            this.pbPwd.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.ErrorImage = global::CapaPresentacion.Properties.Resources.lock_solid;
            this.pbLogin.Image = global::CapaPresentacion.Properties.Resources.user_regular;
            this.pbLogin.Location = new System.Drawing.Point(-1, 48);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(305, 63);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 12;
            this.pbLogin.TabStop = false;
            // 
            // mtbCI
            // 
            this.mtbCI.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbCI.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbCI.Location = new System.Drawing.Point(108, 143);
            this.mtbCI.Mask = "0000000-0";
            this.mtbCI.Name = "mtbCI";
            this.mtbCI.Size = new System.Drawing.Size(86, 26);
            this.mtbCI.TabIndex = 40;
            this.mtbCI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 382);
            this.Controls.Add(this.mtbCI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnInvitado);
            this.Controls.Add(this.cbxMC);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCiUser);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCiUser;
        private System.Windows.Forms.PictureBox pbPwd;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxMC;
        private System.Windows.Forms.Button btnInvitado;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtbCI;
    }
}