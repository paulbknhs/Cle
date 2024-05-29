using Cle.UserControls.CustomControls;

namespace Cle.UserControls.SubViews
{
    partial class P218
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
            label1 = new Label();
            numBeratungszeit = new NumericUpDown();
            dropStaat = new DropDown();
            grpAnm = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            cbAndere = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            cbStraft = new CheckBox();
            checkBox1 = new CheckBox();
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
            dropStand = new DropDown();
            dropVerhütung = new DropDown();
            dropErwerb = new DropDown();
            tbErläuterungen = new RJTextBox();
            tbNr = new RJTextBox();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            panel4 = new Panel();
            dropKommu = new DropDown();
            tbJahr = new RJTextBox();
            dropGeschlecht = new DropDown();
            tbAlter = new RJTextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).BeginInit();
            grpAnm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 97);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 13;
            label1.Text = "Beratungszeit in min";
            // 
            // numBeratungszeit
            // 
            numBeratungszeit.Increment = new decimal(new int[] { 45, 0, 0, 0 });
            numBeratungszeit.Location = new Point(263, 94);
            numBeratungszeit.Maximum = new decimal(new int[] { 270, 0, 0, 0 });
            numBeratungszeit.Name = "numBeratungszeit";
            numBeratungszeit.Size = new Size(70, 23);
            numBeratungszeit.TabIndex = 4;
            // 
            // dropStaat
            // 
            dropStaat.BackColor = Color.WhiteSmoke;
            dropStaat.BorderColor = Color.SkyBlue;
            dropStaat.BorderSize = 1;
            dropStaat.DropDownStyle = ComboBoxStyle.DropDownList;
            dropStaat.Font = new Font("Segoe UI", 10F);
            dropStaat.ForeColor = Color.DimGray;
            dropStaat.IconColor = Color.SkyBlue;
            dropStaat.ListBackColor = Color.FromArgb(230, 228, 245);
            dropStaat.ListTextColor = Color.DimGray;
            dropStaat.Location = new Point(40, 198);
            dropStaat.Margin = new Padding(10);
            dropStaat.MinimumSize = new Size(200, 30);
            dropStaat.Name = "dropStaat";
            dropStaat.Padding = new Padding(1);
            dropStaat.Size = new Size(200, 32);
            dropStaat.TabIndex = 7;
            dropStaat.Texts = "";
            // 
            // grpAnm
            // 
            grpAnm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAnm.Controls.Add(checkBox6);
            grpAnm.Controls.Add(checkBox5);
            grpAnm.Controls.Add(checkBox3);
            grpAnm.Controls.Add(cbAndere);
            grpAnm.Controls.Add(checkBox4);
            grpAnm.Controls.Add(checkBox2);
            grpAnm.Controls.Add(cbStraft);
            grpAnm.Controls.Add(checkBox1);
            grpAnm.Controls.Add(cbFamilie);
            grpAnm.Controls.Add(cbPartn);
            grpAnm.Controls.Add(cbGeld);
            grpAnm.Controls.Add(cbMisshand);
            grpAnm.Controls.Add(cbKörpBehind);
            grpAnm.Controls.Add(cbSucht);
            grpAnm.Controls.Add(cbPsychosen);
            grpAnm.Controls.Add(cbSexuell);
            grpAnm.Controls.Add(cbSuizid);
            grpAnm.Controls.Add(cbTrennung);
            grpAnm.Controls.Add(cbPsychisch);
            grpAnm.Controls.Add(chKrankTod);
            grpAnm.Controls.Add(cbKörper);
            grpAnm.Location = new Point(40, 278);
            grpAnm.Name = "grpAnm";
            grpAnm.Padding = new Padding(5);
            grpAnm.Size = new Size(420, 255);
            grpAnm.TabIndex = 11;
            grpAnm.TabStop = false;
            grpAnm.Text = "Abbruchsgründe";
            // 
            // checkBox6
            // 
            checkBox6.Anchor = AnchorStyles.Bottom;
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 229);
            checkBox6.Margin = new Padding(1);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(106, 19);
            checkBox6.TabIndex = 0;
            checkBox6.Text = "Keine Angaben";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.Bottom;
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(225, 229);
            checkBox5.Margin = new Padding(1);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(113, 19);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "Sonstige Gründe";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Bottom;
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(225, 181);
            checkBox3.Margin = new Padding(1);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(147, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Psychische Gesundheit";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbAndere
            // 
            cbAndere.Anchor = AnchorStyles.Bottom;
            cbAndere.AutoSize = true;
            cbAndere.Location = new Point(225, 109);
            cbAndere.Margin = new Padding(1);
            cbAndere.Name = "cbAndere";
            cbAndere.Size = new Size(167, 19);
            cbAndere.TabIndex = 0;
            cbAndere.Text = "Körperliche Überforderung";
            cbAndere.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Bottom;
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(225, 205);
            checkBox4.Margin = new Padding(1);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(164, 19);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "Drohende Bhd. des Kindes";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Bottom;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(225, 157);
            checkBox2.Margin = new Padding(1);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(149, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Körperliche Gesundheit";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbStraft
            // 
            cbStraft.Anchor = AnchorStyles.Bottom;
            cbStraft.AutoSize = true;
            cbStraft.Location = new Point(225, 85);
            cbStraft.Margin = new Padding(1);
            cbStraft.Name = "cbStraft";
            cbStraft.Size = new Size(56, 19);
            cbStraft.TabIndex = 0;
            cbStraft.Text = "Zu alt";
            cbStraft.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(225, 133);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Psychische Überforderung";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbFamilie
            // 
            cbFamilie.Anchor = AnchorStyles.Bottom;
            cbFamilie.AutoSize = true;
            cbFamilie.Location = new Point(225, 61);
            cbFamilie.Margin = new Padding(1);
            cbFamilie.Name = "cbFamilie";
            cbFamilie.Size = new Size(67, 19);
            cbFamilie.TabIndex = 0;
            cbFamilie.Text = "Zu jung";
            cbFamilie.UseVisualStyleBackColor = true;
            // 
            // cbPartn
            // 
            cbPartn.Anchor = AnchorStyles.Bottom;
            cbPartn.AutoSize = true;
            cbPartn.Location = new Point(225, 37);
            cbPartn.Margin = new Padding(1);
            cbPartn.Name = "cbPartn";
            cbPartn.Size = new Size(117, 19);
            cbPartn.TabIndex = 0;
            cbPartn.Text = "Schule / Studium";
            cbPartn.UseVisualStyleBackColor = true;
            // 
            // cbGeld
            // 
            cbGeld.Anchor = AnchorStyles.Bottom;
            cbGeld.AutoSize = true;
            cbGeld.Location = new Point(225, 13);
            cbGeld.Margin = new Padding(1);
            cbGeld.Name = "cbGeld";
            cbGeld.Size = new Size(131, 19);
            cbGeld.TabIndex = 0;
            cbGeld.Text = "Soziale Unsicherheit";
            cbGeld.UseVisualStyleBackColor = true;
            // 
            // cbMisshand
            // 
            cbMisshand.Anchor = AnchorStyles.Bottom;
            cbMisshand.AutoSize = true;
            cbMisshand.Location = new Point(6, 187);
            cbMisshand.Margin = new Padding(1);
            cbMisshand.Name = "cbMisshand";
            cbMisshand.Size = new Size(113, 19);
            cbMisshand.TabIndex = 0;
            cbMisshand.Text = "Erhalt des Stand.";
            cbMisshand.UseVisualStyleBackColor = true;
            // 
            // cbKörpBehind
            // 
            cbKörpBehind.Anchor = AnchorStyles.Bottom;
            cbKörpBehind.AutoSize = true;
            cbKörpBehind.Location = new Point(6, 145);
            cbKörpBehind.Margin = new Padding(1);
            cbKörpBehind.Name = "cbKörpBehind";
            cbKörpBehind.Size = new Size(116, 19);
            cbKörpBehind.TabIndex = 0;
            cbKörpBehind.Text = "Familiäre Gründe";
            cbKörpBehind.UseVisualStyleBackColor = true;
            // 
            // cbSucht
            // 
            cbSucht.Anchor = AnchorStyles.Bottom;
            cbSucht.AutoSize = true;
            cbSucht.Location = new Point(6, 103);
            cbSucht.Margin = new Padding(1);
            cbSucht.Name = "cbSucht";
            cbSucht.Size = new Size(120, 19);
            cbSucht.TabIndex = 0;
            cbSucht.Text = "Abl. d. d. Kindesv.";
            cbSucht.UseVisualStyleBackColor = true;
            // 
            // cbPsychosen
            // 
            cbPsychosen.Anchor = AnchorStyles.Bottom;
            cbPsychosen.AutoSize = true;
            cbPsychosen.Location = new Point(6, 82);
            cbPsychosen.Margin = new Padding(1);
            cbPsychosen.Name = "cbPsychosen";
            cbPsychosen.Size = new Size(107, 19);
            cbPsychosen.TabIndex = 0;
            cbPsychosen.Text = "Alleinerziehend";
            cbPsychosen.UseVisualStyleBackColor = true;
            // 
            // cbSexuell
            // 
            cbSexuell.Anchor = AnchorStyles.Bottom;
            cbSexuell.AutoSize = true;
            cbSexuell.Location = new Point(6, 208);
            cbSexuell.Margin = new Padding(1);
            cbSexuell.Name = "cbSexuell";
            cbSexuell.Size = new Size(121, 19);
            cbSexuell.TabIndex = 0;
            cbSexuell.Text = "Berufliche Gründe";
            cbSexuell.UseVisualStyleBackColor = true;
            // 
            // cbSuizid
            // 
            cbSuizid.Anchor = AnchorStyles.Bottom;
            cbSuizid.AutoSize = true;
            cbSuizid.Location = new Point(6, 61);
            cbSuizid.Margin = new Padding(1);
            cbSuizid.Name = "cbSuizid";
            cbSuizid.Size = new Size(123, 19);
            cbSuizid.TabIndex = 0;
            cbSuizid.Text = "Finanzielle Gründe";
            cbSuizid.UseVisualStyleBackColor = true;
            // 
            // cbTrennung
            // 
            cbTrennung.Anchor = AnchorStyles.Bottom;
            cbTrennung.AutoSize = true;
            cbTrennung.Location = new Point(6, 166);
            cbTrennung.Margin = new Padding(1);
            cbTrennung.Name = "cbTrennung";
            cbTrennung.Size = new Size(104, 19);
            cbTrennung.TabIndex = 0;
            cbTrennung.Text = "Wohnsituation";
            cbTrennung.UseVisualStyleBackColor = true;
            // 
            // cbPsychisch
            // 
            cbPsychisch.Anchor = AnchorStyles.Bottom;
            cbPsychisch.AutoSize = true;
            cbPsychisch.Location = new Point(6, 40);
            cbPsychisch.Margin = new Padding(1);
            cbPsychisch.Name = "cbPsychisch";
            cbPsychisch.Size = new Size(158, 19);
            cbPsychisch.TabIndex = 0;
            cbPsychisch.Text = "Abgeschlossene Planung";
            cbPsychisch.UseVisualStyleBackColor = true;
            // 
            // chKrankTod
            // 
            chKrankTod.Anchor = AnchorStyles.Bottom;
            chKrankTod.AutoSize = true;
            chKrankTod.Location = new Point(6, 124);
            chKrankTod.Margin = new Padding(1);
            chKrankTod.Name = "chKrankTod";
            chKrankTod.Size = new Size(96, 19);
            chKrankTod.TabIndex = 0;
            chKrankTod.Text = "Partnerschaft";
            chKrankTod.UseVisualStyleBackColor = true;
            // 
            // cbKörper
            // 
            cbKörper.Anchor = AnchorStyles.Bottom;
            cbKörper.AutoSize = true;
            cbKörper.Location = new Point(6, 19);
            cbKörper.Margin = new Padding(1);
            cbKörper.Name = "cbKörper";
            cbKörper.Size = new Size(172, 19);
            cbKörper.TabIndex = 0;
            cbKörper.Text = "Generell kein Kinderwunsch";
            cbKörper.UseVisualStyleBackColor = true;
            // 
            // dropStand
            // 
            dropStand.BackColor = Color.WhiteSmoke;
            dropStand.BorderColor = Color.SkyBlue;
            dropStand.BorderSize = 1;
            dropStand.DropDownStyle = ComboBoxStyle.DropDownList;
            dropStand.Font = new Font("Segoe UI", 10F);
            dropStand.ForeColor = Color.DimGray;
            dropStand.IconColor = Color.SkyBlue;
            dropStand.ListBackColor = Color.FromArgb(230, 228, 245);
            dropStand.ListTextColor = Color.DimGray;
            dropStand.Location = new Point(40, 240);
            dropStand.Margin = new Padding(10);
            dropStand.MinimumSize = new Size(200, 30);
            dropStand.Name = "dropStand";
            dropStand.Padding = new Padding(1);
            dropStand.Size = new Size(200, 32);
            dropStand.TabIndex = 9;
            dropStand.Texts = "";
            // 
            // dropVerhütung
            // 
            dropVerhütung.BackColor = Color.WhiteSmoke;
            dropVerhütung.BorderColor = Color.SkyBlue;
            dropVerhütung.BorderSize = 1;
            dropVerhütung.DropDownStyle = ComboBoxStyle.DropDownList;
            dropVerhütung.Font = new Font("Segoe UI", 10F);
            dropVerhütung.ForeColor = Color.DimGray;
            dropVerhütung.IconColor = Color.SkyBlue;
            dropVerhütung.ListBackColor = Color.FromArgb(230, 228, 245);
            dropVerhütung.ListTextColor = Color.DimGray;
            dropVerhütung.Location = new Point(263, 240);
            dropVerhütung.Margin = new Padding(10);
            dropVerhütung.MinimumSize = new Size(200, 30);
            dropVerhütung.Name = "dropVerhütung";
            dropVerhütung.Padding = new Padding(1);
            dropVerhütung.Size = new Size(200, 32);
            dropVerhütung.TabIndex = 10;
            dropVerhütung.Texts = "";
            // 
            // dropErwerb
            // 
            dropErwerb.BackColor = Color.WhiteSmoke;
            dropErwerb.BorderColor = Color.SkyBlue;
            dropErwerb.BorderSize = 1;
            dropErwerb.DropDownStyle = ComboBoxStyle.DropDownList;
            dropErwerb.Font = new Font("Segoe UI", 8F);
            dropErwerb.ForeColor = Color.DimGray;
            dropErwerb.IconColor = Color.SkyBlue;
            dropErwerb.ListBackColor = Color.FromArgb(230, 228, 245);
            dropErwerb.ListTextColor = Color.DimGray;
            dropErwerb.Location = new Point(263, 198);
            dropErwerb.Margin = new Padding(10);
            dropErwerb.MinimumSize = new Size(200, 30);
            dropErwerb.Name = "dropErwerb";
            dropErwerb.Padding = new Padding(1);
            dropErwerb.Size = new Size(200, 32);
            dropErwerb.TabIndex = 8;
            dropErwerb.Texts = "";
            // 
            // tbErläuterungen
            // 
            tbErläuterungen.BackColor = SystemColors.Window;
            tbErläuterungen.BorderColor = Color.Black;
            tbErläuterungen.BorderFocusColor = Color.SkyBlue;
            tbErläuterungen.BorderRadius = 0;
            tbErläuterungen.BorderSize = 1;
            tbErläuterungen.Font = new Font("Segoe UI", 9.75F);
            tbErläuterungen.ForeColor = Color.FromArgb(64, 64, 64);
            tbErläuterungen.Location = new Point(40, 538);
            tbErläuterungen.Margin = new Padding(10);
            tbErläuterungen.Multiline = true;
            tbErläuterungen.Name = "tbErläuterungen";
            tbErläuterungen.Padding = new Padding(10, 7, 10, 7);
            tbErläuterungen.PasswordChar = false;
            tbErläuterungen.PlaceholderColor = Color.DarkGray;
            tbErläuterungen.PlaceholderText = "Erläuterung zu Sonstiges";
            tbErläuterungen.Size = new Size(200, 32);
            tbErläuterungen.TabIndex = 6;
            tbErläuterungen.Texts = "";
            tbErläuterungen.UnderlinedStyle = true;
            // 
            // tbNr
            // 
            tbNr.BackColor = SystemColors.Window;
            tbNr.BorderColor = Color.Black;
            tbNr.BorderFocusColor = Color.SkyBlue;
            tbNr.BorderRadius = 0;
            tbNr.BorderSize = 1;
            tbNr.Font = new Font("Segoe UI", 9.75F);
            tbNr.ForeColor = Color.FromArgb(64, 64, 64);
            tbNr.Location = new Point(40, 89);
            tbNr.Margin = new Padding(10);
            tbNr.Multiline = false;
            tbNr.Name = "tbNr";
            tbNr.Padding = new Padding(10, 7, 10, 7);
            tbNr.PasswordChar = false;
            tbNr.PlaceholderColor = Color.DarkGray;
            tbNr.PlaceholderText = "Laufende Nummer";
            tbNr.Size = new Size(200, 32);
            tbNr.TabIndex = 3;
            tbNr.Texts = "";
            tbNr.UnderlinedStyle = true;
            tbNr.Enter += OnTextBoxEnter;
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
            btnSave.Location = new Point(253, 538);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 23;
            btnSave.Text = "Speichern";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnButtonSave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 0, 0, 0);
            panel4.Location = new Point(253, 538);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 43);
            panel4.TabIndex = 24;
            panel4.Click += OnButtonSave;
            // 
            // dropKommu
            // 
            dropKommu.BackColor = Color.WhiteSmoke;
            dropKommu.BorderColor = Color.SkyBlue;
            dropKommu.BorderSize = 1;
            dropKommu.DropDownStyle = ComboBoxStyle.DropDownList;
            dropKommu.Font = new Font("Segoe UI", 10F);
            dropKommu.ForeColor = Color.DimGray;
            dropKommu.IconColor = Color.SkyBlue;
            dropKommu.ListBackColor = Color.FromArgb(230, 228, 245);
            dropKommu.ListTextColor = Color.DimGray;
            dropKommu.Location = new Point(263, 155);
            dropKommu.Margin = new Padding(10);
            dropKommu.MinimumSize = new Size(200, 30);
            dropKommu.Name = "dropKommu";
            dropKommu.Padding = new Padding(1);
            dropKommu.Size = new Size(200, 32);
            dropKommu.TabIndex = 6;
            dropKommu.Texts = "";
            // 
            // tbJahr
            // 
            tbJahr.BackColor = SystemColors.Window;
            tbJahr.BorderColor = Color.Black;
            tbJahr.BorderFocusColor = Color.SkyBlue;
            tbJahr.BorderRadius = 0;
            tbJahr.BorderSize = 1;
            tbJahr.Font = new Font("Segoe UI", 9.75F);
            tbJahr.ForeColor = Color.FromArgb(64, 64, 64);
            tbJahr.Location = new Point(40, 28);
            tbJahr.Margin = new Padding(10);
            tbJahr.Multiline = false;
            tbJahr.Name = "tbJahr";
            tbJahr.Padding = new Padding(10, 7, 10, 7);
            tbJahr.PasswordChar = false;
            tbJahr.PlaceholderColor = Color.DarkGray;
            tbJahr.PlaceholderText = "Jahr";
            tbJahr.Size = new Size(200, 32);
            tbJahr.TabIndex = 1;
            tbJahr.Texts = "";
            tbJahr.UnderlinedStyle = true;
            tbJahr.Enter += OnTextBoxEnter;
            // 
            // dropGeschlecht
            // 
            dropGeschlecht.BackColor = Color.WhiteSmoke;
            dropGeschlecht.BorderColor = Color.SkyBlue;
            dropGeschlecht.BorderSize = 1;
            dropGeschlecht.DropDownStyle = ComboBoxStyle.DropDownList;
            dropGeschlecht.Font = new Font("Segoe UI", 10F);
            dropGeschlecht.ForeColor = Color.DimGray;
            dropGeschlecht.IconColor = Color.SkyBlue;
            dropGeschlecht.ListBackColor = Color.FromArgb(230, 228, 245);
            dropGeschlecht.ListTextColor = Color.DimGray;
            dropGeschlecht.Location = new Point(40, 155);
            dropGeschlecht.Margin = new Padding(10);
            dropGeschlecht.MinimumSize = new Size(200, 30);
            dropGeschlecht.Name = "dropGeschlecht";
            dropGeschlecht.Padding = new Padding(1);
            dropGeschlecht.Size = new Size(200, 32);
            dropGeschlecht.TabIndex = 5;
            dropGeschlecht.Texts = "";
            // 
            // tbAlter
            // 
            tbAlter.BackColor = SystemColors.Window;
            tbAlter.BorderColor = Color.Black;
            tbAlter.BorderFocusColor = Color.SkyBlue;
            tbAlter.BorderRadius = 0;
            tbAlter.BorderSize = 1;
            tbAlter.Font = new Font("Segoe UI", 9.75F);
            tbAlter.ForeColor = Color.FromArgb(64, 64, 64);
            tbAlter.Location = new Point(263, 28);
            tbAlter.Margin = new Padding(10);
            tbAlter.Multiline = false;
            tbAlter.Name = "tbAlter";
            tbAlter.Padding = new Padding(10, 7, 10, 7);
            tbAlter.PasswordChar = false;
            tbAlter.PlaceholderColor = Color.DarkGray;
            tbAlter.PlaceholderText = "Alter";
            tbAlter.Size = new Size(197, 32);
            tbAlter.TabIndex = 2;
            tbAlter.Texts = "";
            tbAlter.UnderlinedStyle = true;
            tbAlter.Enter += OnTextBoxEnter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8.25F);
            label5.ForeColor = Color.FromArgb(70, 70, 70);
            label5.Location = new Point(40, 570);
            label5.Name = "label5";
            label5.Size = new Size(136, 13);
            label5.TabIndex = 27;
            label5.Text = "Erläuterung zu Sonstiges";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8.25F);
            label2.ForeColor = Color.FromArgb(70, 70, 70);
            label2.Location = new Point(40, 123);
            label2.Name = "label2";
            label2.Size = new Size(101, 13);
            label2.TabIndex = 27;
            label2.Text = "Laufende Nummer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.ForeColor = Color.FromArgb(70, 70, 70);
            label3.Location = new Point(40, 64);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(28, 13);
            label3.TabIndex = 27;
            label3.Text = "Jahr";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8.25F);
            label6.ForeColor = Color.FromArgb(70, 70, 70);
            label6.Location = new Point(263, 64);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(31, 13);
            label6.TabIndex = 27;
            label6.Text = "Alter";
            // 
            // P218
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(dropGeschlecht);
            Controls.Add(dropKommu);
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(tbAlter);
            Controls.Add(tbJahr);
            Controls.Add(tbNr);
            Controls.Add(tbErläuterungen);
            Controls.Add(grpAnm);
            Controls.Add(label1);
            Controls.Add(numBeratungszeit);
            Controls.Add(dropErwerb);
            Controls.Add(dropVerhütung);
            Controls.Add(dropStand);
            Controls.Add(dropStaat);
            Name = "P218";
            Size = new Size(500, 590);
            Load += P218_Load;
            ((System.ComponentModel.ISupportInitialize)numBeratungszeit).EndInit();
            grpAnm.ResumeLayout(false);
            grpAnm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numBeratungszeit;
        private DropDown dropStaat;
        private GroupBox grpAnm;
        private CheckBox cbAndere;
        private CheckBox cbStraft;
        private CheckBox cbFamilie;
        private CheckBox cbPartn;
        private CheckBox cbGeld;
        private CheckBox cbMisshand;
        private CheckBox cbKörpBehind;
        private CheckBox cbSucht;
        private CheckBox cbPsychosen;
        private CheckBox cbSexuell;
        private CheckBox cbSuizid;
        private CheckBox cbTrennung;
        private CheckBox cbPsychisch;
        private CheckBox chKrankTod;
        private CheckBox cbKörper;
        private DropDown dropStand;
        private DropDown dropVerhütung;
        private DropDown dropErwerb;
        private CheckBox checkBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox6;
        private RJTextBox tbErläuterungen;
        private RJTextBox tbNr;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private Panel panel4;
        private DropDown dropKommu;
        private RJTextBox tbJahr;
        private DropDown dropGeschlecht;
        private RJTextBox tbAlter;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label6;
    }
}
