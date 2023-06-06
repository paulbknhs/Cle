using System.Configuration;
using CDMS_Lebensberatung.cs;

namespace CDMS_Lebensberatung.AddSpecific;

public partial class MutterKind : UserControl
{
    public MutterKind()
    {
        InitializeComponent();
    }

    private void MutterKind_Load(object sender, EventArgs e)
    {
        dropAntrag.DataSource = Lists.MuKiAntrag;
        dropErwerb.DataSource = Lists.MuKiErwerb;
        dropKommu.DataSource = Lists.MuKiKommunikation;
        dropStaat.DataSource = Lists.MuKiStaat;
        dropStand.DataSource = Lists.MuKiLebensstand;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.MutterKind.Clear();

        Dictionary<string, string> toAdd = new()
            {
                { "Jahr", "" },
                { "Nr", "" }
            };

        foreach (var pair in toAdd)
            if (Dictionaries.Allgemein.ContainsKey(pair.Key))
                Dictionaries.MutterKind.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);

        Dictionaries.MutterKind.Add("Alter", Dictionaries.Allgemein["E1"][..2]);

        ReadInput.FromDropDown(this, Dictionaries.MutterKind);
        ReadInput.FromNumberBox(this, Dictionaries.MutterKind);

        var result = ReadInput.LetUserVerify(Dictionaries.MutterKind);
        if (result != DialogResult.OK) return;

        Sql database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("Mutter Kind", Dictionaries.MutterKind);
        database.Disconnect();

        
    }
}