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
			labelHallo = new Label();
			labelDatum = new Label();
			panelBack = new Panel();
			panelSQL = new Panel();
			label4 = new Label();
			serverState = new Label();
			label1 = new Label();
			panelBack.SuspendLayout();
			panelSQL.SuspendLayout();
			SuspendLayout();
			// 
			// labelHallo
			// 
			labelHallo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			labelHallo.AutoSize = true;
			labelHallo.BackColor = Color.Transparent;
			labelHallo.Font = new Font("Segoe UI", 32F);
			labelHallo.ForeColor = Color.FromArgb(35, 78, 84);
			labelHallo.Location = new Point(37, 39);
			labelHallo.Margin = new Padding(0);
			labelHallo.Name = "labelHallo";
			labelHallo.Size = new Size(135, 59);
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
			labelDatum.ForeColor = Color.DimGray;
			labelDatum.Location = new Point(45, 9);
			labelDatum.Margin = new Padding(0);
			labelDatum.Name = "labelDatum";
			labelDatum.Size = new Size(87, 30);
			labelDatum.TabIndex = 17;
			labelDatum.Text = "Datum?";
			labelDatum.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelBack
			// 
			panelBack.BackColor = Color.FromArgb(160, 255, 255, 255);
			panelBack.Controls.Add(panelSQL);
			panelBack.Controls.Add(label1);
			panelBack.Location = new Point(41, 103);
			panelBack.Margin = new Padding(0);
			panelBack.Name = "panelBack";
			panelBack.Size = new Size(974, 567);
			panelBack.TabIndex = 23;
			// 
			// panelSQL
			// 
			panelSQL.Controls.Add(label4);
			panelSQL.Controls.Add(serverState);
			panelSQL.Location = new Point(41, 500);
			panelSQL.Name = "panelSQL";
			panelSQL.Size = new Size(195, 49);
			panelSQL.TabIndex = 29;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 13F);
			label4.Location = new Point(12, 11);
			label4.Name = "label4";
			label4.Size = new Size(64, 25);
			label4.TabIndex = 32;
			label4.Text = "Status:";
			// 
			// serverState
			// 
			serverState.AutoSize = true;
			serverState.BackColor = Color.Transparent;
			serverState.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			serverState.ForeColor = Color.FromArgb(35, 78, 84);
			serverState.Location = new Point(82, 11);
			serverState.Name = "serverState";
			serverState.Size = new Size(94, 25);
			serverState.TabIndex = 31;
			serverState.Text = "Gestoppt";
			serverState.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 11F);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(41, 45);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(341, 20);
			label1.TabIndex = 4;
			label1.Text = "Bitte gehen Sie weiter, hier gibt es nichts zu sehen.";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FrameHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 255, 255, 255);
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(labelDatum);
			Controls.Add(labelHallo);
			Controls.Add(panelBack);
			Name = "FrameHome";
			Size = new Size(1076, 686);
			Load += OnFrameLoad;
			panelBack.ResumeLayout(false);
			panelBack.PerformLayout();
			panelSQL.ResumeLayout(false);
			panelSQL.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label labelHallo;
        private Label labelDatum;
        private Panel panelBack;
        private Label label1;
        private Panel panelSQL;
        private Label label4;
        private Label serverState;
    }
}
