namespace Sheet_metal_board_reminder
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbXmlFile = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblXmlFile = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMins = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.chbOnStartTimer = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbXmlFile
            // 
            this.tbXmlFile.Location = new System.Drawing.Point(85, 6);
            this.tbXmlFile.Name = "tbXmlFile";
            this.tbXmlFile.ReadOnly = true;
            this.tbXmlFile.Size = new System.Drawing.Size(213, 20);
            this.tbXmlFile.TabIndex = 0;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(140, 39);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTimer.Size = new System.Drawing.Size(73, 20);
            this.tbTimer.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(304, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Procházet";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(304, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(385, 166);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lblXmlFile
            // 
            this.lblXmlFile.AutoSize = true;
            this.lblXmlFile.Location = new System.Drawing.Point(12, 9);
            this.lblXmlFile.Name = "lblXmlFile";
            this.lblXmlFile.Size = new System.Drawing.Size(67, 13);
            this.lblXmlFile.TabIndex = 6;
            this.lblXmlFile.Text = "XML soubor:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(12, 42);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(122, 13);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Časový interval kontroly:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 192);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 17);
            this.lblStatus.Text = "status";
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(219, 42);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(32, 13);
            this.lblMins.TabIndex = 10;
            this.lblMins.Text = "minut";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(385, 4);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 11;
            this.btnDefault.Text = "Výchozí";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // chbOnStartTimer
            // 
            this.chbOnStartTimer.AutoSize = true;
            this.chbOnStartTimer.Location = new System.Drawing.Point(15, 86);
            this.chbOnStartTimer.Name = "chbOnStartTimer";
            this.chbOnStartTimer.Size = new System.Drawing.Size(302, 17);
            this.chbOnStartTimer.TabIndex = 12;
            this.chbOnStartTimer.Text = "Po spuštění automaticky zapnout časovač a minimalizovat";
            this.chbOnStartTimer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 214);
            this.Controls.Add(this.chbOnStartTimer);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblXmlFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tbXmlFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Upozornění na nulový stav tabulí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXmlFile;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblXmlFile;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.CheckBox chbOnStartTimer;
    }
}

