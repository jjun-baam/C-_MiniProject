
namespace 과제_201730206_김준범
{
    partial class WeatherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.lblToday = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb1_3 = new System.Windows.Forms.Label();
            this.lb2_4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb2_2 = new System.Windows.Forms.Label();
            this.lb2_3 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb1_4 = new System.Windows.Forms.Label();
            this.lb3_3 = new System.Windows.Forms.Label();
            this.lb3_2 = new System.Windows.Forms.Label();
            this.lb3_4 = new System.Windows.Forms.Label();
            this.lb1_2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb4_2 = new System.Windows.Forms.Label();
            this.lb4_3 = new System.Windows.Forms.Label();
            this.lb4_4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb5_2 = new System.Windows.Forms.Label();
            this.lb5_3 = new System.Windows.Forms.Label();
            this.lb5_4 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb6_2 = new System.Windows.Forms.Label();
            this.lb6_3 = new System.Windows.Forms.Label();
            this.lb6_4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "지역 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "날짜 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "내용 :";
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "서울",
            "인천",
            "수원",
            "춘천",
            "청주",
            "대전",
            "전주",
            "광주",
            "목포",
            "여수",
            "대구",
            "부산",
            "울산",
            "제주"});
            this.cboCity.Location = new System.Drawing.Point(55, 18);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(84, 20);
            this.cboCity.TabIndex = 3;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(55, 49);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(11, 12);
            this.lblToday.TabIndex = 4;
            this.lblToday.Text = "-";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(56, 78);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(387, 142);
            this.txtMsg.TabIndex = 6;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(25, 273);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(29, 12);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "내일";
            // 
            // lb1_3
            // 
            this.lb1_3.AutoSize = true;
            this.lb1_3.Location = new System.Drawing.Point(25, 337);
            this.lb1_3.Name = "lb1_3";
            this.lb1_3.Size = new System.Drawing.Size(57, 12);
            this.lb1_3.TabIndex = 8;
            this.lb1_3.Text = "최고 기온";
            // 
            // lb2_4
            // 
            this.lb2_4.AutoSize = true;
            this.lb2_4.Location = new System.Drawing.Point(212, 369);
            this.lb2_4.Name = "lb2_4";
            this.lb2_4.Size = new System.Drawing.Size(29, 12);
            this.lb2_4.TabIndex = 9;
            this.lb2_4.Text = "날씨";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(212, 273);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(29, 12);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "모레";
            // 
            // lb2_2
            // 
            this.lb2_2.AutoSize = true;
            this.lb2_2.Location = new System.Drawing.Point(212, 305);
            this.lb2_2.Name = "lb2_2";
            this.lb2_2.Size = new System.Drawing.Size(57, 12);
            this.lb2_2.TabIndex = 11;
            this.lb2_2.Text = "최저 기온";
            // 
            // lb2_3
            // 
            this.lb2_3.AutoSize = true;
            this.lb2_3.Location = new System.Drawing.Point(212, 337);
            this.lb2_3.Name = "lb2_3";
            this.lb2_3.Size = new System.Drawing.Size(57, 12);
            this.lb2_3.TabIndex = 12;
            this.lb2_3.Text = "최고 기온";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(386, 273);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(29, 12);
            this.lb3.TabIndex = 13;
            this.lb3.Text = "글피";
            // 
            // lb1_4
            // 
            this.lb1_4.AutoSize = true;
            this.lb1_4.Location = new System.Drawing.Point(25, 369);
            this.lb1_4.Name = "lb1_4";
            this.lb1_4.Size = new System.Drawing.Size(29, 12);
            this.lb1_4.TabIndex = 14;
            this.lb1_4.Text = "날씨";
            // 
            // lb3_3
            // 
            this.lb3_3.AutoSize = true;
            this.lb3_3.Location = new System.Drawing.Point(386, 337);
            this.lb3_3.Name = "lb3_3";
            this.lb3_3.Size = new System.Drawing.Size(57, 12);
            this.lb3_3.TabIndex = 15;
            this.lb3_3.Text = "최고 기온";
            // 
            // lb3_2
            // 
            this.lb3_2.AutoSize = true;
            this.lb3_2.Location = new System.Drawing.Point(386, 305);
            this.lb3_2.Name = "lb3_2";
            this.lb3_2.Size = new System.Drawing.Size(57, 12);
            this.lb3_2.TabIndex = 16;
            this.lb3_2.Text = "최저 기온";
            // 
            // lb3_4
            // 
            this.lb3_4.AutoSize = true;
            this.lb3_4.Location = new System.Drawing.Point(386, 369);
            this.lb3_4.Name = "lb3_4";
            this.lb3_4.Size = new System.Drawing.Size(29, 12);
            this.lb3_4.TabIndex = 17;
            this.lb3_4.Text = "날씨";
            // 
            // lb1_2
            // 
            this.lb1_2.AutoSize = true;
            this.lb1_2.Location = new System.Drawing.Point(25, 305);
            this.lb1_2.Name = "lb1_2";
            this.lb1_2.Size = new System.Drawing.Size(57, 12);
            this.lb1_2.TabIndex = 18;
            this.lb1_2.Text = "최저 기온";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(25, 451);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(39, 12);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "4일 후";
            // 
            // lb4_2
            // 
            this.lb4_2.AutoSize = true;
            this.lb4_2.Location = new System.Drawing.Point(25, 483);
            this.lb4_2.Name = "lb4_2";
            this.lb4_2.Size = new System.Drawing.Size(57, 12);
            this.lb4_2.TabIndex = 20;
            this.lb4_2.Text = "최저 기온";
            // 
            // lb4_3
            // 
            this.lb4_3.AutoSize = true;
            this.lb4_3.Location = new System.Drawing.Point(25, 515);
            this.lb4_3.Name = "lb4_3";
            this.lb4_3.Size = new System.Drawing.Size(57, 12);
            this.lb4_3.TabIndex = 21;
            this.lb4_3.Text = "최고 기온";
            // 
            // lb4_4
            // 
            this.lb4_4.AutoSize = true;
            this.lb4_4.Location = new System.Drawing.Point(25, 547);
            this.lb4_4.Name = "lb4_4";
            this.lb4_4.Size = new System.Drawing.Size(29, 12);
            this.lb4_4.TabIndex = 22;
            this.lb4_4.Text = "날씨";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(212, 451);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(39, 12);
            this.lb5.TabIndex = 23;
            this.lb5.Text = "5일 후";
            // 
            // lb5_2
            // 
            this.lb5_2.AutoSize = true;
            this.lb5_2.Location = new System.Drawing.Point(212, 483);
            this.lb5_2.Name = "lb5_2";
            this.lb5_2.Size = new System.Drawing.Size(57, 12);
            this.lb5_2.TabIndex = 24;
            this.lb5_2.Text = "최저 기온";
            // 
            // lb5_3
            // 
            this.lb5_3.AutoSize = true;
            this.lb5_3.Location = new System.Drawing.Point(212, 515);
            this.lb5_3.Name = "lb5_3";
            this.lb5_3.Size = new System.Drawing.Size(57, 12);
            this.lb5_3.TabIndex = 25;
            this.lb5_3.Text = "최고 기온";
            // 
            // lb5_4
            // 
            this.lb5_4.AutoSize = true;
            this.lb5_4.Location = new System.Drawing.Point(212, 547);
            this.lb5_4.Name = "lb5_4";
            this.lb5_4.Size = new System.Drawing.Size(29, 12);
            this.lb5_4.TabIndex = 26;
            this.lb5_4.Text = "날씨";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(386, 451);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(39, 12);
            this.lb6.TabIndex = 27;
            this.lb6.Text = "6일 후";
            // 
            // lb6_2
            // 
            this.lb6_2.AutoSize = true;
            this.lb6_2.Location = new System.Drawing.Point(386, 483);
            this.lb6_2.Name = "lb6_2";
            this.lb6_2.Size = new System.Drawing.Size(57, 12);
            this.lb6_2.TabIndex = 28;
            this.lb6_2.Text = "최저 기온";
            // 
            // lb6_3
            // 
            this.lb6_3.AutoSize = true;
            this.lb6_3.Location = new System.Drawing.Point(386, 515);
            this.lb6_3.Name = "lb6_3";
            this.lb6_3.Size = new System.Drawing.Size(57, 12);
            this.lb6_3.TabIndex = 29;
            this.lb6_3.Text = "최고 기온";
            // 
            // lb6_4
            // 
            this.lb6_4.AutoSize = true;
            this.lb6_4.Location = new System.Drawing.Point(386, 547);
            this.lb6_4.Name = "lb6_4";
            this.lb6_4.Size = new System.Drawing.Size(29, 12);
            this.lb6_4.TabIndex = 30;
            this.lb6_4.Text = "날씨";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 581);
            this.Controls.Add(this.lb6_4);
            this.Controls.Add(this.lb6_3);
            this.Controls.Add(this.lb6_2);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5_4);
            this.Controls.Add(this.lb5_3);
            this.Controls.Add(this.lb5_2);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4_4);
            this.Controls.Add(this.lb4_3);
            this.Controls.Add(this.lb4_2);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb1_2);
            this.Controls.Add(this.lb3_4);
            this.Controls.Add(this.lb3_2);
            this.Controls.Add(this.lb3_3);
            this.Controls.Add(this.lb1_4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2_3);
            this.Controls.Add(this.lb2_2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb2_4);
            this.Controls.Add(this.lb1_3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherForm";
            this.Text = "Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb1_3;
        private System.Windows.Forms.Label lb2_4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb2_2;
        private System.Windows.Forms.Label lb2_3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb1_4;
        private System.Windows.Forms.Label lb3_3;
        private System.Windows.Forms.Label lb3_2;
        private System.Windows.Forms.Label lb3_4;
        private System.Windows.Forms.Label lb1_2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb4_2;
        private System.Windows.Forms.Label lb4_3;
        private System.Windows.Forms.Label lb4_4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb5_2;
        private System.Windows.Forms.Label lb5_3;
        private System.Windows.Forms.Label lb5_4;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb6_2;
        private System.Windows.Forms.Label lb6_3;
        private System.Windows.Forms.Label lb6_4;
    }
}