namespace Cle.UserControls.SubViews
{
  using Cle.Classes;

  public partial class AllgSgs : UserControl
  {
    public AllgSgs()
    {
      this.InitializeComponent();
    }

    private void AllgSgs_Load(object sender, EventArgs e)
    {
      this.dropErwerb.DataSource = Lists.AllgSgsErwerb;
      this.dropStand.DataSource = Lists.AllgSgsLebensstand;
      this.dropStaat.DataSource = Lists.AllgSgsStaat;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.AllgSgs.Clear();

      Dictionaries.AllgSgs.Add("Jahr", Dictionaries.Allgemein["Jahr"]);
      Dictionaries.AllgSgs.Add("Alter", Dictionaries.Allgemein["E1"][..2]);

      ReadInput.FromTextBox(this, Dictionaries.AllgSgs);
      ReadInput.FromDropDown(this, Dictionaries.AllgSgs);
      ReadInput.FromNumberBox(this, Dictionaries.AllgSgs);

      var result = ReadInput.LetUserVerify(Dictionaries.AllgSgs);
      if (result != DialogResult.OK) return;

      SQL database = new();
      database.Connect();
      database.InsertStringDict("Allgemeine Schwangerschaft", Dictionaries.AllgSgs);
      database.Disconnect();
    }
  }
}