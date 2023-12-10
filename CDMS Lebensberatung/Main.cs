using CDMS_Lebensberatung.UserControls;

namespace CDMS_Lebensberatung;

public partial class Home : Form
{ 
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
            e.Graphics.FillRectangle(Brushes.MediumTurquoise, new Rectangle(0, 0, 5, btn.Height));
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

    private void OnHomeLoad(object sender, EventArgs e)
    {
        var frameSettings = new FrameSettings();
        frameSettings.Location = new Point(200, 0);
        frameSettings.Name = "frameSettings";
        Controls.Add(frameSettings);
        frameSettings.Visible = false;

        var frameAddNew = new FrameAddNew();
        frameAddNew.Location = new Point(200, 0);
        frameAddNew.Name = "frameAddNew";
        Controls.Add(frameAddNew);
        frameAddNew.Visible = false;

        var frameShowTable = new FrameShowTable();
        frameShowTable.Location = new Point(200, 0);
        frameShowTable.Name = "frameShowTable";
        Controls.Add(frameShowTable);
        frameShowTable.Visible = false;
        
        var frameStatistics = new FrameStatistics();
        frameStatistics.Location = new Point(200, 0);
        frameStatistics.Name = "frameStatistics";
        Controls.Add(frameStatistics);
        frameStatistics.Visible = false;

        var frameHome = new FrameHome();
        frameHome.Location = new Point(200, 0);
        frameHome.Name = "frameHome";
        Controls.Add(frameHome);
        frameHome.Visible = true;

        SelectNavigation(HomeButton);
    }

    private void OnClickOnNavigation(object sender, EventArgs e)
    {
        var btn = (Button)sender;
        SelectNavigation(btn);

        foreach (var control in Controls)
        {
            if (control is not UserControl userControl) continue;
            userControl.Visible = false;
        }

        switch (btn.Name)
        {
            case "HomeButton":
                Controls.Find("frameHome", true)[0].Visible = true;
                break;

            case "AddButton":
                Controls.Find("frameAddNew", true)[0].Visible = true;
                break;

            case "SearchButton":
                Controls.Find("frameShowTable", true)[0].Visible = true;
                break;

            case "ExportButton":
                Controls.Find("frameStatistics", true)[0].Visible = true;
                break;

            case "SettingsButton":
                Controls.Find("frameSettings", true)[0].Visible = true;
                break;
                
        }
    }
}
