namespace SIGD
{
    partial class FrmABMJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMJugador));
            this.plTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tlpOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblBE = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.mtbCI = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.dtpFechN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbTelefonoJ = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMailU = new System.Windows.Forms.Label();
            this.txtMailJ = new System.Windows.Forms.TextBox();
            this.plTop.SuspendLayout();
            this.tlpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.SlateGray;
            this.plTop.Controls.Add(this.btnCerrar);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(385, 42);
            this.plTop.TabIndex = 16;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::SIGD.Properties.Resources.circle_xmark_solid;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Location = new System.Drawing.Point(340, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCerrar.Size = new System.Drawing.Size(24, 42);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
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
            this.tlpOpciones.Size = new System.Drawing.Size(385, 55);
            this.tlpOpciones.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(195, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAceptar.Size = new System.Drawing.Size(187, 49);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnCancelar.Size = new System.Drawing.Size(186, 49);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.lblN.Size = new System.Drawing.Size(235, 16);
            this.lblN.TabIndex = 34;
            this.lblN.Text = "Cédula de Identidad del jugador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(21, 180);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Primer apellido:";
            // 
            // txtPApellido
            // 
            this.txtPApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPApellido.Location = new System.Drawing.Point(21, 232);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(343, 22);
            this.txtPApellido.TabIndex = 37;
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
            this.mtbCI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Segundo apellido:";
            // 
            // txtSApellido
            // 
            this.txtSApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSApellido.Location = new System.Drawing.Point(21, 284);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(343, 22);
            this.txtSApellido.TabIndex = 40;
            // 
            // dtpFechN
            // 
            this.dtpFechN.CustomFormat = "yyyy-MM-dd";
            this.dtpFechN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechN.Location = new System.Drawing.Point(21, 340);
            this.dtpFechN.MaxDate = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpFechN.Name = "dtpFechN";
            this.dtpFechN.Size = new System.Drawing.Size(83, 20);
            this.dtpFechN.TabIndex = 42;
            this.dtpFechN.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // mtbTelefonoJ
            // 
            this.mtbTelefonoJ.Location = new System.Drawing.Point(293, 340);
            this.mtbTelefonoJ.Mask = "000 000 000";
            this.mtbTelefonoJ.Name = "mtbTelefonoJ";
            this.mtbTelefonoJ.Size = new System.Drawing.Size(71, 20);
            this.mtbTelefonoJ.TabIndex = 58;
            this.mtbTelefonoJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTel.Location = new System.Drawing.Point(290, 319);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(74, 16);
            this.lblTel.TabIndex = 57;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblMailU
            // 
            this.lblMailU.AutoSize = true;
            this.lblMailU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMailU.Location = new System.Drawing.Point(21, 375);
            this.lblMailU.Name = "lblMailU";
            this.lblMailU.Size = new System.Drawing.Size(141, 16);
            this.lblMailU.TabIndex = 56;
            this.lblMailU.Text = "Correo Electrónico:";
            // 
            // txtMailJ
            // 
            this.txtMailJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMailJ.Location = new System.Drawing.Point(21, 394);
            this.txtMailJ.Name = "txtMailJ";
            this.txtMailJ.Size = new System.Drawing.Size(343, 22);
            this.txtMailJ.TabIndex = 55;
            // 
            // FrmABMJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 492);
            this.Controls.Add(this.mtbTelefonoJ);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblMailU);
            this.Controls.Add(this.txtMailJ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.mtbCI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.tlpOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAMBJugador";
            this.Load += new System.EventHandler(this.FrmAMBJugador_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.MaskedTextBox mtbCI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.DateTimePicker dtpFechN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoJ;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMailU;
        private System.Windows.Forms.TextBox txtMailJ;
    }
}