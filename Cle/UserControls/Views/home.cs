using static System.DateTime;

namespace Cle.UserControls.Views
{
  using Cle.Classes;

  public partial class home : UserControl
  {
    public home()
    {
      this.InitializeComponent();
    }

    private void OnFrameLoad(object sender, EventArgs e)
    {
      var name = Environment.UserName;
      if (name == "ubak") name = "Ute";
      var wochentag = Lists.Wochentage[(int)Now.DayOfWeek];

      this.labelHallo.Text = $"Hallo {name}!";

      this.labelDatum.Text = $"{wochentag}, {Now.Day}.{Now.Month}.{Now.Year}";
    }
  }
}