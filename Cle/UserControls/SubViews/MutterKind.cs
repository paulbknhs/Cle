namespace Cle.UserControls.SubViews
{
  using Cle.Classes;

  public partial class MutterKind : UserControl
  {
    public MutterKind()
    {
      this.InitializeComponent();
    }

    private void MutterKind_Load(object sender, EventArgs e)
    {
      this.dropAntrag.DataSource = Lists.MuKiAntrag;
      this.dropErwerb.DataSource = Lists.MuKiErwerb;
      this.dropKommu.DataSource = Lists.MuKiKommunikation;
      this.dropStaat.DataSource = Lists.MuKiStaat;
      this.dropStand.DataSource = Lists.MuKiLebensstand;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.MutterKind.Clear();

      Dictionary<string, string> toAdd = new() { { "Jahr", string.Empty }, { "Nr", string.Empty } };

      foreach (var pair in toAdd)
        if (Dictionaries.Allgemein.ContainsKey(pair.Key))
          Dictionaries.MutterKind.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);

      Dictionaries.MutterKind.Add("Alter", Dictionaries.Allgemein["E1"][..2]);

      ReadInput.FromDropDown(this, Dictionaries.MutterKind);
      ReadInput.FromNumberBox(this, Dictionaries.MutterKind);

      var result = ReadInput.LetUserVerify(Dictionaries.MutterKind);
      if (result != DialogResult.OK) return;

      SQL database = new();
      database.Connect();
      database.InsertStringDict("Mutter Kind", Dictionaries.MutterKind);
      database.Disconnect();
    }
  }
}