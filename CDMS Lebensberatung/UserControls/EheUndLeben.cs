using System.Configuration;
using CDMS_Lebensberatung.cs;
using RJCodeAdvance.RJControls;

namespace CDMS_Lebensberatung.AddSpecific;

public partial class EheUndLeben : UserControl
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

    public EheUndLeben()
    {
        InitializeComponent();
    }

    private void EheUndLeben_Load(object sender, EventArgs e)
    {
        dropLeistung.DataSource = Lists.EheUndLebenLeistung;
        dropWirtschaft.DataSource = Lists.EheUndLebenWirtschaft;

        foreach (var item in _arten)
            gridStunden.Rows.Add(item, 0);
        gridStunden.Rows[7].ReadOnly = true;
        gridStunden.Columns[0].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleLeft;
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
                sum += value;

        gridStunden[1, 7].Value = sum;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.EheUndLeben.Clear();

        Dictionary<string, string> toAdd =
            new()
            {
                { "Jahr", "" },
                { "Anmeldenummer", "" },
                { "Abgeschlossen", "" }
            };
        foreach (var pair in toAdd)
            if (Dictionaries.Allgemein.ContainsKey(pair.Key))
                Dictionaries.EheUndLeben.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);
        ReadInput.FromTextBox(this, Dictionaries.EheUndLeben);
        ReadInput.FromDropDown(this, Dictionaries.EheUndLeben);

        if (!toggleUnbekannt.Checked)
        {
            switch (togglePartnerschaft.Checked)
            {
                case true:
                    Dictionaries.EheUndLeben.Add("Sozialer Hintergrund",
                        toggleKinder.Checked ? "Verpartnert mit Kind" : "Verpartnert ohne Kind");
                    break;
                case false:
                    Dictionaries.EheUndLeben.Add("Sozialer Hintergrund",
                        toggleKinder.Checked ? "Alleinstehend mit Kind" : "Alleinstehend ohne Kind");
                    break;
            }

            if (toggleSonstige.Checked) Dictionaries.EheUndLeben["Sozialer Hintergrund"] += " & Sonstiges";
        }
        else
        {
            Dictionaries.EheUndLeben.Add("Sozialer Hintergrund", "Unbekannt");
        }

        ReadInput.HoursFromGridView(this, Dictionaries.EheUndLeben);
        ReadInput.FromCheckBox(groupAnmeldung, Dictionaries.EheUndLeben);

        var result = ReadInput.LetUserVerify(Dictionaries.EheUndLeben);
        if (result != DialogResult.OK) return;

        SQL database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("Ehe und Leben", Dictionaries.EheUndLeben);
        database.Disconnect();
    }

    private void onToggleUnbekannt(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
            if (control.Name != "toggleUnbekannt" && control is RJToggleButton toggle)
            {
                if (toggleUnbekannt.Checked)
                {
                    toggle.Checked = false;
                    toggle.Enabled = false;
                }
                else
                {
                    toggle.Enabled = true;
                }
            }
    }
}