namespace BA1Project
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cidBackgroud = new System.Windows.Forms.ColorDialog();
            this.oidBackground = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnSitEqama = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnQuran = new System.Windows.Forms.Button();
            this.btnDuas = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.HomePnl = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.pnlTimeToNextEqama = new System.Windows.Forms.Panel();
            this.lblTimeToEqamaNam = new System.Windows.Forms.Label();
            this.lblTimeToEqamaTime = new System.Windows.Forms.Label();
            this.lblNextEqamaTitel = new System.Windows.Forms.Label();
            this.pnlNextPraye = new System.Windows.Forms.Panel();
            this.lblNextPrayeDisplayName = new System.Windows.Forms.Label();
            this.lblNextPrayeDisplayTime = new System.Windows.Forms.Label();
            this.lblNextPraye = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpcluckDayGrp = new System.Windows.Forms.GroupBox();
            this.lblHijriYare = new System.Windows.Forms.Label();
            this.lblHijriMonth = new System.Windows.Forms.Label();
            this.lblHijriDay = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.grpHome = new System.Windows.Forms.GroupBox();
            this.lblMagAR = new System.Windows.Forms.Label();
            this.lblFAR = new System.Windows.Forms.Label();
            this.lblAsAR = new System.Windows.Forms.Label();
            this.lblAlSAR = new System.Windows.Forms.Label();
            this.lblAldhaAR = new System.Windows.Forms.Label();
            this.lblAldharAR = new System.Windows.Forms.Label();
            this.lblIsaAR = new System.Windows.Forms.Label();
            this.lblIshaEqama = new System.Windows.Forms.Label();
            this.lblIshaAthan = new System.Windows.Forms.Label();
            this.lblMaghribEqama = new System.Windows.Forms.Label();
            this.lblMaghribAthan = new System.Windows.Forms.Label();
            this.lblAsrEqama = new System.Windows.Forms.Label();
            this.lblAsrAthan = new System.Windows.Forms.Label();
            this.lblDhuhrEqama = new System.Windows.Forms.Label();
            this.lblDuhrAthan = new System.Windows.Forms.Label();
            this.lblDuhaAthan = new System.Windows.Forms.Label();
            this.lblShuruqAthan = new System.Windows.Forms.Label();
            this.lblFajrEqama = new System.Windows.Forms.Label();
            this.lblFajrAthan = new System.Windows.Forms.Label();
            this.lblEqama = new System.Windows.Forms.Label();
            this.lblMaghrib = new System.Windows.Forms.Label();
            this.lblFajr = new System.Windows.Forms.Label();
            this.lblAsr = new System.Windows.Forms.Label();
            this.lblShuruq = new System.Windows.Forms.Label();
            this.lblDhuha = new System.Windows.Forms.Label();
            this.lblDhuhr = new System.Windows.Forms.Label();
            this.lblIsha = new System.Windows.Forms.Label();
            this.lblAthan = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            this.HomePnl.SuspendLayout();
            this.pnlTimeToNextEqama.SuspendLayout();
            this.pnlNextPraye.SuspendLayout();
            this.grpcluckDayGrp.SuspendLayout();
            this.grpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // oidBackground
            // 
            this.oidBackground.FileName = "oidBackground";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnlControl
            // 
            this.pnlControl.BackgroundImage = global::BA1Project.Properties.Resources.login_bg_1;
            this.pnlControl.Controls.Add(this.btnInfo);
            this.pnlControl.Controls.Add(this.btnEvent);
            this.pnlControl.Controls.Add(this.btnSitEqama);
            this.pnlControl.Controls.Add(this.btnSetting);
            this.pnlControl.Controls.Add(this.lblTitel);
            this.pnlControl.Controls.Add(this.btnQuran);
            this.pnlControl.Controls.Add(this.btnDuas);
            this.pnlControl.Controls.Add(this.btnMedia);
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(160, 468);
            this.pnlControl.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInfo.BackgroundImage = global::BA1Project.Properties.Resources.icons8_help_20;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(43, 422);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(26, 28);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.SlateGray;
            this.btnEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ForeColor = System.Drawing.Color.White;
            this.btnEvent.Image = global::BA1Project.Properties.Resources.icons8_compass_30;
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.Location = new System.Drawing.Point(12, 310);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(141, 46);
            this.btnEvent.TabIndex = 19;
            this.btnEvent.Text = "Event\r\nعدث";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSitEqama
            // 
            this.btnSitEqama.BackColor = System.Drawing.Color.SlateGray;
            this.btnSitEqama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSitEqama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSitEqama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSitEqama.ForeColor = System.Drawing.Color.White;
            this.btnSitEqama.Image = global::BA1Project.Properties.Resources.icons8_delivery_time_30;
            this.btnSitEqama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSitEqama.Location = new System.Drawing.Point(13, 258);
            this.btnSitEqama.Name = "btnSitEqama";
            this.btnSitEqama.Size = new System.Drawing.Size(141, 46);
            this.btnSitEqama.TabIndex = 18;
            this.btnSitEqama.Text = "Sit Eqama time\r\n ظبط وقت الاقامة";
            this.btnSitEqama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSitEqama.UseVisualStyleBackColor = false;
            this.btnSitEqama.Click += new System.EventHandler(this.btnSitEqama_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetting.BackgroundImage = global::BA1Project.Properties.Resources.icons8_setting_30;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Location = new System.Drawing.Point(11, 421);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(26, 28);
            this.btnSetting.TabIndex = 17;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblTitel.AutoSize = true;
            this.lblTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.White;
            this.lblTitel.Location = new System.Drawing.Point(12, 8);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(113, 22);
            this.lblTitel.TabIndex = 16;
            this.lblTitel.Text = "Athan Clock";
            // 
            // btnQuran
            // 
            this.btnQuran.BackColor = System.Drawing.Color.SlateGray;
            this.btnQuran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuran.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuran.ForeColor = System.Drawing.Color.White;
            this.btnQuran.Image = global::BA1Project.Properties.Resources.icons8_quran_30;
            this.btnQuran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuran.Location = new System.Drawing.Point(13, 206);
            this.btnQuran.Name = "btnQuran";
            this.btnQuran.Size = new System.Drawing.Size(141, 46);
            this.btnQuran.TabIndex = 15;
            this.btnQuran.Text = "Quran";
            this.btnQuran.UseVisualStyleBackColor = false;
            this.btnQuran.Click += new System.EventHandler(this.btnQuran_Click);
            // 
            // btnDuas
            // 
            this.btnDuas.BackColor = System.Drawing.Color.SlateGray;
            this.btnDuas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDuas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuas.ForeColor = System.Drawing.Color.White;
            this.btnDuas.Image = global::BA1Project.Properties.Resources.icons8_prayer_30;
            this.btnDuas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuas.Location = new System.Drawing.Point(13, 154);
            this.btnDuas.Name = "btnDuas";
            this.btnDuas.Size = new System.Drawing.Size(141, 46);
            this.btnDuas.TabIndex = 6;
            this.btnDuas.Text = "Duas\r\nدعاء";
            this.btnDuas.UseVisualStyleBackColor = false;
            this.btnDuas.Click += new System.EventHandler(this.btnDuas_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.SlateGray;
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.White;
            this.btnMedia.Image = global::BA1Project.Properties.Resources.tvicon_Photoroom;
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(13, 102);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(141, 46);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "video Libery\r\nمكتبة الفديوهات";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // HomePnl
            // 
            this.HomePnl.BackgroundImage = global::BA1Project.Properties.Resources.HOME_b;
            this.HomePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePnl.Controls.Add(this.lblEvent);
            this.HomePnl.Controls.Add(this.pnlTimeToNextEqama);
            this.HomePnl.Controls.Add(this.pnlNextPraye);
            this.HomePnl.Controls.Add(this.lblName);
            this.HomePnl.Controls.Add(this.grpcluckDayGrp);
            this.HomePnl.Controls.Add(this.grpHome);
            this.HomePnl.Location = new System.Drawing.Point(135, -2);
            this.HomePnl.Name = "HomePnl";
            this.HomePnl.Size = new System.Drawing.Size(626, 470);
            this.HomePnl.TabIndex = 1;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.BackColor = System.Drawing.Color.White;
            this.lblEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEvent.Location = new System.Drawing.Point(169, 0);
            this.lblEvent.MaximumSize = new System.Drawing.Size(308, 87);
            this.lblEvent.MinimumSize = new System.Drawing.Size(308, 87);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(308, 87);
            this.lblEvent.TabIndex = 0;
            this.lblEvent.Text = "event";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEvent.Visible = false;
            // 
            // pnlTimeToNextEqama
            // 
            this.pnlTimeToNextEqama.BackColor = System.Drawing.Color.White;
            this.pnlTimeToNextEqama.Controls.Add(this.lblTimeToEqamaNam);
            this.pnlTimeToNextEqama.Controls.Add(this.lblTimeToEqamaTime);
            this.pnlTimeToNextEqama.Controls.Add(this.lblNextEqamaTitel);
            this.pnlTimeToNextEqama.Location = new System.Drawing.Point(33, 93);
            this.pnlTimeToNextEqama.Name = "pnlTimeToNextEqama";
            this.pnlTimeToNextEqama.Size = new System.Drawing.Size(130, 97);
            this.pnlTimeToNextEqama.TabIndex = 21;
            // 
            // lblTimeToEqamaNam
            // 
            this.lblTimeToEqamaNam.AutoSize = true;
            this.lblTimeToEqamaNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeToEqamaNam.Location = new System.Drawing.Point(45, 45);
            this.lblTimeToEqamaNam.Name = "lblTimeToEqamaNam";
            this.lblTimeToEqamaNam.Size = new System.Drawing.Size(27, 13);
            this.lblTimeToEqamaNam.TabIndex = 2;
            this.lblTimeToEqamaNam.Text = "pray";
            this.lblTimeToEqamaNam.Click += new System.EventHandler(this.lblTimeToEqamaNam_Click);
            // 
            // lblTimeToEqamaTime
            // 
            this.lblTimeToEqamaTime.AutoSize = true;
            this.lblTimeToEqamaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeToEqamaTime.Location = new System.Drawing.Point(45, 70);
            this.lblTimeToEqamaTime.Name = "lblTimeToEqamaTime";
            this.lblTimeToEqamaTime.Size = new System.Drawing.Size(38, 16);
            this.lblTimeToEqamaTime.TabIndex = 1;
            this.lblTimeToEqamaTime.Text = "00:00";
            // 
            // lblNextEqamaTitel
            // 
            this.lblNextEqamaTitel.AutoSize = true;
            this.lblNextEqamaTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextEqamaTitel.Location = new System.Drawing.Point(3, 6);
            this.lblNextEqamaTitel.Name = "lblNextEqamaTitel";
            this.lblNextEqamaTitel.Size = new System.Drawing.Size(132, 32);
            this.lblNextEqamaTitel.TabIndex = 0;
            this.lblNextEqamaTitel.Text = "Time to Next Eqama \r\nالمتبقي عن الاقامة التالية";
            // 
            // pnlNextPraye
            // 
            this.pnlNextPraye.BackColor = System.Drawing.Color.White;
            this.pnlNextPraye.Controls.Add(this.lblNextPrayeDisplayName);
            this.pnlNextPraye.Controls.Add(this.lblNextPrayeDisplayTime);
            this.pnlNextPraye.Controls.Add(this.lblNextPraye);
            this.pnlNextPraye.Location = new System.Drawing.Point(486, 94);
            this.pnlNextPraye.Name = "pnlNextPraye";
            this.pnlNextPraye.Size = new System.Drawing.Size(130, 97);
            this.pnlNextPraye.TabIndex = 20;
            // 
            // lblNextPrayeDisplayName
            // 
            this.lblNextPrayeDisplayName.AutoSize = true;
            this.lblNextPrayeDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPrayeDisplayName.Location = new System.Drawing.Point(46, 44);
            this.lblNextPrayeDisplayName.Name = "lblNextPrayeDisplayName";
            this.lblNextPrayeDisplayName.Size = new System.Drawing.Size(27, 13);
            this.lblNextPrayeDisplayName.TabIndex = 2;
            this.lblNextPrayeDisplayName.Text = "pray";
            // 
            // lblNextPrayeDisplayTime
            // 
            this.lblNextPrayeDisplayTime.AutoSize = true;
            this.lblNextPrayeDisplayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPrayeDisplayTime.Location = new System.Drawing.Point(46, 70);
            this.lblNextPrayeDisplayTime.Name = "lblNextPrayeDisplayTime";
            this.lblNextPrayeDisplayTime.Size = new System.Drawing.Size(38, 16);
            this.lblNextPrayeDisplayTime.TabIndex = 1;
            this.lblNextPrayeDisplayTime.Text = "00:00";
            // 
            // lblNextPraye
            // 
            this.lblNextPraye.AutoSize = true;
            this.lblNextPraye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPraye.Location = new System.Drawing.Point(3, 6);
            this.lblNextPraye.Name = "lblNextPraye";
            this.lblNextPraye.Size = new System.Drawing.Size(124, 32);
            this.lblNextPraye.TabIndex = 0;
            this.lblNextPraye.Text = "Time to Next Praye \r\nالمتبقي عن الصلاه التالية";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(46, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 24);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Mosque";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // grpcluckDayGrp
            // 
            this.grpcluckDayGrp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpcluckDayGrp.Controls.Add(this.lblHijriYare);
            this.grpcluckDayGrp.Controls.Add(this.lblHijriMonth);
            this.grpcluckDayGrp.Controls.Add(this.lblHijriDay);
            this.grpcluckDayGrp.Controls.Add(this.lblDay);
            this.grpcluckDayGrp.Controls.Add(this.lblDate);
            this.grpcluckDayGrp.Controls.Add(this.lblClock);
            this.grpcluckDayGrp.Location = new System.Drawing.Point(169, 63);
            this.grpcluckDayGrp.Name = "grpcluckDayGrp";
            this.grpcluckDayGrp.Size = new System.Drawing.Size(308, 126);
            this.grpcluckDayGrp.TabIndex = 16;
            this.grpcluckDayGrp.TabStop = false;
            // 
            // lblHijriYare
            // 
            this.lblHijriYare.AutoSize = true;
            this.lblHijriYare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHijriYare.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijriYare.Location = new System.Drawing.Point(41, 29);
            this.lblHijriYare.Name = "lblHijriYare";
            this.lblHijriYare.Size = new System.Drawing.Size(113, 24);
            this.lblHijriYare.TabIndex = 10;
            this.lblHijriYare.Text = "lblHijriYare";
            // 
            // lblHijriMonth
            // 
            this.lblHijriMonth.AutoSize = true;
            this.lblHijriMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHijriMonth.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijriMonth.Location = new System.Drawing.Point(106, 29);
            this.lblHijriMonth.Name = "lblHijriMonth";
            this.lblHijriMonth.Size = new System.Drawing.Size(130, 24);
            this.lblHijriMonth.TabIndex = 9;
            this.lblHijriMonth.Text = "lblHijriMonth";
            // 
            // lblHijriDay
            // 
            this.lblHijriDay.AutoSize = true;
            this.lblHijriDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHijriDay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijriDay.Location = new System.Drawing.Point(182, 29);
            this.lblHijriDay.Name = "lblHijriDay";
            this.lblHijriDay.Size = new System.Drawing.Size(107, 24);
            this.lblHijriDay.TabIndex = 8;
            this.lblHijriDay.Text = "lblHijriDay";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(170, 52);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(67, 24);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "lblDay";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(37, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            // 
            // lblClock
            // 
            this.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClock.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(56, 86);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(163, 24);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "lblClock";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpHome
            // 
            this.grpHome.BackColor = System.Drawing.Color.White;
            this.grpHome.Controls.Add(this.lblMagAR);
            this.grpHome.Controls.Add(this.lblFAR);
            this.grpHome.Controls.Add(this.lblAsAR);
            this.grpHome.Controls.Add(this.lblAlSAR);
            this.grpHome.Controls.Add(this.lblAldhaAR);
            this.grpHome.Controls.Add(this.lblAldharAR);
            this.grpHome.Controls.Add(this.lblIsaAR);
            this.grpHome.Controls.Add(this.lblIshaEqama);
            this.grpHome.Controls.Add(this.lblIshaAthan);
            this.grpHome.Controls.Add(this.lblMaghribEqama);
            this.grpHome.Controls.Add(this.lblMaghribAthan);
            this.grpHome.Controls.Add(this.lblAsrEqama);
            this.grpHome.Controls.Add(this.lblAsrAthan);
            this.grpHome.Controls.Add(this.lblDhuhrEqama);
            this.grpHome.Controls.Add(this.lblDuhrAthan);
            this.grpHome.Controls.Add(this.lblDuhaAthan);
            this.grpHome.Controls.Add(this.lblShuruqAthan);
            this.grpHome.Controls.Add(this.lblFajrEqama);
            this.grpHome.Controls.Add(this.lblFajrAthan);
            this.grpHome.Controls.Add(this.lblEqama);
            this.grpHome.Controls.Add(this.lblMaghrib);
            this.grpHome.Controls.Add(this.lblFajr);
            this.grpHome.Controls.Add(this.lblAsr);
            this.grpHome.Controls.Add(this.lblShuruq);
            this.grpHome.Controls.Add(this.lblDhuha);
            this.grpHome.Controls.Add(this.lblDhuhr);
            this.grpHome.Controls.Add(this.lblIsha);
            this.grpHome.Controls.Add(this.lblAthan);
            this.grpHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpHome.Location = new System.Drawing.Point(89, 196);
            this.grpHome.Margin = new System.Windows.Forms.Padding(2);
            this.grpHome.Name = "grpHome";
            this.grpHome.Padding = new System.Windows.Forms.Padding(2);
            this.grpHome.Size = new System.Drawing.Size(454, 272);
            this.grpHome.TabIndex = 8;
            this.grpHome.TabStop = false;
            // 
            // lblMagAR
            // 
            this.lblMagAR.AutoSize = true;
            this.lblMagAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMagAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagAR.Location = new System.Drawing.Point(374, 119);
            this.lblMagAR.Name = "lblMagAR";
            this.lblMagAR.Size = new System.Drawing.Size(53, 22);
            this.lblMagAR.TabIndex = 27;
            this.lblMagAR.Text = "المغرب";
            // 
            // lblFAR
            // 
            this.lblFAR.AutoSize = true;
            this.lblFAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFAR.Location = new System.Drawing.Point(385, 30);
            this.lblFAR.Name = "lblFAR";
            this.lblFAR.Size = new System.Drawing.Size(42, 22);
            this.lblFAR.TabIndex = 21;
            this.lblFAR.Text = "الفجر";
            this.lblFAR.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAsAR
            // 
            this.lblAsAR.AutoSize = true;
            this.lblAsAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAsAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsAR.Location = new System.Drawing.Point(379, 87);
            this.lblAsAR.Name = "lblAsAR";
            this.lblAsAR.Size = new System.Drawing.Size(48, 22);
            this.lblAsAR.TabIndex = 22;
            this.lblAsAR.Text = "العصر";
            // 
            // lblAlSAR
            // 
            this.lblAlSAR.AutoSize = true;
            this.lblAlSAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlSAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlSAR.Location = new System.Drawing.Point(168, 189);
            this.lblAlSAR.Name = "lblAlSAR";
            this.lblAlSAR.Size = new System.Drawing.Size(59, 22);
            this.lblAlSAR.TabIndex = 23;
            this.lblAlSAR.Text = "الشروق";
            // 
            // lblAldhaAR
            // 
            this.lblAldhaAR.AutoSize = true;
            this.lblAldhaAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAldhaAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAldhaAR.Location = new System.Drawing.Point(309, 185);
            this.lblAldhaAR.Name = "lblAldhaAR";
            this.lblAldhaAR.Size = new System.Drawing.Size(54, 22);
            this.lblAldhaAR.TabIndex = 24;
            this.lblAldhaAR.Text = "الضحى";
            // 
            // lblAldharAR
            // 
            this.lblAldharAR.AutoSize = true;
            this.lblAldharAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAldharAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAldharAR.Location = new System.Drawing.Point(382, 53);
            this.lblAldharAR.Name = "lblAldharAR";
            this.lblAldharAR.Size = new System.Drawing.Size(45, 22);
            this.lblAldharAR.TabIndex = 25;
            this.lblAldharAR.Text = "الظهر";
            // 
            // lblIsaAR
            // 
            this.lblIsaAR.AutoSize = true;
            this.lblIsaAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIsaAR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsaAR.Location = new System.Drawing.Point(377, 152);
            this.lblIsaAR.Name = "lblIsaAR";
            this.lblIsaAR.Size = new System.Drawing.Size(50, 22);
            this.lblIsaAR.TabIndex = 26;
            this.lblIsaAR.Text = "العشاء";
            // 
            // lblIshaEqama
            // 
            this.lblIshaEqama.AutoSize = true;
            this.lblIshaEqama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIshaEqama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIshaEqama.Location = new System.Drawing.Point(271, 152);
            this.lblIshaEqama.Name = "lblIshaEqama";
            this.lblIshaEqama.Size = new System.Drawing.Size(45, 22);
            this.lblIshaEqama.TabIndex = 20;
            this.lblIshaEqama.Text = "Isha";
            // 
            // lblIshaAthan
            // 
            this.lblIshaAthan.AutoSize = true;
            this.lblIshaAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIshaAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIshaAthan.Location = new System.Drawing.Point(146, 152);
            this.lblIshaAthan.Name = "lblIshaAthan";
            this.lblIshaAthan.Size = new System.Drawing.Size(45, 22);
            this.lblIshaAthan.TabIndex = 19;
            this.lblIshaAthan.Text = "Isha";
            // 
            // lblMaghribEqama
            // 
            this.lblMaghribEqama.AutoSize = true;
            this.lblMaghribEqama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaghribEqama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaghribEqama.Location = new System.Drawing.Point(271, 119);
            this.lblMaghribEqama.Name = "lblMaghribEqama";
            this.lblMaghribEqama.Size = new System.Drawing.Size(81, 22);
            this.lblMaghribEqama.TabIndex = 18;
            this.lblMaghribEqama.Text = "Maghrib";
            // 
            // lblMaghribAthan
            // 
            this.lblMaghribAthan.AutoSize = true;
            this.lblMaghribAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaghribAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaghribAthan.Location = new System.Drawing.Point(146, 119);
            this.lblMaghribAthan.Name = "lblMaghribAthan";
            this.lblMaghribAthan.Size = new System.Drawing.Size(81, 22);
            this.lblMaghribAthan.TabIndex = 17;
            this.lblMaghribAthan.Text = "Maghrib";
            // 
            // lblAsrEqama
            // 
            this.lblAsrEqama.AutoSize = true;
            this.lblAsrEqama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAsrEqama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsrEqama.Location = new System.Drawing.Point(271, 85);
            this.lblAsrEqama.Name = "lblAsrEqama";
            this.lblAsrEqama.Size = new System.Drawing.Size(39, 22);
            this.lblAsrEqama.TabIndex = 16;
            this.lblAsrEqama.Text = "Asr";
            // 
            // lblAsrAthan
            // 
            this.lblAsrAthan.AutoSize = true;
            this.lblAsrAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAsrAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsrAthan.Location = new System.Drawing.Point(146, 87);
            this.lblAsrAthan.Name = "lblAsrAthan";
            this.lblAsrAthan.Size = new System.Drawing.Size(39, 22);
            this.lblAsrAthan.TabIndex = 15;
            this.lblAsrAthan.Text = "Asr";
            // 
            // lblDhuhrEqama
            // 
            this.lblDhuhrEqama.AutoSize = true;
            this.lblDhuhrEqama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDhuhrEqama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDhuhrEqama.Location = new System.Drawing.Point(272, 53);
            this.lblDhuhrEqama.Name = "lblDhuhrEqama";
            this.lblDhuhrEqama.Size = new System.Drawing.Size(62, 22);
            this.lblDhuhrEqama.TabIndex = 14;
            this.lblDhuhrEqama.Text = "Dhuhr";
            // 
            // lblDuhrAthan
            // 
            this.lblDuhrAthan.AutoSize = true;
            this.lblDuhrAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuhrAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuhrAthan.Location = new System.Drawing.Point(146, 53);
            this.lblDuhrAthan.Name = "lblDuhrAthan";
            this.lblDuhrAthan.Size = new System.Drawing.Size(62, 22);
            this.lblDuhrAthan.TabIndex = 13;
            this.lblDuhrAthan.Text = "Dhuhr";
            // 
            // lblDuhaAthan
            // 
            this.lblDuhaAthan.AutoSize = true;
            this.lblDuhaAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuhaAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuhaAthan.Location = new System.Drawing.Point(270, 212);
            this.lblDuhaAthan.Name = "lblDuhaAthan";
            this.lblDuhaAthan.Size = new System.Drawing.Size(64, 22);
            this.lblDuhaAthan.TabIndex = 11;
            this.lblDuhaAthan.Text = "Dhuha";
            // 
            // lblShuruqAthan
            // 
            this.lblShuruqAthan.AutoSize = true;
            this.lblShuruqAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShuruqAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShuruqAthan.Location = new System.Drawing.Point(136, 212);
            this.lblShuruqAthan.Name = "lblShuruqAthan";
            this.lblShuruqAthan.Size = new System.Drawing.Size(69, 22);
            this.lblShuruqAthan.TabIndex = 9;
            this.lblShuruqAthan.Text = "Shuruq";
            // 
            // lblFajrEqama
            // 
            this.lblFajrEqama.AutoSize = true;
            this.lblFajrEqama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFajrEqama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFajrEqama.Location = new System.Drawing.Point(271, 26);
            this.lblFajrEqama.Name = "lblFajrEqama";
            this.lblFajrEqama.Size = new System.Drawing.Size(46, 22);
            this.lblFajrEqama.TabIndex = 8;
            this.lblFajrEqama.Text = "Fajr";
            this.lblFajrEqama.Click += new System.EventHandler(this.lblFajrEqama_Click);
            // 
            // lblFajrAthan
            // 
            this.lblFajrAthan.AutoSize = true;
            this.lblFajrAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFajrAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFajrAthan.Location = new System.Drawing.Point(146, 26);
            this.lblFajrAthan.Name = "lblFajrAthan";
            this.lblFajrAthan.Size = new System.Drawing.Size(46, 22);
            this.lblFajrAthan.TabIndex = 7;
            this.lblFajrAthan.Text = "Fajr";
            // 
            // lblEqama
            // 
            this.lblEqama.AutoSize = true;
            this.lblEqama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEqama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqama.Location = new System.Drawing.Point(259, 3);
            this.lblEqama.Name = "lblEqama";
            this.lblEqama.Size = new System.Drawing.Size(112, 22);
            this.lblEqama.TabIndex = 6;
            this.lblEqama.Text = "Eqama الاقامة";
            // 
            // lblMaghrib
            // 
            this.lblMaghrib.AutoSize = true;
            this.lblMaghrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaghrib.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaghrib.Location = new System.Drawing.Point(9, 119);
            this.lblMaghrib.Name = "lblMaghrib";
            this.lblMaghrib.Size = new System.Drawing.Size(81, 22);
            this.lblMaghrib.TabIndex = 4;
            this.lblMaghrib.Text = "Maghrib";
            // 
            // lblFajr
            // 
            this.lblFajr.AutoSize = true;
            this.lblFajr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFajr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFajr.Location = new System.Drawing.Point(45, 26);
            this.lblFajr.Name = "lblFajr";
            this.lblFajr.Size = new System.Drawing.Size(46, 22);
            this.lblFajr.TabIndex = 0;
            this.lblFajr.Text = "Fajr";
            // 
            // lblAsr
            // 
            this.lblAsr.AutoSize = true;
            this.lblAsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAsr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsr.Location = new System.Drawing.Point(53, 87);
            this.lblAsr.Name = "lblAsr";
            this.lblAsr.Size = new System.Drawing.Size(39, 22);
            this.lblAsr.TabIndex = 1;
            this.lblAsr.Text = "Asr";
            // 
            // lblShuruq
            // 
            this.lblShuruq.AutoSize = true;
            this.lblShuruq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShuruq.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShuruq.Location = new System.Drawing.Point(103, 185);
            this.lblShuruq.Name = "lblShuruq";
            this.lblShuruq.Size = new System.Drawing.Size(69, 22);
            this.lblShuruq.TabIndex = 1;
            this.lblShuruq.Text = "Shuruq";
            // 
            // lblDhuha
            // 
            this.lblDhuha.AutoSize = true;
            this.lblDhuha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDhuha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDhuha.Location = new System.Drawing.Point(246, 186);
            this.lblDhuha.Name = "lblDhuha";
            this.lblDhuha.Size = new System.Drawing.Size(64, 22);
            this.lblDhuha.TabIndex = 2;
            this.lblDhuha.Text = "Dhuha";
            // 
            // lblDhuhr
            // 
            this.lblDhuhr.AutoSize = true;
            this.lblDhuhr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDhuhr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDhuhr.Location = new System.Drawing.Point(28, 53);
            this.lblDhuhr.Name = "lblDhuhr";
            this.lblDhuhr.Size = new System.Drawing.Size(62, 22);
            this.lblDhuhr.TabIndex = 2;
            this.lblDhuhr.Text = "Dhuhr";
            // 
            // lblIsha
            // 
            this.lblIsha.AutoSize = true;
            this.lblIsha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIsha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsha.Location = new System.Drawing.Point(48, 152);
            this.lblIsha.Name = "lblIsha";
            this.lblIsha.Size = new System.Drawing.Size(45, 22);
            this.lblIsha.TabIndex = 3;
            this.lblIsha.Text = "Isha";
            // 
            // lblAthan
            // 
            this.lblAthan.AutoSize = true;
            this.lblAthan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAthan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAthan.Location = new System.Drawing.Point(136, 3);
            this.lblAthan.Name = "lblAthan";
            this.lblAthan.Size = new System.Drawing.Size(98, 22);
            this.lblAthan.TabIndex = 5;
            this.lblAthan.Text = "Athan الاذان";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 468);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.HomePnl);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.HomePnl.ResumeLayout(false);
            this.HomePnl.PerformLayout();
            this.pnlTimeToNextEqama.ResumeLayout(false);
            this.pnlTimeToNextEqama.PerformLayout();
            this.pnlNextPraye.ResumeLayout(false);
            this.pnlNextPraye.PerformLayout();
            this.grpcluckDayGrp.ResumeLayout(false);
            this.grpcluckDayGrp.PerformLayout();
            this.grpHome.ResumeLayout(false);
            this.grpHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnDuas;
        private System.Windows.Forms.Button btnQuran;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblEqama;
        private System.Windows.Forms.Label lblMaghrib;
        private System.Windows.Forms.Label lblFajr;
        private System.Windows.Forms.Label lblAsr;
        private System.Windows.Forms.Label lblShuruq;
        private System.Windows.Forms.Label lblDhuha;
        private System.Windows.Forms.Label lblDhuhr;
        private System.Windows.Forms.Label lblIsha;
        private System.Windows.Forms.Label lblAthan;
        private System.Windows.Forms.Label lblHijriYare;
        private System.Windows.Forms.Label lblHijriMonth;
        private System.Windows.Forms.Label lblHijriDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDhuhrEqama;
        private System.Windows.Forms.Label lblDuhrAthan;
        private System.Windows.Forms.Label lblDuhaAthan;
        private System.Windows.Forms.Label lblShuruqAthan;
        private System.Windows.Forms.Label lblFajrEqama;
        private System.Windows.Forms.Label lblFajrAthan;
        private System.Windows.Forms.Label lblIshaEqama;
        private System.Windows.Forms.Label lblIshaAthan;
        private System.Windows.Forms.Label lblMaghribEqama;
        private System.Windows.Forms.Label lblMaghribAthan;
        private System.Windows.Forms.Label lblAsrEqama;
        private System.Windows.Forms.Label lblAsrAthan;
        private System.Windows.Forms.Label lblMagAR;
        private System.Windows.Forms.Label lblFAR;
        private System.Windows.Forms.Label lblAsAR;
        private System.Windows.Forms.Label lblAlSAR;
        private System.Windows.Forms.Label lblAldhaAR;
        private System.Windows.Forms.Label lblAldharAR;
        private System.Windows.Forms.Label lblIsaAR;
        private System.Windows.Forms.ColorDialog cidBackgroud;
        private System.Windows.Forms.OpenFileDialog oidBackground;
        public System.Windows.Forms.Panel HomePnl;
        private System.Windows.Forms.Button btnSitEqama;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.GroupBox grpHome;
        public System.Windows.Forms.GroupBox grpcluckDayGrp;
        private System.Windows.Forms.Panel pnlNextPraye;
        private System.Windows.Forms.Label lblNextPrayeDisplayName;
        private System.Windows.Forms.Label lblNextPrayeDisplayTime;
        private System.Windows.Forms.Label lblNextPraye;
        private System.Windows.Forms.Panel pnlTimeToNextEqama;
        private System.Windows.Forms.Label lblTimeToEqamaNam;
        private System.Windows.Forms.Label lblTimeToEqamaTime;
        private System.Windows.Forms.Label lblNextEqamaTitel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnEvent;
        public System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Button btnInfo;
    }
}