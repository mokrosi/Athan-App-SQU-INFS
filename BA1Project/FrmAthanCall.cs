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
    public partial class FrmAthanCall : Form
    {
        public FrmAthanCall()
        {
            InitializeComponent();
        }
        public WindowsMediaPlayer playerAthan = new WindowsMediaPlayer();

        private async void panel1_Paint(object sender, PaintEventArgs e)
        {
            playerAthan.URL = "sound/TimeForAthan.mp3";
            await Task.Delay(7000);
            playerAthan.URL = "sound/AthanOman1.mp3";
            playerAthan.controls.play();
            await Task.Delay(240000);
            Close();

        }
    }
}
