using CDMS_Lebensberatung.UserControls;

namespace CDMS_Lebensberatung.AddSpecific
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
            this.label1 = new System.Windows.Forms.Label();
            this.numBeratungszeit = new System.Windows.Forms.NumericUpDown();
            this.dropStaat = new CDMS_Lebensberatung.UserControls.DropDown();
            this.grpAnm = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbAndere = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbStraft = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbFamilie = new System.Windows.Forms.CheckBox();
            this.cbPartn = new System.Windows.Forms.CheckBox();
            this.cbGeld = new System.Windows.Forms.CheckBox();
            this.cbMisshand = new System.Windows.Forms.CheckBox();
            this.cbKörpBehind = new System.Windows.Forms.CheckBox();
            this.cbSucht = new System.Windows.Forms.CheckBox();
            this.cbPsychosen = new System.Windows.Forms.CheckBox();
            this.cbSexuell = new System.Windows.Forms.CheckBox();
            this.cbSuizid = new System.Windows.Forms.CheckBox();
            this.cbTrennung = new System.Windows.Forms.CheckBox();
            this.cbPsychisch = new System.Windows.Forms.CheckBox();
            this.chKrankTod = new System.Windows.Forms.CheckBox();
            this.cbKörper = new System.Windows.Forms.CheckBox();
            this.dropStand = new CDMS_Lebensberatung.UserControls.DropDown();
            this.dropVerhütung = new CDMS_Lebensberatung.UserControls.DropDown();
            this.dropErwerb = new CDMS_Lebensberatung.UserControls.DropDown();
            this.tbErläuterungen = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.tbNr = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dropKommu = new CDMS_Lebensberatung.UserControls.DropDown();
            this.tbJahr = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.dropGeschlecht = new CDMS_Lebensberatung.UserControls.DropDown();
            this.tbAlter = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).BeginInit();
            this.grpAnm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 97);
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
            this.numBeratungszeit.Location = new System.Drawing.Point(263, 94);
            this.numBeratungszeit.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numBeratungszeit.Name = "numBeratungszeit";
            this.numBeratungszeit.Size = new System.Drawing.Size(70, 23);
            this.numBeratungszeit.TabIndex = 4;
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
            this.dropStaat.Location = new System.Drawing.Point(40, 198);
            this.dropStaat.Margin = new System.Windows.Forms.Padding(10);
            this.dropStaat.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStaat.Name = "dropStaat";
            this.dropStaat.Padding = new System.Windows.Forms.Padding(1);
            this.dropStaat.Size = new System.Drawing.Size(200, 32);
            this.dropStaat.TabIndex = 7;
            this.dropStaat.Texts = "";
            // 
            // grpAnm
            // 
            this.grpAnm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAnm.Controls.Add(this.checkBox6);
            this.grpAnm.Controls.Add(this.checkBox5);
            this.grpAnm.Controls.Add(this.checkBox3);
            this.grpAnm.Controls.Add(this.cbAndere);
            this.grpAnm.Controls.Add(this.checkBox4);
            this.grpAnm.Controls.Add(this.checkBox2);
            this.grpAnm.Controls.Add(this.cbStraft);
            this.grpAnm.Controls.Add(this.checkBox1);
            this.grpAnm.Controls.Add(this.cbFamilie);
            this.grpAnm.Controls.Add(this.cbPartn);
            this.grpAnm.Controls.Add(this.cbGeld);
            this.grpAnm.Controls.Add(this.cbMisshand);
            this.grpAnm.Controls.Add(this.cbKörpBehind);
            this.grpAnm.Controls.Add(this.cbSucht);
            this.grpAnm.Controls.Add(this.cbPsychosen);
            this.grpAnm.Controls.Add(this.cbSexuell);
            this.grpAnm.Controls.Add(this.cbSuizid);
            this.grpAnm.Controls.Add(this.cbTrennung);
            this.grpAnm.Controls.Add(this.cbPsychisch);
            this.grpAnm.Controls.Add(this.chKrankTod);
            this.grpAnm.Controls.Add(this.cbKörper);
            this.grpAnm.Location = new System.Drawing.Point(40, 278);
            this.grpAnm.Name = "grpAnm";
            this.grpAnm.Padding = new System.Windows.Forms.Padding(5);
            this.grpAnm.Size = new System.Drawing.Size(420, 255);
            this.grpAnm.TabIndex = 11;
            this.grpAnm.TabStop = false;
            this.grpAnm.Text = "Abbruchsgründe";
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 229);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(106, 19);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Keine Angaben";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(225, 229);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 19);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Sonstige Gründe";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(225, 181);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(147, 19);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Psychische Gesundheit";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbAndere
            // 
            this.cbAndere.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAndere.AutoSize = true;
            this.cbAndere.Location = new System.Drawing.Point(225, 109);
            this.cbAndere.Margin = new System.Windows.Forms.Padding(1);
            this.cbAndere.Name = "cbAndere";
            this.cbAndere.Size = new System.Drawing.Size(167, 19);
            this.cbAndere.TabIndex = 0;
            this.cbAndere.Text = "Körperliche Überforderung";
            this.cbAndere.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(225, 205);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(164, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Drohende Bhd. des Kindes";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(225, 157);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Körperliche Gesundheit";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbStraft
            // 
            this.cbStraft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbStraft.AutoSize = true;
            this.cbStraft.Location = new System.Drawing.Point(225, 85);
            this.cbStraft.Margin = new System.Windows.Forms.Padding(1);
            this.cbStraft.Name = "cbStraft";
            this.cbStraft.Size = new System.Drawing.Size(56, 19);
            this.cbStraft.TabIndex = 0;
            this.cbStraft.Text = "Zu alt";
            this.cbStraft.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 133);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Psychische Überforderung";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbFamilie
            // 
            this.cbFamilie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbFamilie.AutoSize = true;
            this.cbFamilie.Location = new System.Drawing.Point(225, 61);
            this.cbFamilie.Margin = new System.Windows.Forms.Padding(1);
            this.cbFamilie.Name = "cbFamilie";
            this.cbFamilie.Size = new System.Drawing.Size(67, 19);
            this.cbFamilie.TabIndex = 0;
            this.cbFamilie.Text = "Zu jung";
            this.cbFamilie.UseVisualStyleBackColor = true;
            // 
            // cbPartn
            // 
            this.cbPartn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbPartn.AutoSize = true;
            this.cbPartn.Location = new System.Drawing.Point(225, 37);
            this.cbPartn.Margin = new System.Windows.Forms.Padding(1);
            this.cbPartn.Name = "cbPartn";
            this.cbPartn.Size = new System.Drawing.Size(117, 19);
            this.cbPartn.TabIndex = 0;
            this.cbPartn.Text = "Schule / Studium";
            this.cbPartn.UseVisualStyleBackColor = true;
            // 
            // cbGeld
            // 
            this.cbGeld.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbGeld.AutoSize = true;
            this.cbGeld.Location = new System.Drawing.Point(225, 13);
            this.cbGeld.Margin = new System.Windows.Forms.Padding(1);
            this.cbGeld.Name = "cbGeld";
            this.cbGeld.Size = new System.Drawing.Size(131, 19);
            this.cbGeld.TabIndex = 0;
            this.cbGeld.Text = "Soziale Unsicherheit";
            this.cbGeld.UseVisualStyleBackColor = true;
            // 
            // cbMisshand
            // 
            this.cbMisshand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMisshand.AutoSize = true;
            this.cbMisshand.Location = new System.Drawing.Point(6, 187);
            this.cbMisshand.Margin = new System.Windows.Forms.Padding(1);
            this.cbMisshand.Name = "cbMisshand";
            this.cbMisshand.Size = new System.Drawing.Size(113, 19);
            this.cbMisshand.TabIndex = 0;
            this.cbMisshand.Text = "Erhalt des Stand.";
            this.cbMisshand.UseVisualStyleBackColor = true;
            // 
            // cbKörpBehind
            // 
            this.cbKörpBehind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbKörpBehind.AutoSize = true;
            this.cbKörpBehind.Location = new System.Drawing.Point(6, 145);
            this.cbKörpBehind.Margin = new System.Windows.Forms.Padding(1);
            this.cbKörpBehind.Name = "cbKörpBehind";
            this.cbKörpBehind.Size = new System.Drawing.Size(116, 19);
            this.cbKörpBehind.TabIndex = 0;
            this.cbKörpBehind.Text = "Familiäre Gründe";
            this.cbKörpBehind.UseVisualStyleBackColor = true;
            // 
            // cbSucht
            // 
            this.cbSucht.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbSucht.AutoSize = true;
            this.cbSucht.Location = new System.Drawing.Point(6, 103);
            this.cbSucht.Margin = new System.Windows.Forms.Padding(1);
            this.cbSucht.Name = "cbSucht";
            this.cbSucht.Size = new System.Drawing.Size(120, 19);
            this.cbSucht.TabIndex = 0;
            this.cbSucht.Text = "Abl. d. d. Kindesv.";
            this.cbSucht.UseVisualStyleBackColor = true;
            // 
            // cbPsychosen
            // 
            this.cbPsychosen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbPsychosen.AutoSize = true;
            this.cbPsychosen.Location = new System.Drawing.Point(6, 82);
            this.cbPsychosen.Margin = new System.Windows.Forms.Padding(1);
            this.cbPsychosen.Name = "cbPsychosen";
            this.cbPsychosen.Size = new System.Drawing.Size(107, 19);
            this.cbPsychosen.TabIndex = 0;
            this.cbPsychosen.Text = "Alleinerziehend";
            this.cbPsychosen.UseVisualStyleBackColor = true;
            // 
            // cbSexuell
            // 
            this.cbSexuell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbSexuell.AutoSize = true;
            this.cbSexuell.Location = new System.Drawing.Point(6, 208);
            this.cbSexuell.Margin = new System.Windows.Forms.Padding(1);
            this.cbSexuell.Name = "cbSexuell";
            this.cbSexuell.Size = new System.Drawing.Size(121, 19);
            this.cbSexuell.TabIndex = 0;
            this.cbSexuell.Text = "Berufliche Gründe";
            this.cbSexuell.UseVisualStyleBackColor = true;
            // 
            // cbSuizid
            // 
            this.cbSuizid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbSuizid.AutoSize = true;
            this.cbSuizid.Location = new System.Drawing.Point(6, 61);
            this.cbSuizid.Margin = new System.Windows.Forms.Padding(1);
            this.cbSuizid.Name = "cbSuizid";
            this.cbSuizid.Size = new System.Drawing.Size(123, 19);
            this.cbSuizid.TabIndex = 0;
            this.cbSuizid.Text = "Finanzielle Gründe";
            this.cbSuizid.UseVisualStyleBackColor = true;
            // 
            // cbTrennung
            // 
            this.cbTrennung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbTrennung.AutoSize = true;
            this.cbTrennung.Location = new System.Drawing.Point(6, 166);
            this.cbTrennung.Margin = new System.Windows.Forms.Padding(1);
            this.cbTrennung.Name = "cbTrennung";
            this.cbTrennung.Size = new System.Drawing.Size(104, 19);
            this.cbTrennung.TabIndex = 0;
            this.cbTrennung.Text = "Wohnsituation";
            this.cbTrennung.UseVisualStyleBackColor = true;
            // 
            // cbPsychisch
            // 
            this.cbPsychisch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbPsychisch.AutoSize = true;
            this.cbPsychisch.Location = new System.Drawing.Point(6, 40);
            this.cbPsychisch.Margin = new System.Windows.Forms.Padding(1);
            this.cbPsychisch.Name = "cbPsychisch";
            this.cbPsychisch.Size = new System.Drawing.Size(158, 19);
            this.cbPsychisch.TabIndex = 0;
            this.cbPsychisch.Text = "Abgeschlossene Planung";
            this.cbPsychisch.UseVisualStyleBackColor = true;
            // 
            // chKrankTod
            // 
            this.chKrankTod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chKrankTod.AutoSize = true;
            this.chKrankTod.Location = new System.Drawing.Point(6, 124);
            this.chKrankTod.Margin = new System.Windows.Forms.Padding(1);
            this.chKrankTod.Name = "chKrankTod";
            this.chKrankTod.Size = new System.Drawing.Size(96, 19);
            this.chKrankTod.TabIndex = 0;
            this.chKrankTod.Text = "Partnerschaft";
            this.chKrankTod.UseVisualStyleBackColor = true;
            // 
            // cbKörper
            // 
            this.cbKörper.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbKörper.AutoSize = true;
            this.cbKörper.Location = new System.Drawing.Point(6, 19);
            this.cbKörper.Margin = new System.Windows.Forms.Padding(1);
            this.cbKörper.Name = "cbKörper";
            this.cbKörper.Size = new System.Drawing.Size(172, 19);
            this.cbKörper.TabIndex = 0;
            this.cbKörper.Text = "Generell kein Kinderwunsch";
            this.cbKörper.UseVisualStyleBackColor = true;
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
            this.dropStand.Location = new System.Drawing.Point(40, 240);
            this.dropStand.Margin = new System.Windows.Forms.Padding(10);
            this.dropStand.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStand.Name = "dropStand";
            this.dropStand.Padding = new System.Windows.Forms.Padding(1);
            this.dropStand.Size = new System.Drawing.Size(200, 32);
            this.dropStand.TabIndex = 9;
            this.dropStand.Texts = "";
            // 
            // dropVerhütung
            // 
            this.dropVerhütung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropVerhütung.BorderColor = System.Drawing.Color.Black;
            this.dropVerhütung.BorderSize = 1;
            this.dropVerhütung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropVerhütung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropVerhütung.ForeColor = System.Drawing.Color.DimGray;
            this.dropVerhütung.IconColor = System.Drawing.Color.Black;
            this.dropVerhütung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropVerhütung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropVerhütung.Location = new System.Drawing.Point(263, 240);
            this.dropVerhütung.Margin = new System.Windows.Forms.Padding(10);
            this.dropVerhütung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropVerhütung.Name = "dropVerhütung";
            this.dropVerhütung.Padding = new System.Windows.Forms.Padding(1);
            this.dropVerhütung.Size = new System.Drawing.Size(200, 32);
            this.dropVerhütung.TabIndex = 10;
            this.dropVerhütung.Texts = "";
            // 
            // dropErwerb
            // 
            this.dropErwerb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropErwerb.BorderColor = System.Drawing.Color.Black;
            this.dropErwerb.BorderSize = 1;
            this.dropErwerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropErwerb.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropErwerb.ForeColor = System.Drawing.Color.DimGray;
            this.dropErwerb.IconColor = System.Drawing.Color.Black;
            this.dropErwerb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropErwerb.ListTextColor = System.Drawing.Color.DimGray;
            this.dropErwerb.Location = new System.Drawing.Point(263, 198);
            this.dropErwerb.Margin = new System.Windows.Forms.Padding(10);
            this.dropErwerb.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropErwerb.Name = "dropErwerb";
            this.dropErwerb.Padding = new System.Windows.Forms.Padding(1);
            this.dropErwerb.Size = new System.Drawing.Size(200, 32);
            this.dropErwerb.TabIndex = 8;
            this.dropErwerb.Texts = "";
            // 
            // tbErläuterungen
            // 
            this.tbErläuterungen.BackColor = System.Drawing.SystemColors.Window;
            this.tbErläuterungen.BorderColor = System.Drawing.Color.Black;
            this.tbErläuterungen.BorderFocusColor = System.Drawing.Color.Green;
            this.tbErläuterungen.BorderRadius = 0;
            this.tbErläuterungen.BorderSize = 1;
            this.tbErläuterungen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbErläuterungen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbErläuterungen.Location = new System.Drawing.Point(40, 538);
            this.tbErläuterungen.Margin = new System.Windows.Forms.Padding(10);
            this.tbErläuterungen.Multiline = true;
            this.tbErläuterungen.Name = "tbErläuterungen";
            this.tbErläuterungen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbErläuterungen.PasswordChar = false;
            this.tbErläuterungen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbErläuterungen.PlaceholderText = "Erläuterung zu Sonstiges";
            this.tbErläuterungen.Size = new System.Drawing.Size(200, 32);
            this.tbErläuterungen.TabIndex = 6;
            this.tbErläuterungen.Texts = "";
            this.tbErläuterungen.UnderlinedStyle = true;
            // 
            // tbNr
            // 
            this.tbNr.BackColor = System.Drawing.SystemColors.Window;
            this.tbNr.BorderColor = System.Drawing.Color.Black;
            this.tbNr.BorderFocusColor = System.Drawing.Color.Green;
            this.tbNr.BorderRadius = 0;
            this.tbNr.BorderSize = 1;
            this.tbNr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNr.Location = new System.Drawing.Point(40, 89);
            this.tbNr.Margin = new System.Windows.Forms.Padding(10);
            this.tbNr.Multiline = false;
            this.tbNr.Name = "tbNr";
            this.tbNr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNr.PasswordChar = false;
            this.tbNr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNr.PlaceholderText = "Laufende Nummer";
            this.tbNr.Size = new System.Drawing.Size(200, 32);
            this.tbNr.TabIndex = 3;
            this.tbNr.Texts = "";
            this.tbNr.UnderlinedStyle = true;
            this.tbNr.Enter += new System.EventHandler(this.OnTextBoxEnter);
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
            this.btnSave.Location = new System.Drawing.Point(253, 538);
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
            this.panel4.Location = new System.Drawing.Point(253, 538);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 43);
            this.panel4.TabIndex = 24;
            this.panel4.Click += new System.EventHandler(this.OnButtonSave);
            // 
            // dropKommu
            // 
            this.dropKommu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropKommu.BorderColor = System.Drawing.Color.Black;
            this.dropKommu.BorderSize = 1;
            this.dropKommu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropKommu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropKommu.ForeColor = System.Drawing.Color.DimGray;
            this.dropKommu.IconColor = System.Drawing.Color.Black;
            this.dropKommu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropKommu.ListTextColor = System.Drawing.Color.DimGray;
            this.dropKommu.Location = new System.Drawing.Point(263, 155);
            this.dropKommu.Margin = new System.Windows.Forms.Padding(10);
            this.dropKommu.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropKommu.Name = "dropKommu";
            this.dropKommu.Padding = new System.Windows.Forms.Padding(1);
            this.dropKommu.Size = new System.Drawing.Size(200, 32);
            this.dropKommu.TabIndex = 6;
            this.dropKommu.Texts = "";
            // 
            // tbJahr
            // 
            this.tbJahr.BackColor = System.Drawing.SystemColors.Window;
            this.tbJahr.BorderColor = System.Drawing.Color.Black;
            this.tbJahr.BorderFocusColor = System.Drawing.Color.Green;
            this.tbJahr.BorderRadius = 0;
            this.tbJahr.BorderSize = 1;
            this.tbJahr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbJahr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbJahr.Location = new System.Drawing.Point(40, 28);
            this.tbJahr.Margin = new System.Windows.Forms.Padding(10);
            this.tbJahr.Multiline = false;
            this.tbJahr.Name = "tbJahr";
            this.tbJahr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbJahr.PasswordChar = false;
            this.tbJahr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbJahr.PlaceholderText = "Jahr";
            this.tbJahr.Size = new System.Drawing.Size(200, 32);
            this.tbJahr.TabIndex = 1;
            this.tbJahr.Texts = "";
            this.tbJahr.UnderlinedStyle = true;
            this.tbJahr.Enter += new System.EventHandler(this.OnTextBoxEnter);
            // 
            // dropGeschlecht
            // 
            this.dropGeschlecht.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropGeschlecht.BorderColor = System.Drawing.Color.Black;
            this.dropGeschlecht.BorderSize = 1;
            this.dropGeschlecht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropGeschlecht.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropGeschlecht.ForeColor = System.Drawing.Color.DimGray;
            this.dropGeschlecht.IconColor = System.Drawing.Color.Black;
            this.dropGeschlecht.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropGeschlecht.ListTextColor = System.Drawing.Color.DimGray;
            this.dropGeschlecht.Location = new System.Drawing.Point(40, 155);
            this.dropGeschlecht.Margin = new System.Windows.Forms.Padding(10);
            this.dropGeschlecht.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropGeschlecht.Name = "dropGeschlecht";
            this.dropGeschlecht.Padding = new System.Windows.Forms.Padding(1);
            this.dropGeschlecht.Size = new System.Drawing.Size(200, 32);
            this.dropGeschlecht.TabIndex = 5;
            this.dropGeschlecht.Texts = "";
            // 
            // tbAlter
            // 
            this.tbAlter.BackColor = System.Drawing.SystemColors.Window;
            this.tbAlter.BorderColor = System.Drawing.Color.Black;
            this.tbAlter.BorderFocusColor = System.Drawing.Color.Green;
            this.tbAlter.BorderRadius = 0;
            this.tbAlter.BorderSize = 1;
            this.tbAlter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAlter.Location = new System.Drawing.Point(263, 28);
            this.tbAlter.Margin = new System.Windows.Forms.Padding(10);
            this.tbAlter.Multiline = false;
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbAlter.PasswordChar = false;
            this.tbAlter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbAlter.PlaceholderText = "Alter";
            this.tbAlter.Size = new System.Drawing.Size(197, 32);
            this.tbAlter.TabIndex = 2;
            this.tbAlter.Texts = "";
            this.tbAlter.UnderlinedStyle = true;
            this.tbAlter.Enter += new System.EventHandler(this.OnTextBoxEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(40, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Erläuterung zu Sonstiges";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Laufende Nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(40, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Jahr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(263, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Alter";
            // 
            // P218
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropGeschlecht);
            this.Controls.Add(this.dropKommu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tbAlter);
            this.Controls.Add(this.tbJahr);
            this.Controls.Add(this.tbNr);
            this.Controls.Add(this.tbErläuterungen);
            this.Controls.Add(this.grpAnm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBeratungszeit);
            this.Controls.Add(this.dropErwerb);
            this.Controls.Add(this.dropVerhütung);
            this.Controls.Add(this.dropStand);
            this.Controls.Add(this.dropStaat);
            this.Name = "P218";
            this.Size = new System.Drawing.Size(500, 590);
            this.Load += new System.EventHandler(this.P218_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).EndInit();
            this.grpAnm.ResumeLayout(false);
            this.grpAnm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
