using CregForm.Resources.classes;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using DB = CregForm.Resources.classes.DatabaseHelper;

namespace CregForm.Views;

public partial class StatisticsView : UserControl
{
    public StatisticsView()
    {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e) { }

    public Dictionary<int, int> gesamtAlter = new();
    public Dictionary<int, int> neuAlter = new();
    public Dictionary<string, string> filter = new() { { "Wiederanmeldung", "Neu" } };
    public Dictionary<int, string> personDict =
        new()
        {
            { 0, "Erwachsene*r 1" },
            { 1, "Erwachsene*r 2" },
            { 2, "Kind 1" },
            { 3, "Kind 2" },
            { 4, "Kind 3" },
            { 5, "Kind 4" },
        };

    public void setUpTables()
    {
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetData("Allgemein");
        db.Disconnect();

        var ageTable = CalculateAgeFrequency(dataTable);

        dataGridAge.DataSource = ageTable;
    }

    public DataTable CalculateAgeFrequency(DataTable dataTable)
    {
        var ageFrequency = new Dictionary<int, int>();
        var ageFrequencyNeu = new Dictionary<int, int>();

        foreach (DataRow row in dataTable.Rows)
        {
            for (var i = 11; i <= 15; i++)
            {
                if (!int.TryParse(row[i].ToString(), out int age)) continue;
                if (ageFrequency.ContainsKey(age))
                {
                    ageFrequency[age]++;
                }
                else
                {
                    ageFrequency[age] = 1;
                }

                if (row["Wiederanmeldung"].ToString() != "Neu") continue;
                if (ageFrequencyNeu.ContainsKey(age))
                {
                    ageFrequencyNeu[age]++;
                }
                else
                {
                    ageFrequencyNeu[age] = 1;
                }
            }
        }

        var ageFrequencyTable = new DataTable();
        ageFrequencyTable.Columns.Add("Alter", typeof(int));
        ageFrequencyTable.Columns.Add("Gesamt", typeof(int));
        ageFrequencyTable.Columns.Add("Gesamt Neu", typeof(int));

        foreach (var kvp in ageFrequency)
        {
            ageFrequencyTable.Rows.Add(
                kvp.Key,
                kvp.Value,
                ageFrequencyNeu.GetValueOrDefault(kvp.Key, 0)
            );
        }

        ageFrequencyTable.DefaultView.Sort = "Alter ASC";
        ageFrequencyTable = ageFrequencyTable.DefaultView.ToTable();

        return ageFrequencyTable;
    }
}
