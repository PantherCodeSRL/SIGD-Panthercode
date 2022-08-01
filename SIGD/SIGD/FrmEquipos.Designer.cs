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
            resources.ApplyResources(this.plSuperior, "plSuperior");
            this.plSuperior.Name = "plSuperior";
            // 
            // tlpHerramientas
            // 
            resources.ApplyResources(this.tlpHerramientas, "tlpHerramientas");
            this.tlpHerramientas.Controls.Add(this.btnCerrar, 2, 0);
            this.tlpHerramientas.Controls.Add(this.btnMin, 0, 0);
            this.tlpHerramientas.Controls.Add(this.button7, 1, 0);
            this.tlpHerramientas.Name = "tlpHerramientas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SIGD.Properties.Resources.circle_xmark_solid;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::SIGD.Properties.Resources.minus_solid;
            resources.ApplyResources(this.btnMin, "btnMin");
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.Name = "btnMin";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SIGD.Properties.Resources.window_maximize_solid;
            resources.ApplyResources(this.button7, "button7");
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // tlpOpciones
            // 
            resources.ApplyResources(this.tlpOpciones, "tlpOpciones");
            this.tlpOpciones.Controls.Add(this.pbJugadores, 3, 0);
            this.tlpOpciones.Controls.Add(this.btnMenu, 2, 0);
            this.tlpOpciones.Controls.Add(this.btnJugadores, 4, 0);
            this.tlpOpciones.Controls.Add(this.pbMenu, 1, 0);
            this.tlpOpciones.Name = "tlpOpciones";
            // 
            // pbJugadores
            // 
            this.pbJugadores.Image = global::SIGD.Properties.Resources.person_running_solid;
            resources.ApplyResources(this.pbJugadores, "pbJugadores");
            this.pbJugadores.Name = "pbJugadores";
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
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.TabStop = false;
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
            resources.ApplyResources(this.btnJugadores, "btnJugadores");
            this.btnJugadores.ForeColor = System.Drawing.Color.Black;
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.TabStop = false;
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::SIGD.Properties.Resources.house_solid;
            resources.ApplyResources(this.pbMenu, "pbMenu");
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.TabStop = false;
            // 
            // txtFiltroNombre
            // 
            resources.ApplyResources(this.txtFiltroNombre, "txtFiltroNombre");
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            // 
            // cbxTitulos
            // 
            this.cbxTitulos.FormattingEnabled = true;
            resources.ApplyResources(this.cbxTitulos, "cbxTitulos");
            this.cbxTitulos.Name = "cbxTitulos";
            // 
            // lblFP
            // 
            resources.ApplyResources(this.lblFP, "lblFP");
            this.lblFP.Name = "lblFP";
            // 
            // lblN
            // 
            resources.ApplyResources(this.lblN, "lblN");
            this.lblN.Name = "lblN";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.BackgroundImage = global::SIGD.Properties.Resources.magnifying_glass_solid;
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.TabStop = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // plInferior
            // 
            this.plInferior.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.plInferior, "plInferior");
            this.plInferior.Name = "plInferior";
            // 
            // mtbFecha
            // 
            resources.ApplyResources(this.mtbFecha, "mtbFecha");
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFdF
            // 
            resources.ApplyResources(this.lblFdF, "lblFdF");
            this.lblFdF.Name = "lblFdF";
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            resources.ApplyResources(this.cbxDeporte, "cbxDeporte");
            this.cbxDeporte.Name = "cbxDeporte";
            // 
            // lblBE
            // 
            resources.ApplyResources(this.lblBE, "lblBE");
            this.lblBE.Name = "lblBE";
            // 
            // plEquipos
            // 
            resources.ApplyResources(this.plEquipos, "plEquipos");
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
            this.plEquipos.Name = "plEquipos";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button11, "button11");
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Name = "button11";
            this.button11.TabStop = false;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button6, "button6");
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Name = "button6";
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button9, "button9");
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Name = "button9";
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Name = "button4";
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Name = "button3";
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmEquipos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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