namespace CapaPresentacion
{
    partial class FrmABMEquipo
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tlpOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblBE = new System.Windows.Forms.Label();
            this.lblNomE = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechF = new System.Windows.Forms.Label();
            this.dtpFechF = new System.Windows.Forms.DateTimePicker();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.plTop.Size = new System.Drawing.Size(383, 42);
            this.plTop.TabIndex = 16;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.circle_xmark_solid;
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
            this.btnCerrar.TabIndex = 15;
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
            this.tlpOpciones.Size = new System.Drawing.Size(383, 55);
            this.tlpOpciones.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(194, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAceptar.Size = new System.Drawing.Size(186, 49);
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
            this.btnCancelar.Size = new System.Drawing.Size(185, 49);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblBE
            // 
            this.lblBE.AutoSize = true;
            this.lblBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBE.Location = new System.Drawing.Point(20, 64);
            this.lblBE.Name = "lblBE";
            this.lblBE.Size = new System.Drawing.Size(344, 24);
            this.lblBE.TabIndex = 33;
            this.lblBE.Text = "Ingrese los datos correspondientes:";
            // 
            // lblNomE
            // 
            this.lblNomE.AutoSize = true;
            this.lblNomE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNomE.Location = new System.Drawing.Point(21, 108);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(145, 16);
            this.lblNomE.TabIndex = 36;
            this.lblNomE.Text = "Nombre del equipo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(21, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 35;
            // 
            // lblFechF
            // 
            this.lblFechF.AutoSize = true;
            this.lblFechF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFechF.Location = new System.Drawing.Point(21, 170);
            this.lblFechF.Name = "lblFechF";
            this.lblFechF.Size = new System.Drawing.Size(226, 16);
            this.lblFechF.TabIndex = 45;
            this.lblFechF.Text = "Fecha de fundación del equipo:";
            // 
            // dtpFechF
            // 
            this.dtpFechF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechF.Location = new System.Drawing.Point(21, 189);
            this.dtpFechF.Name = "dtpFechF";
            this.dtpFechF.Size = new System.Drawing.Size(102, 20);
            this.dtpFechF.TabIndex = 44;
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Location = new System.Drawing.Point(21, 254);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(171, 21);
            this.cbxDeporte.TabIndex = 47;
            this.cbxDeporte.Text = "Seleccione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Deporte:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmABMEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 492);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechF);
            this.Controls.Add(this.dtpFechF);
            this.Controls.Add(this.lblNomE);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.tlpOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMEquipo";
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
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechF;
        private System.Windows.Forms.DateTimePicker dtpFechF;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrar;
    }
}