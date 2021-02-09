using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__Replay_Resampler
{
  /// <summary>
  /// Class that holds data about a specified video
  /// </summary>
  public class Video
  {
    /// <summary>
    /// The file path to the video
    /// </summary>
    public string File { get; }

    /// <summary>
    /// The size of the video frames
    /// </summary>
    public Size Size { get; }

    /// <summary>
    /// Length of the video in milliseconds
    /// </summary>
    public int Length { get; }

    /// <summary>
    /// Frames per second of the video
    /// </summary>
    public int FPS { get; }

    /// <summary>
    /// The bitrate of the video in kbps
    /// </summary>
    public int VideoBitrate { get; }

    /// <summary>
    /// The bitrate of the video's audio in kbps
    /// </summary>
    public int AudioBitrate { get; }

    public Video(string file)
    {
      File = file;
      int width = (int)ShellFile.FromFilePath(file).Properties.System.Video.FrameWidth.Value.Value;
      int height = (int)ShellFile.FromFilePath(file).Properties.System.Video.FrameHeight.Value.Value;
      Size = new Size(width, height);
      Length = (int)Math.Round(ShellFile.FromFilePath(file).Properties.System.Media.Duration.Value.Value / 10000d);
      FPS = (int)Math.Ceiling(ShellFile.FromFilePath(file).Properties.System.Video.FrameRate.Value.Value / 1000d);
      VideoBitrate = (int)Math.Round(ShellFile.FromFilePath(file).Properties.System.Video.EncodingBitrate.Value.Value / 1000d);
      AudioBitrate = (int)Math.Round(ShellFile.FromFilePath(file).Properties.System.Audio.EncodingBitrate.Value.Value / 1000d);
    }
  }
}
