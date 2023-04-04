using System.Runtime.InteropServices;
using CDMS_Lebensberatung.UserControls;

namespace CDMS_Lebensberatung;

public partial class Home : Form
{
    #region Form Dragging
    private const int WmNclbuttondown = 0xA1;
    private const int HtCaption = 0x2;
    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();
    private void OnControlStrip(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
            return;
        ReleaseCapture();
        _ = SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
    }
    #endregion

    public Home()
    {
        InitializeComponent();
        
    }

    #region Highlight Navigation

    private void SelectNavigation(object selection)
    {
        var selectedButton = (Button)selection;
        foreach (Control control in NavigationBar.Controls)
        {
            if (control is not Button b || b.Tag == null)
                continue;
            b.Tag = null;
            b.Invalidate();
        }

        selectedButton.Tag = "selected";
        selectedButton.Invalidate();
    }

    private void OnNavigationPaint(object sender, PaintEventArgs e)
    {
        var btn = (Button)sender;
        if (ReferenceEquals(btn.Tag, "selected"))
        {
            e.Graphics.FillRectangle(Brushes.Green, new Rectangle(0, 0, 5, btn.Height));
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.ForeColor = Color.Black;
        }
        else
        {
            btn.Font = new Font(btn.Font, FontStyle.Regular);
            btn.ForeColor = Color.FromArgb(40, 40, 40);
        }
    }

    #endregion


    private void OnButtonClose(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void OnHomeButton(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
            if (control is UserControl)
                Controls.Remove(control);

        var frameHome = new FrameHome() { Location = new Point(200, 30) };
        Controls.Add(frameHome);

        SelectNavigation(sender);
    }

    private void OnAddButton(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        foreach (Control control in Controls)
            if (control is UserControl)
                Controls.Remove(control);

        var frameAddNew = new FrameAddNew();
        var tempPanel = new Panel
        {
            Size = new Size(1080, 690),
            Location = new Point(200, 30),
            BackColor = Color.FromArgb(255, 255, 255)
        };

        frameAddNew.Location = new Point(200, 30);
        Controls.Add(tempPanel);
        Controls.Add(frameAddNew);
        Controls.Remove(tempPanel);
    }

    private void OnSearchButton(object sender, EventArgs e)
    {
        var frameShowTable = new FrameShowTable { Location = new Point(200, 30) };
        foreach (Control control in Controls)
            if (control is UserControl)
                Controls.Remove(control);

        Controls.Add(frameShowTable);

        SelectNavigation(sender);
    }

    private void OnExportButton(object sender, EventArgs e)
    {
        var frameStatistics = new FrameStatistics { Location = new Point(200, 30) };
        foreach (Control control in Controls)
            if (control is UserControl)
                Controls.Remove(control);

        Controls.Add(frameStatistics);
        SelectNavigation(sender);
    }

    private void OnSettingsButton(object sender, EventArgs e)
    {
        var frameSettings = new FrameSettings { Location = new Point(200, 30) };
        foreach (Control control in Controls)
            if (control is UserControl)
                Controls.Remove(control);

        Controls.Add(frameSettings);
        SelectNavigation(sender);
    }

    private void OnHomeLoad(object sender, EventArgs e)
    {
        OnHomeButton(new Button(), new EventArgs());
    }
}
