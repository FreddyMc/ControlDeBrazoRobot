namespace ControlDeBrazo
{
    partial class FrmSelectorDeCamara
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVideoResolutions = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.cbCaptureDevices = new System.Windows.Forms.ComboBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVideoResolutions);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(18, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resolución/FPS";
            // 
            // cbVideoResolutions
            // 
            this.cbVideoResolutions.FormattingEnabled = true;
            this.cbVideoResolutions.Location = new System.Drawing.Point(7, 27);
            this.cbVideoResolutions.Name = "cbVideoResolutions";
            this.cbVideoResolutions.Size = new System.Drawing.Size(415, 21);
            this.cbVideoResolutions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectDevice);
            this.groupBox1.Controls.Add(this.cbCaptureDevices);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(18, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar camara";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnSelectDevice.FlatAppearance.BorderSize = 0;
            this.btnSelectDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDevice.Location = new System.Drawing.Point(357, 10);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(65, 51);
            this.btnSelectDevice.TabIndex = 1;
            this.btnSelectDevice.Text = "ok";
            this.btnSelectDevice.UseVisualStyleBackColor = false;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // cbCaptureDevices
            // 
            this.cbCaptureDevices.FormattingEnabled = true;
            this.cbCaptureDevices.Location = new System.Drawing.Point(7, 27);
            this.cbCaptureDevices.Name = "cbCaptureDevices";
            this.cbCaptureDevices.Size = new System.Drawing.Size(344, 21);
            this.cbCaptureDevices.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseForm.Location = new System.Drawing.Point(195, 185);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(118, 49);
            this.btnCloseForm.TabIndex = 5;
            this.btnCloseForm.Text = "Cerrar";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnApplySettings.FlatAppearance.BorderSize = 0;
            this.btnApplySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApplySettings.Location = new System.Drawing.Point(328, 185);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(118, 49);
            this.btnApplySettings.TabIndex = 4;
            this.btnApplySettings.Text = "Aplicar";
            this.btnApplySettings.UseVisualStyleBackColor = false;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // FrmSelectorDeCamara
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(465, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnApplySettings);
            this.Name = "FrmSelectorDeCamara";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbVideoResolutions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.ComboBox cbCaptureDevices;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnApplySettings;
    }
}