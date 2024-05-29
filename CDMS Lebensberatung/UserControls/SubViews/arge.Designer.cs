using CDMS_Lebensberatung.UserControls.CustomControls;

namespace CDMS_Lebensberatung.AddSpecific
{
    partial class ARGE
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
            dropWartezeit = new DropDown();
            dropKomplettAbbruch = new DropDown();
            dropBasisAbbruch = new DropDown();
            dropKomplett = new DropDown();
            dropBelastung = new DropDown();
            dropBasis = new DropDown();
            dropEinsZwei = new DropDown();
            label1 = new Label();
            label2 = new Label();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // dropWartezeit
            // 
            dropWartezeit.BackColor = Color.WhiteSmoke;
            dropWartezeit.BorderColor = Color.SkyBlue;
            dropWartezeit.BorderSize = 1;
            dropWartezeit.DropDownStyle = ComboBoxStyle.DropDownList;
            dropWartezeit.Font = new Font("Segoe UI", 10F);
            dropWartezeit.ForeColor = Color.DimGray;
            dropWartezeit.IconColor = Color.SkyBlue;
            dropWartezeit.ListBackColor = Color.FromArgb(230, 228, 245);
            dropWartezeit.ListTextColor = Color.DimGray;
            dropWartezeit.Location = new Point(260, 343);
            dropWartezeit.Margin = new Padding(10);
            dropWartezeit.MinimumSize = new Size(200, 30);
            dropWartezeit.Name = "dropWartezeit";
            dropWartezeit.Padding = new Padding(1);
            dropWartezeit.Size = new Size(200, 32);
            dropWartezeit.TabIndex = 12;
            dropWartezeit.Texts = "";
            // 
            // dropKomplettAbbruch
            // 
            dropKomplettAbbruch.BackColor = Color.WhiteSmoke;
            dropKomplettAbbruch.BorderColor = Color.SkyBlue;
            dropKomplettAbbruch.BorderSize = 1;
            dropKomplettAbbruch.DropDownStyle = ComboBoxStyle.DropDownList;
            dropKomplettAbbruch.Font = new Font("Segoe UI", 10F);
            dropKomplettAbbruch.ForeColor = Color.DimGray;
            dropKomplettAbbruch.IconColor = Color.SkyBlue;
            dropKomplettAbbruch.ListBackColor = Color.FromArgb(230, 228, 245);
            dropKomplettAbbruch.ListTextColor = Color.DimGray;
            dropKomplettAbbruch.Location = new Point(260, 204);
            dropKomplettAbbruch.Margin = new Padding(10);
            dropKomplettAbbruch.MinimumSize = new Size(200, 30);
            dropKomplettAbbruch.Name = "dropKomplettAbbruch";
            dropKomplettAbbruch.Padding = new Padding(1);
            dropKomplettAbbruch.Size = new Size(200, 32);
            dropKomplettAbbruch.TabIndex = 13;
            dropKomplettAbbruch.Texts = "";
            // 
            // dropBasisAbbruch
            // 
            dropBasisAbbruch.BackColor = Color.WhiteSmoke;
            dropBasisAbbruch.BorderColor = Color.SkyBlue;
            dropBasisAbbruch.BorderSize = 1;
            dropBasisAbbruch.DropDownStyle = ComboBoxStyle.DropDownList;
            dropBasisAbbruch.Font = new Font("Segoe UI", 10F);
            dropBasisAbbruch.ForeColor = Color.DimGray;
            dropBasisAbbruch.IconColor = Color.SkyBlue;
            dropBasisAbbruch.ListBackColor = Color.FromArgb(230, 228, 245);
            dropBasisAbbruch.ListTextColor = Color.DimGray;
            dropBasisAbbruch.Location = new Point(40, 204);
            dropBasisAbbruch.Margin = new Padding(10);
            dropBasisAbbruch.MinimumSize = new Size(200, 30);
            dropBasisAbbruch.Name = "dropBasisAbbruch";
            dropBasisAbbruch.Padding = new Padding(1);
            dropBasisAbbruch.Size = new Size(200, 32);
            dropBasisAbbruch.TabIndex = 14;
            dropBasisAbbruch.Texts = "";
            // 
            // dropKomplett
            // 
            dropKomplett.BackColor = Color.WhiteSmoke;
            dropKomplett.BorderColor = Color.SkyBlue;
            dropKomplett.BorderSize = 1;
            dropKomplett.DropDownStyle = ComboBoxStyle.DropDownList;
            dropKomplett.Font = new Font("Segoe UI", 10F);
            dropKomplett.ForeColor = Color.DimGray;
            dropKomplett.IconColor = Color.SkyBlue;
            dropKomplett.ListBackColor = Color.FromArgb(230, 228, 245);
            dropKomplett.ListTextColor = Color.DimGray;
            dropKomplett.Location = new Point(260, 152);
            dropKomplett.Margin = new Padding(10);
            dropKomplett.MinimumSize = new Size(200, 30);
            dropKomplett.Name = "dropKomplett";
            dropKomplett.Padding = new Padding(1);
            dropKomplett.Size = new Size(200, 32);
            dropKomplett.TabIndex = 15;
            dropKomplett.Texts = "";
            // 
            // dropBelastung
            // 
            dropBelastung.BackColor = Color.WhiteSmoke;
            dropBelastung.BorderColor = Color.SkyBlue;
            dropBelastung.BorderSize = 1;
            dropBelastung.DropDownStyle = ComboBoxStyle.DropDownList;
            dropBelastung.Font = new Font("Segoe UI", 10F);
            dropBelastung.ForeColor = Color.DimGray;
            dropBelastung.IconColor = Color.SkyBlue;
            dropBelastung.ListBackColor = Color.FromArgb(230, 228, 245);
            dropBelastung.ListTextColor = Color.DimGray;
            dropBelastung.Location = new Point(40, 343);
            dropBelastung.Margin = new Padding(10);
            dropBelastung.MinimumSize = new Size(200, 30);
            dropBelastung.Name = "dropBelastung";
            dropBelastung.Padding = new Padding(1);
            dropBelastung.Size = new Size(200, 32);
            dropBelastung.TabIndex = 16;
            dropBelastung.Texts = "";
            // 
            // dropBasis
            // 
            dropBasis.BackColor = Color.WhiteSmoke;
            dropBasis.BorderColor = Color.SkyBlue;
            dropBasis.BorderSize = 1;
            dropBasis.DropDownStyle = ComboBoxStyle.DropDownList;
            dropBasis.Font = new Font("Segoe UI", 10F);
            dropBasis.ForeColor = Color.DimGray;
            dropBasis.IconColor = Color.SkyBlue;
            dropBasis.ListBackColor = Color.FromArgb(230, 228, 245);
            dropBasis.ListTextColor = Color.DimGray;
            dropBasis.Location = new Point(40, 152);
            dropBasis.Margin = new Padding(10);
            dropBasis.MinimumSize = new Size(200, 30);
            dropBasis.Name = "dropBasis";
            dropBasis.Padding = new Padding(1);
            dropBasis.Size = new Size(200, 32);
            dropBasis.TabIndex = 17;
            dropBasis.Texts = "";
            // 
            // dropEinsZwei
            // 
            dropEinsZwei.BackColor = Color.WhiteSmoke;
            dropEinsZwei.BorderColor = Color.SkyBlue;
            dropEinsZwei.BorderSize = 1;
            dropEinsZwei.DropDownStyle = ComboBoxStyle.DropDownList;
            dropEinsZwei.Font = new Font("Segoe UI", 10F);
            dropEinsZwei.ForeColor = Color.DimGray;
            dropEinsZwei.IconColor = Color.SkyBlue;
            dropEinsZwei.ListBackColor = Color.FromArgb(230, 228, 245);
            dropEinsZwei.ListTextColor = Color.DimGray;
            dropEinsZwei.Location = new Point(260, 256);
            dropEinsZwei.Margin = new Padding(10);
            dropEinsZwei.MinimumSize = new Size(200, 30);
            dropEinsZwei.Name = "dropEinsZwei";
            dropEinsZwei.Padding = new Padding(1);
            dropEinsZwei.Size = new Size(200, 32);
            dropEinsZwei.TabIndex = 18;
            dropEinsZwei.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(40, 127);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 20;
            label1.Text = "Basis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(258, 127);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 20;
            label2.Text = "Komplett";
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
            btnSave.Location = new Point(260, 434);
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
            panel4.Location = new Point(260, 434);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 43);
            panel4.TabIndex = 24;
            panel4.Click += OnButtonSave;
            // 
            // ARGE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dropEinsZwei);
            Controls.Add(dropBasis);
            Controls.Add(dropBelastung);
            Controls.Add(dropKomplett);
            Controls.Add(dropBasisAbbruch);
            Controls.Add(dropKomplettAbbruch);
            Controls.Add(dropWartezeit);
            Name = "ARGE";
            Size = new Size(500, 590);
            Load += ARGE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DropDown dropWartezeit;
        private DropDown dropKomplettAbbruch;
        private DropDown dropBasisAbbruch;
        private DropDown dropKomplett;
        private DropDown dropBelastung;
        private DropDown dropBasis;
        private DropDown dropEinsZwei;
        private Label label1;
        private Label label2;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
    }
}
