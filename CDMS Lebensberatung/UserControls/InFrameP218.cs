using System.Configuration;
using CDMS_Lebensberatung.cs;

namespace CDMS_Lebensberatung.AddSpecific;

public partial class P218 : UserControl
{
    public P218()
    {
        InitializeComponent();
    }

    private void P218_Load(object sender, EventArgs e)
    {
        dropErwerb.DataSource = Lists.P218Erwerb;
        dropStaat.DataSource = Lists.P218Staat;
        dropStand.DataSource = Lists.P218Stand;
        dropVerhütung.DataSource = Lists.P218Verhütung;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.P218.Clear();
        Dictionaries.P218.Add("Jahr", DateTime.Now.Year.ToString());

        ReadInput.FromDropDown(this, Dictionaries.P218);
        ReadInput.FromTextBox(this, Dictionaries.P218);
        ReadInput.FromNumberBox(this, Dictionaries.P218);
        ReadInput.FromToggleSwitch(this, Dictionaries.P218);
        ReadInput.FromCheckBox(grpAnm, Dictionaries.P218);

        var result = ReadInput.LetUserVerify(Dictionaries.P218);
        if (result != DialogResult.OK) return;

        SQL database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("§ 218", Dictionaries.P218);
        database.Disconnect();

        
    }
}