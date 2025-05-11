namespace BA1Project
{
    partial class FrmAthanCall
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
            this.lblAiah = new System.Windows.Forms.Panel();
            this.lblAthanTimeNow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAiah.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAiah
            // 
            this.lblAiah.BackgroundImage = global::BA1Project.Properties.Resources.bg_grean;
            this.lblAiah.Controls.Add(this.label1);
            this.lblAiah.Controls.Add(this.lblAthanTimeNow);
            this.lblAiah.Location = new System.Drawing.Point(-1, 1);
            this.lblAiah.Name = "lblAiah";
            this.lblAiah.Padding = new System.Windows.Forms.Padding(2);
            this.lblAiah.Size = new System.Drawing.Size(317, 354);
            this.lblAiah.TabIndex = 0;
            this.lblAiah.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAthanTimeNow
            // 
            this.lblAthanTimeNow.AutoSize = true;
            this.lblAthanTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAthanTimeNow.Location = new System.Drawing.Point(36, 70);
            this.lblAthanTimeNow.Name = "lblAthanTimeNow";
            this.lblAthanTimeNow.Size = new System.Drawing.Size(250, 62);
            this.lblAthanTimeNow.TabIndex = 0;
            this.lblAthanTimeNow.Text = "it is time for Athan\r\nحان وقت الاذان\r\n";
            this.lblAthanTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "إِنَّ الصَّلَاةَ كَانَتْ عَلَى الْمُؤْمِنِينَ كِتَابًا مَوْقُوتًا﴾ \r\n[النساء: 103" +
    "]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAthanCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 352);
            this.Controls.Add(this.lblAiah);
            this.Name = "FrmAthanCall";
            this.Text = "FrmAthanCall";
            this.lblAiah.ResumeLayout(false);
            this.lblAiah.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblAiah;
        private System.Windows.Forms.Label lblAthanTimeNow;
        private System.Windows.Forms.Label label1;
    }
}