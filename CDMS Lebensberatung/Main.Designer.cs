namespace CDMS_Lebensberatung
{
    partial class Home
    {
                                private System.ComponentModel.IContainer components = null;

                                        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			NavigationBar = new Panel();
			SettingsButton = new Button();
			ExportButton = new Button();
			SearchButton = new Button();
			AddButton = new Button();
			HomeButton = new Button();
			NavigationBar.SuspendLayout();
			SuspendLayout();
			// 
			// NavigationBar
			// 
			NavigationBar.BackColor = Color.FromArgb(30, 255, 255, 255);
			NavigationBar.BorderStyle = BorderStyle.Fixed3D;
			NavigationBar.Controls.Add(SettingsButton);
			NavigationBar.Controls.Add(ExportButton);
			NavigationBar.Controls.Add(SearchButton);
			NavigationBar.Controls.Add(AddButton);
			NavigationBar.Controls.Add(HomeButton);
			NavigationBar.Location = new Point(0, 0);
			NavigationBar.Name = "NavigationBar";
			NavigationBar.Size = new Size(200, 690);
			NavigationBar.TabIndex = 0;
			// 
			// SettingsButton
			// 
			SettingsButton.BackColor = Color.FromArgb(160, 255, 255, 255);
			SettingsButton.FlatAppearance.BorderSize = 0;
			SettingsButton.FlatStyle = FlatStyle.Popup;
			SettingsButton.Font = new Font("Segoe UI", 11F);
			SettingsButton.ForeColor = Color.FromArgb(24, 38, 37);
			SettingsButton.Image = Properties.images.settings24x24;
			SettingsButton.ImageAlign = ContentAlignment.MiddleLeft;
			SettingsButton.Location = new Point(-1, 634);
			SettingsButton.Margin = new Padding(0);
			SettingsButton.Name = "SettingsButton";
			SettingsButton.Padding = new Padding(10);
			SettingsButton.Size = new Size(199, 50);
			SettingsButton.TabIndex = 0;
			SettingsButton.Tag = "setting";
			SettingsButton.Text = " |   Einstellungen";
			SettingsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			SettingsButton.UseVisualStyleBackColor = false;
			SettingsButton.Click += OnClickOnNavigation;
			SettingsButton.Paint += OnNavigationPaint;
			// 
			// ExportButton
			// 
			ExportButton.BackColor = Color.FromArgb(160, 255, 255, 255);
			ExportButton.FlatAppearance.BorderSize = 0;
			ExportButton.FlatStyle = FlatStyle.Popup;
			ExportButton.Font = new Font("Segoe UI", 11F);
			ExportButton.ForeColor = Color.FromArgb(24, 38, 37);
			ExportButton.Image = Properties.images.export24x24;
			ExportButton.ImageAlign = ContentAlignment.MiddleLeft;
			ExportButton.Location = new Point(0, 151);
			ExportButton.Margin = new Padding(0);
			ExportButton.Name = "ExportButton";
			ExportButton.Padding = new Padding(10);
			ExportButton.Size = new Size(196, 50);
			ExportButton.TabIndex = 0;
			ExportButton.Tag = "stat";
			ExportButton.Text = "  |  Exportieren";
			ExportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			ExportButton.UseVisualStyleBackColor = false;
			ExportButton.Click += OnClickOnNavigation;
			ExportButton.Paint += OnNavigationPaint;
			// 
			// SearchButton
			// 
			SearchButton.BackColor = Color.FromArgb(160, 255, 255, 255);
			SearchButton.FlatAppearance.BorderSize = 0;
			SearchButton.FlatStyle = FlatStyle.Popup;
			SearchButton.Font = new Font("Segoe UI", 11F);
			SearchButton.ForeColor = Color.FromArgb(24, 38, 37);
			SearchButton.Image = Properties.images.search_db24x24;
			SearchButton.ImageAlign = ContentAlignment.MiddleLeft;
			SearchButton.Location = new Point(0, 101);
			SearchButton.Margin = new Padding(0);
			SearchButton.Name = "SearchButton";
			SearchButton.Padding = new Padding(10);
			SearchButton.Size = new Size(196, 50);
			SearchButton.TabIndex = 0;
			SearchButton.Tag = "show";
			SearchButton.Text = "  |  Anzeigen";
			SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			SearchButton.UseVisualStyleBackColor = false;
			SearchButton.Click += OnClickOnNavigation;
			SearchButton.Paint += OnNavigationPaint;
			// 
			// AddButton
			// 
			AddButton.BackColor = Color.FromArgb(160, 255, 255, 255);
			AddButton.FlatAppearance.BorderSize = 0;
			AddButton.FlatStyle = FlatStyle.Popup;
			AddButton.Font = new Font("Segoe UI", 11F);
			AddButton.ForeColor = Color.FromArgb(24, 38, 37);
			AddButton.Image = Properties.images.add_new24x24;
			AddButton.ImageAlign = ContentAlignment.MiddleLeft;
			AddButton.Location = new Point(0, 51);
			AddButton.Margin = new Padding(0);
			AddButton.Name = "AddButton";
			AddButton.Padding = new Padding(10);
			AddButton.Size = new Size(196, 50);
			AddButton.TabIndex = 0;
			AddButton.Tag = "add";
			AddButton.Text = "  |  Eintrag erstellen";
			AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			AddButton.UseVisualStyleBackColor = false;
			AddButton.Click += OnClickOnNavigation;
			AddButton.Paint += OnNavigationPaint;
			// 
			// HomeButton
			// 
			HomeButton.BackColor = Color.FromArgb(160, 255, 255, 255);
			HomeButton.FlatAppearance.BorderSize = 0;
			HomeButton.FlatStyle = FlatStyle.Popup;
			HomeButton.Font = new Font("Segoe UI", 12F);
			HomeButton.ForeColor = Color.FromArgb(24, 38, 37);
			HomeButton.Image = Properties.images.home24x24;
			HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
			HomeButton.Location = new Point(0, 1);
			HomeButton.Margin = new Padding(0);
			HomeButton.Name = "HomeButton";
			HomeButton.Padding = new Padding(10);
			HomeButton.Size = new Size(196, 50);
			HomeButton.TabIndex = 0;
			HomeButton.Tag = "home";
			HomeButton.Text = "  |  Startseite";
			HomeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			HomeButton.UseVisualStyleBackColor = false;
			HomeButton.Click += OnClickOnNavigation;
			HomeButton.Paint += OnNavigationPaint;
			// 
			// Home
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(24, 38, 37);
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1274, 686);
			Controls.Add(NavigationBar);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			HelpButton = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Home";
			SizeGripStyle = SizeGripStyle.Hide;
			Text = "CDMS Lebensberatung";
			Load += OnHomeLoad;
			NavigationBar.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel NavigationBar;
        private Button SettingsButton;
        private Button ExportButton;
        private Button SearchButton;
        private Button AddButton;
        private Button HomeButton;
    }
}