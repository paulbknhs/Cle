namespace CDMS_Lebensberatung.UserControls
{
    partial class FrameSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			panel2 = new Panel();
			rjButton2 = new RJCodeAdvance.RJControls.RJButton();
			rjButton1 = new RJCodeAdvance.RJControls.RJButton();
			tbDefaultPath = new RJCodeAdvance.RJControls.RJTextBox();
			tbServiceName = new RJCodeAdvance.RJControls.RJTextBox();
			tbConnectionString = new RJCodeAdvance.RJControls.RJTextBox();
			label3 = new Label();
			label4 = new Label();
			label2 = new Label();
			dialogueDefaultFolder = new FolderBrowserDialog();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 22F);
			label1.Location = new Point(15, 12);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(195, 41);
			label1.TabIndex = 3;
			label1.Text = "Einstellungen";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			panel2.Controls.Add(rjButton2);
			panel2.Controls.Add(rjButton1);
			panel2.Controls.Add(tbDefaultPath);
			panel2.Controls.Add(tbServiceName);
			panel2.Controls.Add(tbConnectionString);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(label2);
			panel2.Location = new Point(63, 45);
			panel2.Name = "panel2";
			panel2.Size = new Size(959, 610);
			panel2.TabIndex = 6;
			// 
			// rjButton2
			// 
			rjButton2.BackColor = Color.White;
			rjButton2.BackgroundColor = Color.White;
			rjButton2.BorderColor = Color.Transparent;
			rjButton2.BorderRadius = 0;
			rjButton2.BorderSize = 1;
			rjButton2.FlatAppearance.BorderSize = 0;
			rjButton2.FlatStyle = FlatStyle.Flat;
			rjButton2.Font = new Font("Segoe UI", 12F);
			rjButton2.ForeColor = Color.Black;
			rjButton2.Location = new Point(789, 287);
			rjButton2.Name = "rjButton2";
			rjButton2.Size = new Size(140, 31);
			rjButton2.TabIndex = 23;
			rjButton2.Text = "Durchsuchen...";
			rjButton2.TextColor = Color.Black;
			rjButton2.UseVisualStyleBackColor = false;
			rjButton2.Click += OnOpenFolder;
			// 
			// rjButton1
			// 
			rjButton1.BackColor = Color.Green;
			rjButton1.BackgroundColor = Color.Green;
			rjButton1.BorderColor = Color.Transparent;
			rjButton1.BorderRadius = 0;
			rjButton1.BorderSize = 1;
			rjButton1.FlatAppearance.BorderSize = 0;
			rjButton1.FlatStyle = FlatStyle.Flat;
			rjButton1.Font = new Font("Segoe UI", 12F);
			rjButton1.ForeColor = Color.White;
			rjButton1.Location = new Point(729, 542);
			rjButton1.Name = "rjButton1";
			rjButton1.Size = new Size(200, 40);
			rjButton1.TabIndex = 23;
			rjButton1.Text = "Speichern";
			rjButton1.TextColor = Color.White;
			rjButton1.UseVisualStyleBackColor = false;
			rjButton1.Click += OnSaveConfig;
			// 
			// tbDefaultPath
			// 
			tbDefaultPath.BackColor = SystemColors.Window;
			tbDefaultPath.BorderColor = Color.Green;
			tbDefaultPath.BorderFocusColor = Color.IndianRed;
			tbDefaultPath.BorderRadius = 0;
			tbDefaultPath.BorderSize = 2;
			tbDefaultPath.Font = new Font("Microsoft Sans Serif", 9.5F);
			tbDefaultPath.ForeColor = Color.FromArgb(64, 64, 64);
			tbDefaultPath.Location = new Point(35, 287);
			tbDefaultPath.Margin = new Padding(4);
			tbDefaultPath.Multiline = false;
			tbDefaultPath.Name = "tbDefaultPath";
			tbDefaultPath.Padding = new Padding(10, 7, 10, 7);
			tbDefaultPath.PasswordChar = false;
			tbDefaultPath.PlaceholderColor = Color.DarkGray;
			tbDefaultPath.PlaceholderText = "";
			tbDefaultPath.Size = new Size(750, 31);
			tbDefaultPath.TabIndex = 0;
			tbDefaultPath.Texts = "";
			tbDefaultPath.UnderlinedStyle = true;
			tbDefaultPath._TextChanged += OnDpChanged;
			// 
			// tbServiceName
			// 
			tbServiceName.BackColor = SystemColors.Window;
			tbServiceName.BorderColor = Color.Green;
			tbServiceName.BorderFocusColor = Color.IndianRed;
			tbServiceName.BorderRadius = 0;
			tbServiceName.BorderSize = 2;
			tbServiceName.Font = new Font("Microsoft Sans Serif", 9.5F);
			tbServiceName.ForeColor = Color.FromArgb(64, 64, 64);
			tbServiceName.Location = new Point(35, 192);
			tbServiceName.Margin = new Padding(4);
			tbServiceName.Multiline = false;
			tbServiceName.Name = "tbServiceName";
			tbServiceName.Padding = new Padding(10, 7, 10, 7);
			tbServiceName.PasswordChar = false;
			tbServiceName.PlaceholderColor = Color.DarkGray;
			tbServiceName.PlaceholderText = "";
			tbServiceName.Size = new Size(894, 31);
			tbServiceName.TabIndex = 0;
			tbServiceName.Texts = "";
			tbServiceName.UnderlinedStyle = true;
			tbServiceName._TextChanged += OnSnChanged;
			// 
			// tbConnectionString
			// 
			tbConnectionString.BackColor = SystemColors.Window;
			tbConnectionString.BorderColor = Color.Green;
			tbConnectionString.BorderFocusColor = Color.IndianRed;
			tbConnectionString.BorderRadius = 0;
			tbConnectionString.BorderSize = 2;
			tbConnectionString.Font = new Font("Microsoft Sans Serif", 9.5F);
			tbConnectionString.ForeColor = Color.FromArgb(64, 64, 64);
			tbConnectionString.Location = new Point(35, 113);
			tbConnectionString.Margin = new Padding(4);
			tbConnectionString.Multiline = false;
			tbConnectionString.Name = "tbConnectionString";
			tbConnectionString.Padding = new Padding(10, 7, 10, 7);
			tbConnectionString.PasswordChar = false;
			tbConnectionString.PlaceholderColor = Color.DarkGray;
			tbConnectionString.PlaceholderText = "";
			tbConnectionString.Size = new Size(894, 31);
			tbConnectionString.TabIndex = 0;
			tbConnectionString.Texts = "";
			tbConnectionString.UnderlinedStyle = true;
			tbConnectionString._TextChanged += OnCsChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 14F);
			label3.Location = new Point(35, 258);
			label3.Name = "label3";
			label3.Size = new Size(169, 25);
			label3.TabIndex = 3;
			label3.Text = "Statistik Zielordner";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 14F);
			label4.Location = new Point(35, 163);
			label4.Name = "label4";
			label4.Size = new Size(165, 25);
			label4.TabIndex = 3;
			label4.Text = "SQL Service Name";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(35, 84);
			label2.Name = "label2";
			label2.Size = new Size(204, 25);
			label2.TabIndex = 3;
			label2.Text = "SQL Connection-String";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dialogueDefaultFolder
			// 
			dialogueDefaultFolder.RootFolder = Environment.SpecialFolder.MyDocuments;
			// 
			// FrameSettings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 255, 255, 255);
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(panel2);
			Name = "FrameSettings";
			Size = new Size(1076, 686);
			Load += OnFrameLoad;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox tbConnectionString;
        private Label label2;
        private RJCodeAdvance.RJControls.RJTextBox tbDefaultPath;
        private Label label3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private FolderBrowserDialog dialogueDefaultFolder;
        private RJCodeAdvance.RJControls.RJTextBox tbServiceName;
        private Label label4;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
    }
}
