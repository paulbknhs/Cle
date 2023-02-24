namespace CregForm.Views
{
    partial class AddView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropARGE = new CregForm.Controls.DropDown();
            this.tbJahr = new CustomControls.RJControls.RJTextBox();
            this.tbName = new CustomControls.RJControls.RJTextBox();
            this.tbAnmeldenummer = new CustomControls.RJControls.RJTextBox();
            this.tbWohnort = new CustomControls.RJControls.RJTextBox();
            this.dropBeratung = new CregForm.Controls.DropDown();
            this.dropMigra = new CregForm.Controls.DropDown();
            this.dropAnregung = new CregForm.Controls.DropDown();
            this.dropAnmeldung = new CregForm.Controls.DropDown();
            this.dropGrund = new CregForm.Controls.DropDown();
            this.toggleWiederanmeldung = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleAbgeschlossen = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.ContentFrame = new System.Windows.Forms.Panel();
            this.TabNavControl = new System.Windows.Forms.Panel();
            this.ButtonP2a = new System.Windows.Forms.Button();
            this.ButtonArge = new System.Windows.Forms.Button();
            this.ButtonAllgSgs = new System.Windows.Forms.Button();
            this.ButtonP56 = new System.Windows.Forms.Button();
            this.ButtonMutterKind = new System.Windows.Forms.Button();
            this.ButtonSgb8 = new System.Windows.Forms.Button();
            this.ButtonEheUndLeben = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridAlter = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentFrame.SuspendLayout();
            this.TabNavControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlter)).BeginInit();
            this.SuspendLayout();
            // 
            // dropARGE
            // 
            this.dropARGE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropARGE.BorderColor = System.Drawing.Color.Black;
            this.dropARGE.BorderSize = 1;
            this.dropARGE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropARGE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropARGE.ForeColor = System.Drawing.Color.DimGray;
            this.dropARGE.IconColor = System.Drawing.Color.Black;
            this.dropARGE.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropARGE.ListTextColor = System.Drawing.Color.DimGray;
            this.dropARGE.Location = new System.Drawing.Point(74, 165);
            this.dropARGE.Margin = new System.Windows.Forms.Padding(10);
            this.dropARGE.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropARGE.Name = "dropARGE";
            this.dropARGE.Padding = new System.Windows.Forms.Padding(1);
            this.dropARGE.Size = new System.Drawing.Size(200, 32);
            this.dropARGE.TabIndex = 4;
            this.dropARGE.Texts = "";
            // 
            // tbJahr
            // 
            this.tbJahr.BackColor = System.Drawing.SystemColors.Window;
            this.tbJahr.BorderColor = System.Drawing.Color.Black;
            this.tbJahr.BorderFocusColor = System.Drawing.Color.Green;
            this.tbJahr.BorderRadius = 0;
            this.tbJahr.BorderSize = 1;
            this.tbJahr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbJahr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbJahr.Location = new System.Drawing.Point(74, 49);
            this.tbJahr.Margin = new System.Windows.Forms.Padding(10);
            this.tbJahr.Multiline = false;
            this.tbJahr.Name = "tbJahr";
            this.tbJahr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbJahr.PasswordChar = false;
            this.tbJahr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbJahr.PlaceholderText = "Jahr";
            this.tbJahr.Size = new System.Drawing.Size(200, 32);
            this.tbJahr.TabIndex = 0;
            this.tbJahr.Texts = "";
            this.tbJahr.UnderlinedStyle = true;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.BorderColor = System.Drawing.Color.Black;
            this.tbName.BorderFocusColor = System.Drawing.Color.Green;
            this.tbName.BorderRadius = 0;
            this.tbName.BorderSize = 1;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Location = new System.Drawing.Point(74, 101);
            this.tbName.Margin = new System.Windows.Forms.Padding(10);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(200, 32);
            this.tbName.TabIndex = 2;
            this.tbName.Texts = "";
            this.tbName.UnderlinedStyle = true;
            // 
            // tbAnmeldenummer
            // 
            this.tbAnmeldenummer.BackColor = System.Drawing.SystemColors.Window;
            this.tbAnmeldenummer.BorderColor = System.Drawing.Color.Black;
            this.tbAnmeldenummer.BorderFocusColor = System.Drawing.Color.Green;
            this.tbAnmeldenummer.BorderRadius = 0;
            this.tbAnmeldenummer.BorderSize = 1;
            this.tbAnmeldenummer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnmeldenummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAnmeldenummer.Location = new System.Drawing.Point(282, 49);
            this.tbAnmeldenummer.Margin = new System.Windows.Forms.Padding(10);
            this.tbAnmeldenummer.Multiline = false;
            this.tbAnmeldenummer.Name = "tbAnmeldenummer";
            this.tbAnmeldenummer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbAnmeldenummer.PasswordChar = false;
            this.tbAnmeldenummer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbAnmeldenummer.PlaceholderText = "Anmeldenummer";
            this.tbAnmeldenummer.Size = new System.Drawing.Size(200, 32);
            this.tbAnmeldenummer.TabIndex = 1;
            this.tbAnmeldenummer.Texts = "";
            this.tbAnmeldenummer.UnderlinedStyle = true;
            // 
            // tbWohnort
            // 
            this.tbWohnort.BackColor = System.Drawing.SystemColors.Window;
            this.tbWohnort.BorderColor = System.Drawing.Color.Black;
            this.tbWohnort.BorderFocusColor = System.Drawing.Color.Green;
            this.tbWohnort.BorderRadius = 0;
            this.tbWohnort.BorderSize = 1;
            this.tbWohnort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWohnort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbWohnort.Location = new System.Drawing.Point(282, 101);
            this.tbWohnort.Margin = new System.Windows.Forms.Padding(10);
            this.tbWohnort.Multiline = false;
            this.tbWohnort.Name = "tbWohnort";
            this.tbWohnort.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbWohnort.PasswordChar = false;
            this.tbWohnort.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbWohnort.PlaceholderText = "Wohnort";
            this.tbWohnort.Size = new System.Drawing.Size(200, 32);
            this.tbWohnort.TabIndex = 3;
            this.tbWohnort.Texts = "";
            this.tbWohnort.UnderlinedStyle = true;
            // 
            // dropBeratung
            // 
            this.dropBeratung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropBeratung.BorderColor = System.Drawing.Color.Black;
            this.dropBeratung.BorderSize = 1;
            this.dropBeratung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropBeratung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBeratung.ForeColor = System.Drawing.Color.DimGray;
            this.dropBeratung.IconColor = System.Drawing.Color.Black;
            this.dropBeratung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropBeratung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropBeratung.Location = new System.Drawing.Point(282, 165);
            this.dropBeratung.Margin = new System.Windows.Forms.Padding(10);
            this.dropBeratung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropBeratung.Name = "dropBeratung";
            this.dropBeratung.Padding = new System.Windows.Forms.Padding(1);
            this.dropBeratung.Size = new System.Drawing.Size(200, 32);
            this.dropBeratung.TabIndex = 5;
            this.dropBeratung.Texts = "";
            // 
            // dropMigra
            // 
            this.dropMigra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropMigra.BorderColor = System.Drawing.Color.Black;
            this.dropMigra.BorderSize = 1;
            this.dropMigra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropMigra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropMigra.ForeColor = System.Drawing.Color.DimGray;
            this.dropMigra.IconColor = System.Drawing.Color.Black;
            this.dropMigra.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropMigra.ListTextColor = System.Drawing.Color.DimGray;
            this.dropMigra.Location = new System.Drawing.Point(74, 217);
            this.dropMigra.Margin = new System.Windows.Forms.Padding(10);
            this.dropMigra.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropMigra.Name = "dropMigra";
            this.dropMigra.Padding = new System.Windows.Forms.Padding(1);
            this.dropMigra.Size = new System.Drawing.Size(200, 32);
            this.dropMigra.TabIndex = 6;
            this.dropMigra.Texts = "";
            // 
            // dropAnregung
            // 
            this.dropAnregung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropAnregung.BorderColor = System.Drawing.Color.Black;
            this.dropAnregung.BorderSize = 1;
            this.dropAnregung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropAnregung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropAnregung.ForeColor = System.Drawing.Color.DimGray;
            this.dropAnregung.IconColor = System.Drawing.Color.Black;
            this.dropAnregung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropAnregung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropAnregung.Location = new System.Drawing.Point(282, 217);
            this.dropAnregung.Margin = new System.Windows.Forms.Padding(10);
            this.dropAnregung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropAnregung.Name = "dropAnregung";
            this.dropAnregung.Padding = new System.Windows.Forms.Padding(1);
            this.dropAnregung.Size = new System.Drawing.Size(200, 32);
            this.dropAnregung.TabIndex = 7;
            this.dropAnregung.Texts = "";
            // 
            // dropAnmeldung
            // 
            this.dropAnmeldung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropAnmeldung.BorderColor = System.Drawing.Color.Black;
            this.dropAnmeldung.BorderSize = 1;
            this.dropAnmeldung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropAnmeldung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropAnmeldung.ForeColor = System.Drawing.Color.DimGray;
            this.dropAnmeldung.IconColor = System.Drawing.Color.Black;
            this.dropAnmeldung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropAnmeldung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropAnmeldung.Location = new System.Drawing.Point(282, 536);
            this.dropAnmeldung.Margin = new System.Windows.Forms.Padding(10);
            this.dropAnmeldung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropAnmeldung.Name = "dropAnmeldung";
            this.dropAnmeldung.Padding = new System.Windows.Forms.Padding(1);
            this.dropAnmeldung.Size = new System.Drawing.Size(200, 32);
            this.dropAnmeldung.TabIndex = 8;
            this.dropAnmeldung.Texts = "";
            // 
            // dropGrund
            // 
            this.dropGrund.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropGrund.BorderColor = System.Drawing.Color.Gray;
            this.dropGrund.BorderSize = 1;
            this.dropGrund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropGrund.Enabled = false;
            this.dropGrund.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropGrund.ForeColor = System.Drawing.Color.DimGray;
            this.dropGrund.IconColor = System.Drawing.Color.Gray;
            this.dropGrund.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropGrund.ListTextColor = System.Drawing.Color.DimGray;
            this.dropGrund.Location = new System.Drawing.Point(282, 588);
            this.dropGrund.Margin = new System.Windows.Forms.Padding(10);
            this.dropGrund.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropGrund.Name = "dropGrund";
            this.dropGrund.Padding = new System.Windows.Forms.Padding(1);
            this.dropGrund.Size = new System.Drawing.Size(200, 32);
            this.dropGrund.TabIndex = 11;
            this.dropGrund.Texts = "";
            // 
            // toggleWiederanmeldung
            // 
            this.toggleWiederanmeldung.AutoSize = true;
            this.toggleWiederanmeldung.Location = new System.Drawing.Point(17, 8);
            this.toggleWiederanmeldung.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleWiederanmeldung.Name = "toggleWiederanmeldung";
            this.toggleWiederanmeldung.OffBackColor = System.Drawing.Color.Gray;
            this.toggleWiederanmeldung.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleWiederanmeldung.OnBackColor = System.Drawing.Color.Green;
            this.toggleWiederanmeldung.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleWiederanmeldung.Size = new System.Drawing.Size(45, 22);
            this.toggleWiederanmeldung.TabIndex = 9;
            this.toggleWiederanmeldung.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wiederanmeldung";
            // 
            // toggleAbgeschlossen
            // 
            this.toggleAbgeschlossen.AutoSize = true;
            this.toggleAbgeschlossen.Location = new System.Drawing.Point(17, 55);
            this.toggleAbgeschlossen.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleAbgeschlossen.Name = "toggleAbgeschlossen";
            this.toggleAbgeschlossen.OffBackColor = System.Drawing.Color.Gray;
            this.toggleAbgeschlossen.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleAbgeschlossen.OnBackColor = System.Drawing.Color.Green;
            this.toggleAbgeschlossen.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleAbgeschlossen.Size = new System.Drawing.Size(45, 22);
            this.toggleAbgeschlossen.TabIndex = 10;
            this.toggleAbgeschlossen.UseVisualStyleBackColor = true;
            this.toggleAbgeschlossen.CheckedChanged += new System.EventHandler(this.OnToggle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abgeschlossen";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(74, 636);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(200, 40);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "(1) Speichern";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.OnButtonSave);
            // 
            // ContentFrame
            // 
            this.ContentFrame.BackColor = System.Drawing.Color.White;
            this.ContentFrame.Controls.Add(this.TabNavControl);
            this.ContentFrame.Location = new System.Drawing.Point(525, 30);
            this.ContentFrame.Name = "ContentFrame";
            this.ContentFrame.Size = new System.Drawing.Size(500, 590);
            this.ContentFrame.TabIndex = 7;
            // 
            // TabNavControl
            // 
            this.TabNavControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabNavControl.Controls.Add(this.ButtonP2a);
            this.TabNavControl.Controls.Add(this.ButtonArge);
            this.TabNavControl.Controls.Add(this.ButtonAllgSgs);
            this.TabNavControl.Controls.Add(this.ButtonP56);
            this.TabNavControl.Controls.Add(this.ButtonMutterKind);
            this.TabNavControl.Controls.Add(this.ButtonSgb8);
            this.TabNavControl.Controls.Add(this.ButtonEheUndLeben);
            this.TabNavControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabNavControl.Location = new System.Drawing.Point(0, 0);
            this.TabNavControl.Name = "TabNavControl";
            this.TabNavControl.Size = new System.Drawing.Size(500, 30);
            this.TabNavControl.TabIndex = 8;
            // 
            // ButtonP2a
            // 
            this.ButtonP2a.AutoSize = true;
            this.ButtonP2a.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonP2a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonP2a.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonP2a.FlatAppearance.BorderSize = 0;
            this.ButtonP2a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonP2a.Location = new System.Drawing.Point(408, 0);
            this.ButtonP2a.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonP2a.Name = "ButtonP2a";
            this.ButtonP2a.Size = new System.Drawing.Size(37, 30);
            this.ButtonP2a.TabIndex = 3;
            this.ButtonP2a.Text = "§ 2a";
            this.ButtonP2a.UseVisualStyleBackColor = false;
            this.ButtonP2a.Click += new System.EventHandler(this.ButtonP2a_Click);
            this.ButtonP2a.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // ButtonArge
            // 
            this.ButtonArge.AutoSize = true;
            this.ButtonArge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonArge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonArge.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonArge.FlatAppearance.BorderSize = 0;
            this.ButtonArge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonArge.Location = new System.Drawing.Point(362, 0);
            this.ButtonArge.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonArge.Name = "ButtonArge";
            this.ButtonArge.Size = new System.Drawing.Size(46, 30);
            this.ButtonArge.TabIndex = 3;
            this.ButtonArge.Text = "ARGE";
            this.ButtonArge.UseVisualStyleBackColor = false;
            this.ButtonArge.Click += new System.EventHandler(this.ButtonArge_Click);
            this.ButtonArge.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // ButtonAllgSgs
            // 
            this.ButtonAllgSgs.AutoSize = true;
            this.ButtonAllgSgs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAllgSgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonAllgSgs.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAllgSgs.FlatAppearance.BorderSize = 0;
            this.ButtonAllgSgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAllgSgs.Location = new System.Drawing.Point(277, 0);
            this.ButtonAllgSgs.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAllgSgs.Name = "ButtonAllgSgs";
            this.ButtonAllgSgs.Size = new System.Drawing.Size(85, 30);
            this.ButtonAllgSgs.TabIndex = 3;
            this.ButtonAllgSgs.Text = "allg. Schwgs.";
            this.ButtonAllgSgs.UseVisualStyleBackColor = false;
            this.ButtonAllgSgs.Click += new System.EventHandler(this.ButtonAllgSgs_Click);
            this.ButtonAllgSgs.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // ButtonP56
            // 
            this.ButtonP56.AutoSize = true;
            this.ButtonP56.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonP56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonP56.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonP56.FlatAppearance.BorderSize = 0;
            this.ButtonP56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonP56.Location = new System.Drawing.Point(234, 0);
            this.ButtonP56.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonP56.Name = "ButtonP56";
            this.ButtonP56.Size = new System.Drawing.Size(43, 30);
            this.ButtonP56.TabIndex = 3;
            this.ButtonP56.Text = "§ 218";
            this.ButtonP56.UseVisualStyleBackColor = false;
            this.ButtonP56.Click += new System.EventHandler(this.ButtonP56_Click);
            this.ButtonP56.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // ButtonMutterKind
            // 
            this.ButtonMutterKind.AutoSize = true;
            this.ButtonMutterKind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMutterKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonMutterKind.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonMutterKind.FlatAppearance.BorderSize = 0;
            this.ButtonMutterKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMutterKind.Location = new System.Drawing.Point(152, 0);
            this.ButtonMutterKind.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMutterKind.Name = "ButtonMutterKind";
            this.ButtonMutterKind.Size = new System.Drawing.Size(82, 30);
            this.ButtonMutterKind.TabIndex = 2;
            this.ButtonMutterKind.Text = "Mutter-Kind";
            this.ButtonMutterKind.UseVisualStyleBackColor = false;
            this.ButtonMutterKind.Click += new System.EventHandler(this.ButtonMutterKind_Click);
            this.ButtonMutterKind.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // ButtonSgb8
            // 
            this.ButtonSgb8.AutoSize = true;
            this.ButtonSgb8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSgb8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonSgb8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSgb8.FlatAppearance.BorderSize = 0;
            this.ButtonSgb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSgb8.Location = new System.Drawing.Point(95, 0);
            this.ButtonSgb8.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSgb8.Name = "ButtonSgb8";
            this.ButtonSgb8.Size = new System.Drawing.Size(57, 30);
            this.ButtonSgb8.TabIndex = 1;
            this.ButtonSgb8.Text = "SGB VIII";
            this.ButtonSgb8.UseVisualStyleBackColor = false;
            this.ButtonSgb8.Click += new System.EventHandler(this.ButtonSgb8_Click);
            this.ButtonSgb8.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // ButtonEheUndLeben
            // 
            this.ButtonEheUndLeben.AutoSize = true;
            this.ButtonEheUndLeben.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonEheUndLeben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonEheUndLeben.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonEheUndLeben.FlatAppearance.BorderSize = 0;
            this.ButtonEheUndLeben.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEheUndLeben.Location = new System.Drawing.Point(0, 0);
            this.ButtonEheUndLeben.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonEheUndLeben.Name = "ButtonEheUndLeben";
            this.ButtonEheUndLeben.Size = new System.Drawing.Size(95, 30);
            this.ButtonEheUndLeben.TabIndex = 0;
            this.ButtonEheUndLeben.Text = "Ehe und Leben";
            this.ButtonEheUndLeben.UseVisualStyleBackColor = false;
            this.ButtonEheUndLeben.Click += new System.EventHandler(this.ButtonEheUndLeben_Click);
            this.ButtonEheUndLeben.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabNavPaint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.toggleWiederanmeldung);
            this.panel3.Controls.Add(this.toggleAbgeschlossen);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(74, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 84);
            this.panel3.TabIndex = 8;
            // 
            // gridAlter
            // 
            this.gridAlter.AllowUserToAddRows = false;
            this.gridAlter.AllowUserToDeleteRows = false;
            this.gridAlter.AllowUserToResizeColumns = false;
            this.gridAlter.AllowUserToResizeRows = false;
            this.gridAlter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAlter.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridAlter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.m,
            this.w,
            this.nb});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAlter.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlter.EnableHeadersVisualStyles = false;
            this.gridAlter.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gridAlter.Location = new System.Drawing.Point(74, 275);
            this.gridAlter.Name = "gridAlter";
            this.gridAlter.RowHeadersVisible = false;
            this.gridAlter.RowHeadersWidth = 40;
            this.gridAlter.RowTemplate.Height = 25;
            this.gridAlter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridAlter.Size = new System.Drawing.Size(408, 200);
            this.gridAlter.TabIndex = 12;
            this.gridAlter.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnValueChanged);
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            // 
            // m
            // 
            this.m.HeaderText = "männlich";
            this.m.Name = "m";
            // 
            // w
            // 
            this.w.HeaderText = "weiblich";
            this.w.Name = "w";
            // 
            // nb
            // 
            this.nb.HeaderText = "non-binär";
            this.nb.Name = "nb";
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.gridAlter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ContentFrame);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.tbWohnort);
            this.Controls.Add(this.tbAnmeldenummer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbJahr);
            this.Controls.Add(this.dropGrund);
            this.Controls.Add(this.dropAnmeldung);
            this.Controls.Add(this.dropMigra);
            this.Controls.Add(this.dropAnregung);
            this.Controls.Add(this.dropBeratung);
            this.Controls.Add(this.dropARGE);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddView";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Tag = "View";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ContentFrame.ResumeLayout(false);
            this.TabNavControl.ResumeLayout(false);
            this.TabNavControl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.DropDown dropARGE;
        private CustomControls.RJControls.RJTextBox tbJahr;
        private CustomControls.RJControls.RJTextBox tbName;
        private CustomControls.RJControls.RJTextBox tbAnmeldenummer;
        private CustomControls.RJControls.RJTextBox tbWohnort;
        private Controls.DropDown dropBeratung;
        private Controls.DropDown dropMigra;
        private Controls.DropDown dropAnregung;
        private Controls.DropDown dropAnmeldung;
        private Controls.DropDown dropGrund;
        private RJCodeAdvance.RJControls.RJToggleButton toggleWiederanmeldung;
        private Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton toggleAbgeschlossen;
        private Label label2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private Panel ContentFrame;
        private Panel TabNavControl;
        private Button ButtonP2a;
        private Button ButtonArge;
        private Button ButtonAllgSgs;
        private Button ButtonP56;
        private Button ButtonMutterKind;
        private Button ButtonSgb8;
        private Button ButtonEheUndLeben;
        private Panel panel3;
        private DataGridView gridAlter;
        private DataGridViewTextBoxColumn Person;
        private DataGridViewTextBoxColumn m;
        private DataGridViewTextBoxColumn w;
        private DataGridViewTextBoxColumn nb;
    }
}
