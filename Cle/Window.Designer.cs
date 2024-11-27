namespace Cle
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            ExportButton = new Button();
            SearchButton = new Button();
            AddButton = new Button();
            HomeButton = new Button();
            NavigationBar = new Panel();
            NavigationBar.SuspendLayout();
            SuspendLayout();
            // 
            // ExportButton
            // 
            ExportButton.BackColor = Color.Transparent;
            ExportButton.FlatAppearance.BorderSize = 0;
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ExportButton.ForeColor = Color.Black;
            ExportButton.Image = Properties.images.export24x24;
            ExportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExportButton.Location = new Point(0, 184);
            ExportButton.Margin = new Padding(0);
            ExportButton.Name = "ExportButton";
            ExportButton.Padding = new Padding(10);
            ExportButton.Size = new Size(200, 50);
            ExportButton.TabIndex = 0;
            ExportButton.Tag = "stat";
            ExportButton.Text = "    Statistik";
            ExportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += OnClickOnNavigation;
            ExportButton.Paint += OnNavigationPaint;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            SearchButton.ForeColor = Color.Black;
            SearchButton.Image = Properties.images.search_db24x24;
            SearchButton.ImageAlign = ContentAlignment.MiddleLeft;
            SearchButton.Location = new Point(0, 134);
            SearchButton.Margin = new Padding(0);
            SearchButton.Name = "SearchButton";
            SearchButton.Padding = new Padding(10);
            SearchButton.Size = new Size(200, 50);
            SearchButton.TabIndex = 0;
            SearchButton.Tag = "show";
            SearchButton.Text = "    Tabellen";
            SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += OnClickOnNavigation;
            SearchButton.Paint += OnNavigationPaint;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.Black;
            AddButton.Image = Properties.images.add_new24x24;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(0, 84);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(10);
            AddButton.Size = new Size(200, 50);
            AddButton.TabIndex = 0;
            AddButton.Tag = "Add";
            AddButton.Text = "    Neu erstellen";
            AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += OnClickOnNavigation;
            AddButton.Paint += OnNavigationPaint;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Transparent;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            HomeButton.ForeColor = Color.Black;
            HomeButton.Image = Properties.images.home24x24;
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(0, 15);
            HomeButton.Margin = new Padding(0);
            HomeButton.Name = "HomeButton";
            HomeButton.Padding = new Padding(10);
            HomeButton.Size = new Size(200, 50);
            HomeButton.TabIndex = 0;
            HomeButton.Tag = "home";
            HomeButton.Text = "    Start";
            HomeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += OnClickOnNavigation;
            HomeButton.Paint += OnNavigationPaint;
            // 
            // NavigationBar
            // 
            NavigationBar.BackColor = Color.SkyBlue;
            NavigationBar.BorderStyle = BorderStyle.Fixed3D;
            NavigationBar.Controls.Add(ExportButton);
            NavigationBar.Controls.Add(SearchButton);
            NavigationBar.Controls.Add(AddButton);
            NavigationBar.Controls.Add(HomeButton);
            NavigationBar.Font = new Font("NotoSans NF", 12F);
            NavigationBar.Location = new Point(0, 0);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.Size = new Size(200, 690);
            NavigationBar.TabIndex = 0;
            // 
            // Window
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 686);
            Controls.Add(NavigationBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Window";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cle";
            Load += OnHomeLoad;
            NavigationBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button ExportButton;
        private Button SearchButton;
        private Button AddButton;
        private Button HomeButton;
        private Panel NavigationBar;
    }
}