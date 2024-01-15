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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			gridData = new DataGridView();
			dropTabelle = new DropDown();
			buttonDelete = new RJCodeAdvance.RJControls.RJButton();
			tbFilter = new RJTextBox();
			dropFilter = new DropDown();
			tbListFilters = new RJTextBox();
			btnUpdate = new RJCodeAdvance.RJControls.RJButton();
			txtRows = new Label();
			rjButton1 = new RJCodeAdvance.RJControls.RJButton();
			rjButton2 = new RJCodeAdvance.RJControls.RJButton();
			label2 = new Label();
			label1 = new Label();
			label3 = new Label();
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
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			gridData.ColumnHeadersHeight = 26;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = Color.LightGreen;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			gridData.DefaultCellStyle = dataGridViewCellStyle5;
			gridData.Location = new Point(32, 175);
			gridData.Margin = new Padding(10);
			gridData.MultiSelect = false;
			gridData.Name = "gridData";
			gridData.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			gridData.RowHeadersVisible = false;
			gridData.RowTemplate.Height = 25;
			gridData.Size = new Size(1013, 476);
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
			dropTabelle.Location = new Point(573, 27);
			dropTabelle.Margin = new Padding(10);
			dropTabelle.MinimumSize = new Size(200, 30);
			dropTabelle.Name = "dropTabelle";
			dropTabelle.Padding = new Padding(1);
			dropTabelle.Size = new Size(271, 36);
			dropTabelle.TabIndex = 4;
			dropTabelle.Texts = "";
			dropTabelle.OnSelectedIndexChanged += OnTableChange;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.FromArgb(24, 38, 37);
			buttonDelete.BackgroundColor = Color.FromArgb(24, 38, 37);
			buttonDelete.BorderColor = Color.Black;
			buttonDelete.BorderRadius = 0;
			buttonDelete.BorderSize = 0;
			buttonDelete.FlatAppearance.BorderSize = 0;
			buttonDelete.FlatStyle = FlatStyle.Popup;
			buttonDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			buttonDelete.ForeColor = Color.Transparent;
			buttonDelete.Image = Properties.images.icons8_müll_24;
			buttonDelete.ImageAlign = ContentAlignment.TopCenter;
			buttonDelete.Location = new Point(898, 76);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Padding = new Padding(2);
			buttonDelete.Size = new Size(147, 36);
			buttonDelete.TabIndex = 13;
			buttonDelete.Text = "  löschen";
			buttonDelete.TextColor = Color.Transparent;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
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
			tbFilter.Location = new Point(32, 79);
			tbFilter.Margin = new Padding(10);
			tbFilter.Multiline = false;
			tbFilter.Name = "tbFilter";
			tbFilter.Padding = new Padding(10, 7, 10, 7);
			tbFilter.PasswordChar = false;
			tbFilter.PlaceholderColor = Color.DarkGray;
			tbFilter.PlaceholderText = "Zeichenkette";
			tbFilter.Size = new Size(200, 32);
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
			dropFilter.Location = new Point(32, 27);
			dropFilter.Margin = new Padding(10);
			dropFilter.MinimumSize = new Size(200, 30);
			dropFilter.Name = "dropFilter";
			dropFilter.Padding = new Padding(1);
			dropFilter.Size = new Size(200, 32);
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
			tbListFilters.Location = new Point(32, 135);
			tbListFilters.Margin = new Padding(10);
			tbListFilters.Multiline = false;
			tbListFilters.Name = "tbListFilters";
			tbListFilters.Padding = new Padding(10, 7, 10, 7);
			tbListFilters.PasswordChar = false;
			tbListFilters.PlaceholderColor = Color.DimGray;
			tbListFilters.PlaceholderText = "Keine aktiven Filter";
			tbListFilters.Size = new Size(1013, 32);
			tbListFilters.TabIndex = 15;
			tbListFilters.Texts = "";
			tbListFilters.UnderlinedStyle = false;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(24, 38, 37);
			btnUpdate.BackgroundColor = Color.FromArgb(24, 38, 37);
			btnUpdate.BorderColor = Color.Black;
			btnUpdate.BorderRadius = 0;
			btnUpdate.BorderSize = 0;
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatStyle = FlatStyle.Popup;
			btnUpdate.Font = new Font("Segoe UI", 9F);
			btnUpdate.ForeColor = Color.Transparent;
			btnUpdate.Image = Properties.images.icons8_aktualisieren_24__1_;
			btnUpdate.Location = new Point(898, 27);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Padding = new Padding(2);
			btnUpdate.Size = new Size(147, 36);
			btnUpdate.TabIndex = 13;
			btnUpdate.Text = "  aktualisieren";
			btnUpdate.TextColor = Color.Transparent;
			btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += OnUpdateClick;
			// 
			// txtRows
			// 
			txtRows.BackColor = Color.Transparent;
			txtRows.FlatStyle = FlatStyle.Popup;
			txtRows.ForeColor = Color.Transparent;
			txtRows.Location = new Point(398, 33);
			txtRows.Name = "txtRows";
			txtRows.Size = new Size(112, 24);
			txtRows.TabIndex = 22;
			txtRows.Text = "Keine Einträge";
			txtRows.TextAlign = ContentAlignment.MiddleRight;
			// 
			// rjButton1
			// 
			rjButton1.BackColor = Color.FromArgb(24, 38, 37);
			rjButton1.BackgroundColor = Color.FromArgb(24, 38, 37);
			rjButton1.BorderColor = Color.Black;
			rjButton1.BorderRadius = 0;
			rjButton1.BorderSize = 0;
			rjButton1.FlatAppearance.BorderSize = 0;
			rjButton1.FlatStyle = FlatStyle.Popup;
			rjButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			rjButton1.ForeColor = Color.Transparent;
			rjButton1.Image = Properties.images.icons8_rückgängig_machen_24;
			rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
			rjButton1.Location = new Point(245, 76);
			rjButton1.Name = "rjButton1";
			rjButton1.Padding = new Padding(4);
			rjButton1.Size = new Size(147, 36);
			rjButton1.TabIndex = 13;
			rjButton1.Text = "  zurücksetzen";
			rjButton1.TextColor = Color.Transparent;
			rjButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
			rjButton1.UseVisualStyleBackColor = false;
			rjButton1.Click += OnReset;
			// 
			// rjButton2
			// 
			rjButton2.BackColor = Color.FromArgb(24, 38, 37);
			rjButton2.BackgroundColor = Color.FromArgb(24, 38, 37);
			rjButton2.BorderColor = Color.Black;
			rjButton2.BorderRadius = 0;
			rjButton2.BorderSize = 0;
			rjButton2.FlatAppearance.BorderSize = 0;
			rjButton2.FlatStyle = FlatStyle.Popup;
			rjButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			rjButton2.ForeColor = Color.Transparent;
			rjButton2.Image = Properties.images.icons8_speichern_24;
			rjButton2.ImageAlign = ContentAlignment.TopCenter;
			rjButton2.Location = new Point(245, 27);
			rjButton2.Name = "rjButton2";
			rjButton2.Padding = new Padding(2);
			rjButton2.Size = new Size(147, 36);
			rjButton2.TabIndex = 13;
			rjButton2.Text = "  Filter speichern";
			rjButton2.TextColor = Color.Transparent;
			rjButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
			rjButton2.UseVisualStyleBackColor = false;
			rjButton2.Click += OnFilterAdd;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = Color.White;
			label2.Location = new Point(31, 59);
			label2.Name = "label2";
			label2.Size = new Size(76, 15);
			label2.TabIndex = 16;
			label2.Text = "Spaltenname";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.ForeColor = Color.White;
			label1.Location = new Point(32, 110);
			label1.Name = "label1";
			label1.Size = new Size(91, 15);
			label1.TabIndex = 16;
			label1.Text = "muss enthalten:";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.FlatStyle = FlatStyle.Popup;
			label3.ForeColor = Color.Transparent;
			label3.Location = new Point(573, 63);
			label3.Name = "label3";
			label3.Size = new Size(112, 24);
			label3.TabIndex = 22;
			label3.Text = "Tabelle";
			// 
			// FrameShowTable
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(30, 255, 255, 255);
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(label3);
			Controls.Add(txtRows);
			Controls.Add(dropFilter);
			Controls.Add(tbListFilters);
			Controls.Add(tbFilter);
			Controls.Add(btnUpdate);
			Controls.Add(rjButton2);
			Controls.Add(rjButton1);
			Controls.Add(buttonDelete);
			Controls.Add(dropTabelle);
			Controls.Add(gridData);
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
		private RJCodeAdvance.RJControls.RJButton rjButton1;
		private RJCodeAdvance.RJControls.RJButton rjButton2;
		private Label label2;
		private Label label1;
		private Label label3;
	}
}
