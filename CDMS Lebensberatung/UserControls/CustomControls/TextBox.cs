using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CDMS_Lebensberatung.UserControls;

[DefaultEvent("_TextChanged")]
public partial class RJTextBox : UserControl
{
    #region -> Fields

    private Color borderColor = Color.MediumSlateBlue;
    private int borderSize = 2;
    private bool underlinedStyle;
    private bool isFocused;

    private int borderRadius;
    private Color placeholderColor = Color.DarkGray;
    private string placeholderText = "";
    private bool isPlaceholder;
    private bool isPasswordChar;

    public event EventHandler _TextChanged;

    #endregion

    public RJTextBox()
    {
        InitializeComponent();
    }

    #region -> Properties

    [Category("RJ Code Advance")]
    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            Invalidate();
        }
    }

    [Category("RJ Code Advance")] public Color BorderFocusColor { get; set; } = Color.HotPink;

    [Category("RJ Code Advance")]
    public int BorderSize
    {
        get => borderSize;
        set
        {
            if (value >= 1)
            {
                borderSize = value;
                Invalidate();
            }
        }
    }

    [Category("RJ Code Advance")]
    public bool UnderlinedStyle
    {
        get => underlinedStyle;
        set
        {
            underlinedStyle = value;
            Invalidate();
        }
    }

    [Category("RJ Code Advance")]
    public bool PasswordChar
    {
        get => isPasswordChar;
        set
        {
            isPasswordChar = value;
            if (!isPlaceholder)
                textBox1.UseSystemPasswordChar = value;
        }
    }

    [Category("RJ Code Advance")]
    public bool Multiline
    {
        get => textBox1.Multiline;
        set => textBox1.Multiline = value;
    }

    [Category("RJ Code Advance")]
    public override Color BackColor
    {
        get => base.BackColor;
        set
        {
            base.BackColor = value;
            textBox1.BackColor = value;
        }
    }

    [Category("RJ Code Advance")]
    public override Color ForeColor
    {
        get => base.ForeColor;
        set
        {
            base.ForeColor = value;
            textBox1.ForeColor = value;
        }
    }

    [Category("RJ Code Advance")]
    public override Font Font
    {
        get => base.Font;
        set
        {
            base.Font = value;
            textBox1.Font = value;
            if (DesignMode)
                UpdateControlHeight();
        }
    }

    [Category("RJ Code Advance")]
    public string Texts
    {
        get
        {
            return isPlaceholder ? "" : textBox1.Text;
        }
        set
        {
            textBox1.Text = value;
            SetPlaceholder();
        }
    }

    [Category("RJ Code Advance")]
    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            if (value >= 0)
            {
                borderRadius = value;
                Invalidate();
            }
        }
    }

    [Category("RJ Code Advance")]
    public Color PlaceholderColor
    {
        get => placeholderColor;
        set
        {
            placeholderColor = value;
            if (isPlaceholder)
                textBox1.ForeColor = value;
        }
    }

    [Category("RJ Code Advance")]
    public string PlaceholderText
    {
        get => placeholderText;
        set
        {
            placeholderText = value;
            textBox1.Text = "";
            SetPlaceholder();
        }
    }

    #endregion

    #region -> Overridden methods

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (DesignMode)
            UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        UpdateControlHeight();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var graph = e.Graphics;

        if (borderRadius > 1)
        {
            var rectBorderSmooth = ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize : 1;

            using (var pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
            using (var pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (var penBorderSmooth = new Pen(Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderColor, borderSize))
            {
                Region = new Region(pathBorderSmooth);
                if (borderRadius > 15) SetTextBoxRoundedRegion();
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = PenAlignment.Center;
                if (isFocused) penBorder.Color = BorderFocusColor;

                if (underlinedStyle)
                {
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
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
            using (var penBorder = new Pen(borderColor, borderSize))
            {
                Region = new Region(ClientRectangle);
                penBorder.Alignment = PenAlignment.Inset;
                if (isFocused) penBorder.Color = BorderFocusColor;

                if (underlinedStyle) graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                else graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
            }
        }
    }

    #endregion

    #region -> Private methods

    private void SetPlaceholder()
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
        {
            isPlaceholder = true;
            textBox1.Text = placeholderText;
            textBox1.ForeColor = placeholderColor;
            if (isPasswordChar)
                textBox1.UseSystemPasswordChar = false;
        }
    }

    private void RemovePlaceholder()
    {
        if (isPlaceholder && placeholderText != "")
        {
            isPlaceholder = false;
            textBox1.Text = "";
            textBox1.ForeColor = ForeColor;
            if (isPasswordChar)
                textBox1.UseSystemPasswordChar = true;
        }
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

    private void SetTextBoxRoundedRegion()
    {
        GraphicsPath pathTxt;
        if (Multiline)
        {
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
            textBox1.Region = new Region(pathTxt);
        }
        else
        {
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
            textBox1.Region = new Region(pathTxt);
        }

        pathTxt.Dispose();
    }

    private void UpdateControlHeight()
    {
        if (textBox1.Multiline == false)
        {
            var txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
            textBox1.Multiline = true;
            textBox1.MinimumSize = new Size(0, txtHeight);
            textBox1.Multiline = false;

            Height = textBox1.Height + Padding.Top + Padding.Bottom;
        }
    }

    #endregion

    #region -> TextBox events

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (_TextChanged != null)
            _TextChanged.Invoke(sender, e);
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
        OnClick(e);
    }

    private void textBox1_MouseEnter(object sender, EventArgs e)
    {
        OnMouseEnter(e);
    }

    private void textBox1_MouseLeave(object sender, EventArgs e)
    {
        OnMouseLeave(e);
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        OnKeyPress(e);
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
        isFocused = true;
        Invalidate();
        RemovePlaceholder();
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
        isFocused = false;
        Invalidate();
        SetPlaceholder();
    }

    #endregion
}