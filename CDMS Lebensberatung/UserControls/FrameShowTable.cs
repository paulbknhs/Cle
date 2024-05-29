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
    dropTable.DataSource = Lists.Tabellen;
    dropTable.SelectedIndex = 0;
    dropComparator.DataSource = Lists.Comparators;
    GetData();
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

    SQL database = new(ConnectionString);
    database.Connect();
    database.DeleteData(table, id);

    OnUpdateClick(btnUpdate, EventArgs.Empty);
  }

  private void GetData()
  {
    SQL database = new(ConnectionString);
    database.Connect();

    var table = database.GetFullTable(dropTable.SelectedItem.ToString());
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
    var tableName = dropTable.SelectedItem.ToString() ?? "";
    SQL database = new(ConnectionString);
    database.Connect();
    var table = database.GetStrictlyFiltered(tableName, Dictionaries.Filters);
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
      // check if Dictionary Filters already contains the selected category. if not create an empty array and add the selected category with its value. if it does exist, add the selected value to the existing categories array
      if (Dictionaries.Filters.ContainsKey(dropCategory.SelectedItem.ToString()))
      {
          // append the value to the existing array
          Dictionaries.Filters[dropCategory.SelectedItem.ToString()] = Dictionaries
              .Filters[dropCategory.SelectedItem.ToString()]
              .Append(dropValue.SelectedItem.ToString())
              .ToArray();
      }
      else
      {
          Dictionaries.Filters.Add(dropCategory.SelectedItem.ToString(),
              [dropValue.SelectedItem.ToString()]);
      }
      
      var filterButton = new Button
      {
          Text = $"{dropCategory.SelectedItem}: {dropValue.SelectedItem}",
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
      var filterParts = filterText.Split(':');
      var category = filterParts[0].Trim();
      var value = filterParts[1].Trim();
      // remove the filter with this value from the dictionaries key, if its the last value, remove the key
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
    Dictionaries.Filters.Clear();
  }

  private void OnUpdateClick(object sender, EventArgs e)
  {
    if (Dictionaries.Filters.IsNullOrEmpty()) GetData();
    else GetDataFiltered();
  }

  private void onCategorySelect(object sender, EventArgs e)
  {
      // get selected column name
      var columnName = dropCategory.SelectedItem.ToString();

      // get all possible entries in certain column 
      var entries = gridData.Rows.Cast<DataGridViewRow>().Select(x => x.Cells[columnName].Value.ToString()).Distinct().ToList();
      dropValue.DataSource = entries;
  }
  
  
}
