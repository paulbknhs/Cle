using System.Data;
using System.ServiceProcess;
using System.Text;
using Cle.Classes;

namespace Cle.UserControls.Views;

public partial class FrameStatistics : UserControl
{
    private const string ConnectionString =
        "Data Source=\"localhost\\SQLEXPRESS\"; Initial Catalog=active_db; Integrated Security=True; TrustServerCertificate=True";

    public FrameStatistics()
    {
        InitializeComponent();
        UpdateGrid();
    }

    public static List<int> CollectAgesUnfiltered()
    {
        SQL db = new();
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        return Statistics.TabelleZuListeAlter(dataTable);
    }

    public List<int> CollectAgesFiltered()
    {
        List<string> filters = new();

        foreach (var box in CollectionCheckedBoxes())
            switch (box.Name)
            {
                case "cbNeu":
                    filters.Add("Jahr = '2023'");
                    break;
                case "cb1Jahr":
                    filters.Add("Jahr = '2022'");
                    break;
                case "cb2Jahr":
                    filters.Add("Jahr = '2021'");
                    break;

                case "cbAllg":
                    filters.Add("Beratungsart = 'Allgem. LB'");
                    break;
                case "cbSGB8":
                    filters.Add("Beratungsart = 'SGB VIII'");
                    break;
                case "cbSchwanger":
                    filters.Add("Beratungsart = 'MuKi + allgem. Sgs'");
                    filters.Add("Beratungsart = 'Beratung n. pränatal'");
                    break;
                case "cb218":
                    filters.Add("Beratungsart = '§218'");
                    break;
                case "cbRA":
                    filters.Add("Beratungsart = 'RA'");
                    break;

                case "cbBurgwedel":
                    filters.Add("Wohnort = 'Burgwedel'");
                    break;
                case "cbWedemark":
                    filters.Add("Wohnort = 'Wedemark'");
                    break;
                case "cbIsernhagen":
                    filters.Add("Wohnort = 'Isernhagen'");
                    break;

                case "cbMale":
                    filters.Add("Gender = 'male'");
                    break;
                case "cbFemale":
                    filters.Add("Gender = 'female'");
                    break;
                case "cbNonBin":
                    filters.Add("Gender = 'nonbinary'");
                    break;
            }

        if (filters.Count == 0)
            return CollectAgesUnfiltered();

        StringBuilder query = new();

        query.Append("SELECT * FROM Allgemein WHERE ");

        for (var i = 0; i < filters.Count; i++)
        {
            if (i > 0)
            {
                if (filters[i - 1].StartsWith("Jahr") && filters[i].StartsWith("Jahr"))
                    query.Append(" OR ");
                else if (
                    filters[i - 1].StartsWith("Beratungsart")
                    && filters[i].StartsWith("Beratungsart")
                )
                    query.Append(" OR ");
                else if (filters[i - 1].StartsWith("Wohnort") && filters[i].StartsWith("Wohnort"))
                    query.Append(" OR ");
                else
                    query.Append(" AND ");
            }

            query.Append(filters[i]);
        }

        SQL db = new();
        db.Connect();
        var dataTable = db.SendQuery(query.ToString());
        db.Disconnect();

        return Statistics.TabelleZuListeAlter(dataTable);
    }

    public List<CheckBox> CollectionCheckedBoxes()
    {
        List<CheckBox> boxes = new();

        foreach (Control control in filterPanel.Controls)
        {
            if (control is not GroupBox)
                continue;

            foreach (Control box in control.Controls)
            {
                if (box is not CheckBox checkbox)
                    continue;
                if (checkbox.Checked)
                    boxes.Add(checkbox);
            }
        }

        return boxes;
    }

    public void UpdateGrid()
    {
        gridAge.DataSource = Statistics.ListeZuTabelle(CollectAgesUnfiltered());
    }

    private static bool IsServiceRunning()
    {
        var sc = new ServiceController(ConnectionString);
        return sc.Status == ServiceControllerStatus.Running;
    }

    private void OnLoad(object sender, EventArgs e)
    {
        if (IsServiceRunning()) UpdateGrid();

        for (var i = 0; i < checkListStats.Items.Count; i++) checkListStats.SetItemChecked(i, true);
    }


    private void OnCheckedChanged(object sender, EventArgs e)
    {
        gridAge.DataSource = Statistics.ListeZuTabelle(CollectAgesFiltered());
    }

    private void OnButtonExport(object sender, EventArgs e)
    {
        var tableList = new List<DataTable>();
        var checkedList = (from object? item in checkListStats.CheckedItems select item.ToString()).ToList();


        if (checkedList.Contains("Neuanmeldungen nach Beratungsart")) tableList.Add(Statistics.BeratungAlsNeu());
        if (checkedList.Contains("Fortführungen nach Beratungsart")) tableList.Add(Statistics.BeratungAlsAlt());
        if (checkedList.Contains("Gesamt nach Beratungsart")) tableList.Add(Statistics.Beratung());
        if (checkedList.Contains("Gesamt nach Ort")) tableList.Add(Statistics.Wohnort());
        if (checkedList.Contains("Anmeldegründe LB")) tableList.Add(Statistics.GründeFürEheUndLeben());
        if (checkedList.Contains("Anmeldegründe SGB VIII")) tableList.Add(Statistics.GründeFürErziehung());
        if (checkedList.Contains("Art der Beratung für Schwangere"))
            tableList.Add(Statistics.SchwangerschaftAufteilung());
    }
}