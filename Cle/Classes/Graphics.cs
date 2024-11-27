namespace Cle.Classes
{
  using System.Drawing.Drawing2D;
  using System.Runtime.InteropServices;

  internal static class Graphics
  {
    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      float x,
      float y,
      float width,
      float height,
      float radius,
      RectangleEdgeFilter filter)
    {
      var rectangle = new RectangleF(x, y, width, height);
      var path = graphics.GenerateRoundedRectangle(rectangle, radius, filter);
      var old = graphics.SmoothingMode;
      graphics.SmoothingMode = SmoothingMode.AntiAlias;
      graphics.DrawPath(pen, path);
      graphics.SmoothingMode = old;
    }

    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      float x,
      float y,
      float width,
      float height,
      float radius)
    {
      graphics.DrawRoundedRectangle(pen, x, y, width, height, radius, RectangleEdgeFilter.All);
    }

    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      int x,
      int y,
      int width,
      int height,
      int radius)
    {
      graphics.DrawRoundedRectangle(
        pen,
        Convert.ToSingle(x),
        Convert.ToSingle(y),
        Convert.ToSingle(width),
        Convert.ToSingle(height),
        Convert.ToSingle(radius));
    }

    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      Rectangle rectangle,
      int radius,
      RectangleEdgeFilter filter)
    {
      graphics.DrawRoundedRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, radius, filter);
    }

    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      Rectangle rectangle,
      int radius)
    {
      graphics.DrawRoundedRectangle(
        pen,
        rectangle.X,
        rectangle.Y,
        rectangle.Width,
        rectangle.Height,
        radius,
        RectangleEdgeFilter.All);
    }

    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      RectangleF rectangle,
      int radius,
      RectangleEdgeFilter filter)
    {
      graphics.DrawRoundedRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, radius, filter);
    }

    public static void DrawRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Pen pen,
      RectangleF rectangle,
      int radius)
    {
      graphics.DrawRoundedRectangle(
        pen,
        rectangle.X,
        rectangle.Y,
        rectangle.Width,
        rectangle.Height,
        radius,
        RectangleEdgeFilter.All);
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      float x,
      float y,
      float width,
      float height,
      float radius,
      RectangleEdgeFilter filter)
    {
      var rectangle = new RectangleF(x, y, width, height);
      var path = graphics.GenerateRoundedRectangle(rectangle, radius, filter);
      var old = graphics.SmoothingMode;
      graphics.SmoothingMode = SmoothingMode.AntiAlias;
      graphics.FillPath(brush, path);
      graphics.SmoothingMode = old;
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      float x,
      float y,
      float width,
      float height,
      float radius)
    {
      graphics.FillRoundedRectangle(brush, x, y, width, height, radius, RectangleEdgeFilter.All);
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      int x,
      int y,
      int width,
      int height,
      int radius)
    {
      graphics.FillRoundedRectangle(
        brush,
        Convert.ToSingle(x),
        Convert.ToSingle(y),
        Convert.ToSingle(width),
        Convert.ToSingle(height),
        Convert.ToSingle(radius));
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      Rectangle rectangle,
      int radius,
      RectangleEdgeFilter filter)
    {
      graphics.FillRoundedRectangle(brush, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, radius, filter);
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      Rectangle rectangle,
      int radius)
    {
      graphics.FillRoundedRectangle(
        brush,
        rectangle.X,
        rectangle.Y,
        rectangle.Width,
        rectangle.Height,
        radius,
        RectangleEdgeFilter.All);
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      RectangleF rectangle,
      int radius,
      RectangleEdgeFilter filter)
    {
      graphics.FillRoundedRectangle(brush, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, radius, filter);
    }

    public static void FillRoundedRectangle(
      this System.Drawing.Graphics graphics,
      Brush brush,
      RectangleF rectangle,
      int radius)
    {
      graphics.FillRoundedRectangle(
        brush,
        rectangle.X,
        rectangle.Y,
        rectangle.Width,
        rectangle.Height,
        radius,
        RectangleEdgeFilter.All);
    }

    public static FontMetrics GetFontMetrics(this System.Drawing.Graphics graphics, Font font)
    {
      return FontMetricsImpl.GetFontMetrics(graphics, font);
    }

    private static GraphicsPath GenerateCapsule(this System.Drawing.Graphics graphics, RectangleF rectangle)
    {
      float diameter;
      RectangleF arc;
      var path = new GraphicsPath();
      try
      {
        if (rectangle.Width > rectangle.Height)
        {
          diameter = rectangle.Height;
          var sizeF = new SizeF(diameter, diameter);
          arc = new RectangleF(rectangle.Location, sizeF);
          path.AddArc(arc, 90, 180);
          arc.X = rectangle.Right - diameter;
          path.AddArc(arc, 270, 180);
        }
        else if (rectangle.Width < rectangle.Height)
        {
          diameter = rectangle.Width;
          var sizeF = new SizeF(diameter, diameter);
          arc = new RectangleF(rectangle.Location, sizeF);
          path.AddArc(arc, 180, 180);
          arc.Y = rectangle.Bottom - diameter;
          path.AddArc(arc, 0, 180);
        }
        else
        {
          path.AddEllipse(rectangle);
        }
      }
      catch
      {
        path.AddEllipse(rectangle);
      }
      finally
      {
        path.CloseFigure();
      }

      return path;
    }

    private static GraphicsPath GenerateRoundedRectangle(
      this System.Drawing.Graphics graphics,
      RectangleF rectangle,
      float radius,
      RectangleEdgeFilter filter)
    {
      var path = new GraphicsPath();
      if (radius <= 0.0F || filter == RectangleEdgeFilter.None)
      {
        path.AddRectangle(rectangle);
        path.CloseFigure();
        return path;
      }

      if (radius >= Math.Min(rectangle.Width, rectangle.Height) / 2.0)
        return graphics.GenerateCapsule(rectangle);
      var diameter = radius * 2.0F;
      var sizeF = new SizeF(diameter, diameter);
      var arc = new RectangleF(rectangle.Location, sizeF);
      if ((RectangleEdgeFilter.TopLeft & filter) == RectangleEdgeFilter.TopLeft)
      {
        path.AddArc(arc, 180, 90);
      }
      else
      {
        path.AddLine(arc.X, arc.Y + arc.Height, arc.X, arc.Y);
        path.AddLine(arc.X, arc.Y, arc.X + arc.Width, arc.Y);
      }

      arc.X = rectangle.Right - diameter;
      if ((RectangleEdgeFilter.TopRight & filter) == RectangleEdgeFilter.TopRight)
      {
        path.AddArc(arc, 270, 90);
      }
      else
      {
        path.AddLine(arc.X, arc.Y, arc.X + arc.Width, arc.Y);
        path.AddLine(arc.X + arc.Width, arc.Y + arc.Height, arc.X + arc.Width, arc.Y);
      }

      arc.Y = rectangle.Bottom - diameter;
      if ((RectangleEdgeFilter.BottomRight & filter) == RectangleEdgeFilter.BottomRight)
      {
        path.AddArc(arc, 0, 90);
      }
      else
      {
        path.AddLine(arc.X + arc.Width, arc.Y, arc.X + arc.Width, arc.Y + arc.Height);
        path.AddLine(arc.X, arc.Y + arc.Height, arc.X + arc.Width, arc.Y + arc.Height);
      }

      arc.X = rectangle.Left;
      if ((RectangleEdgeFilter.BottomLeft & filter) == RectangleEdgeFilter.BottomLeft)
      {
        path.AddArc(arc, 90, 90);
      }
      else
      {
        path.AddLine(arc.X + arc.Width, arc.Y + arc.Height, arc.X, arc.Y + arc.Height);
        path.AddLine(arc.X, arc.Y + arc.Height, arc.X, arc.Y);
      }

      path.CloseFigure();
      return path;
    }

    private class FontMetricsImpl : FontMetrics
    {
      private readonly TEXTMETRIC metrics;

      private FontMetricsImpl(System.Drawing.Graphics graphics, Font font)
      {
        this.metrics = this.GenerateTextMetrics(graphics, font);
      }

      public override int Ascent => this.metrics.tmAscent;

      public override int AverageCharacterWidth => this.metrics.tmAveCharWidth;

      public override int Descent => this.metrics.tmDescent;

      public override int DigitizedAspectX => this.metrics.tmDigitizedAspectX;

      public override int DigitizedAspectY => this.metrics.tmDigitizedAspectY;

      public override int ExternalLeading => this.metrics.tmExternalLeading;

      public override int Height => this.metrics.tmHeight;

      public override int InternalLeading => this.metrics.tmInternalLeading;

      public override int MaximumCharacterWidth => this.metrics.tmMaxCharWidth;

      public override int Overhang => this.metrics.tmOverhang;

      public override int Weight => this.metrics.tmWeight;

      [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
      public static extern bool DeleteObject(IntPtr hdc);

      public static FontMetrics GetFontMetrics(System.Drawing.Graphics graphics, Font font)
      {
        return new FontMetricsImpl(graphics, font);
      }

      [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
      public static extern bool GetTextMetrics(IntPtr hdc, out TEXTMETRIC lptm);

      [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
      public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

      private TEXTMETRIC GenerateTextMetrics(System.Drawing.Graphics graphics, Font font)
      {
        var hDC = IntPtr.Zero;
        TEXTMETRIC textMetric;
        var hFont = IntPtr.Zero;
        try
        {
          hDC = graphics.GetHdc();
          hFont = font.ToHfont();
          var hFontDefault = SelectObject(hDC, hFont);
          var result = GetTextMetrics(hDC, out textMetric);
          SelectObject(hDC, hFontDefault);
        }
        finally
        {
          if (hFont != IntPtr.Zero) DeleteObject(hFont);
          if (hDC != IntPtr.Zero) graphics.ReleaseHdc(hDC);
        }

        return textMetric;
      }

      [StructLayout(LayoutKind.Sequential)]
      public struct TEXTMETRIC
      {
        public readonly int tmHeight;

        public readonly int tmAscent;

        public readonly int tmDescent;

        public readonly int tmInternalLeading;

        public readonly int tmExternalLeading;

        public readonly int tmAveCharWidth;

        public readonly int tmMaxCharWidth;

        public readonly int tmWeight;

        public readonly int tmOverhang;

        public readonly int tmDigitizedAspectX;

        public readonly int tmDigitizedAspectY;

        public readonly char tmFirstChar;

        public readonly char tmLastChar;

        public readonly char tmDefaultChar;

        public readonly char tmBreakChar;

        public readonly byte tmItalic;

        public readonly byte tmUnderlined;

        public readonly byte tmStruckOut;

        public readonly byte tmPitchAndFamily;

        public readonly byte tmCharSet;
      }
    }
  }
}