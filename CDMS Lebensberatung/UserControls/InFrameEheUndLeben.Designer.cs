using CDMS_Lebensberatung.UserControls;

namespace CDMS_Lebensberatung.AddSpecific
{
    partial class EheUndLeben
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			dropLeistung = new DropDown();
			dropWirtschaft = new DropDown();
			groupAnmeldung = new GroupBox();
			cbAndere = new CheckBox();
			cbStraft = new CheckBox();
			cbFamilie = new CheckBox();
			cbPartn = new CheckBox();
			cbGeld = new CheckBox();
			cbMisshand = new CheckBox();
			cbKörpBehind = new CheckBox();
			cbSucht = new CheckBox();
			cbPsychosen = new CheckBox();
			cbSexuell = new CheckBox();
			cbSuizid = new CheckBox();
			cbTrennung = new CheckBox();
			cbPsychisch = new CheckBox();
			chKrankTod = new CheckBox();
			cbKörper = new CheckBox();
			tbErläuterung = new RJTextBox();
			togglePartnerschaft = new RJCodeAdvance.RJControls.RJToggleButton();
			toggleKinder = new RJCodeAdvance.RJControls.RJToggleButton();
			label1 = new Label();
			label2 = new Label();
			toggleSonstige = new RJCodeAdvance.RJControls.RJToggleButton();
			label3 = new Label();
			toggleUnbekannt = new RJCodeAdvance.RJControls.RJToggleButton();
			label4 = new Label();
			gridStunden = new DataGridView();
			Art = new DataGridViewTextBoxColumn();
			Stunden = new DataGridViewTextBoxColumn();
			btnSave = new RJCodeAdvance.RJControls.RJButton();
			panel4 = new Panel();
			label5 = new Label();
			groupAnmeldung.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridStunden).BeginInit();
			SuspendLayout();
			// 
			// dropLeistung
			// 
			dropLeistung.BackColor = Color.WhiteSmoke;
			dropLeistung.BorderColor = Color.Black;
			dropLeistung.BorderSize = 1;
			dropLeistung.DropDownStyle = ComboBoxStyle.DropDownList;
			dropLeistung.Font = new Font("Segoe UI", 10F);
			dropLeistung.ForeColor = Color.DimGray;
			dropLeistung.IconColor = Color.Black;
			dropLeistung.ListBackColor = Color.FromArgb(230, 228, 245);
			dropLeistung.ListTextColor = Color.DimGray;
			dropLeistung.Location = new Point(38, 85);
			dropLeistung.Margin = new Padding(10);
			dropLeistung.MinimumSize = new Size(200, 30);
			dropLeistung.Name = "dropLeistung";
			dropLeistung.Padding = new Padding(1);
			dropLeistung.Size = new Size(200, 32);
			dropLeistung.TabIndex = 3;
			dropLeistung.Texts = "";
			// 
			// dropWirtschaft
			// 
			dropWirtschaft.BackColor = Color.WhiteSmoke;
			dropWirtschaft.BorderColor = Color.Black;
			dropWirtschaft.BorderSize = 1;
			dropWirtschaft.DropDownStyle = ComboBoxStyle.DropDownList;
			dropWirtschaft.Font = new Font("Segoe UI", 8F);
			dropWirtschaft.ForeColor = Color.DimGray;
			dropWirtschaft.IconColor = Color.Black;
			dropWirtschaft.ListBackColor = Color.FromArgb(230, 228, 245);
			dropWirtschaft.ListTextColor = Color.DimGray;
			dropWirtschaft.Location = new Point(258, 85);
			dropWirtschaft.Margin = new Padding(10);
			dropWirtschaft.MinimumSize = new Size(200, 30);
			dropWirtschaft.Name = "dropWirtschaft";
			dropWirtschaft.Padding = new Padding(1);
			dropWirtschaft.Size = new Size(200, 32);
			dropWirtschaft.TabIndex = 3;
			dropWirtschaft.Texts = "";
			// 
			// groupAnmeldung
			// 
			groupAnmeldung.Controls.Add(cbAndere);
			groupAnmeldung.Controls.Add(cbStraft);
			groupAnmeldung.Controls.Add(cbFamilie);
			groupAnmeldung.Controls.Add(cbPartn);
			groupAnmeldung.Controls.Add(cbGeld);
			groupAnmeldung.Controls.Add(cbMisshand);
			groupAnmeldung.Controls.Add(cbKörpBehind);
			groupAnmeldung.Controls.Add(cbSucht);
			groupAnmeldung.Controls.Add(cbPsychosen);
			groupAnmeldung.Controls.Add(cbSexuell);
			groupAnmeldung.Controls.Add(cbSuizid);
			groupAnmeldung.Controls.Add(cbTrennung);
			groupAnmeldung.Controls.Add(cbPsychisch);
			groupAnmeldung.Controls.Add(chKrankTod);
			groupAnmeldung.Controls.Add(cbKörper);
			groupAnmeldung.Location = new Point(38, 130);
			groupAnmeldung.Name = "groupAnmeldung";
			groupAnmeldung.Padding = new Padding(5);
			groupAnmeldung.Size = new Size(200, 383);
			groupAnmeldung.TabIndex = 4;
			groupAnmeldung.TabStop = false;
			groupAnmeldung.Text = "Anmeldegründe";
			// 
			// cbAndere
			// 
			cbAndere.AutoSize = true;
			cbAndere.Location = new Point(8, 356);
			cbAndere.Name = "cbAndere";
			cbAndere.Size = new Size(118, 19);
			cbAndere.TabIndex = 0;
			cbAndere.Text = "Andere Probleme";
			cbAndere.UseVisualStyleBackColor = true;
			// 
			// cbStraft
			// 
			cbStraft.AutoSize = true;
			cbStraft.Location = new Point(8, 331);
			cbStraft.Name = "cbStraft";
			cbStraft.Size = new Size(77, 19);
			cbStraft.TabIndex = 0;
			cbStraft.Text = "Straftaten";
			cbStraft.UseVisualStyleBackColor = true;
			// 
			// cbFamilie
			// 
			cbFamilie.AutoSize = true;
			cbFamilie.Location = new Point(8, 306);
			cbFamilie.Name = "cbFamilie";
			cbFamilie.Size = new Size(128, 19);
			cbFamilie.TabIndex = 0;
			cbFamilie.Text = "Familiäre Probleme";
			cbFamilie.UseVisualStyleBackColor = true;
			// 
			// cbPartn
			// 
			cbPartn.AutoSize = true;
			cbPartn.Location = new Point(8, 281);
			cbPartn.Name = "cbPartn";
			cbPartn.Size = new Size(154, 19);
			cbPartn.TabIndex = 0;
			cbPartn.Text = "Probleme mit Partner*in";
			cbPartn.UseVisualStyleBackColor = true;
			// 
			// cbGeld
			// 
			cbGeld.AutoSize = true;
			cbGeld.Location = new Point(8, 256);
			cbGeld.Name = "cbGeld";
			cbGeld.Size = new Size(93, 19);
			cbGeld.TabIndex = 0;
			cbGeld.Text = "Geld / Arbeit";
			cbGeld.UseVisualStyleBackColor = true;
			// 
			// cbMisshand
			// 
			cbMisshand.AutoSize = true;
			cbMisshand.Location = new Point(8, 206);
			cbMisshand.Name = "cbMisshand";
			cbMisshand.Size = new Size(164, 19);
			cbMisshand.TabIndex = 0;
			cbMisshand.Text = "Allgemeine Misshandlung";
			cbMisshand.UseVisualStyleBackColor = true;
			// 
			// cbKörpBehind
			// 
			cbKörpBehind.AutoSize = true;
			cbKörpBehind.Location = new Point(8, 156);
			cbKörpBehind.Name = "cbKörpBehind";
			cbKörpBehind.Size = new Size(157, 19);
			cbKörpBehind.TabIndex = 0;
			cbKörpBehind.Text = "Körperliche Behinderung";
			cbKörpBehind.UseVisualStyleBackColor = true;
			// 
			// cbSucht
			// 
			cbSucht.AutoSize = true;
			cbSucht.Location = new Point(8, 106);
			cbSucht.Name = "cbSucht";
			cbSucht.Size = new Size(107, 19);
			cbSucht.TabIndex = 0;
			cbSucht.Text = "Suchtprobleme";
			cbSucht.UseVisualStyleBackColor = true;
			// 
			// cbPsychosen
			// 
			cbPsychosen.AutoSize = true;
			cbPsychosen.Location = new Point(83, 81);
			cbPsychosen.Name = "cbPsychosen";
			cbPsychosen.Size = new Size(82, 19);
			cbPsychosen.TabIndex = 0;
			cbPsychosen.Text = "Psychosen";
			cbPsychosen.UseVisualStyleBackColor = true;
			// 
			// cbSexuell
			// 
			cbSexuell.AutoSize = true;
			cbSexuell.Location = new Point(8, 231);
			cbSexuell.Name = "cbSexuell";
			cbSexuell.Size = new Size(123, 19);
			cbSexuell.TabIndex = 0;
			cbSexuell.Text = "Sexueller Übergriff";
			cbSexuell.UseVisualStyleBackColor = true;
			// 
			// cbSuizid
			// 
			cbSuizid.AutoSize = true;
			cbSuizid.Location = new Point(8, 81);
			cbSuizid.Name = "cbSuizid";
			cbSuizid.Size = new Size(57, 19);
			cbSuizid.TabIndex = 0;
			cbSuizid.Text = "Suizid";
			cbSuizid.UseVisualStyleBackColor = true;
			// 
			// cbTrennung
			// 
			cbTrennung.AutoSize = true;
			cbTrennung.Location = new Point(8, 181);
			cbTrennung.Name = "cbTrennung";
			cbTrennung.Size = new Size(143, 19);
			cbTrennung.TabIndex = 0;
			cbTrennung.Text = "Trennung / Scheidung";
			cbTrennung.UseVisualStyleBackColor = true;
			// 
			// cbPsychisch
			// 
			cbPsychisch.AutoSize = true;
			cbPsychisch.Location = new Point(8, 56);
			cbPsychisch.Name = "cbPsychisch";
			cbPsychisch.Size = new Size(145, 19);
			cbPsychisch.TabIndex = 0;
			cbPsychisch.Text = "Psychische Symptome";
			cbPsychisch.UseVisualStyleBackColor = true;
			// 
			// chKrankTod
			// 
			chKrankTod.AutoSize = true;
			chKrankTod.Location = new Point(8, 131);
			chKrankTod.Name = "chKrankTod";
			chKrankTod.Size = new Size(106, 19);
			chKrankTod.TabIndex = 0;
			chKrankTod.Text = "Krankheit / Tod";
			chKrankTod.UseVisualStyleBackColor = true;
			// 
			// cbKörper
			// 
			cbKörper.AutoSize = true;
			cbKörper.Location = new Point(8, 31);
			cbKörper.Name = "cbKörper";
			cbKörper.Size = new Size(147, 19);
			cbKörper.TabIndex = 0;
			cbKörper.Text = "Körperliche Symptome";
			cbKörper.UseVisualStyleBackColor = true;
			// 
			// tbErläuterung
			// 
			tbErläuterung.BackColor = SystemColors.Window;
			tbErläuterung.BorderColor = Color.Black;
			tbErläuterung.BorderFocusColor = Color.Green;
			tbErläuterung.BorderRadius = 0;
			tbErläuterung.BorderSize = 1;
			tbErläuterung.Font = new Font("Segoe UI", 9.75F);
			tbErläuterung.ForeColor = Color.FromArgb(64, 64, 64);
			tbErläuterung.Location = new Point(38, 526);
			tbErläuterung.Margin = new Padding(10);
			tbErläuterung.Multiline = false;
			tbErläuterung.Name = "tbErläuterung";
			tbErläuterung.Padding = new Padding(10, 7, 10, 7);
			tbErläuterung.PasswordChar = false;
			tbErläuterung.PlaceholderColor = Color.DarkGray;
			tbErläuterung.PlaceholderText = "Erläuterung zu Andere";
			tbErläuterung.Size = new Size(200, 32);
			tbErläuterung.TabIndex = 5;
			tbErläuterung.Texts = "";
			tbErläuterung.UnderlinedStyle = true;
			// 
			// togglePartnerschaft
			// 
			togglePartnerschaft.AutoSize = true;
			togglePartnerschaft.Location = new Point(258, 148);
			togglePartnerschaft.MinimumSize = new Size(45, 22);
			togglePartnerschaft.Name = "togglePartnerschaft";
			togglePartnerschaft.OffBackColor = Color.Gray;
			togglePartnerschaft.OffToggleColor = Color.Gainsboro;
			togglePartnerschaft.OnBackColor = Color.Green;
			togglePartnerschaft.OnToggleColor = Color.WhiteSmoke;
			togglePartnerschaft.Size = new Size(45, 22);
			togglePartnerschaft.TabIndex = 6;
			togglePartnerschaft.UseVisualStyleBackColor = true;
			// 
			// toggleKinder
			// 
			toggleKinder.AutoSize = true;
			toggleKinder.Location = new Point(258, 192);
			toggleKinder.MinimumSize = new Size(45, 22);
			toggleKinder.Name = "toggleKinder";
			toggleKinder.OffBackColor = Color.Gray;
			toggleKinder.OffToggleColor = Color.Gainsboro;
			toggleKinder.OnBackColor = Color.Green;
			toggleKinder.OnToggleColor = Color.WhiteSmoke;
			toggleKinder.Size = new Size(45, 22);
			toggleKinder.TabIndex = 6;
			toggleKinder.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(309, 151);
			label1.Name = "label1";
			label1.Size = new Size(90, 15);
			label1.TabIndex = 7;
			label1.Text = "in Partnerschaft";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(309, 195);
			label2.Name = "label2";
			label2.Size = new Size(52, 15);
			label2.TabIndex = 7;
			label2.Text = "mit Kind";
			// 
			// toggleSonstige
			// 
			toggleSonstige.AutoSize = true;
			toggleSonstige.Location = new Point(258, 236);
			toggleSonstige.MinimumSize = new Size(45, 22);
			toggleSonstige.Name = "toggleSonstige";
			toggleSonstige.OffBackColor = Color.Gray;
			toggleSonstige.OffToggleColor = Color.Gainsboro;
			toggleSonstige.OnBackColor = Color.Green;
			toggleSonstige.OnToggleColor = Color.WhiteSmoke;
			toggleSonstige.Size = new Size(45, 22);
			toggleSonstige.TabIndex = 6;
			toggleSonstige.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(309, 239);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 7;
			label3.Text = "Sonstiges";
			// 
			// toggleUnbekannt
			// 
			toggleUnbekannt.AutoSize = true;
			toggleUnbekannt.Location = new Point(258, 280);
			toggleUnbekannt.MinimumSize = new Size(45, 22);
			toggleUnbekannt.Name = "toggleUnbekannt";
			toggleUnbekannt.OffBackColor = Color.Gray;
			toggleUnbekannt.OffToggleColor = Color.Gainsboro;
			toggleUnbekannt.OnBackColor = Color.Green;
			toggleUnbekannt.OnToggleColor = Color.WhiteSmoke;
			toggleUnbekannt.Size = new Size(45, 22);
			toggleUnbekannt.TabIndex = 6;
			toggleUnbekannt.UseVisualStyleBackColor = true;
			toggleUnbekannt.CheckedChanged += onToggleUnbekannt;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(309, 283);
			label4.Name = "label4";
			label4.Size = new Size(65, 15);
			label4.TabIndex = 7;
			label4.Text = "Unbekannt";
			// 
			// gridStunden
			// 
			gridStunden.AllowUserToAddRows = false;
			gridStunden.AllowUserToDeleteRows = false;
			gridStunden.AllowUserToResizeColumns = false;
			gridStunden.AllowUserToResizeRows = false;
			gridStunden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridStunden.BackgroundColor = SystemColors.ControlLight;
			gridStunden.BorderStyle = BorderStyle.Fixed3D;
			gridStunden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridStunden.Columns.AddRange(new DataGridViewColumn[] { Art, Stunden });
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = Color.LightGreen;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
			gridStunden.DefaultCellStyle = dataGridViewCellStyle1;
			gridStunden.EnableHeadersVisualStyles = false;
			gridStunden.GridColor = SystemColors.ControlLight;
			gridStunden.Location = new Point(258, 315);
			gridStunden.Name = "gridStunden";
			gridStunden.RowHeadersVisible = false;
			gridStunden.RowHeadersWidth = 40;
			gridStunden.RowTemplate.Height = 25;
			gridStunden.ScrollBars = ScrollBars.None;
			gridStunden.Size = new Size(200, 220);
			gridStunden.TabIndex = 11;
			gridStunden.CellValueChanged += OnValueChange;
			// 
			// Art
			// 
			Art.HeaderText = "Art";
			Art.Name = "Art";
			Art.ReadOnly = true;
			// 
			// Stunden
			// 
			Stunden.HeaderText = "Stunden";
			Stunden.Name = "Stunden";
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Green;
			btnSave.BackgroundColor = Color.Green;
			btnSave.BorderColor = Color.Transparent;
			btnSave.BorderRadius = 0;
			btnSave.BorderSize = 1;
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Font = new Font("Segoe UI", 12F);
			btnSave.ForeColor = Color.White;
			btnSave.Location = new Point(258, 541);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(200, 40);
			btnSave.TabIndex = 23;
			btnSave.Text = "Speichern";
			btnSave.TextColor = Color.White;
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += OnButtonSave;
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb(45, 0, 0, 0);
			panel4.Location = new Point(258, 541);
			panel4.Margin = new Padding(0);
			panel4.Name = "panel4";
			panel4.Size = new Size(203, 43);
			panel4.TabIndex = 24;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 8.25F);
			label5.ForeColor = Color.FromArgb(70, 70, 70);
			label5.Location = new Point(38, 564);
			label5.Name = "label5";
			label5.Size = new Size(123, 13);
			label5.TabIndex = 26;
			label5.Text = "Erläuterung zu Andere";
			// 
			// EheUndLeben
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label5);
			Controls.Add(btnSave);
			Controls.Add(panel4);
			Controls.Add(gridStunden);
			Controls.Add(label2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(toggleKinder);
			Controls.Add(toggleUnbekannt);
			Controls.Add(toggleSonstige);
			Controls.Add(togglePartnerschaft);
			Controls.Add(tbErläuterung);
			Controls.Add(groupAnmeldung);
			Controls.Add(dropWirtschaft);
			Controls.Add(dropLeistung);
			Name = "EheUndLeben";
			Size = new Size(500, 590);
			Load += EheUndLeben_Load;
			groupAnmeldung.ResumeLayout(false);
			groupAnmeldung.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gridStunden).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DropDown dropLeistung;
        private DropDown dropWirtschaft;
        private GroupBox groupAnmeldung;
        private CheckBox cbKörpBehind;
        private CheckBox cbSucht;
        private CheckBox cbPsychosen;
        private CheckBox cbSuizid;
        private CheckBox cbPsychisch;
        private CheckBox chKrankTod;
        private CheckBox cbKörper;
        private CheckBox cbAndere;
        private CheckBox cbStraft;
        private CheckBox cbFamilie;
        private CheckBox cbPartn;
        private CheckBox cbGeld;
        private CheckBox cbMisshand;
        private CheckBox cbSexuell;
        private CheckBox cbTrennung;
        private RJTextBox tbErläuterung;
        private RJCodeAdvance.RJControls.RJToggleButton togglePartnerschaft;
        private RJCodeAdvance.RJControls.RJToggleButton toggleKinder;
        private Label label1;
        private Label label2;
        private RJCodeAdvance.RJControls.RJToggleButton toggleSonstige;
        private Label label3;
        private RJCodeAdvance.RJControls.RJToggleButton toggleUnbekannt;
        private Label label4;
        private DataGridView gridStunden;
        private DataGridViewTextBoxColumn Art;
        private DataGridViewTextBoxColumn Stunden;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
        private Label label5;
    }
}
