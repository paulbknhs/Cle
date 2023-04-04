using System.Text;
using CDMS_Lebensberatung.UserControls;
using RJCodeAdvance.RJControls;
using RJTextBox = CDMS_Lebensberatung.UserControls.RJTextBox;

namespace CDMS_Lebensberatung.cs
{
    public static class ReadInput
    {
        public static void FromTextBox(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (Control control in frame.Controls)
            {
                if (control is not RJTextBox textBox || textBox.Texts == "") continue;

                dictionary.Add(textBox.Name[2..], textBox.Texts);
            }
        }

        public static void FromDropDown(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (Control item in frame.Controls)
            {
                if (!item.Enabled || item is not DropDown || item.Name == "dropAlter") continue;

                var dd = (DropDown)item;
                var key = dd.Items[0].ToString();
                var value = dd.Texts;

                if (key != null && key != value) dictionary.Add(key, value);
            }
        }

        public static void FromToggleSwitch(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (var toggle in frame.Controls.OfType<RJToggleButton>())
            {
                var key = toggle.Name[6..];
                var value = toggle.Checked switch
                {
                    true => "Ja",
                    false => "Nein"
                };

                switch (key)
                {
                    case "Sonstige" when !toggle.Checked:
                    case "Unbekannt" when !toggle.Checked:
                        return;

                    case "Wiederanmeldung" when !toggle.Checked:
                        dictionary.Add("Wiederanmeldung", "Neu");
                        return;
                    case "Wiederanmeldung" when toggle.Checked:
                        dictionary.Add("Wiederanmeldung", "Wiederanmeldung");
                        return;

                    case "Wartezeit" when toggle.Checked:
                        dictionary.Add("Wartezeit", "Länger als 4 Wochen");
                        return;

                    case "Wartezeit" when !toggle.Checked:
                        dictionary.Add("Wartezeit", "Bis zu 4 Wochen");
                        return;

                    default:
                        dictionary.Add(key, value);
                        return;
                }
            }
        }

        public static void FromCheckBox(Control frame, Dictionary<string, string> dictionary)
        {
            StringBuilder checkedBoxes = new();
            var group = (GroupBox)frame;
            foreach (Control control in frame.Controls)
            {
                switch (control)
                {
                    case CheckBox { Checked: false }:
                        continue;
                    case CheckBox cb:
                        checkedBoxes.AppendLine(cb.Text);
                        break;
                }
            }

            if (checkedBoxes.Length > 2)
                checkedBoxes.Length -= 2;
            dictionary.Add(group.Text, checkedBoxes.ToString());
        }

        public static void AgeFromGridView(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (var control in frame.Controls)
            {
                if (control is not DataGridView) continue;

                var grid = (DataGridView)control;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    var key = row.Cells[0].Value.ToString();
                    var value = row.Cells[1].Value?.ToString() ??
                                row.Cells[2].Value?.ToString() ?? row.Cells[3].Value?.ToString();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || cell.ColumnIndex == 0) continue;

                        switch (cell.ColumnIndex)
                        {
                            case 1:
                                value += " m";
                                break;
                            case 2:
                                value += " w";
                                break;
                            case 3:
                                value += " nb";
                                break;
                        }
                    }

                    if (value != null) dictionary.Add(key, value);
                }
            }
        }

        public static void HoursFromGridView(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (var control in frame.Controls)
            {
                if (control is not DataGridView grid) continue;

                var value = new StringBuilder();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[1].Value == null) continue;

                    var _key = row.Cells[0].Value.ToString();
                    var _value = row.Cells[1].Value.ToString();

                    value.AppendLine(_key + ": " + _value);
                }

                dictionary.Add("Stunden", value.ToString());
            }
        }

        public static void FromNumberBox(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (Control control in frame.Controls)
            {
                if (control is not NumericUpDown numBox || numBox.Text == "") continue;

                dictionary.Add(numBox.Name[3..], numBox.Text);
            }
        }

        public static DialogResult LetUserVerify(Dictionary<string, string> dictionary)
        {
            var form = new Form
            {
                Text = "Eingaben prüfen",
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterParent,
            };

            var dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                Size = new Size(300, 420),
                AutoGenerateColumns = true,
                ColumnHeadersVisible = false,
                RowHeadersVisible = false,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
            };

            dataGridView.Columns.Add("Key", "Feld");
            dataGridView.Columns.Add("Value", "Wert");

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (var kvp in dictionary)
            {
                dataGridView.Rows.Add(kvp.Key, kvp.Value);
            }

            form.Controls.Add(dataGridView);
            var btnOk = new Button
            {
                Dock = DockStyle.Right,
                Text = "OK",
                DialogResult = DialogResult.OK,
                Size = new Size(100, 40)
            };

            var btnCancel = new Button
            {
                Dock = DockStyle.Left,
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Size = new Size(100, 40)
            };

            var panel = new Panel
            {
                Dock = DockStyle.Bottom,
                Padding = new Padding(15),
            };

            panel.Height = btnOk.Height + panel.Padding.Vertical;
            panel.Controls.Add(btnOk);
            panel.Controls.Add(btnCancel);

            form.Controls.Add(panel);
            form.ClientSize = new Size(dataGridView.Width, dataGridView.Height + panel.Height);

            return form.ShowDialog();
        }
    }
}
