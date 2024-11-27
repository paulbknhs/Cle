namespace Cle.UserControls.CustomControls
{
  using System.ComponentModel;
  using System.Drawing.Drawing2D;

  [DefaultEvent("_TextChanged")]
  public partial class RJTextBox : UserControl
  {
    private Color borderColor = Color.MediumSlateBlue;

    private int borderRadius;

    private int borderSize = 2;

    private bool isFocused;

    private bool isPasswordChar;

    private bool isPlaceholder;

    private Color placeholderColor = Color.DarkGray;

    private string placeholderText = string.Empty;

    private bool underlinedStyle;

    public RJTextBox()
    {
      this.InitializeComponent();
    }

    public event EventHandler _TextChanged;

    [Category("RJ Code Advance")]
    public override Color BackColor
    {
      get => base.BackColor;
      set
      {
        base.BackColor = value;
        this.textBox1.BackColor = value;
      }
    }

    [Category("RJ Code Advance")]
    public Color BorderColor
    {
      get => this.borderColor;
      set
      {
        this.borderColor = value;
        this.Invalidate();
      }
    }

    [Category("RJ Code Advance")]
    public Color BorderFocusColor { get; set; } = Color.HotPink;

    [Category("RJ Code Advance")]
    public int BorderRadius
    {
      get => this.borderRadius;
      set
      {
        if (value >= 0)
        {
          this.borderRadius = value;
          this.Invalidate();
        }
      }
    }

    [Category("RJ Code Advance")]
    public int BorderSize
    {
      get => this.borderSize;
      set
      {
        if (value >= 1)
        {
          this.borderSize = value;
          this.Invalidate();
        }
      }
    }

    [Category("RJ Code Advance")]
    public override Font Font
    {
      get => base.Font;
      set
      {
        base.Font = value;
        this.textBox1.Font = value;
        if (this.DesignMode) this.UpdateControlHeight();
      }
    }

    [Category("RJ Code Advance")]
    public override Color ForeColor
    {
      get => base.ForeColor;
      set
      {
        base.ForeColor = value;
        this.textBox1.ForeColor = value;
      }
    }

    [Category("RJ Code Advance")]
    public bool Multiline
    {
      get => this.textBox1.Multiline;
      set => this.textBox1.Multiline = value;
    }

    [Category("RJ Code Advance")]
    public bool PasswordChar
    {
      get => this.isPasswordChar;
      set
      {
        this.isPasswordChar = value;
        if (!this.isPlaceholder) this.textBox1.UseSystemPasswordChar = value;
      }
    }

    [Category("RJ Code Advance")]
    public Color PlaceholderColor
    {
      get => this.placeholderColor;
      set
      {
        this.placeholderColor = value;
        if (this.isPlaceholder) this.textBox1.ForeColor = value;
      }
    }

    [Category("RJ Code Advance")]
    public string PlaceholderText
    {
      get => this.placeholderText;
      set
      {
        this.placeholderText = value;
        this.textBox1.Text = string.Empty;
        this.SetPlaceholder();
      }
    }

    [Category("RJ Code Advance")]
    public string Texts
    {
      get => this.isPlaceholder ? string.Empty : this.textBox1.Text;
      set
      {
        this.textBox1.Text = value;
        this.SetPlaceholder();
      }
    }

    [Category("RJ Code Advance")]
    public bool UnderlinedStyle
    {
      get => this.underlinedStyle;
      set
      {
        this.underlinedStyle = value;
        this.Invalidate();
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      this.UpdateControlHeight();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      var graph = e.Graphics;

      if (this.borderRadius > 1)
      {
        var rectBorderSmooth = this.ClientRectangle;
        var rectBorder = Rectangle.Inflate(rectBorderSmooth, -this.borderSize, -this.borderSize);
        var smoothSize = this.borderSize > 0 ? this.borderSize : 1;

        using (var pathBorderSmooth = this.GetFigurePath(rectBorderSmooth, this.borderRadius))
        using (var pathBorder = this.GetFigurePath(rectBorder, this.borderRadius - this.borderSize))
        using (var penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
        using (var penBorder = new Pen(this.borderColor, this.borderSize))
        {
          this.Region = new Region(pathBorderSmooth);
          if (this.borderRadius > 15) this.SetTextBoxRoundedRegion();
          graph.SmoothingMode = SmoothingMode.AntiAlias;
          penBorder.Alignment = PenAlignment.Center;
          if (this.isFocused) penBorder.Color = this.BorderFocusColor;

          if (this.underlinedStyle)
          {
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
            graph.SmoothingMode = SmoothingMode.None;
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          }
          else
          {
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
            graph.DrawPath(penBorder, pathBorder);
          }
        }
      }
      else
      {
        using (var penBorder = new Pen(this.borderColor, this.borderSize))
        {
          this.Region = new Region(this.ClientRectangle);
          penBorder.Alignment = PenAlignment.Inset;
          if (this.isFocused) penBorder.Color = this.BorderFocusColor;

          if (this.underlinedStyle) graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          else graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      if (this.DesignMode) this.UpdateControlHeight();
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
      var path = new GraphicsPath();
      var curveSize = radius * 2F;

      path.StartFigure();
      path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
      path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
      path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
      path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
      path.CloseFigure();
      return path;
    }

    private void RemovePlaceholder()
    {
      if (this.isPlaceholder && this.placeholderText != string.Empty)
      {
        this.isPlaceholder = false;
        this.textBox1.Text = string.Empty;
        this.textBox1.ForeColor = this.ForeColor;
        if (this.isPasswordChar) this.textBox1.UseSystemPasswordChar = true;
      }
    }

    private void SetPlaceholder()
    {
      if (string.IsNullOrWhiteSpace(this.textBox1.Text) && this.placeholderText != string.Empty)
      {
        this.isPlaceholder = true;
        this.textBox1.Text = this.placeholderText;
        this.textBox1.ForeColor = this.placeholderColor;
        if (this.isPasswordChar) this.textBox1.UseSystemPasswordChar = false;
      }
    }

    private void SetTextBoxRoundedRegion()
    {
      GraphicsPath pathTxt;
      if (this.Multiline)
      {
        pathTxt = this.GetFigurePath(this.textBox1.ClientRectangle, this.borderRadius - this.borderSize);
        this.textBox1.Region = new Region(pathTxt);
      }
      else
      {
        pathTxt = this.GetFigurePath(this.textBox1.ClientRectangle, this.borderSize * 2);
        this.textBox1.Region = new Region(pathTxt);
      }

      pathTxt.Dispose();
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
      this.OnClick(e);
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
      this.isFocused = true;
      this.Invalidate();
      this.RemovePlaceholder();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.OnKeyPress(e);
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      this.isFocused = false;
      this.Invalidate();
      this.SetPlaceholder();
    }

    private void textBox1_MouseEnter(object sender, EventArgs e)
    {
      this.OnMouseEnter(e);
    }

    private void textBox1_MouseLeave(object sender, EventArgs e)
    {
      this.OnMouseLeave(e);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (this._TextChanged != null) this._TextChanged.Invoke(sender, e);
    }

    private void UpdateControlHeight()
    {
      if (this.textBox1.Multiline == false)
      {
        var txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
        this.textBox1.Multiline = true;
        this.textBox1.MinimumSize = new Size(0, txtHeight);
        this.textBox1.Multiline = false;

        this.Height = this.textBox1.Height + this.Padding.Top + this.Padding.Bottom;
      }
    }
  }
}