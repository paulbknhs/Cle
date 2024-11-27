using Cle.UserControls.CustomControls;

namespace Cle.UserControls.Views
{
    partial class Table
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            dropTable = new ComboBox();
            dropCat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tbKeyword = new TextBox();
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
            gridData.Location = new Point(3, 127);
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
            gridData.RowHeadersWidth = 51;
            gridData.Size = new Size(1077, 563);
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
            rjButton1.Location = new Point(10, 12);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(312, 32);
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
            rjButton2.Location = new Point(580, 12);
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
            btnUpdate.Location = new Point(694, 38);
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
            panelActiveFilters.Location = new Point(328, 12);
            panelActiveFilters.Margin = new Padding(3, 2, 3, 2);
            panelActiveFilters.Name = "panelActiveFilters";
            panelActiveFilters.Size = new Size(339, 89);
            panelActiveFilters.TabIndex = 23;
            // 
            // dropTable
            // 
            dropTable.FormattingEnabled = true;
            dropTable.Location = new Point(877, 9);
            dropTable.Name = "dropTable";
            dropTable.Size = new Size(200, 23);
            dropTable.TabIndex = 24;
            // 
            // dropCat
            // 
            dropCat.FormattingEnabled = true;
            dropCat.Location = new Point(169, 54);
            dropCat.Name = "dropCat";
            dropCat.Size = new Size(153, 23);
            dropCat.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 52);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 26;
            label1.Text = "Spaltenbezeichnung:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(44, 78);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 26;
            label2.Text = "muss enthalten:";
            // 
            // tbKeyword
            // 
            tbKeyword.Location = new Point(169, 78);
            tbKeyword.Name = "tbKeyword";
            tbKeyword.Size = new Size(153, 23);
            tbKeyword.TabIndex = 27;
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tbKeyword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dropCat);
            Controls.Add(dropTable);
            Controls.Add(panelActiveFilters);
            Controls.Add(txtRows);
            Controls.Add(btnUpdate);
            Controls.Add(rjButton1);
            Controls.Add(rjButton2);
            Controls.Add(buttonDelete);
            Controls.Add(gridData);
            Margin = new Padding(0);
            Name = "Table";
            Size = new Size(1080, 690);
            Tag = "Frame";
            Load += OnLoad;
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridData;
        private RJCodeAdvance.RJControls.RJButton buttonDelete;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label txtRows;
        private DropDown dropComparator;
        private FlowLayoutPanel panelActiveFilters;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ComboBox dropTable;
    private ComboBox dropCat;
        private Label label1;
        private Label label2;
        private TextBox tbKeyword;
    }
}
