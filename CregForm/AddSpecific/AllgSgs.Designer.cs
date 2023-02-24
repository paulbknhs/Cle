namespace CregForm.AddSpecific
{
    partial class AllgSgs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropErwerb = new CregForm.Controls.DropDown();
            this.dropStand = new CregForm.Controls.DropDown();
            this.dropStaat = new CregForm.Controls.DropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBeratungszeit = new System.Windows.Forms.NumericUpDown();
            this.tbLfdNummer = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).BeginInit();
            this.SuspendLayout();
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
            this.dropErwerb.Location = new System.Drawing.Point(40, 236);
            this.dropErwerb.Margin = new System.Windows.Forms.Padding(10);
            this.dropErwerb.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropErwerb.Name = "dropErwerb";
            this.dropErwerb.Padding = new System.Windows.Forms.Padding(1);
            this.dropErwerb.Size = new System.Drawing.Size(200, 32);
            this.dropErwerb.TabIndex = 9;
            this.dropErwerb.Texts = "";
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
            this.dropStand.Location = new System.Drawing.Point(260, 184);
            this.dropStand.Margin = new System.Windows.Forms.Padding(10);
            this.dropStand.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStand.Name = "dropStand";
            this.dropStand.Padding = new System.Windows.Forms.Padding(1);
            this.dropStand.Size = new System.Drawing.Size(200, 32);
            this.dropStand.TabIndex = 10;
            this.dropStand.Texts = "";
            // 
            // dropStaat
            // 
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Beratungszeit in min";
            // 
            // numBeratungszeit
            // 
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
            // 
            // tbLfdNummer
            // 
            this.tbLfdNummer.BackColor = System.Drawing.SystemColors.Window;
            this.tbLfdNummer.BorderColor = System.Drawing.Color.Black;
            this.tbLfdNummer.BorderFocusColor = System.Drawing.Color.Green;
            this.tbLfdNummer.BorderRadius = 0;
            this.tbLfdNummer.BorderSize = 1;
            this.tbLfdNummer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLfdNummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLfdNummer.Location = new System.Drawing.Point(40, 100);
            this.tbLfdNummer.Margin = new System.Windows.Forms.Padding(10);
            this.tbLfdNummer.Multiline = false;
            this.tbLfdNummer.Name = "tbLfdNummer";
            this.tbLfdNummer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbLfdNummer.PasswordChar = false;
            this.tbLfdNummer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLfdNummer.PlaceholderText = "Laufende Nummer";
            this.tbLfdNummer.Size = new System.Drawing.Size(200, 32);
            this.tbLfdNummer.TabIndex = 14;
            this.tbLfdNummer.Texts = "";
            this.tbLfdNummer.UnderlinedStyle = true;
            // 
            // AllgSgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLfdNummer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBeratungszeit);
            this.Controls.Add(this.dropErwerb);
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
        private CustomControls.RJControls.RJTextBox tbLfdNummer;
    }
}
