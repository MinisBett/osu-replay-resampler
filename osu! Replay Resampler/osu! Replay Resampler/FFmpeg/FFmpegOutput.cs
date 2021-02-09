using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__Replay_Resampler.FFmpegVideo
{
  public class FFmpegOutput
  {
    /// <summary>
    /// Frames that have been rendered
    /// </summary>
    public int Frames { get; }

    /// <summary>
    /// Speed at which ffmpeg is current rendering, specified in frames per second
    /// </summary>
    public double FPS { get; }

    /// <summary>
    /// No information
    /// </summary>
    public double Q { get; }

    /// <summary>
    /// Current size of the output video
    /// </summary>
    public int Size { get; }

    /// <summary>
    /// Timestamp in the output video at which ffmpeg is currently rendering
    /// </summary>
    public string Time { get; }

    /// <summary>
    /// Current bitrate, with which the output video is rendering
    /// </summary>
    public double Bitrate { get; }

    /// <summary>
    /// No information
    /// </summary>
    public int DUP { get; }

    /// <summary>
    /// Frames that have been dropped whilst rendering
    /// </summary>
    public int Dropped { get; }

    /// <summary>
    /// Speed at which ffmpeg is currently rendering, specified in a multiplier. (0.1 = 1 second of output video is 10 seconds to render)
    /// </summary>
    public double Speed { get; }

    private FFmpegOutput(int frames, double fps, double q, int size, string time, double bitrate, int dup, int dropped, double speed)
    {
      Frames = frames;
      FPS = fps;
      Q = q;
      Size = size;
      Time = time;
      Bitrate = bitrate;
      DUP = dup;
      Dropped = dropped;
      Speed = speed;
    }

    public static bool TryParse(string raw, out FFmpegOutput output)
    {
      output = null;

      try
      {
        string[] elements = raw.Replace("    ", "").Replace("   ", "").Replace("  ", " ").Replace("= ", "=").Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        /*List<string> _elem = new List<string>();
        foreach (string elem in elements)
          if (!_elem.Any(x => elem.StartsWith(x.Split('=')[0])))
            _elem.Add(elem);
        elements = _elem.ToArray(); */

        string[] keys = new string[] { "frame", "fps", "q", "size", "time", "bitrate", "dup", "drop", "speed" };

        if (elements.Length != keys.Length)
          return false;

        for (int i = 0; i < elements.Length; i++)
        {
          if (!elements[i].StartsWith(keys[i]))
            return false;

          elements[i] = elements[i].Replace(keys[i] + "=", "");
          if (elements[i] == "N/A")
            elements[i] = "0";
        }

        output = new FFmpegOutput(int.Parse(elements[0]), double.Parse(elements[1]), double.Parse(elements[2]), int.Parse(elements[3].Replace("kB", "")),
                                  elements[4], double.Parse(elements[5].Replace("kbits/s", "")), int.Parse(elements[6]),
                                  int.Parse(elements[7]), double.Parse(elements[8].Replace("x", "")));

        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
