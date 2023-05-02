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
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.NavigationBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NavigationBar.Controls.Add(this.SettingsButton);
            this.NavigationBar.Controls.Add(this.ExportButton);
            this.NavigationBar.Controls.Add(this.SearchButton);
            this.NavigationBar.Controls.Add(this.AddButton);
            this.NavigationBar.Controls.Add(this.HomeButton);
            this.NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(200, 690);
            this.NavigationBar.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Image = global::CDMS_Lebensberatung.Properties.images.settings24x24;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 640);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10);
            this.SettingsButton.Size = new System.Drawing.Size(200, 50);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Tag = "setting";
            this.SettingsButton.Text = "    Einstellungen";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.OnClickOnNavigation);
            this.SettingsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExportButton.ForeColor = System.Drawing.Color.Black;
            this.ExportButton.Image = global::CDMS_Lebensberatung.Properties.images.export24x24;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(0, 184);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Padding = new System.Windows.Forms.Padding(10);
            this.ExportButton.Size = new System.Drawing.Size(200, 50);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Tag = "stat";
            this.ExportButton.Text = "    Exportieren";
            this.ExportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.OnClickOnNavigation);
            this.ExportButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Image = global::CDMS_Lebensberatung.Properties.images.search_db24x24;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(0, 134);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(10);
            this.SearchButton.Size = new System.Drawing.Size(200, 50);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Tag = "show";
            this.SearchButton.Text = "    Anzeigen";
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.OnClickOnNavigation);
            this.SearchButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Image = global::CDMS_Lebensberatung.Properties.images.add_new24x24;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(0, 84);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(10);
            this.AddButton.Size = new System.Drawing.Size(200, 50);
            this.AddButton.TabIndex = 0;
            this.AddButton.Tag = "add";
            this.AddButton.Text = "    Eintrag erstellen";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.OnClickOnNavigation);
            this.AddButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.Black;
            this.HomeButton.Image = global::CDMS_Lebensberatung.Properties.images.home24x24;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 15);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10);
            this.HomeButton.Size = new System.Drawing.Size(200, 50);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Tag = "home";
            this.HomeButton.Text = "    Startseite";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.OnClickOnNavigation);
            this.HomeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::CDMS_Lebensberatung.Properties.images.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 696);
            this.Controls.Add(this.NavigationBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CDMS Lebensberatung";
            this.Load += new System.EventHandler(this.OnHomeLoad);
            this.NavigationBar.ResumeLayout(false);
            this.ResumeLayout(false);

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