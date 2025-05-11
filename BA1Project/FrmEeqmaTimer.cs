using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BA1Project
{
    public partial class FrmEeqmaTimer : Form
    {
        public FrmEeqmaTimer()
        {
            InitializeComponent();
        }

        public WindowsMediaPlayer playerEeqma = new WindowsMediaPlayer();

        private async void FrmEeqmaTimer_Load(object sender, EventArgs e)
        {

            pnlTimerEqma.Visible = true;
            int countdownSeconds = 60;
            while (countdownSeconds > 0)
            {
                lblTimerEqama.Text = countdownSeconds.ToString("00");
                await Task.Delay(1000);
                countdownSeconds--;

            }

            lblItIsTimeForEqama.Visible = true;
            lblTimerTitel.Visible = false;
            playerEeqma.URL = "sound/TimeForEqama.mp3";
            playerEeqma.controls.play();
            lblTimerEqama.Text = ("00");
            await Task.Delay(10000);
            pnlTimerEqma.Visible = false;
            MainFrm.afterslat();

            Close();




        }

        private void pnlTimerEqma_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
