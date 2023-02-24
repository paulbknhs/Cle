using System.Data;
using DB = CregForm.Resources.classes.DatabaseHelper;
using System.Configuration;

namespace CregForm.Views
{
    public partial class ExportView : UserControl
    {
        public ExportView()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var table = GetAgeAndGenderData();
            dataGridAge.DataSource = table;
        }

        
        public static DataTable GetAgeAndGenderData()
        {
            var db = new DB(ConfigurationManager.AppSettings.Get("ConnectionString") ?? string.Empty);
            var table = new DataTable();

            db.Connect();
            var data = db.GetData("Allgemein");

            

            var columns = new List<string>(){"Erwachsene*r 1", "Erwachsene*r 2", "Kind 1", "Kind 2", "Kind 3", "Kind 4", "Kind 5" };

            table = FilterColumns(data, columns);

            var freqAge = new Dictionary<int, int>();

            foreach (DataRow row in table.Rows)
            {
                for (var i = 0; i < row.ItemArray.Length; i++)
                {
                    var value = row.ItemArray[i].ToString();
                    if (!value.Contains("m") && !value.Contains("w") && !value.Contains("nb")) continue;
                    var age = value.Split(" ")[0];
                    row[i] = age;

                    if (freqAge.ContainsKey(int.Parse(age)))
                        freqAge[int.Parse(age)]++;
                    else
                        freqAge.Add(int.Parse(age), 1);
                }
            }

            var sortedFreqAge = from entry in freqAge orderby entry.Key ascending select entry;

            var result = new DataTable();
            result.Columns.Add("Alter", typeof(string));
            result.Columns.Add("Gesamt", typeof(string));
            result.Columns.Add("Männlich", typeof(string));
            result.Columns.Add("Weiblich", typeof(string));
            result.Columns.Add("Non-Binär", typeof(string));

            foreach (var entry in sortedFreqAge)
            {
                var row = result.NewRow();
                row["Alter"] = entry.Key;
                row["Gesamt"] = entry.Value;
                result.Rows.Add(row);
            }
        }

        
        public static DataTable FilterColumns(DataTable dataTable, List<string> columnNames)
        {
            var filteredDataTable = new DataTable();
            foreach (var column in columnNames.Select(columnName => dataTable.Columns[columnName]))
                filteredDataTable.Columns.Add(column.ColumnName, column.DataType);

            foreach (DataRow row in dataTable.Rows)
            {
                var filteredRow = filteredDataTable.NewRow();
                foreach (var columnName in columnNames) filteredRow[columnName] = row[columnName];
                filteredDataTable.Rows.Add(filteredRow);
            }
            return filteredDataTable;
        }

    }
}
