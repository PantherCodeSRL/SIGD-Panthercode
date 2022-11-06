namespace CapaPresentacion
{
    partial class FrmIncidencias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncidencias));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPartido = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFixture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plAdminEquipos = new System.Windows.Forms.Panel();
            this.lblHAI = new System.Windows.Forms.Label();
            this.btnCrearI = new System.Windows.Forms.Button();
            this.btnBorrarI = new System.Windows.Forms.Button();
            this.btnModificarI = new System.Windows.Forms.Button();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plFiltro = new System.Windows.Forms.Panel();
            this.cbxTI = new System.Windows.Forms.ComboBox();
            this.lblFP = new System.Windows.Forms.Label();
            this.cbxJugador = new System.Windows.Forms.ComboBox();
            this.lblBI = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plAdminEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.plFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.lblPartido);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 81);
            this.panel4.TabIndex = 44;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.BackColor = System.Drawing.Color.Transparent;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPartido.ForeColor = System.Drawing.Color.Black;
            this.lblPartido.Location = new System.Drawing.Point(377, 29);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(165, 24);
            this.lblPartido.TabIndex = 50;
            this.lblPartido.Text = "(Partido elegido)";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(897, 0);
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
            this.tableLayoutPanel2.Controls.Add(this.btnFixture, 4, 0);
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
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.calendar_regular;
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
            // 
            // btnFixture
            // 
            this.btnFixture.BackColor = System.Drawing.Color.SlateGray;
            this.btnFixture.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFixture.FlatAppearance.BorderSize = 0;
            this.btnFixture.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFixture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFixture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.btnFixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFixture.ForeColor = System.Drawing.Color.Black;
            this.btnFixture.Location = new System.Drawing.Point(230, 3);
            this.btnFixture.Name = "btnFixture";
            this.btnFixture.Size = new System.Drawing.Size(89, 75);
            this.btnFixture.TabIndex = 0;
            this.btnFixture.TabStop = false;
            this.btnFixture.Text = "Volver a Partidos";
            this.btnFixture.UseVisualStyleBackColor = false;
            this.btnFixture.Click += new System.EventHandler(this.btnFixture_Click);
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
            // plAdminEquipos
            // 
            this.plAdminEquipos.Controls.Add(this.lblHAI);
            this.plAdminEquipos.Controls.Add(this.btnCrearI);
            this.plAdminEquipos.Controls.Add(this.btnBorrarI);
            this.plAdminEquipos.Controls.Add(this.btnModificarI);
            this.plAdminEquipos.Location = new System.Drawing.Point(0, 343);
            this.plAdminEquipos.Name = "plAdminEquipos";
            this.plAdminEquipos.Size = new System.Drawing.Size(337, 106);
            this.plAdminEquipos.TabIndex = 48;
            this.plAdminEquipos.Visible = false;
            // 
            // lblHAI
            // 
            this.lblHAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHAI.Location = new System.Drawing.Point(13, 2);
            this.lblHAI.Name = "lblHAI";
            this.lblHAI.Size = new System.Drawing.Size(306, 42);
            this.lblHAI.TabIndex = 43;
            this.lblHAI.Text = "Herramientas de Administración de Incidencias";
            // 
            // btnCrearI
            // 
            this.btnCrearI.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearI.BackgroundImage = global::CapaPresentacion.Properties.Resources.circle_plus_solid;
            this.btnCrearI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrearI.FlatAppearance.BorderSize = 0;
            this.btnCrearI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearI.Location = new System.Drawing.Point(25, 48);
            this.btnCrearI.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearI.Name = "btnCrearI";
            this.btnCrearI.Size = new System.Drawing.Size(50, 50);
            this.btnCrearI.TabIndex = 41;
            this.btnCrearI.UseVisualStyleBackColor = false;
            this.btnCrearI.Click += new System.EventHandler(this.btnCrearI_Click);
            // 
            // btnBorrarI
            // 
            this.btnBorrarI.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarI.BackgroundImage = global::CapaPresentacion.Properties.Resources.eraser_solid;
            this.btnBorrarI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarI.FlatAppearance.BorderSize = 0;
            this.btnBorrarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarI.Location = new System.Drawing.Point(157, 48);
            this.btnBorrarI.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrarI.Name = "btnBorrarI";
            this.btnBorrarI.Size = new System.Drawing.Size(50, 50);
            this.btnBorrarI.TabIndex = 41;
            this.btnBorrarI.UseVisualStyleBackColor = false;
            this.btnBorrarI.Click += new System.EventHandler(this.btnBorrarI_Click);
            // 
            // btnModificarI
            // 
            this.btnModificarI.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarI.BackgroundImage = global::CapaPresentacion.Properties.Resources.pen_to_square_solid;
            this.btnModificarI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarI.FlatAppearance.BorderSize = 0;
            this.btnModificarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarI.Location = new System.Drawing.Point(94, 48);
            this.btnModificarI.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarI.Name = "btnModificarI";
            this.btnModificarI.Size = new System.Drawing.Size(50, 50);
            this.btnModificarI.TabIndex = 41;
            this.btnModificarI.UseVisualStyleBackColor = false;
            this.btnModificarI.Click += new System.EventHandler(this.btnModificarI_Click);
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIncidencias.Location = new System.Drawing.Point(360, 99);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidencias.Size = new System.Drawing.Size(564, 337);
            this.dgvIncidencias.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 42);
            this.panel1.TabIndex = 45;
            // 
            // plFiltro
            // 
            this.plFiltro.Controls.Add(this.cbxTI);
            this.plFiltro.Controls.Add(this.lblFP);
            this.plFiltro.Controls.Add(this.cbxJugador);
            this.plFiltro.Location = new System.Drawing.Point(0, 135);
            this.plFiltro.Name = "plFiltro";
            this.plFiltro.Size = new System.Drawing.Size(337, 101);
            this.plFiltro.TabIndex = 46;
            this.plFiltro.Visible = false;
            // 
            // cbxTI
            // 
            this.cbxTI.FormattingEnabled = true;
            this.cbxTI.Location = new System.Drawing.Point(25, 29);
            this.cbxTI.Name = "cbxTI";
            this.cbxTI.Size = new System.Drawing.Size(294, 23);
            this.cbxTI.TabIndex = 29;
            this.cbxTI.Text = "Tipo de Incidencia";
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
            // cbxJugador
            // 
            this.cbxJugador.FormattingEnabled = true;
            this.cbxJugador.Location = new System.Drawing.Point(25, 58);
            this.cbxJugador.Name = "cbxJugador";
            this.cbxJugador.Size = new System.Drawing.Size(294, 23);
            this.cbxJugador.TabIndex = 29;
            this.cbxJugador.Text = "Jugador";
            // 
            // lblBI
            // 
            this.lblBI.AutoSize = true;
            this.lblBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBI.Location = new System.Drawing.Point(21, 99);
            this.lblBI.Name = "lblBI";
            this.lblBI.Size = new System.Drawing.Size(246, 24);
            this.lblBI.TabIndex = 49;
            this.lblBI.Text = "Búsqueda de incidencias";
            // 
            // FrmIncidencias
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(961, 510);
            this.Controls.Add(this.lblBI);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.plAdminEquipos);
            this.Controls.Add(this.dgvIncidencias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIncidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmIncidencias_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plAdminEquipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.plFiltro.ResumeLayout(false);
            this.plFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFixture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plAdminEquipos;
        private System.Windows.Forms.Label lblHAI;
        private System.Windows.Forms.Button btnCrearI;
        private System.Windows.Forms.Button btnBorrarI;
        private System.Windows.Forms.Button btnModificarI;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plFiltro;
        private System.Windows.Forms.ComboBox cbxTI;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.ComboBox cbxJugador;
        private System.Windows.Forms.Label lblBI;
        private System.Windows.Forms.Label lblPartido;
    }
}

