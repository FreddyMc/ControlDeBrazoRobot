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
            this.PInferior = new System.Windows.Forms.Panel();
            this.PSuperior = new System.Windows.Forms.Panel();
            this.PIzquierdo = new System.Windows.Forms.Panel();
            this.PCentralPadre = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PDerecho = new System.Windows.Forms.Panel();
            this.PCentral = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PbPantalla = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.PSuperior.SuspendLayout();
            this.PIzquierdo.SuspendLayout();
            this.PCentralPadre.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PInferior
            // 
            this.PInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.PInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PInferior.Location = new System.Drawing.Point(0, 333);
            this.PInferior.MaximumSize = new System.Drawing.Size(800, 50);
            this.PInferior.Name = "PInferior";
            this.PInferior.Size = new System.Drawing.Size(726, 43);
            this.PInferior.TabIndex = 0;
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
            // PIzquierdo
            // 
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.44313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85229F));
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 74);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // PDerecho
            // 
            this.PDerecho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.PDerecho.Location = new System.Drawing.Point(620, 3);
            this.PDerecho.Name = "PDerecho";
            this.PDerecho.Size = new System.Drawing.Size(103, 328);
            this.PDerecho.TabIndex = 3;
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
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.NavajoWhite;
            this.LblTitulo.Location = new System.Drawing.Point(5, 5);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.LblTitulo.Size = new System.Drawing.Size(610, 23);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Control de brazos robot";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbPantalla
            // 
            this.PbPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbPantalla.Location = new System.Drawing.Point(0, 0);
            this.PbPantalla.Name = "PbPantalla";
            this.PbPantalla.Size = new System.Drawing.Size(614, 328);
            this.PbPantalla.TabIndex = 0;
            this.PbPantalla.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MaximumSize = new System.Drawing.Size(74, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.MaximumSize = new System.Drawing.Size(74, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.MaximumSize = new System.Drawing.Size(74, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCerrar.Location = new System.Drawing.Point(693, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 27);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
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
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmPrincipal";
            this.PSuperior.ResumeLayout(false);
            this.PIzquierdo.ResumeLayout(false);
            this.PCentralPadre.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbPantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
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
    }
}

