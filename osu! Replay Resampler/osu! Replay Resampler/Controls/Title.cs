using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu__Replay_Resampler.Controls
{
  public class Title : Control
  {
    public Title()
    {

    }

    protected override void OnPaint(PaintEventArgs e)
    {
      SizeF size = e.Graphics.MeasureString(Text, Font);
      e.Graphics.DrawLine(new Pen(new SolidBrush(ForeColor), 1), 0, Height / 2, Width, Height / 2);
      int padding = 4;

      e.Graphics.DrawLine(new Pen(new SolidBrush(BackColor), 1), Width / 2 - size.Width / 2 - padding, Height / 2, Width / 2 + size.Width / 2 + padding, Height / 2);
      e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2 - size.Width / 2, Height / 2 - size.Height / 2);
    }
  }
}
