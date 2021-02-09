using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__Replay_Resampler.FFmpegVideo
{
  public class FFmpegSettings
  {
    /// <summary>
    /// Input video file
    /// </summary>
    public string InputVideo { get; }

    /// <summary>
    /// Output video file
    /// </summary>
    public string OutputVideo { get; }

    /// <summary>
    /// FPS of the input video file
    /// </summary>
    public int VideoFPS { get; }

    /// <summary>
    /// Video bitrate of the output video file in kbps
    /// </summary>
    public int VideoBitrate { get; }

    /// <summary>
    /// Audio bitrate of the output video file in kbps
    /// </summary>
    public int AudioBitrate { get; }

    /// <summary>
    /// Specifies whether ffmpeg should use gpu acceleration if available
    /// </summary>
    public bool UseGPUAcceleration { get; }

    /// <summary>
    /// Specifies whether ffmpeg should output to udp
    /// </summary>
    public bool OutputUdp { get; }

    public FFmpegSettings(string inputVideo, string outputVideo, int videofps, int videobitrate, int audiobitrate, bool useGPUAcceleration, bool outputUdp)
    {
      InputVideo = inputVideo;
      OutputVideo = outputVideo;
      VideoFPS = videofps;
      VideoBitrate = videobitrate;
      AudioBitrate = audiobitrate;
      UseGPUAcceleration = useGPUAcceleration;
      OutputUdp = outputUdp;
    }
  }
}
