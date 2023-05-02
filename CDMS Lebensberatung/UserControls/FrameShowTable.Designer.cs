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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.dropTabelle = new CDMS_Lebensberatung.UserControls.DropDown();
            this.buttonDelete = new RJCodeAdvance.RJControls.RJButton();
            this.tbFilter = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.dropFilter = new CDMS_Lebensberatung.UserControls.DropDown();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.tbListFilters = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeight = 26;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.Location = new System.Drawing.Point(65, 119);
            this.gridData.Margin = new System.Windows.Forms.Padding(10);
            this.gridData.MultiSelect = false;
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.RowHeadersVisible = false;
            this.gridData.RowTemplate.Height = 25;
            this.gridData.Size = new System.Drawing.Size(1000, 555);
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
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.tbFilter.Location = new System.Drawing.Point(285, 27);
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
            this.rjButton1.Location = new System.Drawing.Point(498, 27);
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
            this.dropFilter.Location = new System.Drawing.Point(65, 27);
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
            this.rjButton2.BackColor = System.Drawing.Color.IndianRed;
            this.rjButton2.BackgroundColor = System.Drawing.Color.IndianRed;
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(498, 72);
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
            this.tbListFilters.Location = new System.Drawing.Point(65, 77);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 5);
            this.panel5.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 690);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(67, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 555);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(498, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 35);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(498, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 35);
            this.panel4.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(870, 27);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 35);
            this.panel6.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(688, 27);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(162, 35);
            this.panel7.TabIndex = 19;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.White;
            this.rjButton3.BackgroundColor = System.Drawing.Color.White;
            this.rjButton3.BorderColor = System.Drawing.Color.Black;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.Black;
            this.rjButton3.Location = new System.Drawing.Point(688, 27);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(159, 32);
            this.rjButton3.TabIndex = 13;
            this.rjButton3.Text = "Aktualisieren";
            this.rjButton3.TextColor = System.Drawing.Color.Black;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.OnUpdateClick);
            // 
            // FrameShowTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbListFilters);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dropFilter);
            this.Controls.Add(this.dropTabelle);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FrameShowTable";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Tag = "Frame";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
    }
}
