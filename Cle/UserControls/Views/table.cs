using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cle.Classes;
using Microsoft.IdentityModel.Tokens;

namespace Cle.UserControls.Views
{
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }

        public static DataTable RemoveColumns(DataTable table, List<string> columnsToRemove)
        {
            foreach (var column in columnsToRemove.Where(table.Columns.Contains))
            {
                table.Columns.Remove(column);
            }
            return table;
        }

        private void GetData()
        {
            using var database = new SQL();
            database.Connect();

            var dataTable = database.GetFullTable(dropTable.SelectedItem?.ToString() ?? string.Empty);

            if (dataTable.Columns.Contains("Beratungsart"))
            {
                var rowsToRemove = dataTable.AsEnumerable()
                    .Where(r => r["Beratungsart"].ToString() == "§218")
                    .ToList();

                foreach (var row in rowsToRemove)
                {
                    dataTable.Rows.Remove(row);
                }
            }

            gridData.DataSource = dataTable;
            UpdateRowCountLabel(dataTable.Rows.Count);
        }

        private void GetDataFiltered()
        {
            var tableName = dropTable.SelectedItem?.ToString() ?? string.Empty;

            using var database = new SQL();
            database.Connect();
            var dataTable = database.GetStrictlyFiltered(tableName, Dictionaries.Filters);

            // Example columns to remove
            var columnsToRemove = new List<string> { "Age", "Gender" };
            dataTable = RemoveColumns(dataTable, columnsToRemove);

            if (dataTable.Columns.Contains("Beratungsart"))
            {
                var rowsToRemove = dataTable.AsEnumerable()
                    .Where(r => r["Beratungsart"].ToString() == "§218")
                    .ToList();

                foreach (var row in rowsToRemove)
                {
                    dataTable.Rows.Remove(row);
                }
            }

            gridData.DataSource = dataTable;
            UpdateRowCountLabel(dataTable.Rows.Count);
        }

        private void UpdateRowCountLabel(int rowCount)
        {
            txtRows.Text = rowCount switch
            {
                0 => "Keine Einträge",
                1 => "1 Eintrag",
                _ => $"{rowCount} Einträge"
            };
            txtRows.ForeColor = rowCount > 0 ? Color.Green : Color.Red;
        }

        private void OnDelete(object sender, EventArgs e)
        {
            var tableName = dropTable.SelectedItem?.ToString() ?? string.Empty;

            foreach (DataGridViewCell cell in gridData.SelectedCells)
            {
                cell.OwningRow.Selected = true;
            }

            var row = gridData.SelectedCells[0].OwningRow;
            var id = row.Cells[0].Value.ToString();

            if (MessageBox.Show(
                $"Ausgewählten Eintrag mit ID: {id} unwiderruflich aus Tabelle \"{tableName}\" entfernen?",
                "Bestätigung",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            using var database = new SQL();
            database.Connect();
            database.DeleteData(tableName, id);

            OnUpdateClick(btnUpdate, EventArgs.Empty);
        }

        private void OnFilterAdd(object sender, EventArgs e)
        {
            var category = dropCat.SelectedItem?.ToString();
            var keyword = tbKeyword.Text;

            if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(keyword))
            {
                return;
            }

            if (Dictionaries.Filters.ContainsKey(category))
            {
                Dictionaries.Filters[category] = Dictionaries.Filters[category].Append(keyword).ToArray();
            }
            else
            {
                Dictionaries.Filters.Add(category, new[] { keyword });
            }

            var filterButton = new Button
            {
                Text = $"{category}: {keyword}",
                AutoSize = true,
                BackColor = Color.LightGray,
                Margin = new Padding(5, 0, 5, 0)
            };
            filterButton.Click += OnFilterButtonClick;
            panelActiveFilters.Controls.Add(filterButton);

            GetDataFiltered();
        }

        private void OnFilterButtonClick(object sender, EventArgs e)
        {
            var filterButton = (Button)sender;
            var filterParts = filterButton.Text.Split(':');
            var category = filterParts[0].Trim();
            var value = filterParts[1].Trim();

            if (Dictionaries.Filters[category].Length == 1)
            {
                Dictionaries.Filters.Remove(category);
            }
            else
            {
                Dictionaries.Filters[category] = Dictionaries.Filters[category].Where(x => x != value).ToArray();
            }

            panelActiveFilters.Controls.Remove(filterButton);

            GetDataFiltered();
            OnUpdateClick(btnUpdate, EventArgs.Empty);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            dropTable.DataSource = Lists.Tabellen;
            dropTable.SelectedIndex = 0;
            GetData();
            dropCat.DataSource = gridData.Columns.Cast<DataGridViewColumn>()
                .Select(x => x.HeaderText)
                .ToList();
        }

        private void OnReset(object sender, EventArgs e)
        {
            GetData();
            panelActiveFilters.Controls.Clear();
            Dictionaries.Filters.Clear();
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            if (Dictionaries.Filters.IsNullOrEmpty())
            {
                GetData();
            }
            else
            {
                GetDataFiltered();
            }
        }
    }
}
