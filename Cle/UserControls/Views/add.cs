using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Cle.Classes;
using Cle.UserControls.CustomControls;
using Cle.UserControls.SubViews;
using Microsoft.IdentityModel.Tokens;

namespace Cle.UserControls.Views
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }

        public bool IsSaved { get; set; }

        public void OnLoad(object sender, EventArgs e)
        {
            SetDropDowns();
            InitializeContent();
            SetGridAlter();
        }

        private static string GetAgeFromRow(DataRow row)
        {
            foreach (var entry in row.ItemArray)
            {
                if (entry == null || entry.ToString().IsNullOrEmpty() || entry == row[0]) continue;
                return Regex.Replace(entry.ToString(), "[^0-9]", string.Empty);
            }
            return string.Empty;
        }

        private static string GetGenderFromRow(DataRow row)
        {
            for (int i = 1; i < row.ItemArray.Length; i++)
            {
                if (row.ItemArray[i].ToString().IsNullOrEmpty()) continue;

                return i switch
                {
                    1 => "male",
                    2 => "female",
                    3 => "nonbinary",
                    _ => "error"
                };
            }
            return string.Empty;
        }

        private void ClearUserControl()
        {
            ContentFrame.Controls.Clear();
        }

        private void ClearFields()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case RJTextBox textBox:
                        textBox.Texts = string.Empty;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                    case DropDown dropDown:
                        dropDown.SelectedIndex = 0;
                        break;
                    case DataGridView gridView:
                        foreach (DataGridViewRow row in gridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex != 0) cell.Value = null;
                            }
                        }
                        break;
                }
            }
            ClearUserControl();
            panelBlocker.Visible = true;
            indicateSaved.Value = 0;
        }

        private DataRow GetRelevantRow()
        {
            var dataTable = new DataTable();
            foreach (DataGridViewColumn column in gridAlter.Columns)
            {
                dataTable.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in gridAlter.Rows)
            {
                var dataRow = dataTable.NewRow();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dropBeratung.SelectedItem.ToString() switch
            {
                "SGB VIII" => dataTable.Rows[2],
                _ => dataTable.Rows[0]
            };
        }

        private void InitializeContent()
        {
            SelectNavigation(ButtonEheUndLeben);
            var control = new EheUndLeben();
            ContentFrame.Controls.Add(control);
            btnSave.DialogResult = DialogResult.OK;
        }

        private void SelectNavigation(object sender)
        {
            if (sender is not Button button) return;

            foreach (Control control in TabNavControl.Controls.OfType<Button>())
            {
                control.Tag = null;
                control.Invalidate();
            }

            button.Tag = "selected";
            button.Invalidate();
        }

        private void SetDropDowns()
        {
            dropMigra.DataSource = Lists.Migra;
            dropAnregung.DataSource = Lists.Anregung;
            dropBeratung.DataSource = Lists.Beratung;
            dropGrund.DataSource = Lists.Grund;
        }

        private void SetGridAlter()
        {
            foreach (var person in Lists.Personen)
            {
                gridAlter.Rows.Add(person);
            }

            gridAlter.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridAlter.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            var requiredFields = new Dictionary<Control, string>
            {
                { tbJahr, "Jahr" },
                { tbNr, "Anmeldenummer" },
                { tbWohnort, "Wohnort" },
                { tbName, "Name" },
                { dropMigra, "Migrationshintergrund" },
                { dropBeratung, "Art der Beratung" },
                { dropAnregung, "Anregung zur Beratung" }
            };

            var errorMessages = new StringBuilder("Fehler: Folgende Felder müssen ausgefüllt werden:\n\n");
            int errorCount = 0;

            foreach (var (control, fieldName) in requiredFields)
            {
                if (control is RJTextBox textBox && textBox.Texts.IsNullOrEmpty())
                {
                    HighlightField(textBox, errorMessages, fieldName);
                    errorCount++;
                }
                else if (control is DropDown dropDown && dropDown.SelectedIndex == 0)
                {
                    HighlightField(dropDown, errorMessages, fieldName);
                    errorCount++;
                }
            }

            if (errorCount > 0)
            {
                MessageBox.Show(errorMessages.ToString(), "Notwendige Felder nicht ausgefüllt.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveData();
        }

        private void HighlightField(Control control, StringBuilder errors, string fieldName)
        {
            control.BackColor = Color.FromArgb(255, 220, 220);
            control.ForeColor = Color.FromArgb(160, 50, 30);
            errors.AppendLine(fieldName);
        }

        private void SaveData()
        {
            Dictionaries.Allgemein.Clear();
            ReadInput.FromTextBox(this, Dictionaries.Allgemein);
            ReadInput.FromDropDown(this, Dictionaries.Allgemein);

            var relevantRow = GetRelevantRow();
            Dictionaries.Allgemein["Age"] = GetAgeFromRow(relevantRow);
            Dictionaries.Allgemein["Gender"] = GetGenderFromRow(relevantRow);

            if (ReadInput.LetUserVerify(Dictionaries.Allgemein) == DialogResult.OK)
            {
                using var database = new SQL();
                database.Connect();
                database.InsertStringDict("Allgemein", Dictionaries.Allgemein);
                database.Disconnect();

                indicateSaved.Value = 100;
                IsSaved = true;
                panelBlocker.Visible = false;
            }
        }
    }
}
