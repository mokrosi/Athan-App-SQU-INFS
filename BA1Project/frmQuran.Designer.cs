namespace BA1Project
{
    partial class frmQuran
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAiahAlKrsi = new System.Windows.Forms.Button();
            this.btnAlKhf = new System.Windows.Forms.Button();
            this.btnEclas = new System.Windows.Forms.Button();
            this.btnAlflak = new System.Windows.Forms.Button();
            this.btnِAnas = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BA1Project.Properties.Resources.HOME_b1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnِAnas);
            this.panel1.Controls.Add(this.btnAlflak);
            this.panel1.Controls.Add(this.btnEclas);
            this.panel1.Controls.Add(this.btnAlKhf);
            this.panel1.Controls.Add(this.btnAiahAlKrsi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 400);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quran Audio Library\r\nمكتبة القران الصوتية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sorah Yasen\r\nسورة يس";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAiahAlKrsi
            // 
            this.btnAiahAlKrsi.Location = new System.Drawing.Point(55, 295);
            this.btnAiahAlKrsi.Name = "btnAiahAlKrsi";
            this.btnAiahAlKrsi.Size = new System.Drawing.Size(105, 34);
            this.btnAiahAlKrsi.TabIndex = 2;
            this.btnAiahAlKrsi.Text = "Aiah Al Krsi\r\nايه الكرسي";
            this.btnAiahAlKrsi.UseVisualStyleBackColor = true;
            this.btnAiahAlKrsi.Click += new System.EventHandler(this.btnAiahAlKrsi_Click);
            // 
            // btnAlKhf
            // 
            this.btnAlKhf.Location = new System.Drawing.Point(55, 246);
            this.btnAlKhf.Name = "btnAlKhf";
            this.btnAlKhf.Size = new System.Drawing.Size(105, 35);
            this.btnAlKhf.TabIndex = 3;
            this.btnAlKhf.Text = "Sorah Al Khaf \r\nسورة الكهف";
            this.btnAlKhf.UseVisualStyleBackColor = true;
            this.btnAlKhf.Click += new System.EventHandler(this.btnAlKhf_Click);
            // 
            // btnEclas
            // 
            this.btnEclas.Location = new System.Drawing.Point(207, 195);
            this.btnEclas.Name = "btnEclas";
            this.btnEclas.Size = new System.Drawing.Size(104, 40);
            this.btnEclas.TabIndex = 4;
            this.btnEclas.Text = "Sorah Al Eklas\r\nسورة الاخلاص";
            this.btnEclas.UseVisualStyleBackColor = true;
            this.btnEclas.Click += new System.EventHandler(this.btnEclas_Click);
            // 
            // btnAlflak
            // 
            this.btnAlflak.Location = new System.Drawing.Point(207, 246);
            this.btnAlflak.Name = "btnAlflak";
            this.btnAlflak.Size = new System.Drawing.Size(104, 35);
            this.btnAlflak.TabIndex = 5;
            this.btnAlflak.Text = "Sorah Al Falak\r\nسورة الفلق";
            this.btnAlflak.UseVisualStyleBackColor = true;
            this.btnAlflak.Click += new System.EventHandler(this.btnAlflak_Click);
            // 
            // btnِAnas
            // 
            this.btnِAnas.Location = new System.Drawing.Point(207, 295);
            this.btnِAnas.Name = "btnِAnas";
            this.btnِAnas.Size = new System.Drawing.Size(104, 34);
            this.btnِAnas.TabIndex = 6;
            this.btnِAnas.Text = "Sorah A Nas\r\nسورة الناس";
            this.btnِAnas.UseVisualStyleBackColor = true;
            this.btnِAnas.Click += new System.EventHandler(this.btnِAnas_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(138, 358);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 28);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop توقف";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmQuran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 397);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuran";
            this.Text = "frmQuran";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnِAnas;
        private System.Windows.Forms.Button btnAlflak;
        private System.Windows.Forms.Button btnEclas;
        private System.Windows.Forms.Button btnAlKhf;
        private System.Windows.Forms.Button btnAiahAlKrsi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
    }
}