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
    public partial class frmQuran : Form
    {
        public WindowsMediaPlayer playerQuran = new WindowsMediaPlayer();

        public frmQuran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerQuran.URL = "Quran/quranYS.mp3";

            playerQuran.controls.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            playerQuran.controls.stop();
        }

        private void btnAlKhf_Click(object sender, EventArgs e)
        {
            playerQuran.URL = "Quran/quranKhf.mp3";

            playerQuran.controls.play();
        }

        private void btnAiahAlKrsi_Click(object sender, EventArgs e)
        {
            
            playerQuran.URL = "Quran/quranAiahkharsi.mp3";

            playerQuran.controls.play();
        }

        private void btnEclas_Click(object sender, EventArgs e)
        {
            playerQuran.URL = "Quran/quranEclas.mp3";

            playerQuran.controls.play();
        }

        private void btnAlflak_Click(object sender, EventArgs e)
        {
            playerQuran.URL = "Quran/quranFlak.mp3";

            playerQuran.controls.play();
        }

        private void btnِAnas_Click(object sender, EventArgs e)
        {
            playerQuran.URL = "Quran/quranNas.mp3";

            playerQuran.controls.play();
        }
    }
}
