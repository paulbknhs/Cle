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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDefaultPath = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbServiceName = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbConnectionString = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dialogueDefaultFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Einstellungen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tbDefaultPath);
            this.panel2.Controls.Add(this.tbServiceName);
            this.panel2.Controls.Add(this.tbConnectionString);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(67, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 610);
            this.panel2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(789, 287);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(143, 33);
            this.panel6.TabIndex = 24;
            this.panel6.Click += new System.EventHandler(this.OnSaveConfig);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Green;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(729, 542);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(200, 40);
            this.rjButton1.TabIndex = 23;
            this.rjButton1.Text = "Speichern";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.OnSaveConfig);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(729, 542);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 43);
            this.panel4.TabIndex = 24;
            this.panel4.Click += new System.EventHandler(this.OnSaveConfig);
            // 
            // tbDefaultPath
            // 
            this.tbDefaultPath.BackColor = System.Drawing.SystemColors.Window;
            this.tbDefaultPath.BorderColor = System.Drawing.Color.Green;
            this.tbDefaultPath.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.tbDefaultPath.BorderRadius = 0;
            this.tbDefaultPath.BorderSize = 2;
            this.tbDefaultPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDefaultPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDefaultPath.Location = new System.Drawing.Point(35, 287);
            this.tbDefaultPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbDefaultPath.Multiline = false;
            this.tbDefaultPath.Name = "tbDefaultPath";
            this.tbDefaultPath.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbDefaultPath.PasswordChar = false;
            this.tbDefaultPath.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDefaultPath.PlaceholderText = "";
            this.tbDefaultPath.Size = new System.Drawing.Size(750, 31);
            this.tbDefaultPath.TabIndex = 0;
            this.tbDefaultPath.Texts = "";
            this.tbDefaultPath.UnderlinedStyle = true;
            this.tbDefaultPath._TextChanged += new System.EventHandler(this.OnDpChanged);
            // 
            // tbServiceName
            // 
            this.tbServiceName.BackColor = System.Drawing.SystemColors.Window;
            this.tbServiceName.BorderColor = System.Drawing.Color.Green;
            this.tbServiceName.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.tbServiceName.BorderRadius = 0;
            this.tbServiceName.BorderSize = 2;
            this.tbServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbServiceName.Location = new System.Drawing.Point(35, 192);
            this.tbServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceName.Multiline = false;
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbServiceName.PasswordChar = false;
            this.tbServiceName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbServiceName.PlaceholderText = "";
            this.tbServiceName.Size = new System.Drawing.Size(894, 31);
            this.tbServiceName.TabIndex = 0;
            this.tbServiceName.Texts = "";
            this.tbServiceName.UnderlinedStyle = true;
            this.tbServiceName._TextChanged += new System.EventHandler(this.OnSnChanged);
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.BackColor = System.Drawing.SystemColors.Window;
            this.tbConnectionString.BorderColor = System.Drawing.Color.Green;
            this.tbConnectionString.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.tbConnectionString.BorderRadius = 0;
            this.tbConnectionString.BorderSize = 2;
            this.tbConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConnectionString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConnectionString.Location = new System.Drawing.Point(35, 113);
            this.tbConnectionString.Margin = new System.Windows.Forms.Padding(4);
            this.tbConnectionString.Multiline = false;
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbConnectionString.PasswordChar = false;
            this.tbConnectionString.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbConnectionString.PlaceholderText = "";
            this.tbConnectionString.Size = new System.Drawing.Size(894, 31);
            this.tbConnectionString.TabIndex = 0;
            this.tbConnectionString.Texts = "";
            this.tbConnectionString.UnderlinedStyle = true;
            this.tbConnectionString._TextChanged += new System.EventHandler(this.OnCsChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statistik Zielordner";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "SQL Service Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "SQL Connection-String";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 690);
            this.panel5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 5);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(71, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 610);
            this.panel3.TabIndex = 16;
            // 
            // dialogueDefaultFolder
            // 
            this.dialogueDefaultFolder.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BackgroundColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(789, 287);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(140, 31);
            this.rjButton2.TabIndex = 23;
            this.rjButton2.Text = "Durchsuchen...";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.OnOpenFolder);
            // 
            // FrameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrameSettings";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Load += new System.EventHandler(this.OnFrameLoad);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox tbConnectionString;
        private Label label2;
        private Panel panel5;
        private Panel panel1;
        private Panel panel3;
        private RJCodeAdvance.RJControls.RJTextBox tbDefaultPath;
        private Label label3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private Panel panel4;
        private Panel panel6;
        private FolderBrowserDialog dialogueDefaultFolder;
        private RJCodeAdvance.RJControls.RJTextBox tbServiceName;
        private Label label4;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
    }
}
