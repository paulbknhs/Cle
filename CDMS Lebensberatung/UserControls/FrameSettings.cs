using System.Configuration;
using CDMS_Lebensberatung.cs;

namespace CDMS_Lebensberatung.UserControls;

public partial class FrameSettings : UserControl
{
    public static string? CurrentConnectionString { get; set; }
    public static string? CurrentExportPath { get; set; }

    public FrameSettings()
    {
        InitializeComponent();
    }

    private void OnFrameLoad(object sender, EventArgs e)
    {
        CurrentConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        Reload();
    }

    public void Reload()
    {
        tbConnectionString.Texts = ConfigurationManager.AppSettings.Get("ConnectionString");
        tbConnectionString.BorderColor = Color.Green;
        tbConnectionString.BorderFocusColor = Color.Green;

        tbServiceName.Texts = ConfigurationManager.AppSettings.Get("ServiceName");
        tbServiceName.BorderColor = Color.Green;
        tbServiceName.BorderFocusColor = Color.Green;
    }

    private void OnSaveConfig(object sender, EventArgs e)
    {
        ConfigurationManager.AppSettings.Set("ConnectionString", tbConnectionString.Texts);
        ConfigurationManager.AppSettings.Set("DefaultPath", tbDefaultPath.Texts);
        ConfigurationManager.AppSettings.Set("ServiceName", tbServiceName.Texts);

        Reload();
    }

    private void OnOpenFolder(object sender, EventArgs e)
    {
        if (dialogueDefaultFolder.ShowDialog() != DialogResult.OK) return;
        var path = dialogueDefaultFolder.SelectedPath;
        tbDefaultPath.Texts = path;
    }

    private void OnCsChanged(object sender, EventArgs e)
    {
        var tb = tbConnectionString;
        if (tb.Texts != ConfigurationManager.AppSettings.Get(tb.Name[..2]))
        {
            tb.BorderColor = Color.IndianRed;
            tb.BorderFocusColor = Color.IndianRed;
        }
        else
        {
            tb.BorderColor = Color.Green;
            tb.BorderFocusColor = Color.Green;
        }
    }

    private void OnSnChanged(object sender, EventArgs e)
    {
        var tb = tbServiceName;
        if (tb.Texts != ConfigurationManager.AppSettings.Get(tb.Name[..2]))
        {
            tb.BorderColor = Color.IndianRed;
            tb.BorderFocusColor = Color.IndianRed;
        }
        else
        {
            tb.BorderColor = Color.Green;
            tb.BorderFocusColor = Color.Green;
        }
    }

    private void OnDpChanged(object sender, EventArgs e)
    {
        var tb = tbDefaultPath;
        if (tb.Texts != ConfigurationManager.AppSettings.Get(tb.Name[..2]))
        {
            tb.BorderColor = Color.IndianRed;
            tb.BorderFocusColor = Color.IndianRed;
        }
        else
        {
            tb.BorderColor = Color.Green;
            tb.BorderFocusColor = Color.Green;
        }
    }
}