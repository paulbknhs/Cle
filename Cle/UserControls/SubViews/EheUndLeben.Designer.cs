using Cle.UserControls.CustomControls;

namespace Cle.UserControls.SubViews
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            groupAnmeldung.Location = new Point(43, 173);
            groupAnmeldung.Margin = new Padding(3, 4, 3, 4);
            groupAnmeldung.Name = "groupAnmeldung";
            groupAnmeldung.Padding = new Padding(6, 7, 6, 7);
            groupAnmeldung.Size = new Size(229, 511);
            groupAnmeldung.TabIndex = 4;
            groupAnmeldung.TabStop = false;
            groupAnmeldung.Text = "Anmeldegründe";
            // 
            // cbAndere
            // 
            cbAndere.AutoSize = true;
            cbAndere.Location = new Point(9, 475);
            cbAndere.Margin = new Padding(3, 4, 3, 4);
            cbAndere.Name = "cbAndere";
            cbAndere.Size = new Size(147, 24);
            cbAndere.TabIndex = 0;
            cbAndere.Text = "Andere Probleme";
            cbAndere.UseVisualStyleBackColor = true;
            // 
            // cbStraft
            // 
            cbStraft.AutoSize = true;
            cbStraft.Location = new Point(9, 441);
            cbStraft.Margin = new Padding(3, 4, 3, 4);
            cbStraft.Name = "cbStraft";
            cbStraft.Size = new Size(96, 24);
            cbStraft.TabIndex = 0;
            cbStraft.Text = "Straftaten";
            cbStraft.UseVisualStyleBackColor = true;
            // 
            // cbFamilie
            // 
            cbFamilie.AutoSize = true;
            cbFamilie.Location = new Point(9, 408);
            cbFamilie.Margin = new Padding(3, 4, 3, 4);
            cbFamilie.Name = "cbFamilie";
            cbFamilie.Size = new Size(159, 24);
            cbFamilie.TabIndex = 0;
            cbFamilie.Text = "Familiäre Probleme";
            cbFamilie.UseVisualStyleBackColor = true;
            // 
            // cbPartn
            // 
            cbPartn.AutoSize = true;
            cbPartn.Location = new Point(9, 375);
            cbPartn.Margin = new Padding(3, 4, 3, 4);
            cbPartn.Name = "cbPartn";
            cbPartn.Size = new Size(189, 24);
            cbPartn.TabIndex = 0;
            cbPartn.Text = "Probleme mit Partner*in";
            cbPartn.UseVisualStyleBackColor = true;
            // 
            // cbGeld
            // 
            cbGeld.AutoSize = true;
            cbGeld.Location = new Point(9, 341);
            cbGeld.Margin = new Padding(3, 4, 3, 4);
            cbGeld.Name = "cbGeld";
            cbGeld.Size = new Size(117, 24);
            cbGeld.TabIndex = 0;
            cbGeld.Text = "Geld / Arbeit";
            cbGeld.UseVisualStyleBackColor = true;
            // 
            // cbMisshand
            // 
            cbMisshand.AutoSize = true;
            cbMisshand.Location = new Point(9, 275);
            cbMisshand.Margin = new Padding(3, 4, 3, 4);
            cbMisshand.Name = "cbMisshand";
            cbMisshand.Size = new Size(202, 24);
            cbMisshand.TabIndex = 0;
            cbMisshand.Text = "Allgemeine Misshandlung";
            cbMisshand.UseVisualStyleBackColor = true;
            // 
            // cbKörpBehind
            // 
            cbKörpBehind.AutoSize = true;
            cbKörpBehind.Location = new Point(9, 208);
            cbKörpBehind.Margin = new Padding(3, 4, 3, 4);
            cbKörpBehind.Name = "cbKörpBehind";
            cbKörpBehind.Size = new Size(195, 24);
            cbKörpBehind.TabIndex = 0;
            cbKörpBehind.Text = "Körperliche Behinderung";
            cbKörpBehind.UseVisualStyleBackColor = true;
            // 
            // cbSucht
            // 
            cbSucht.AutoSize = true;
            cbSucht.Location = new Point(9, 141);
            cbSucht.Margin = new Padding(3, 4, 3, 4);
            cbSucht.Name = "cbSucht";
            cbSucht.Size = new Size(132, 24);
            cbSucht.TabIndex = 0;
            cbSucht.Text = "Suchtprobleme";
            cbSucht.UseVisualStyleBackColor = true;
            // 
            // cbPsychosen
            // 
            cbPsychosen.AutoSize = true;
            cbPsychosen.Location = new Point(95, 108);
            cbPsychosen.Margin = new Padding(3, 4, 3, 4);
            cbPsychosen.Name = "cbPsychosen";
            cbPsychosen.Size = new Size(98, 24);
            cbPsychosen.TabIndex = 0;
            cbPsychosen.Text = "Psychosen";
            cbPsychosen.UseVisualStyleBackColor = true;
            // 
            // cbSexuell
            // 
            cbSexuell.AutoSize = true;
            cbSexuell.Location = new Point(9, 308);
            cbSexuell.Margin = new Padding(3, 4, 3, 4);
            cbSexuell.Name = "cbSexuell";
            cbSexuell.Size = new Size(155, 24);
            cbSexuell.TabIndex = 0;
            cbSexuell.Text = "Sexueller Übergriff";
            cbSexuell.UseVisualStyleBackColor = true;
            // 
            // cbSuizid
            // 
            cbSuizid.AutoSize = true;
            cbSuizid.Location = new Point(9, 108);
            cbSuizid.Margin = new Padding(3, 4, 3, 4);
            cbSuizid.Name = "cbSuizid";
            cbSuizid.Size = new Size(71, 24);
            cbSuizid.TabIndex = 0;
            cbSuizid.Text = "Suizid";
            cbSuizid.UseVisualStyleBackColor = true;
            // 
            // cbTrennung
            // 
            cbTrennung.AutoSize = true;
            cbTrennung.Location = new Point(9, 241);
            cbTrennung.Margin = new Padding(3, 4, 3, 4);
            cbTrennung.Name = "cbTrennung";
            cbTrennung.Size = new Size(175, 24);
            cbTrennung.TabIndex = 0;
            cbTrennung.Text = "Trennung / Scheidung";
            cbTrennung.UseVisualStyleBackColor = true;
            // 
            // cbPsychisch
            // 
            cbPsychisch.AutoSize = true;
            cbPsychisch.Location = new Point(9, 75);
            cbPsychisch.Margin = new Padding(3, 4, 3, 4);
            cbPsychisch.Name = "cbPsychisch";
            cbPsychisch.Size = new Size(176, 24);
            cbPsychisch.TabIndex = 0;
            cbPsychisch.Text = "Psychische Symptome";
            cbPsychisch.UseVisualStyleBackColor = true;
            // 
            // chKrankTod
            // 
            chKrankTod.AutoSize = true;
            chKrankTod.Location = new Point(9, 175);
            chKrankTod.Margin = new Padding(3, 4, 3, 4);
            chKrankTod.Name = "chKrankTod";
            chKrankTod.Size = new Size(132, 24);
            chKrankTod.TabIndex = 0;
            chKrankTod.Text = "Krankheit / Tod";
            chKrankTod.UseVisualStyleBackColor = true;
            // 
            // cbKörper
            // 
            cbKörper.AutoSize = true;
            cbKörper.Location = new Point(9, 41);
            cbKörper.Margin = new Padding(3, 4, 3, 4);
            cbKörper.Name = "cbKörper";
            cbKörper.Size = new Size(183, 24);
            cbKörper.TabIndex = 0;
            cbKörper.Text = "Körperliche Symptome";
            cbKörper.UseVisualStyleBackColor = true;
            // 
            // togglePartnerschaft
            // 
            togglePartnerschaft.AutoSize = true;
            togglePartnerschaft.Location = new Point(295, 197);
            togglePartnerschaft.Margin = new Padding(3, 4, 3, 4);
            togglePartnerschaft.MinimumSize = new Size(51, 29);
            togglePartnerschaft.Name = "togglePartnerschaft";
            togglePartnerschaft.OffBackColor = Color.Gray;
            togglePartnerschaft.OffToggleColor = Color.Gainsboro;
            togglePartnerschaft.OnBackColor = Color.SkyBlue;
            togglePartnerschaft.OnToggleColor = Color.WhiteSmoke;
            togglePartnerschaft.Size = new Size(51, 29);
            togglePartnerschaft.TabIndex = 6;
            togglePartnerschaft.UseVisualStyleBackColor = true;
            // 
            // toggleKinder
            // 
            toggleKinder.AutoSize = true;
            toggleKinder.Location = new Point(295, 256);
            toggleKinder.Margin = new Padding(3, 4, 3, 4);
            toggleKinder.MinimumSize = new Size(51, 29);
            toggleKinder.Name = "toggleKinder";
            toggleKinder.OffBackColor = Color.Gray;
            toggleKinder.OffToggleColor = Color.Gainsboro;
            toggleKinder.OnBackColor = Color.SkyBlue;
            toggleKinder.OnToggleColor = Color.WhiteSmoke;
            toggleKinder.Size = new Size(51, 29);
            toggleKinder.TabIndex = 6;
            toggleKinder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 201);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 7;
            label1.Text = "in Partnerschaft";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 260);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "mit Kind";
            // 
            // toggleSonstige
            // 
            toggleSonstige.AutoSize = true;
            toggleSonstige.Location = new Point(295, 315);
            toggleSonstige.Margin = new Padding(3, 4, 3, 4);
            toggleSonstige.MinimumSize = new Size(51, 29);
            toggleSonstige.Name = "toggleSonstige";
            toggleSonstige.OffBackColor = Color.Gray;
            toggleSonstige.OffToggleColor = Color.Gainsboro;
            toggleSonstige.OnBackColor = Color.SkyBlue;
            toggleSonstige.OnToggleColor = Color.WhiteSmoke;
            toggleSonstige.Size = new Size(51, 29);
            toggleSonstige.TabIndex = 6;
            toggleSonstige.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 319);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Sonstiges";
            // 
            // toggleUnbekannt
            // 
            toggleUnbekannt.AutoSize = true;
            toggleUnbekannt.Location = new Point(295, 373);
            toggleUnbekannt.Margin = new Padding(3, 4, 3, 4);
            toggleUnbekannt.MinimumSize = new Size(51, 29);
            toggleUnbekannt.Name = "toggleUnbekannt";
            toggleUnbekannt.OffBackColor = Color.Gray;
            toggleUnbekannt.OffToggleColor = Color.Gainsboro;
            toggleUnbekannt.OnBackColor = Color.SkyBlue;
            toggleUnbekannt.OnToggleColor = Color.WhiteSmoke;
            toggleUnbekannt.Size = new Size(51, 29);
            toggleUnbekannt.TabIndex = 6;
            toggleUnbekannt.UseVisualStyleBackColor = true;
            toggleUnbekannt.CheckedChanged += onToggleUnbekannt;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 377);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridStunden.DefaultCellStyle = dataGridViewCellStyle2;
            gridStunden.EnableHeadersVisualStyles = false;
            gridStunden.GridColor = SystemColors.ControlLight;
            gridStunden.Location = new Point(295, 420);
            gridStunden.Margin = new Padding(3, 4, 3, 4);
            gridStunden.Name = "gridStunden";
            gridStunden.RowHeadersVisible = false;
            gridStunden.RowHeadersWidth = 40;
            gridStunden.ScrollBars = ScrollBars.None;
            gridStunden.Size = new Size(229, 293);
            gridStunden.TabIndex = 11;
            gridStunden.CellValueChanged += OnValueChange;
            // 
            // Art
            // 
            Art.HeaderText = "Art";
            Art.MinimumWidth = 6;
            Art.Name = "Art";
            Art.ReadOnly = true;
            // 
            // Stunden
            // 
            Stunden.HeaderText = "Stunden";
            Stunden.MinimumWidth = 6;
            Stunden.Name = "Stunden";
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
            btnSave.Location = new Point(295, 721);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(229, 53);
            btnSave.TabIndex = 23;
            btnSave.Text = "Speichern";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnButtonSave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 0, 0, 0);
            panel4.Location = new Point(295, 721);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 57);
            panel4.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8.25F);
            label5.ForeColor = Color.FromArgb(70, 70, 70);
            label5.Location = new Point(43, 752);
            label5.Name = "label5";
            label5.Size = new Size(146, 19);
            label5.TabIndex = 26;
            label5.Text = "Erläuterung zu Andere";
            // 
            // EheUndLeben
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Controls.Add(groupAnmeldung);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EheUndLeben";
            Size = new Size(571, 787);
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
