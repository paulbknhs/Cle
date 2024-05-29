using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace CDMS_Lebensberatung.UserControls;

[DefaultEvent("OnSelectedIndexChanged")]
public class DropDown : UserControl
{
    private Color backColor = Color.WhiteSmoke;
    private Color iconColor = Color.MediumSlateBlue;
    private Color listBackColor = Color.FromArgb(230, 228, 245);
    private Color listTextColor = Color.DimGray;
    private Color borderColor = Color.MediumSlateBlue;
    private int borderSize = 1;

    private readonly ComboBox cmbList;
    private readonly Label lblText;
    private readonly Button btnIcon;

    public event EventHandler OnSelectedIndexChanged;

    public DropDown()
    {
        cmbList = new ComboBox();
        lblText = new Label();
        btnIcon = new Button();
        SuspendLayout();

        cmbList.BackColor = listBackColor;
        cmbList.Font = new Font(Font.Name, 10F);
        cmbList.ForeColor = listTextColor;
        cmbList.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        cmbList.TextChanged += ComboBox_TextChanged;
        btnIcon.Dock = DockStyle.Right;
        btnIcon.FlatStyle = FlatStyle.Flat;
        btnIcon.FlatAppearance.BorderSize = 0;
        btnIcon.BackColor = backColor;
        btnIcon.Size = new Size(30, 30);
        btnIcon.Cursor = Cursors.Hand;
        btnIcon.Click += Icon_Click;
        btnIcon.Paint += Icon_Paint;
        lblText.Dock = DockStyle.Fill;
        lblText.AutoSize = false;
        lblText.BackColor = backColor;
        lblText.TextAlign = ContentAlignment.MiddleLeft;
        lblText.Padding = new Padding(8, 0, 0, 0);
        lblText.Font = new Font(Font.Name, 10F);
        lblText.Click += Surface_Click;
        lblText.MouseEnter += Surface_MouseEnter;
        lblText.MouseLeave += Surface_MouseLeave;

        Controls.Add(lblText);
        Controls.Add(btnIcon);
        Controls.Add(cmbList);
        MinimumSize = new Size(200, 30);
        Size = new Size(200, 30);
        ForeColor = Color.DimGray;
        Padding = new Padding(borderSize);
        Font = new Font(Font.Name, 10F);
        base.BackColor = borderColor;
        ResumeLayout();
        AdjustComboBoxDimensions();
    }

    [Category("DropDown - Appearance")]
    public new Color BackColor
    {
        get => backColor;
        set
        {
            backColor = value;
            lblText.BackColor = backColor;
            btnIcon.BackColor = backColor;
        }
    }

    [Category("DropDown - Appearance")]
    public Color IconColor
    {
        get => iconColor;
        set
        {
            iconColor = value;
            btnIcon.Invalidate();
        }
    }

    [Category("DropDown - Appearance")]
    public Color ListBackColor
    {
        get => listBackColor;
        set
        {
            listBackColor = value;
            cmbList.BackColor = listBackColor;
        }
    }

    [Category("DropDown - Appearance")]
    public Color ListTextColor
    {
        get => listTextColor;
        set
        {
            listTextColor = value;
            cmbList.ForeColor = listTextColor;
        }
    }

