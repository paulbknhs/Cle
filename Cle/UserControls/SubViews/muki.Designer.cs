using Cle.UserControls.CustomControls;

namespace Cle.UserControls.SubViews
{
    partial class MutterKind
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
            dropStaat = new DropDown();
            dropAntrag = new DropDown();
            dropKommu = new DropDown();
            dropStand = new DropDown();
            dropErwerb = new DropDown();
            numBeratungszeit = new NumericUpDown();
            label1 = new Label();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).BeginInit();
            SuspendLayout();
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
            dropStaat.Location = new Point(40, 100);
            dropStaat.Margin = new Padding(10);
            dropStaat.MinimumSize = new Size(200, 30);
            dropStaat.Name = "dropStaat";
            dropStaat.Padding = new Padding(1);
            dropStaat.Size = new Size(200, 32);
            dropStaat.TabIndex = 8;
            dropStaat.Texts = "";
            // 
            // dropAntrag
            // 
            dropAntrag.BackColor = Color.WhiteSmoke;
            dropAntrag.BorderColor = Color.SkyBlue;
            dropAntrag.BorderSize = 1;
            dropAntrag.DropDownStyle = ComboBoxStyle.DropDownList;
            dropAntrag.Font = new Font("Segoe UI", 10F);
            dropAntrag.ForeColor = Color.DimGray;
            dropAntrag.IconColor = Color.SkyBlue;
            dropAntrag.ListBackColor = Color.FromArgb(230, 228, 245);
            dropAntrag.ListTextColor = Color.DimGray;
            dropAntrag.Location = new Point(40, 152);
            dropAntrag.Margin = new Padding(10);
            dropAntrag.MinimumSize = new Size(200, 30);
            dropAntrag.Name = "dropAntrag";
            dropAntrag.Padding = new Padding(1);
            dropAntrag.Size = new Size(200, 32);
            dropAntrag.TabIndex = 8;
            dropAntrag.Texts = "";
            // 
            // dropKommu
            // 
            dropKommu.BackColor = Color.WhiteSmoke;
            dropKommu.BorderColor = Color.SkyBlue;
            dropKommu.BorderSize = 1;
            dropKommu.DropDownStyle = ComboBoxStyle.DropDownList;
            dropKommu.Font = new Font("Segoe UI", 10F);
            dropKommu.ForeColor = Color.DimGray;
            dropKommu.IconColor = Color.SkyBlue;
            dropKommu.ListBackColor = Color.FromArgb(230, 228, 245);
            dropKommu.ListTextColor = Color.DimGray;
            dropKommu.Location = new Point(260, 100);
            dropKommu.Margin = new Padding(10);
            dropKommu.MinimumSize = new Size(200, 30);
            dropKommu.Name = "dropKommu";
            dropKommu.Padding = new Padding(1);
            dropKommu.Size = new Size(200, 32);
            dropKommu.TabIndex = 8;
            dropKommu.Texts = "";
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
            dropStand.Location = new Point(260, 152);
            dropStand.Margin = new Padding(10);
            dropStand.MinimumSize = new Size(200, 30);
            dropStand.Name = "dropStand";
            dropStand.Padding = new Padding(1);
            dropStand.Size = new Size(200, 32);
            dropStand.TabIndex = 8;
            dropStand.Texts = "";
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
            dropErwerb.Location = new Point(40, 204);
            dropErwerb.Margin = new Padding(10);
            dropErwerb.MinimumSize = new Size(200, 30);
            dropErwerb.Name = "dropErwerb";
            dropErwerb.Padding = new Padding(1);
            dropErwerb.Size = new Size(200, 32);
            dropErwerb.TabIndex = 8;
            dropErwerb.Texts = "";
            // 
            // numBeratungszeit
            // 
            numBeratungszeit.Increment = new decimal(new int[] { 45, 0, 0, 0 });
            numBeratungszeit.Location = new Point(260, 211);
            numBeratungszeit.Maximum = new decimal(new int[] { 270, 0, 0, 0 });
            numBeratungszeit.Name = "numBeratungszeit";
            numBeratungszeit.Size = new Size(70, 23);
            numBeratungszeit.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 213);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 10;
            label1.Text = "Beratungszeit in min";
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
            btnSave.Location = new Point(260, 303);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(197, 40);
            btnSave.TabIndex = 23;
            btnSave.Text = "Speichern";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnButtonSave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 0, 0, 0);
            panel4.Location = new Point(260, 303);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 43);
            panel4.TabIndex = 24;
            panel4.Click += OnButtonSave;
            // 
            // MutterKind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(numBeratungszeit);
            Controls.Add(dropErwerb);
            Controls.Add(dropStand);
            Controls.Add(dropKommu);
            Controls.Add(dropAntrag);
            Controls.Add(dropStaat);
            Name = "MutterKind";
            Size = new Size(500, 590);
            Load += MutterKind_Load;
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DropDown dropStaat;
        private DropDown dropAntrag;
        private DropDown dropKommu;
        private DropDown dropStand;
        private DropDown dropErwerb;
        private NumericUpDown numBeratungszeit;
        private Label label1;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
    }
}
