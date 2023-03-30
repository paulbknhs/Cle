using System.Data;
using DB = CregForm.Resources.classes.DatabaseHelper;
using System.Configuration;

namespace CregForm.Views
{
    public partial class StatisticsView : UserControl
    {
        public StatisticsView()
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
                var columns = new List<string>()
                    { "Erwachsene*r 1", "Erwachsene*r 2", "Kind 1", "Kind 2", "Kind 3", "Kind 4", "Kind 5" };

                table = FilterColumns(data, columns);

                var freqAgeGender = new Dictionary<(int age, string gender), int>();

                foreach (DataRow row in table.Rows)
                {
                    for (var i = 0; i < row.ItemArray.Length; i++)
                    {
                        var value = row.ItemArray[i].ToString();
                        if (!value.Contains("m") && !value.Contains("w") && !value.Contains("nb")) continue;
                        var age = int.Parse(value.Split(" ")[0]);
                        var gender = value.Contains("m") ? "Männlich" : value.Contains("w") ? "Weiblich" : "Non-Binär";

                        var ageGenderTuple = (age, gender);
                        if (freqAgeGender.ContainsKey(ageGenderTuple))
                            freqAgeGender[ageGenderTuple]++;
                        else
                            freqAgeGender[ageGenderTuple] = 1;
                    }
                }


            var sortedFreqAgeGender = from entry in freqAgeGender orderby entry.Key.age ascending select entry;

                var result = new DataTable();
                result.Columns.Add("Alter", typeof(int));
                result.Columns.Add("Gesamt", typeof(int));
                result.Columns.Add("Männlich", typeof(int));
                result.Columns.Add("Weiblich", typeof(int));
                result.Columns.Add("Non-Binär", typeof(int));

                foreach (var entry in sortedFreqAgeGender)
                {
                    var row = result.NewRow();
                    row["Alter"] = entry.Key.age;
                    row["Gesamt"] = entry.Value;

                    if (entry.Key.gender == "Männlich")
                        row["Männlich"] = entry.Value;
                    else if (entry.Key.gender == "Weiblich")
                        row["Weiblich"] = entry.Value;
                    else
                        row["Non-Binär"] = entry.Value;

                    result.Rows.Add(row);
                }

                result.DefaultView.Sort = "Alter ASC";
                result = result.DefaultView.ToTable();
                
                return result;
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


        public static DataTable Age()
        {
            DataTable dt = new();

            
            return dt;
        }


    }
}
