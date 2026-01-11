using Cle.Classes;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Cle.UserControls.Views;

public partial class table : UserControl
{
    private readonly Dictionary<string, string[]> _likeFilters = new();
    private readonly Dictionary<string, string[]> _strictFilters = new();

    public table()
    {
        InitializeComponent();
        dropComparator.OnSelectedIndexChanged += OnComparatorChanged;
    }

    private void OnLoad(object sender, EventArgs e)
    {
        dropTable.DataSource = Lists.Tabellen;
        dropTable.SelectedIndex = 0;
        dropComparator.DataSource = Lists.Comparators;
        dropComparator.SelectedIndex = 0;
        GetData();
        dropCategory.DataSource = gridData.Columns.Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToList();
    }

    private void OnComparatorChanged(object sender, EventArgs e)
    {
        if (dropComparator.SelectedItem.ToString() == "ist genau")
        {
            dropValue.Visible = true;
            tbFilterString.Visible = false;
            dropValue.DropDownStyle = ComboBoxStyle.DropDownList;
            onCategorySelect(sender, e);
        }
        else // This means "enthält" or other comparators
        {
            dropValue.Visible = false;
            tbFilterString.Visible = true;
            dropValue.DataSource = null; // Clear dropdown source
            dropValue.Texts = ""; // Clear text from dropValue
            tbFilterString.Texts = ""; // Clear text from tbFilterString
        }
    }

    private void OnDelete(object sender, EventArgs e)
    {
        var table = dropTable.SelectedItem.ToString();
        foreach (DataGridViewCell cell in gridData.SelectedCells)
            cell.OwningRow.Selected = true;

        var row = gridData.SelectedCells[0].OwningRow;
        var id = row.Cells[0].Value.ToString();

        if (MessageBox.Show(
                $"Ausgewählten Eintrag mit ID: {id} unwiderruflich aus Tabelle \"{dropTable.SelectedItem}\" entfernen?",
                "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        SQL database = new();
        database.Connect();
        database.DeleteData(table, id);

        OnUpdateClick(btnUpdate, EventArgs.Empty);
    }

    private void GetData()
    {
        SQL database = new();
        database.Connect();

        var table = database.GetFullTable(dropTable.SelectedItem.ToString());
        database.Disconnect();

        List<string> toRemove = ["Age", "Gender"];
        table = RemoveColumns(table, toRemove);
        if (table.Columns.Contains("Beratungsart"))
        {
            var rowsToRemove = table.AsEnumerable().Where(r => r.Field<string>("Beratungsart") == "§218").ToList();
            foreach (var r in rowsToRemove)
                table.Rows.Remove(r);
        }

        gridData.DataSource = table;
        dropCategory.DataSource = gridData.Columns.Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToList();

        txtRows.Text = table.Rows.Count switch
        {
            > 0 => $"{table.Rows.Count} Einträge",
            _ => "Keine Einträge"
        };
        txtRows.ForeColor = table.Rows.Count switch
        {
            > 0 => Color.Green,
            _ => Color.Red
        };
    }

    private void GetDataFiltered()
    {
        var tableName = dropTable.SelectedItem.ToString() ?? "";
        SQL database = new();
        database.Connect();
        var table = database.GetCombinedFiltered(tableName, _strictFilters, _likeFilters);
        database.Disconnect();

        List<string> toRemove = ["Age", "Gender"];
        table = RemoveColumns(table, toRemove);
        if (table.Columns.Contains("Beratungsart"))
        {
            var rowsToRemove = table.AsEnumerable().Where(r => r.Field<string>("Beratungsart") == "§218").ToList();
            foreach (var r in rowsToRemove)
                table.Rows.Remove(r);
        }

        gridData.DataSource = table;
        txtRows.Text = table.Rows.Count switch
        {
            1 => "1 Eintrag",
            > 1 => $"{table.Rows.Count} Einträge",
            _ => "Keine Einträge"
        };
        txtRows.ForeColor = table.Rows.Count switch
        {
            > 0 => Color.Green,
            _ => Color.Red
        };
    }

    private void OnFilterAdd(object sender, EventArgs e)
    {
        var category = dropCategory.SelectedItem.ToString();
        var comparator = dropComparator.SelectedItem.ToString();
        var value = "";

        if (comparator == "ist genau")
        {
            value = dropValue.Texts;
        }
        else if (comparator == "enthält")
        {
            value = tbFilterString.Texts;
        }
        // Add other comparators here if needed

        if (string.IsNullOrEmpty(value))
        {
            MessageBox.Show("Bitte geben Sie einen Wert für den Filter an.", "Leerer Wert", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var filterDict = comparator == "ist genau" ? _strictFilters : _likeFilters;

        if (filterDict.ContainsKey(category))
            filterDict[category] = filterDict[category].Append(value).ToArray();
        else
            filterDict.Add(category, [value]);

        var filterButton = new Button
        {
            Text = $"'{category}' {comparator} '{value}'",
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
        var filterText = filterButton.Text;

        var parts = filterText.Split(new[] { " " }, 3, StringSplitOptions.RemoveEmptyEntries);
        var category = parts[0].Trim('\'');
        var comparator = parts[1];
        var value = parts[2].Trim('\'');

        var filterDict = comparator == "ist genau" ? _strictFilters : _likeFilters;

        if (filterDict.ContainsKey(category))
        {
            if (filterDict[category].Length == 1)
                filterDict.Remove(category);
            else
                filterDict[category] = filterDict[category].Where(x => x != value).ToArray();
        }

        panelActiveFilters.Controls.Remove(filterButton);

        if (_strictFilters.Count == 0 && _likeFilters.Count == 0)
            OnReset(sender, e);
        else
            GetDataFiltered();
    }

    public static DataTable RemoveColumns(DataTable table, List<string> toRemove)
    {
        foreach (var columnName in toRemove.Where(columnName => table.Columns.Contains(columnName)))
            table.Columns.Remove(columnName);
        return table;
    }

    private void OnReset(object sender, EventArgs e)
    {
        GetData();
        panelActiveFilters.Controls.Clear();
        _strictFilters.Clear();
        _likeFilters.Clear();
    }

    private void OnUpdateClick(object sender, EventArgs e)
    {
        if (_strictFilters.Count == 0 && _likeFilters.Count == 0)
            GetData();
        else
            GetDataFiltered();
    }

    private void onCategorySelect(object sender, EventArgs e)
    {
        if (dropComparator.SelectedItem.ToString() != "ist genau" || !dropValue.Visible) return;

        var columnName = dropCategory.SelectedItem.ToString();
        if (string.IsNullOrEmpty(columnName)) return;

        var entries = gridData.Rows.Cast<DataGridViewRow>()
            .Select(x => x.Cells[columnName].Value?.ToString())
            .Where(s => !string.IsNullOrEmpty(s))
            .Distinct()
            .ToList();
        dropValue.DataSource = entries;
    }

    private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }
}
