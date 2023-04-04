using CDMS_Lebensberatung.UserControls;

namespace CDMS_Lebensberatung.AddSpecific
{
    partial class Sgb8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toggleWartezeit = new RJCodeAdvance.RJControls.RJToggleButton();
            this.dropLeistung = new DropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dropWirtschaft = new DropDown();
            this.dropHerkunftHh = new DropDown();
            this.dropHilfe = new DropDown();
            this.gridStunden = new System.Windows.Forms.DataGridView();
            this.Art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stunden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new RJCodeAdvance.RJControls.RJButton();
            this.dropAnmeldung = new DropDown();
            this.tbAge = new RJTextBox();
            this.dropGender = new DropDown();
            this.tbErläuterungen = new RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStunden)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleWartezeit
            // 
            this.toggleWartezeit.AutoSize = true;
            this.toggleWartezeit.Location = new System.Drawing.Point(40, 90);
            this.toggleWartezeit.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleWartezeit.Name = "toggleWartezeit";
            this.toggleWartezeit.OffBackColor = System.Drawing.Color.Gray;
            this.toggleWartezeit.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleWartezeit.OnBackColor = System.Drawing.Color.Green;
            this.toggleWartezeit.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleWartezeit.Size = new System.Drawing.Size(45, 22);
            this.toggleWartezeit.TabIndex = 8;
            this.toggleWartezeit.UseVisualStyleBackColor = true;
            // 
            // dropLeistung
            // 
            this.dropLeistung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropLeistung.BorderColor = System.Drawing.Color.Black;
            this.dropLeistung.BorderSize = 1;
            this.dropLeistung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropLeistung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropLeistung.ForeColor = System.Drawing.Color.DimGray;
            this.dropLeistung.IconColor = System.Drawing.Color.Black;
            this.dropLeistung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropLeistung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropLeistung.Location = new System.Drawing.Point(40, 317);
            this.dropLeistung.Margin = new System.Windows.Forms.Padding(10);
            this.dropLeistung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropLeistung.Name = "dropLeistung";
            this.dropLeistung.Padding = new System.Windows.Forms.Padding(1);
            this.dropLeistung.Size = new System.Drawing.Size(200, 32);
            this.dropLeistung.TabIndex = 7;
            this.dropLeistung.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wartezeit länger als 4 Wochen";
            // 
            // dropWirtschaft
            // 
            this.dropWirtschaft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropWirtschaft.BorderColor = System.Drawing.Color.Black;
            this.dropWirtschaft.BorderSize = 1;
            this.dropWirtschaft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropWirtschaft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropWirtschaft.ForeColor = System.Drawing.Color.DimGray;
            this.dropWirtschaft.IconColor = System.Drawing.Color.Black;
            this.dropWirtschaft.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropWirtschaft.ListTextColor = System.Drawing.Color.DimGray;
            this.dropWirtschaft.Location = new System.Drawing.Point(40, 421);
            this.dropWirtschaft.Margin = new System.Windows.Forms.Padding(10);
            this.dropWirtschaft.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropWirtschaft.Name = "dropWirtschaft";
            this.dropWirtschaft.Padding = new System.Windows.Forms.Padding(1);
            this.dropWirtschaft.Size = new System.Drawing.Size(200, 32);
            this.dropWirtschaft.TabIndex = 7;
            this.dropWirtschaft.Texts = "";
            // 
            // dropHerkunftHh
            // 
            this.dropHerkunftHh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropHerkunftHh.BorderColor = System.Drawing.Color.Black;
            this.dropHerkunftHh.BorderSize = 1;
            this.dropHerkunftHh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropHerkunftHh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropHerkunftHh.ForeColor = System.Drawing.Color.DimGray;
            this.dropHerkunftHh.IconColor = System.Drawing.Color.Black;
            this.dropHerkunftHh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropHerkunftHh.ListTextColor = System.Drawing.Color.DimGray;
            this.dropHerkunftHh.Location = new System.Drawing.Point(40, 369);
            this.dropHerkunftHh.Margin = new System.Windows.Forms.Padding(10);
            this.dropHerkunftHh.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropHerkunftHh.Name = "dropHerkunftHh";
            this.dropHerkunftHh.Padding = new System.Windows.Forms.Padding(1);
            this.dropHerkunftHh.Size = new System.Drawing.Size(200, 32);
            this.dropHerkunftHh.TabIndex = 7;
            this.dropHerkunftHh.Texts = "";
            // 
            // dropHilfe
            // 
            this.dropHilfe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropHilfe.BorderColor = System.Drawing.Color.Black;
            this.dropHilfe.BorderSize = 1;
            this.dropHilfe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropHilfe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropHilfe.ForeColor = System.Drawing.Color.DimGray;
            this.dropHilfe.IconColor = System.Drawing.Color.Black;
            this.dropHilfe.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropHilfe.ListTextColor = System.Drawing.Color.DimGray;
            this.dropHilfe.Location = new System.Drawing.Point(40, 473);
            this.dropHilfe.Margin = new System.Windows.Forms.Padding(10);
            this.dropHilfe.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropHilfe.Name = "dropHilfe";
            this.dropHilfe.Padding = new System.Windows.Forms.Padding(1);
            this.dropHilfe.Size = new System.Drawing.Size(200, 32);
            this.dropHilfe.TabIndex = 7;
            this.dropHilfe.Texts = "";
            // 
            // gridStunden
            // 
            this.gridStunden.AllowUserToAddRows = false;
            this.gridStunden.AllowUserToDeleteRows = false;
            this.gridStunden.AllowUserToResizeColumns = false;
            this.gridStunden.AllowUserToResizeRows = false;
            this.gridStunden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStunden.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridStunden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridStunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStunden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Art,
            this.Stunden});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStunden.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridStunden.EnableHeadersVisualStyles = false;
            this.gridStunden.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gridStunden.Location = new System.Drawing.Point(253, 265);
            this.gridStunden.Name = "gridStunden";
            this.gridStunden.RowHeadersVisible = false;
            this.gridStunden.RowHeadersWidth = 40;
            this.gridStunden.RowTemplate.Height = 25;
            this.gridStunden.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridStunden.Size = new System.Drawing.Size(200, 220);
            this.gridStunden.TabIndex = 10;
            this.gridStunden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnValueChange);
            // 
            // Art
            // 
            this.Art.HeaderText = "Art";
            this.Art.Name = "Art";
            // 
            // Stunden
            // 
            this.Stunden.HeaderText = "Stunden";
            this.Stunden.Name = "Stunden";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.BackgroundColor = System.Drawing.Color.White;
            this.buttonSave.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.BorderRadius = 0;
            this.buttonSave.BorderSize = 1;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(253, 517);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 40);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSave);
            // 
            // dropAnmeldung
            // 
            this.dropAnmeldung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropAnmeldung.BorderColor = System.Drawing.Color.Black;
            this.dropAnmeldung.BorderSize = 1;
            this.dropAnmeldung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropAnmeldung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropAnmeldung.ForeColor = System.Drawing.Color.DimGray;
            this.dropAnmeldung.IconColor = System.Drawing.Color.Black;
            this.dropAnmeldung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropAnmeldung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropAnmeldung.Location = new System.Drawing.Point(40, 265);
            this.dropAnmeldung.Margin = new System.Windows.Forms.Padding(10);
            this.dropAnmeldung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropAnmeldung.Name = "dropAnmeldung";
            this.dropAnmeldung.Padding = new System.Windows.Forms.Padding(1);
            this.dropAnmeldung.Size = new System.Drawing.Size(200, 32);
            this.dropAnmeldung.TabIndex = 18;
            this.dropAnmeldung.Texts = "";
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.SystemColors.Window;
            this.tbAge.BorderColor = System.Drawing.Color.Black;
            this.tbAge.BorderFocusColor = System.Drawing.Color.Green;
            this.tbAge.BorderRadius = 0;
            this.tbAge.BorderSize = 1;
            this.tbAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAge.Location = new System.Drawing.Point(40, 125);
            this.tbAge.Margin = new System.Windows.Forms.Padding(10);
            this.tbAge.Multiline = false;
            this.tbAge.Name = "tbAge";
            this.tbAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbAge.PasswordChar = false;
            this.tbAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbAge.PlaceholderText = "Alter";
            this.tbAge.Size = new System.Drawing.Size(200, 32);
            this.tbAge.TabIndex = 19;
            this.tbAge.Texts = "";
            this.tbAge.UnderlinedStyle = true;
            // 
            // dropGender
            // 
            this.dropGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropGender.BorderColor = System.Drawing.Color.Black;
            this.dropGender.BorderSize = 1;
            this.dropGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropGender.ForeColor = System.Drawing.Color.DimGray;
            this.dropGender.IconColor = System.Drawing.Color.Black;
            this.dropGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropGender.ListTextColor = System.Drawing.Color.DimGray;
            this.dropGender.Location = new System.Drawing.Point(253, 125);
            this.dropGender.Margin = new System.Windows.Forms.Padding(10);
            this.dropGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropGender.Name = "dropGender";
            this.dropGender.Padding = new System.Windows.Forms.Padding(1);
            this.dropGender.Size = new System.Drawing.Size(200, 32);
            this.dropGender.TabIndex = 7;
            this.dropGender.Texts = "";
            // 
            // tbErläuterungen
            // 
            this.tbErläuterungen.BackColor = System.Drawing.SystemColors.Window;
            this.tbErläuterungen.BorderColor = System.Drawing.Color.Black;
            this.tbErläuterungen.BorderFocusColor = System.Drawing.Color.Green;
            this.tbErläuterungen.BorderRadius = 0;
            this.tbErläuterungen.BorderSize = 1;
            this.tbErläuterungen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbErläuterungen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbErläuterungen.Location = new System.Drawing.Point(40, 525);
            this.tbErläuterungen.Margin = new System.Windows.Forms.Padding(10);
            this.tbErläuterungen.Multiline = false;
            this.tbErläuterungen.Name = "tbErläuterungen";
            this.tbErläuterungen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbErläuterungen.PasswordChar = false;
            this.tbErläuterungen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbErläuterungen.PlaceholderText = "Andere Gründe";
            this.tbErläuterungen.Size = new System.Drawing.Size(200, 32);
            this.tbErläuterungen.TabIndex = 19;
            this.tbErläuterungen.Texts = "";
            this.tbErläuterungen.UnderlinedStyle = true;
            // 
            // Sgb8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbErläuterungen);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.dropAnmeldung);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.gridStunden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleWartezeit);
            this.Controls.Add(this.dropGender);
            this.Controls.Add(this.dropHilfe);
            this.Controls.Add(this.dropHerkunftHh);
            this.Controls.Add(this.dropWirtschaft);
            this.Controls.Add(this.dropLeistung);
            this.Name = "Sgb8";
            this.Size = new System.Drawing.Size(500, 590);
            this.Load += new System.EventHandler(this.Sgb8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStunden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJToggleButton toggleWartezeit;
        private DropDown dropLeistung;
        private Label label1;
        private DropDown dropWirtschaft;
        private DropDown dropHerkunftHh;
        private DropDown dropHilfe;
        private DataGridView gridStunden;
        private DataGridViewTextBoxColumn Art;
        private DataGridViewTextBoxColumn Stunden;
        private RJCodeAdvance.RJControls.RJButton buttonSave;
        private DropDown dropAnmeldung;
        private RJTextBox tbAge;
        private DropDown dropGender;
        private RJTextBox tbErläuterungen;
    }
}
