using System;
using System.Collections;
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
    public partial class Main : Form
    {
        ArrayList UserNameList = new ArrayList();
        List<User> users = new List<User>();
        User user;
        public Main()
        {
            InitializeComponent();

            btnUserIn.Click += btnUserIn_Click; //공부시작 버튼
            btnUserOut.Click += btnUserOut_Click; //공부종료 버튼

            btnSearch.Click += BtnSearch_Click; //검색 버튼

            btn1.Click += Btn1_Click;  //자
            btn2.Click += Btn2_Click;  //주
            btn3.Click += Btn3_Click;  //사
            btn4.Click += Btn4_Click;  //용
            btn5.Click += Btn5_Click;  //하
            btn6.Click += Btn6_Click;  //는
            btn7.Click += Btn7_Click;  //프
            btn8.Click += Btn8_Click;  //로
            btn9.Click += Btn9_Click;  //그
            btn10.Click += Btn10_Click;//램
            btn11.Click += Btn11_Click;//버
            btn12.Click += Btn12_Click;//튼

            btnScreenCapture.Click += BtnScreenCapture_Click;
            btnImageCut.Click += BtnImageCut_Click;
            btnStopWatch.Click += BtnStopWatch_Click;
            btnAlarm.Click += BtnAlarm_Click;
            btnWeather.Click += BtnWeather_Click;
            btnIDPWBook.Click += BtnIDPWBook_Click;

        }







        /*사용자 공부 방명록 코드 시작*/
        private void btnUserIn_Click(object sender, EventArgs e) //공부시작 버튼을 눌렀을 때의 이벤트내용
        {
            if (UserNameList.Contains(cboUserList.Text))
            {
                listBoxState.Items.Add(cboUserList.Text + "은(는) 공부 중 입니다."); //이미 공부를 시작한 사용자의 중복입력을 막는다.
                return;
            }
            user = new User();
            user.UserName = cboUserList.Text;
            user.SetInTime();
            users.Add(user);
            UserNameList.Add(user.UserName);
            cboUserList.Items.Clear();
            cboUserList.Items.AddRange(UserNameList.ToArray());
            StringBuilder sb = new StringBuilder();
            sb.Append(" [이름] ");
            sb.Append(user.UserName);
            sb.Append(" [공부시작] ");
            sb.Append(user.GetInTime());
            listBoxState.Items.Add(sb.ToString());   
        }

        private void btnUserOut_Click(object sender, EventArgs e) //공부종료 버튼을 눌렀을 때의 이벤트내용
        {
            foreach (var item in users)
            {
                if (item.UserName.Contains(cboUserList.Text))
                {
                    item.SetOutTime();
                    StringBuilder sb = new StringBuilder();
                    sb.Append(" [이름] ");
                    sb.Append(item.UserName);
                    sb.AppendLine();
                    sb.Append(" [공부종료] ");
                    sb.Append(item.GetOutTime());
                    sb.AppendLine();
                    sb.Append(" [공부시간] ");
                    sb.Append(GetSturyingTime(item.GetInTime(), item.GetOutTime()));
                    listBoxState.Items.Add(sb.ToString());
                    UserNameList.Remove(item.UserName);
                    cboUserList.Items.Clear();
                    cboUserList.Items.AddRange(UserNameList.ToArray());
                    users.Remove(item);
                    cboUserList.Text = "";
                    MessageBox.Show(sb.ToString());
                    break;
                }
            }
        }

        private string GetSturyingTime(DateTime inTime, DateTime outTime) //공부시작 시간과 공부종료 시간의 차를 계산한다.
        {
            double oaOutTimeout = outTime.ToOADate();
            double oaInTimeout = inTime.ToOADate();
            double oaStudyTime = oaOutTimeout - oaInTimeout;
            DateTime StudyingTime = DateTime.FromOADate(oaStudyTime);
            int hour = StudyingTime.Hour;
            int min = StudyingTime.Minute;
            int sec = StudyingTime.Second;
            return hour + "시간 " + min + "분 " + sec + "초";
        }
        /*사용자 공부 방명록 코드 종료*/


        /*검색 기능 코드 시작*/
        private void Problem_Load(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "https://image7.coupangcdn.com/image/coupang/common/logo_coupang_w350.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = "http://static.campaign.naver.com/nfs/logoart/logo/695/756395534e8a5283fe66862082ac9488.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + textBox1.Text);
            }
            if (radioButton2.Checked == true)
            {
                System.Diagnostics.Process.Start("https://search.naver.com/search.naver?query=" + textBox1.Text);
            }
            if (radioButton3.Checked == true)
            {
                System.Diagnostics.Process.Start("https://www.coupang.com/np/search?q=" + textBox1.Text);
            }

        }
        /*검색 기능 코드 종료*/


        /*자주 사용하는 프로그램 코드 시작*/
        private void Btn12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\kimju\\eclipse\\java-2020-12\\eclipse\\eclipse.exe");
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\Microsoft VS Code\\Code.exe");
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\devenv.exe");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Android\\Android Studio\\bin\\studio64.exe");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("E:");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
        /*자주 사용하는 프로그램 코드 종료*/

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            ScreenCaptureForm screenCaptureForm = new ScreenCaptureForm();
            screenCaptureForm.Show();
        }
        private void BtnImageCut_Click(object sender, EventArgs e)
        {
            ImageCutForm imageCutForm = new ImageCutForm();
            imageCutForm.Show();
        }
        private void BtnStopWatch_Click(object sender, EventArgs e)
        {
            StopWatchForm stopWatchForm = new StopWatchForm();
            stopWatchForm.Show();
        }
        private void BtnAlarm_Click(object sender, EventArgs e)
        {
            AlarmForm alarmForm = new AlarmForm();
            alarmForm.Show();
        }
        private void BtnWeather_Click(object sender, EventArgs e)
        {
            WeatherForm weatherForm = new WeatherForm();
            weatherForm.Show();
        }
        private void BtnIDPWBook_Click(object sender, EventArgs e)
        {
            ID_PW_BookForm iD_PW_BookForm = new ID_PW_BookForm();
            iD_PW_BookForm.Show();
        }
        
    }
}
