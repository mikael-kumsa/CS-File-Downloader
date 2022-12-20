namespace PhoenixDownloader
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
            this.urlTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadedLbl = new System.Windows.Forms.Label();
            this.speedLbl = new System.Windows.Forms.Label();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlTxtbox
            // 
            this.urlTxtbox.Location = new System.Drawing.Point(119, 37);
            this.urlTxtbox.Name = "urlTxtbox";
            this.urlTxtbox.Size = new System.Drawing.Size(441, 20);
            this.urlTxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(119, 94);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(442, 23);
            this.progressBar.TabIndex = 2;
            // 
            // resumeBtn
            // 
            this.resumeBtn.Location = new System.Drawing.Point(469, 152);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(87, 23);
            this.resumeBtn.TabIndex = 3;
            this.resumeBtn.Text = "&Resume";
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(115, 73);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(28, 13);
            this.statusLbl.TabIndex = 1;
            this.statusLbl.Text = "???";
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Location = new System.Drawing.Point(532, 77);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(23, 13);
            this.percentLbl.TabIndex = 1;
            this.percentLbl.Text = "0%";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(358, 152);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(87, 23);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "&Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(241, 152);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(87, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "&Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Downloaded";
            // 
            // downloadedLbl
            // 
            this.downloadedLbl.AutoSize = true;
            this.downloadedLbl.Location = new System.Drawing.Point(115, 180);
            this.downloadedLbl.Name = "downloadedLbl";
            this.downloadedLbl.Size = new System.Drawing.Size(36, 13);
            this.downloadedLbl.TabIndex = 1;
            this.downloadedLbl.Text = "0 MB";
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(115, 131);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(48, 13);
            this.speedLbl.TabIndex = 1;
            this.speedLbl.Text = "0 MB/s";
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Location = new System.Drawing.Point(469, 182);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openFolderBtn.Size = new System.Drawing.Size(87, 23);
            this.openFolderBtn.TabIndex = 4;
            this.openFolderBtn.Text = "Open Folder";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Visible = false;
            this.openFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(605, 220);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.downloadedLbl);
            this.Controls.Add(this.speedLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTxtbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phoenix Downloader";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label percentLbl;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label downloadedLbl;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.Button openFolderBtn;
    }
}

