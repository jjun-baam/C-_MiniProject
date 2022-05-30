using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제_201730206_김준범
{
    public partial class AlarmForm : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;
        SoundPlayer simpleSound = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\alarm.wav");

        public AlarmForm()
        {
            InitializeComponent();

            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;
            myTimer.Interval = 1000;
            myTimer.Tick += timer1_Tick;
            myTimer.Start();
            tabControl1.SelectedTab = tabPage2;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "tt hh:mm";

            btnSet.Click += Button1_Click;
            btnRset.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarm.Text = "-";
            tabControl1.SelectedTab = tabPage2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(dateTimePicker1.Text);
            tTime = DateTime.Parse(dateTimePicker2.Text);

            setAlarm = true;
            lblAlarmSet.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = dDay.ToShortDateString() + " " + tTime.ToShortTimeString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            lblDate.Text = cTime.ToShortDateString();
            lblTime.Text = cTime.ToShortTimeString();

            if (setAlarm == true)
            {
                if (dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    simpleSound.Play();
                    MessageBox.Show("설정한 시각이 되었습니다!!");
                }
            }
        }
    }
}
