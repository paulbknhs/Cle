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
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelSQL = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.serverState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            this.panelSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 5);
            this.panel5.TabIndex = 16;
            // 
            // labelHallo
            // 
            this.labelHallo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHallo.AutoSize = true;
            this.labelHallo.BackColor = System.Drawing.Color.Transparent;
            this.labelHallo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHallo.ForeColor = System.Drawing.Color.Green;
            this.labelHallo.Location = new System.Drawing.Point(41, 43);
            this.labelHallo.Margin = new System.Windows.Forms.Padding(0);
            this.labelHallo.Name = "labelHallo";
            this.labelHallo.Size = new System.Drawing.Size(135, 59);
            this.labelHallo.TabIndex = 4;
            this.labelHallo.Text = "Hallo!";
            this.labelHallo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDatum
            // 
            this.labelDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.Color.Transparent;
            this.labelDatum.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatum.ForeColor = System.Drawing.Color.DimGray;
            this.labelDatum.Location = new System.Drawing.Point(45, 13);
            this.labelDatum.Margin = new System.Windows.Forms.Padding(0);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(87, 30);
            this.labelDatum.TabIndex = 17;
            this.labelDatum.Text = "Datum?";
            this.labelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 690);
            this.panel1.TabIndex = 18;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBack.Controls.Add(this.panelSQL);
            this.panelBack.Controls.Add(this.label1);
            this.panelBack.Location = new System.Drawing.Point(41, 103);
            this.panelBack.Margin = new System.Windows.Forms.Padding(0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(974, 567);
            this.panelBack.TabIndex = 23;
            // 
            // panelSQL
            // 
            this.panelSQL.Controls.Add(this.label4);
            this.panelSQL.Controls.Add(this.serverState);
            this.panelSQL.Location = new System.Drawing.Point(41, 500);
            this.panelSQL.Name = "panelSQL";
            this.panelSQL.Size = new System.Drawing.Size(195, 49);
            this.panelSQL.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Status:";
            // 
            // serverState
            // 
            this.serverState.AutoSize = true;
            this.serverState.BackColor = System.Drawing.Color.Transparent;
            this.serverState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serverState.ForeColor = System.Drawing.Color.IndianRed;
            this.serverState.Location = new System.Drawing.Point(82, 11);
            this.serverState.Name = "serverState";
            this.serverState.Size = new System.Drawing.Size(94, 25);
            this.serverState.TabIndex = 31;
            this.serverState.Text = "Gestoppt";
            this.serverState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bitte gehen Sie weiter, hier gibt es nichts zu sehen.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.panelBack);
            this.Name = "FrameHome";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Load += new System.EventHandler(this.OnFrameLoad);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelSQL.ResumeLayout(false);
            this.panelSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel5;
        private Label labelHallo;
        private Label labelDatum;
        private Panel panel1;
        private Panel panelBack;
        private Label label1;
        private Panel panelSQL;
        private Label label4;
        private Label serverState;
    }
}
