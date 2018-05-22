namespace VizuelnoProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filenameLabel = new System.Windows.Forms.TextBox();
            this.durationField = new System.Windows.Forms.TextBox();
            this.volumeTrack = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loopingStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.songTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.backTrackButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filenameLabel
            // 
            this.filenameLabel.BackColor = System.Drawing.Color.Black;
            this.filenameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filenameLabel.Enabled = false;
            this.filenameLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.ForeColor = System.Drawing.Color.Lime;
            this.filenameLabel.Location = new System.Drawing.Point(10, 22);
            this.filenameLabel.Multiline = true;
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(487, 33);
            this.filenameLabel.TabIndex = 1;
            this.filenameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // durationField
            // 
            this.durationField.BackColor = System.Drawing.Color.Black;
            this.durationField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationField.Enabled = false;
            this.durationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationField.ForeColor = System.Drawing.Color.Lime;
            this.durationField.Location = new System.Drawing.Point(123, 60);
            this.durationField.Name = "durationField";
            this.durationField.Size = new System.Drawing.Size(137, 24);
            this.durationField.TabIndex = 2;
            // 
            // volumeTrack
            // 
            this.volumeTrack.BackColor = System.Drawing.Color.DimGray;
            this.volumeTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeTrack.LargeChange = 50;
            this.volumeTrack.Location = new System.Drawing.Point(114, 97);
            this.volumeTrack.Maximum = 100;
            this.volumeTrack.Name = "volumeTrack";
            this.volumeTrack.Size = new System.Drawing.Size(383, 56);
            this.volumeTrack.SmallChange = 10;
            this.volumeTrack.TabIndex = 0;
            this.volumeTrack.TickFrequency = 10;
            this.volumeTrack.ValueChanged += new System.EventHandler(this.volumeTrack_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.loopingStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.songTrackBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.backTrackButton);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.filenameLabel);
            this.groupBox1.Controls.Add(this.durationField);
            this.groupBox1.Controls.Add(this.volumeTrack);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playing";
            // 
            // loopingStatus
            // 
            this.loopingStatus.BackColor = System.Drawing.Color.Black;
            this.loopingStatus.Enabled = false;
            this.loopingStatus.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopingStatus.ForeColor = System.Drawing.Color.Lime;
            this.loopingStatus.Location = new System.Drawing.Point(349, 60);
            this.loopingStatus.Name = "loopingStatus";
            this.loopingStatus.Size = new System.Drawing.Size(148, 27);
            this.loopingStatus.TabIndex = 20;
            this.loopingStatus.Text = "Off";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(270, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Repeat:";
            // 
            // songTrackBar
            // 
            this.songTrackBar.BackColor = System.Drawing.Color.DimGray;
            this.songTrackBar.Location = new System.Drawing.Point(10, 204);
            this.songTrackBar.Name = "songTrackBar";
            this.songTrackBar.Size = new System.Drawing.Size(487, 56);
            this.songTrackBar.TabIndex = 18;
            this.songTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.songTrackBar.Scroll += new System.EventHandler(this.songTrackBar_Scroll);
            this.songTrackBar.ValueChanged += new System.EventHandler(this.songTrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Volume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Minute:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(338, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 39);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(419, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 39);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(354, 266);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(64, 54);
            this.nextButton.TabIndex = 11;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(284, 266);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(64, 54);
            this.stopButton.TabIndex = 10;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(144, 266);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(64, 54);
            this.pauseButton.TabIndex = 9;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(214, 266);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 54);
            this.playButton.TabIndex = 8;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backTrackButton
            // 
            this.backTrackButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.backTrackButton.Image = ((System.Drawing.Image)(resources.GetObject("backTrackButton.Image")));
            this.backTrackButton.Location = new System.Drawing.Point(74, 266);
            this.backTrackButton.Name = "backTrackButton";
            this.backTrackButton.Size = new System.Drawing.Size(64, 54);
            this.backTrackButton.TabIndex = 7;
            this.backTrackButton.UseVisualStyleBackColor = false;
            this.backTrackButton.Click += new System.EventHandler(this.backTrackButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(17, 39);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 25);
            this.statusLabel.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Black;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Lime;
            this.timeLabel.Location = new System.Drawing.Point(121, 166);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(87, 32);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "00:00";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 502);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 444);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = ".mp3|";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Delete selected song from Playlist";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 853);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(521, 900);
            this.MinimumSize = new System.Drawing.Size(521, 653);
            this.Name = "Form1";
            this.Text = "Mini Audio Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filenameLabel;
        private System.Windows.Forms.TextBox durationField;
        private System.Windows.Forms.TrackBar volumeTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button backTrackButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar songTrackBar;
        private System.Windows.Forms.TextBox loopingStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

