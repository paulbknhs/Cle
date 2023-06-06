using CDMS_Lebensberatung.UserControls;

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
            this.dropStand = new CDMS_Lebensberatung.UserControls.DropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBeratungszeit = new System.Windows.Forms.NumericUpDown();
            this.dropErwerb = new CDMS_Lebensberatung.UserControls.DropDown();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).BeginInit();
            this.SuspendLayout();
            // 
            // dropStand
            // 
            this.dropStand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropStand.BorderColor = System.Drawing.Color.Black;
            this.dropStand.BorderSize = 1;
            this.dropStand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropStand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropStand.ForeColor = System.Drawing.Color.DimGray;
            this.dropStand.IconColor = System.Drawing.Color.Black;
            this.dropStand.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropStand.ListTextColor = System.Drawing.Color.DimGray;
            this.dropStand.Location = new System.Drawing.Point(40, 100);
            this.dropStand.Margin = new System.Windows.Forms.Padding(10);
            this.dropStand.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStand.Name = "dropStand";
            this.dropStand.Padding = new System.Windows.Forms.Padding(1);
            this.dropStand.Size = new System.Drawing.Size(200, 32);
            this.dropStand.TabIndex = 12;
            this.dropStand.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Beratungszeit in min";
            // 
            // numBeratungszeit
            // 
            this.numBeratungszeit.Increment = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numBeratungszeit.Location = new System.Drawing.Point(40, 169);
            this.numBeratungszeit.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numBeratungszeit.Name = "numBeratungszeit";
            this.numBeratungszeit.Size = new System.Drawing.Size(70, 23);
            this.numBeratungszeit.TabIndex = 14;
            // 
            // dropErwerb
            // 
            this.dropErwerb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropErwerb.BorderColor = System.Drawing.Color.Black;
            this.dropErwerb.BorderSize = 1;
            this.dropErwerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropErwerb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropErwerb.ForeColor = System.Drawing.Color.DimGray;
            this.dropErwerb.IconColor = System.Drawing.Color.Black;
            this.dropErwerb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropErwerb.ListTextColor = System.Drawing.Color.DimGray;
            this.dropErwerb.Location = new System.Drawing.Point(260, 100);
            this.dropErwerb.Margin = new System.Windows.Forms.Padding(10);
            this.dropErwerb.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropErwerb.Name = "dropErwerb";
            this.dropErwerb.Padding = new System.Windows.Forms.Padding(1);
            this.dropErwerb.Size = new System.Drawing.Size(200, 32);
            this.dropErwerb.TabIndex = 12;
            this.dropErwerb.Texts = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundColor = System.Drawing.Color.Green;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(260, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Speichern";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnButtonSave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(260, 235);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 43);
            this.panel4.TabIndex = 24;
            this.panel4.Click += new System.EventHandler(this.OnButtonSave);
            // 
            // P2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBeratungszeit);
            this.Controls.Add(this.dropErwerb);
            this.Controls.Add(this.dropStand);
            this.Name = "P2a";
            this.Size = new System.Drawing.Size(500, 590);
            this.Load += new System.EventHandler(this.P2a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
