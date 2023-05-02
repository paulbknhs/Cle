using System.Configuration;
using CDMS_Lebensberatung.cs;

namespace CDMS_Lebensberatung.AddSpecific;

public partial class P2a : UserControl
{
    public P2a()
    {
        InitializeComponent();
    }

    private void P2a_Load(object sender, EventArgs e)
    {
        dropErwerb.DataSource = Lists.P2aErwerb;
        dropStand.DataSource = Lists.P2aStand;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.P2a.Clear();

        Dictionaries.P2a.Add("Jahr", Dictionaries.Allgemein["Jahr"]);
        ReadInput.FromDropDown(this, Dictionaries.P2a);
        ReadInput.FromNumberBox(this, Dictionaries.P2a);

        var result = ReadInput.LetUserVerify(Dictionaries.P2a);
        if (result != DialogResult.OK) return;

        SQL database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("§ 2a", Dictionaries.P2a);
        database.Disconnect();

        
    }
}