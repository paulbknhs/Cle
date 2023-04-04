using CDMS_Lebensberatung.Controls;

namespace CDMS_Lebensberatung.Views
{
    partial class SearchView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.dropTabelle = new CDMS_Lebensberatung.Controls.DropDown();
            this.buttonDelete = new RJCodeAdvance.RJControls.RJButton();
            this.tbFilter = new CustomControls.RJControls.RJTextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.dropFilter = new CDMS_Lebensberatung.Controls.DropDown();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.tbListFilters = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridData.Location = new System.Drawing.Point(10, 119);
            this.gridData.Margin = new System.Windows.Forms.Padding(10);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridData.RowHeadersVisible = false;
            this.gridData.RowTemplate.Height = 25;
            this.gridData.Size = new System.Drawing.Size(1060, 561);
            this.gridData.TabIndex = 0;
            // 
            // dropTabelle
            // 
            this.dropTabelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropTabelle.BorderColor = System.Drawing.Color.Black;
            this.dropTabelle.BorderSize = 1;
            this.dropTabelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropTabelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropTabelle.ForeColor = System.Drawing.Color.DimGray;
            this.dropTabelle.IconColor = System.Drawing.Color.Black;
            this.dropTabelle.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropTabelle.ListTextColor = System.Drawing.Color.DimGray;
            this.dropTabelle.Location = new System.Drawing.Point(870, 72);
            this.dropTabelle.Margin = new System.Windows.Forms.Padding(10);
            this.dropTabelle.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropTabelle.Name = "dropTabelle";
            this.dropTabelle.Padding = new System.Windows.Forms.Padding(1);
            this.dropTabelle.Size = new System.Drawing.Size(200, 32);
            this.dropTabelle.TabIndex = 4;
            this.dropTabelle.Texts = "";
            this.dropTabelle.OnSelectedIndexChanged += new System.EventHandler(this.OnSelection);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Tomato;
            this.buttonDelete.BackgroundColor = System.Drawing.Color.Tomato;
            this.buttonDelete.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.BorderRadius = 0;
            this.buttonDelete.BorderSize = 0;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(870, 27);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 32);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eintrag löschen";
            this.buttonDelete.TextColor = System.Drawing.Color.White;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.OnDelete);
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.SystemColors.Window;
            this.tbFilter.BorderColor = System.Drawing.Color.Black;
            this.tbFilter.BorderFocusColor = System.Drawing.Color.Green;
            this.tbFilter.BorderRadius = 0;
            this.tbFilter.BorderSize = 1;
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFilter.Location = new System.Drawing.Point(230, 27);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(10);
            this.tbFilter.Multiline = false;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbFilter.PasswordChar = false;
            this.tbFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbFilter.PlaceholderText = "Filtern nach...";
            this.tbFilter.Size = new System.Drawing.Size(200, 32);
            this.tbFilter.TabIndex = 15;
            this.tbFilter.Texts = "";
            this.tbFilter.UnderlinedStyle = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Green;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(443, 27);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(159, 32);
            this.rjButton1.TabIndex = 13;
            this.rjButton1.Text = "Filter hinzufügen";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.OnFilterAdd);
            // 
            // dropFilter
            // 
            this.dropFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropFilter.BorderColor = System.Drawing.Color.Black;
            this.dropFilter.BorderSize = 1;
            this.dropFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropFilter.ForeColor = System.Drawing.Color.DimGray;
            this.dropFilter.IconColor = System.Drawing.Color.Black;
            this.dropFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.dropFilter.Location = new System.Drawing.Point(10, 27);
            this.dropFilter.Margin = new System.Windows.Forms.Padding(10);
            this.dropFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropFilter.Name = "dropFilter";
            this.dropFilter.Padding = new System.Windows.Forms.Padding(1);
            this.dropFilter.Size = new System.Drawing.Size(200, 32);
            this.dropFilter.TabIndex = 4;
            this.dropFilter.Texts = "";
            this.dropFilter.OnSelectedIndexChanged += new System.EventHandler(this.OnSelection);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Tomato;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Tomato;
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(443, 72);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(159, 32);
            this.rjButton2.TabIndex = 13;
            this.rjButton2.Text = "Zurücksetzen";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.OnReset);
            // 
            // tbListFilters
            // 
            this.tbListFilters.AutoSize = true;
            this.tbListFilters.BackColor = System.Drawing.Color.LightGray;
            this.tbListFilters.BorderColor = System.Drawing.Color.Black;
            this.tbListFilters.BorderFocusColor = System.Drawing.Color.Black;
            this.tbListFilters.BorderRadius = 0;
            this.tbListFilters.BorderSize = 1;
            this.tbListFilters.Enabled = false;
            this.tbListFilters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbListFilters.ForeColor = System.Drawing.Color.Black;
            this.tbListFilters.Location = new System.Drawing.Point(10, 77);
            this.tbListFilters.Margin = new System.Windows.Forms.Padding(10);
            this.tbListFilters.Multiline = false;
            this.tbListFilters.Name = "tbListFilters";
            this.tbListFilters.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbListFilters.PasswordChar = false;
            this.tbListFilters.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbListFilters.PlaceholderText = "Keine aktiven Filter";
            this.tbListFilters.Size = new System.Drawing.Size(420, 32);
            this.tbListFilters.TabIndex = 15;
            this.tbListFilters.Texts = "";
            this.tbListFilters.UnderlinedStyle = false;
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.tbListFilters);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dropFilter);
            this.Controls.Add(this.dropTabelle);
            this.Controls.Add(this.gridData);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchView";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Tag = "View";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridData;
        private Controls.DropDown dropTabelle;
        private RJCodeAdvance.RJControls.RJButton buttonDelete;
        private Controls.DropDown dropFilter;
        private CustomControls.RJControls.RJTextBox tbFilter;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJTextBox tbListFilters;
    }
}
