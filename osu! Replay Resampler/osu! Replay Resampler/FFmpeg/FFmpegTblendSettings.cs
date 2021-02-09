using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__Replay_Resampler.FFmpegVideo
{
  public class FFmpegTblendSettings : FFmpegSettings
  {
    /// <summary>
    /// Opacity of the tlbend filter
    /// </summary>
    public double Opacity { get; }

    /// <summary>
    /// Frameskip of the tblend filter
    /// </summary>
    public int FrameSkip { get; }

    public FFmpegTblendSettings(string inputVideo, string outputVideo, int videofps, int videobitrate, int audiobitrate, bool useGPUAcceleration, bool outputUdp, double opacity, int frameskip)
      : base(inputVideo, outputVideo, videofps, videobitrate, audiobitrate, useGPUAcceleration, outputUdp)
    {
      Opacity = opacity;
      FrameSkip = frameskip;
    }
  }
}
