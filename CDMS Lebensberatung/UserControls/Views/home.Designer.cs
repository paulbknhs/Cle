namespace CDMS_Lebensberatung.UserControls
{
    partial class home
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
            labelHallo = new Label();
            labelDatum = new Label();
            SuspendLayout();
            // 
            // labelHallo
            // 
            labelHallo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelHallo.AutoSize = true;
            labelHallo.BackColor = Color.Transparent;
            labelHallo.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHallo.ForeColor = Color.Black;
            labelHallo.Location = new Point(41, 43);
            labelHallo.Margin = new Padding(0);
            labelHallo.Name = "labelHallo";
            labelHallo.Size = new Size(145, 59);
            labelHallo.TabIndex = 4;
            labelHallo.Text = "Hallo!";
            labelHallo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDatum
            // 
            labelDatum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDatum.AutoSize = true;
            labelDatum.BackColor = Color.Transparent;
            labelDatum.Font = new Font("Segoe UI", 16F);
            labelDatum.ForeColor = Color.Black;
            labelDatum.Location = new Point(45, 13);
            labelDatum.Margin = new Padding(0);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(87, 30);
            labelDatum.TabIndex = 17;
            labelDatum.Text = "Datum?";
            labelDatum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(labelDatum);
            Controls.Add(labelHallo);
            Name = "home";
            Size = new Size(1080, 690);
            Load += OnFrameLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelHallo;
        private Label labelDatum;
    }
}