    [Category("DropDown - Appearance")]
    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            base.BackColor = borderColor;
        }
    }

    [Category("DropDown - Appearance")]
    public int BorderSize
    {
        get => borderSize;
        set
        {
            borderSize = value;
            Padding = new Padding(borderSize);
            AdjustComboBoxDimensions();
        }
    }

    [Category("DropDown - Appearance")]
    public override Color ForeColor
    {
        get => base.ForeColor;
        set
        {
            base.ForeColor = value;
            lblText.ForeColor = value;
        }
    }

    [Category("DropDown - Appearance")]
    public override Font Font
    {
        get => base.Font;
        set
        {
            base.Font = value;
            lblText.Font = value;
            cmbList.Font = value;
        }
    }

    [Category("DropDown - Appearance")]
    public string Texts
    {
        get => lblText.Text;
        set => lblText.Text = value;
    }

    [Category("DropDown - Appearance")]
    public ComboBoxStyle DropDownStyle
    {
        get => cmbList.DropDownStyle;
        set
        {
            if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                cmbList.DropDownStyle = value;
        }
    }

    [Category("DropDown - Data")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor(
        "System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
        typeof(UITypeEditor)
    )]
    [Localizable(true)]
    [MergableProperty(false)]
    public ComboBox.ObjectCollection Items => cmbList.Items;

    [Category("DropDown - Data")]
    [AttributeProvider(typeof(IListSource))]
    [DefaultValue(null)]
    public object DataSource
    {
        get => cmbList.DataSource;
        set => cmbList.DataSource = value;
    }

    [Category("DropDown - Data")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor(
        "System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
        typeof(UITypeEditor)
    )]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [Localizable(true)]
    public AutoCompleteStringCollection AutoCompleteCustomSource
    {
        get => cmbList.AutoCompleteCustomSource;
        set => cmbList.AutoCompleteCustomSource = value;
    }

    [Category("DropDown - Data")]
    [Browsable(true)]
    [DefaultValue(AutoCompleteSource.None)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public AutoCompleteSource AutoCompleteSource
    {
        get => cmbList.AutoCompleteSource;
        set => cmbList.AutoCompleteSource = value;
    }

    [Category("DropDown - Data")]
    [Browsable(true)]
    [DefaultValue(AutoCompleteMode.None)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public AutoCompleteMode AutoCompleteMode
    {
        get => cmbList.AutoCompleteMode;
        set => cmbList.AutoCompleteMode = value;
    }

    [Category("DropDown - Data")]
    [Bindable(true)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object SelectedItem
    {
        get => cmbList.SelectedItem;
        set => cmbList.SelectedItem = value;
    }

    [Category("DropDown - Data")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex
    {
        get => cmbList.SelectedIndex;
        set => cmbList.SelectedIndex = value;
    }

    [Category("DropDown - Data")]
    [DefaultValue("")]
    [Editor(
        "System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
        typeof(UITypeEditor)
    )]
    [TypeConverter(
        "System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    )]
    public string DisplayMember
    {
        get => cmbList.DisplayMember;
        set => cmbList.DisplayMember = value;
    }

    [Category("DropDown - Data")]
    [DefaultValue("")]
    [Editor(
        "System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
        typeof(UITypeEditor)
    )]
    public string ValueMember
    {
        get => cmbList.ValueMember;
        set => cmbList.ValueMember = value;
    }

    private void AdjustComboBoxDimensions()
    {
        cmbList.Width = lblText.Width;
        cmbList.Location = new Point
        {
            X = Width - Padding.Right - cmbList.Width,
            Y = lblText.Bottom - cmbList.Height
        };
    }


    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (OnSelectedIndexChanged != null)
            OnSelectedIndexChanged.Invoke(sender, e);
        lblText.Text = cmbList.Text;
    }

    private void Icon_Paint(object sender, PaintEventArgs e)
    {
        var iconWidht = 14;
        var iconHeight = 6;
        var rectIcon = new Rectangle(
            (btnIcon.Width - iconWidht) / 2,
            (btnIcon.Height - iconHeight) / 2,
            iconWidht,
            iconHeight
        );
        var graph = e.Graphics;

        using (var path = new GraphicsPath())
        using (var pen = new Pen(iconColor, 2))
        {
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + iconWidht / 2, rectIcon.Bottom);
            path.AddLine(
                rectIcon.X + iconWidht / 2,
                rectIcon.Bottom,
                rectIcon.Right,
                rectIcon.Y
            );
            graph.DrawPath(pen, path);
        }
    }

    private void Icon_Click(object sender, EventArgs e)
    {
        cmbList.Select();
        cmbList.DroppedDown = true;
    }

    private void Surface_Click(object sender, EventArgs e)
    {
        OnClick(e);
        cmbList.Select();
        if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
            cmbList.DroppedDown = true;
    }

    private void ComboBox_TextChanged(object sender, EventArgs e)
    {
        lblText.Text = cmbList.Text;
    }

    private void Surface_MouseLeave(object sender, EventArgs e)
    {
        OnMouseLeave(e);
    }

    private void Surface_MouseEnter(object sender, EventArgs e)
    {
        OnMouseEnter(e);
    }


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustComboBoxDimensions();
    }
}