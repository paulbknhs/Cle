using CDMS_Lebensberatung.UserControls.CustomControls;

namespace CDMS_Lebensberatung.AddSpecific
{
    partial class P2a
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
            dropStand = new DropDown();
            label1 = new Label();
            numBeratungszeit = new NumericUpDown();
            dropErwerb = new DropDown();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).BeginInit();
            SuspendLayout();
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
            dropStand.Location = new Point(40, 100);
            dropStand.Margin = new Padding(10);
            dropStand.MinimumSize = new Size(200, 30);
            dropStand.Name = "dropStand";
            dropStand.Padding = new Padding(1);
            dropStand.Size = new Size(200, 32);
            dropStand.TabIndex = 12;
            dropStand.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 171);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 15;
            label1.Text = "Beratungszeit in min";
            // 
            // numBeratungszeit
            // 
            numBeratungszeit.Increment = new decimal(new int[] { 45, 0, 0, 0 });
            numBeratungszeit.Location = new Point(40, 169);
            numBeratungszeit.Maximum = new decimal(new int[] { 270, 0, 0, 0 });
            numBeratungszeit.Name = "numBeratungszeit";
            numBeratungszeit.Size = new Size(70, 23);
            numBeratungszeit.TabIndex = 14;
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
            dropErwerb.Location = new Point(260, 100);
            dropErwerb.Margin = new Padding(10);
            dropErwerb.MinimumSize = new Size(200, 30);
            dropErwerb.Name = "dropErwerb";
            dropErwerb.Padding = new Padding(1);
            dropErwerb.Size = new Size(200, 32);
            dropErwerb.TabIndex = 12;
            dropErwerb.Texts = "";
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
            btnSave.Location = new Point(260, 235);
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
            panel4.Location = new Point(260, 235);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 43);
            panel4.TabIndex = 24;
            panel4.Click += OnButtonSave;
            // 
            // P2a
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(numBeratungszeit);
            Controls.Add(dropErwerb);
            Controls.Add(dropStand);
            Name = "P2a";
            Size = new Size(500, 590);
            Load += P2a_Load;
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DropDown dropStand;
        private Label label1;
        private NumericUpDown numBeratungszeit;
        private DropDown dropErwerb;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
    }
}
