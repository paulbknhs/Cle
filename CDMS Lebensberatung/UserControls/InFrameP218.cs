using System.Configuration;
using System.Diagnostics;
using CDMS_Lebensberatung.cs;
using CDMS_Lebensberatung.UserControls;
using RJCodeAdvance.RJControls;
using RJTextBox = CDMS_Lebensberatung.UserControls.RJTextBox;

namespace CDMS_Lebensberatung.AddSpecific;

public partial class P218 : UserControl
{
    private bool didSave = false;
    public P218()
    {
        InitializeComponent();
    }

    private void P218_Load(object sender, EventArgs e)
    {
        dropErwerb.DataSource = Lists.P218Erwerb;
        dropStand.DataSource = Lists.P218Stand;
        dropStaat.DataSource = Lists.P218Staat;
        dropKommu.DataSource = Lists.P218Kommunikation;
        dropVerhütung.DataSource = Lists.P218Verhütung;
        dropGeschlecht.DataSource = Lists.P218Geschlecht;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        Dictionaries.P218.Clear();

        ReadInput.FromDropDown(this, Dictionaries.P218);
        ReadInput.FromTextBox(this, Dictionaries.P218);
        ReadInput.FromNumberBox(this, Dictionaries.P218);
        ReadInput.FromToggleSwitch(this, Dictionaries.P218);
        ReadInput.FromCheckBox(grpAnm, Dictionaries.P218);
        Dictionaries.P218.Remove("Geschlecht");

        var result = ReadInput.LetUserVerify(Dictionaries.P218);
        if (result != DialogResult.OK) return;

        var allgemeinAlter = new Dictionary<string, string>() { { "Beratungsart", "§218" }, { "Age", tbAlter.Texts } };
        var gender = dropGeschlecht.SelectedItem.ToString() switch
        {
            "Weiblich" => "female",
            "Männlich" => "male",
            "Nicht-Binär" => "nonbinary",
            _ => ""
        };

        allgemeinAlter.Add("Gender", gender);

        Sql database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertStringDict("§ 218", Dictionaries.P218);
        database.InsertStringDict("Allgemein", allgemeinAlter);
        database.Disconnect();
        didSave = true;
    }

    private void OnTextBoxEnter(object sender, EventArgs e)
    {
        if (!didSave) return;
        
        ClearFields();
        didSave = false;
    }

    private void ClearFields()
    {
        foreach (var control in Controls)
            switch (control)
            {
                case RJTextBox tb:
                    tb.Texts = "";
                    break;
                case NumericUpDown num:
                    num.Value = 0;
                    break;
                case DropDown drop:
                    drop.SelectedIndex = 0;
                    break;
                case GroupBox group:
                {
                    if (group.Name != "grpAnm") break;
                    foreach (var pControl in group.Controls)
                        if (pControl is CheckBox cb)
                            cb.Checked = false;
                    break;
                }
            }
    }
}