namespace BA1Project
{
    partial class FrmSitting
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
            this.grpSeting = new System.Windows.Forms.GroupBox();
            this.pnlSitting = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImgBackground = new System.Windows.Forms.Button();
            this.btnColorBackgroud = new System.Windows.Forms.Button();
            this.lblCitySittingAR = new System.Windows.Forms.Label();
            this.lblSittingNameAR = new System.Windows.Forms.Label();
            this.lblCitySitting = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.chkShowName = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameSitting = new System.Windows.Forms.Label();
            this.lbltitesitting = new System.Windows.Forms.Label();
            this.cidBackgroud = new System.Windows.Forms.ColorDialog();
            this.btnBGDefault = new System.Windows.Forms.Button();
            this.grpSeting.SuspendLayout();
            this.pnlSitting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeting
            // 
            this.grpSeting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpSeting.Controls.Add(this.pnlSitting);
            this.grpSeting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSeting.Location = new System.Drawing.Point(-7, -9);
            this.grpSeting.Margin = new System.Windows.Forms.Padding(2);
            this.grpSeting.Name = "grpSeting";
            this.grpSeting.Size = new System.Drawing.Size(407, 364);
            this.grpSeting.TabIndex = 19;
            this.grpSeting.TabStop = false;
            // 
            // pnlSitting
            // 
            this.pnlSitting.BackColor = System.Drawing.Color.Honeydew;
            this.pnlSitting.Controls.Add(this.btnBGDefault);
            this.pnlSitting.Controls.Add(this.label10);
            this.pnlSitting.Controls.Add(this.btnImgBackground);
            this.pnlSitting.Controls.Add(this.btnColorBackgroud);
            this.pnlSitting.Controls.Add(this.lblCitySittingAR);
            this.pnlSitting.Controls.Add(this.lblSittingNameAR);
            this.pnlSitting.Controls.Add(this.lblCitySitting);
            this.pnlSitting.Controls.Add(this.cboCity);
            this.pnlSitting.Controls.Add(this.chkShowName);
            this.pnlSitting.Controls.Add(this.btnClear);
            this.pnlSitting.Controls.Add(this.btnSave);
            this.pnlSitting.Controls.Add(this.txtName);
            this.pnlSitting.Controls.Add(this.lblNameSitting);
            this.pnlSitting.Controls.Add(this.lbltitesitting);
            this.pnlSitting.Location = new System.Drawing.Point(7, 9);
            this.pnlSitting.Name = "pnlSitting";
            this.pnlSitting.Size = new System.Drawing.Size(382, 338);
            this.pnlSitting.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "backgroud الخلفية";
            // 
            // btnImgBackground
            // 
            this.btnImgBackground.Location = new System.Drawing.Point(137, 266);
            this.btnImgBackground.Name = "btnImgBackground";
            this.btnImgBackground.Size = new System.Drawing.Size(85, 34);
            this.btnImgBackground.TabIndex = 25;
            this.btnImgBackground.Text = "choose  image\r\nاختر صورة";
            this.btnImgBackground.UseVisualStyleBackColor = true;
            this.btnImgBackground.Click += new System.EventHandler(this.btnImgBackground_Click);
            // 
            // btnColorBackgroud
            // 
            this.btnColorBackgroud.Location = new System.Drawing.Point(31, 266);
            this.btnColorBackgroud.Name = "btnColorBackgroud";
            this.btnColorBackgroud.Size = new System.Drawing.Size(82, 34);
            this.btnColorBackgroud.TabIndex = 24;
            this.btnColorBackgroud.Text = "choose colour\r\nاختر اللون";
            this.btnColorBackgroud.UseVisualStyleBackColor = true;
            this.btnColorBackgroud.Click += new System.EventHandler(this.btnColorBackgroud_Click);
            // 
            // lblCitySittingAR
            // 
            this.lblCitySittingAR.AutoSize = true;
            this.lblCitySittingAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitySittingAR.Location = new System.Drawing.Point(243, 102);
            this.lblCitySittingAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitySittingAR.Name = "lblCitySittingAR";
            this.lblCitySittingAR.Size = new System.Drawing.Size(79, 24);
            this.lblCitySittingAR.TabIndex = 10;
            this.lblCitySittingAR.Text = " : المدينة ";
            // 
            // lblSittingNameAR
            // 
            this.lblSittingNameAR.AutoSize = true;
            this.lblSittingNameAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSittingNameAR.Location = new System.Drawing.Point(250, 62);
            this.lblSittingNameAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSittingNameAR.Name = "lblSittingNameAR";
            this.lblSittingNameAR.Size = new System.Drawing.Size(56, 24);
            this.lblSittingNameAR.TabIndex = 9;
            this.lblSittingNameAR.Text = ": الاسم";
            // 
            // lblCitySitting
            // 
            this.lblCitySitting.AutoSize = true;
            this.lblCitySitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitySitting.Location = new System.Drawing.Point(27, 102);
            this.lblCitySitting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitySitting.Name = "lblCitySitting";
            this.lblCitySitting.Size = new System.Drawing.Size(53, 24);
            this.lblCitySitting.TabIndex = 8;
            this.lblCitySitting.Text = "city :";
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(91, 105);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(148, 21);
            this.cboCity.TabIndex = 7;
            // 
            // chkShowName
            // 
            this.chkShowName.AutoSize = true;
            this.chkShowName.Checked = true;
            this.chkShowName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowName.Location = new System.Drawing.Point(91, 43);
            this.chkShowName.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowName.Name = "chkShowName";
            this.chkShowName.Size = new System.Drawing.Size(81, 17);
            this.chkShowName.TabIndex = 5;
            this.chkShowName.Text = "ShowName";
            this.chkShowName.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(50, 158);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear تصفية";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 158);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE حفظ ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 31);
            this.txtName.TabIndex = 2;
            // 
            // lblNameSitting
            // 
            this.lblNameSitting.AutoSize = true;
            this.lblNameSitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSitting.Location = new System.Drawing.Point(5, 62);
            this.lblNameSitting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameSitting.Name = "lblNameSitting";
            this.lblNameSitting.Size = new System.Drawing.Size(77, 24);
            this.lblNameSitting.TabIndex = 1;
            this.lblNameSitting.Text = "Name :";
            // 
            // lbltitesitting
            // 
            this.lbltitesitting.AutoSize = true;
            this.lbltitesitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitesitting.Location = new System.Drawing.Point(115, 7);
            this.lbltitesitting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitesitting.Name = "lbltitesitting";
            this.lbltitesitting.Size = new System.Drawing.Size(153, 24);
            this.lbltitesitting.TabIndex = 0;
            this.lbltitesitting.Text = "settings الاعدادات";
            // 
            // btnBGDefault
            // 
            this.btnBGDefault.Location = new System.Drawing.Point(254, 266);
            this.btnBGDefault.Name = "btnBGDefault";
            this.btnBGDefault.Size = new System.Drawing.Size(85, 34);
            this.btnBGDefault.TabIndex = 26;
            this.btnBGDefault.Text = "Default\r\nافتراضي";
            this.btnBGDefault.UseVisualStyleBackColor = true;
            this.btnBGDefault.Click += new System.EventHandler(this.btnBGDefault_Click);
            // 
            // FrmSitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 337);
            this.Controls.Add(this.grpSeting);
            this.Name = "FrmSitting";
            this.Text = "FrmSitting";
            this.Load += new System.EventHandler(this.FrmSitting_Load);
            this.grpSeting.ResumeLayout(false);
            this.pnlSitting.ResumeLayout(false);
            this.pnlSitting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeting;
        private System.Windows.Forms.Panel pnlSitting;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImgBackground;
        private System.Windows.Forms.Button btnColorBackgroud;
        private System.Windows.Forms.Label lblCitySittingAR;
        private System.Windows.Forms.Label lblSittingNameAR;
        private System.Windows.Forms.Label lblCitySitting;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.CheckBox chkShowName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameSitting;
        private System.Windows.Forms.Label lbltitesitting;
        private System.Windows.Forms.ColorDialog cidBackgroud;
        private System.Windows.Forms.Button btnBGDefault;
    }
}