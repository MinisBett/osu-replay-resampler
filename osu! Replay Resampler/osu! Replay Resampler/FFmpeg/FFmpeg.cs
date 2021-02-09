using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu__Replay_Resampler.FFmpegVideo
{
  public class FFmpeg
  {
    /// <summary>
    /// Specifies whether this ffmpeg instance is running
    /// </summary>
    public bool Running => m_ffmpegProcess != null && !m_ffmpegProcess.HasExited;

    /// <summary>
    /// Time at which ffmpeg started
    /// </summary>
    public DateTime StartTime { get; private set; } = DateTime.MinValue;

    private Process m_ffmpegProcess = null;

    public delegate void UpdateReceivedHandler(object sender, FFmpegOutput output);
    public event UpdateReceivedHandler UpdateReceived;

    // Codecs
    const string GPUACC_NVIDIA = "-vcodec h264_nvenc -cq 1 -acodec aac";
    const string GPUACC_AMD = "-vcodec h264_amf -cq 1 -acodec aac";
    const string X264 = "-vcodec libx264 -crf 1 -acodec aac";

    // Udp
    const string PSEUDOMUXER = "-f tee -map v:0 -map a:0";
    const string UDPOUTPUT = "|[f=mpegts:an]udp://127.0.0.1:3769?pkt_size=1316";

    // Other settings
    const string OPTIONS = "-r 60";

    public string getArgs(FFmpegSettings settings, string filter)
    {
      string output = settings.OutputVideo;

      string codecs = GPUACC_NVIDIA;

      string args = "";
      if (settings.OutputUdp)
        args = $"-i \"{settings.InputVideo}\" {PSEUDOMUXER} {codecs} {OPTIONS} -vf {filter} \"{output}{UDPOUTPUT}\"";
      else
        args = $"-i \"{settings.InputVideo}\" {codecs} {OPTIONS} -vf {filter} \"{output}\"";

      return args;
    }

    public void Tmix(FFmpegTmixSettings settings)
    {
      string filter = getTmix(settings);
      start(getArgs(settings, filter));
    }

    public void Tblend(FFmpegTblendSettings settings)
    {
      string filter = getTblend(settings);

      start(getArgs(settings, filter));
    }

    private void start(string args)
    {
      if (Running)
        throw new InvalidOperationException("This instance of FFmpeg is already running.");

      //Clipboard.SetText("ffmpeg.exe " + args);

      m_ffmpegProcess = new Process()
      {
        StartInfo = new ProcessStartInfo()
        {
          FileName = "ffmpeg.exe",
          Arguments = args,
          RedirectStandardInput = true,
          RedirectStandardOutput = true,
          RedirectStandardError = true,
          UseShellExecute = false,
          CreateNoWindow = true
        },
        EnableRaisingEvents = true
      };

      m_ffmpegProcess.ErrorDataReceived += (sender, e) =>
      {
        if (e.Data != null)
          Debug.WriteLine(e.Data);
        else
          return;

        if (FFmpegOutput.TryParse(e.Data, out FFmpegOutput output))
        {
          UpdateReceived?.Invoke(this, output);
        }
      };

      m_ffmpegProcess.Start();
      StartTime = DateTime.Now;
      m_ffmpegProcess.BeginErrorReadLine();
    }

    public void Stop()
    {
      if (!Running)
        throw new InvalidOperationException("FFmpeg is not running");

      m_ffmpegProcess.Kill();
      m_ffmpegProcess.WaitForExit();
    }

    private string getTmix(FFmpegTmixSettings settings)
    {
      List<int> weights = new List<int>();
      int weightcount = settings.VideoFPS / 60 * 2;

      if (settings.WeightOrder == WeightOrder.DESCENDING)
      {
        for (int i = weightcount; i > 0; i--)
          weights.Add(i);
      }
      else if (settings.WeightOrder == WeightOrder.EQUAL)
      {
        for (int i = 0; i < weightcount; i++)
          weights.Add(1);
      }
      else if (settings.WeightOrder == WeightOrder.ASCENDING)
      {
        for (int i = 0; i < weightcount; i++)
          weights.Add(i);
      }

      return $"tmix=frames={weightcount}:weights=\"{string.Join(" ", weights)}\"";
    }

    private string getTblend(FFmpegTblendSettings settings)
    {
      string filter = "";
      for (int i = 0; i < Math.Floor(settings.VideoFPS / 60d / settings.FrameSkip); i++)
        filter += $"tblend=average:all_opacity={settings.Opacity.ToString(CultureInfo.GetCultureInfo("en-US"))},framestep={settings.FrameSkip},";

      return filter.TrimEnd(',');
    }
  }
}
