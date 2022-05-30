namespace 과제_201730206_김준범
{
    partial class ImageCutForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale100MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale75MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale66MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale50MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale25MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale15MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sizeLebal = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.scaleMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(277, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveAsMenuItem,
            this.menuSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fileMenuItem.Text = "파일(&F)";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(268, 24);
            this.openMenuItem.Text = "열기(&O)...";
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(268, 24);
            this.saveAsMenuItem.Text = "다른 이름으로 저장(&S)...";
            // 
            // menuSeparator1
            // 
            this.menuSeparator1.Name = "menuSeparator1";
            this.menuSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(268, 24);
            this.exitMenuItem.Text = "종료(&X)";
            // 
            // scaleMenuItem
            // 
            this.scaleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scale100MenuItem,
            this.scale75MenuItem,
            this.scale66MenuItem,
            this.scale50MenuItem,
            this.scale25MenuItem,
            this.scale15MenuItem});
            this.scaleMenuItem.Name = "scaleMenuItem";
            this.scaleMenuItem.Size = new System.Drawing.Size(149, 24);
            this.scaleMenuItem.Text = "확대/축소(&S) (100%)";
            // 
            // scale100MenuItem
            // 
            this.scale100MenuItem.Checked = true;
            this.scale100MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scale100MenuItem.Name = "scale100MenuItem";
            this.scale100MenuItem.Size = new System.Drawing.Size(119, 24);
            this.scale100MenuItem.Text = "1&00%";
            // 
            // scale75MenuItem
            // 
            this.scale75MenuItem.Name = "scale75MenuItem";
            this.scale75MenuItem.Size = new System.Drawing.Size(119, 24);
            this.scale75MenuItem.Text = "&75%";
            // 
            // scale66MenuItem
            // 
            this.scale66MenuItem.Name = "scale66MenuItem";
            this.scale66MenuItem.Size = new System.Drawing.Size(119, 24);
            this.scale66MenuItem.Text = "&66%";
            // 
            // scale50MenuItem
            // 
            this.scale50MenuItem.Name = "scale50MenuItem";
            this.scale50MenuItem.Size = new System.Drawing.Size(119, 24);
            this.scale50MenuItem.Text = "&50%";
            // 
            // scale25MenuItem
            // 
            this.scale25MenuItem.Name = "scale25MenuItem";
            this.scale25MenuItem.Size = new System.Drawing.Size(119, 24);
            this.scale25MenuItem.Text = "&25%";
            // 
            // scale15MenuItem
            // 
            this.scale15MenuItem.Name = "scale15MenuItem";
            this.scale15MenuItem.Size = new System.Drawing.Size(119, 24);
            this.scale15MenuItem.Text = "&15%";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.Filter = "Picture Files|*.bmp;*.jpg;*.gif;*.png;*.tif|All Files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "png";
            this.openFileDialog.Filter = "Picture Files|*.bmp;*.jpg;*.gif;*.png;*.tif|All Files|*.*";
            // 
            // sizeLebal
            // 
            this.sizeLebal.Location = new System.Drawing.Point(10, 40);
            this.sizeLebal.Name = "sizeLebal";
            this.sizeLebal.Size = new System.Drawing.Size(40, 23);
            this.sizeLebal.TabIndex = 1;
            this.sizeLebal.Text = "크기";
            this.sizeLebal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(50, 40);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(50, 26);
            this.widthTextBox.TabIndex = 2;
            this.widthTextBox.Text = "200";
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(120, 40);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(50, 26);
            this.heightTextBox.TabIndex = 4;
            this.heightTextBox.Text = "100";
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.Location = new System.Drawing.Point(100, 40);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(20, 23);
            this.multiplyLabel.TabIndex = 3;
            this.multiplyLabel.Text = "X";
            this.multiplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(10, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // ImageCutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(277, 345);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.multiplyLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.sizeLebal);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ImageCutForm";
            this.Text = "이미지 자르기";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label sizeLebal;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label multiplyLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem scaleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale75MenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale66MenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale50MenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale25MenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale15MenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale100MenuItem;
    }
}

