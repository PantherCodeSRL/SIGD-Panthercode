namespace CapaPresentacion
{
    partial class FrmJugadores
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxAltura = new System.Windows.Forms.ComboBox();
            this.cbxPeso = new System.Windows.Forms.ComboBox();
            this.cbxEdad = new System.Windows.Forms.ComboBox();
            this.lblFP = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblIngresarCi = new System.Windows.Forms.Label();
            this.mtbCI = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblBJ = new System.Windows.Forms.Label();
            this.plFiltro = new System.Windows.Forms.Panel();
            this.dtpFechF = new System.Windows.Forms.DateTimePicker();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.plAdminEquipos = new System.Windows.Forms.Panel();
            this.lblHAJ = new System.Windows.Forms.Label();
            this.btnCrearJ = new System.Windows.Forms.Button();
            this.btnBorrarJ = new System.Windows.Forms.Button();
            this.btnModificarJ = new System.Windows.Forms.Button();
            this.btnBuscarJ = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.plAdminEquipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 81);
            this.panel4.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCerrar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMinimizar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(877, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(64, 81);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.circle_xmark_solid;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(35, 6);
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
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::CapaPresentacion.Properties.Resources.minus_solid;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(3, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 35);
            this.btnMinimizar.TabIndex = 21;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMenu, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEquipos, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 81);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.people_group_solid;
            this.pictureBox3.Location = new System.Drawing.Point(188, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
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
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.SlateGray;
            this.btnEquipos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEquipos.ForeColor = System.Drawing.Color.Black;
            this.btnEquipos.Location = new System.Drawing.Point(230, 3);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(89, 75);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.TabStop = false;
            this.btnEquipos.Text = " Equipos";
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.house_solid;
            this.pictureBox1.Location = new System.Drawing.Point(65, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(124, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 26;
            // 
            // cbxAltura
            // 
            this.cbxAltura.FormattingEnabled = true;
            this.cbxAltura.Location = new System.Drawing.Point(25, 29);
            this.cbxAltura.Name = "cbxAltura";
            this.cbxAltura.Size = new System.Drawing.Size(93, 21);
            this.cbxAltura.TabIndex = 29;
            this.cbxAltura.Text = "Altura";
            // 
            // cbxPeso
            // 
            this.cbxPeso.FormattingEnabled = true;
            this.cbxPeso.Location = new System.Drawing.Point(25, 58);
            this.cbxPeso.Name = "cbxPeso";
            this.cbxPeso.Size = new System.Drawing.Size(93, 21);
            this.cbxPeso.TabIndex = 29;
            this.cbxPeso.Text = "Peso";
            // 
            // cbxEdad
            // 
            this.cbxEdad.FormattingEnabled = true;
            this.cbxEdad.Location = new System.Drawing.Point(25, 87);
            this.cbxEdad.Name = "cbxEdad";
            this.cbxEdad.Size = new System.Drawing.Size(93, 21);
            this.cbxEdad.TabIndex = 29;
            this.cbxEdad.Text = "Edad";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFP.Location = new System.Drawing.Point(22, 9);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(79, 16);
            this.lblFP.TabIndex = 28;
            this.lblFP.Text = "Filtrar por:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(124, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(195, 22);
            this.txtApellido.TabIndex = 26;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApe.Location = new System.Drawing.Point(124, 53);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(70, 16);
            this.lblApe.TabIndex = 28;
            this.lblApe.Text = "Apellido:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(124, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(67, 16);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nombre:";
            // 
            // lblIngresarCi
            // 
            this.lblIngresarCi.AutoSize = true;
            this.lblIngresarCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIngresarCi.Location = new System.Drawing.Point(22, 139);
            this.lblIngresarCi.Name = "lblIngresarCi";
            this.lblIngresarCi.Size = new System.Drawing.Size(120, 16);
            this.lblIngresarCi.TabIndex = 28;
            this.lblIngresarCi.Text = "Ingresar cédula:";
            // 
            // mtbCI
            // 
            this.mtbCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbCI.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbCI.Location = new System.Drawing.Point(148, 133);
            this.mtbCI.Mask = "0000000-0";
            this.mtbCI.Name = "mtbCI";
            this.mtbCI.Size = new System.Drawing.Size(86, 26);
            this.mtbCI.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 42);
            this.panel1.TabIndex = 31;
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechNac.Location = new System.Drawing.Point(82, 149);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(129, 13);
            this.lblFechNac.TabIndex = 28;
            this.lblFechNac.Text = "Fecha de nacimiento:";
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Items.AddRange(new object[] {
            "Basketball",
            "Football",
            "Handball"});
            this.cbxDeporte.Location = new System.Drawing.Point(25, 117);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(93, 21);
            this.cbxDeporte.TabIndex = 29;
            this.cbxDeporte.Text = "Deporte";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEquipo.Location = new System.Drawing.Point(124, 117);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(195, 22);
            this.txtEquipo.TabIndex = 26;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEquipo.Location = new System.Drawing.Point(124, 98);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(61, 16);
            this.lblEquipo.TabIndex = 28;
            this.lblEquipo.Text = "Equipo:";
            // 
            // lblBJ
            // 
            this.lblBJ.AutoSize = true;
            this.lblBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBJ.Location = new System.Drawing.Point(21, 99);
            this.lblBJ.Name = "lblBJ";
            this.lblBJ.Size = new System.Drawing.Size(233, 24);
            this.lblBJ.TabIndex = 32;
            this.lblBJ.Text = "Búsqueda de jugadores";
            // 
            // plFiltro
            // 
            this.plFiltro.Controls.Add(this.dtpFechF);
            this.plFiltro.Controls.Add(this.lblFechNac);
            this.plFiltro.Controls.Add(this.txtEquipo);
            this.plFiltro.Controls.Add(this.cbxAltura);
            this.plFiltro.Controls.Add(this.lblFP);
            this.plFiltro.Controls.Add(this.cbxPeso);
            this.plFiltro.Controls.Add(this.cbxEdad);
            this.plFiltro.Controls.Add(this.cbxDeporte);
            this.plFiltro.Controls.Add(this.txtApellido);
            this.plFiltro.Controls.Add(this.txtNombre);
            this.plFiltro.Controls.Add(this.lblNom);
            this.plFiltro.Controls.Add(this.lblApe);
            this.plFiltro.Controls.Add(this.lblEquipo);
            this.plFiltro.Location = new System.Drawing.Point(0, 167);
            this.plFiltro.Name = "plFiltro";
            this.plFiltro.Size = new System.Drawing.Size(337, 170);
            this.plFiltro.TabIndex = 36;
            this.plFiltro.Visible = false;
            // 
            // dtpFechF
            // 
            this.dtpFechF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechF.Location = new System.Drawing.Point(217, 146);
            this.dtpFechF.Name = "dtpFechF";
            this.dtpFechF.Size = new System.Drawing.Size(102, 20);
            this.dtpFechF.TabIndex = 41;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJugadores.Location = new System.Drawing.Point(360, 99);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(564, 337);
            this.dgvJugadores.TabIndex = 37;
            // 
            // plAdminEquipos
            // 
            this.plAdminEquipos.Controls.Add(this.lblHAJ);
            this.plAdminEquipos.Controls.Add(this.btnCrearJ);
            this.plAdminEquipos.Controls.Add(this.btnBorrarJ);
            this.plAdminEquipos.Controls.Add(this.btnModificarJ);
            this.plAdminEquipos.Location = new System.Drawing.Point(0, 338);
            this.plAdminEquipos.Name = "plAdminEquipos";
            this.plAdminEquipos.Size = new System.Drawing.Size(337, 106);
            this.plAdminEquipos.TabIndex = 43;
            this.plAdminEquipos.Visible = false;
            // 
            // lblHAJ
            // 
            this.lblHAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHAJ.Location = new System.Drawing.Point(13, 2);
            this.lblHAJ.Name = "lblHAJ";
            this.lblHAJ.Size = new System.Drawing.Size(306, 42);
            this.lblHAJ.TabIndex = 43;
            this.lblHAJ.Text = "Herramientas de Administración de Jugadores";
            // 
            // btnCrearJ
            // 
            this.btnCrearJ.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearJ.BackgroundImage = global::CapaPresentacion.Properties.Resources.circle_plus_solid;
            this.btnCrearJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrearJ.FlatAppearance.BorderSize = 0;
            this.btnCrearJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearJ.Location = new System.Drawing.Point(25, 48);
            this.btnCrearJ.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearJ.Name = "btnCrearJ";
            this.btnCrearJ.Size = new System.Drawing.Size(50, 50);
            this.btnCrearJ.TabIndex = 41;
            this.btnCrearJ.UseVisualStyleBackColor = false;
            this.btnCrearJ.Click += new System.EventHandler(this.btnCrearJ_Click);
            // 
            // btnBorrarJ
            // 
            this.btnBorrarJ.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarJ.BackgroundImage = global::CapaPresentacion.Properties.Resources.eraser_solid;
            this.btnBorrarJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarJ.FlatAppearance.BorderSize = 0;
            this.btnBorrarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarJ.Location = new System.Drawing.Point(157, 48);
            this.btnBorrarJ.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrarJ.Name = "btnBorrarJ";
            this.btnBorrarJ.Size = new System.Drawing.Size(50, 50);
            this.btnBorrarJ.TabIndex = 41;
            this.btnBorrarJ.UseVisualStyleBackColor = false;
            this.btnBorrarJ.Click += new System.EventHandler(this.btnBorrarJ_Click);
            // 
            // btnModificarJ
            // 
            this.btnModificarJ.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarJ.BackgroundImage = global::CapaPresentacion.Properties.Resources.pen_to_square_solid;
            this.btnModificarJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarJ.FlatAppearance.BorderSize = 0;
            this.btnModificarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJ.Location = new System.Drawing.Point(94, 48);
            this.btnModificarJ.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarJ.Name = "btnModificarJ";
            this.btnModificarJ.Size = new System.Drawing.Size(50, 50);
            this.btnModificarJ.TabIndex = 41;
            this.btnModificarJ.UseVisualStyleBackColor = false;
            this.btnModificarJ.Click += new System.EventHandler(this.btnModificarJ_Click);
            // 
            // btnBuscarJ
            // 
            this.btnBuscarJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarJ.BackgroundImage = global::CapaPresentacion.Properties.Resources.magnifying_glass_solid;
            this.btnBuscarJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarJ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarJ.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarJ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarJ.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarJ.Location = new System.Drawing.Point(244, 133);
            this.btnBuscarJ.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarJ.Name = "btnBuscarJ";
            this.btnBuscarJ.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarJ.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarJ.TabIndex = 0;
            this.btnBuscarJ.TabStop = false;
            this.btnBuscarJ.UseVisualStyleBackColor = false;
            // 
            // FrmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 492);
            this.Controls.Add(this.plAdminEquipos);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.lblBJ);
            this.Controls.Add(this.btnBuscarJ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtbCI);
            this.Controls.Add(this.lblIngresarCi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.plFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJugador";
            this.Activated += new System.EventHandler(this.FrmJugadores_Activated);
            this.Load += new System.EventHandler(this.FrmJugadores_Load);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plFiltro.ResumeLayout(false);
            this.plFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.plAdminEquipos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxAltura;
        private System.Windows.Forms.ComboBox cbxPeso;
        private System.Windows.Forms.ComboBox cbxEdad;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblIngresarCi;
        private System.Windows.Forms.Button btnBuscarJ;
        private System.Windows.Forms.MaskedTextBox mtbCI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblBJ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel plFiltro;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.DateTimePicker dtpFechF;
        private System.Windows.Forms.Panel plAdminEquipos;
        private System.Windows.Forms.Label lblHAJ;
        private System.Windows.Forms.Button btnCrearJ;
        private System.Windows.Forms.Button btnBorrarJ;
        private System.Windows.Forms.Button btnModificarJ;
    }
}