namespace CDMS_Lebensberatung.UserControls
{
    partial class FrameAddNew
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

		#region Component Designer generated code

		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			tbJahr = new RJTextBox();
			tbName = new RJTextBox();
			tbNr = new RJTextBox();
			tbWohnort = new RJTextBox();
			dropBeratung = new DropDown();
			dropMigra = new DropDown();
			dropAnregung = new DropDown();
			dropGrund = new DropDown();
			toggleWieder = new RJCodeAdvance.RJControls.RJToggleButton();
			label1 = new Label();
			toggleAbgeschlossen = new RJCodeAdvance.RJControls.RJToggleButton();
			label2 = new Label();
			btnSave = new RJCodeAdvance.RJControls.RJButton();
			ContentFrame = new Panel();
			TabNavControl = new Panel();
			ButtonP2a = new Button();
			ButtonArge = new Button();
			ButtonAllgSgs = new Button();
			ButtonP56 = new Button();
			ButtonMutterKind = new Button();
			ButtonSgb8 = new Button();
			ButtonEheUndLeben = new Button();
			panelToggle = new Panel();
			toggleARGE = new RJCodeAdvance.RJControls.RJToggleButton();
			lblARGE = new Label();
			gridAlter = new DataGridView();
			Person = new DataGridViewTextBoxColumn();
			m = new DataGridViewTextBoxColumn();
			w = new DataGridViewTextBoxColumn();
			nb = new DataGridViewTextBoxColumn();
			panelBlocker = new Panel();
			rjButton1 = new RJCodeAdvance.RJControls.RJButton();
			label3 = new Label();
			btnDebug = new RJCodeAdvance.RJControls.RJButton();
			indicateSaved = new ProgressBar();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			tbDatum = new RJTextBox();
			Abschlussdatum = new Label();
			ContentFrame.SuspendLayout();
			TabNavControl.SuspendLayout();
			panelToggle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridAlter).BeginInit();
			panelBlocker.SuspendLayout();
			SuspendLayout();
			// 
			// tbJahr
			// 
			tbJahr.BackColor = SystemColors.Window;
			tbJahr.BorderColor = Color.Black;
			tbJahr.BorderFocusColor = Color.Green;
			tbJahr.BorderRadius = 0;
			tbJahr.BorderSize = 1;
			tbJahr.Font = new Font("Segoe UI", 9.75F);
			tbJahr.ForeColor = Color.FromArgb(13, 47, 48);
			tbJahr.Location = new Point(72, 18);
			tbJahr.Margin = new Padding(0);
			tbJahr.Multiline = false;
			tbJahr.Name = "tbJahr";
			tbJahr.Padding = new Padding(10, 7, 10, 7);
			tbJahr.PasswordChar = false;
			tbJahr.PlaceholderColor = Color.DarkGray;
			tbJahr.PlaceholderText = "Jahr";
			tbJahr.Size = new Size(200, 32);
			tbJahr.TabIndex = 0;
			tbJahr.Texts = "";
			tbJahr.UnderlinedStyle = true;
			tbJahr.Click += OnTextBoxClick;
			tbJahr.Enter += OnTextBoxClick;
			// 
			// tbName
			// 
			tbName.BackColor = SystemColors.Window;
			tbName.BorderColor = Color.Black;
			tbName.BorderFocusColor = Color.Green;
			tbName.BorderRadius = 0;
			tbName.BorderSize = 1;
			tbName.Font = new Font("Segoe UI", 9.75F);
			tbName.ForeColor = Color.FromArgb(13, 47, 48);
			tbName.Location = new Point(72, 72);
			tbName.Margin = new Padding(0);
			tbName.Multiline = false;
			tbName.Name = "tbName";
			tbName.Padding = new Padding(10, 7, 10, 7);
			tbName.PasswordChar = false;
			tbName.PlaceholderColor = Color.DarkGray;
			tbName.PlaceholderText = "Name";
			tbName.Size = new Size(200, 32);
			tbName.TabIndex = 2;
			tbName.Texts = "";
			tbName.UnderlinedStyle = true;
			tbName.Click += OnTextBoxClick;
			tbName.Enter += OnTextBoxClick;
			// 
			// tbNr
			// 
			tbNr.BackColor = SystemColors.Window;
			tbNr.BorderColor = Color.Black;
			tbNr.BorderFocusColor = Color.Green;
			tbNr.BorderRadius = 0;
			tbNr.BorderSize = 1;
			tbNr.Font = new Font("Segoe UI", 9.75F);
			tbNr.ForeColor = Color.FromArgb(13, 47, 48);
			tbNr.Location = new Point(291, 18);
			tbNr.Margin = new Padding(0);
			tbNr.Multiline = false;
			tbNr.Name = "tbNr";
			tbNr.Padding = new Padding(10, 7, 10, 7);
			tbNr.PasswordChar = false;
			tbNr.PlaceholderColor = Color.DarkGray;
			tbNr.PlaceholderText = "Anmeldenummer";
			tbNr.Size = new Size(214, 32);
			tbNr.TabIndex = 1;
			tbNr.Texts = "";
			tbNr.UnderlinedStyle = true;
			tbNr.Click += OnTextBoxClick;
			tbNr.Enter += OnTextBoxClick;
			// 
			// tbWohnort
			// 
			tbWohnort.BackColor = SystemColors.Window;
			tbWohnort.BorderColor = Color.Black;
			tbWohnort.BorderFocusColor = Color.Green;
			tbWohnort.BorderRadius = 0;
			tbWohnort.BorderSize = 1;
			tbWohnort.Font = new Font("Segoe UI", 9.75F);
			tbWohnort.ForeColor = Color.FromArgb(13, 47, 48);
			tbWohnort.Location = new Point(291, 72);
			tbWohnort.Margin = new Padding(0);
			tbWohnort.Multiline = false;
			tbWohnort.Name = "tbWohnort";
			tbWohnort.Padding = new Padding(10, 7, 10, 7);
			tbWohnort.PasswordChar = false;
			tbWohnort.PlaceholderColor = Color.DarkGray;
			tbWohnort.PlaceholderText = "Wohnort";
			tbWohnort.Size = new Size(214, 32);
			tbWohnort.TabIndex = 3;
			tbWohnort.Texts = "";
			tbWohnort.UnderlinedStyle = true;
			tbWohnort.Click += OnTextBoxClick;
			tbWohnort.Enter += OnTextBoxClick;
			// 
			// dropBeratung
			// 
			dropBeratung.BackColor = Color.WhiteSmoke;
			dropBeratung.BorderColor = Color.Black;
			dropBeratung.BorderSize = 1;
			dropBeratung.DropDownStyle = ComboBoxStyle.DropDownList;
			dropBeratung.Font = new Font("Segoe UI", 10F);
			dropBeratung.ForeColor = Color.FromArgb(13, 47, 48);
			dropBeratung.IconColor = Color.Black;
			dropBeratung.ListBackColor = Color.FromArgb(230, 228, 245);
			dropBeratung.ListTextColor = Color.DimGray;
			dropBeratung.Location = new Point(74, 140);
			dropBeratung.Margin = new Padding(10);
			dropBeratung.MinimumSize = new Size(200, 30);
			dropBeratung.Name = "dropBeratung";
			dropBeratung.Padding = new Padding(1);
			dropBeratung.Size = new Size(200, 32);
			dropBeratung.TabIndex = 4;
			dropBeratung.Texts = "";
			dropBeratung.Click += OnDropDownClick;
			dropBeratung.Enter += OnDropDownClick;
			// 
			// dropMigra
			// 
			dropMigra.BackColor = Color.WhiteSmoke;
			dropMigra.BorderColor = Color.Black;
			dropMigra.BorderSize = 1;
			dropMigra.DropDownStyle = ComboBoxStyle.DropDownList;
			dropMigra.Font = new Font("Segoe UI", 10F);
			dropMigra.ForeColor = Color.FromArgb(13, 47, 48);
			dropMigra.IconColor = Color.Black;
			dropMigra.ListBackColor = Color.FromArgb(230, 228, 245);
			dropMigra.ListTextColor = Color.DimGray;
			dropMigra.Location = new Point(293, 140);
			dropMigra.Margin = new Padding(10);
			dropMigra.MinimumSize = new Size(200, 30);
			dropMigra.Name = "dropMigra";
			dropMigra.Padding = new Padding(1);
			dropMigra.Size = new Size(214, 32);
			dropMigra.TabIndex = 5;
			dropMigra.Texts = "";
			dropMigra.Click += OnDropDownClick;
			dropMigra.Enter += OnDropDownClick;
			// 
			// dropAnregung
			// 
			dropAnregung.BackColor = Color.WhiteSmoke;
			dropAnregung.BorderColor = Color.Black;
			dropAnregung.BorderSize = 1;
			dropAnregung.DropDownStyle = ComboBoxStyle.DropDownList;
			dropAnregung.Font = new Font("Segoe UI", 10F);
			dropAnregung.ForeColor = Color.FromArgb(13, 47, 48);
			dropAnregung.IconColor = Color.Black;
			dropAnregung.ListBackColor = Color.FromArgb(230, 228, 245);
			dropAnregung.ListTextColor = Color.DimGray;
			dropAnregung.Location = new Point(74, 184);
			dropAnregung.Margin = new Padding(10);
			dropAnregung.MinimumSize = new Size(200, 30);
			dropAnregung.Name = "dropAnregung";
			dropAnregung.Padding = new Padding(1);
			dropAnregung.Size = new Size(200, 32);
			dropAnregung.TabIndex = 6;
			dropAnregung.Texts = "";
			dropAnregung.Click += OnDropDownClick;
			dropAnregung.Enter += OnDropDownClick;
			// 
			// dropGrund
			// 
			dropGrund.BackColor = Color.WhiteSmoke;
			dropGrund.BorderColor = Color.DarkGray;
			dropGrund.BorderSize = 1;
			dropGrund.DropDownStyle = ComboBoxStyle.DropDownList;
			dropGrund.Enabled = false;
			dropGrund.Font = new Font("Segoe UI", 10F);
			dropGrund.ForeColor = Color.DimGray;
			dropGrund.IconColor = Color.Gray;
			dropGrund.ListBackColor = Color.FromArgb(230, 228, 245);
			dropGrund.ListTextColor = Color.DimGray;
			dropGrund.Location = new Point(217, 40);
			dropGrund.Margin = new Padding(10);
			dropGrund.MinimumSize = new Size(200, 30);
			dropGrund.Name = "dropGrund";
			dropGrund.Padding = new Padding(1);
			dropGrund.Size = new Size(200, 32);
			dropGrund.TabIndex = 11;
			dropGrund.Texts = "";
			dropGrund.Click += OnDropDownClick;
			dropGrund.Enter += OnDropDownClick;
			// 
			// toggleWieder
			// 
			toggleWieder.AutoSize = true;
			toggleWieder.Location = new Point(20, 11);
			toggleWieder.MinimumSize = new Size(45, 22);
			toggleWieder.Name = "toggleWieder";
			toggleWieder.OffBackColor = Color.Gray;
			toggleWieder.OffToggleColor = Color.Gainsboro;
			toggleWieder.OnBackColor = Color.FromArgb(13, 47, 48);
			toggleWieder.OnToggleColor = Color.WhiteSmoke;
			toggleWieder.Size = new Size(45, 22);
			toggleWieder.TabIndex = 8;
			toggleWieder.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F);
			label1.ForeColor = Color.FromArgb(13, 47, 48);
			label1.Location = new Point(71, 12);
			label1.Name = "label1";
			label1.Size = new Size(115, 17);
			label1.TabIndex = 5;
			label1.Text = "Wiederanmeldung";
			// 
			// toggleAbgeschlossen
			// 
			toggleAbgeschlossen.AutoSize = true;
			toggleAbgeschlossen.Location = new Point(20, 50);
			toggleAbgeschlossen.MinimumSize = new Size(45, 22);
			toggleAbgeschlossen.Name = "toggleAbgeschlossen";
			toggleAbgeschlossen.OffBackColor = Color.Gray;
			toggleAbgeschlossen.OffToggleColor = Color.Gainsboro;
			toggleAbgeschlossen.OnBackColor = Color.Green;
			toggleAbgeschlossen.OnToggleColor = Color.WhiteSmoke;
			toggleAbgeschlossen.Size = new Size(45, 22);
			toggleAbgeschlossen.TabIndex = 9;
			toggleAbgeschlossen.UseVisualStyleBackColor = true;
			toggleAbgeschlossen.CheckedChanged += OnToggle;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F);
			label2.ForeColor = Color.FromArgb(13, 47, 48);
			label2.Location = new Point(71, 51);
			label2.Name = "label2";
			label2.Size = new Size(95, 17);
			label2.TabIndex = 5;
			label2.Text = "Abgeschlossen";
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.White;
			btnSave.BackgroundColor = Color.White;
			btnSave.BorderColor = Color.Transparent;
			btnSave.BorderRadius = 0;
			btnSave.BorderSize = 1;
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Font = new Font("Segoe UI", 12F);
			btnSave.ForeColor = Color.FromArgb(13, 47, 48);
			btnSave.Location = new Point(291, 580);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(214, 40);
			btnSave.TabIndex = 100;
			btnSave.Text = "Speichern";
			btnSave.TextColor = Color.FromArgb(13, 47, 48);
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += OnButtonSave;
			// 
			// ContentFrame
			// 
			ContentFrame.BackColor = Color.White;
			ContentFrame.Controls.Add(TabNavControl);
			ContentFrame.Location = new Point(525, 30);
			ContentFrame.Name = "ContentFrame";
			ContentFrame.Size = new Size(500, 590);
			ContentFrame.TabIndex = 7;
			// 
			// TabNavControl
			// 
			TabNavControl.BackColor = Color.WhiteSmoke;
			TabNavControl.Controls.Add(ButtonP2a);
			TabNavControl.Controls.Add(ButtonArge);
			TabNavControl.Controls.Add(ButtonAllgSgs);
			TabNavControl.Controls.Add(ButtonP56);
			TabNavControl.Controls.Add(ButtonMutterKind);
			TabNavControl.Controls.Add(ButtonSgb8);
			TabNavControl.Controls.Add(ButtonEheUndLeben);
			TabNavControl.Dock = DockStyle.Top;
			TabNavControl.Location = new Point(0, 0);
			TabNavControl.Name = "TabNavControl";
			TabNavControl.Size = new Size(500, 30);
			TabNavControl.TabIndex = 8;
			// 
			// ButtonP2a
			// 
			ButtonP2a.AutoSize = true;
			ButtonP2a.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonP2a.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonP2a.Dock = DockStyle.Left;
			ButtonP2a.FlatAppearance.BorderSize = 0;
			ButtonP2a.FlatStyle = FlatStyle.Flat;
			ButtonP2a.Location = new Point(408, 0);
			ButtonP2a.Margin = new Padding(5);
			ButtonP2a.Name = "ButtonP2a";
			ButtonP2a.Size = new Size(37, 30);
			ButtonP2a.TabIndex = 3;
			ButtonP2a.Text = "§ 2a";
			ButtonP2a.UseVisualStyleBackColor = false;
			ButtonP2a.Click += ButtonP2a_Click;
			ButtonP2a.Paint += OnTabNavPaint;
			// 
			// ButtonArge
			// 
			ButtonArge.AutoSize = true;
			ButtonArge.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonArge.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonArge.Dock = DockStyle.Left;
			ButtonArge.FlatAppearance.BorderSize = 0;
			ButtonArge.FlatStyle = FlatStyle.Flat;
			ButtonArge.Location = new Point(362, 0);
			ButtonArge.Margin = new Padding(5);
			ButtonArge.Name = "ButtonArge";
			ButtonArge.Size = new Size(46, 30);
			ButtonArge.TabIndex = 3;
			ButtonArge.Text = "ARGE";
			ButtonArge.UseVisualStyleBackColor = false;
			ButtonArge.Click += ButtonArge_Click;
			ButtonArge.Paint += OnTabNavPaint;
			// 
			// ButtonAllgSgs
			// 
			ButtonAllgSgs.AutoSize = true;
			ButtonAllgSgs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonAllgSgs.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonAllgSgs.Dock = DockStyle.Left;
			ButtonAllgSgs.FlatAppearance.BorderSize = 0;
			ButtonAllgSgs.FlatStyle = FlatStyle.Flat;
			ButtonAllgSgs.Location = new Point(277, 0);
			ButtonAllgSgs.Margin = new Padding(5);
			ButtonAllgSgs.Name = "ButtonAllgSgs";
			ButtonAllgSgs.Size = new Size(85, 30);
			ButtonAllgSgs.TabIndex = 3;
			ButtonAllgSgs.Text = "allg. Schwgs.";
			ButtonAllgSgs.UseVisualStyleBackColor = false;
			ButtonAllgSgs.Click += ButtonAllgSgs_Click;
			ButtonAllgSgs.Paint += OnTabNavPaint;
			// 
			// ButtonP56
			// 
			ButtonP56.AutoSize = true;
			ButtonP56.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonP56.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonP56.Dock = DockStyle.Left;
			ButtonP56.FlatAppearance.BorderSize = 0;
			ButtonP56.FlatStyle = FlatStyle.Flat;
			ButtonP56.Location = new Point(234, 0);
			ButtonP56.Margin = new Padding(5);
			ButtonP56.Name = "ButtonP56";
			ButtonP56.Size = new Size(43, 30);
			ButtonP56.TabIndex = 3;
			ButtonP56.Text = "§ 218";
			ButtonP56.UseVisualStyleBackColor = false;
			ButtonP56.Click += ButtonP56_Click;
			ButtonP56.Paint += OnTabNavPaint;
			// 
			// ButtonMutterKind
			// 
			ButtonMutterKind.AutoSize = true;
			ButtonMutterKind.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonMutterKind.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonMutterKind.Dock = DockStyle.Left;
			ButtonMutterKind.FlatAppearance.BorderSize = 0;
			ButtonMutterKind.FlatStyle = FlatStyle.Flat;
			ButtonMutterKind.Location = new Point(152, 0);
			ButtonMutterKind.Margin = new Padding(5);
			ButtonMutterKind.Name = "ButtonMutterKind";
			ButtonMutterKind.Size = new Size(82, 30);
			ButtonMutterKind.TabIndex = 2;
			ButtonMutterKind.Text = "Mutter-Kind";
			ButtonMutterKind.UseVisualStyleBackColor = false;
			ButtonMutterKind.Click += ButtonMutterKind_Click;
			ButtonMutterKind.Paint += OnTabNavPaint;
			// 
			// ButtonSgb8
			// 
			ButtonSgb8.AutoSize = true;
			ButtonSgb8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonSgb8.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonSgb8.Dock = DockStyle.Left;
			ButtonSgb8.FlatAppearance.BorderSize = 0;
			ButtonSgb8.FlatStyle = FlatStyle.Flat;
			ButtonSgb8.Location = new Point(95, 0);
			ButtonSgb8.Margin = new Padding(5);
			ButtonSgb8.Name = "ButtonSgb8";
			ButtonSgb8.Size = new Size(57, 30);
			ButtonSgb8.TabIndex = 0;
			ButtonSgb8.Text = "SGB VIII";
			ButtonSgb8.UseVisualStyleBackColor = false;
			ButtonSgb8.Click += ButtonSgb8_Click;
			ButtonSgb8.Paint += OnTabNavPaint;
			// 
			// ButtonEheUndLeben
			// 
			ButtonEheUndLeben.AutoSize = true;
			ButtonEheUndLeben.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ButtonEheUndLeben.BackColor = Color.FromArgb(200, 255, 255, 255);
			ButtonEheUndLeben.Dock = DockStyle.Left;
			ButtonEheUndLeben.FlatAppearance.BorderSize = 0;
			ButtonEheUndLeben.FlatStyle = FlatStyle.Flat;
			ButtonEheUndLeben.Location = new Point(0, 0);
			ButtonEheUndLeben.Margin = new Padding(5);
			ButtonEheUndLeben.Name = "ButtonEheUndLeben";
			ButtonEheUndLeben.Size = new Size(95, 30);
			ButtonEheUndLeben.TabIndex = 1;
			ButtonEheUndLeben.Text = "Ehe und Leben";
			ButtonEheUndLeben.UseVisualStyleBackColor = false;
			ButtonEheUndLeben.Click += ButtonEheUndLeben_Click;
			ButtonEheUndLeben.Paint += OnTabNavPaint;
			// 
			// panelToggle
			// 
			panelToggle.BackColor = Color.White;
			panelToggle.Controls.Add(toggleARGE);
			panelToggle.Controls.Add(toggleWieder);
			panelToggle.Controls.Add(lblARGE);
			panelToggle.Controls.Add(toggleAbgeschlossen);
			panelToggle.Controls.Add(label1);
			panelToggle.Controls.Add(label2);
			panelToggle.Controls.Add(dropGrund);
			panelToggle.Location = new Point(74, 469);
			panelToggle.Name = "panelToggle";
			panelToggle.Padding = new Padding(3);
			panelToggle.Size = new Size(431, 82);
			panelToggle.TabIndex = 8;
			// 
			// toggleARGE
			// 
			toggleARGE.AutoSize = true;
			toggleARGE.Location = new Point(217, 12);
			toggleARGE.MinimumSize = new Size(45, 22);
			toggleARGE.Name = "toggleARGE";
			toggleARGE.OffBackColor = Color.Gray;
			toggleARGE.OffToggleColor = Color.Gainsboro;
			toggleARGE.OnBackColor = Color.Green;
			toggleARGE.OnToggleColor = Color.WhiteSmoke;
			toggleARGE.Size = new Size(45, 22);
			toggleARGE.TabIndex = 8;
			toggleARGE.UseVisualStyleBackColor = true;
			// 
			// lblARGE
			// 
			lblARGE.AutoSize = true;
			lblARGE.Font = new Font("Segoe UI", 9.75F);
			lblARGE.ForeColor = Color.FromArgb(13, 47, 48);
			lblARGE.Location = new Point(268, 13);
			lblARGE.Name = "lblARGE";
			lblARGE.Size = new Size(40, 17);
			lblARGE.TabIndex = 5;
			lblARGE.Text = "ARGE";
			// 
			// gridAlter
			// 
			gridAlter.AllowUserToAddRows = false;
			gridAlter.AllowUserToDeleteRows = false;
			gridAlter.AllowUserToResizeColumns = false;
			gridAlter.AllowUserToResizeRows = false;
			gridAlter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridAlter.BackgroundColor = SystemColors.ControlLight;
			gridAlter.BorderStyle = BorderStyle.Fixed3D;
			gridAlter.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			gridAlter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			gridAlter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridAlter.Columns.AddRange(new DataGridViewColumn[] { Person, m, w, nb });
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Window;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = Color.LightGreen;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			gridAlter.DefaultCellStyle = dataGridViewCellStyle4;
			gridAlter.GridColor = SystemColors.ControlLight;
			gridAlter.Location = new Point(74, 238);
			gridAlter.Name = "gridAlter";
			gridAlter.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			gridAlter.RowHeadersVisible = false;
			gridAlter.RowHeadersWidth = 40;
			gridAlter.RowTemplate.Height = 25;
			gridAlter.ScrollBars = ScrollBars.None;
			gridAlter.Size = new Size(433, 203);
			gridAlter.TabIndex = 7;
			gridAlter.CellContentClick += gridAlter_CellContentClick;
			gridAlter.CellValueChanged += OnValueChanged;
			// 
			// Person
			// 
			Person.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			Person.FillWeight = 105F;
			Person.HeaderText = "Person";
			Person.MinimumWidth = 100;
			Person.Name = "Person";
			Person.ReadOnly = true;
			Person.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// m
			// 
			m.FillWeight = 52.11506F;
			m.HeaderText = "männlich";
			m.Name = "m";
			m.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// w
			// 
			w.FillWeight = 52.11506F;
			w.HeaderText = "weiblich";
			w.Name = "w";
			w.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// nb
			// 
			nb.FillWeight = 52.11506F;
			nb.HeaderText = "non-binär";
			nb.Name = "nb";
			nb.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// panelBlocker
			// 
			panelBlocker.BackColor = Color.FromArgb(210, 255, 255, 255);
			panelBlocker.Controls.Add(rjButton1);
			panelBlocker.Controls.Add(label3);
			panelBlocker.Location = new Point(525, 30);
			panelBlocker.Name = "panelBlocker";
			panelBlocker.Size = new Size(500, 590);
			panelBlocker.TabIndex = 14;
			panelBlocker.Paint += panelBlocker_Paint;
			// 
			// rjButton1
			// 
			rjButton1.BackColor = Color.FromArgb(13, 47, 48);
			rjButton1.BackgroundColor = Color.FromArgb(13, 47, 48);
			rjButton1.BorderColor = Color.Transparent;
			rjButton1.BorderRadius = 0;
			rjButton1.BorderSize = 1;
			rjButton1.FlatAppearance.BorderSize = 0;
			rjButton1.FlatStyle = FlatStyle.Flat;
			rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			rjButton1.ForeColor = Color.White;
			rjButton1.Location = new Point(152, 511);
			rjButton1.Name = "rjButton1";
			rjButton1.Size = new Size(200, 40);
			rjButton1.TabIndex = 6;
			rjButton1.Text = "Ohne Seite 1 fortfahren";
			rjButton1.TextColor = Color.White;
			rjButton1.UseVisualStyleBackColor = false;
			rjButton1.Click += OnButtonSkip;
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 14F);
			label3.ForeColor = Color.FromArgb(23, 54, 48);
			label3.Location = new Point(0, 57);
			label3.Name = "label3";
			label3.Size = new Size(502, 198);
			label3.TabIndex = 0;
			label3.Text = "Da einige Tabellen auf allgemeine Daten zur \r\nPerson und Anmeldung zugreifen, ist es notwendig\r\ndiese zuerst vorzunehmen und zu speichern.";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnDebug
			// 
			btnDebug.BackColor = Color.Gray;
			btnDebug.BackgroundColor = Color.Gray;
			btnDebug.BorderColor = Color.Transparent;
			btnDebug.BorderRadius = 0;
			btnDebug.BorderSize = 1;
			btnDebug.FlatAppearance.BorderSize = 0;
			btnDebug.FlatStyle = FlatStyle.Flat;
			btnDebug.Font = new Font("Segoe UI", 12F);
			btnDebug.ForeColor = Color.White;
			btnDebug.Location = new Point(293, 184);
			btnDebug.Name = "btnDebug";
			btnDebug.Size = new Size(214, 32);
			btnDebug.TabIndex = 6;
			btnDebug.Text = "(debug)";
			btnDebug.TextColor = Color.White;
			btnDebug.UseVisualStyleBackColor = false;
			btnDebug.Visible = false;
			btnDebug.Click += OnButtonFill;
			// 
			// indicateSaved
			// 
			indicateSaved.ForeColor = Color.Green;
			indicateSaved.Location = new Point(72, 643);
			indicateSaved.Name = "indicateSaved";
			indicateSaved.Size = new Size(953, 23);
			indicateSaved.Style = ProgressBarStyle.Continuous;
			indicateSaved.TabIndex = 23;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 9.75F);
			label4.ForeColor = Color.White;
			label4.Location = new Point(72, 50);
			label4.Name = "label4";
			label4.Size = new Size(32, 17);
			label4.TabIndex = 5;
			label4.Text = "Jahr";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 9.75F);
			label5.ForeColor = Color.White;
			label5.Location = new Point(293, 50);
			label5.Name = "label5";
			label5.Size = new Size(107, 17);
			label5.TabIndex = 5;
			label5.Text = "Anmeldenummer";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 9.75F);
			label6.ForeColor = Color.White;
			label6.Location = new Point(72, 104);
			label6.Name = "label6";
			label6.Size = new Size(43, 17);
			label6.TabIndex = 5;
			label6.Text = "Name";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI", 9.75F);
			label7.ForeColor = Color.White;
			label7.Location = new Point(293, 104);
			label7.Name = "label7";
			label7.Size = new Size(58, 17);
			label7.TabIndex = 5;
			label7.Text = "Wohnort";
			// 
			// tbDatum
			// 
			tbDatum.BackColor = SystemColors.Window;
			tbDatum.BorderColor = Color.Black;
			tbDatum.BorderFocusColor = Color.Green;
			tbDatum.BorderRadius = 0;
			tbDatum.BorderSize = 1;
			tbDatum.Font = new Font("Segoe UI", 9.75F);
			tbDatum.ForeColor = Color.FromArgb(13, 47, 48);
			tbDatum.Location = new Point(74, 580);
			tbDatum.Margin = new Padding(0);
			tbDatum.Multiline = false;
			tbDatum.Name = "tbDatum";
			tbDatum.Padding = new Padding(10, 7, 10, 7);
			tbDatum.PasswordChar = false;
			tbDatum.PlaceholderColor = Color.DarkGray;
			tbDatum.PlaceholderText = "Abgeschlossen am";
			tbDatum.Size = new Size(200, 32);
			tbDatum.TabIndex = 12;
			tbDatum.Texts = "";
			tbDatum.UnderlinedStyle = true;
			tbDatum.Click += OnTextBoxClick;
			tbDatum.Enter += OnTextBoxClick;
			// 
			// Abschlussdatum
			// 
			Abschlussdatum.AutoSize = true;
			Abschlussdatum.BackColor = Color.Transparent;
			Abschlussdatum.Font = new Font("Segoe UI", 9.75F);
			Abschlussdatum.ForeColor = Color.White;
			Abschlussdatum.Location = new Point(74, 612);
			Abschlussdatum.Name = "Abschlussdatum";
			Abschlussdatum.Size = new Size(117, 17);
			Abschlussdatum.TabIndex = 5;
			Abschlussdatum.Text = "Abgeschlossen am";
			// 
			// FrameAddNew
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(40, 255, 255, 255);
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(indicateSaved);
			Controls.Add(label7);
			Controls.Add(Abschlussdatum);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(panelBlocker);
			Controls.Add(gridAlter);
			Controls.Add(panelToggle);
			Controls.Add(ContentFrame);
			Controls.Add(btnDebug);
			Controls.Add(btnSave);
			Controls.Add(tbWohnort);
			Controls.Add(tbNr);
			Controls.Add(tbDatum);
			Controls.Add(tbName);
			Controls.Add(tbJahr);
			Controls.Add(dropMigra);
			Controls.Add(dropAnregung);
			Controls.Add(dropBeratung);
			ForeColor = Color.White;
			Margin = new Padding(0);
			Name = "FrameAddNew";
			Size = new Size(1076, 686);
			Tag = "Frame";
			Load += OnLoad;
			ContentFrame.ResumeLayout(false);
			TabNavControl.ResumeLayout(false);
			TabNavControl.PerformLayout();
			panelToggle.ResumeLayout(false);
			panelToggle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gridAlter).EndInit();
			panelBlocker.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private RJTextBox tbJahr;
        private RJTextBox tbName;
        private RJTextBox tbNr;
        private RJTextBox tbWohnort;
        private DropDown dropBeratung;
        private DropDown dropMigra;
        private DropDown dropAnregung;
        private DropDown dropGrund;
        private RJCodeAdvance.RJControls.RJToggleButton toggleWieder;
        private Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton toggleAbgeschlossen;
        private Label label2;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel ContentFrame;
        private Panel TabNavControl;
        private Button ButtonP2a;
        private Button ButtonArge;
        private Button ButtonAllgSgs;
        private Button ButtonP56;
        private Button ButtonMutterKind;
        private Button ButtonSgb8;
        private Button ButtonEheUndLeben;
        private Panel panelToggle;
        private DataGridView gridAlter;
        private Panel panelBlocker;
        private Label label3;
        private RJCodeAdvance.RJControls.RJButton btnDebug;
        private DataGridViewTextBoxColumn Person;
        private DataGridViewTextBoxColumn m;
        private DataGridViewTextBoxColumn w;
        private DataGridViewTextBoxColumn nb;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private ProgressBar indicateSaved;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RJTextBox tbDatum;
        private Label Abschlussdatum;
		private RJCodeAdvance.RJControls.RJToggleButton toggleARGE;
		private Label lblARGE;
	}
}
