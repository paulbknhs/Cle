using System.Configuration;
using CDMS_Lebensberatung.cs;

namespace CDMS_Lebensberatung.AddSpecific;

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
        dropAnmeldung.DataSource = Lists.Sgb8Anmeldung;
        dropLeistung.DataSource = Lists.Sgb8Leistung;
        dropHerkunftHh.DataSource = Lists.Sgb8Haushalt;
        dropWirtschaft.DataSource = Lists.Sgb8Wirtschaft;
        dropHilfe.DataSource = Lists.Sgb8Hilfe;
        dropGender.DataSource = Lists.Sgb8Gender;


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
            {
                gridStunden[1, i].Style.BackColor = Color.LightCoral;
            }

        gridStunden[1, 7].Value = sum;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.Sgb8.Clear();

        Dictionary<string, string> toAdd =
            new()
            {
                { "Jahr", "" },
                { "Nr", "" },
                { "Grund", "" },
                { "Wohnort", "" },
                { "Anregung", "" },
                { "Migra", "" }
            };

        foreach (var pair in toAdd)
            if (Dictionaries.Allgemein.ContainsKey(pair.Key))
                Dictionaries.Sgb8.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);


        ReadInput.FromTextBox(this, Dictionaries.Sgb8);
        ReadInput.FromDropDown(this, Dictionaries.Sgb8);
        ReadInput.FromToggleSwitch(this, Dictionaries.Sgb8);
        ReadInput.HoursFromGridView(this, Dictionaries.Sgb8);

        var result = ReadInput.LetUserVerify(Dictionaries.Sgb8);
        if (result != DialogResult.OK) return;

        Sql database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("SGB VIII", Dictionaries.Sgb8);
        database.Disconnect();
    }
}