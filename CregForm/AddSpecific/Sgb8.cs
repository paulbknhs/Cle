using System.Configuration;
using System.Text.RegularExpressions;
using CregForm.Resources.classes;
using Color = System.Drawing.Color;

namespace CregForm.AddSpecific;

public partial class Sgb8 : UserControl
{
    private readonly List<string> _arten =
        new()
        {
            "Anmeldungen",
            "Sprechstunde",
            "Fallverteilung",
            "SV",
            "Weitere Fall.",
            "Gruppensitzung",
            "Beratung",
            "Summe"
        };

    public Sgb8()
    {
        InitializeComponent();
    }

    private void Sgb8_Load(object sender, EventArgs e)
    {
        dropLeistung.DataSource = LSTS.Sgb8Leistung;
        dropHerkunftHh.DataSource = LSTS.Sgb8Haushalt;
        dropWirtschaft.DataSource = LSTS.Sgb8Wirtschaft;
        dropHilfe.DataSource = LSTS.Sgb8Hilfe;


        foreach (var item in _arten)
            gridStunden.Rows.Add(item, 0);
        gridStunden.Columns[0].ReadOnly = true;
        gridStunden.Rows[7].ReadOnly = true;

        gridStunden.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        gridStunden.Columns[1].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
    }

    private void OnValueChange(object sender, DataGridViewCellEventArgs e)
    {
        var rowCount = gridStunden.RowCount;
        var sum = 0;

        if (e.RowIndex == 7 || rowCount < 8)
            return;

        for (var i = 0; i < 7; i++)
            if (int.TryParse(gridStunden[1, i].Value?.ToString(), out var value))
            {
                sum += value;
                gridStunden[1, i].Style.BackColor = Color.White;
            }
            else
                gridStunden[1, i].Style.BackColor = Color.LightCoral;
        gridStunden[1, 7].Value = sum;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        DICT.Sgb8.Clear();

        Dictionary<string, string> toAdd =
            new()
            {
                { "Jahr", "" },
                { "Anmeldenummer", "" },
                { "Abgeschlossen", "" },
                { "Wohnort", "" },
                { "Anregung durch", "" },
                { "Anmeldung durch", "" },
                { "Migrationshintergrund", "" }
            };
        foreach (KeyValuePair<string, string> pair in toAdd)
        {
            if (DICT.Allgemein.ContainsKey(pair.Key))
            {
                DICT.Sgb8.Add(pair.Key, DICT.Allgemein[pair.Key]);
            }
        }
        
        var gender = Regex.Replace(DICT.Allgemein["Erwachsene*r 1"], "[^a-z.]", "");
        DICT.Sgb8.Add("Geschlecht", gender);

        DSTR.StoreDropDownContent(this, DICT.Sgb8);
        DSTR.StoreToggleContent(this, DICT.Sgb8);
        DSTR.StoreStundenGridContent(this, DICT.Sgb8);

        var result = DSTR.ValidateEntries(DICT.Sgb8);
        if (result != DialogResult.OK) return;

        DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertData("SGB VIII", DICT.Sgb8);
        database.Disconnect();
    }
}
