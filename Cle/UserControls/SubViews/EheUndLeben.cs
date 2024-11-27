namespace Cle.UserControls.SubViews
{
  using Cle.Classes;

  using RJCodeAdvance.RJControls;

  public partial class EheUndLeben : UserControl
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

    public EheUndLeben()
    {
      this.InitializeComponent();
    }

    private void EheUndLeben_Load(object sender, EventArgs e)
    {
      this.dropLeistung.DataSource = Lists.EheUndLebenLeistung;
      this.dropWirtschaft.DataSource = Lists.EheUndLebenWirtschaft;

      foreach (var item in this._arten) this.gridStunden.Rows.Add(item, 0);
      this.gridStunden.Rows[7].ReadOnly = true;
      this.gridStunden.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.gridStunden.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.EheUndLeben.Clear();

      Dictionary<string, string> toAdd = new() { { "Jahr", string.Empty }, { "Nr", string.Empty }, { "Grund", string.Empty } };
      foreach (var pair in toAdd)
        if (Dictionaries.Allgemein.ContainsKey(pair.Key))
          Dictionaries.EheUndLeben.Add(pair.Key, Dictionaries.Allgemein[pair.Key]);
      ReadInput.FromTextBox(this, Dictionaries.EheUndLeben);
      ReadInput.FromDropDown(this, Dictionaries.EheUndLeben);

      if (!this.toggleUnbekannt.Checked)
      {
        switch (this.togglePartnerschaft.Checked)
        {
          case true:
            Dictionaries.EheUndLeben.Add(
              "Sozialer Hintergrund",
              this.toggleKinder.Checked ? "Verpartnert mit Kind" : "Verpartnert ohne Kind");
            break;
          case false:
            Dictionaries.EheUndLeben.Add(
              "Sozialer Hintergrund",
              this.toggleKinder.Checked ? "Alleinstehend mit Kind" : "Alleinstehend ohne Kind");
            break;
        }

        if (this.toggleSonstige.Checked) Dictionaries.EheUndLeben["Sozialer Hintergrund"] += " & Sonstiges";
      }
      else
      {
        Dictionaries.EheUndLeben.Add("Sozialer Hintergrund", "Unbekannt");
      }

      ReadInput.HoursFromGridView(this, Dictionaries.EheUndLeben);
      ReadInput.FromCheckBox(this.groupAnmeldung, Dictionaries.EheUndLeben);

      var result = ReadInput.LetUserVerify(Dictionaries.EheUndLeben);
      if (result != DialogResult.OK) return;

      SQL database = new();
      database.Connect();
      database.InsertStringDict("Ehe und Leben", Dictionaries.EheUndLeben);
      database.Disconnect();
    }

    private void onToggleUnbekannt(object sender, EventArgs e)
    {
      foreach (Control control in this.Controls)
        if (control.Name != "toggleUnbekannt" && control is RJToggleButton toggle)
        {
          if (this.toggleUnbekannt.Checked)
          {
            toggle.Checked = false;
            toggle.Enabled = false;
          }
          else
          {
            toggle.Enabled = true;
          }
        }
    }

    private void OnValueChange(object sender, DataGridViewCellEventArgs e)
    {
      var rowCount = this.gridStunden.RowCount;
      var sum = 0;

      if (e.RowIndex == 7 || rowCount < 8)
        return;

      for (var i = 0; i < 7; i++)
        if (int.TryParse(this.gridStunden[1, i].Value?.ToString(), out var value))
          sum += value;

      this.gridStunden[1, 7].Value = sum;
    }
  }
}