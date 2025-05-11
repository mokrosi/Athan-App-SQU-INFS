using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BA1Project
{
    public partial class FrmDuas : Form
    {
        public FrmDuas()
        {
            InitializeComponent();
        }

        public WindowsMediaPlayer playerDuas = new WindowsMediaPlayer();
        private void pnlDuas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerDuas.URL = "sound/Dous1.mp3";

            txtDuseAR.Text = File.ReadAllText("Duse/Dase1AR.txt");
            txtDuasEN.Text = File.ReadAllText("Duse/Dase1EN.txt");
            playerDuas.controls.play();
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            playerDuas.URL = "sound/Dous2.mp3";
            txtDuseAR.Text = File.ReadAllText("Duse/Dase2AR.txt");
            txtDuasEN.Text = File.ReadAllText("Duse/Dase2EN.txt");
            playerDuas.controls.play();
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            playerDuas.URL = "sound/Dous3.mp3";
            txtDuseAR.Text = File.ReadAllText("Duse/Dase3AR.txt");
            txtDuasEN.Text = File.ReadAllText("Duse/Dase3EN.txt");
            playerDuas.controls.play();
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            playerDuas.URL = "sound/Dous4.mp3";
            txtDuseAR.Text = File.ReadAllText("Duse/Dase4AR.txt");
            txtDuasEN.Text = File.ReadAllText("Duse/Dase4EN.txt");
            playerDuas.controls.play();
        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            playerDuas.URL = "sound/Dous5.mp3";
            txtDuseAR.Text = File.ReadAllText("Duse/Dase5AR.txt");
            txtDuasEN.Text = File.ReadAllText("Duse/Dase5EN.txt");
            playerDuas.controls.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            playerDuas.controls.stop();
        }

        private void txtDuasEN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
