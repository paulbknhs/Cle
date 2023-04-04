using CDMS_Lebensberatung.Views;

namespace CDMS_Lebensberatung
{
    public partial class Home : Form
    {
        #region Form Dragging

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void OnControlStrip(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion

        public Home()
        {
            InitializeComponent();
            HomeButton.Tag = "selected";
        }

        #region Highlight Navigation
        private void SelectNavigation(object selection)
        {
            var selectedButton = (Button)selection;
            foreach (Control control in NavigationBar.Controls)
            {
                if (control is not Button b || b.Tag == null) continue;
                b.Tag = null;
                b.Invalidate();
            }
            selectedButton.Tag = "selected";
            selectedButton.Invalidate();
        }

        private void OnNavigationPaint(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            if (ReferenceEquals(btn.Tag, "selected"))
            {
                e.Graphics.FillRectangle(Brushes.Green, new Rectangle(0, 0, 5, btn.Height));
                btn.Font = new Font(btn.Font, FontStyle.Bold);
                btn.ForeColor = Color.Black;
            }
            else
            {
                btn.Font = new Font(btn.Font, FontStyle.Regular);
                btn.ForeColor = Color.FromArgb(40, 40, 40);
            }
        }

        #endregion
       

        private void OnButtonClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnHomeButton(object sender, EventArgs e)
        {
            SelectNavigation(sender);

            foreach (Control control in Controls)
            {
                if (control.Tag == "View") Controls.Remove(control);
            }
        }

        private void OnAddButton(object sender, EventArgs e)
        {
            SelectNavigation(sender);

            foreach (Control control in Controls)
            {
                if (control.Tag == "View") Controls.Remove(control);
            }

            var addView = new AddView();
            var tempPanel = new Panel
            {
                Size = new Size(1080, 690),
                Location = new Point(200, 30),
                BackColor = Color.FromArgb(255, 255, 255)
            };

            addView.Location = new Point(200, 30);
            Controls.Add(tempPanel);
            Controls.Add(addView);
            Controls.Remove(tempPanel);

        }

        private void OnSearchButton(object sender, EventArgs e)
        {
            var searchView = new SearchView { Location = new Point(200, 30) };
            foreach (Control control in Controls)
            {
                if (control.Tag == "View") Controls.Remove(control);
            }
            
            Controls.Add(searchView);

            SelectNavigation(sender);
        }

        private void OnExportButton(object sender, EventArgs e)
        {
            var exportView = new StatisticsView { Location = new Point(200, 30) };
            foreach (Control control in Controls)
            {
                if (control.Tag == "View") Controls.Remove(control);
            }

            Controls.Add(exportView);
            SelectNavigation(sender);
        }

        private void OnSettingsButton(object sender, EventArgs e)
        {
            SelectNavigation(sender);
        }
    }
}