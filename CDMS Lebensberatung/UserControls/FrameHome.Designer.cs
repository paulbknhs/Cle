namespace CDMS_Lebensberatung.UserControls
{
    partial class FrameHome
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelHallo = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 8);
            this.panel5.TabIndex = 16;
            // 
            // labelHallo
            // 
            this.labelHallo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHallo.BackColor = System.Drawing.Color.Transparent;
            this.labelHallo.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHallo.Location = new System.Drawing.Point(0, 134);
            this.labelHallo.Margin = new System.Windows.Forms.Padding(0);
            this.labelHallo.Name = "labelHallo";
            this.labelHallo.Size = new System.Drawing.Size(1080, 117);
            this.labelHallo.TabIndex = 4;
            this.labelHallo.Text = "Hallo!";
            this.labelHallo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDatum
            // 
            this.labelDatum.BackColor = System.Drawing.Color.Transparent;
            this.labelDatum.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatum.Location = new System.Drawing.Point(0, 430);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(1080, 78);
            this.labelDatum.TabIndex = 17;
            this.labelDatum.Text = "Wochentag, der DD.MM.YYYY";
            this.labelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 690);
            this.panel1.TabIndex = 18;
            // 
            // FrameHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelHallo);
            this.Controls.Add(this.panel5);
            this.Name = "FrameHome";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Load += new System.EventHandler(this.OnFrameLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel5;
        private Label labelHallo;
        private Label labelDatum;
        private Panel panel1;
    }
}
