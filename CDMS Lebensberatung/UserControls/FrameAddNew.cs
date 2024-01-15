using System.Configuration;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using CDMS_Lebensberatung.AddSpecific;
using CDMS_Lebensberatung.cs;
using Microsoft.IdentityModel.Tokens;
using RJCodeAdvance.RJControls;

namespace CDMS_Lebensberatung.UserControls;

public partial class FrameAddNew : UserControl
{
	public FrameAddNew()
	{
		InitializeComponent();
	}

	#region ContentFrame Navigation

	private void SelectNavigation(object selection)
	{
		var selectedButton = (Button)selection;
		foreach (Control control in TabNavControl.Controls)
		{
			if (control is not Button b || b.Tag == null)
				continue;
			b.Tag = null;
			b.Invalidate();
		}

		selectedButton.Tag = "selected";
		selectedButton.Invalidate();
	}

	private void OnTabNavPaint(object sender, PaintEventArgs e)
	{
		var btn = (Button)sender;
		if (ReferenceEquals(btn.Tag, "selected"))
		{
			e.Graphics.FillRectangle(Brushes.Green, new Rectangle(0, 0, btn.Width, 2));
			btn.Font = new Font(btn.Font, FontStyle.Bold);
		}
		else
		{
			btn.Font = new Font(btn.Font, FontStyle.Regular);
		}
	}

	private void ClearUserControl()
	{
		if (ContentFrame == null)
			return;
		foreach (
			var frameControl in from Control frameControl in ContentFrame.Controls
								where frameControl is UserControl
								select frameControl
		)
			ContentFrame.Controls.Remove(frameControl);
	}

	#endregion

	#region ContentFrame Switch

