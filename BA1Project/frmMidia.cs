using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA1Project
{
    public partial class frmMidia : Form
    {
        public frmMidia()
        {
            InitializeComponent();
        }

        private void webTV_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        public void PlayYouTubeVideo(string videoId)
        {
            string embedUrl = $"https://www.youtube.com/embed/{videoId}?autoplay=1&controls=1";

            string html = $@"
        <html>
        <head>
            <meta http-equiv='X-UA-Compatible' content='IE=Edge'/>
        </head>
        <body style='margin:0px;padding:0px;overflow:hidden'>
            <iframe width='100%' height='100%' 
                    src='{embedUrl}' 
                    frameborder='0' 
                    allow='autoplay; encrypted-media' 
                    allowfullscreen>
            </iframe>
        </body>
        </html>";

            webTV.DocumentText = html;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string videoId = "tIm46KbdXtA";
            PlayYouTubeVideo(videoId);
        }

        private void btnSal2_Click(object sender, EventArgs e)
        {

            string videoId = "qe5f45yML00";
            PlayYouTubeVideo(videoId);
        }

        private void btnSal3_Click(object sender, EventArgs e)
        {
            string videoId = "Zoju8IQ9E4U";
            PlayYouTubeVideo(videoId);
        }

        private void btnSal4_Click(object sender, EventArgs e)
        {
            string videoId = "J_z8hCzS2PQ";
            PlayYouTubeVideo(videoId);
        }

        private void btnSal5_Click(object sender, EventArgs e)
        {
            string videoId = "5yG9RHxkyVs";
            PlayYouTubeVideo(videoId);
        }

        private void btnSal6_Click(object sender, EventArgs e)
        {
            string videoId = "exy70Pu2c7c";
            PlayYouTubeVideo(videoId);
        }

        private void btnStory1_Click(object sender, EventArgs e)
        {
            string videoId = "UTXkgTcIdkk";
            PlayYouTubeVideo(videoId);

        }

        private void btnStory2_Click(object sender, EventArgs e)
        {
            string videoId = "RkiD_W5ffhU";
            PlayYouTubeVideo(videoId);

        }

        private void btnStory3_Click(object sender, EventArgs e)
        {
            string videoId = "oCXIK4ZF3Mc";
            PlayYouTubeVideo(videoId);
        }

        private void btnStory4_Click(object sender, EventArgs e)
        {
            string videoId = "ZBYdoe5fNa4";
            PlayYouTubeVideo(videoId);
        }

        private void btnStory5_Click(object sender, EventArgs e)
        {

            string videoId = "MntX9clYGp4";
            PlayYouTubeVideo(videoId);
        }

        private void btnStory6_Click(object sender, EventArgs e)
        {

            string videoId = "D2DWo8iVJC0";
            PlayYouTubeVideo(videoId);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string videoId = "z9VlkgVyLhg";
            PlayYouTubeVideo(videoId);
        }

        private void btnSera2_Click(object sender, EventArgs e)
        {
            string videoId = "Cut8UA4dSS4";
            PlayYouTubeVideo(videoId);
        }

        private void btnSera3_Click(object sender, EventArgs e)
        {

            string videoId = "7CbP4SczIpE";
            PlayYouTubeVideo(videoId);
        }

        private void btnSera4_Click(object sender, EventArgs e)
        {
            string videoId = "QqeNhIBv2IE";
            PlayYouTubeVideo(videoId);
        }

        private void btnSera5_Click(object sender, EventArgs e)
        {
            string videoId = "Ke3S1LBu26Y";
            PlayYouTubeVideo(videoId);
        }

        private void btnSera6_Click(object sender, EventArgs e)
        {
            {
                string videoId = "6pG8ks_8OT4";
                PlayYouTubeVideo(videoId);
            }
        }
    }
}
