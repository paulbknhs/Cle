﻿using CDMS_Lebensberatung.UserControls;

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
            this.dropStaat = new DropDown();
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
            this.dropStand = new DropDown();
            this.dropVerhütung = new DropDown();
            this.dropErwerb = new DropDown();
            this.tbErläuterungen = new RJTextBox();
            this.tbLaufnummer = new RJTextBox();
            this.buttonSave = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleTelefonberatung = new RJCodeAdvance.RJControls.RJToggleButton();
            this.tbAlter = new RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratungszeit)).BeginInit();
            this.grpAnm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 95);
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
            this.numBeratungszeit.Location = new System.Drawing.Point(260, 91);
            this.numBeratungszeit.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numBeratungszeit.Name = "numBeratungszeit";
            this.numBeratungszeit.Size = new System.Drawing.Size(70, 23);
            this.numBeratungszeit.TabIndex = 12;
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
            this.dropStaat.Location = new System.Drawing.Point(40, 139);
            this.dropStaat.Margin = new System.Windows.Forms.Padding(10);
            this.dropStaat.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStaat.Name = "dropStaat";
            this.dropStaat.Padding = new System.Windows.Forms.Padding(1);
            this.dropStaat.Size = new System.Drawing.Size(200, 32);
            this.dropStaat.TabIndex = 11;
            this.dropStaat.Texts = "";
            // 
            // grpAnm
            // 
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
            this.grpAnm.Location = new System.Drawing.Point(40, 236);
            this.grpAnm.Name = "grpAnm";
            this.grpAnm.Padding = new System.Windows.Forms.Padding(5);
            this.grpAnm.Size = new System.Drawing.Size(420, 299);
            this.grpAnm.TabIndex = 14;
            this.grpAnm.TabStop = false;
            this.grpAnm.Text = "Abbruchsgründe";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(8, 274);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(106, 19);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Keine Angaben";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(231, 249);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 19);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Sonstige Gründe";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(231, 199);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(147, 19);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Psychische Gesundheit";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbAndere
            // 
            this.cbAndere.AutoSize = true;
            this.cbAndere.Location = new System.Drawing.Point(231, 124);
            this.cbAndere.Name = "cbAndere";
            this.cbAndere.Size = new System.Drawing.Size(167, 19);
            this.cbAndere.TabIndex = 0;
            this.cbAndere.Text = "Körperliche Überforderung";
            this.cbAndere.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(231, 224);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(164, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Drohende Bhd. des Kindes";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(231, 174);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Körperliche Gesundheit";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbStraft
            // 
            this.cbStraft.AutoSize = true;
            this.cbStraft.Location = new System.Drawing.Point(231, 99);
            this.cbStraft.Name = "cbStraft";
            this.cbStraft.Size = new System.Drawing.Size(56, 19);
            this.cbStraft.TabIndex = 0;
            this.cbStraft.Text = "Zu alt";
            this.cbStraft.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(231, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Psychische Überforderung";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbFamilie
            // 
            this.cbFamilie.AutoSize = true;
            this.cbFamilie.Location = new System.Drawing.Point(231, 74);
            this.cbFamilie.Name = "cbFamilie";
            this.cbFamilie.Size = new System.Drawing.Size(67, 19);
            this.cbFamilie.TabIndex = 0;
            this.cbFamilie.Text = "Zu jung";
            this.cbFamilie.UseVisualStyleBackColor = true;
            // 
            // cbPartn
            // 
            this.cbPartn.AutoSize = true;
            this.cbPartn.Location = new System.Drawing.Point(231, 49);
            this.cbPartn.Name = "cbPartn";
            this.cbPartn.Size = new System.Drawing.Size(117, 19);
            this.cbPartn.TabIndex = 0;
            this.cbPartn.Text = "Schule / Studium";
            this.cbPartn.UseVisualStyleBackColor = true;
            // 
            // cbGeld
            // 
            this.cbGeld.AutoSize = true;
            this.cbGeld.Location = new System.Drawing.Point(231, 24);
            this.cbGeld.Name = "cbGeld";
            this.cbGeld.Size = new System.Drawing.Size(131, 19);
            this.cbGeld.TabIndex = 0;
            this.cbGeld.Text = "Soziale Unsicherheit";
            this.cbGeld.UseVisualStyleBackColor = true;
            // 
            // cbMisshand
            // 
            this.cbMisshand.AutoSize = true;
            this.cbMisshand.Location = new System.Drawing.Point(8, 224);
            this.cbMisshand.Name = "cbMisshand";
            this.cbMisshand.Size = new System.Drawing.Size(113, 19);
            this.cbMisshand.TabIndex = 0;
            this.cbMisshand.Text = "Erhalt des Stand.";
            this.cbMisshand.UseVisualStyleBackColor = true;
            // 
            // cbKörpBehind
            // 
            this.cbKörpBehind.AutoSize = true;
            this.cbKörpBehind.Location = new System.Drawing.Point(8, 174);
            this.cbKörpBehind.Name = "cbKörpBehind";
            this.cbKörpBehind.Size = new System.Drawing.Size(116, 19);
            this.cbKörpBehind.TabIndex = 0;
            this.cbKörpBehind.Text = "Familiäre Gründe";
            this.cbKörpBehind.UseVisualStyleBackColor = true;
            // 
            // cbSucht
            // 
            this.cbSucht.AutoSize = true;
            this.cbSucht.Location = new System.Drawing.Point(8, 124);
            this.cbSucht.Name = "cbSucht";
            this.cbSucht.Size = new System.Drawing.Size(120, 19);
            this.cbSucht.TabIndex = 0;
            this.cbSucht.Text = "Abl. d. d. Kindesv.";
            this.cbSucht.UseVisualStyleBackColor = true;
            // 
            // cbPsychosen
            // 
            this.cbPsychosen.AutoSize = true;
            this.cbPsychosen.Location = new System.Drawing.Point(8, 99);
            this.cbPsychosen.Name = "cbPsychosen";
            this.cbPsychosen.Size = new System.Drawing.Size(107, 19);
            this.cbPsychosen.TabIndex = 0;
            this.cbPsychosen.Text = "Alleinerziehend";
            this.cbPsychosen.UseVisualStyleBackColor = true;
            // 
            // cbSexuell
            // 
            this.cbSexuell.AutoSize = true;
            this.cbSexuell.Location = new System.Drawing.Point(8, 249);
            this.cbSexuell.Name = "cbSexuell";
            this.cbSexuell.Size = new System.Drawing.Size(121, 19);
            this.cbSexuell.TabIndex = 0;
            this.cbSexuell.Text = "Berufliche Gründe";
            this.cbSexuell.UseVisualStyleBackColor = true;
            // 
            // cbSuizid
            // 
            this.cbSuizid.AutoSize = true;
            this.cbSuizid.Location = new System.Drawing.Point(8, 74);
            this.cbSuizid.Name = "cbSuizid";
            this.cbSuizid.Size = new System.Drawing.Size(123, 19);
            this.cbSuizid.TabIndex = 0;
            this.cbSuizid.Text = "Finanzielle Gründe";
            this.cbSuizid.UseVisualStyleBackColor = true;
            // 
            // cbTrennung
            // 
            this.cbTrennung.AutoSize = true;
            this.cbTrennung.Location = new System.Drawing.Point(8, 199);
            this.cbTrennung.Name = "cbTrennung";
            this.cbTrennung.Size = new System.Drawing.Size(104, 19);
            this.cbTrennung.TabIndex = 0;
            this.cbTrennung.Text = "Wohnsituation";
            this.cbTrennung.UseVisualStyleBackColor = true;
            // 
            // cbPsychisch
            // 
            this.cbPsychisch.AutoSize = true;
            this.cbPsychisch.Location = new System.Drawing.Point(8, 49);
            this.cbPsychisch.Name = "cbPsychisch";
            this.cbPsychisch.Size = new System.Drawing.Size(158, 19);
            this.cbPsychisch.TabIndex = 0;
            this.cbPsychisch.Text = "Abgeschlossene Planung";
            this.cbPsychisch.UseVisualStyleBackColor = true;
            // 
            // chKrankTod
            // 
            this.chKrankTod.AutoSize = true;
            this.chKrankTod.Location = new System.Drawing.Point(8, 149);
            this.chKrankTod.Name = "chKrankTod";
            this.chKrankTod.Size = new System.Drawing.Size(96, 19);
            this.chKrankTod.TabIndex = 0;
            this.chKrankTod.Text = "Partnerschaft";
            this.chKrankTod.UseVisualStyleBackColor = true;
            // 
            // cbKörper
            // 
            this.cbKörper.AutoSize = true;
            this.cbKörper.Location = new System.Drawing.Point(8, 24);
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
            this.dropStand.Location = new System.Drawing.Point(40, 191);
            this.dropStand.Margin = new System.Windows.Forms.Padding(10);
            this.dropStand.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropStand.Name = "dropStand";
            this.dropStand.Padding = new System.Windows.Forms.Padding(1);
            this.dropStand.Size = new System.Drawing.Size(200, 32);
            this.dropStand.TabIndex = 11;
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
            this.dropVerhütung.Location = new System.Drawing.Point(260, 191);
            this.dropVerhütung.Margin = new System.Windows.Forms.Padding(10);
            this.dropVerhütung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropVerhütung.Name = "dropVerhütung";
            this.dropVerhütung.Padding = new System.Windows.Forms.Padding(1);
            this.dropVerhütung.Size = new System.Drawing.Size(200, 32);
            this.dropVerhütung.TabIndex = 11;
            this.dropVerhütung.Texts = "";
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
            this.dropErwerb.Location = new System.Drawing.Point(260, 139);
            this.dropErwerb.Margin = new System.Windows.Forms.Padding(10);
            this.dropErwerb.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropErwerb.Name = "dropErwerb";
            this.dropErwerb.Padding = new System.Windows.Forms.Padding(1);
            this.dropErwerb.Size = new System.Drawing.Size(200, 32);
            this.dropErwerb.TabIndex = 11;
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
            this.tbErläuterungen.Location = new System.Drawing.Point(40, 548);
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
            // tbLaufnummer
            // 
            this.tbLaufnummer.BackColor = System.Drawing.SystemColors.Window;
            this.tbLaufnummer.BorderColor = System.Drawing.Color.Black;
            this.tbLaufnummer.BorderFocusColor = System.Drawing.Color.Green;
            this.tbLaufnummer.BorderRadius = 0;
            this.tbLaufnummer.BorderSize = 1;
            this.tbLaufnummer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLaufnummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLaufnummer.Location = new System.Drawing.Point(260, 37);
            this.tbLaufnummer.Margin = new System.Windows.Forms.Padding(10);
            this.tbLaufnummer.Multiline = false;
            this.tbLaufnummer.Name = "tbLaufnummer";
            this.tbLaufnummer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbLaufnummer.PasswordChar = false;
            this.tbLaufnummer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLaufnummer.PlaceholderText = "Laufende Nummer";
            this.tbLaufnummer.Size = new System.Drawing.Size(200, 32);
            this.tbLaufnummer.TabIndex = 15;
            this.tbLaufnummer.Texts = "";
            this.tbLaufnummer.UnderlinedStyle = true;
            // 
            // buttonSave
            // 
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
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefonische Beratung";
            // 
            // toggleTelefonberatung
            // 
            this.toggleTelefonberatung.AutoSize = true;
            this.toggleTelefonberatung.Location = new System.Drawing.Point(40, 91);
            this.toggleTelefonberatung.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleTelefonberatung.Name = "toggleTelefonberatung";
            this.toggleTelefonberatung.OffBackColor = System.Drawing.Color.Gray;
            this.toggleTelefonberatung.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleTelefonberatung.OnBackColor = System.Drawing.Color.Green;
            this.toggleTelefonberatung.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleTelefonberatung.Size = new System.Drawing.Size(45, 22);
            this.toggleTelefonberatung.TabIndex = 17;
            this.toggleTelefonberatung.UseVisualStyleBackColor = true;
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
            this.tbAlter.Location = new System.Drawing.Point(40, 37);
            this.tbAlter.Margin = new System.Windows.Forms.Padding(10);
            this.tbAlter.Multiline = false;
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbAlter.PasswordChar = false;
            this.tbAlter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbAlter.PlaceholderText = "Alter";
            this.tbAlter.Size = new System.Drawing.Size(200, 32);
            this.tbAlter.TabIndex = 15;
            this.tbAlter.Texts = "";
            this.tbAlter.UnderlinedStyle = true;
            // 
            // P218
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toggleTelefonberatung);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbAlter);
            this.Controls.Add(this.tbLaufnummer);
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
        private RJTextBox tbLaufnummer;
        private RJCodeAdvance.RJControls.RJButton buttonSave;
        private Label label2;
        private RJCodeAdvance.RJControls.RJToggleButton toggleTelefonberatung;
        private RJTextBox tbAlter;
    }
}