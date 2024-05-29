using CDMS_Lebensberatung.UserControls.CustomControls;

namespace CDMS_Lebensberatung.UserControls
{
    partial class table
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
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridData.DefaultCellStyle = dataGridViewCellStyle2;
            gridData.Location = new Point(3, 114);
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
            gridData.Size = new Size(1077, 576);
            gridData.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Salmon;
            buttonDelete.BackgroundColor = Color.Salmon;
            buttonDelete.BorderColor = Color.Black;
            buttonDelete.BorderRadius = 0;
            buttonDelete.BorderSize = 0;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.DimGray;
            buttonDelete.Location = new Point(877, 41);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 32);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Eintrag löschen";
            buttonDelete.TextColor = Color.DimGray;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += OnDelete;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.LightBlue;
            rjButton1.BackgroundColor = Color.LightBlue;
            rjButton1.BorderColor = Color.White;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9F);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(415, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(159, 32);
            rjButton1.TabIndex = 13;
            rjButton1.Text = "Filter hinzufügen";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += OnFilterAdd;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Salmon;
            rjButton2.BackgroundColor = Color.Salmon;
            rjButton2.BorderColor = Color.White;
            rjButton2.BorderRadius = 0;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.DimGray;
            rjButton2.Location = new Point(415, 41);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(159, 32);
            rjButton2.TabIndex = 13;
            rjButton2.Text = "Zurücksetzen";
            rjButton2.TextColor = Color.DimGray;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += OnReset;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.BackgroundColor = Color.LightBlue;
            btnUpdate.BorderColor = Color.Black;
            btnUpdate.BorderRadius = 0;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(580, 3);
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
            txtRows.BackColor = Color.Azure;
            txtRows.ForeColor = Color.Salmon;
            txtRows.Location = new Point(745, 3);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(126, 32);
            txtRows.TabIndex = 22;
            txtRows.Text = "Keine Einträge";
            txtRows.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActiveFilters
            // 
            panelActiveFilters.BackColor = Color.LightBlue;
            panelActiveFilters.Location = new Point(3, 79);
            panelActiveFilters.Name = "panelActiveFilters";
            panelActiveFilters.Size = new Size(1074, 31);
            panelActiveFilters.TabIndex = 23;
            // 
            // dropCategory
            // 
            dropCategory.BackColor = Color.WhiteSmoke;
            dropCategory.BorderColor = Color.LightBlue;
            dropCategory.BorderSize = 1;
            dropCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            dropCategory.Font = new Font("Segoe UI", 10F);
            dropCategory.ForeColor = Color.DimGray;
            dropCategory.IconColor = Color.LightBlue;
            dropCategory.ListBackColor = Color.White;
            dropCategory.ListTextColor = Color.DimGray;
            dropCategory.Location = new Point(3, 3);
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
            dropValue.BorderColor = Color.LightBlue;
            dropValue.BorderSize = 1;
            dropValue.DropDownStyle = ComboBoxStyle.DropDownList;
            dropValue.Font = new Font("Segoe UI", 10F);
            dropValue.ForeColor = Color.DimGray;
            dropValue.IconColor = Color.LightBlue;
            dropValue.ListBackColor = Color.White;
            dropValue.ListTextColor = Color.DimGray;
            dropValue.Location = new Point(209, 3);
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
            dropTable.BorderColor = Color.LightBlue;
            dropTable.BorderSize = 1;
            dropTable.DropDownStyle = ComboBoxStyle.DropDownList;
            dropTable.Font = new Font("Segoe UI", 10F);
            dropTable.ForeColor = Color.DimGray;
            dropTable.IconColor = Color.LightBlue;
            dropTable.ListBackColor = Color.White;
            dropTable.ListTextColor = Color.DimGray;
            dropTable.Location = new Point(877, 5);
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
            dropComparator.BorderColor = Color.LightBlue;
            dropComparator.BorderSize = 1;
            dropComparator.DropDownStyle = ComboBoxStyle.DropDownList;
            dropComparator.Font = new Font("Segoe UI", 10F);
            dropComparator.ForeColor = Color.DimGray;
            dropComparator.IconColor = Color.LightBlue;
            dropComparator.ListBackColor = Color.White;
            dropComparator.ListTextColor = Color.DimGray;
            dropComparator.Location = new Point(3, 39);
            dropComparator.MinimumSize = new Size(200, 30);
            dropComparator.Name = "dropComparator";
            dropComparator.Padding = new Padding(1);
            dropComparator.Size = new Size(200, 30);
            dropComparator.TabIndex = 24;
            dropComparator.Texts = "";
            dropComparator.OnSelectedIndexChanged += onCategorySelect;
            // 
            // table
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
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
            Name = "table";
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
