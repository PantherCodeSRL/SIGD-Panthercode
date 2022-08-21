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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipos));
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
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFdF = new System.Windows.Forms.Label();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.lblBE = new System.Windows.Forms.Label();
            this.plEquipos = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.plSuperior.SuspendLayout();
            this.tlpHerramientas.SuspendLayout();
            this.tlpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.plEquipos.SuspendLayout();
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
            this.txtFiltroNombre.Location = new System.Drawing.Point(146, 204);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(195, 22);
            this.txtFiltroNombre.TabIndex = 26;
            // 
            // cbxTitulos
            // 
            this.cbxTitulos.FormattingEnabled = true;
            this.cbxTitulos.Location = new System.Drawing.Point(47, 204);
            this.cbxTitulos.Name = "cbxTitulos";
            this.cbxTitulos.Size = new System.Drawing.Size(93, 21);
            this.cbxTitulos.TabIndex = 29;
            this.cbxTitulos.Text = "Titulos";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFP.Location = new System.Drawing.Point(44, 185);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(79, 16);
            this.lblFP.TabIndex = 28;
            this.lblFP.Text = "Filtrar por:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblN.Location = new System.Drawing.Point(146, 185);
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
            // mtbFecha
            // 
            this.mtbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbFecha.Location = new System.Drawing.Point(203, 249);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(92, 26);
            this.mtbFecha.TabIndex = 30;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFdF
            // 
            this.lblFdF.AutoSize = true;
            this.lblFdF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFdF.Location = new System.Drawing.Point(44, 255);
            this.lblFdF.Name = "lblFdF";
            this.lblFdF.Size = new System.Drawing.Size(153, 16);
            this.lblFdF.TabIndex = 28;
            this.lblFdF.Text = "Fecha de Fundación:";
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Location = new System.Drawing.Point(47, 231);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(93, 21);
            this.cbxDeporte.TabIndex = 29;
            this.cbxDeporte.Text = "Deporte";
            // 
            // lblBE
            // 
            this.lblBE.AutoSize = true;
            this.lblBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBE.Location = new System.Drawing.Point(39, 150);
            this.lblBE.Name = "lblBE";
            this.lblBE.Size = new System.Drawing.Size(217, 24);
            this.lblBE.TabIndex = 32;
            this.lblBE.Text = "Búsqueda de Equipos";
            // 
            // plEquipos
            // 
            this.plEquipos.AutoScroll = true;
            this.plEquipos.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.plEquipos.Controls.Add(this.label15);
            this.plEquipos.Controls.Add(this.label11);
            this.plEquipos.Controls.Add(this.label10);
            this.plEquipos.Controls.Add(this.label13);
            this.plEquipos.Controls.Add(this.label9);
            this.plEquipos.Controls.Add(this.label8);
            this.plEquipos.Controls.Add(this.button11);
            this.plEquipos.Controls.Add(this.button6);
            this.plEquipos.Controls.Add(this.button9);
            this.plEquipos.Controls.Add(this.button4);
            this.plEquipos.Controls.Add(this.button3);
            this.plEquipos.Controls.Add(this.button2);
            this.plEquipos.Dock = System.Windows.Forms.DockStyle.Right;
            this.plEquipos.Location = new System.Drawing.Point(392, 81);
            this.plEquipos.Name = "plEquipos";
            this.plEquipos.Size = new System.Drawing.Size(549, 369);
            this.plEquipos.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(317, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Datos de Equipo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(317, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Datos de Equipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(317, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Datos de Equipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(103, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Datos de Equipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(103, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Datos de Equipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(103, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Datos de Equipo";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(128, 393);
            this.button11.Margin = new System.Windows.Forms.Padding(6);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(5);
            this.button11.Size = new System.Drawing.Size(76, 116);
            this.button11.TabIndex = 35;
            this.button11.TabStop = false;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(128, 208);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(5);
            this.button6.Size = new System.Drawing.Size(76, 116);
            this.button6.TabIndex = 35;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(337, 393);
            this.button9.Margin = new System.Windows.Forms.Padding(6);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(5);
            this.button9.Size = new System.Drawing.Size(76, 116);
            this.button9.TabIndex = 37;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(337, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5);
            this.button4.Size = new System.Drawing.Size(76, 116);
            this.button4.TabIndex = 36;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(337, 208);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(76, 116);
            this.button3.TabIndex = 37;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(128, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(76, 116);
            this.button2.TabIndex = 38;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 492);
            this.Controls.Add(this.plEquipos);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.plInferior);
            this.Controls.Add(this.mtbFecha);
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
            this.plEquipos.ResumeLayout(false);
            this.plEquipos.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.Label lblFdF;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label lblBE;
        private System.Windows.Forms.Panel plEquipos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}