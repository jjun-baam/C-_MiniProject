
namespace 과제_201730206_김준범
{
    partial class StopWatchForm
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
            this.components = new System.ComponentModel.Container();
            this.lbM = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.lbMS = new System.Windows.Forms.Label();
            this.btnStart_Stop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbColon = new System.Windows.Forms.Label();
            this.lbSpot = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRecord = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbM.Location = new System.Drawing.Point(13, 43);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(102, 64);
            this.lbM.TabIndex = 0;
            this.lbM.Text = "00";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbS.Location = new System.Drawing.Point(127, 43);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(102, 64);
            this.lbS.TabIndex = 1;
            this.lbS.Text = "00";
            // 
            // lbMS
            // 
            this.lbMS.AutoSize = true;
            this.lbMS.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMS.Location = new System.Drawing.Point(248, 43);
            this.lbMS.Name = "lbMS";
            this.lbMS.Size = new System.Drawing.Size(102, 64);
            this.lbMS.TabIndex = 2;
            this.lbMS.Text = "00";
            // 
            // btnStart_Stop
            // 
            this.btnStart_Stop.Location = new System.Drawing.Point(12, 153);
            this.btnStart_Stop.Name = "btnStart_Stop";
            this.btnStart_Stop.Size = new System.Drawing.Size(99, 45);
            this.btnStart_Stop.TabIndex = 3;
            this.btnStart_Stop.Text = "시작/정지";
            this.btnStart_Stop.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(128, 153);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(99, 45);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "구간 기록";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(246, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 45);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lbColon
            // 
            this.lbColon.AutoSize = true;
            this.lbColon.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbColon.Location = new System.Drawing.Point(100, 51);
            this.lbColon.Name = "lbColon";
            this.lbColon.Size = new System.Drawing.Size(36, 48);
            this.lbColon.TabIndex = 6;
            this.lbColon.Text = ":";
            // 
            // lbSpot
            // 
            this.lbSpot.AutoSize = true;
            this.lbSpot.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSpot.Location = new System.Drawing.Point(220, 51);
            this.lbSpot.Name = "lbSpot";
            this.lbSpot.Size = new System.Drawing.Size(36, 48);
            this.lbSpot.TabIndex = 7;
            this.lbSpot.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecord);
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기록";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Location = new System.Drawing.Point(6, 17);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(0, 12);
            this.lbRecord.TabIndex = 0;
            // 
            // StopWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMS);
            this.Controls.Add(this.lbSpot);
            this.Controls.Add(this.lbColon);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnStart_Stop);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.lbM);
            this.Name = "StopWatchForm";
            this.Text = "스톱워치";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbMS;
        private System.Windows.Forms.Button btnStart_Stop;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbColon;
        private System.Windows.Forms.Label lbSpot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRecord;
    }
}