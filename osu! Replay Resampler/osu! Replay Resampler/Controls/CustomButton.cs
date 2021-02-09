using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu__Replay_Resampler.Controls
{
  public class CustomButton : Control
  {
    public CustomButton()
    {
      MouseEnter += (sender, e) =>
      {
        Debug.WriteLine("MouseEnter");
        hovering = true;
        Invalidate();
      };

      MouseLeave += (sender, e) =>
      {
        Debug.WriteLine("MouseLeave");
        hovering = false;
        Invalidate();
      };

      MouseDown += (sender, e) =>
      {
        Debug.WriteLine("MouseDown");
        mouseDown = true;
        Invalidate();
      };

      Click += (sender, e) =>
      {
        OnMouseUp(new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0));
      };

      MouseUp += (sender, e) =>
      {
        Debug.WriteLine("MouseUp");
        mouseDown = false;
        Invalidate();
      };

      TextChanged += (sender, e) => Invalidate();
    }

    private bool mouseDown = false;
    private bool hovering = false;

    private bool m_selected = false;
    public bool Selected
    {
      get
      {
        return m_selected;
      }
      set
      {
        m_selected = value;
        Invalidate();
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Rectangle rect = new Rectangle(2, 2, e.ClipRectangle.Width - 4, e.ClipRectangle.Height - 4);
      Color clrborder = Color.FromArgb(67, 71, 77);
      Color clrhoveringborder = Color.FromArgb(171, 171, 171);
      Color clrtext = Color.FromArgb(171, 171, 171);
      Color clrmousedownbg = Color.FromArgb(23, 24, 26);
      Color clrmousedownborder = Color.FromArgb(230, 75, 61);
      Color clrbg = Color.FromArgb(40, 40, 46);

      Color border = clrborder;
      if (mouseDown || Selected)
        border = clrmousedownborder;
      else if (hovering)
        border = clrhoveringborder;

      Color bg = clrbg;
      if (mouseDown)
        bg = clrmousedownbg;

      Color text = clrtext;
      if (hovering || Selected)
        text = Color.White;

      e.Graphics.FillPath(new SolidBrush(bg), RoundedRect(rect, 10));
      e.Graphics.DrawPath(new Pen(new SolidBrush(border), 1), RoundedRect(rect, 10));
      SizeF size = e.Graphics.MeasureString(Text, Font);
      e.Graphics.DrawString(Text, Font, new SolidBrush(text), Width / 2 - size.Width / 2, Height / 2 - size.Height / 2);
    }

    private GraphicsPath RoundedRect(Rectangle bounds, int radius)
    {
      int diameter = radius * 2;
      Size size = new Size(diameter, diameter);
      Rectangle arc = new Rectangle(bounds.Location, size);
      GraphicsPath path = new GraphicsPath();

      if (radius == 0)
      {
        path.AddRectangle(bounds);
        return path;
      }

      // top left arc  
      path.AddArc(arc, 180, 90);

      // top right arc  
      arc.X = bounds.Right - diameter;
      path.AddArc(arc, 270, 90);

      // bottom right arc  
      arc.Y = bounds.Bottom - diameter;
      path.AddArc(arc, 0, 90);

      // bottom left arc 
      arc.X = bounds.Left;
      path.AddArc(arc, 90, 90);

      path.CloseFigure();
      return path;
    }
  }
}
