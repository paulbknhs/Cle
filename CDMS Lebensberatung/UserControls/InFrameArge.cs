using System.Configuration;
using System.Text.RegularExpressions;
using CDMS_Lebensberatung.cs;

namespace CDMS_Lebensberatung.AddSpecific;

public partial class ARGE : UserControl
{
    public ARGE()
    {
        InitializeComponent();
    }

    private void ARGE_Load(object sender, EventArgs e)
    {
        dropBasis.DataSource = Lists.ARGEBasis;
        dropBasisAbbruch.DataSource = Lists.ARGEAbbruch;
        dropKomplett.DataSource = Lists.ARGEKomplett;
        dropKomplettAbbruch.DataSource = Lists.ARGEKomplettAbbruch;
        dropEinsZwei.DataSource = Lists.ARGE12;
        dropBelastung.DataSource = Lists.ARGEBelastung;
        dropWartezeit.DataSource = Lists.ARGEWochen;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.ARGE.Clear();

        Dictionary<string, string> toAdd =
            new()
            {
                { "Jahr", "" },
                { "Anmeldenummer", "" },
                { "Abgeschlossen", "" },
                { "Wohnort", "" },
                { "Alter", "" },
                { "Geschlecht", "" },
                { "Migrationshintergrund", "" }
            };
        foreach (var pair in toAdd)
            if (Dictionaries.Allgemein.ContainsKey(pair.Key))
                Dictionaries.ARGE.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);

        Dictionaries.ARGE.Add("Alter", Dictionaries.Allgemein["Erwachsene*r 1"][..2]);

        var gender = Regex.Replace(Dictionaries.Allgemein["Erwachsene*r 1"], "[^a-z.]", "");
        Dictionaries.ARGE.Add("Geschlecht", gender);

        ReadInput.FromDropDown(this, Dictionaries.ARGE);

        var result = ReadInput.LetUserVerify(Dictionaries.ARGE);
        if (result != DialogResult.OK) return;

        SQL database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("ARGE", Dictionaries.ARGE);
        database.Disconnect();
    }
}