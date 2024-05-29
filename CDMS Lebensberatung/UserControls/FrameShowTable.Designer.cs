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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gridData = new DataGridView();
            buttonDelete = new RJCodeAdvance.RJControls.RJButton();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            txtRows = new Label();
            panelActiveFilters = new FlowLayoutPanel();
            dropCategory = new DropDown();
            dropValue = new DropDown();
            dropTable = new DropDown();
            dropComparator = new DropDown();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridData.ColumnHeadersHeight = 26;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridData.DefaultCellStyle = dataGridViewCellStyle2;
            gridData.Location = new Point(65, 180);
            gridData.Margin = new Padding(10);
            gridData.MultiSelect = false;
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            buttonDelete.Location = new Point(865, 60);
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
            rjButton1.Location = new Point(438, 22);
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
            rjButton2.Location = new Point(438, 60);
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
            btnUpdate.Location = new Point(603, 22);
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
            txtRows.Location = new Point(603, 60);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(159, 32);
            txtRows.TabIndex = 22;
            txtRows.Text = "Keine Einträge";
            txtRows.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActiveFilters
            // 
            panelActiveFilters.Location = new Point(65, 100);
            panelActiveFilters.Name = "panelActiveFilters";
            panelActiveFilters.Size = new Size(1000, 67);
            panelActiveFilters.TabIndex = 23;
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
            dropCategory.Location = new Point(26, 22);
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
            dropValue.Location = new Point(232, 22);
            dropValue.MinimumSize = new Size(200, 30);
            dropValue.Name = "dropValue";
            dropValue.Padding = new Padding(1);
            dropValue.Size = new Size(200, 30);
            dropValue.TabIndex = 24;
            dropValue.Texts = "";
            // 
            // dropTable
            // 
            dropTable.BackColor = Color.WhiteSmoke;
            dropTable.BorderColor = Color.Green;
            dropTable.BorderSize = 1;
            dropTable.DropDownStyle = ComboBoxStyle.DropDown;
            dropTable.Font = new Font("Segoe UI", 10F);
            dropTable.ForeColor = Color.DimGray;
            dropTable.IconColor = Color.Green;
            dropTable.ListBackColor = Color.FromArgb(230, 228, 245);
            dropTable.ListTextColor = Color.DimGray;
            dropTable.Location = new Point(865, 24);
            dropTable.MinimumSize = new Size(200, 30);
            dropTable.Name = "dropTable";
            dropTable.Padding = new Padding(1);
            dropTable.Size = new Size(200, 30);
            dropTable.TabIndex = 24;
            dropTable.Texts = "";
            // 
            // dropComparator
            // 
            dropComparator.BackColor = Color.WhiteSmoke;
            dropComparator.BorderColor = Color.Green;
            dropComparator.BorderSize = 1;
            dropComparator.DropDownStyle = ComboBoxStyle.DropDown;
            dropComparator.Font = new Font("Segoe UI", 10F);
            dropComparator.ForeColor = Color.DimGray;
            dropComparator.IconColor = Color.Green;
            dropComparator.ListBackColor = Color.FromArgb(230, 228, 245);
            dropComparator.ListTextColor = Color.DimGray;
            dropComparator.Location = new Point(26, 58);
            dropComparator.MinimumSize = new Size(200, 30);
            dropComparator.Name = "dropComparator";
            dropComparator.Padding = new Padding(1);
            dropComparator.Size = new Size(200, 30);
            dropComparator.TabIndex = 24;
            dropComparator.Texts = "";
            dropComparator.OnSelectedIndexChanged += onCategorySelect;
            // 
            // FrameShowTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 255, 255, 255);
            Controls.Add(dropValue);
            Controls.Add(dropTable);
            Controls.Add(dropComparator);
            Controls.Add(dropCategory);
            Controls.Add(panelActiveFilters);
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
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label txtRows;
        private FlowLayoutPanel panelActiveFilters;
        private DropDown dropCategory;
        private DropDown dropValue;
        private DropDown dropTable;
        private DropDown dropComparator;
    }
}
