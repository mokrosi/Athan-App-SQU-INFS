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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BA1Project
{
    public partial class FrmSitting : Form
    {


        private MainFrm mainFormData;
        public int intcitytoSend = 0;

        public FrmSitting(MainFrm MainFrmData)
        {
            InitializeComponent();
            mainFormData = MainFrmData;
        }
        public FrmSitting()
        {
            InitializeComponent();
        }

        private void FrmSitting_Load(object sender, EventArgs e)
        {
            cboCity.Items.Add("Muscat");
            cboCity.Items.Add("Nizwa");
            cboCity.Items.Add("Swaiq");
            cboCity.Items.Add("Sohar");
            cboCity.Items.Add("Salalah");
            cboCity.Items.Add("Sur");
            cboCity.Items.Add("Ibri");
            cboCity.Items.Add("Buraimi");
            cboCity.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool boolnameswitch = false;
            bool boolCityswitch = false;

            
            if (chkShowName.Checked)
            {
                if (txtName.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Please Enter Your Name \n أدخل اسم من فضلك");

                }
                else
                {
                    string strupname = txtName.Text.Trim();
                    
                    MessageBox.Show("Your Name is Saved \n تم حفظ الاسم ");
                    //mainFormData.lblName.Text = strupname;
                    boolnameswitch = true;

                    mainFormData.saveName(txtName.Text.Trim());


                }
                mainFormData.lblName.Visible = true;
            }
            else
            {
                mainFormData.lblName.Visible = false;
                boolnameswitch = true;
            }



            string selectedCity = cboCity.SelectedItem.ToString().Trim();



            if (selectedCity == "Muscat")
            {
                intcitytoSend = 0;
                boolCityswitch = true;
            }
            else if (selectedCity == "Nizwa")
            {
                intcitytoSend = 3;
                boolCityswitch = true;

            }
            else if (selectedCity == "Swaiq")
            {
                intcitytoSend = 3;
                boolCityswitch = true;

            }
            else if (selectedCity == "Sohar")
            {
                intcitytoSend = 5;
                boolCityswitch = true;

            }
            else if (selectedCity == "Salalah")
            {
                intcitytoSend = 31;
                boolCityswitch = true;

            }
            else if (selectedCity == "Sur")
            {
                intcitytoSend = -4;
                boolCityswitch = true;

            }
            else if (selectedCity == "Ibri")
            {
                intcitytoSend = 8;
                boolCityswitch = true;

            }
            else if (selectedCity == "Buraimi")
            {
                intcitytoSend =7;
                boolCityswitch = true;

            }

            if (boolCityswitch && boolnameswitch)
            {
                mainFormData.LoadPrayerTimes();
                mainFormData.saveCite(intcitytoSend);
                MessageBox.Show("Sitting Update تم تحديث البيانات ");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            chkShowName.Checked = false;
        }

        private void btnImgBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Background Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mainFormData.HomePnl.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                    mainFormData.HomePnl.BackgroundImageLayout = ImageLayout.Stretch;
                    mainFormData.grpHome.BackColor = Color.White;
                    mainFormData.grpcluckDayGrp.BackColor = Color.White;
                    mainFormData.lblName.BackColor = Color.White;
                    mainFormData.lblName.ForeColor = Color.Black;
                    mainFormData.HomePnl.BackColor = Color.Transparent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnColorBackgroud_Click(object sender, EventArgs e)
        {
            if (cidBackgroud.ShowDialog() == DialogResult.OK)
            {
                mainFormData.HomePnl.BackColor = cidBackgroud.Color;
                mainFormData.grpHome.BackColor = Color.White;
                mainFormData.grpcluckDayGrp.BackColor = Color.White;
                mainFormData.lblName.BackColor = Color.White;
                mainFormData.lblName.ForeColor = Color.Black;
                mainFormData.HomePnl.BackgroundImage = null;
            }
        }

        private void btnBGDefault_Click(object sender, EventArgs e)
        {
            mainFormData.HomePnl.BackgroundImage = global::BA1Project.Properties.Resources.HOME_b;
            mainFormData.grpHome.BackColor = Color.Transparent;
            mainFormData.grpcluckDayGrp.BackColor = Color.Transparent;
        }
    }
}