	private void ButtonSgb8_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var sgb8 = new Sgb8();
		ContentFrame.Controls.Add(sgb8);
	}

	private void ButtonMutterKind_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var muKi = new MutterKind();
		ContentFrame.Controls.Add(muKi);
	}

	private void ButtonP56_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var p56 = new P218();
		ContentFrame.Controls.Add(p56);
	}

	private void ButtonAllgSgs_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var allgSgs = new AllgSgs();
		ContentFrame.Controls.Add(allgSgs);
	}

	private void ButtonArge_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var arge = new ARGE();
		ContentFrame.Controls.Add(arge);
	}

	private void ButtonP2a_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var p2A = new P2a();
		ContentFrame.Controls.Add(p2A);
	}

	private void ButtonEheUndLeben_Click(object sender, EventArgs e)
	{
		SelectNavigation(sender);

		ClearUserControl();
		var eheUndLeben = new EheUndLeben();
		ContentFrame.Controls.Add(eheUndLeben);
	}

	#endregion

	#region OnLoad

	private void SetDropDowns()
	{
		dropMigra.DataSource = Lists.Migra;
		dropAnregung.DataSource = Lists.Anregung;
		dropBeratung.DataSource = Lists.Beratung;
		dropGrund.DataSource = Lists.Grund;
	}

	private void InitializeContent()
	{
		ButtonEheUndLeben.Tag = "selected";
		ClearUserControl();
		var eheUndLeben = new EheUndLeben();
		ContentFrame.Controls.Add(eheUndLeben);
		btnSave.DialogResult = DialogResult.OK;
	}

	#endregion

	#region DGridV Alter

	private void SetGridAlter()
	{
		foreach (var person in Lists.Personen)
			gridAlter.Rows.Add(person);

		gridAlter.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		gridAlter.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
	}

	private void OnValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		var grid = (DataGridView)sender;
		if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count)
			return;
		var row = grid.Rows[e.RowIndex];
		if (e.ColumnIndex < 0 || e.ColumnIndex >= row.Cells.Count)
			return;
		var cell = row.Cells[e.ColumnIndex];

		if (cell.Value == null)
			return;

		foreach (DataGridViewCell c in row.Cells)
		{
			if (c.ColumnIndex == e.ColumnIndex || c.ColumnIndex == 0)
				continue;
			c.Value = null;
		}
	}

	#endregion

	public bool IsSaved { get; set; }

	public void OnLoad(object sender, EventArgs e)
	{
		SetDropDowns();
		InitializeContent();
		SetGridAlter();
	}

	private void OnToggle(object sender, EventArgs e)
	{
		var toggle = (RJToggleButton)sender;

		if (toggle.Checked)
		{
			dropGrund.Enabled = true;
			dropGrund.SelectedIndex = 0;
			dropGrund.BorderColor = Color.Black;
			dropGrund.IconColor = Color.Black;
		}
		else
		{
			dropGrund.Enabled = false;
			dropGrund.SelectedIndex = 0;
			dropGrund.BorderColor = Color.Gray;
			dropGrund.IconColor = Color.Gray;
		}
	}

	private void OnButtonSave(object sender, EventArgs e)
	{
		Dictionary<Control, string> requiredFields =
			new()
			{
				{ tbJahr, "Jahr" },
				{ tbNr, "Anmeldenummer" },
				{ tbWohnort, "Wohnort" },
				{ tbName, "Name" },
				{ dropMigra, "Migrationshintergrund" },
				{ dropBeratung, "Art der Beratung" },
				{ dropAnregung, "Anregung zur Beratung" }
			};

		var errorString = new StringBuilder().Append(
			"Fehler: Folgende Felder müssen ausgefüllt werden: \n\n"
		);

		var count = 0;

		foreach (var field in requiredFields)
			switch (field.Key)
			{
				case RJTextBox tb:
					{
						if (tb.Texts.IsNullOrEmpty())
						{
							tb.BorderColor = Color.FromArgb(160, 50, 30);
							tb.BorderSize += 1;
							tb.BackColor = Color.FromArgb(255, 220, 220);
							tb.UnderlinedStyle = false;
							count++;
							errorString.AppendLine(field.Value);
						}

						break;
					}

				case DropDown dd:
					if (dd.SelectedIndex == 0)
					{
						dd.BorderColor = Color.FromArgb(160, 50, 30);
						dd.BorderSize += 1;
						dd.BackColor = Color.FromArgb(255, 220, 220);
						count++;
						errorString.AppendLine(field.Value);
					}

					break;
			}

		if (count > 0)
		{
			MessageBox.Show(
				errorString.ToString(),
				"Notwendige Felder nicht ausgefüllt.",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error
			);
			return;
		}

		Dictionaries.Allgemein.Clear();

		ReadInput.FromTextBox(this, Dictionaries.Allgemein);
		ReadInput.FromDropDown(this, Dictionaries.Allgemein);
		ReadInput.FromToggleSwitch(panelToggle, Dictionaries.Allgemein);
		ReadInput.AgeFromGridView(this, Dictionaries.Allgemein);

		if (toggleARGE.Checked)
			Dictionaries.Allgemein.Add("ARGE", "Ja");

		Dictionaries.Allgemein.Add("Age", GetAgeFromRow(GetRelevantRow()));
		Dictionaries.Allgemein.Add("Gender", GetGenderFromRow(GetRelevantRow()));

		if (ReadInput.LetUserVerify(Dictionaries.Allgemein) != DialogResult.OK) return;

		Sql database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
		database.Connect();
		database.InsertStringDict("Allgemein", Dictionaries.Allgemein);
		database.Disconnect();

		indicateSaved.Value = 100;
		panelBlocker.Visible = false;
		IsSaved = true;
	}

	private static string GetAgeFromRow(DataRow row)
	{
		foreach (var entry in row.ItemArray)
		{
			if (entry.ToString().IsNullOrEmpty() || entry == row[0]) continue;

			return Regex.Replace(entry.ToString(), "[^0-9.]", "");
		}

		return "";
	}

	private static string GetGenderFromRow(DataRow row)
	{
		for (var column = 1; column < row.ItemArray.Length; column++)
		{
			var entry = row.ItemArray[column];
			if (entry.ToString().IsNullOrEmpty()) continue;

			switch (column)
			{
				case 1:
					return "male";
				case 2:
					return "female";
				case 3:
					return "nonbinary";
				default:
					return "error";
			}
		}

		return "";
	}

	private DataRow GetRelevantRow()
	{
		var tableGridView = new DataTable();
		foreach (DataGridViewColumn column in gridAlter.Columns) tableGridView.Columns.Add(column.Name);

		foreach (DataGridViewRow row in gridAlter.Rows)
		{
			var dRow = tableGridView.NewRow();
			foreach (DataGridViewCell cell in row.Cells) dRow[cell.ColumnIndex] = cell.Value;

			tableGridView.Rows.Add(dRow);
		}

		return dropBeratung.SelectedItem.ToString() switch
		{
			"SGB VIII" => tableGridView.Rows[2],
			_ => tableGridView.Rows[0]
		};
	}


	private void OnButtonFill(object sender, EventArgs e)
	{
		#region RandomFill

		Random rnd = new();

		tbJahr.Texts = "2023";
		tbNr.Texts = rnd.Next(0, 9999).ToString();

		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		var text = chars[rnd.Next(chars.Length)].ToString();

		for (var i = 0; i < 2; i++)
			text += chars[rnd.Next(chars.Length)];

		tbName.Texts = text;
		tbWohnort.Texts = "30" + rnd.Next(0, 999);

		dropBeratung.SelectedIndex = rnd.Next(1, 6);
		dropMigra.SelectedIndex = rnd.Next(1, 4);
		dropAnregung.SelectedIndex = rnd.Next(1, 8);

		gridAlter.Rows[0].Cells[rnd.Next(1, 4)].Value = rnd.Next(24, 56).ToString();
		if (rnd.Next(1, 100) > 65)
			gridAlter.Rows[1].Cells[rnd.Next(1, 4)].Value = rnd.Next(28, 64).ToString();

		gridAlter.Rows[2].Cells[rnd.Next(1, 4)].Value = rnd.Next(11, 18).ToString();
		if (rnd.Next(1, 100) > 65)
			gridAlter.Rows[3].Cells[rnd.Next(1, 4)].Value = rnd.Next(6, 14).ToString();

		if (rnd.Next(1, 10) > 6)
		{
			toggleAbgeschlossen.Checked = true;
			dropGrund.SelectedIndex = rnd.Next(1, 3);
		}
		else
		{
			toggleAbgeschlossen.Checked = false;
		}

		toggleWieder.Checked = rnd.Next(1, 15) == 5;

		#endregion
	}

	private void ClearFields()
	{
		foreach (var control in Controls)
			switch (control)
			{
				case RJTextBox tb:
					tb.Texts = "";
					break;
				case CheckBox cb:
					cb.Checked = false;
					break;
				case DropDown drop:
					drop.SelectedIndex = 0;
					break;
				case DataGridView dgv:
					{
						foreach (DataGridViewRow row in dgv.Rows)
							foreach (DataGridViewCell cell in row.Cells)
								if (cell.ColumnIndex != 0)
									cell.Value = null;
						break;
					}
				case Panel panel:
					{
						if (panel.Name != "panelToggle") break;
						foreach (var pControl in panel.Controls)
							if (pControl is RJToggleButton toggle)
								toggle.Checked = false;
						break;
					}
			}
		ClearUserControl();
		ButtonEheUndLeben_Click(ButtonEheUndLeben, EventArgs.Empty);
		panelBlocker.Visible = true;
		indicateSaved.Value = 0;
	}


	private void OnTextBoxClick(object sender, EventArgs e)
	{
		var textBox = (RJTextBox)sender;

		if (IsSaved)
		{
			ClearFields();
			SetDropDowns();
			IsSaved = false;
		}

		textBox.UnderlinedStyle = true;
		textBox.BorderColor = Color.Black;
		textBox.BackColor = Color.WhiteSmoke;
		textBox.BorderSize = 1;
	}

	private void OnDropDownClick(object sender, EventArgs e)
	{
		var dropDown = (DropDown)sender;

		dropDown.BorderColor = Color.Black;
		dropDown.BackColor = Color.WhiteSmoke;
		dropDown.BorderSize = 1;
	}

	private void OnButtonSkip(object sender, EventArgs e)
	{
		
	}

	private void panelBlocker_Paint(object sender, PaintEventArgs e)
	{
	}

	private void gridAlter_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{

	}

	private void label2_Click(object sender, EventArgs e)
	{

	}

	private void panelBlocker_Click(object sender, EventArgs e)
	{
		panelBlocker.Visible = false;
	}
}