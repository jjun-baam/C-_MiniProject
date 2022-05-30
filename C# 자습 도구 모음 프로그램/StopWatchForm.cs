using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제_201730206_김준범
{
    public partial class StopWatchForm : Form
    {
        private int CountMS = 0;
        private int CountS = 0;
        private int CountM = 0;
        int a = 1;
        private bool Toggle = false;
        public StopWatchForm()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            timer2.Tick += Timer2_Tick;
            btnStart_Stop.Click += BtnStart_Stop_Click;
            btnRecord.Click += BtnRecord_Click;
            btnReset.Click += BtnReset_Click;
        }

        private void BtnStart_Stop_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Start();
                timer2.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            string str = "";

            lbRecord.Text += "["+a.ToString() + "]  " + CountM.ToString() + " " + lbColon.Text + " " 
                + CountS.ToString() + " " + lbSpot.Text + " " + CountMS.ToString() + " \n";
            ++a;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Toggle = false;
            CountM = 0;
            CountS = 0;
            CountMS = 0;
            lbM.Text = CountM.ToString();
            lbS.Text = CountS.ToString();
            lbMS.Text = CountMS.ToString();
            lbRecord.Text = "";
            a = 1;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            ++CountMS;
            if (CountMS == 60)
            {
                CountMS = 0;
                ++CountS;

                if (CountS == 60)
                {
                    CountS = 0;
                    ++CountM;
                }
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            lbM.Text = CountM.ToString();
            lbS.Text = CountS.ToString();
            lbMS.Text = CountMS.ToString();
        }
    }
}
