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
    public partial class FrmEvent : Form
    {

        private MainFrm mainFormData;


        public FrmEvent(MainFrm MainFrmData)
        {
            InitializeComponent();
            mainFormData = MainFrmData;
        }

        public FrmEvent()
        {
            InitializeComponent();
        }

        private void lblEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cidEvent.ShowDialog() == DialogResult.OK)
            {
                lblEvent.ForeColor = cidEvent.Color;
                //mainFormData.lblEvent.ForeColor = cidEvent.Color;
            }
        }

        private void btnFontStyle_Click(object sender, EventArgs e)
        {
            if (fndText.ShowDialog() == DialogResult.OK)
            {
                lblEvent.Font = fndText.Font;
                //mainFormData.lblEvent.Font = fndText.Font;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (cidBack.ShowDialog() == DialogResult.OK)
            {
                lblEvent.BackColor = cidBack.Color;
                //mainFormData.lblEvent.BackColor = cidEvent.Color;
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblEvent.Text = txtEventTipe.Text;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            mainFormData.lblEvent.Visible = true;
            mainFormData.lblEvent.Text = txtEventTipe.Text;
            mainFormData.lblEvent.BackColor = cidBack.Color;
            mainFormData.lblEvent.ForeColor = cidEvent.Color;
            mainFormData.lblEvent.Font = fndText.Font;
            int intMinit = (int)nudMinit.Value;
            mainFormData.showEvent(intMinit);
        }
    }
}
