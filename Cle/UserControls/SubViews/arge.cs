namespace Cle.UserControls.SubViews
{
  using Cle.Classes;

  public partial class ARGE : UserControl
  {
    public ARGE()
    {
      this.InitializeComponent();
    }

    private void ARGE_Load(object sender, EventArgs e)
    {
      this.dropBasis.DataSource = Lists.ARGEBasis;
      this.dropBasisAbbruch.DataSource = Lists.ARGEAbbruch;
      this.dropKomplett.DataSource = Lists.ARGEKomplett;
      this.dropKomplettAbbruch.DataSource = Lists.ARGEKomplettAbbruch;
      this.dropEinsZwei.DataSource = Lists.ARGE12;
      this.dropBelastung.DataSource = Lists.ARGEBelastung;
      this.dropWartezeit.DataSource = Lists.ARGEWochen;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.ARGE.Clear();

      Dictionary<string, string> toAdd = new() {
                                                   { "Jahr", string.Empty },
                                                   { "Anmeldenummer", string.Empty },
                                                   { "Abgeschlossen", string.Empty },
                                                   { "Wohnort", string.Empty },
                                                   { "Alter", string.Empty },
                                                   { "Geschlecht", string.Empty },
                                                   { "Migrationshintergrund", string.Empty }
                                               };
      foreach (var pair in toAdd)
        if (Dictionaries.Allgemein.ContainsKey(pair.Key))
          Dictionaries.ARGE.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);

      Dictionaries.ARGE.Add("Alter", Dictionaries.Allgemein["Age"]);

      var gender = Dictionaries.Allgemein["Gender"];
      Dictionaries.ARGE.Add("Geschlecht", gender);

      ReadInput.FromDropDown(this, Dictionaries.ARGE);

      var result = ReadInput.LetUserVerify(Dictionaries.ARGE);
      if (result != DialogResult.OK) return;

      SQL database = new();
      database.Connect();
      database.InsertStringDict("ARGE", Dictionaries.ARGE);
      database.Disconnect();
    }
  }
}