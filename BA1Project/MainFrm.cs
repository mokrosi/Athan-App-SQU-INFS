using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace BA1Project
{
    public partial class MainFrm : Form
    {
        public static int intTimecontrol = 0;
    
        public static DateTime fajrEqamaTime, dhuhrEqamaTime, asrEqamaTime, maghribEqamaTime, ishaEqamaTime , shuruqEqamaTime , DuhaEqamaTime;
        public static DateTime FajrAthan, ShuruqAthan, DuhaAthan, DuhrAthan, AsrAthan, MaghribAthan, IshaAthan;
        //Eqama sit edite 
        public static int intFajrEqamaTime = 0;
        public static int intShuruqrEqamaTime = 0;
        public static int intDhuhaEqamaTime = 0;
        public static int intDuhrEqamaTime = 0;
        public static int intAsrEqamaTime = 0;
        public static int intMaghribEqamaTime = 0;
        public static int intIshaEqamaTime = 0;

        //AthanToEqama
        int intAtnanToEqamaAll = 0;
        int intAtnanToEqamatDuhrAndAsr = 0;
        //Switch
        public bool boolTimerSwitch = true;
        public bool boolAthanCallSwitch = true;
        //int test = 0;

        //remaining nextPrayer
        //DateTime nextPrayerTime;
        //string strNextPrayerName;




        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            frmMidia frmMidia = new frmMidia();
            frmMidia.Show();
        }

        private async void MainFrm_Load(object sender, EventArgs e)
        {


            timer1.Start();
            //hajri date 
            DateTime hijriDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.Now.Day - 1), new GregorianCalendar());
            CultureInfo hijriCulture = new CultureInfo("ar-SA");
            hijriCulture.DateTimeFormat.Calendar = new HijriCalendar();
            //lblHijriDate.Text = hijriDate.ToString("dd "+"MMMM"+" yyyy", hijriCulture);
            lblHijriMonth.Text = hijriDate.ToString("MMMM", hijriCulture);
            lblHijriDay.Text = hijriDate.ToString("dd", hijriCulture);
            lblHijriYare.Text = hijriDate.ToString("yyyy ", hijriCulture);




            grpHome.BackColor = Color.Transparent;
            grpcluckDayGrp.BackColor = Color.Transparent;
            lblTitel.BackColor = Color.Transparent;
            lblName.BackColor = Color.Transparent;


            //lodeName


            lodeName();
            lodecite();
            int[] intTimeEqama = LoadEqamaTimes();
            SetEqamaTimes(intTimeEqama);
            LoadPrayerTimes();
            await PlayNightContent();




        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt ");
            lblDate.Text = DateTime.Now.ToString(" dd MMMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");

            LoadPrayerTimes();

            DateTime now = DateTime.Now;

            //callEqama
            if (boolTimerSwitch)
            {


                //test 
                //if (boolTimerSwitch)
                //{
                //    boolTimerSwitch = false;
                //    timerBeforEqama();
                //}
                if (now.Hour == fajrEqamaTime.Hour && now.Minute == fajrEqamaTime.Minute)
                {
                    boolTimerSwitch = false;
                    timerBeforEqama();
                }
                else if (now.Hour == dhuhrEqamaTime.Hour && now.Minute == dhuhrEqamaTime.Minute)
                {
                    boolTimerSwitch = false;
                    timerBeforEqama();
                }
                else if (now.Hour == asrEqamaTime.Hour && now.Minute == asrEqamaTime.Minute)
                {
                    boolTimerSwitch = false;
                    timerBeforEqama();
                }
                else if (now.Hour == maghribEqamaTime.Hour && now.Minute == maghribEqamaTime.Minute)
                {
                    boolTimerSwitch = false;
                    timerBeforEqama();
                }
                else if (now.Hour == ishaEqamaTime.Hour && now.Minute == ishaEqamaTime.Minute)
                {
                    boolTimerSwitch = false;
                    timerBeforEqama();
                    await PlayNightContent();
                }
            }
            //cllAthan
            //public static DateTime FajrAthan, ShuruqAthan, DuhaAthan, DuhrAthan, AsrAthan, MaghribAthan, IshaAthan;

            if (boolAthanCallSwitch)
            {


                //test 
                //if (boolAthanCallSwitch)
                //{
                //    boolAthanCallSwitch = false;
                //    formTimeaAthanCall();
                //}
                if (now.Hour == FajrAthan.Hour && now.Minute == FajrAthan.Minute)
                {
                    boolAthanCallSwitch = false;
                    formTimeaAthanCall();
                }
                else if (now.Hour == DuhrAthan.Hour && now.Minute == DuhrAthan.Minute)
                {
                    boolAthanCallSwitch = false;
                    formTimeaAthanCall();
                }
                else if (now.Hour == AsrAthan.Hour && now.Minute == AsrAthan.Minute)
                {
                    boolAthanCallSwitch = false;
                    formTimeaAthanCall();
                }
                else if (now.Hour == MaghribAthan.Hour && now.Minute == MaghribAthan.Minute)
                {
                    boolTimerSwitch = false;
                    formTimeaAthanCall();
                }
                else if (now.Hour == IshaAthan.Hour && now.Minute == IshaAthan.Minute)
                {
                    boolAthanCallSwitch = false;
                    formTimeaAthanCall();
                }
            }


            if (FajrAthan > now)
            {
                TimeSpan untilFajr = FajrAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text = $"{untilFajr.Hours:D2}:{untilFajr.Minutes:D2}"; ;
                lblNextPrayeDisplayName.Text = "Fajr الفجر";
                
            }
            else if (ShuruqAthan > now)
            {
                TimeSpan untilShuruq = ShuruqAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text = $"{untilShuruq.Hours:D2}:{untilShuruq.Minutes:D2}"; 
                lblNextPrayeDisplayName.Text = "Shuruq الشروق";
            }
            else if (DuhaAthan > now)
            {
                TimeSpan untilDuha = DuhaAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text= $"{untilDuha.Hours:D2}:{untilDuha.Minutes:D2}";
                lblNextPrayeDisplayName.Text = "Duha الضحى";
            }
            else if (DuhrAthan > now)
            {
                TimeSpan untilDuhr = DuhrAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text= $"{untilDuhr.Hours:D2}:{untilDuhr.Minutes:D2}";
                lblNextPrayeDisplayName.Text = "Dhuhr الظهر";
            }
            else if (AsrAthan > now)
            {
                TimeSpan untilAsr = AsrAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text = $"{untilAsr.Hours:D2}:{untilAsr.Minutes:D2}";
                lblNextPrayeDisplayName.Text = "Asr العصر";
            }
            else if (MaghribAthan > now)
            {
                TimeSpan untilMaghrib = MaghribAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text = $"{untilMaghrib.Hours:D2}:{untilMaghrib.Minutes:D2}";
                lblNextPrayeDisplayName.Text = "Maghrib المغرب";
            }
            else if (IshaAthan > now)
            {
                TimeSpan untilIsha = IshaAthan - DateTime.Now;
                lblNextPrayeDisplayTime.Text = $"{untilIsha.Hours:D2}:{untilIsha.Minutes:D2}";
                lblNextPrayeDisplayName.Text = "Isha العشاء";
            }
            else
            {
                TimeSpan untilFajrNextDay = FajrAthan.AddDays(1) - now;
                lblNextPrayeDisplayTime.Text = $"{untilFajrNextDay.Hours:D2}:{untilFajrNextDay.Minutes:D2}"; 
                lblNextPrayeDisplayName.Text = "Fajr الفجر";
            }


            //TimeToEqama


            if ( fajrEqamaTime.AddMinutes(1) > now)
            {
                TimeSpan untilFajr = fajrEqamaTime.AddMinutes(1) - DateTime.Now;
                lblTimeToEqamaTime.Text = $"{untilFajr.Hours:D2}:{untilFajr.Minutes:D2}"; ;
                lblTimeToEqamaNam.Text = "Fajr الفجر";

            }
            //else if (shuruqEqamaTime > now)
            //{
            //    TimeSpan untilShuruq = shuruqEqamaTime - DateTime.Now;
            //    lblTimeToEqamaTime.Text = $"{untilShuruq.Hours:D2}:{untilShuruq.Minutes:D2}";
            //    lblTimeToEqamaNam.Text = "Shuruq الشروق";
            //}
            //else if (dhuhrEqamaTime > now)
            //{
            //    TimeSpan untilDuha = dhuhrEqamaTime - DateTime.Now;
            //    lblTimeToEqamaTime.Text = $"{untilDuha.Hours:D2}:{untilDuha.Minutes:D2}";
            //    lblTimeToEqamaNam.Text = "Duha الضحى";
            //}
            else if (dhuhrEqamaTime.AddMinutes(1) > now)
            {
                TimeSpan untilDuhr = dhuhrEqamaTime.AddMinutes(1) - DateTime.Now;
                lblTimeToEqamaTime.Text = $"{untilDuhr.Hours:D2}:{untilDuhr.Minutes:D2}";
                lblTimeToEqamaNam.Text = "Dhuhr الظهر";
            }
            else if (asrEqamaTime.AddMinutes(1) > now)
            {
                TimeSpan untilAsr = asrEqamaTime.AddMinutes(1) - DateTime.Now;
                lblTimeToEqamaTime.Text = $"{untilAsr.Hours:D2}:{untilAsr.Minutes:D2}";
                lblTimeToEqamaNam.Text = "Asr العصر";
            }
            else if (maghribEqamaTime.AddMinutes(1) > now)
            {
                TimeSpan untilMaghrib = maghribEqamaTime.AddMinutes(1) - DateTime.Now;
                lblTimeToEqamaTime.Text = $"{untilMaghrib.Hours:D2}:{untilMaghrib.Minutes:D2}";
                lblTimeToEqamaNam.Text = "Maghrib المغرب";
            }
            else if (ishaEqamaTime.AddMinutes(1) > now)
            {
                TimeSpan untilIsha = ishaEqamaTime.AddMinutes(1) - DateTime.Now;
                lblTimeToEqamaTime.Text = $"{untilIsha.Hours:D2}:{untilIsha.Minutes:D2}";
                lblTimeToEqamaNam.Text = "Isha العشاء";
            }
            else
            {
                TimeSpan untilFajrNextDay = fajrEqamaTime.AddMinutes(1).AddDays(1) - now;
                lblTimeToEqamaTime.Text = $"{untilFajrNextDay.Hours:D2}:{untilFajrNextDay.Minutes:D2}";
                lblTimeToEqamaNam.Text = "Fajr الفجر";
            }


        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSitting FrmSitEeqamaTime = new FrmSitting(this);
            FrmSitEeqamaTime.Show();

        }

        private void btnSittingclose_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        // Fix for CS0119: 'Path' is a type, which is not valid in the given context
        // The issue occurs because 'Path' is being used as a variable name, but it conflicts with the System.IO.Path class.
        // Renaming the variable to avoid the conflict.

        //string filePath = Path.Combine(
        //   Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        //   "test.txt"
        //);

        // Update the usage of the renamed variable
        private void btnQuran_Click(object sender, EventArgs e)
        {

            frmQuran frmQuran = new frmQuran();
            frmQuran.Show();


        }

        private void btnDuas_Click(object sender, EventArgs e)
        {
            FrmDuas FrmDuas = new FrmDuas();
            FrmDuas.Show();
            
        }

        private void lblTimerTitel_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdoColor_CheckedChanged(object sender, EventArgs e)
        {

                
        }

        private void btnSitEqama_Click(object sender, EventArgs e)
        {
            FrmSitEeqamaTime FrmSitEeqamaTime = new FrmSitEeqamaTime(this);
            FrmSitEeqamaTime.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnColorBackgroud_Click(object sender, EventArgs e)
        {   
            

        }

        private void lblTimeToEqamaNam_Click(object sender, EventArgs e)
        {

        }

        private void btnImgBackground_Click(object sender, EventArgs e)
        {


        }

        private void lblFajrEqama_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEvent FrmEvent = new FrmEvent(this);
            FrmEvent.Show();
        }

        public void LoadPrayerTimes()
        {

            string strDateFrom, strDateTo;
            string strFajr, strShuruq, strDhuha, strDhuhr, strAsr, strMaghrib, strIsha;
            int intLinesCounter;
            string[] strSplittedText;
            string[] strLineDataIndex;

            strLineDataIndex = File.ReadAllLines("athan.txt");
            intLinesCounter = strLineDataIndex.Length;

            int intIndex = 1;
            while (intIndex < intLinesCounter)
            {
                strSplittedText = strLineDataIndex[intIndex].Split(',');

                strDateFrom = strSplittedText[0];
                strDateTo = strSplittedText[1];
                strFajr = strSplittedText[2];
                strShuruq = strSplittedText[3];
                strDhuha = strSplittedText[4];
                strDhuhr = strSplittedText[5];
                strAsr = strSplittedText[6];
                strMaghrib = strSplittedText[7];
                strIsha = strSplittedText[8];

                DateTime today = DateTime.Today;
                DateTime dtFrom = DateTime.Parse(strDateFrom);
                DateTime dtTo = DateTime.Parse(strDateTo);

                if (today >= dtFrom && today <= dtTo)
                {
                    // Athan
                    lblFajrAthan.Text = DateTime.ParseExact(strFajr, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");
                    lblShuruqAthan.Text = DateTime.ParseExact(strShuruq, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");
                    lblDuhaAthan.Text = DateTime.ParseExact(strDhuha, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");
                    lblDuhrAthan.Text = DateTime.ParseExact(strDhuhr, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");
                    lblAsrAthan.Text = DateTime.ParseExact(strAsr, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");
                    lblMaghribAthan.Text = DateTime.ParseExact(strMaghrib, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");
                    lblIshaAthan.Text = DateTime.ParseExact(strIsha, "H:mm", null).AddMinutes(intTimecontrol).ToString("hh:mm tt");

                    FajrAthan = DateTime.ParseExact(strFajr, "H:mm", null).AddMinutes(intTimecontrol);
                    ShuruqAthan = DateTime.ParseExact(strShuruq, "H:mm", null).AddMinutes(intTimecontrol);
                    DuhaAthan = DateTime.ParseExact(strDhuha, "H:mm", null).AddMinutes(intTimecontrol);
                    DuhrAthan = DateTime.ParseExact(strDhuhr, "H:mm", null).AddMinutes(intTimecontrol);
                    AsrAthan = DateTime.ParseExact(strAsr, "H:mm", null).AddMinutes(intTimecontrol);
                    MaghribAthan = DateTime.ParseExact(strMaghrib, "H:mm", null).AddMinutes(intTimecontrol);
                    IshaAthan = DateTime.ParseExact(strIsha, "H:mm", null).AddMinutes(intTimecontrol);


                    // Eqama
                    lblFajrEqama.Text = DateTime.ParseExact(strFajr, "H:mm", null).AddMinutes(intAtnanToEqamaAll + intTimecontrol + intFajrEqamaTime).ToString("hh:mm tt");
                    lblDhuhrEqama.Text = DateTime.ParseExact(strDhuhr, "H:mm", null).AddMinutes(intAtnanToEqamatDuhrAndAsr + intTimecontrol + intDuhrEqamaTime).ToString("hh:mm tt");
                    lblAsrEqama.Text = DateTime.ParseExact(strAsr, "H:mm", null).AddMinutes(intAtnanToEqamatDuhrAndAsr + intTimecontrol + intAsrEqamaTime).ToString("hh:mm tt");
                    lblMaghribEqama.Text = DateTime.ParseExact(strMaghrib, "H:mm", null).AddMinutes(intAtnanToEqamaAll + intTimecontrol + intMaghribEqamaTime).ToString("hh:mm tt");
                    lblIshaEqama.Text = DateTime.ParseExact(strIsha, "H:mm", null).AddMinutes(intAtnanToEqamaAll + intTimecontrol + intIshaEqamaTime).ToString("hh:mm tt");
                    //for timer
                    fajrEqamaTime = DateTime.ParseExact(strFajr, "H:mm", null).AddMinutes(intAtnanToEqamaAll + intTimecontrol - 1 + intFajrEqamaTime);
                    dhuhrEqamaTime = DateTime.ParseExact(strDhuhr, "H:mm", null).AddMinutes(intAtnanToEqamatDuhrAndAsr + intTimecontrol + intShuruqrEqamaTime);
                    asrEqamaTime = DateTime.ParseExact(strAsr, "H:mm", null).AddMinutes(intAtnanToEqamatDuhrAndAsr + intTimecontrol - 1 + intDhuhaEqamaTime);
                    maghribEqamaTime = DateTime.ParseExact(strMaghrib, "H:mm", null).AddMinutes(intAtnanToEqamaAll + intTimecontrol - 1 + intDuhrEqamaTime);
                    ishaEqamaTime = DateTime.ParseExact(strIsha, "H:mm", null).AddMinutes(intAtnanToEqamaAll + intTimecontrol - 1 + intIshaEqamaTime);

                }

                intIndex++;
                //summer time fix
                int intNowMonth = DateTime.Now.Month;
                if (intNowMonth == 4 || intNowMonth == 5 || intNowMonth == 6 || intNowMonth == 7)
                {
                    intAtnanToEqamaAll = 15;
                    intAtnanToEqamatDuhrAndAsr = 25;
                }
                else
                {
                    intAtnanToEqamaAll = 10;
                    intAtnanToEqamatDuhrAndAsr = 15;
                }



            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Interval = 10000000; 
            //timer2.Start();
            //PlayAllDayAudio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInfo FrmInfo = new FrmInfo();
            FrmInfo.Show();
        }

        private async void timerBeforEqama()
        {



            FrmEeqmaTimer FrmEeqmaTimer = new FrmEeqmaTimer();
            FrmEeqmaTimer.Show();

            await Task.Delay(120000);
            boolTimerSwitch = true;


        }

        private async void formTimeaAthanCall()
        {



            FrmAthanCall FrmAthanCall = new FrmAthanCall();
            FrmAthanCall.Show();

            await Task.Delay(300000);
            boolAthanCallSwitch = true;


        }

        public void lodeName()
        {


            try
            {
                
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "namesave.txt"
                );

                
                if (File.Exists(filePath))
                {
                    string savedName = File.ReadAllText(filePath).Trim();
                    
                    lblName.Text = savedName; 
                    lblName.Visible = true;
                }
                else
                {
                    
                    lblName.Text = "Mosque";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading name: " + ex.Message);
            }
        }

        public void saveName(string strNametoSave)
        {

            try
            {
                string strfilePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "namesave.txt"
                );

                File.WriteAllText(strfilePath, strNametoSave.Trim());
                lodeName();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving name: " + ex.Message);
            }

        }

        public void lodecite()
        {
            try
            {

                string filePathcite = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Citesave.txt"
                );


                if (File.Exists(filePathcite))
                {
                    string savedcite = File.ReadAllText(filePathcite).Trim();

                    int intCiteControl = int.Parse(savedcite);
                    //MessageBox.Show(" "+ intCiteControl);

                    intTimecontrol = intCiteControl;


                }
                else
                {

                    intTimecontrol = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading name: " + ex.Message);
            }


        }

        public void saveCite(int intCiteControl)
        {

            try
            {
                string filePathcite = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Citesave.txt"
                );

                File.WriteAllText(filePathcite, intCiteControl.ToString().Trim());
                lodecite(); // Load after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving cite: " + ex.Message);
            }


        }

        public static void SetEqamaTimes(int[] intTimeEqama)
        {
            if (intTimeEqama.Length >= 5) // Ensure array has at least 5 elements
            {
                intFajrEqamaTime = intTimeEqama[0];
                intDuhrEqamaTime = intTimeEqama[1];
                intAsrEqamaTime = intTimeEqama[2];
                intMaghribEqamaTime = intTimeEqama[3];
                intIshaEqamaTime = intTimeEqama[4];


            }
            else
            {
                intFajrEqamaTime = 0;
                intDuhrEqamaTime = 0;
                intAsrEqamaTime = 0;
                intMaghribEqamaTime = 0;
                intIshaEqamaTime = 0;
                //MessageBox.Show("Error:  intTimeEqama array.");
            }
        }

        public void SaveEqamaTimes(int[] intTimeEqama)
        {
            try
            {
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "EqamaTimes.txt"
                );

                string strDataToSave = string.Join(",", intTimeEqama);

                File.WriteAllText(filePath, strDataToSave);

                MessageBox.Show("Eqama times saved successfully!");
            }
            catch (Exception ex)
            {
                intFajrEqamaTime = 0;
                intDuhrEqamaTime = 0;
                intAsrEqamaTime = 0;
                intMaghribEqamaTime = 0;
                intIshaEqamaTime = 0;
                //MessageBox.Show("Error saving times: " + ex.Message);
            }
        }

        public int[] LoadEqamaTimes()
        {
            try
            {
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "EqamaTimes.txt"
                );

                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath).Trim();

                    // Convert comma-separated values back to an integer array
                    return data.Split(',').Select(int.Parse).ToArray();
                }
                else
                {
                    //MessageBox.Show("EqamaTimes.txt not found! Using default values.");
                    return new int[] { 0, 0, 0, 0, 0 }; // Default values
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Eqama times: " + ex.Message);
                return new int[] { 0, 0, 0, 0, 0 }; 
            }
        }

        //public WindowsMediaPlayer playerAllDay = new WindowsMediaPlayer();
        //public void PlayAllDayAudio()
        //{
        //    if(PlayAllDayAudioTimeChick() == 1)
        //    {
        //        // Play the audio file

        //        playerAllDay.URL = "";
        //        playerAllDay.controls.play();
        //        playerAllDay.settings.setMode("loop", true); 


        //    }
        //    else
        //    {
        //        // Do not play the audio
        //    }

        //}

        //public int PlayAllDayAudioTimeChick()
        //{
        //    //1 = night 0 Moring
        //  //DateTime now = DateTime.Now;

        //  //  if (now.Hour >= IshaAthan.Hour || now.Hour < FajrAthan.Hour)
        //  //  {
        //  //      return 1;
        //  //  }
        //  //  else
        //  //  {
        //  //      return 0;
        //  //  }


        //}

        public  async void showEvent(int intMinite)
        {
            //lblEvent.Visible = true;
            await Task.Delay(intMinite * 60000);
            lblEvent.Visible = false;


        }

        public static async void afterslat()
        {
            WindowsMediaPlayer playerafterslat = new WindowsMediaPlayer();
            await Task.Delay(15 * 60000);
            playerafterslat.URL = "afterslat.mp3";
            playerafterslat.controls.play();



        }
        private async Task PlayNightContent()
        {
            DateTime now = DateTime.Now;
            WindowsMediaPlayer PlayNightContent = new WindowsMediaPlayer();

            if (now >= IshaAthan.AddMinutes(60) || now < FajrAthan)
            {
                PlayNightContent.URL = "day/quran1.mp3";
                PlayNightContent.controls.play();
                await Task.Delay(30 * 60000); 

                PlayNightContent.URL = "day/THKER1.mp3";
                PlayNightContent.controls.play();
                await Task.Delay(30 * 60000);

                PlayNightContent.URL = "day/STORY.mp3";
                PlayNightContent.controls.play();
                await Task.Delay(30 * 60000);

                PlayNightContent.URL = "day/LACTURE1.mp3";
                PlayNightContent.controls.play();
                await Task.Delay(30 * 60000);

                PlayNightContent.URL = "day/duas1.mp3";
                PlayNightContent.controls.play();
            }
        }

    }

}


    

