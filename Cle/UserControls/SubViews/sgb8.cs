namespace Cle.UserControls.SubViews
{
  using Cle.Classes;

  public partial class Sgb8 : UserControl
  {
    private readonly List<string> _arten = new() {
                                                     "Anmeldungen",
                                                     "Sprechstunde",
                                                     "Fallverteilung",
                                                     "SV",
                                                     "Weitere Fall.",
                                                     "Gruppensitzung",
                                                     "Beratung",
                                                     "Summe"
                                                 };

    public Sgb8()
    {
      this.InitializeComponent();
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.Sgb8.Clear();

      Dictionary<string, string> toAdd = new() {
                                                   { "Jahr", string.Empty },
                                                   { "Nr", string.Empty },
                                                   { "Grund", string.Empty },
                                                   { "Wohnort", string.Empty },
                                                   { "Anregung", string.Empty },
                                                   { "Migra", string.Empty }
                                               };

      foreach (var pair in toAdd)
        if (Dictionaries.Allgemein.ContainsKey(pair.Key))
          Dictionaries.Sgb8.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);

      ReadInput.FromTextBox(this, Dictionaries.Sgb8);
      ReadInput.FromDropDown(this, Dictionaries.Sgb8);
      ReadInput.FromToggleSwitch(this, Dictionaries.Sgb8);
      ReadInput.HoursFromGridView(this, Dictionaries.Sgb8);

      var result = ReadInput.LetUserVerify(Dictionaries.Sgb8);
      if (result != DialogResult.OK) return;

      SQL database = new();
      database.Connect();
      database.InsertStringDict("SGB VIII", Dictionaries.Sgb8);
      database.Disconnect();
    }

    private void OnValueChange(object sender, DataGridViewCellEventArgs e)
    {
      var rowCount = this.gridStunden.RowCount;
      var sum = 0;

      if (e.RowIndex == 7 || rowCount < 8)
        return;

      for (var i = 0; i < 7; i++)
        if (int.TryParse(this.gridStunden[1, i].Value?.ToString(), out var value))
        {
          sum += value;
          this.gridStunden[1, i].Style.BackColor = Color.White;
        }
        else
        {
          this.gridStunden[1, i].Style.BackColor = Color.LightCoral;
        }

      this.gridStunden[1, 7].Value = sum;
    }

    private void Sgb8_Load(object sender, EventArgs e)
    {
      this.dropAnmeldung.DataSource = Lists.Sgb8Anmeldung;
      this.dropLeistung.DataSource = Lists.Sgb8Leistung;
      this.dropHerkunftHh.DataSource = Lists.Sgb8Haushalt;
      this.dropWirtschaft.DataSource = Lists.Sgb8Wirtschaft;
      this.dropHilfe.DataSource = Lists.Sgb8Hilfe;
      this.dropGender.DataSource = Lists.Sgb8Gender;

      foreach (var item in this._arten) this.gridStunden.Rows.Add(item, 0);
      this.gridStunden.Columns[0].ReadOnly = true;
      this.gridStunden.Rows[7].ReadOnly = true;

      this.gridStunden.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.gridStunden.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }
  }
}