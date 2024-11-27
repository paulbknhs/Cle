namespace Cle.UserControls.SubViews
{
  using Cle.Classes;
  using Cle.UserControls.CustomControls;

  public partial class P218 : UserControl
  {
    private bool didSave;

    public P218()
    {
      this.InitializeComponent();
    }

    private void ClearFields()
    {
      foreach (var control in this.Controls)
        switch (control)
        {
          case RJTextBox tb:
            tb.Texts = string.Empty;
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

    private void OnButtonSave(object sender, EventArgs e)
    {
      Dictionaries.P218.Clear();

      ReadInput.FromDropDown(this, Dictionaries.P218);
      ReadInput.FromTextBox(this, Dictionaries.P218);
      ReadInput.FromNumberBox(this, Dictionaries.P218);
      ReadInput.FromToggleSwitch(this, Dictionaries.P218);
      ReadInput.FromCheckBox(this.grpAnm, Dictionaries.P218);
      Dictionaries.P218.Remove("Geschlecht");

      var result = ReadInput.LetUserVerify(Dictionaries.P218);
      if (result != DialogResult.OK) return;

      var allgemeinAlter = new Dictionary<string, string> { { "Beratungsart", "§218" }, { "Age", this.tbAlter.Texts } };
      var gender = this.dropGeschlecht.SelectedItem.ToString() switch
                   {
                     "Weiblich" => "female",
                     "Männlich" => "male",
                     "Nicht-Binär" => "nonbinary",
                     _ => string.Empty
                   };

      allgemeinAlter.Add("Gender", gender);

      SQL database = new();
      database.Connect();
      database.InsertStringDict("§ 218", Dictionaries.P218);
      database.InsertStringDict("Allgemein", allgemeinAlter);
      database.Disconnect();
      this.didSave = true;
    }

    private void OnTextBoxEnter(object sender, EventArgs e)
    {
      if (!this.didSave) return;

      this.ClearFields();
      this.didSave = false;
    }

    private void P218_Load(object sender, EventArgs e)
    {
      this.dropErwerb.DataSource = Lists.P218Erwerb;
      this.dropStand.DataSource = Lists.P218Stand;
      this.dropStaat.DataSource = Lists.P218Staat;
      this.dropKommu.DataSource = Lists.P218Kommunikation;
      this.dropVerhütung.DataSource = Lists.P218Verhütung;
      this.dropGeschlecht.DataSource = Lists.P218Geschlecht;
    }
  }
}