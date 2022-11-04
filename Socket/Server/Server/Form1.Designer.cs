namespace Server
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtbxSnd = new System.Windows.Forms.TextBox();
            this.TxtbxRcv = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statubar = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnSnd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtbxIP = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDC = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtbxSnd
            // 
            this.TxtbxSnd.Location = new System.Drawing.Point(6, 261);
            this.TxtbxSnd.Multiline = true;
            this.TxtbxSnd.Name = "TxtbxSnd";
            this.TxtbxSnd.Size = new System.Drawing.Size(259, 79);
            this.TxtbxSnd.TabIndex = 0;
            this.TxtbxSnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbxSnd_KeyUp);
            // 
            // TxtbxRcv
            // 
            this.TxtbxRcv.Location = new System.Drawing.Point(6, 148);
            this.TxtbxRcv.Multiline = true;
            this.TxtbxRcv.Name = "TxtbxRcv";
            this.TxtbxRcv.ReadOnly = true;
            this.TxtbxRcv.Size = new System.Drawing.Size(259, 79);
            this.TxtbxRcv.TabIndex = 0;
            this.TxtbxRcv.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statubar,
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statubar
            // 
            this.statubar.Name = "statubar";
            this.statubar.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BtnSnd
            // 
            this.BtnSnd.Enabled = false;
            this.BtnSnd.Location = new System.Drawing.Point(3, 132);
            this.BtnSnd.Name = "BtnSnd";
            this.BtnSnd.Size = new System.Drawing.Size(111, 32);
            this.BtnSnd.TabIndex = 1;
            this.BtnSnd.Text = "&Send";
            this.BtnSnd.UseVisualStyleBackColor = true;
            this.BtnSnd.Click += new System.EventHandler(this.BtnSnd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(3, 22);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(111, 32);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnSnd);
            this.panel1.Location = new System.Drawing.Point(276, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 184);
            this.panel1.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button8.Location = new System.Drawing.Point(401, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 32);
            this.button8.TabIndex = 28;
            this.button8.Text = "Bloquear";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.Location = new System.Drawing.Point(401, 156);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 32);
            this.button9.TabIndex = 27;
            this.button9.Text = "Habilitar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(401, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 32);
            this.button3.TabIndex = 26;
            this.button3.Text = "Reiniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(401, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 32);
            this.button4.TabIndex = 25;
            this.button4.Text = "Apagar ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtbxIP);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.BtnDC);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 66);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect To";
            // 
            // TxtbxIP
            // 
            this.TxtbxIP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxIP.Location = new System.Drawing.Point(17, 24);
            this.TxtbxIP.Name = "TxtbxIP";
            this.TxtbxIP.Size = new System.Drawing.Size(98, 22);
            this.TxtbxIP.TabIndex = 2;
            this.TxtbxIP.Text = "192.168.100.7";
            this.TxtbxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(138, 21);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(90, 27);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "&Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            // 
            // BtnDC
            // 
            this.BtnDC.Enabled = false;
            this.BtnDC.Location = new System.Drawing.Point(251, 21);
            this.BtnDC.Name = "BtnDC";
            this.BtnDC.Size = new System.Drawing.Size(90, 27);
            this.BtnDC.TabIndex = 1;
            this.BtnDC.Text = "&Disconect";
            this.BtnDC.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Location = new System.Drawing.Point(514, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 32);
            this.button7.TabIndex = 31;
            this.button7.Text = "Iniciar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(514, 57);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 32);
            this.button10.TabIndex = 30;
            this.button10.Text = "Añadir Tiempo";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Administrador de tareas";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnSnd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(632, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TxtbxRcv);
            this.Controls.Add(this.TxtbxSnd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbxSnd;
        private System.Windows.Forms.TextBox TxtbxRcv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statubar;
        private System.Windows.Forms.Button BtnSnd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtbxIP;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDC;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
    }
}

