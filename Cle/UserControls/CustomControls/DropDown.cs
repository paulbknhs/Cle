namespace Cle.UserControls.CustomControls
{
  using System.ComponentModel;
  using System.Drawing.Design;
  using System.Drawing.Drawing2D;

  [DefaultEvent("OnSelectedIndexChanged")]
  public class DropDown : UserControl
  {
    private readonly Button btnIcon;

    private readonly ComboBox cmbList;

    private readonly Label lblText;

    private Color backColor = Color.WhiteSmoke;

    private Color borderColor = Color.MediumSlateBlue;

    private int borderSize = 1;

    private Color iconColor = Color.MediumSlateBlue;

    private Color listBackColor = Color.FromArgb(230, 228, 245);

    private Color listTextColor = Color.DimGray;

    public DropDown()
    {
      this.cmbList = new ComboBox();
      this.lblText = new Label();
      this.btnIcon = new Button();
      this.SuspendLayout();

      this.cmbList.BackColor = this.listBackColor;
      this.cmbList.Font = new Font(this.Font.Name, 10F);
      this.cmbList.ForeColor = this.listTextColor;
      this.cmbList.SelectedIndexChanged += this.ComboBox_SelectedIndexChanged;
      this.cmbList.TextChanged += this.ComboBox_TextChanged;
      this.btnIcon.Dock = DockStyle.Right;
      this.btnIcon.FlatStyle = FlatStyle.Flat;
      this.btnIcon.FlatAppearance.BorderSize = 0;
      this.btnIcon.BackColor = this.backColor;
      this.btnIcon.Size = new Size(30, 30);
      this.btnIcon.Cursor = Cursors.Hand;
      this.btnIcon.Click += this.Icon_Click;
      this.btnIcon.Paint += this.Icon_Paint;
      this.lblText.Dock = DockStyle.Fill;
      this.lblText.AutoSize = false;
      this.lblText.BackColor = this.backColor;
      this.lblText.TextAlign = ContentAlignment.MiddleLeft;
      this.lblText.Padding = new Padding(8, 0, 0, 0);
      this.lblText.Font = new Font(this.Font.Name, 10F);
      this.lblText.Click += this.Surface_Click;
      this.lblText.MouseEnter += this.Surface_MouseEnter;
      this.lblText.MouseLeave += this.Surface_MouseLeave;

      this.Controls.Add(this.lblText);
      this.Controls.Add(this.btnIcon);
      this.Controls.Add(this.cmbList);
      this.MinimumSize = new Size(200, 30);
      this.Size = new Size(200, 30);
      this.ForeColor = Color.DimGray;
      this.Padding = new Padding(this.borderSize);
      this.Font = new Font(this.Font.Name, 10F);
      base.BackColor = this.borderColor;
      this.ResumeLayout();
      this.AdjustComboBoxDimensions();
    }

    public event EventHandler OnSelectedIndexChanged;

    [Category("DropDown - Data")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor(
      "System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
      typeof(UITypeEditor))]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [Localizable(true)]
    public AutoCompleteStringCollection AutoCompleteCustomSource
    {
      get => this.cmbList.AutoCompleteCustomSource;
      set => this.cmbList.AutoCompleteCustomSource = value;
    }

    [Category("DropDown - Data")]
    [Browsable(true)]
    [DefaultValue(AutoCompleteMode.None)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public AutoCompleteMode AutoCompleteMode
    {
      get => this.cmbList.AutoCompleteMode;
      set => this.cmbList.AutoCompleteMode = value;
    }

    [Category("DropDown - Data")]
    [Browsable(true)]
    [DefaultValue(AutoCompleteSource.None)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public AutoCompleteSource AutoCompleteSource
    {
      get => this.cmbList.AutoCompleteSource;
      set => this.cmbList.AutoCompleteSource = value;
    }

    [Category("DropDown - Appearance")]
    public new Color BackColor
    {
      get => this.backColor;
      set
      {
        this.backColor = value;
        this.lblText.BackColor = this.backColor;
        this.btnIcon.BackColor = this.backColor;
      }
    }

    [Category("DropDown - Appearance")]
    public Color BorderColor
    {
      get => this.borderColor;
      set
      {
        this.borderColor = value;
        base.BackColor = this.borderColor;
      }
    }

    [Category("DropDown - Appearance")]
    public int BorderSize
    {
      get => this.borderSize;
      set
      {
        this.borderSize = value;
        this.Padding = new Padding(this.borderSize);
        this.AdjustComboBoxDimensions();
      }
    }

    [Category("DropDown - Data")]
    [AttributeProvider(typeof(IListSource))]
    [DefaultValue(null)]
    public object DataSource
    {
      get => this.cmbList.DataSource;
      set => this.cmbList.DataSource = value;
    }

    [Category("DropDown - Data")]
    [DefaultValue("")]
    [Editor(
      "System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
      typeof(UITypeEditor))]
    [TypeConverter(
      "System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string DisplayMember
    {
      get => this.cmbList.DisplayMember;
      set => this.cmbList.DisplayMember = value;
    }

    [Category("DropDown - Appearance")]
    public ComboBoxStyle DropDownStyle
    {
      get => this.cmbList.DropDownStyle;
      set
      {
        if (this.cmbList.DropDownStyle != ComboBoxStyle.Simple) this.cmbList.DropDownStyle = value;
      }
    }

    [Category("DropDown - Appearance")]
    public override Font Font
    {
      get => base.Font;
      set
      {
        base.Font = value;
        this.lblText.Font = value;
        this.cmbList.Font = value;
      }
    }

    [Category("DropDown - Appearance")]
    public override Color ForeColor
    {
      get => base.ForeColor;
      set
      {
        base.ForeColor = value;
        this.lblText.ForeColor = value;
      }
    }

    [Category("DropDown - Appearance")]
    public Color IconColor
    {
      get => this.iconColor;
      set
      {
        this.iconColor = value;
        this.btnIcon.Invalidate();
      }
    }

    [Category("DropDown - Data")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor(
      "System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
      typeof(UITypeEditor))]
    [Localizable(true)]
    [MergableProperty(false)]
    public ComboBox.ObjectCollection Items => this.cmbList.Items;

    [Category("DropDown - Appearance")]
    public Color ListBackColor
    {
      get => this.listBackColor;
      set
      {
        this.listBackColor = value;
        this.cmbList.BackColor = this.listBackColor;
      }
    }

    [Category("DropDown - Appearance")]
    public Color ListTextColor
    {
      get => this.listTextColor;
      set
      {
        this.listTextColor = value;
        this.cmbList.ForeColor = this.listTextColor;
      }
    }

    [Category("DropDown - Data")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex
    {
      get => this.cmbList.SelectedIndex;
      set => this.cmbList.SelectedIndex = value;
    }

    [Category("DropDown - Data")]
    [Bindable(true)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object SelectedItem
    {
      get => this.cmbList.SelectedItem;
      set => this.cmbList.SelectedItem = value;
    }

    [Category("DropDown - Appearance")]
    public string Texts
    {
      get => this.lblText.Text;
      set => this.lblText.Text = value;
    }

    [Category("DropDown - Data")]
    [DefaultValue("")]
    [Editor(
      "System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
      typeof(UITypeEditor))]
    public string ValueMember
    {
      get => this.cmbList.ValueMember;
      set => this.cmbList.ValueMember = value;
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      this.AdjustComboBoxDimensions();
    }

    private void AdjustComboBoxDimensions()
    {
      this.cmbList.Width = this.lblText.Width;
      this.cmbList.Location = new Point
      {
        X = this.Width - this.Padding.Right - this.cmbList.Width,
        Y = this.lblText.Bottom - this.cmbList.Height
      };
    }

    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.OnSelectedIndexChanged != null) this.OnSelectedIndexChanged.Invoke(sender, e);
      this.lblText.Text = this.cmbList.Text;
    }

    private void ComboBox_TextChanged(object sender, EventArgs e)
    {
      this.lblText.Text = this.cmbList.Text;
    }

    private void Icon_Click(object sender, EventArgs e)
    {
      this.cmbList.Select();
      this.cmbList.DroppedDown = true;
    }

    private void Icon_Paint(object sender, PaintEventArgs e)
    {
      var iconWidht = 14;
      var iconHeight = 6;
      var rectIcon = new Rectangle(
        (this.btnIcon.Width - iconWidht) / 2,
        (this.btnIcon.Height - iconHeight) / 2,
        iconWidht,
        iconHeight);
      var graph = e.Graphics;

      using (var path = new GraphicsPath())
      using (var pen = new Pen(this.iconColor, 2))
      {
        graph.SmoothingMode = SmoothingMode.AntiAlias;
        path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + iconWidht / 2, rectIcon.Bottom);
        path.AddLine(rectIcon.X + iconWidht / 2, rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
        graph.DrawPath(pen, path);
      }
    }

    private void Surface_Click(object sender, EventArgs e)
    {
      this.OnClick(e);
      this.cmbList.Select();
      if (this.cmbList.DropDownStyle == ComboBoxStyle.DropDownList) this.cmbList.DroppedDown = true;
    }

    private void Surface_MouseEnter(object sender, EventArgs e)
    {
      this.OnMouseEnter(e);
    }

    private void Surface_MouseLeave(object sender, EventArgs e)
    {
      this.OnMouseLeave(e);
    }
  }
}