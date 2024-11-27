namespace Cle
{
  using Cle.UserControls.Views;

  public partial class Window : Form
  {
    public Window()
    {
      this.InitializeComponent();
    }

    private void AddUserControl(UserControl userControl, string name, bool isVisible = false)
    {
      userControl.Location = new Point(200, 0);
      userControl.Name = name;
      userControl.Visible = isVisible;
      this.Controls.Add(userControl);
    }

    private void HideAllUserControls()
    {
      foreach (Control control in this.Controls)
        if (control is UserControl userControl)
          userControl.Visible = false;
    }

    private void OnClickOnNavigation(object sender, EventArgs e)
    {
      if (sender is Button btn)
      {
        this.SelectNavigation(btn);

        this.HideAllUserControls();

        var frameName = btn.Name switch
        {
          "HomeButton" => "frameHome",
          "AddButton" => "frameAddNew",
          "SearchButton" => "frameShowTable",
          "ExportButton" => "frameStatistics",
          "SettingsButton" => "frameSettings",
          _ => null
        };

        if (frameName != null) this.Controls.Find(frameName, true)[0].Visible = true;
      }
    }

    private void OnHomeLoad(object sender, EventArgs e)
    {
      this.AddUserControl(new Add(), "frameAddNew");
      this.AddUserControl(new Table(), "frameShowTable");
      this.AddUserControl(new FrameStatistics(), "frameStatistics");
      this.AddUserControl(new home(), "frameHome", true);

      this.SelectNavigation(this.HomeButton);
    }

    private void OnNavigationPaint(object sender, PaintEventArgs e)
    {
      switch (sender)
      {
        case Button button when button.Tag?.ToString() == "selected":
          e.Graphics.FillRectangle(Brushes.Azure, new Rectangle(0, 0, 5, button.Height));
          button.Font = new Font(button.Font, FontStyle.Bold);
          button.ForeColor = Color.Black;
          break;
        case Button button:
          button.Font = new Font(button.Font, FontStyle.Regular);
          button.ForeColor = Color.FromArgb(40, 40, 40);
          break;
      }
    }

    private void SelectNavigation(Button selectedButton)
    {
      foreach (Control control in this.NavigationBar.Controls)
        if (control is Button button)
        {
          button.Tag = null;
          button.Invalidate();
        }

      selectedButton.Tag = "selected";
      selectedButton.Invalidate();
    }
  }
}