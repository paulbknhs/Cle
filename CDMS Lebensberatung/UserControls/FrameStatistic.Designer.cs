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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAge = new System.Windows.Forms.DataGridView();
            this.cbNeu = new System.Windows.Forms.CheckBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbNonBin = new System.Windows.Forms.CheckBox();
            this.cb1Jahr = new System.Windows.Forms.CheckBox();
            this.cb2Jahr = new System.Windows.Forms.CheckBox();
            this.cbAllg = new System.Windows.Forms.CheckBox();
            this.cbSGB8 = new System.Windows.Forms.CheckBox();
            this.cbSchwanger = new System.Windows.Forms.CheckBox();
            this.cbRA = new System.Windows.Forms.CheckBox();
            this.cbBurgwedel = new System.Windows.Forms.CheckBox();
            this.cbIsernhagen = new System.Windows.Forms.CheckBox();
            this.cbWedemark = new System.Windows.Forms.CheckBox();
            this.cbAndere = new System.Windows.Forms.CheckBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.gOrt = new System.Windows.Forms.GroupBox();
            this.gBeratung = new System.Windows.Forms.GroupBox();
            this.cb218 = new System.Windows.Forms.CheckBox();
            this.gGeschlecht = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gNeu = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkListStats = new System.Windows.Forms.CheckedListBox();
            this.xlsx = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exportStatisticsFileSave = new System.Windows.Forms.SaveFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridAge)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.gOrt.SuspendLayout();
            this.gBeratung.SuspendLayout();
            this.gGeschlecht.SuspendLayout();
            this.gNeu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAge
            // 
            this.gridAge.AllowUserToAddRows = false;
            this.gridAge.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridAge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridAge.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAge.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAge.ColumnHeadersHeight = 32;
            this.gridAge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAge.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridAge.Location = new System.Drawing.Point(23, 54);
            this.gridAge.Margin = new System.Windows.Forms.Padding(0);
            this.gridAge.Name = "gridAge";
            this.gridAge.ReadOnly = true;
            this.gridAge.RowHeadersVisible = false;
            this.gridAge.RowHeadersWidth = 51;
            this.gridAge.RowTemplate.Height = 25;
            this.gridAge.ShowCellErrors = false;
            this.gridAge.ShowCellToolTips = false;
            this.gridAge.ShowEditingIcon = false;
            this.gridAge.ShowRowErrors = false;
            this.gridAge.Size = new System.Drawing.Size(200, 514);
            this.gridAge.TabIndex = 1;
            // 
            // cbNeu
            // 
            this.cbNeu.AutoSize = true;
            this.cbNeu.BackColor = System.Drawing.Color.Transparent;
            this.cbNeu.Location = new System.Drawing.Point(6, 22);
            this.cbNeu.Name = "cbNeu";
            this.cbNeu.Size = new System.Drawing.Size(109, 19);
            this.cbNeu.TabIndex = 3;
            this.cbNeu.Text = "Neuanmeldung";
            this.cbNeu.UseVisualStyleBackColor = false;
            this.cbNeu.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.BackColor = System.Drawing.Color.Transparent;
            this.cbMale.Location = new System.Drawing.Point(6, 22);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(76, 19);
            this.cbMale.TabIndex = 3;
            this.cbMale.Text = "Männlich";
            this.cbMale.UseVisualStyleBackColor = false;
            this.cbMale.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.BackColor = System.Drawing.Color.Transparent;
            this.cbFemale.Location = new System.Drawing.Point(6, 47);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(72, 19);
            this.cbFemale.TabIndex = 3;
            this.cbFemale.Text = "Weiblich";
            this.cbFemale.UseVisualStyleBackColor = false;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbNonBin
            // 
            this.cbNonBin.AutoSize = true;
            this.cbNonBin.BackColor = System.Drawing.Color.Transparent;
            this.cbNonBin.Location = new System.Drawing.Point(6, 72);
            this.cbNonBin.Name = "cbNonBin";
            this.cbNonBin.Size = new System.Drawing.Size(81, 19);
            this.cbNonBin.TabIndex = 3;
            this.cbNonBin.Text = "Non-Binär";
            this.cbNonBin.UseVisualStyleBackColor = false;
            this.cbNonBin.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cb1Jahr
            // 
            this.cb1Jahr.AutoSize = true;
            this.cb1Jahr.BackColor = System.Drawing.Color.Transparent;
            this.cb1Jahr.Location = new System.Drawing.Point(6, 47);
            this.cb1Jahr.Name = "cb1Jahr";
            this.cb1Jahr.Size = new System.Drawing.Size(86, 19);
            this.cb1Jahr.TabIndex = 3;
            this.cb1Jahr.Text = "Aus Vorjahr";
            this.cb1Jahr.UseVisualStyleBackColor = false;
            this.cb1Jahr.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cb2Jahr
            // 
            this.cb2Jahr.AutoSize = true;
            this.cb2Jahr.BackColor = System.Drawing.Color.Transparent;
            this.cb2Jahr.Location = new System.Drawing.Point(6, 72);
            this.cb2Jahr.Name = "cb2Jahr";
            this.cb2Jahr.Size = new System.Drawing.Size(108, 19);
            this.cb2Jahr.TabIndex = 3;
            this.cb2Jahr.Text = "Aus Vor-Vorjahr";
            this.cb2Jahr.UseVisualStyleBackColor = false;
            this.cb2Jahr.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbAllg
            // 
            this.cbAllg.AutoSize = true;
            this.cbAllg.BackColor = System.Drawing.Color.Transparent;
            this.cbAllg.Location = new System.Drawing.Point(6, 22);
            this.cbAllg.Name = "cbAllg";
            this.cbAllg.Size = new System.Drawing.Size(138, 19);
            this.cbAllg.TabIndex = 3;
            this.cbAllg.Text = "Allg. Lebensberatung";
            this.cbAllg.UseVisualStyleBackColor = false;
            this.cbAllg.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbSGB8
            // 
            this.cbSGB8.AutoSize = true;
            this.cbSGB8.BackColor = System.Drawing.Color.Transparent;
            this.cbSGB8.Location = new System.Drawing.Point(6, 47);
            this.cbSGB8.Name = "cbSGB8";
            this.cbSGB8.Size = new System.Drawing.Size(66, 19);
            this.cbSGB8.TabIndex = 3;
            this.cbSGB8.Text = "SGB VIII";
            this.cbSGB8.UseVisualStyleBackColor = false;
            this.cbSGB8.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbSchwanger
            // 
            this.cbSchwanger.AutoSize = true;
            this.cbSchwanger.BackColor = System.Drawing.Color.Transparent;
            this.cbSchwanger.Location = new System.Drawing.Point(6, 72);
            this.cbSchwanger.Name = "cbSchwanger";
            this.cbSchwanger.Size = new System.Drawing.Size(116, 19);
            this.cbSchwanger.TabIndex = 3;
            this.cbSchwanger.Text = "Schwangerschaft";
            this.cbSchwanger.UseVisualStyleBackColor = false;
            this.cbSchwanger.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbRA
            // 
            this.cbRA.AutoSize = true;
            this.cbRA.BackColor = System.Drawing.Color.Transparent;
            this.cbRA.Location = new System.Drawing.Point(6, 122);
            this.cbRA.Name = "cbRA";
            this.cbRA.Size = new System.Drawing.Size(115, 19);
            this.cbRA.TabIndex = 3;
            this.cbRA.Text = "Rechtsanwaltlich";
            this.cbRA.UseVisualStyleBackColor = false;
            this.cbRA.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbBurgwedel
            // 
            this.cbBurgwedel.AutoSize = true;
            this.cbBurgwedel.BackColor = System.Drawing.Color.Transparent;
            this.cbBurgwedel.Location = new System.Drawing.Point(6, 22);
            this.cbBurgwedel.Name = "cbBurgwedel";
            this.cbBurgwedel.Size = new System.Drawing.Size(82, 19);
            this.cbBurgwedel.TabIndex = 3;
            this.cbBurgwedel.Text = "Burgwedel";
            this.cbBurgwedel.UseVisualStyleBackColor = false;
            this.cbBurgwedel.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbIsernhagen
            // 
            this.cbIsernhagen.AutoSize = true;
            this.cbIsernhagen.BackColor = System.Drawing.Color.Transparent;
            this.cbIsernhagen.Location = new System.Drawing.Point(6, 47);
            this.cbIsernhagen.Name = "cbIsernhagen";
            this.cbIsernhagen.Size = new System.Drawing.Size(84, 19);
            this.cbIsernhagen.TabIndex = 3;
            this.cbIsernhagen.Text = "Isernhagen";
            this.cbIsernhagen.UseVisualStyleBackColor = false;
            this.cbIsernhagen.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbWedemark
            // 
            this.cbWedemark.AutoSize = true;
            this.cbWedemark.BackColor = System.Drawing.Color.Transparent;
            this.cbWedemark.Location = new System.Drawing.Point(6, 72);
            this.cbWedemark.Name = "cbWedemark";
            this.cbWedemark.Size = new System.Drawing.Size(83, 19);
            this.cbWedemark.TabIndex = 3;
            this.cbWedemark.Text = "Wedemark";
            this.cbWedemark.UseVisualStyleBackColor = false;
            this.cbWedemark.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbAndere
            // 
            this.cbAndere.AutoSize = true;
            this.cbAndere.BackColor = System.Drawing.Color.Transparent;
            this.cbAndere.Location = new System.Drawing.Point(5, 97);
            this.cbAndere.Name = "cbAndere";
            this.cbAndere.Size = new System.Drawing.Size(64, 19);
            this.cbAndere.TabIndex = 3;
            this.cbAndere.Text = "Andere";
            this.cbAndere.UseVisualStyleBackColor = false;
            this.cbAndere.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterPanel.Controls.Add(this.gOrt);
            this.filterPanel.Controls.Add(this.gBeratung);
            this.filterPanel.Controls.Add(this.gGeschlecht);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.gNeu);
            this.filterPanel.Controls.Add(this.gridAge);
            this.filterPanel.Location = new System.Drawing.Point(41, 39);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(500, 622);
            this.filterPanel.TabIndex = 4;
            // 
            // gOrt
            // 
            this.gOrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gOrt.BackColor = System.Drawing.Color.Transparent;
            this.gOrt.Controls.Add(this.cbBurgwedel);
            this.gOrt.Controls.Add(this.cbIsernhagen);
            this.gOrt.Controls.Add(this.cbWedemark);
            this.gOrt.Controls.Add(this.cbAndere);
            this.gOrt.ForeColor = System.Drawing.Color.Black;
            this.gOrt.Location = new System.Drawing.Point(385, 54);
            this.gOrt.Name = "gOrt";
            this.gOrt.Size = new System.Drawing.Size(104, 124);
            this.gOrt.TabIndex = 4;
            this.gOrt.TabStop = false;
            this.gOrt.Text = "Ort";
            // 
            // gBeratung
            // 
            this.gBeratung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gBeratung.BackColor = System.Drawing.Color.Transparent;
            this.gBeratung.Controls.Add(this.cbAllg);
            this.gBeratung.Controls.Add(this.cbSGB8);
            this.gBeratung.Controls.Add(this.cb218);
            this.gBeratung.Controls.Add(this.cbSchwanger);
            this.gBeratung.Controls.Add(this.cbRA);
            this.gBeratung.ForeColor = System.Drawing.Color.Black;
            this.gBeratung.Location = new System.Drawing.Point(336, 184);
            this.gBeratung.Name = "gBeratung";
            this.gBeratung.Size = new System.Drawing.Size(153, 154);
            this.gBeratung.TabIndex = 4;
            this.gBeratung.TabStop = false;
            this.gBeratung.Text = "Beratungsart";
            // 
            // cb218
            // 
            this.cb218.AutoSize = true;
            this.cb218.BackColor = System.Drawing.Color.Transparent;
            this.cb218.Location = new System.Drawing.Point(6, 97);
            this.cb218.Name = "cb218";
            this.cb218.Size = new System.Drawing.Size(52, 19);
            this.cb218.TabIndex = 3;
            this.cb218.Text = "§ 218";
            this.cb218.UseVisualStyleBackColor = false;
            this.cb218.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // gGeschlecht
            // 
            this.gGeschlecht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gGeschlecht.BackColor = System.Drawing.Color.Transparent;
            this.gGeschlecht.Controls.Add(this.cbMale);
            this.gGeschlecht.Controls.Add(this.cbFemale);
            this.gGeschlecht.Controls.Add(this.cbNonBin);
            this.gGeschlecht.ForeColor = System.Drawing.Color.Black;
            this.gGeschlecht.Location = new System.Drawing.Point(237, 184);
            this.gGeschlecht.Name = "gGeschlecht";
            this.gGeschlecht.Size = new System.Drawing.Size(93, 124);
            this.gGeschlecht.TabIndex = 4;
            this.gGeschlecht.TabStop = false;
            this.gGeschlecht.Text = "Geschlecht";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Statistik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gNeu
            // 
            this.gNeu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gNeu.BackColor = System.Drawing.Color.Transparent;
            this.gNeu.Controls.Add(this.cbNeu);
            this.gNeu.Controls.Add(this.cb1Jahr);
            this.gNeu.Controls.Add(this.cb2Jahr);
            this.gNeu.ForeColor = System.Drawing.Color.Black;
            this.gNeu.Location = new System.Drawing.Point(237, 54);
            this.gNeu.Name = "gNeu";
            this.gNeu.Size = new System.Drawing.Size(142, 124);
            this.gNeu.TabIndex = 4;
            this.gNeu.TabStop = false;
            this.gNeu.Text = "Neuanmeldung";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.checkListStats);
            this.panel1.Controls.Add(this.xlsx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(552, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 622);
            this.panel1.TabIndex = 5;
            // 
            // checkListStats
            // 
            this.checkListStats.FormattingEnabled = true;
            this.checkListStats.Items.AddRange(new object[] {
            "Neuanmeldungen nach Beratungsart",
            "Fortführungen nach Beratungsart",
            "Gesamt nach Beratungsart",
            "Gesamt nach Ort",
            "Anmeldegründe LB",
            "Anmeldegründe SGB VIII",
            "Art der Beratung für Schwangere"});
            this.checkListStats.Location = new System.Drawing.Point(30, 60);
            this.checkListStats.Name = "checkListStats";
            this.checkListStats.Size = new System.Drawing.Size(231, 112);
            this.checkListStats.TabIndex = 19;
            // 
            // xlsx
            // 
            this.xlsx.BackColor = System.Drawing.Color.Green;
            this.xlsx.BackgroundColor = System.Drawing.Color.Green;
            this.xlsx.BorderColor = System.Drawing.Color.Empty;
            this.xlsx.BorderRadius = 0;
            this.xlsx.BorderSize = 1;
            this.xlsx.FlatAppearance.BorderSize = 0;
            this.xlsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xlsx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xlsx.ForeColor = System.Drawing.Color.White;
            this.xlsx.Image = global::CDMS_Lebensberatung.Properties.images.excel26x26;
            this.xlsx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xlsx.Location = new System.Drawing.Point(30, 206);
            this.xlsx.Name = "xlsx";
            this.xlsx.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.xlsx.Size = new System.Drawing.Size(231, 52);
            this.xlsx.TabIndex = 18;
            this.xlsx.Text = "Als .xlsx exportieren";
            this.xlsx.TextColor = System.Drawing.Color.White;
            this.xlsx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xlsx.UseVisualStyleBackColor = false;
            this.xlsx.Click += new System.EventHandler(this.OnButtonExport);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Relevantes auswählen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(30, 206);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 55);
            this.panel4.TabIndex = 21;
            // 
            // exportStatisticsFileSave
            // 
            this.exportStatisticsFileSave.DefaultExt = "xlsx";
            this.exportStatisticsFileSave.FileName = "statistik_export";
            this.exportStatisticsFileSave.RestoreDirectory = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 5);
            this.panel5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 690);
            this.panel2.TabIndex = 7;
            // 
            // FrameStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FrameStatistics";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Tag = "Frame";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridAge)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.gOrt.ResumeLayout(false);
            this.gOrt.PerformLayout();
            this.gBeratung.ResumeLayout(false);
            this.gBeratung.PerformLayout();
            this.gGeschlecht.ResumeLayout(false);
            this.gGeschlecht.PerformLayout();
            this.gNeu.ResumeLayout(false);
            this.gNeu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private CheckedListBox checkListStats;
        private Label label3;
        private Panel panel5;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private CheckBox cb218;
    }
}
