using LibVLCSharp.Shared;
using osu__Replay_Resampler.FFmpegVideo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu__Replay_Resampler
{
  public partial class Form1 : Form
  {

    #region Dll Imports

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    #endregion

    #region Variables

    Video m_video = null;

    FFmpeg m_ffmpeg = new FFmpeg();

    LibVLC m_vlc = null;
    MediaPlayer m_player = null;

    #endregion

    public Form1()
    {
      InitializeComponent();

      if (!DesignMode)
        Core.Initialize();

      m_vlc = new LibVLC();
      m_player = new MediaPlayer(m_vlc);
      videoView.MediaPlayer = m_player;
    }

    // Make borderless window moveable
    private void pnlMenuBar_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, 0xA1, 0x2, 0);
      }
    }

    #region Exit button events

    private void pctrbxExit_MouseEnter(object sender, EventArgs e)
    {
      pctrbxExit.Image = Properties.Resources.exit_hover;
    }

    private void pctrbxExit_MouseLeave(object sender, EventArgs e)
    {
      pctrbxExit.Image = Properties.Resources.exit;
    }

    private void pctrbxExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    #endregion

    #region video input events

    private void btnBrowseInput_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Supported Video Files|*.mp4;*.avi;*.mov;*.mkv;*.flv";
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        try
        {
          m_video = new Video(ofd.FileName);
          txtInputVideo.Text = ofd.FileName;
          prprtyVideo.SelectedObject = m_video;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void txtInputVideo_TextChanged(object sender, EventArgs e)
    {
      btnExport.Enabled = txtInputVideo.Text != "" && txtOutputVideo.Text != "";
    }

    #endregion

    #region tmix tblend selection button events

    private void btnTmix_Click(object sender, EventArgs e)
    {
      btnTmix.Selected = true;
      btnTblend.Selected = false;

      pnlTmix.Visible = true;
      pnlTblend.Visible = false;
    }

    private void btnTblend_Click(object sender, EventArgs e)
    {
      btnTmix.Selected = false;
      btnTblend.Selected = true;

      pnlTblend.Visible = true;
      pnlTmix.Visible = false;
    }

    #endregion

    #region tmix option events

    private void btnTmixReset_Click(object sender, EventArgs e)
    {
      rdbtnDescending.Checked = true;
    }

    #endregion

    #region tblend option events

    private void trckBrOpacity_Scroll(object sender, EventArgs e)
    {
      lblOpacity.Text = "(" + trckBrOpacity.Value + ")";
    }

    private void trckBrFrameSkip_Scroll(object sender, EventArgs e)
    {
      lblFrameSkip.Text = "(" + trckBrFrameSkip.Value + ")";
    }

    private void btnTblendReset_Click(object sender, EventArgs e)
    {
      trckBrOpacity.Value = 90;
      trckBrFrameSkip.Value = 2;
    }

    #endregion

    #region video export events

    private void btnBrowseOutput_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "Supported Video Files|*.mp4;*.avi;*.mov;*.mkv;*.flv";
      if (sfd.ShowDialog() == DialogResult.OK)
      {
        txtOutputVideo.Text = sfd.FileName;
      }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      if (m_ffmpeg.Running)
      {
        m_ffmpeg.Stop();

        if (File.Exists(txtOutputVideo.Text))
          File.Delete(txtOutputVideo.Text);

        pnlExportInformations.Visible = false;
        prgrsExport.Value = 0;
        lblCurrentFileSize.Text = "Current File Size: -";
        lblEstimatedFileSize.Text = "Estimated File Size: -";
        lblRenderTime.Text = "Render Time: -";
        lblEstimatedTimeLeft.Text = "Estimated Time Left: -";

        return;
      }

      SynchronizationContext context = SynchronizationContext.Current;

      double percentage = 0;

      m_ffmpeg.UpdateReceived += (_sender, output) =>
      {
        int outputTotalFrames = (int)Math.Ceiling(m_video.Length * (60 / 1000d));
        percentage = (double)output.Frames / outputTotalFrames * 100;

        context.Post(_ =>
        {
          if (prgrsExport.Value != (int)Math.Round(percentage))
            prgrsExport.Value = (int)Math.Round(percentage);
          double currentSizeMB = Math.Round(output.Size / 1024d, 2);
          lblCurrentFileSize.Text = $"Current File Size: {currentSizeMB.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))} MB";
          if (percentage > 0)
            lblEstimatedFileSize.Text = $"Estimated File Size: {Math.Round(currentSizeMB / percentage * 100, 2).ToString("F", CultureInfo.CreateSpecificCulture("en-US"))} MB";
        }, null);
      };

      Thread secondUpdate = new Thread(_ =>
      {
        while (m_ffmpeg.Running)
        {
          Thread.Sleep(100);
          context.Post(__ =>
          {
            TimeSpan timeSinceStart = DateTime.Now.Subtract(m_ffmpeg.StartTime);
            lblRenderTime.Text = $"Render Time: {string.Format("{0:00}:{1:00}:{2:00}", timeSinceStart.Hours, timeSinceStart.Minutes, timeSinceStart.Seconds)}";
            if (percentage > 0)
            {
              int estimatedSecondsLeft = (int)Math.Round(timeSinceStart.TotalSeconds / percentage * (100 - prgrsExport.Value));
              TimeSpan estimatedTimeLeft = TimeSpan.FromSeconds(estimatedSecondsLeft);
              lblEstimatedTimeLeft.Text = $"Estimated Time Left: {string.Format("{0:00}:{1:00}:{2:00}", estimatedTimeLeft.Hours, estimatedTimeLeft.Minutes, estimatedTimeLeft.Seconds)}";
            }
          }, null);
        }
      });

      pctrbxHideExportInformations.Visible = false;
      pnlExportInformations.Visible = true;
      btnExport.Text = "Cancel";

      Media media = new Media(m_vlc, "udp://@:3769?pkt_size=1316", FromType.FromLocation);
      m_player.Play(media);
      media.Dispose();

      if (File.Exists(txtOutputVideo.Text))
        File.Delete(txtOutputVideo.Text);

      if (btnTmix.Selected)
      {
        WeightOrder order = WeightOrder.DESCENDING;
        if (rdbtnAscending.Checked)
          order = WeightOrder.ASCENDING;
        else if (rdbtnEqual.Checked)
          order = WeightOrder.EQUAL;

        FFmpegTmixSettings settings = new FFmpegTmixSettings(txtInputVideo.Text, txtOutputVideo.Text, m_video.FPS, m_video.VideoBitrate, m_video.AudioBitrate, true, true, order);
        m_ffmpeg.Tmix(settings);
      }
      else if (btnTblend.Selected)
      {
        FFmpegTblendSettings settings = new FFmpegTblendSettings(txtInputVideo.Text, txtOutputVideo.Text, m_video.FPS, m_video.VideoBitrate, m_video.AudioBitrate, true, false, trckBrOpacity.Value / 100d, trckBrFrameSkip.Value);
        m_ffmpeg.Tblend(settings);
      }

      secondUpdate.Start();

      while (m_ffmpeg.Running)
        Application.DoEvents();

      btnExport.Text = "Export";
      prgrsExport.Value = 100;
      pctrbxHideExportInformations.Visible = true;
    }

    private void txtOutputVideo_TextChanged(object sender, EventArgs e)
    {
      btnExport.Enabled = txtInputVideo.Text != "" && txtOutputVideo.Text != "";
    }

    private void pctrbxHideExportInformations_MouseEnter(object sender, EventArgs e)
    {
      pctrbxHideExportInformations.Image = Properties.Resources.exit_hover;
    }

    private void pctrbxHideExportInformations_MouseLeave(object sender, EventArgs e)
    {
      pctrbxHideExportInformations.Image = Properties.Resources.exit;
    }

    private void pctrbxHideExportInformations_Click(object sender, EventArgs e)
    {
      pnlExportInformations.Visible = false;
      prgrsExport.Value = 0;
      lblCurrentFileSize.Text = "Current File Size: -";
      lblEstimatedFileSize.Text = "Estimated File Size: -";
      lblRenderTime.Text = "Render Time: -";
      lblEstimatedTimeLeft.Text = "Estimated Time Left: -";
    }

    #endregion
  }
}
