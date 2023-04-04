using CDMS_Lebensberatung.UserControls;

namespace CDMS_Lebensberatung.AddSpecific
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
            this.dropStaat = new DropDown();
            this.dropAntrag = new DropDown();
            this.dropKommu = new DropDown();
            this.dropStand = new DropDown();
            this.dropErwerb = new DropDown();
            this.numBeratungszeit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).BeginInit();
            this.SuspendLayout();
                                                this.dropStaat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropStaat.BorderColor = System.Drawing.Color.Black;
            this.dropStaat.BorderSize = 1;
            this.dropStaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropStaat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropStaat.ForeColor = System.Drawing.Color.DimGray;
            this.dropStaat.IconColor = System.Drawing.Color.Black;
            this.dropStaat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropStaat.ListTextColor = System.Drawing.Color.DimGray;
            this.dropStaat.Location = new System.Drawing.Point(40, 100);
            this.dropStaat.Margin = new System.Windows.Forms.Padding(10);
            this.dropStaat.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStaat.Name = "dropStaat";
            this.dropStaat.Padding = new System.Windows.Forms.Padding(1);
            this.dropStaat.Size = new System.Drawing.Size(200, 32);
            this.dropStaat.TabIndex = 8;
            this.dropStaat.Texts = "";
                                                this.dropAntrag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropAntrag.BorderColor = System.Drawing.Color.Black;
            this.dropAntrag.BorderSize = 1;
            this.dropAntrag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropAntrag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropAntrag.ForeColor = System.Drawing.Color.DimGray;
            this.dropAntrag.IconColor = System.Drawing.Color.Black;
            this.dropAntrag.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropAntrag.ListTextColor = System.Drawing.Color.DimGray;
            this.dropAntrag.Location = new System.Drawing.Point(40, 152);
            this.dropAntrag.Margin = new System.Windows.Forms.Padding(10);
            this.dropAntrag.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropAntrag.Name = "dropAntrag";
            this.dropAntrag.Padding = new System.Windows.Forms.Padding(1);
            this.dropAntrag.Size = new System.Drawing.Size(200, 32);
            this.dropAntrag.TabIndex = 8;
            this.dropAntrag.Texts = "";
                                                this.dropKommu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropKommu.BorderColor = System.Drawing.Color.Black;
            this.dropKommu.BorderSize = 1;
            this.dropKommu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropKommu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropKommu.ForeColor = System.Drawing.Color.DimGray;
            this.dropKommu.IconColor = System.Drawing.Color.Black;
            this.dropKommu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropKommu.ListTextColor = System.Drawing.Color.DimGray;
            this.dropKommu.Location = new System.Drawing.Point(260, 100);
            this.dropKommu.Margin = new System.Windows.Forms.Padding(10);
            this.dropKommu.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropKommu.Name = "dropKommu";
            this.dropKommu.Padding = new System.Windows.Forms.Padding(1);
            this.dropKommu.Size = new System.Drawing.Size(200, 32);
            this.dropKommu.TabIndex = 8;
            this.dropKommu.Texts = "";
                                                this.dropStand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropStand.BorderColor = System.Drawing.Color.Black;
            this.dropStand.BorderSize = 1;
            this.dropStand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropStand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropStand.ForeColor = System.Drawing.Color.DimGray;
            this.dropStand.IconColor = System.Drawing.Color.Black;
            this.dropStand.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropStand.ListTextColor = System.Drawing.Color.DimGray;
            this.dropStand.Location = new System.Drawing.Point(260, 152);
            this.dropStand.Margin = new System.Windows.Forms.Padding(10);
            this.dropStand.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStand.Name = "dropStand";
            this.dropStand.Padding = new System.Windows.Forms.Padding(1);
            this.dropStand.Size = new System.Drawing.Size(200, 32);
            this.dropStand.TabIndex = 8;
            this.dropStand.Texts = "";
                                                this.dropErwerb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropErwerb.BorderColor = System.Drawing.Color.Black;
            this.dropErwerb.BorderSize = 1;
            this.dropErwerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropErwerb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropErwerb.ForeColor = System.Drawing.Color.DimGray;
            this.dropErwerb.IconColor = System.Drawing.Color.Black;
            this.dropErwerb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropErwerb.ListTextColor = System.Drawing.Color.DimGray;
            this.dropErwerb.Location = new System.Drawing.Point(40, 204);
            this.dropErwerb.Margin = new System.Windows.Forms.Padding(10);
            this.dropErwerb.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropErwerb.Name = "dropErwerb";
            this.dropErwerb.Padding = new System.Windows.Forms.Padding(1);
            this.dropErwerb.Size = new System.Drawing.Size(200, 32);
            this.dropErwerb.TabIndex = 8;
            this.dropErwerb.Texts = "";
                                                this.numBeratungszeit.Increment = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numBeratungszeit.Location = new System.Drawing.Point(260, 209);
            this.numBeratungszeit.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numBeratungszeit.Name = "numBeratungszeit";
            this.numBeratungszeit.Size = new System.Drawing.Size(70, 23);
            this.numBeratungszeit.TabIndex = 9;
                                                this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Beratungszeit in min";
                                                this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.BackgroundColor = System.Drawing.Color.White;
            this.buttonSave.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.BorderRadius = 0;
            this.buttonSave.BorderSize = 1;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(258, 541);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 40);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSave);
                                                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBeratungszeit);
            this.Controls.Add(this.dropErwerb);
            this.Controls.Add(this.dropStand);
            this.Controls.Add(this.dropKommu);
            this.Controls.Add(this.dropAntrag);
            this.Controls.Add(this.dropStaat);
            this.Name = "MutterKind";
            this.Size = new System.Drawing.Size(500, 590);
            this.Load += new System.EventHandler(this.MutterKind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DropDown dropStaat;
        private DropDown dropAntrag;
        private DropDown dropKommu;
        private DropDown dropStand;
        private DropDown dropErwerb;
        private NumericUpDown numBeratungszeit;
        private Label label1;
        private RJCodeAdvance.RJControls.RJButton buttonSave;
    }
}
