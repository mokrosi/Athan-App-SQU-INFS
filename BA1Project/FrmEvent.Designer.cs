namespace BA1Project
{
    partial class FrmEvent
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
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.fndText = new System.Windows.Forms.FontDialog();
            this.cidEvent = new System.Windows.Forms.ColorDialog();
            this.pnlEventPage = new System.Windows.Forms.Panel();
            this.txtEventTipe = new System.Windows.Forms.TextBox();
            this.btnFontStyle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.nudMinit = new System.Windows.Forms.NumericUpDown();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.lblTimeMEN = new System.Windows.Forms.Label();
            this.lbltimeMAR = new System.Windows.Forms.Label();
            this.cidBack = new System.Windows.Forms.ColorDialog();
            this.pnlEvent.SuspendLayout();
            this.pnlEventPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEvent
            // 
            this.pnlEvent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEvent.Controls.Add(this.lblEvent);
            this.pnlEvent.Location = new System.Drawing.Point(59, 13);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(308, 87);
            this.pnlEvent.TabIndex = 23;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.BackColor = System.Drawing.Color.White;
            this.lblEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEvent.Location = new System.Drawing.Point(0, 0);
            this.lblEvent.MaximumSize = new System.Drawing.Size(308, 87);
            this.lblEvent.MinimumSize = new System.Drawing.Size(308, 87);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(308, 87);
            this.lblEvent.TabIndex = 0;
            this.lblEvent.Text = "This is Event\r\n هذا حدث\r\n";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEvent.Click += new System.EventHandler(this.lblEvent_Click);
            // 
            // pnlEventPage
            // 
            this.pnlEventPage.BackColor = System.Drawing.Color.MintCream;
            this.pnlEventPage.Controls.Add(this.lbltimeMAR);
            this.pnlEventPage.Controls.Add(this.lblTimeMEN);
            this.pnlEventPage.Controls.Add(this.btnBackColor);
            this.pnlEventPage.Controls.Add(this.nudMinit);
            this.pnlEventPage.Controls.Add(this.btnAddEvent);
            this.pnlEventPage.Controls.Add(this.btnShow);
            this.pnlEventPage.Controls.Add(this.btnColor);
            this.pnlEventPage.Controls.Add(this.btnFontStyle);
            this.pnlEventPage.Controls.Add(this.txtEventTipe);
            this.pnlEventPage.Controls.Add(this.pnlEvent);
            this.pnlEventPage.Location = new System.Drawing.Point(-4, -4);
            this.pnlEventPage.Name = "pnlEventPage";
            this.pnlEventPage.Size = new System.Drawing.Size(419, 386);
            this.pnlEventPage.TabIndex = 24;
            // 
            // txtEventTipe
            // 
            this.txtEventTipe.Location = new System.Drawing.Point(79, 117);
            this.txtEventTipe.MaxLength = 180;
            this.txtEventTipe.Multiline = true;
            this.txtEventTipe.Name = "txtEventTipe";
            this.txtEventTipe.Size = new System.Drawing.Size(265, 96);
            this.txtEventTipe.TabIndex = 24;
            // 
            // btnFontStyle
            // 
            this.btnFontStyle.Location = new System.Drawing.Point(256, 273);
            this.btnFontStyle.Name = "btnFontStyle";
            this.btnFontStyle.Size = new System.Drawing.Size(75, 46);
            this.btnFontStyle.TabIndex = 25;
            this.btnFontStyle.Text = "Font Style\r\nتنسيق الخط";
            this.btnFontStyle.UseVisualStyleBackColor = true;
            this.btnFontStyle.Click += new System.EventHandler(this.btnFontStyle_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(156, 273);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 46);
            this.btnColor.TabIndex = 26;
            this.btnColor.Text = "Text Color\r\nلون الخط";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(95, 335);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 38);
            this.btnShow.TabIndex = 27;
            this.btnShow.Text = "preview\r\nمعاينة";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEvent.Location = new System.Drawing.Point(235, 335);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 38);
            this.btnAddEvent.TabIndex = 28;
            this.btnAddEvent.Text = "Add Event\r\nاضافة حدث";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // nudMinit
            // 
            this.nudMinit.Location = new System.Drawing.Point(144, 237);
            this.nudMinit.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinit.Name = "nudMinit";
            this.nudMinit.Size = new System.Drawing.Size(120, 20);
            this.nudMinit.TabIndex = 29;
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(47, 273);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 46);
            this.btnBackColor.TabIndex = 30;
            this.btnBackColor.Text = "back color\r\nلون الخلفية";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // lblTimeMEN
            // 
            this.lblTimeMEN.AutoSize = true;
            this.lblTimeMEN.Location = new System.Drawing.Point(75, 241);
            this.lblTimeMEN.Name = "lblTimeMEN";
            this.lblTimeMEN.Size = new System.Drawing.Size(47, 13);
            this.lblTimeMEN.TabIndex = 31;
            this.lblTimeMEN.Text = "Time (m)";
            // 
            // lbltimeMAR
            // 
            this.lbltimeMAR.AutoSize = true;
            this.lbltimeMAR.Location = new System.Drawing.Point(284, 239);
            this.lbltimeMAR.Name = "lbltimeMAR";
            this.lbltimeMAR.Size = new System.Drawing.Size(47, 13);
            this.lbltimeMAR.TabIndex = 32;
            this.lbltimeMAR.Text = "الوقت (د)";
            // 
            // FrmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.pnlEventPage);
            this.Name = "FrmEvent";
            this.Text = "FrmEvent";
            this.pnlEvent.ResumeLayout(false);
            this.pnlEvent.PerformLayout();
            this.pnlEventPage.ResumeLayout(false);
            this.pnlEventPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEvent;
        public System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.FontDialog fndText;
        private System.Windows.Forms.ColorDialog cidEvent;
        private System.Windows.Forms.Panel pnlEventPage;
        private System.Windows.Forms.NumericUpDown nudMinit;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFontStyle;
        private System.Windows.Forms.TextBox txtEventTipe;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lbltimeMAR;
        private System.Windows.Forms.Label lblTimeMEN;
        private System.Windows.Forms.ColorDialog cidBack;
    }
}