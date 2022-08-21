namespace SIGD
{
    partial class FrmEquipos
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
            this.plSuperior = new System.Windows.Forms.Panel();
            this.tlpHerramientas = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tlpOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.pbJugadores = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.cbxTitulos = new System.Windows.Forms.ComboBox();
            this.lblFP = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.plInferior = new System.Windows.Forms.Panel();
            this.lblFdF = new System.Windows.Forms.Label();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.lblBE = new System.Windows.Forms.Label();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.plSuperior.SuspendLayout();
            this.tlpHerramientas.SuspendLayout();
            this.tlpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // plSuperior
            // 
            this.plSuperior.BackColor = System.Drawing.Color.SlateGray;
            this.plSuperior.Controls.Add(this.tlpHerramientas);
            this.plSuperior.Controls.Add(this.tlpOpciones);
            this.plSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSuperior.Location = new System.Drawing.Point(0, 0);
            this.plSuperior.Name = "plSuperior";
            this.plSuperior.Size = new System.Drawing.Size(941, 81);
            this.plSuperior.TabIndex = 25;
            // 
            // tlpHerramientas
            // 
            this.tlpHerramientas.ColumnCount = 3;
            this.tlpHerramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHerramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHerramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpHerramientas.Controls.Add(this.btnCerrar, 2, 0);
            this.tlpHerramientas.Controls.Add(this.btnMin, 0, 0);
            this.tlpHerramientas.Controls.Add(this.button7, 1, 0);
            this.tlpHerramientas.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpHerramientas.Location = new System.Drawing.Point(857, 0);
            this.tlpHerramientas.Name = "tlpHerramientas";
            this.tlpHerramientas.RowCount = 1;
            this.tlpHerramientas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpHerramientas.Size = new System.Drawing.Size(84, 81);
            this.tlpHerramientas.TabIndex = 27;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SIGD.Properties.Resources.circle_xmark_solid;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(63, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 31);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::SIGD.Properties.Resources.minus_solid;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(3, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 35);
            this.btnMin.TabIndex = 21;
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SIGD.Properties.Resources.window_maximize_solid;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(33, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 35);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // tlpOpciones
            // 
            this.tlpOpciones.ColumnCount = 5;
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOpciones.Controls.Add(this.pbJugadores, 3, 0);
            this.tlpOpciones.Controls.Add(this.btnMenu, 2, 0);
            this.tlpOpciones.Controls.Add(this.btnJugadores, 4, 0);
            this.tlpOpciones.Controls.Add(this.pbMenu, 1, 0);
            this.tlpOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpOpciones.Location = new System.Drawing.Point(0, 0);
            this.tlpOpciones.Name = "tlpOpciones";
            this.tlpOpciones.RowCount = 1;
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpOpciones.Size = new System.Drawing.Size(361, 81);
            this.tlpOpciones.TabIndex = 26;
            // 
            // pbJugadores
            // 
            this.pbJugadores.Image = global::SIGD.Properties.Resources.person_running_solid;
            this.pbJugadores.Location = new System.Drawing.Point(188, 3);
            this.pbJugadores.Name = "pbJugadores";
            this.pbJugadores.Size = new System.Drawing.Size(36, 71);
            this.pbJugadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJugadores.TabIndex = 25;
            this.pbJugadores.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.Location = new System.Drawing.Point(96, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 75);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menú\nPrincipal";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.Color.SlateGray;
            this.btnJugadores.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnJugadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJugadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnJugadores.ForeColor = System.Drawing.Color.Black;
            this.btnJugadores.Location = new System.Drawing.Point(230, 3);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(111, 75);
            this.btnJugadores.TabIndex = 0;
            this.btnJugadores.TabStop = false;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::SIGD.Properties.Resources.house_solid;
            this.pbMenu.Location = new System.Drawing.Point(65, 3);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(25, 71);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFiltroNombre.Location = new System.Drawing.Point(119, 150);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(213, 22);
            this.txtFiltroNombre.TabIndex = 26;
            // 
            // cbxTitulos
            // 
            this.cbxTitulos.FormattingEnabled = true;
            this.cbxTitulos.Location = new System.Drawing.Point(20, 150);
            this.cbxTitulos.Name = "cbxTitulos";
            this.cbxTitulos.Size = new System.Drawing.Size(93, 21);
            this.cbxTitulos.TabIndex = 29;
            this.cbxTitulos.Text = "Titulos";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFP.Location = new System.Drawing.Point(17, 131);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(79, 16);
            this.lblFP.TabIndex = 28;
            this.lblFP.Text = "Filtrar por:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblN.Location = new System.Drawing.Point(119, 131);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(67, 16);
            this.lblN.TabIndex = 28;
            this.lblN.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.BackgroundImage = global::SIGD.Properties.Resources.magnifying_glass_solid;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(350, 204);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Size = new System.Drawing.Size(33, 71);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // plInferior
            // 
            this.plInferior.BackColor = System.Drawing.Color.SlateGray;
            this.plInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plInferior.Location = new System.Drawing.Point(0, 450);
            this.plInferior.Name = "plInferior";
            this.plInferior.Size = new System.Drawing.Size(941, 42);
            this.plInferior.TabIndex = 31;
            // 
            // lblFdF
            // 
            this.lblFdF.AutoSize = true;
            this.lblFdF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFdF.Location = new System.Drawing.Point(17, 208);
            this.lblFdF.Name = "lblFdF";
            this.lblFdF.Size = new System.Drawing.Size(153, 16);
            this.lblFdF.TabIndex = 28;
            this.lblFdF.Text = "Fecha de Fundación:";
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Location = new System.Drawing.Point(20, 177);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(93, 21);
            this.cbxDeporte.TabIndex = 29;
            this.cbxDeporte.Text = "Deporte";
            // 
            // lblBE
            // 
            this.lblBE.AutoSize = true;
            this.lblBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBE.Location = new System.Drawing.Point(12, 96);
            this.lblBE.Name = "lblBE";
            this.lblBE.Size = new System.Drawing.Size(217, 24);
            this.lblBE.TabIndex = 32;
            this.lblBE.Text = "Búsqueda de Equipos";
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJugadores.Location = new System.Drawing.Point(346, 96);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.Size = new System.Drawing.Size(583, 337);
            this.dgvJugadores.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = global::SIGD.Properties.Resources.magnifying_glass_solid;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(20, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(312, 23);
            this.button1.TabIndex = 39;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // FrmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 492);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.plInferior);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.cbxTitulos);
            this.Controls.Add(this.lblFdF);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblFP);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.plSuperior);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEquipos";
            this.plSuperior.ResumeLayout(false);
            this.tlpHerramientas.ResumeLayout(false);
            this.tlpOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plSuperior;
        private System.Windows.Forms.TableLayoutPanel tlpOpciones;
        private System.Windows.Forms.PictureBox pbJugadores;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.ComboBox cbxTitulos;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel plInferior;
        private System.Windows.Forms.TableLayoutPanel tlpHerramientas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblFdF;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label lblBE;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}