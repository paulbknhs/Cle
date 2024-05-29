using CDMS_Lebensberatung.UserControls;
using CDMS_Lebensberatung.UserControls.CustomControls;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toggleWartezeit = new RJCodeAdvance.RJControls.RJToggleButton();
            dropLeistung = new DropDown();
            label1 = new Label();
            dropWirtschaft = new DropDown();
            dropHerkunftHh = new DropDown();
            dropHilfe = new DropDown();
            gridStunden = new DataGridView();
            Art = new DataGridViewTextBoxColumn();
            Stunden = new DataGridViewTextBoxColumn();
            dropAnmeldung = new DropDown();
            tbAlter = new RJTextBox();
            dropGender = new DropDown();
            tbErläuterungen = new RJTextBox();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            panel4 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridStunden).BeginInit();
            SuspendLayout();
            // 
            // toggleWartezeit
            // 
            toggleWartezeit.AutoSize = true;
            toggleWartezeit.BackColor = Color.White;
            toggleWartezeit.Location = new Point(40, 90);
            toggleWartezeit.MinimumSize = new Size(45, 22);
            toggleWartezeit.Name = "toggleWartezeit";
            toggleWartezeit.OffBackColor = Color.Gray;
            toggleWartezeit.OffToggleColor = Color.Gainsboro;
            toggleWartezeit.OnBackColor = Color.SkyBlue;
            toggleWartezeit.OnToggleColor = Color.WhiteSmoke;
            toggleWartezeit.Size = new Size(45, 22);
            toggleWartezeit.TabIndex = 8;
            toggleWartezeit.UseVisualStyleBackColor = false;
            // 
            // dropLeistung
            // 
            dropLeistung.BackColor = Color.WhiteSmoke;
            dropLeistung.BorderColor = Color.SkyBlue;
            dropLeistung.BorderSize = 1;
            dropLeistung.DropDownStyle = ComboBoxStyle.DropDownList;
            dropLeistung.Font = new Font("Segoe UI", 10F);
            dropLeistung.ForeColor = Color.DimGray;
            dropLeistung.IconColor = Color.SkyBlue;
            dropLeistung.ListBackColor = Color.FromArgb(230, 228, 245);
            dropLeistung.ListTextColor = Color.DimGray;
            dropLeistung.Location = new Point(40, 317);
            dropLeistung.Margin = new Padding(10);
            dropLeistung.MinimumSize = new Size(200, 30);
            dropLeistung.Name = "dropLeistung";
            dropLeistung.Padding = new Padding(1);
            dropLeistung.Size = new Size(200, 32);
            dropLeistung.TabIndex = 7;
            dropLeistung.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 93);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 9;
            label1.Text = "Wartezeit länger als 4 Wochen";
            // 
            // dropWirtschaft
            // 
            dropWirtschaft.BackColor = Color.WhiteSmoke;
            dropWirtschaft.BorderColor = Color.SkyBlue;
            dropWirtschaft.BorderSize = 1;
            dropWirtschaft.DropDownStyle = ComboBoxStyle.DropDownList;
            dropWirtschaft.Font = new Font("Segoe UI", 10F);
            dropWirtschaft.ForeColor = Color.DimGray;
            dropWirtschaft.IconColor = Color.SkyBlue;
            dropWirtschaft.ListBackColor = Color.FromArgb(230, 228, 245);
            dropWirtschaft.ListTextColor = Color.DimGray;
            dropWirtschaft.Location = new Point(40, 421);
            dropWirtschaft.Margin = new Padding(10);
            dropWirtschaft.MinimumSize = new Size(200, 30);
            dropWirtschaft.Name = "dropWirtschaft";
            dropWirtschaft.Padding = new Padding(1);
            dropWirtschaft.Size = new Size(200, 32);
            dropWirtschaft.TabIndex = 7;
            dropWirtschaft.Texts = "";
            // 
            // dropHerkunftHh
            // 
            dropHerkunftHh.BackColor = Color.WhiteSmoke;
            dropHerkunftHh.BorderColor = Color.SkyBlue;
            dropHerkunftHh.BorderSize = 1;
            dropHerkunftHh.DropDownStyle = ComboBoxStyle.DropDownList;
            dropHerkunftHh.Font = new Font("Segoe UI", 10F);
            dropHerkunftHh.ForeColor = Color.DimGray;
            dropHerkunftHh.IconColor = Color.SkyBlue;
            dropHerkunftHh.ListBackColor = Color.FromArgb(230, 228, 245);
            dropHerkunftHh.ListTextColor = Color.DimGray;
            dropHerkunftHh.Location = new Point(40, 369);
            dropHerkunftHh.Margin = new Padding(10);
            dropHerkunftHh.MinimumSize = new Size(200, 30);
            dropHerkunftHh.Name = "dropHerkunftHh";
            dropHerkunftHh.Padding = new Padding(1);
            dropHerkunftHh.Size = new Size(200, 32);
            dropHerkunftHh.TabIndex = 7;
            dropHerkunftHh.Texts = "";
            // 
            // dropHilfe
            // 
            dropHilfe.BackColor = Color.WhiteSmoke;
            dropHilfe.BorderColor = Color.SkyBlue;
            dropHilfe.BorderSize = 1;
            dropHilfe.DropDownStyle = ComboBoxStyle.DropDownList;
            dropHilfe.Font = new Font("Segoe UI", 10F);
            dropHilfe.ForeColor = Color.DimGray;
            dropHilfe.IconColor = Color.SkyBlue;
            dropHilfe.ListBackColor = Color.FromArgb(230, 228, 245);
            dropHilfe.ListTextColor = Color.DimGray;
            dropHilfe.Location = new Point(40, 473);
            dropHilfe.Margin = new Padding(10);
            dropHilfe.MinimumSize = new Size(200, 30);
            dropHilfe.Name = "dropHilfe";
            dropHilfe.Padding = new Padding(1);
            dropHilfe.Size = new Size(200, 32);
            dropHilfe.TabIndex = 7;
            dropHilfe.Texts = "";
            // 
            // gridStunden
            // 
            gridStunden.AllowUserToAddRows = false;
            gridStunden.AllowUserToDeleteRows = false;
            gridStunden.AllowUserToResizeColumns = false;
            gridStunden.AllowUserToResizeRows = false;
            gridStunden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridStunden.BackgroundColor = SystemColors.ControlLight;
            gridStunden.BorderStyle = BorderStyle.Fixed3D;
            gridStunden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStunden.Columns.AddRange(new DataGridViewColumn[] { Art, Stunden });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridStunden.DefaultCellStyle = dataGridViewCellStyle1;
            gridStunden.EnableHeadersVisualStyles = false;
            gridStunden.GridColor = SystemColors.ControlLight;
            gridStunden.Location = new Point(253, 265);
            gridStunden.Name = "gridStunden";
            gridStunden.RowHeadersVisible = false;
            gridStunden.RowHeadersWidth = 40;
            gridStunden.ScrollBars = ScrollBars.None;
            gridStunden.Size = new Size(200, 220);
            gridStunden.TabIndex = 10;
            gridStunden.CellValueChanged += OnValueChange;
            // 
            // Art
            // 
            Art.HeaderText = "Art";
            Art.Name = "Art";
            // 
            // Stunden
            // 
            Stunden.HeaderText = "Stunden";
            Stunden.Name = "Stunden";
            // 
            // dropAnmeldung
            // 
            dropAnmeldung.BackColor = Color.WhiteSmoke;
            dropAnmeldung.BorderColor = Color.SkyBlue;
            dropAnmeldung.BorderSize = 1;
            dropAnmeldung.DropDownStyle = ComboBoxStyle.DropDownList;
            dropAnmeldung.Font = new Font("Segoe UI", 10F);
            dropAnmeldung.ForeColor = Color.DimGray;
            dropAnmeldung.IconColor = Color.SkyBlue;
            dropAnmeldung.ListBackColor = Color.FromArgb(230, 228, 245);
            dropAnmeldung.ListTextColor = Color.DimGray;
            dropAnmeldung.Location = new Point(40, 265);
            dropAnmeldung.Margin = new Padding(10);
            dropAnmeldung.MinimumSize = new Size(200, 30);
            dropAnmeldung.Name = "dropAnmeldung";
            dropAnmeldung.Padding = new Padding(1);
            dropAnmeldung.Size = new Size(200, 32);
            dropAnmeldung.TabIndex = 18;
            dropAnmeldung.Texts = "";
            // 
            // tbAlter
            // 
            tbAlter.BackColor = SystemColors.Window;
            tbAlter.BorderColor = Color.Black;
            tbAlter.BorderFocusColor = Color.SkyBlue;
            tbAlter.BorderRadius = 0;
            tbAlter.BorderSize = 1;
            tbAlter.Font = new Font("Segoe UI", 9.75F);
            tbAlter.ForeColor = Color.FromArgb(64, 64, 64);
            tbAlter.Location = new Point(40, 125);
            tbAlter.Margin = new Padding(10);
            tbAlter.Multiline = false;
            tbAlter.Name = "tbAlter";
            tbAlter.Padding = new Padding(10, 7, 10, 7);
            tbAlter.PasswordChar = false;
            tbAlter.PlaceholderColor = Color.DarkGray;
            tbAlter.PlaceholderText = "Alter";
            tbAlter.Size = new Size(200, 32);
            tbAlter.TabIndex = 19;
            tbAlter.Texts = "";
            tbAlter.UnderlinedStyle = true;
            // 
            // dropGender
            // 
            dropGender.BackColor = Color.WhiteSmoke;
            dropGender.BorderColor = Color.SkyBlue;
            dropGender.BorderSize = 1;
            dropGender.DropDownStyle = ComboBoxStyle.DropDownList;
            dropGender.Font = new Font("Segoe UI", 10F);
            dropGender.ForeColor = Color.DimGray;
            dropGender.IconColor = Color.SkyBlue;
            dropGender.ListBackColor = Color.FromArgb(230, 228, 245);
            dropGender.ListTextColor = Color.DimGray;
            dropGender.Location = new Point(253, 125);
            dropGender.Margin = new Padding(10);
            dropGender.MinimumSize = new Size(200, 30);
            dropGender.Name = "dropGender";
            dropGender.Padding = new Padding(1);
            dropGender.Size = new Size(200, 32);
            dropGender.TabIndex = 7;
            dropGender.Texts = "";
            // 
            // tbErläuterungen
            // 
            tbErläuterungen.BackColor = SystemColors.Window;
            tbErläuterungen.BorderColor = Color.Black;
            tbErläuterungen.BorderFocusColor = Color.SkyBlue;
            tbErläuterungen.BorderRadius = 0;
            tbErläuterungen.BorderSize = 1;
            tbErläuterungen.Font = new Font("Segoe UI", 9.75F);
            tbErläuterungen.ForeColor = Color.FromArgb(64, 64, 64);
            tbErläuterungen.Location = new Point(40, 525);
            tbErläuterungen.Margin = new Padding(10);
            tbErläuterungen.Multiline = false;
            tbErläuterungen.Name = "tbErläuterungen";
            tbErläuterungen.Padding = new Padding(10, 7, 10, 7);
            tbErläuterungen.PasswordChar = false;
            tbErläuterungen.PlaceholderColor = Color.DarkGray;
            tbErläuterungen.PlaceholderText = "Andere Gründe";
            tbErläuterungen.Size = new Size(200, 32);
            tbErläuterungen.TabIndex = 19;
            tbErläuterungen.Texts = "";
            tbErläuterungen.UnderlinedStyle = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SkyBlue;
            btnSave.BackgroundColor = Color.SkyBlue;
            btnSave.BorderColor = Color.Transparent;
            btnSave.BorderRadius = 0;
            btnSave.BorderSize = 1;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(253, 517);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 23;
            btnSave.Text = "Speichern";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnButtonSave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 0, 0, 0);
            panel4.Location = new Point(253, 517);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 43);
            panel4.TabIndex = 24;
            panel4.Click += OnButtonSave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8.25F);
            label2.ForeColor = Color.FromArgb(70, 70, 70);
            label2.Location = new Point(40, 560);
            label2.Name = "label2";
            label2.Size = new Size(86, 13);
            label2.TabIndex = 28;
            label2.Text = "Andere Gründe";
            // 
            // Sgb8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(tbErläuterungen);
            Controls.Add(tbAlter);
            Controls.Add(dropAnmeldung);
            Controls.Add(gridStunden);
            Controls.Add(label1);
            Controls.Add(toggleWartezeit);
            Controls.Add(dropGender);
            Controls.Add(dropHilfe);
            Controls.Add(dropHerkunftHh);
            Controls.Add(dropWirtschaft);
            Controls.Add(dropLeistung);
            Name = "Sgb8";
            Size = new Size(500, 590);
            Load += Sgb8_Load;
            ((System.ComponentModel.ISupportInitialize)gridStunden).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DropDown dropAnmeldung;
        private RJTextBox tbAlter;
        private DropDown dropGender;
        private RJTextBox tbErläuterungen;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
        private Label label2;
    }
}
