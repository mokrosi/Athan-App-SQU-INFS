namespace BA1Project
{
    partial class FrmEeqmaTimer
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
            this.pnlTimerEqma = new System.Windows.Forms.Panel();
            this.lblItIsTimeForEqama = new System.Windows.Forms.Label();
            this.lblTimerTitel = new System.Windows.Forms.Label();
            this.lblTimerEqama = new System.Windows.Forms.Label();
            this.pnlTimerEqma.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimerEqma
            // 
            this.pnlTimerEqma.BackgroundImage = global::BA1Project.Properties.Resources.bg_grean;
            this.pnlTimerEqma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimerEqma.Controls.Add(this.lblItIsTimeForEqama);
            this.pnlTimerEqma.Controls.Add(this.lblTimerTitel);
            this.pnlTimerEqma.Controls.Add(this.lblTimerEqama);
            this.pnlTimerEqma.Location = new System.Drawing.Point(1, 1);
            this.pnlTimerEqma.Name = "pnlTimerEqma";
            this.pnlTimerEqma.Size = new System.Drawing.Size(239, 280);
            this.pnlTimerEqma.TabIndex = 18;
            this.pnlTimerEqma.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTimerEqma_Paint);
            // 
            // lblItIsTimeForEqama
            // 
            this.lblItIsTimeForEqama.AutoSize = true;
            this.lblItIsTimeForEqama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItIsTimeForEqama.Location = new System.Drawing.Point(29, 193);
            this.lblItIsTimeForEqama.Name = "lblItIsTimeForEqama";
            this.lblItIsTimeForEqama.Size = new System.Drawing.Size(185, 48);
            this.lblItIsTimeForEqama.TabIndex = 2;
            this.lblItIsTimeForEqama.Text = "The time for Eqama  \r\nحان وقت الاقامة\r\n";
            this.lblItIsTimeForEqama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItIsTimeForEqama.Visible = false;
            // 
            // lblTimerTitel
            // 
            this.lblTimerTitel.AutoSize = true;
            this.lblTimerTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTitel.Location = new System.Drawing.Point(61, 30);
            this.lblTimerTitel.Name = "lblTimerTitel";
            this.lblTimerTitel.Size = new System.Drawing.Size(109, 48);
            this.lblTimerTitel.TabIndex = 1;
            this.lblTimerTitel.Text = "Eqama in\r\nتبقاء عن الاقامة ";
            this.lblTimerTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerEqama
            // 
            this.lblTimerEqama.AutoSize = true;
            this.lblTimerEqama.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerEqama.Location = new System.Drawing.Point(75, 110);
            this.lblTimerEqama.Name = "lblTimerEqama";
            this.lblTimerEqama.Size = new System.Drawing.Size(80, 55);
            this.lblTimerEqama.TabIndex = 0;
            this.lblTimerEqama.Text = "60";
            // 
            // FrmEeqmaTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 281);
            this.Controls.Add(this.pnlTimerEqma);
            this.Name = "FrmEeqmaTimer";
            this.Text = "FrmEeqmaTimer";
            this.Load += new System.EventHandler(this.FrmEeqmaTimer_Load);
            this.pnlTimerEqma.ResumeLayout(false);
            this.pnlTimerEqma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTimerEqma;
        private System.Windows.Forms.Label lblItIsTimeForEqama;
        private System.Windows.Forms.Label lblTimerTitel;
        private System.Windows.Forms.Label lblTimerEqama;
        private System.Windows.Forms.Timer timer1;
    }
}