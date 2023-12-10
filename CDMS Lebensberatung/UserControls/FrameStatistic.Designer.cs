namespace CDMS_Lebensberatung.UserControls
{
    partial class FrameStatistics
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			gridAge = new DataGridView();
			cbNeu = new CheckBox();
			cbMale = new CheckBox();
			cbFemale = new CheckBox();
			cbNonBin = new CheckBox();
			cb1Jahr = new CheckBox();
			cb2Jahr = new CheckBox();
			cbAllg = new CheckBox();
			cbSGB8 = new CheckBox();
			cbSchwanger = new CheckBox();
			cbRA = new CheckBox();
			cbBurgwedel = new CheckBox();
			cbIsernhagen = new CheckBox();
			cbWedemark = new CheckBox();
			cbAndere = new CheckBox();
			filterPanel = new Panel();
			gOrt = new GroupBox();
			gBeratung = new GroupBox();
			cb218 = new CheckBox();
			gGeschlecht = new GroupBox();
			label3 = new Label();
			gNeu = new GroupBox();
			panel1 = new Panel();
			xlsx = new RJCodeAdvance.RJControls.RJButton();
			label2 = new Label();
			exportStatisticsFileSave = new SaveFileDialog();
			checkListStats = new CheckedListBox();
			((System.ComponentModel.ISupportInitialize)gridAge).BeginInit();
			filterPanel.SuspendLayout();
			gOrt.SuspendLayout();
			gBeratung.SuspendLayout();
			gGeschlecht.SuspendLayout();
			gNeu.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// gridAge
			// 
			gridAge.AllowUserToAddRows = false;
			gridAge.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
			gridAge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			gridAge.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			gridAge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridAge.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridAge.BackgroundColor = SystemColors.ControlLightLight;
			gridAge.BorderStyle = BorderStyle.Fixed3D;
			gridAge.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			gridAge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			gridAge.ColumnHeadersHeight = 32;
			gridAge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Honeydew;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			gridAge.DefaultCellStyle = dataGridViewCellStyle3;
			gridAge.Location = new Point(23, 54);
			gridAge.Margin = new Padding(0);
			gridAge.Name = "gridAge";
			gridAge.ReadOnly = true;
			gridAge.RowHeadersVisible = false;
			gridAge.RowHeadersWidth = 51;
			gridAge.RowTemplate.Height = 25;
			gridAge.ShowCellErrors = false;
			gridAge.ShowCellToolTips = false;
			gridAge.ShowEditingIcon = false;
			gridAge.ShowRowErrors = false;
			gridAge.Size = new Size(200, 514);
			gridAge.TabIndex = 1;
			// 
			// cbNeu
			// 
			cbNeu.AutoSize = true;
			cbNeu.BackColor = Color.Transparent;
			cbNeu.Location = new Point(6, 22);
			cbNeu.Name = "cbNeu";
			cbNeu.Size = new Size(109, 19);
			cbNeu.TabIndex = 3;
			cbNeu.Text = "Neuanmeldung";
			cbNeu.UseVisualStyleBackColor = false;
			cbNeu.CheckedChanged += OnCheckedChanged;
			// 
			// cbMale
			// 
			cbMale.AutoSize = true;
			cbMale.BackColor = Color.Transparent;
			cbMale.Location = new Point(6, 22);
			cbMale.Name = "cbMale";
			cbMale.Size = new Size(76, 19);
			cbMale.TabIndex = 3;
			cbMale.Text = "Männlich";
			cbMale.UseVisualStyleBackColor = false;
			cbMale.CheckedChanged += OnCheckedChanged;
			// 
			// cbFemale
			// 
			cbFemale.AutoSize = true;
			cbFemale.BackColor = Color.Transparent;
			cbFemale.Location = new Point(6, 47);
			cbFemale.Name = "cbFemale";
			cbFemale.Size = new Size(72, 19);
			cbFemale.TabIndex = 3;
			cbFemale.Text = "Weiblich";
			cbFemale.UseVisualStyleBackColor = false;
			cbFemale.CheckedChanged += OnCheckedChanged;
			// 
			// cbNonBin
			// 
			cbNonBin.AutoSize = true;
			cbNonBin.BackColor = Color.Transparent;
			cbNonBin.Location = new Point(6, 72);
			cbNonBin.Name = "cbNonBin";
			cbNonBin.Size = new Size(81, 19);
			cbNonBin.TabIndex = 3;
			cbNonBin.Text = "Non-Binär";
			cbNonBin.UseVisualStyleBackColor = false;
			cbNonBin.CheckedChanged += OnCheckedChanged;
			// 
			// cb1Jahr
			// 
			cb1Jahr.AutoSize = true;
			cb1Jahr.BackColor = Color.Transparent;
			cb1Jahr.Location = new Point(6, 47);
			cb1Jahr.Name = "cb1Jahr";
			cb1Jahr.Size = new Size(86, 19);
			cb1Jahr.TabIndex = 3;
			cb1Jahr.Text = "Aus Vorjahr";
			cb1Jahr.UseVisualStyleBackColor = false;
			cb1Jahr.CheckedChanged += OnCheckedChanged;
			// 
			// cb2Jahr
			// 
			cb2Jahr.AutoSize = true;
			cb2Jahr.BackColor = Color.Transparent;
			cb2Jahr.Location = new Point(6, 72);
			cb2Jahr.Name = "cb2Jahr";
			cb2Jahr.Size = new Size(108, 19);
			cb2Jahr.TabIndex = 3;
			cb2Jahr.Text = "Aus Vor-Vorjahr";
			cb2Jahr.UseVisualStyleBackColor = false;
			cb2Jahr.CheckedChanged += OnCheckedChanged;
			// 
			// cbAllg
			// 
			cbAllg.AutoSize = true;
			cbAllg.BackColor = Color.Transparent;
			cbAllg.Location = new Point(6, 22);
			cbAllg.Name = "cbAllg";
			cbAllg.Size = new Size(138, 19);
			cbAllg.TabIndex = 3;
			cbAllg.Text = "Allg. Lebensberatung";
			cbAllg.UseVisualStyleBackColor = false;
			cbAllg.CheckedChanged += OnCheckedChanged;
			// 
			// cbSGB8
			// 
			cbSGB8.AutoSize = true;
			cbSGB8.BackColor = Color.Transparent;
			cbSGB8.Location = new Point(6, 47);
			cbSGB8.Name = "cbSGB8";
			cbSGB8.Size = new Size(66, 19);
			cbSGB8.TabIndex = 3;
			cbSGB8.Text = "SGB VIII";
			cbSGB8.UseVisualStyleBackColor = false;
			cbSGB8.CheckedChanged += OnCheckedChanged;
			// 
			// cbSchwanger
			// 
			cbSchwanger.AutoSize = true;
			cbSchwanger.BackColor = Color.Transparent;
			cbSchwanger.Location = new Point(6, 72);
			cbSchwanger.Name = "cbSchwanger";
			cbSchwanger.Size = new Size(116, 19);
			cbSchwanger.TabIndex = 3;
			cbSchwanger.Text = "Schwangerschaft";
			cbSchwanger.UseVisualStyleBackColor = false;
			cbSchwanger.CheckedChanged += OnCheckedChanged;
			// 
			// cbRA
			// 
			cbRA.AutoSize = true;
			cbRA.BackColor = Color.Transparent;
			cbRA.Location = new Point(6, 122);
			cbRA.Name = "cbRA";
			cbRA.Size = new Size(115, 19);
			cbRA.TabIndex = 3;
			cbRA.Text = "Rechtsanwaltlich";
			cbRA.UseVisualStyleBackColor = false;
			cbRA.CheckedChanged += OnCheckedChanged;
			// 
			// cbBurgwedel
			// 
			cbBurgwedel.AutoSize = true;
			cbBurgwedel.BackColor = Color.Transparent;
			cbBurgwedel.Location = new Point(6, 22);
			cbBurgwedel.Name = "cbBurgwedel";
			cbBurgwedel.Size = new Size(82, 19);
			cbBurgwedel.TabIndex = 3;
			cbBurgwedel.Text = "Burgwedel";
			cbBurgwedel.UseVisualStyleBackColor = false;
			cbBurgwedel.CheckedChanged += OnCheckedChanged;
			// 
			// cbIsernhagen
			// 
			cbIsernhagen.AutoSize = true;
			cbIsernhagen.BackColor = Color.Transparent;
			cbIsernhagen.Location = new Point(6, 47);
			cbIsernhagen.Name = "cbIsernhagen";
			cbIsernhagen.Size = new Size(84, 19);
			cbIsernhagen.TabIndex = 3;
			cbIsernhagen.Text = "Isernhagen";
			cbIsernhagen.UseVisualStyleBackColor = false;
			cbIsernhagen.CheckedChanged += OnCheckedChanged;
			// 
			// cbWedemark
			// 
			cbWedemark.AutoSize = true;
			cbWedemark.BackColor = Color.Transparent;
			cbWedemark.Location = new Point(6, 72);
			cbWedemark.Name = "cbWedemark";
			cbWedemark.Size = new Size(83, 19);
			cbWedemark.TabIndex = 3;
			cbWedemark.Text = "Wedemark";
			cbWedemark.UseVisualStyleBackColor = false;
			cbWedemark.CheckedChanged += OnCheckedChanged;
			// 
			// cbAndere
			// 
			cbAndere.AutoSize = true;
			cbAndere.BackColor = Color.Transparent;
			cbAndere.Location = new Point(5, 97);
			cbAndere.Name = "cbAndere";
			cbAndere.Size = new Size(64, 19);
			cbAndere.TabIndex = 3;
			cbAndere.Text = "Andere";
			cbAndere.UseVisualStyleBackColor = false;
			cbAndere.CheckedChanged += OnCheckedChanged;
			// 
			// filterPanel
			// 
			filterPanel.BackColor = Color.FromArgb(210, 255, 255, 255);
			filterPanel.Controls.Add(gOrt);
			filterPanel.Controls.Add(gBeratung);
			filterPanel.Controls.Add(gGeschlecht);
			filterPanel.Controls.Add(label3);
			filterPanel.Controls.Add(gNeu);
			filterPanel.Controls.Add(gridAge);
			filterPanel.Location = new Point(41, 39);
			filterPanel.Name = "filterPanel";
			filterPanel.Size = new Size(500, 622);
			filterPanel.TabIndex = 4;
			// 
			// gOrt
			// 
			gOrt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			gOrt.BackColor = Color.Transparent;
			gOrt.Controls.Add(cbBurgwedel);
			gOrt.Controls.Add(cbIsernhagen);
			gOrt.Controls.Add(cbWedemark);
			gOrt.Controls.Add(cbAndere);
			gOrt.ForeColor = Color.Black;
			gOrt.Location = new Point(385, 54);
			gOrt.Name = "gOrt";
			gOrt.Size = new Size(104, 124);
			gOrt.TabIndex = 4;
			gOrt.TabStop = false;
			gOrt.Text = "Ort";
			// 
			// gBeratung
			// 
			gBeratung.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			gBeratung.BackColor = Color.Transparent;
			gBeratung.Controls.Add(cbAllg);
			gBeratung.Controls.Add(cbSGB8);
			gBeratung.Controls.Add(cb218);
			gBeratung.Controls.Add(cbSchwanger);
			gBeratung.Controls.Add(cbRA);
			gBeratung.ForeColor = Color.Black;
			gBeratung.Location = new Point(336, 184);
			gBeratung.Name = "gBeratung";
			gBeratung.Size = new Size(153, 154);
			gBeratung.TabIndex = 4;
			gBeratung.TabStop = false;
			gBeratung.Text = "Beratungsart";
			// 
			// cb218
			// 
			cb218.AutoSize = true;
			cb218.BackColor = Color.Transparent;
			cb218.Location = new Point(6, 97);
			cb218.Name = "cb218";
			cb218.Size = new Size(52, 19);
			cb218.TabIndex = 3;
			cb218.Text = "§ 218";
			cb218.UseVisualStyleBackColor = false;
			cb218.CheckedChanged += OnCheckedChanged;
			// 
			// gGeschlecht
			// 
			gGeschlecht.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			gGeschlecht.BackColor = Color.Transparent;
			gGeschlecht.Controls.Add(cbMale);
			gGeschlecht.Controls.Add(cbFemale);
			gGeschlecht.Controls.Add(cbNonBin);
			gGeschlecht.ForeColor = Color.Black;
			gGeschlecht.Location = new Point(237, 184);
			gGeschlecht.Name = "gGeschlecht";
			gGeschlecht.Size = new Size(93, 124);
			gGeschlecht.TabIndex = 4;
			gGeschlecht.TabStop = false;
			gGeschlecht.Text = "Geschlecht";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 18F);
			label3.Location = new Point(23, 13);
			label3.Name = "label3";
			label3.Size = new Size(96, 32);
			label3.TabIndex = 2;
			label3.Text = "Statistik";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// gNeu
			// 
			gNeu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			gNeu.BackColor = Color.Transparent;
			gNeu.Controls.Add(cbNeu);
			gNeu.Controls.Add(cb1Jahr);
			gNeu.Controls.Add(cb2Jahr);
			gNeu.ForeColor = Color.Black;
			gNeu.Location = new Point(237, 54);
			gNeu.Name = "gNeu";
			gNeu.Size = new Size(142, 124);
			gNeu.TabIndex = 4;
			gNeu.TabStop = false;
			gNeu.Text = "Neuanmeldung";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(210, 255, 255, 255);
			panel1.Controls.Add(checkListStats);
			panel1.Controls.Add(xlsx);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(552, 39);
			panel1.Name = "panel1";
			panel1.Size = new Size(501, 622);
			panel1.TabIndex = 5;
			// 
			// xlsx
			// 
			xlsx.BackColor = Color.Green;
			xlsx.BackgroundColor = Color.Green;
			xlsx.BorderColor = Color.Empty;
			xlsx.BorderRadius = 0;
			xlsx.BorderSize = 1;
			xlsx.FlatAppearance.BorderSize = 0;
			xlsx.FlatStyle = FlatStyle.Flat;
			xlsx.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			xlsx.ForeColor = Color.White;
			xlsx.Image = Properties.images.excel26x26;
			xlsx.ImageAlign = ContentAlignment.MiddleLeft;
			xlsx.Location = new Point(30, 206);
			xlsx.Name = "xlsx";
			xlsx.Padding = new Padding(30, 0, 0, 0);
			xlsx.Size = new Size(231, 52);
			xlsx.TabIndex = 18;
			xlsx.Text = "Als .xlsx exportieren";
			xlsx.TextColor = Color.White;
			xlsx.TextImageRelation = TextImageRelation.ImageBeforeText;
			xlsx.UseVisualStyleBackColor = false;
			xlsx.Click += OnButtonExport;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(30, 22);
			label2.Name = "label2";
			label2.Size = new Size(163, 21);
			label2.TabIndex = 2;
			label2.Text = "Relevantes auswählen";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// exportStatisticsFileSave
			// 
			exportStatisticsFileSave.DefaultExt = "xlsx";
			exportStatisticsFileSave.FileName = "statistik_export";
			exportStatisticsFileSave.RestoreDirectory = true;
			// 
			// checkListStats
			// 
			checkListStats.FormattingEnabled = true;
			checkListStats.Items.AddRange(new object[] { "Neuanmeldungen nach Beratungsart", "Fortführungen nach Beratungsart", "Gesamt nach Beratungsart", "Gesamt nach Ort", "Anmeldegründe LB", "Anmeldegründe SGB VIII", "Art der Beratung für Schwangere" });
			checkListStats.Location = new Point(30, 60);
			checkListStats.Name = "checkListStats";
			checkListStats.Size = new Size(231, 112);
			checkListStats.TabIndex = 19;
			// 
			// FrameStatistics
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(160, 255, 255, 255);
			Controls.Add(panel1);
			Controls.Add(filterPanel);
			Margin = new Padding(0);
			Name = "FrameStatistics";
			Size = new Size(1080, 690);
			Tag = "Frame";
			Load += OnLoad;
			((System.ComponentModel.ISupportInitialize)gridAge).EndInit();
			filterPanel.ResumeLayout(false);
			filterPanel.PerformLayout();
			gOrt.ResumeLayout(false);
			gOrt.PerformLayout();
			gBeratung.ResumeLayout(false);
			gBeratung.PerformLayout();
			gGeschlecht.ResumeLayout(false);
			gGeschlecht.PerformLayout();
			gNeu.ResumeLayout(false);
			gNeu.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView gridAge;
        private CheckBox cbNeu;
        private CheckBox cbMale;
        private CheckBox cbFemale;
        private CheckBox cbNonBin;
        private CheckBox cb1Jahr;
        private CheckBox cb2Jahr;
        private CheckBox cbAllg;
        private CheckBox cbSGB8;
        private CheckBox cbSchwanger;
        private CheckBox cbRA;
        private CheckBox cbBurgwedel;
        private CheckBox cbIsernhagen;
        private CheckBox cbWedemark;
        private CheckBox cbAndere;
        private Panel filterPanel;
        private GroupBox gOrt;
        private GroupBox gBeratung;
        private GroupBox gGeschlecht;
        private GroupBox gNeu;
        private Panel panel1;
        private SaveFileDialog exportStatisticsFileSave;
        private RJCodeAdvance.RJControls.RJButton xlsx;
        private Label label3;
        private Label label2;
        private CheckBox cb218;
		private CheckedListBox checkListStats;
	}
}
