using System.Configuration;
using System.Diagnostics;
using System.ServiceProcess;
using CDMS_Lebensberatung.cs;
using static System.DateTime;

namespace CDMS_Lebensberatung.UserControls;

public partial class FrameHome : UserControl
{
    public string serviceName = ConfigurationManager.AppSettings.Get("ServiceName");

    public FrameHome()
    {
        InitializeComponent();
    }

    private void OnFrameLoad(object sender, EventArgs e)
    {
        var name = Environment.UserName;
        if (name == "ubak") name = "Ute";
        var wochentag = Lists.Wochentage[(int)Now.DayOfWeek];

        labelHallo.Text = $"Hallo {name}!";

        labelDatum.Text = $"{wochentag}, {Now.Day}.{Now.Month}.{Now.Year}";

        if (IsServiceRunning(serviceName))
        {
            serverState.Text = "Gestartet";
            serverState.ForeColor = Color.Green;
        }
        else
        {
            serverState.Text = "Gestoppt";
            serverState.ForeColor = Color.IndianRed;
        }
    }

    private static bool IsServiceRunning(string serviceName)
    {
        var sc = new ServiceController(serviceName);
        return sc.Status == ServiceControllerStatus.Running;
    }
}