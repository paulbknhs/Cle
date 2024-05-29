using CDMS_Lebensberatung.UserControls;
using System.Drawing;
using System.Windows.Forms;

namespace CDMS_Lebensberatung
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Highlight Navigation

        private void SelectNavigation(Button selectedButton)
        {
            foreach (Control control in NavigationBar.Controls)
            {
                if (control is Button button)
                {
                    button.Tag = null;
                    button.Invalidate();
                }
            }

            selectedButton.Tag = "selected";
            selectedButton.Invalidate();
        }

        private void OnNavigationPaint(object sender, PaintEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Tag?.ToString() == "selected")
                {
                    e.Graphics.FillRectangle(Brushes.MediumTurquoise, new Rectangle(0, 0, 5, button.Height));
                    button.Font = new Font(button.Font, FontStyle.Bold);
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button.Font = new Font(button.Font, FontStyle.Regular);
                    button.ForeColor = Color.FromArgb(40, 40, 40);
                }
            }
        }

        #endregion

        private void OnHomeLoad(object sender, EventArgs e)
        {
            AddUserControl(new FrameSettings(), "frameSettings");
            AddUserControl(new FrameAddNew(), "frameAddNew");
            AddUserControl(new FrameShowTable(), "frameShowTable");
            AddUserControl(new FrameStatistics(), "frameStatistics");
            AddUserControl(new FrameHome(), "frameHome", true);

            SelectNavigation(HomeButton);
        }

        private void AddUserControl(UserControl userControl, string name, bool isVisible = false)
        {
            userControl.Location = new Point(200, 0);
            userControl.Name = name;
            userControl.Visible = isVisible;
            Controls.Add(userControl);
        }

        private void OnClickOnNavigation(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                SelectNavigation(btn);

                HideAllUserControls();

                var frameName = btn.Name switch
                {
                    "HomeButton" => "frameHome",
                    "AddButton" => "frameAddNew",
                    "SearchButton" => "frameShowTable",
                    "ExportButton" => "frameStatistics",
                    "SettingsButton" => "frameSettings",
                    _ => null
                };

                if (frameName != null)
                {
                    Controls.Find(frameName, true)[0].Visible = true;
                }
            }
        }

        private void HideAllUserControls()
        {
            foreach (Control control in Controls)
            {
                if (control is UserControl userControl)
                {
                    userControl.Visible = false;
                }
            }
        }
    }
}
