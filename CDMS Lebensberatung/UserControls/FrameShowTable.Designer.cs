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
            buttonDelete = new RJCodeAdvance.RJControls.RJButton();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            txtRows = new Label();
            activeFiltersPanel = new FlowLayoutPanel();
            dropCategory = new DropDown();
            dropValue = new DropDown();
            dropTabelle = new DropDown();
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
            gridData.Location = new Point(65, 180);
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
            gridData.Size = new Size(1000, 494);
            gridData.TabIndex = 0;
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
            buttonDelete.Location = new Point(865, 45);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 32);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Eintrag löschen";
            buttonDelete.TextColor = Color.White;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += OnDelete;
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
            rjButton1.Location = new Point(471, 7);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(159, 32);
            rjButton1.TabIndex = 13;
            rjButton1.Text = "Filter hinzufügen";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += OnFilterAdd;
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
            rjButton2.Location = new Point(471, 45);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(159, 32);
            rjButton2.TabIndex = 13;
            rjButton2.Text = "Zurücksetzen";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += OnReset;
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
            btnUpdate.Location = new Point(688, 7);
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
            txtRows.Location = new Point(688, 45);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(159, 32);
            txtRows.TabIndex = 22;
            txtRows.Text = "Keine Einträge";
            txtRows.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // activeFiltersPanel
            // 
            activeFiltersPanel.Location = new Point(65, 100);
            activeFiltersPanel.Name = "activeFiltersPanel";
            activeFiltersPanel.Size = new Size(1000, 67);
            activeFiltersPanel.TabIndex = 23;
            // 
            // dropCategory
            // 
            dropCategory.BackColor = Color.WhiteSmoke;
            dropCategory.BorderColor = Color.Green;
            dropCategory.BorderSize = 1;
            dropCategory.DropDownStyle = ComboBoxStyle.DropDown;
            dropCategory.Font = new Font("Segoe UI", 10F);
            dropCategory.ForeColor = Color.DimGray;
            dropCategory.IconColor = Color.Green;
            dropCategory.ListBackColor = Color.FromArgb(230, 228, 245);
            dropCategory.ListTextColor = Color.DimGray;
            dropCategory.Location = new Point(65, 20);
            dropCategory.MinimumSize = new Size(200, 30);
            dropCategory.Name = "dropCategory";
            dropCategory.Padding = new Padding(1);
            dropCategory.Size = new Size(200, 30);
            dropCategory.TabIndex = 24;
            dropCategory.Texts = "";
            dropCategory.OnSelectedIndexChanged += onCategorySelect;
            // 
            // dropValue
            // 
            dropValue.BackColor = Color.WhiteSmoke;
            dropValue.BorderColor = Color.Green;
            dropValue.BorderSize = 1;
            dropValue.DropDownStyle = ComboBoxStyle.DropDown;
            dropValue.Font = new Font("Segoe UI", 10F);
            dropValue.ForeColor = Color.DimGray;
            dropValue.IconColor = Color.Green;
            dropValue.ListBackColor = Color.FromArgb(230, 228, 245);
            dropValue.ListTextColor = Color.DimGray;
            dropValue.Location = new Point(65, 56);
            dropValue.MinimumSize = new Size(200, 30);
            dropValue.Name = "dropValue";
            dropValue.Padding = new Padding(1);
            dropValue.Size = new Size(200, 30);
            dropValue.TabIndex = 24;
            dropValue.Texts = "";
            // 
            // dropTabelle
            // 
            dropTabelle.BackColor = Color.WhiteSmoke;
            dropTabelle.BorderColor = Color.Green;
            dropTabelle.BorderSize = 1;
            dropTabelle.DropDownStyle = ComboBoxStyle.DropDown;
            dropTabelle.Font = new Font("Segoe UI", 10F);
            dropTabelle.ForeColor = Color.DimGray;
            dropTabelle.IconColor = Color.Green;
            dropTabelle.ListBackColor = Color.FromArgb(230, 228, 245);
            dropTabelle.ListTextColor = Color.DimGray;
            dropTabelle.Location = new Point(865, 9);
            dropTabelle.MinimumSize = new Size(200, 30);
            dropTabelle.Name = "dropTabelle";
            dropTabelle.Padding = new Padding(1);
            dropTabelle.Size = new Size(200, 30);
            dropTabelle.TabIndex = 24;
            dropTabelle.Texts = "";
            // 
            // FrameShowTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 255, 255, 255);
            Controls.Add(dropValue);
            Controls.Add(dropTabelle);
            Controls.Add(dropCategory);
            Controls.Add(activeFiltersPanel);
            Controls.Add(txtRows);
            Controls.Add(btnUpdate);
            Controls.Add(rjButton1);
            Controls.Add(rjButton2);
            Controls.Add(buttonDelete);
            Controls.Add(gridData);
            Margin = new Padding(0);
            Name = "FrameShowTable";
            Size = new Size(1080, 690);
            Tag = "Frame";
            Load += OnLoad;
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridData;
        private RJCodeAdvance.RJControls.RJButton buttonDelete;
        private DropDown dropFilter;
        private RJTextBox tbFilter;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJTextBox tbListFilters;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label txtRows;
        private FlowLayoutPanel activeFiltersPanel;
        private DropDown dropCategory;
        private DropDown dropValue;
        private DropDown dropTabelle;
    }
}
