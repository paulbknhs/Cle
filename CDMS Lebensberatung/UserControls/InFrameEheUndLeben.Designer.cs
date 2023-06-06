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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropLeistung = new CDMS_Lebensberatung.UserControls.DropDown();
            this.dropWirtschaft = new CDMS_Lebensberatung.UserControls.DropDown();
            this.groupAnmeldung = new System.Windows.Forms.GroupBox();
            this.cbAndere = new System.Windows.Forms.CheckBox();
            this.cbStraft = new System.Windows.Forms.CheckBox();
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
            this.tbErläuterung = new CDMS_Lebensberatung.UserControls.RJTextBox();
            this.togglePartnerschaft = new RJCodeAdvance.RJControls.RJToggleButton();
            this.toggleKinder = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleSonstige = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleUnbekannt = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gridStunden = new System.Windows.Forms.DataGridView();
            this.Art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stunden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupAnmeldung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStunden)).BeginInit();
            this.SuspendLayout();
            // 
            // dropLeistung
            // 
            this.dropLeistung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropLeistung.BorderColor = System.Drawing.Color.Black;
            this.dropLeistung.BorderSize = 1;
            this.dropLeistung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropLeistung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropLeistung.ForeColor = System.Drawing.Color.DimGray;
            this.dropLeistung.IconColor = System.Drawing.Color.Black;
            this.dropLeistung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropLeistung.ListTextColor = System.Drawing.Color.DimGray;
            this.dropLeistung.Location = new System.Drawing.Point(38, 85);
            this.dropLeistung.Margin = new System.Windows.Forms.Padding(10);
            this.dropLeistung.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropLeistung.Name = "dropLeistung";
            this.dropLeistung.Padding = new System.Windows.Forms.Padding(1);
            this.dropLeistung.Size = new System.Drawing.Size(200, 32);
            this.dropLeistung.TabIndex = 3;
            this.dropLeistung.Texts = "";
            // 
            // dropWirtschaft
            // 
            this.dropWirtschaft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropWirtschaft.BorderColor = System.Drawing.Color.Black;
            this.dropWirtschaft.BorderSize = 1;
            this.dropWirtschaft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropWirtschaft.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropWirtschaft.ForeColor = System.Drawing.Color.DimGray;
            this.dropWirtschaft.IconColor = System.Drawing.Color.Black;
            this.dropWirtschaft.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropWirtschaft.ListTextColor = System.Drawing.Color.DimGray;
            this.dropWirtschaft.Location = new System.Drawing.Point(258, 85);
            this.dropWirtschaft.Margin = new System.Windows.Forms.Padding(10);
            this.dropWirtschaft.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropWirtschaft.Name = "dropWirtschaft";
            this.dropWirtschaft.Padding = new System.Windows.Forms.Padding(1);
            this.dropWirtschaft.Size = new System.Drawing.Size(200, 32);
            this.dropWirtschaft.TabIndex = 3;
            this.dropWirtschaft.Texts = "";
            // 
            // groupAnmeldung
            // 
            this.groupAnmeldung.Controls.Add(this.cbAndere);
            this.groupAnmeldung.Controls.Add(this.cbStraft);
            this.groupAnmeldung.Controls.Add(this.cbFamilie);
            this.groupAnmeldung.Controls.Add(this.cbPartn);
            this.groupAnmeldung.Controls.Add(this.cbGeld);
            this.groupAnmeldung.Controls.Add(this.cbMisshand);
            this.groupAnmeldung.Controls.Add(this.cbKörpBehind);
            this.groupAnmeldung.Controls.Add(this.cbSucht);
            this.groupAnmeldung.Controls.Add(this.cbPsychosen);
            this.groupAnmeldung.Controls.Add(this.cbSexuell);
            this.groupAnmeldung.Controls.Add(this.cbSuizid);
            this.groupAnmeldung.Controls.Add(this.cbTrennung);
            this.groupAnmeldung.Controls.Add(this.cbPsychisch);
            this.groupAnmeldung.Controls.Add(this.chKrankTod);
            this.groupAnmeldung.Controls.Add(this.cbKörper);
            this.groupAnmeldung.Location = new System.Drawing.Point(38, 130);
            this.groupAnmeldung.Name = "groupAnmeldung";
            this.groupAnmeldung.Padding = new System.Windows.Forms.Padding(5);
            this.groupAnmeldung.Size = new System.Drawing.Size(200, 383);
            this.groupAnmeldung.TabIndex = 4;
            this.groupAnmeldung.TabStop = false;
            this.groupAnmeldung.Text = "Anmeldegründe";
            // 
            // cbAndere
            // 
            this.cbAndere.AutoSize = true;
            this.cbAndere.Location = new System.Drawing.Point(8, 356);
            this.cbAndere.Name = "cbAndere";
            this.cbAndere.Size = new System.Drawing.Size(118, 19);
            this.cbAndere.TabIndex = 0;
            this.cbAndere.Text = "Andere Probleme";
            this.cbAndere.UseVisualStyleBackColor = true;
            // 
            // cbStraft
            // 
            this.cbStraft.AutoSize = true;
            this.cbStraft.Location = new System.Drawing.Point(8, 331);
            this.cbStraft.Name = "cbStraft";
            this.cbStraft.Size = new System.Drawing.Size(77, 19);
            this.cbStraft.TabIndex = 0;
            this.cbStraft.Text = "Straftaten";
            this.cbStraft.UseVisualStyleBackColor = true;
            // 
            // cbFamilie
            // 
            this.cbFamilie.AutoSize = true;
            this.cbFamilie.Location = new System.Drawing.Point(8, 306);
            this.cbFamilie.Name = "cbFamilie";
            this.cbFamilie.Size = new System.Drawing.Size(128, 19);
            this.cbFamilie.TabIndex = 0;
            this.cbFamilie.Text = "Familiäre Probleme";
            this.cbFamilie.UseVisualStyleBackColor = true;
            // 
            // cbPartn
            // 
            this.cbPartn.AutoSize = true;
            this.cbPartn.Location = new System.Drawing.Point(8, 281);
            this.cbPartn.Name = "cbPartn";
            this.cbPartn.Size = new System.Drawing.Size(154, 19);
            this.cbPartn.TabIndex = 0;
            this.cbPartn.Text = "Probleme mit Partner*in";
            this.cbPartn.UseVisualStyleBackColor = true;
            // 
            // cbGeld
            // 
            this.cbGeld.AutoSize = true;
            this.cbGeld.Location = new System.Drawing.Point(8, 256);
            this.cbGeld.Name = "cbGeld";
            this.cbGeld.Size = new System.Drawing.Size(93, 19);
            this.cbGeld.TabIndex = 0;
            this.cbGeld.Text = "Geld / Arbeit";
            this.cbGeld.UseVisualStyleBackColor = true;
            // 
            // cbMisshand
            // 
            this.cbMisshand.AutoSize = true;
            this.cbMisshand.Location = new System.Drawing.Point(8, 206);
            this.cbMisshand.Name = "cbMisshand";
            this.cbMisshand.Size = new System.Drawing.Size(164, 19);
            this.cbMisshand.TabIndex = 0;
            this.cbMisshand.Text = "Allgemeine Misshandlung";
            this.cbMisshand.UseVisualStyleBackColor = true;
            // 
            // cbKörpBehind
            // 
            this.cbKörpBehind.AutoSize = true;
            this.cbKörpBehind.Location = new System.Drawing.Point(8, 156);
            this.cbKörpBehind.Name = "cbKörpBehind";
            this.cbKörpBehind.Size = new System.Drawing.Size(157, 19);
            this.cbKörpBehind.TabIndex = 0;
            this.cbKörpBehind.Text = "Körperliche Behinderung";
            this.cbKörpBehind.UseVisualStyleBackColor = true;
            // 
            // cbSucht
            // 
            this.cbSucht.AutoSize = true;
            this.cbSucht.Location = new System.Drawing.Point(8, 106);
            this.cbSucht.Name = "cbSucht";
            this.cbSucht.Size = new System.Drawing.Size(107, 19);
            this.cbSucht.TabIndex = 0;
            this.cbSucht.Text = "Suchtprobleme";
            this.cbSucht.UseVisualStyleBackColor = true;
            // 
            // cbPsychosen
            // 
            this.cbPsychosen.AutoSize = true;
            this.cbPsychosen.Location = new System.Drawing.Point(83, 81);
            this.cbPsychosen.Name = "cbPsychosen";
            this.cbPsychosen.Size = new System.Drawing.Size(82, 19);
            this.cbPsychosen.TabIndex = 0;
            this.cbPsychosen.Text = "Psychosen";
            this.cbPsychosen.UseVisualStyleBackColor = true;
            // 
            // cbSexuell
            // 
            this.cbSexuell.AutoSize = true;
            this.cbSexuell.Location = new System.Drawing.Point(8, 231);
            this.cbSexuell.Name = "cbSexuell";
            this.cbSexuell.Size = new System.Drawing.Size(123, 19);
            this.cbSexuell.TabIndex = 0;
            this.cbSexuell.Text = "Sexueller Übergriff";
            this.cbSexuell.UseVisualStyleBackColor = true;
            // 
            // cbSuizid
            // 
            this.cbSuizid.AutoSize = true;
            this.cbSuizid.Location = new System.Drawing.Point(8, 81);
            this.cbSuizid.Name = "cbSuizid";
            this.cbSuizid.Size = new System.Drawing.Size(57, 19);
            this.cbSuizid.TabIndex = 0;
            this.cbSuizid.Text = "Suizid";
            this.cbSuizid.UseVisualStyleBackColor = true;
            // 
            // cbTrennung
            // 
            this.cbTrennung.AutoSize = true;
            this.cbTrennung.Location = new System.Drawing.Point(8, 181);
            this.cbTrennung.Name = "cbTrennung";
            this.cbTrennung.Size = new System.Drawing.Size(143, 19);
            this.cbTrennung.TabIndex = 0;
            this.cbTrennung.Text = "Trennung / Scheidung";
            this.cbTrennung.UseVisualStyleBackColor = true;
            // 
            // cbPsychisch
            // 
            this.cbPsychisch.AutoSize = true;
            this.cbPsychisch.Location = new System.Drawing.Point(8, 56);
            this.cbPsychisch.Name = "cbPsychisch";
            this.cbPsychisch.Size = new System.Drawing.Size(145, 19);
            this.cbPsychisch.TabIndex = 0;
            this.cbPsychisch.Text = "Psychische Schmerzen";
            this.cbPsychisch.UseVisualStyleBackColor = true;
            // 
            // chKrankTod
            // 
            this.chKrankTod.AutoSize = true;
            this.chKrankTod.Location = new System.Drawing.Point(8, 131);
            this.chKrankTod.Name = "chKrankTod";
            this.chKrankTod.Size = new System.Drawing.Size(106, 19);
            this.chKrankTod.TabIndex = 0;
            this.chKrankTod.Text = "Krankheit / Tod";
            this.chKrankTod.UseVisualStyleBackColor = true;
            // 
            // cbKörper
            // 
            this.cbKörper.AutoSize = true;
            this.cbKörper.Location = new System.Drawing.Point(8, 31);
            this.cbKörper.Name = "cbKörper";
            this.cbKörper.Size = new System.Drawing.Size(147, 19);
            this.cbKörper.TabIndex = 0;
            this.cbKörper.Text = "Körperliche Schmerzen";
            this.cbKörper.UseVisualStyleBackColor = true;
            // 
            // tbErläuterung
            // 
            this.tbErläuterung.BackColor = System.Drawing.SystemColors.Window;
            this.tbErläuterung.BorderColor = System.Drawing.Color.Black;
            this.tbErläuterung.BorderFocusColor = System.Drawing.Color.Green;
            this.tbErläuterung.BorderRadius = 0;
            this.tbErläuterung.BorderSize = 1;
            this.tbErläuterung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbErläuterung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbErläuterung.Location = new System.Drawing.Point(38, 526);
            this.tbErläuterung.Margin = new System.Windows.Forms.Padding(10);
            this.tbErläuterung.Multiline = false;
            this.tbErläuterung.Name = "tbErläuterung";
            this.tbErläuterung.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbErläuterung.PasswordChar = false;
            this.tbErläuterung.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbErläuterung.PlaceholderText = "Erläuterung zu Andere";
            this.tbErläuterung.Size = new System.Drawing.Size(200, 32);
            this.tbErläuterung.TabIndex = 5;
            this.tbErläuterung.Texts = "";
            this.tbErläuterung.UnderlinedStyle = true;
            // 
            // togglePartnerschaft
            // 
            this.togglePartnerschaft.AutoSize = true;
            this.togglePartnerschaft.Location = new System.Drawing.Point(258, 148);
            this.togglePartnerschaft.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglePartnerschaft.Name = "togglePartnerschaft";
            this.togglePartnerschaft.OffBackColor = System.Drawing.Color.Gray;
            this.togglePartnerschaft.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togglePartnerschaft.OnBackColor = System.Drawing.Color.Green;
            this.togglePartnerschaft.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togglePartnerschaft.Size = new System.Drawing.Size(45, 22);
            this.togglePartnerschaft.TabIndex = 6;
            this.togglePartnerschaft.UseVisualStyleBackColor = true;
            // 
            // toggleKinder
            // 
            this.toggleKinder.AutoSize = true;
            this.toggleKinder.Location = new System.Drawing.Point(258, 192);
            this.toggleKinder.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleKinder.Name = "toggleKinder";
            this.toggleKinder.OffBackColor = System.Drawing.Color.Gray;
            this.toggleKinder.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleKinder.OnBackColor = System.Drawing.Color.Green;
            this.toggleKinder.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleKinder.Size = new System.Drawing.Size(45, 22);
            this.toggleKinder.TabIndex = 6;
            this.toggleKinder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "in Partnerschaft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "mit Kind";
            // 
            // toggleSonstige
            // 
            this.toggleSonstige.AutoSize = true;
            this.toggleSonstige.Location = new System.Drawing.Point(258, 236);
            this.toggleSonstige.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleSonstige.Name = "toggleSonstige";
            this.toggleSonstige.OffBackColor = System.Drawing.Color.Gray;
            this.toggleSonstige.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleSonstige.OnBackColor = System.Drawing.Color.Green;
            this.toggleSonstige.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleSonstige.Size = new System.Drawing.Size(45, 22);
            this.toggleSonstige.TabIndex = 6;
            this.toggleSonstige.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sonstiges";
            // 
            // toggleUnbekannt
            // 
            this.toggleUnbekannt.AutoSize = true;
            this.toggleUnbekannt.Location = new System.Drawing.Point(258, 280);
            this.toggleUnbekannt.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleUnbekannt.Name = "toggleUnbekannt";
            this.toggleUnbekannt.OffBackColor = System.Drawing.Color.Gray;
            this.toggleUnbekannt.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleUnbekannt.OnBackColor = System.Drawing.Color.Green;
            this.toggleUnbekannt.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleUnbekannt.Size = new System.Drawing.Size(45, 22);
            this.toggleUnbekannt.TabIndex = 6;
            this.toggleUnbekannt.UseVisualStyleBackColor = true;
            this.toggleUnbekannt.CheckedChanged += new System.EventHandler(this.onToggleUnbekannt);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unbekannt";
            // 
            // gridStunden
            // 
            this.gridStunden.AllowUserToAddRows = false;
            this.gridStunden.AllowUserToDeleteRows = false;
            this.gridStunden.AllowUserToResizeColumns = false;
            this.gridStunden.AllowUserToResizeRows = false;
            this.gridStunden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStunden.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridStunden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridStunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStunden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Art,
            this.Stunden});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStunden.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridStunden.EnableHeadersVisualStyles = false;
            this.gridStunden.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gridStunden.Location = new System.Drawing.Point(258, 315);
            this.gridStunden.Name = "gridStunden";
            this.gridStunden.RowHeadersVisible = false;
            this.gridStunden.RowHeadersWidth = 40;
            this.gridStunden.RowTemplate.Height = 25;
            this.gridStunden.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridStunden.Size = new System.Drawing.Size(200, 220);
            this.gridStunden.TabIndex = 11;
            this.gridStunden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnValueChange);
            // 
            // Art
            // 
            this.Art.HeaderText = "Art";
            this.Art.Name = "Art";
            this.Art.ReadOnly = true;
            // 
            // Stunden
            // 
            this.Stunden.HeaderText = "Stunden";
            this.Stunden.Name = "Stunden";
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
            this.btnSave.Location = new System.Drawing.Point(258, 541);
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
            this.panel4.Location = new System.Drawing.Point(258, 541);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 43);
            this.panel4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(38, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Erläuterung zu Andere";
            // 
            // EheUndLeben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.gridStunden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleKinder);
            this.Controls.Add(this.toggleUnbekannt);
            this.Controls.Add(this.toggleSonstige);
            this.Controls.Add(this.togglePartnerschaft);
            this.Controls.Add(this.tbErläuterung);
            this.Controls.Add(this.groupAnmeldung);
            this.Controls.Add(this.dropWirtschaft);
            this.Controls.Add(this.dropLeistung);
            this.Name = "EheUndLeben";
            this.Size = new System.Drawing.Size(500, 590);
            this.Load += new System.EventHandler(this.EheUndLeben_Load);
            this.groupAnmeldung.ResumeLayout(false);
            this.groupAnmeldung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStunden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
