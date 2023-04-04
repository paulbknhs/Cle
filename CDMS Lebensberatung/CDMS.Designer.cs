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
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ControlStrip = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NavigationBar.SuspendLayout();
            this.ControlStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NavigationBar.Controls.Add(this.label1);
            this.NavigationBar.Controls.Add(this.SettingsButton);
            this.NavigationBar.Controls.Add(this.ExportButton);
            this.NavigationBar.Controls.Add(this.SearchButton);
            this.NavigationBar.Controls.Add(this.AddButton);
            this.NavigationBar.Controls.Add(this.HomeButton);
            this.NavigationBar.Location = new System.Drawing.Point(0, 30);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(200, 690);
            this.NavigationBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "______________________________________";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.Image = global::CDMS_Lebensberatung.Properties.images.settings24x24;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 640);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10);
            this.SettingsButton.Size = new System.Drawing.Size(200, 50);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "    Einstellungen";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.OnSettingsButton);
            this.SettingsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExportButton.ForeColor = System.Drawing.Color.DimGray;
            this.ExportButton.Image = global::CDMS_Lebensberatung.Properties.images.export24x24;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(0, 184);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Padding = new System.Windows.Forms.Padding(10);
            this.ExportButton.Size = new System.Drawing.Size(200, 50);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "    Exportieren";
            this.ExportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.OnExportButton);
            this.ExportButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.DimGray;
            this.SearchButton.Image = global::CDMS_Lebensberatung.Properties.images.search_db24x24;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(0, 134);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(10);
            this.SearchButton.Size = new System.Drawing.Size(200, 50);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "    Suchen";
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.OnSearchButton);
            this.SearchButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddButton.Image = global::CDMS_Lebensberatung.Properties.images.add_new24x24;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(0, 84);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(10);
            this.AddButton.Size = new System.Drawing.Size(200, 50);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "    Hinzufügen";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.OnAddButton);
            this.AddButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.DimGray;
            this.HomeButton.Image = global::CDMS_Lebensberatung.Properties.images.home24x24;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 11);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10);
            this.HomeButton.Size = new System.Drawing.Size(200, 50);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "    Startseite";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.OnHomeButton);
            this.HomeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNavigationPaint);
            // 
            // ControlStrip
            // 
            this.ControlStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ControlStrip.Controls.Add(this.ButtonClose);
            this.ControlStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlStrip.Location = new System.Drawing.Point(0, 0);
            this.ControlStrip.Margin = new System.Windows.Forms.Padding(0);
            this.ControlStrip.Name = "ControlStrip";
            this.ControlStrip.Size = new System.Drawing.Size(1280, 30);
            this.ControlStrip.TabIndex = 1;
            this.ControlStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnControlStrip);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Image = global::CDMS_Lebensberatung.Properties.images.close_16;
            this.ButtonClose.Location = new System.Drawing.Point(1240, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(40, 30);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.OnButtonClose);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 720);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 20);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(144, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 20);
            this.label5.TabIndex = 2;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(514, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "CDMS-0.2.1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(884, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client Data Management System - Die Lebensberatung";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CDMS_Lebensberatung.Properties.images.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ControlStrip);
            this.Controls.Add(this.NavigationBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.OnHomeLoad);
            this.NavigationBar.ResumeLayout(false);
            this.ControlStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavigationBar;
        private Panel ControlStrip;
        private Button ButtonClose;
        private Button SettingsButton;
        private Button ExportButton;
        private Button SearchButton;
        private Button AddButton;
        private Button HomeButton;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}