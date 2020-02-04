namespace ControlDeBrazo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PInferior = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PSuperior = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMCamra = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProcesaImagen = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrjinalOrProcessImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiOrSingleTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PIzquierdo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vChica = new System.Windows.Forms.VScrollBar();
            this.vGrande = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vPzadetect = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGris = new System.Windows.Forms.RadioButton();
            this.rdOriginal = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PCentralPadre = new System.Windows.Forms.Panel();
            this.PCentral = new System.Windows.Forms.Panel();
            this.PbPantalla = new System.Windows.Forms.PictureBox();
            this.PDerecho = new System.Windows.Forms.Panel();
            this.lblPieza = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.PSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.PIzquierdo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PCentralPadre.SuspendLayout();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPantalla)).BeginInit();
            this.PDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // PInferior
            // 
            this.PInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.PInferior.Controls.Add(this.button4);
            this.PInferior.Controls.Add(this.label5);
            this.PInferior.Controls.Add(this.numericUpDown1);
            this.PInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PInferior.Location = new System.Drawing.Point(0, 333);
            this.PInferior.MaximumSize = new System.Drawing.Size(800, 50);
            this.PInferior.Name = "PInferior";
            this.PInferior.Size = new System.Drawing.Size(726, 43);
            this.PInferior.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(229, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Default";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Width height blob";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(102, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // PSuperior
            // 
            this.PSuperior.Controls.Add(this.tableLayoutPanel1);
            this.PSuperior.Controls.Add(this.PLogo);
            this.PSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSuperior.Location = new System.Drawing.Point(0, 0);
            this.PSuperior.MaximumSize = new System.Drawing.Size(800, 74);
            this.PSuperior.Name = "PSuperior";
            this.PSuperior.Size = new System.Drawing.Size(800, 74);
            this.PSuperior.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.44313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85229F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMaximizar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMinimizar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMCamra,
            this.TSMProcesaImagen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(620, 41);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMCamra
            // 
            this.TSMCamra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TSMCamra.ForeColor = System.Drawing.SystemColors.Control;
            this.TSMCamra.Name = "TSMCamra";
            this.TSMCamra.Size = new System.Drawing.Size(60, 21);
            this.TSMCamra.Text = "Cámara";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.setToolStripMenuItem.Text = "Seleccionar fuente";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.SetToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.startToolStripMenuItem.Text = "Iniciar";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.stopToolStripMenuItem.Text = "Parar";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clearToolStripMenuItem.Text = "Limpiar";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TSMProcesaImagen
            // 
            this.TSMProcesaImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.TSMProcesaImagen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTrackingToolStripMenuItem,
            this.showOrjinalOrProcessImageToolStripMenuItem,
            this.multiOrSingleTrackingToolStripMenuItem});
            this.TSMProcesaImagen.ForeColor = System.Drawing.SystemColors.Control;
            this.TSMProcesaImagen.Name = "TSMProcesaImagen";
            this.TSMProcesaImagen.Size = new System.Drawing.Size(157, 21);
            this.TSMProcesaImagen.Text = "Procesamiento de imagen";
            // 
            // colorTrackingToolStripMenuItem
            // 
            this.colorTrackingToolStripMenuItem.Name = "colorTrackingToolStripMenuItem";
            this.colorTrackingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.colorTrackingToolStripMenuItem.Text = "Seguimiento de color";
            this.colorTrackingToolStripMenuItem.Click += new System.EventHandler(this.ColorTrackingToolStripMenuItem_Click);
            // 
            // showOrjinalOrProcessImageToolStripMenuItem
            // 
            this.showOrjinalOrProcessImageToolStripMenuItem.CheckOnClick = true;
            this.showOrjinalOrProcessImageToolStripMenuItem.Name = "showOrjinalOrProcessImageToolStripMenuItem";
            this.showOrjinalOrProcessImageToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showOrjinalOrProcessImageToolStripMenuItem.Text = "Mostrar original";
            this.showOrjinalOrProcessImageToolStripMenuItem.Click += new System.EventHandler(this.ShowOrjinalOrProcessImageToolStripMenuItem_Click);
            // 
            // multiOrSingleTrackingToolStripMenuItem
            // 
            this.multiOrSingleTrackingToolStripMenuItem.CheckOnClick = true;
            this.multiOrSingleTrackingToolStripMenuItem.Name = "multiOrSingleTrackingToolStripMenuItem";
            this.multiOrSingleTrackingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.multiOrSingleTrackingToolStripMenuItem.Text = "Rastreo multiple";
            this.multiOrSingleTrackingToolStripMenuItem.Click += new System.EventHandler(this.MultiOrSingleTrackingToolStripMenuItem_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTitulo.Location = new System.Drawing.Point(5, 5);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.LblTitulo.Size = new System.Drawing.Size(610, 23);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Control de brazos robot";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(693, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 27);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(658, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 27);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(623, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            // 
            // PLogo
            // 
            this.PLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(74, 74);
            this.PLogo.TabIndex = 1;
            // 
            // PIzquierdo
            // 
            this.PIzquierdo.Controls.Add(this.label4);
            this.PIzquierdo.Controls.Add(this.label3);
            this.PIzquierdo.Controls.Add(this.label2);
            this.PIzquierdo.Controls.Add(this.label1);
            this.PIzquierdo.Controls.Add(this.vChica);
            this.PIzquierdo.Controls.Add(this.vGrande);
            this.PIzquierdo.Controls.Add(this.vScrollBar1);
            this.PIzquierdo.Controls.Add(this.vPzadetect);
            this.PIzquierdo.Controls.Add(this.groupBox1);
            this.PIzquierdo.Controls.Add(this.button3);
            this.PIzquierdo.Controls.Add(this.button2);
            this.PIzquierdo.Controls.Add(this.button1);
            this.PIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PIzquierdo.Location = new System.Drawing.Point(0, 74);
            this.PIzquierdo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PIzquierdo.Name = "PIzquierdo";
            this.PIzquierdo.Size = new System.Drawing.Size(74, 376);
            this.PIzquierdo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Desv clr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lim detect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grande";
            // 
            // vChica
            // 
            this.vChica.Location = new System.Drawing.Point(50, 296);
            this.vChica.Maximum = 1000000;
            this.vChica.Name = "vChica";
            this.vChica.Size = new System.Drawing.Size(17, 80);
            this.vChica.TabIndex = 6;
            this.vChica.Value = 800;
            // 
            // vGrande
            // 
            this.vGrande.Location = new System.Drawing.Point(7, 287);
            this.vGrande.Maximum = 1000000;
            this.vGrande.Name = "vGrande";
            this.vGrande.Size = new System.Drawing.Size(17, 80);
            this.vGrande.TabIndex = 5;
            this.vGrande.Value = 1000;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(49, 190);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Value = 5;
            // 
            // vPzadetect
            // 
            this.vPzadetect.Location = new System.Drawing.Point(7, 178);
            this.vPzadetect.Maximum = 100000;
            this.vPzadetect.Name = "vPzadetect";
            this.vPzadetect.Size = new System.Drawing.Size(17, 80);
            this.vPzadetect.TabIndex = 1;
            this.vPzadetect.Value = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGris);
            this.groupBox1.Controls.Add(this.rdOriginal);
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitmap";
            // 
            // rbGris
            // 
            this.rbGris.AutoSize = true;
            this.rbGris.Location = new System.Drawing.Point(7, 44);
            this.rbGris.Name = "rbGris";
            this.rbGris.Size = new System.Drawing.Size(43, 17);
            this.rbGris.TabIndex = 1;
            this.rbGris.TabStop = true;
            this.rbGris.Text = "Gris";
            this.rbGris.UseVisualStyleBackColor = true;
            // 
            // rdOriginal
            // 
            this.rdOriginal.AutoSize = true;
            this.rdOriginal.Checked = true;
            this.rdOriginal.Location = new System.Drawing.Point(7, 20);
            this.rdOriginal.Name = "rdOriginal";
            this.rdOriginal.Size = new System.Drawing.Size(60, 17);
            this.rdOriginal.TabIndex = 0;
            this.rdOriginal.TabStop = true;
            this.rdOriginal.Text = "Original";
            this.rdOriginal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.MaximumSize = new System.Drawing.Size(74, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.MaximumSize = new System.Drawing.Size(74, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver Pertos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MaximumSize = new System.Drawing.Size(74, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PCentralPadre
            // 
            this.PCentralPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.PCentralPadre.Controls.Add(this.PCentral);
            this.PCentralPadre.Controls.Add(this.PDerecho);
            this.PCentralPadre.Controls.Add(this.PInferior);
            this.PCentralPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentralPadre.Location = new System.Drawing.Point(74, 74);
            this.PCentralPadre.Name = "PCentralPadre";
            this.PCentralPadre.Size = new System.Drawing.Size(726, 376);
            this.PCentralPadre.TabIndex = 3;
            // 
            // PCentral
            // 
            this.PCentral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.PCentral.Controls.Add(this.PbPantalla);
            this.PCentral.Location = new System.Drawing.Point(3, 3);
            this.PCentral.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(614, 328);
            this.PCentral.TabIndex = 4;
            // 
            // PbPantalla
            // 
            this.PbPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbPantalla.Location = new System.Drawing.Point(0, 0);
            this.PbPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.PbPantalla.Name = "PbPantalla";
            this.PbPantalla.Size = new System.Drawing.Size(614, 328);
            this.PbPantalla.TabIndex = 0;
            this.PbPantalla.TabStop = false;
            // 
            // PDerecho
            // 
            this.PDerecho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.PDerecho.Controls.Add(this.label7);
            this.PDerecho.Controls.Add(this.textBox1);
            this.PDerecho.Controls.Add(this.label6);
            this.PDerecho.Controls.Add(this.comboBox1);
            this.PDerecho.Controls.Add(this.lblPieza);
            this.PDerecho.Location = new System.Drawing.Point(620, 3);
            this.PDerecho.Name = "PDerecho";
            this.PDerecho.Size = new System.Drawing.Size(103, 328);
            this.PDerecho.TabIndex = 3;
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPieza.Location = new System.Drawing.Point(4, 9);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(35, 13);
            this.lblPieza.TabIndex = 0;
            this.lblPieza.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Puertos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mensaje";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCentralPadre);
            this.Controls.Add(this.PIzquierdo);
            this.Controls.Add(this.PSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.PInferior.ResumeLayout(false);
            this.PInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.PSuperior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.PIzquierdo.ResumeLayout(false);
            this.PIzquierdo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PCentralPadre.ResumeLayout(false);
            this.PCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbPantalla)).EndInit();
            this.PDerecho.ResumeLayout(false);
            this.PDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PInferior;
        private System.Windows.Forms.Panel PSuperior;
        private System.Windows.Forms.Panel PIzquierdo;
        private System.Windows.Forms.Panel PCentralPadre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Panel PDerecho;
        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PbPantalla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMCamra;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMProcesaImagen;
        private System.Windows.Forms.ToolStripMenuItem colorTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrjinalOrProcessImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiOrSingleTrackingToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblPieza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdOriginal;
        private System.Windows.Forms.VScrollBar vPzadetect;
        private System.Windows.Forms.RadioButton rbGris;
        private System.Windows.Forms.VScrollBar vGrande;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vChica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

