using System.Data;
using CDMS_Lebensberatung.cs;
using Microsoft.IdentityModel.Tokens;
using DataTable = System.Data.DataTable;

namespace CDMS_Lebensberatung.UserControls;

public partial class FrameShowTable : UserControl
{
    private const string ConnectionString =
        "Data Source=\"localhost\\SQLEXPRESS01\"; Initial Catalog=active_db; Integrated Security=True; TrustServerCertificate=True";

    public FrameShowTable()
    {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        dropTabelle.DataSource = Lists.Tabellen;
        dropTabelle.SelectedIndex = 0;
        GetData();
    }

    private void OnDelete(object sender, EventArgs e)
    {
        var table = dropTabelle.SelectedItem.ToString();
        foreach (DataGridViewCell cell in gridData.SelectedCells)
            cell.OwningRow.Selected = true;

        var row = gridData.SelectedCells[0].OwningRow;
        var id = row.Cells[0].Value.ToString();

        if (MessageBox.Show(
                $"Ausgewählten Eintrag mit ID: {id} unwiderruflich aus Tabelle \"{dropTabelle.SelectedItem}\" entfernen?",
                "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        SQL database = new(ConnectionString);
        database.Connect();
        database.DeleteData(table, id);

        OnUpdateClick(btnUpdate, EventArgs.Empty);
    }

    private void GetData()
    {
        SQL database = new(ConnectionString);
        database.Connect();

        var table = database.GetFullTable(dropTabelle.SelectedItem.ToString());
        database.Disconnect();

        List<string> toRemove = ["Age", "Gender"];
        table = RemoveColumns(table, toRemove);
        if (table.Columns.Contains("Beratungsart"))
        {
            var rowsToRemove = table.AsEnumerable().Where(r => r["Beratungsart"].ToString() == "§218").ToList();
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
        var tableName = dropTabelle.SelectedItem.ToString() ?? "";
        SQL database = new(ConnectionString);
        database.Connect();
        var table = database.GetDataFiltered(tableName, Dictionaries.Filters);
        database.Disconnect();

        List<string> toRemove = new() { "Age", "Gender" };
        table = RemoveColumns(table, toRemove);
        if (table.Columns.Contains("Beratungsart"))
        {
            var rowsToRemove = table.AsEnumerable().Where(r => r["Beratungsart"].ToString() == "§218").ToList();
            foreach (var r in rowsToRemove)
                table.Rows.Remove(r);
        }

        gridData.DataSource = table;
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

    private void OnFilterAdd(object sender, EventArgs e)
    {
        var key = dropFilter.SelectedItem.ToString() ?? "";
        if (tbFilter.Texts == "") return;
        var value = tbFilter.Texts;

        tbListFilters.Texts = string.Concat(tbListFilters.Texts, $"[{key}] {value}; ");
        Console.WriteLine(tbListFilters.Texts);

        if (Dictionaries.Filters.ContainsKey(key)) Dictionaries.Filters[key] = value;
        else Dictionaries.Filters.Add(key, value);
        UpdateFiltered();
    }

    public static DataTable RemoveColumns(DataTable table, List<string> toRemove)
    {
        foreach (var columnName in toRemove.Where(columnName => table.Columns.Contains(columnName)))
            table.Columns.Remove(columnName);
        return table;
    }

    private void UpdateFiltered()
    {
        tbFilter.Text = "";
        GetDataFiltered();
    }

    private void OnReset(object sender, EventArgs e)
    {
        tbListFilters.Texts = "";
        tbFilter.Texts = "";
        GetData();
        Dictionaries.Filters.Clear();
        dropFilter.DataSource = gridData.Columns.Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToList();
        dropFilter.SelectedIndex = 0;
    }

    private void OnUpdateClick(object sender, EventArgs e)
    {
        if (Dictionaries.Filters.IsNullOrEmpty()) GetData();
        else GetDataFiltered();
    }

    private void onCategorySelect(object sender, EventArgs e)
    {
        dropCategory.
    }
}
