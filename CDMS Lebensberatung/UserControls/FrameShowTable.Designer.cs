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
			rjButton1 = new RJCodeAdvance.RJControls.RJButton();
			dropFilter = new DropDown();
			rjButton2 = new RJCodeAdvance.RJControls.RJButton();
			tbListFilters = new RJTextBox();
			btnUpdate = new RJCodeAdvance.RJControls.RJButton();
			txtRows = new Label();
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
			gridData.Location = new Point(65, 119);
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
			gridData.Size = new Size(1000, 555);
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
			dropTabelle.Location = new Point(870, 72);
			dropTabelle.Margin = new Padding(10);
			dropTabelle.MinimumSize = new Size(200, 30);
			dropTabelle.Name = "dropTabelle";
			dropTabelle.Padding = new Padding(1);
			dropTabelle.Size = new Size(200, 32);
			dropTabelle.TabIndex = 4;
			dropTabelle.Texts = "";
			dropTabelle.OnSelectedIndexChanged += OnTableChange;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.IndianRed;
			buttonDelete.BackgroundColor = Color.IndianRed;
			buttonDelete.BorderColor = Color.Black;
			buttonDelete.BorderRadius = 0;
			buttonDelete.BorderSize = 0;
			buttonDelete.FlatAppearance.BorderSize = 0;
			buttonDelete.FlatStyle = FlatStyle.Flat;
			buttonDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			buttonDelete.ForeColor = Color.White;
			buttonDelete.Location = new Point(870, 27);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(200, 32);
			buttonDelete.TabIndex = 13;
			buttonDelete.Text = "Eintrag löschen";
			buttonDelete.TextColor = Color.White;
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
			tbFilter.Location = new Point(285, 27);
			tbFilter.Margin = new Padding(10);
			tbFilter.Multiline = false;
			tbFilter.Name = "tbFilter";
			tbFilter.Padding = new Padding(10, 7, 10, 7);
			tbFilter.PasswordChar = false;
			tbFilter.PlaceholderColor = Color.DarkGray;
			tbFilter.PlaceholderText = "Filtern nach...";
			tbFilter.Size = new Size(200, 32);
			tbFilter.TabIndex = 15;
			tbFilter.Texts = "";
			tbFilter.UnderlinedStyle = true;
			// 
			// rjButton1
			// 
			rjButton1.BackColor = Color.Green;
			rjButton1.BackgroundColor = Color.Green;
			rjButton1.BorderColor = Color.White;
			rjButton1.BorderRadius = 0;
			rjButton1.BorderSize = 0;
			rjButton1.FlatAppearance.BorderSize = 0;
			rjButton1.FlatStyle = FlatStyle.Flat;
			rjButton1.Font = new Font("Segoe UI", 9F);
			rjButton1.ForeColor = Color.White;
			rjButton1.Location = new Point(498, 27);
			rjButton1.Name = "rjButton1";
			rjButton1.Size = new Size(159, 32);
			rjButton1.TabIndex = 13;
			rjButton1.Text = "Filter hinzufügen";
			rjButton1.TextColor = Color.White;
			rjButton1.UseVisualStyleBackColor = false;
			rjButton1.Click += OnFilterAdd;
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
			dropFilter.Location = new Point(65, 27);
			dropFilter.Margin = new Padding(10);
			dropFilter.MinimumSize = new Size(200, 30);
			dropFilter.Name = "dropFilter";
			dropFilter.Padding = new Padding(1);
			dropFilter.Size = new Size(200, 32);
			dropFilter.TabIndex = 4;
			dropFilter.Texts = "";
			// 
			// rjButton2
			// 
			rjButton2.BackColor = Color.IndianRed;
			rjButton2.BackgroundColor = Color.IndianRed;
			rjButton2.BorderColor = Color.White;
			rjButton2.BorderRadius = 0;
			rjButton2.BorderSize = 0;
			rjButton2.FlatAppearance.BorderSize = 0;
			rjButton2.FlatStyle = FlatStyle.Flat;
			rjButton2.Font = new Font("Segoe UI", 9F);
			rjButton2.ForeColor = Color.White;
			rjButton2.Location = new Point(498, 72);
			rjButton2.Name = "rjButton2";
			rjButton2.Size = new Size(159, 32);
			rjButton2.TabIndex = 13;
			rjButton2.Text = "Zurücksetzen";
			rjButton2.TextColor = Color.White;
			rjButton2.UseVisualStyleBackColor = false;
			rjButton2.Click += OnReset;
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
			tbListFilters.Location = new Point(65, 77);
			tbListFilters.Margin = new Padding(10);
			tbListFilters.Multiline = false;
			tbListFilters.Name = "tbListFilters";
			tbListFilters.Padding = new Padding(10, 7, 10, 7);
			tbListFilters.PasswordChar = false;
			tbListFilters.PlaceholderColor = Color.DimGray;
			tbListFilters.PlaceholderText = "Keine aktiven Filter";
			tbListFilters.Size = new Size(420, 32);
			tbListFilters.TabIndex = 15;
			tbListFilters.Texts = "";
			tbListFilters.UnderlinedStyle = false;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.White;
			btnUpdate.BackgroundColor = Color.White;
			btnUpdate.BorderColor = Color.Black;
			btnUpdate.BorderRadius = 0;
			btnUpdate.BorderSize = 0;
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Segoe UI", 9F);
			btnUpdate.ForeColor = Color.Black;
			btnUpdate.Location = new Point(688, 27);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(159, 32);
			btnUpdate.TabIndex = 13;
			btnUpdate.Text = "Aktualisieren";
			btnUpdate.TextColor = Color.Black;
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += OnUpdateClick;
			// 
			// txtRows
			// 
			txtRows.BackColor = Color.White;
			txtRows.BorderStyle = BorderStyle.FixedSingle;
			txtRows.ForeColor = Color.IndianRed;
			txtRows.Location = new Point(688, 72);
			txtRows.Name = "txtRows";
			txtRows.Size = new Size(159, 32);
			txtRows.TabIndex = 22;
			txtRows.Text = "Keine Einträge";
			txtRows.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FrameShowTable
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(160, 255, 255, 255);
			Controls.Add(txtRows);
			Controls.Add(tbListFilters);
			Controls.Add(tbFilter);
			Controls.Add(btnUpdate);
			Controls.Add(rjButton1);
			Controls.Add(rjButton2);
			Controls.Add(buttonDelete);
			Controls.Add(dropFilter);
			Controls.Add(dropTabelle);
			Controls.Add(gridData);
			Margin = new Padding(0);
			Name = "FrameShowTable";
			Size = new Size(1080, 690);
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
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJTextBox tbListFilters;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label txtRows;
    }
}
