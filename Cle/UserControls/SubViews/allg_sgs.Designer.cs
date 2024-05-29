using Cle.UserControls.CustomControls;

namespace Cle.UserControls.SubViews
{
    partial class AllgSgs
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
            dropErwerb = new DropDown();
            dropStand = new DropDown();
            dropStaat = new DropDown();
            label1 = new Label();
            numBeratungszeit = new NumericUpDown();
            tbNr = new RJTextBox();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            panel4 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).BeginInit();
            SuspendLayout();
            // 
            // dropErwerb
            // 
            dropErwerb.BackColor = Color.WhiteSmoke;
            dropErwerb.BorderColor = Color.SkyBlue;
            dropErwerb.BorderSize = 1;
            dropErwerb.DropDownStyle = ComboBoxStyle.DropDownList;
            dropErwerb.Font = new Font("Segoe UI", 10F);
            dropErwerb.ForeColor = Color.DimGray;
            dropErwerb.IconColor = Color.SkyBlue;
            dropErwerb.ListBackColor = Color.FromArgb(230, 228, 245);
            dropErwerb.ListTextColor = Color.DimGray;
            dropErwerb.Location = new Point(40, 236);
            dropErwerb.Margin = new Padding(10);
            dropErwerb.MinimumSize = new Size(200, 30);
            dropErwerb.Name = "dropErwerb";
            dropErwerb.Padding = new Padding(1);
            dropErwerb.Size = new Size(200, 32);
            dropErwerb.TabIndex = 9;
            dropErwerb.Texts = "";
            // 
            // dropStand
            // 
            dropStand.BackColor = Color.WhiteSmoke;
            dropStand.BorderColor = Color.SkyBlue;
            dropStand.BorderSize = 1;
            dropStand.DropDownStyle = ComboBoxStyle.DropDownList;
            dropStand.Font = new Font("Segoe UI", 10F);
            dropStand.ForeColor = Color.DimGray;
            dropStand.IconColor = Color.SkyBlue;
            dropStand.ListBackColor = Color.FromArgb(230, 228, 245);
            dropStand.ListTextColor = Color.DimGray;
            dropStand.Location = new Point(260, 184);
            dropStand.Margin = new Padding(10);
            dropStand.MinimumSize = new Size(200, 30);
            dropStand.Name = "dropStand";
            dropStand.Padding = new Padding(1);
            dropStand.Size = new Size(200, 32);
            dropStand.TabIndex = 10;
            dropStand.Texts = "";
            // 
            // dropStaat
            // 
            dropStaat.BackColor = Color.WhiteSmoke;
            dropStaat.BorderColor = Color.SkyBlue;
            dropStaat.BorderSize = 1;
            dropStaat.DropDownStyle = ComboBoxStyle.DropDownList;
            dropStaat.Font = new Font("Segoe UI", 10F);
            dropStaat.ForeColor = Color.DimGray;
            dropStaat.IconColor = Color.SkyBlue;
            dropStaat.ListBackColor = Color.FromArgb(230, 228, 245);
            dropStaat.ListTextColor = Color.DimGray;
            dropStaat.Location = new Point(40, 184);
            dropStaat.Margin = new Padding(10);
            dropStaat.MinimumSize = new Size(200, 30);
            dropStaat.Name = "dropStaat";
            dropStaat.Padding = new Padding(1);
            dropStaat.Size = new Size(200, 32);
            dropStaat.TabIndex = 11;
            dropStaat.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 238);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 13;
            label1.Text = "Beratungszeit in min";
            // 
            // numBeratungszeit
            // 
            numBeratungszeit.Increment = new decimal(new int[] { 45, 0, 0, 0 });
            numBeratungszeit.Location = new Point(260, 238);
            numBeratungszeit.Maximum = new decimal(new int[] { 270, 0, 0, 0 });
            numBeratungszeit.Name = "numBeratungszeit";
            numBeratungszeit.Size = new Size(70, 23);
            numBeratungszeit.TabIndex = 12;
            // 
            // tbNr
            // 
            tbNr.BackColor = SystemColors.Window;
            tbNr.BorderColor = Color.Black;
            tbNr.BorderFocusColor = Color.SkyBlue;
            tbNr.BorderRadius = 0;
            tbNr.BorderSize = 1;
            tbNr.Font = new Font("Segoe UI", 9.75F);
            tbNr.ForeColor = Color.FromArgb(64, 64, 64);
            tbNr.Location = new Point(40, 110);
            tbNr.Margin = new Padding(10);
            tbNr.Multiline = false;
            tbNr.Name = "tbNr";
            tbNr.Padding = new Padding(10, 7, 10, 7);
            tbNr.PasswordChar = false;
            tbNr.PlaceholderColor = Color.DarkGray;
            tbNr.PlaceholderText = "Laufende Nummer";
            tbNr.Size = new Size(200, 32);
            tbNr.TabIndex = 14;
            tbNr.Texts = "";
            tbNr.UnderlinedStyle = true;
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
            btnSave.Location = new Point(260, 281);
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
            panel4.Location = new Point(260, 281);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 43);
            panel4.TabIndex = 24;
            panel4.Click += OnButtonSave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F);
            label4.ForeColor = Color.FromArgb(70, 70, 70);
            label4.Location = new Point(40, 144);
            label4.Name = "label4";
            label4.Size = new Size(101, 13);
            label4.TabIndex = 25;
            label4.Text = "Laufende Nummer";
            // 
            // AllgSgs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(tbNr);
            Controls.Add(label1);
            Controls.Add(numBeratungszeit);
            Controls.Add(dropErwerb);
            Controls.Add(dropStand);
            Controls.Add(dropStaat);
            Name = "AllgSgs";
            Size = new Size(500, 590);
            Load += AllgSgs_Load;
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DropDown dropErwerb;
        private DropDown dropStand;
        private DropDown dropStaat;
        private Label label1;
        private NumericUpDown numBeratungszeit;
        private RJTextBox tbNr;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
        private Label label4;
    }
}
