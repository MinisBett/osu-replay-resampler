using System.Drawing;
using System.Windows.Forms;

namespace osu__Replay_Resampler.Controls
{
  public class CustomProgressBar : ProgressBar
  {
    /// <summary>
    /// Color of the progress bar border
    /// </summary>
    public Color BorderColor { get; set; } = Color.Gray;

    /// <summary>
    /// Color of the rectangle that indicates the progress
    /// </summary>
    public Color ProgressColor { get; set; } = Color.Green;

    /// <summary>
    /// Determines whether a label with the current percentage should be shown
    /// </summary>
    public bool ShowPercentLabel { get; set; } = true;

    /// <summary>
    /// Determines whether the label should say "Done." when percentage is 100. Only works in combination with ShowPercentLabel
    /// </summary>
    public bool ShowDoneLabel { get; set; } = true;


    public CustomProgressBar()
    {
      SetStyle(ControlStyles.UserPaint, true);
      SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      e.Graphics.DrawRectangle(new Pen(new SolidBrush(BorderColor), 1), 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);

      double percentageMultiplier = (double)Value / Maximum;
      e.Graphics.FillRectangle(new SolidBrush(ProgressColor), 1, 1, (int)(e.ClipRectangle.Width * percentageMultiplier) - 3, e.ClipRectangle.Height - 3);

      if (ShowPercentLabel)
      {
        string text = Value.ToString() + "%";
        if (ShowDoneLabel && Value == Maximum)
          text = "Done.";
        SizeF size = e.Graphics.MeasureString(text, Font);
        e.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), new PointF(Size.Width / 2 - size.Width / 2, Size.Height / 2 - size.Height / 2));
      }
    }
  }
}