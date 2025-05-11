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
    public partial class FrmSitEeqamaTime : Form
    {
        private MainFrm mainFormData;

        public FrmSitEeqamaTime(MainFrm MainFrmData)
        {
            InitializeComponent();
            mainFormData = MainFrmData;
        }
        public FrmSitEeqamaTime()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            

            int[] intTimeEqama = { (int)nudFajer.Value, (int)nudDhuhr.Value, (int)nudAsr.Value, (int)nudMaqhrib.Value, (int)nudIsha.Value };
            mainFormData.SaveEqamaTimes(intTimeEqama);
            MainFrm.SetEqamaTimes(intTimeEqama);
            mainFormData.LoadPrayerTimes();
            MessageBox.Show("Eqama times updated \n تم تحديث وقت الاقامة");
        }
    }
}
