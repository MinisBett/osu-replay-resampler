using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__Replay_Resampler.FFmpegVideo
{
  public class FFmpegTmixSettings : FFmpegSettings
  {
    /// <summary>
    /// The weight order of the tmix filter
    /// </summary>
    public WeightOrder WeightOrder { get; }

    public FFmpegTmixSettings(string inputVideo, string outputVideo, int videofps, int videobitrate, int audiobitrate, bool useGPUAcceleration, bool outputUdp, WeightOrder weightOrder)
      : base(inputVideo, outputVideo, videofps, videobitrate, audiobitrate, useGPUAcceleration, outputUdp)
    {
      WeightOrder = weightOrder;
    }
  }
}
