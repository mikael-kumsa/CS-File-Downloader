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
using AltoHttp;

namespace PhoenixDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;
        private void StartBtn_Click(object sender, EventArgs e)
        {
            httpDownloader = new HttpDownloader(urlTxtbox.Text, $"{Application.StartupPath}\\{Path.GetFileName(urlTxtbox.Text)}");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();

        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            percentLbl.Text = $"{e.Progress.ToString("0.00")} %";
            speedLbl.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            downloadedLbl.Text = string.Format("{0} MB/s", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            statusLbl.Text = "Downloading...";
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                statusLbl.Text = "Download Completed!";
                percentLbl.Text = "100%";
                if (statusLbl.Text == "Download Completed!")
                {
                    openFolderBtn.Visible = true;
                    Application.DoEvents();
                }
            });
            
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
            {
                httpDownloader.Pause();
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
            {
                httpDownloader.Resume();
            }
        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select, \"{0}\"", $"{Application.StartupPath}\\{Path.GetFileName(urlTxtbox.Text)}"));
        }

    }
}

