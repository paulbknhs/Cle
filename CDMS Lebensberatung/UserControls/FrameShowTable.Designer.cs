namespace CDMS_Lebensberatung.UserControls
{
    partial class FrameShowTable
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
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			gridData = new DataGridView();
			dropTabelle = new DropDown();
			buttonDelete = new RJCodeAdvance.RJControls.RJButton();
			tbFilter = new RJTextBox();
			dropFilter = new DropDown();
			tbListFilters = new RJTextBox();
			btnUpdate = new RJCodeAdvance.RJControls.RJButton();
			txtRows = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
			SuspendLayout();
			// 
			// gridData
			// 
			gridData.AllowUserToAddRows = false;
			gridData.AllowUserToDeleteRows = false;
			gridData.AllowUserToOrderColumns = true;
			gridData.AllowUserToResizeRows = false;
			gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			gridData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridData.BackgroundColor = SystemColors.ControlLightLight;
			gridData.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			gridData.ColumnHeadersHeight = 26;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = Color.LightGreen;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
			gridData.DefaultCellStyle = dataGridViewCellStyle8;
			gridData.Location = new Point(10, 119);
			gridData.Margin = new Padding(10);
			gridData.MultiSelect = false;
			gridData.Name = "gridData";
			gridData.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			gridData.RowHeadersVisible = false;
			gridData.RowTemplate.Height = 25;
			gridData.Size = new Size(1055, 557);
			gridData.TabIndex = 0;
			// 
			// dropTabelle
			// 
			dropTabelle.BackColor = Color.WhiteSmoke;
			dropTabelle.BorderColor = Color.Black;
			dropTabelle.BorderSize = 1;
			dropTabelle.DropDownStyle = ComboBoxStyle.DropDownList;
			dropTabelle.Font = new Font("Segoe UI", 9F);
			dropTabelle.ForeColor = Color.DimGray;
			dropTabelle.IconColor = Color.Black;
			dropTabelle.ListBackColor = Color.FromArgb(230, 228, 245);
			dropTabelle.ListTextColor = Color.DimGray;
			dropTabelle.Location = new Point(686, 39);
			dropTabelle.Margin = new Padding(10);
			dropTabelle.MinimumSize = new Size(200, 30);
			dropTabelle.Name = "dropTabelle";
			dropTabelle.Padding = new Padding(1);
			dropTabelle.Size = new Size(282, 32);
			dropTabelle.TabIndex = 4;
			dropTabelle.Texts = "";
			dropTabelle.OnSelectedIndexChanged += OnTableChange;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.FromArgb(174, 191, 191);
			buttonDelete.BackgroundColor = Color.FromArgb(174, 191, 191);
			buttonDelete.BorderColor = Color.Black;
			buttonDelete.BorderRadius = 0;
			buttonDelete.BorderSize = 0;
			buttonDelete.FlatAppearance.BorderSize = 0;
			buttonDelete.FlatStyle = FlatStyle.Flat;
			buttonDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			buttonDelete.ForeColor = Color.Black;
			buttonDelete.Location = new Point(974, 39);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(91, 72);
			buttonDelete.TabIndex = 13;
			buttonDelete.Text = "Eintrag löschen";
			buttonDelete.TextColor = Color.Black;
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += OnDelete;
			// 
			// tbFilter
			// 
			tbFilter.BackColor = SystemColors.Window;
			tbFilter.BorderColor = Color.Black;
			tbFilter.BorderFocusColor = Color.Green;
			tbFilter.BorderRadius = 0;
			tbFilter.BorderSize = 1;
			tbFilter.Font = new Font("Segoe UI", 9.75F);
			tbFilter.ForeColor = Color.FromArgb(64, 64, 64);
			tbFilter.Location = new Point(254, 39);
			tbFilter.Margin = new Padding(10);
			tbFilter.Multiline = false;
			tbFilter.Name = "tbFilter";
			tbFilter.Padding = new Padding(10, 7, 10, 7);
			tbFilter.PasswordChar = false;
			tbFilter.PlaceholderColor = Color.DarkGray;
			tbFilter.PlaceholderText = "Filtern nach...";
			tbFilter.Size = new Size(220, 32);
			tbFilter.TabIndex = 15;
			tbFilter.Texts = "";
			tbFilter.UnderlinedStyle = true;
			// 
			// dropFilter
			// 
			dropFilter.BackColor = Color.WhiteSmoke;
			dropFilter.BorderColor = Color.Black;
			dropFilter.BorderSize = 1;
			dropFilter.DropDownStyle = ComboBoxStyle.DropDownList;
			dropFilter.Font = new Font("Segoe UI", 10F);
			dropFilter.ForeColor = Color.DimGray;
			dropFilter.IconColor = Color.Black;
			dropFilter.ListBackColor = Color.FromArgb(230, 228, 245);
			dropFilter.ListTextColor = Color.DimGray;
			dropFilter.Location = new Point(14, 39);
			dropFilter.Margin = new Padding(10);
			dropFilter.MinimumSize = new Size(200, 30);
			dropFilter.Name = "dropFilter";
			dropFilter.Padding = new Padding(1);
			dropFilter.Size = new Size(220, 32);
			dropFilter.TabIndex = 4;
			dropFilter.Texts = "";
			dropFilter.OnSelectedIndexChanged += dropFilter_OnSelectedIndexChanged;
			// 
			// tbListFilters
			// 
			tbListFilters.AutoSize = true;
			tbListFilters.BackColor = Color.LightGray;
			tbListFilters.BorderColor = Color.Black;
			tbListFilters.BorderFocusColor = Color.Black;
			tbListFilters.BorderRadius = 0;
			tbListFilters.BorderSize = 1;
			tbListFilters.Enabled = false;
			tbListFilters.Font = new Font("Segoe UI", 9.75F);
			tbListFilters.ForeColor = Color.Black;
			tbListFilters.Location = new Point(10, 79);
			tbListFilters.Margin = new Padding(10);
			tbListFilters.Multiline = false;
			tbListFilters.Name = "tbListFilters";
			tbListFilters.Padding = new Padding(10, 7, 10, 7);
			tbListFilters.PasswordChar = false;
			tbListFilters.PlaceholderColor = Color.DimGray;
			tbListFilters.PlaceholderText = "Keine aktiven Filter";
			tbListFilters.Size = new Size(607, 32);
			tbListFilters.TabIndex = 15;
			tbListFilters.Texts = "";
			tbListFilters.UnderlinedStyle = false;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(174, 191, 191);
			btnUpdate.BackgroundColor = Color.FromArgb(174, 191, 191);
			btnUpdate.BorderColor = Color.Black;
			btnUpdate.BorderRadius = 0;
			btnUpdate.BorderSize = 0;
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Segoe UI", 9F);
			btnUpdate.ForeColor = Color.Black;
			btnUpdate.Location = new Point(686, 79);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(117, 32);
			btnUpdate.TabIndex = 13;
			btnUpdate.Text = "Aktualisieren";
			btnUpdate.TextColor = Color.Black;
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += OnUpdateClick;
			// 
			// txtRows
			// 
			txtRows.BackColor = Color.FromArgb(174, 191, 191);
			txtRows.ForeColor = Color.Black;
			txtRows.Location = new Point(809, 79);
			txtRows.Name = "txtRows";
			txtRows.Size = new Size(159, 32);
			txtRows.TabIndex = 22;
			txtRows.Text = "Keine Einträge";
			txtRows.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(174, 191, 191);
			label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(483, 13);
			label1.Name = "label1";
			label1.Size = new Size(62, 62);
			label1.TabIndex = 23;
			label1.Text = "+";
			label1.TextAlign = ContentAlignment.TopCenter;
			label1.Click += OnFilterAdd;
			// 
			// label2
			// 
			label2.BackColor = Color.FromArgb(174, 191, 191);
			label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(555, 13);
			label2.Name = "label2";
			label2.Size = new Size(62, 62);
			label2.TabIndex = 23;
			label2.Text = "⮪";
			label2.TextAlign = ContentAlignment.TopCenter;
			label2.Click += OnReset;
			// 
			// label3
			// 
			label3.BackColor = Color.Silver;
			label3.Font = new Font("Segoe UI", 9F);
			label3.ForeColor = Color.FromArgb(13, 47, 48);
			label3.Location = new Point(10, 13);
			label3.Name = "label3";
			label3.Size = new Size(227, 62);
			label3.TabIndex = 23;
			label3.Text = "Spaltenname";
			label3.TextAlign = ContentAlignment.TopCenter;
			label3.Click += label1_Click;
			// 
			// label4
			// 
			label4.BackColor = Color.Silver;
			label4.Font = new Font("Segoe UI", 9F);
			label4.ForeColor = Color.FromArgb(13, 47, 48);
			label4.Location = new Point(250, 13);
			label4.Name = "label4";
			label4.Size = new Size(227, 62);
			label4.TabIndex = 23;
			label4.Text = "Eintrag muss enthalten:";
			label4.TextAlign = ContentAlignment.TopCenter;
			label4.Click += label1_Click;
			// 
			// FrameShowTable
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 255, 255, 255);
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtRows);
			Controls.Add(tbListFilters);
			Controls.Add(tbFilter);
			Controls.Add(btnUpdate);
			Controls.Add(buttonDelete);
			Controls.Add(dropFilter);
			Controls.Add(dropTabelle);
			Controls.Add(gridData);
			Controls.Add(label4);
			Controls.Add(label3);
			Margin = new Padding(0);
			Name = "FrameShowTable";
			Size = new Size(1076, 686);
			Tag = "Frame";
			Load += OnLoad;
			((System.ComponentModel.ISupportInitialize)gridData).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView gridData;
        private DropDown dropTabelle;
        private RJCodeAdvance.RJControls.RJButton buttonDelete;
        private DropDown dropFilter;
        private RJTextBox tbFilter;
        private RJTextBox tbListFilters;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label txtRows;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}
