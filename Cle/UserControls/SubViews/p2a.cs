namespace Cle.UserControls.SubViews
{
  using Cle.Classes;

  public partial class P2a : UserControl
  {
    public P2a()
    {
      this.InitializeComponent();
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.P2a.Clear();

      Dictionaries.P2a.Add("Jahr", Dictionaries.Allgemein["Jahr"]);
      ReadInput.FromDropDown(this, Dictionaries.P2a);
      ReadInput.FromNumberBox(this, Dictionaries.P2a);

      var result = ReadInput.LetUserVerify(Dictionaries.P2a);
      if (result != DialogResult.OK) return;

      SQL database = new();
      database.Connect();
      database.InsertStringDict("§ 2a", Dictionaries.P2a);
      database.Disconnect();
    }

    private void P2a_Load(object sender, EventArgs e)
    {
      this.dropErwerb.DataSource = Lists.P2aErwerb;
      this.dropStand.DataSource = Lists.P2aStand;
    }
  }
}