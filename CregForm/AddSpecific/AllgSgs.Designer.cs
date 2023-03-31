namespace CregForm.AddSpecific
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
            this.dropErwerb = new CregForm.Controls.DropDown();
            this.dropStand = new CregForm.Controls.DropDown();
            this.dropStaat = new CregForm.Controls.DropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBeratungszeit = new System.Windows.Forms.NumericUpDown();
            this.tbLaufnummer = new CustomControls.RJControls.RJTextBox();
            this.buttonSave = new RJCodeAdvance.RJControls.RJButton();
            this.dropAlter = new CregForm.Controls.DropDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).BeginInit();
            this.SuspendLayout();
                                                this.dropErwerb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropErwerb.BorderColor = System.Drawing.Color.Black;
            this.dropErwerb.BorderSize = 1;
            this.dropErwerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropErwerb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropErwerb.ForeColor = System.Drawing.Color.DimGray;
            this.dropErwerb.IconColor = System.Drawing.Color.Black;
            this.dropErwerb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropErwerb.ListTextColor = System.Drawing.Color.DimGray;
            this.dropErwerb.Location = new System.Drawing.Point(40, 236);
            this.dropErwerb.Margin = new System.Windows.Forms.Padding(10);
            this.dropErwerb.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropErwerb.Name = "dropErwerb";
            this.dropErwerb.Padding = new System.Windows.Forms.Padding(1);
            this.dropErwerb.Size = new System.Drawing.Size(200, 32);
            this.dropErwerb.TabIndex = 9;
            this.dropErwerb.Texts = "";
                                                this.dropStand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropStand.BorderColor = System.Drawing.Color.Black;
            this.dropStand.BorderSize = 1;
            this.dropStand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropStand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropStand.ForeColor = System.Drawing.Color.DimGray;
            this.dropStand.IconColor = System.Drawing.Color.Black;
            this.dropStand.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropStand.ListTextColor = System.Drawing.Color.DimGray;
            this.dropStand.Location = new System.Drawing.Point(260, 184);
            this.dropStand.Margin = new System.Windows.Forms.Padding(10);
            this.dropStand.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStand.Name = "dropStand";
            this.dropStand.Padding = new System.Windows.Forms.Padding(1);
            this.dropStand.Size = new System.Drawing.Size(200, 32);
            this.dropStand.TabIndex = 10;
            this.dropStand.Texts = "";
                                                this.dropStaat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropStaat.BorderColor = System.Drawing.Color.Black;
            this.dropStaat.BorderSize = 1;
            this.dropStaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropStaat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropStaat.ForeColor = System.Drawing.Color.DimGray;
            this.dropStaat.IconColor = System.Drawing.Color.Black;
            this.dropStaat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropStaat.ListTextColor = System.Drawing.Color.DimGray;
            this.dropStaat.Location = new System.Drawing.Point(40, 184);
            this.dropStaat.Margin = new System.Windows.Forms.Padding(10);
            this.dropStaat.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStaat.Name = "dropStaat";
            this.dropStaat.Padding = new System.Windows.Forms.Padding(1);
            this.dropStaat.Size = new System.Drawing.Size(200, 32);
            this.dropStaat.TabIndex = 11;
            this.dropStaat.Texts = "";
                                                this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Beratungszeit in min";
                                                this.numBeratungszeit.Increment = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numBeratungszeit.Location = new System.Drawing.Point(260, 241);
            this.numBeratungszeit.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numBeratungszeit.Name = "numBeratungszeit";
            this.numBeratungszeit.Size = new System.Drawing.Size(70, 23);
            this.numBeratungszeit.TabIndex = 12;
                                                this.tbLaufnummer.BackColor = System.Drawing.SystemColors.Window;
            this.tbLaufnummer.BorderColor = System.Drawing.Color.Black;
            this.tbLaufnummer.BorderFocusColor = System.Drawing.Color.Green;
            this.tbLaufnummer.BorderRadius = 0;
            this.tbLaufnummer.BorderSize = 1;
            this.tbLaufnummer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLaufnummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLaufnummer.Location = new System.Drawing.Point(40, 100);
            this.tbLaufnummer.Margin = new System.Windows.Forms.Padding(10);
            this.tbLaufnummer.Multiline = false;
            this.tbLaufnummer.Name = "tbLaufnummer";
            this.tbLaufnummer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbLaufnummer.PasswordChar = false;
            this.tbLaufnummer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLaufnummer.PlaceholderText = "Laufende Nummer";
            this.tbLaufnummer.Size = new System.Drawing.Size(200, 32);
            this.tbLaufnummer.TabIndex = 14;
            this.tbLaufnummer.Texts = "";
            this.tbLaufnummer.UnderlinedStyle = true;
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
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSave);
                                                this.dropAlter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropAlter.BorderColor = System.Drawing.Color.Black;
            this.dropAlter.BorderSize = 1;
            this.dropAlter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropAlter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropAlter.ForeColor = System.Drawing.Color.DimGray;
            this.dropAlter.IconColor = System.Drawing.Color.Black;
            this.dropAlter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropAlter.ListTextColor = System.Drawing.Color.DimGray;
            this.dropAlter.Location = new System.Drawing.Point(260, 100);
            this.dropAlter.Margin = new System.Windows.Forms.Padding(10);
            this.dropAlter.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropAlter.Name = "dropAlter";
            this.dropAlter.Padding = new System.Windows.Forms.Padding(1);
            this.dropAlter.Size = new System.Drawing.Size(200, 32);
            this.dropAlter.TabIndex = 10;
            this.dropAlter.Texts = "";
                                                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbLaufnummer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBeratungszeit);
            this.Controls.Add(this.dropErwerb);
            this.Controls.Add(this.dropAlter);
            this.Controls.Add(this.dropStand);
            this.Controls.Add(this.dropStaat);
            this.Name = "AllgSgs";
            this.Size = new System.Drawing.Size(500, 590);
            this.Load += new System.EventHandler(this.AllgSgs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DropDown dropErwerb;
        private Controls.DropDown dropStand;
        private Controls.DropDown dropStaat;
        private Label label1;
        private NumericUpDown numBeratungszeit;
        private CustomControls.RJControls.RJTextBox tbLaufnummer;
        private RJCodeAdvance.RJControls.RJButton buttonSave;
        private Controls.DropDown dropAlter;
    }
}
