﻿namespace SIGD
{
    partial class FrmABMUsuario
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
            this.plTop = new System.Windows.Forms.Panel();
            this.tlpOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblBE = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblNomU = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.lblPAU = new System.Windows.Forms.Label();
            this.txtPApellidoU = new System.Windows.Forms.TextBox();
            this.mtbCI = new System.Windows.Forms.MaskedTextBox();
            this.lblSAU = new System.Windows.Forms.Label();
            this.txtSApellidoU = new System.Windows.Forms.TextBox();
            this.dtpFechNU = new System.Windows.Forms.DateTimePicker();
            this.lblFechNacU = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblMailU = new System.Windows.Forms.Label();
            this.txtMailU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbTelefonoU = new System.Windows.Forms.MaskedTextBox();
            this.txtRCU = new System.Windows.Forms.TextBox();
            this.txtCU = new System.Windows.Forms.TextBox();
            this.plTop.SuspendLayout();
            this.tlpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.SlateGray;
            this.plTop.Controls.Add(this.btnSalida);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(739, 42);
            this.plTop.TabIndex = 16;
            // 
            // tlpOpciones
            // 
            this.tlpOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpOpciones.BackColor = System.Drawing.Color.Transparent;
            this.tlpOpciones.ColumnCount = 2;
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOpciones.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpOpciones.Controls.Add(this.btnCancelar, 0, 0);
            this.tlpOpciones.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOpciones.Location = new System.Drawing.Point(0, 437);
            this.tlpOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOpciones.Name = "tlpOpciones";
            this.tlpOpciones.RowCount = 1;
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpOpciones.Size = new System.Drawing.Size(739, 55);
            this.tlpOpciones.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(372, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAceptar.Size = new System.Drawing.Size(364, 49);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(363, 49);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblBE
            // 
            this.lblBE.AutoSize = true;
            this.lblBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBE.Location = new System.Drawing.Point(20, 65);
            this.lblBE.Name = "lblBE";
            this.lblBE.Size = new System.Drawing.Size(344, 24);
            this.lblBE.TabIndex = 33;
            this.lblBE.Text = "Ingrese los datos correspondientes:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblN.Location = new System.Drawing.Point(21, 110);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(233, 16);
            this.lblN.TabIndex = 34;
            this.lblN.Text = "Cédula de Identidad del usuario:";
            // 
            // lblNomU
            // 
            this.lblNomU.AutoSize = true;
            this.lblNomU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNomU.Location = new System.Drawing.Point(21, 168);
            this.lblNomU.Name = "lblNomU";
            this.lblNomU.Size = new System.Drawing.Size(67, 16);
            this.lblNomU.TabIndex = 36;
            this.lblNomU.Text = "Nombre:";
            // 
            // txtNombreU
            // 
            this.txtNombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombreU.Location = new System.Drawing.Point(21, 187);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(343, 22);
            this.txtNombreU.TabIndex = 35;
            // 
            // lblPAU
            // 
            this.lblPAU.AutoSize = true;
            this.lblPAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPAU.Location = new System.Drawing.Point(24, 226);
            this.lblPAU.Name = "lblPAU";
            this.lblPAU.Size = new System.Drawing.Size(118, 16);
            this.lblPAU.TabIndex = 38;
            this.lblPAU.Text = "Primer apellido:";
            // 
            // txtPApellidoU
            // 
            this.txtPApellidoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPApellidoU.Location = new System.Drawing.Point(24, 245);
            this.txtPApellidoU.Name = "txtPApellidoU";
            this.txtPApellidoU.Size = new System.Drawing.Size(340, 22);
            this.txtPApellidoU.TabIndex = 37;
            // 
            // mtbCI
            // 
            this.mtbCI.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbCI.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbCI.Location = new System.Drawing.Point(21, 129);
            this.mtbCI.Mask = "0000000-0";
            this.mtbCI.Name = "mtbCI";
            this.mtbCI.Size = new System.Drawing.Size(86, 26);
            this.mtbCI.TabIndex = 39;
            // 
            // lblSAU
            // 
            this.lblSAU.AutoSize = true;
            this.lblSAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSAU.Location = new System.Drawing.Point(24, 286);
            this.lblSAU.Name = "lblSAU";
            this.lblSAU.Size = new System.Drawing.Size(135, 16);
            this.lblSAU.TabIndex = 41;
            this.lblSAU.Text = "Segundo apellido:";
            // 
            // txtSApellidoU
            // 
            this.txtSApellidoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSApellidoU.Location = new System.Drawing.Point(24, 305);
            this.txtSApellidoU.Name = "txtSApellidoU";
            this.txtSApellidoU.Size = new System.Drawing.Size(340, 22);
            this.txtSApellidoU.TabIndex = 40;
            // 
            // dtpFechNU
            // 
            this.dtpFechNU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechNU.Location = new System.Drawing.Point(24, 371);
            this.dtpFechNU.Name = "dtpFechNU";
            this.dtpFechNU.Size = new System.Drawing.Size(102, 20);
            this.dtpFechNU.TabIndex = 42;
            // 
            // lblFechNacU
            // 
            this.lblFechNacU.AutoSize = true;
            this.lblFechNacU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFechNacU.Location = new System.Drawing.Point(24, 352);
            this.lblFechNacU.Name = "lblFechNacU";
            this.lblFechNacU.Size = new System.Drawing.Size(156, 16);
            this.lblFechNacU.TabIndex = 43;
            this.lblFechNacU.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(247, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Rol del usuario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(243, 371);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(121, 21);
            this.cbxRol.TabIndex = 45;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.Transparent;
            this.btnSalida.BackgroundImage = global::SIGD.Properties.Resources.circle_xmark_solid;
            this.btnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalida.Location = new System.Drawing.Point(695, 0);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSalida.Size = new System.Drawing.Size(24, 42);
            this.btnSalida.TabIndex = 14;
            this.btnSalida.TabStop = false;
            this.btnSalida.UseVisualStyleBackColor = false;
            // 
            // lblMailU
            // 
            this.lblMailU.AutoSize = true;
            this.lblMailU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMailU.Location = new System.Drawing.Point(375, 110);
            this.lblMailU.Name = "lblMailU";
            this.lblMailU.Size = new System.Drawing.Size(141, 16);
            this.lblMailU.TabIndex = 47;
            this.lblMailU.Text = "Correo Electrónico:";
            // 
            // txtMailU
            // 
            this.txtMailU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMailU.Location = new System.Drawing.Point(376, 132);
            this.txtMailU.Name = "txtMailU";
            this.txtMailU.Size = new System.Drawing.Size(343, 22);
            this.txtMailU.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(375, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(375, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Repetir contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(375, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Contraseña del usuario:";
            // 
            // mtbTelefonoU
            // 
            this.mtbTelefonoU.Location = new System.Drawing.Point(378, 189);
            this.mtbTelefonoU.Mask = "000 000 000";
            this.mtbTelefonoU.Name = "mtbTelefonoU";
            this.mtbTelefonoU.Size = new System.Drawing.Size(71, 20);
            this.mtbTelefonoU.TabIndex = 54;
            // 
            // txtRCU
            // 
            this.txtRCU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRCU.Location = new System.Drawing.Point(376, 305);
            this.txtRCU.Name = "txtRCU";
            this.txtRCU.PasswordChar = '*';
            this.txtRCU.Size = new System.Drawing.Size(343, 22);
            this.txtRCU.TabIndex = 52;
            // 
            // txtCU
            // 
            this.txtCU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCU.Location = new System.Drawing.Point(376, 245);
            this.txtCU.Name = "txtCU";
            this.txtCU.PasswordChar = '*';
            this.txtCU.Size = new System.Drawing.Size(343, 22);
            this.txtCU.TabIndex = 50;
            // 
            // FrmAMBUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 492);
            this.Controls.Add(this.mtbTelefonoU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRCU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMailU);
            this.Controls.Add(this.txtMailU);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechNacU);
            this.Controls.Add(this.dtpFechNU);
            this.Controls.Add(this.lblSAU);
            this.Controls.Add(this.txtSApellidoU);
            this.Controls.Add(this.mtbCI);
            this.Controls.Add(this.lblPAU);
            this.Controls.Add(this.txtPApellidoU);
            this.Controls.Add(this.lblNomU);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.tlpOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAMBUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAMBJugador";
            this.plTop.ResumeLayout(false);
            this.tlpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.TableLayoutPanel tlpOpciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblBE;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblNomU;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label lblPAU;
        private System.Windows.Forms.TextBox txtPApellidoU;
        private System.Windows.Forms.MaskedTextBox mtbCI;
        private System.Windows.Forms.Label lblSAU;
        private System.Windows.Forms.TextBox txtSApellidoU;
        private System.Windows.Forms.DateTimePicker dtpFechNU;
        private System.Windows.Forms.Label lblFechNacU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label lblMailU;
        private System.Windows.Forms.TextBox txtMailU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoU;
        private System.Windows.Forms.TextBox txtRCU;
        private System.Windows.Forms.TextBox txtCU;
    }
}