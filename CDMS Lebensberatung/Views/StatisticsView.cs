using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using Application = Microsoft.Office.Interop.Excel.Application;
using CheckBox = System.Windows.Forms.CheckBox;
using DB = CDMS_Lebensberatung.Resources.classes.DatabaseHelper;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using Excel = Microsoft.Office.Interop.Excel;


namespace CDMS_Lebensberatung.Views;

public partial class StatisticsView : UserControl
{
    public StatisticsView()
    {
        InitializeComponent();
    }

    public static List<int> AgeListFromTable(DataTable table)
    {
        List<int> ageList = new();

        foreach (DataRow row in table.Rows)
            if (int.TryParse(row[18].ToString(), out var age))
                ageList.Add(age);
        return ageList;
    }

    public static List<int> CollectAgesUnfiltered()
    {
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        return AgeListFromTable(dataTable);
    }

    public List<int> CollectAgesFiltered()
    {
        List<string> filters = new();

        foreach (var box in CollectionCheckedBoxes())
            switch (box.Name)
            {
                case "cbNeu":
                    filters.Add("Jahr = '2023'");
                    break;
                case "cb1Jahr":
                    filters.Add("Jahr = '2022'");
                    break;
                case "cb2Jahr":
                    filters.Add("Jahr = '2021'");
                    break;

                case "cbAllg":
                    filters.Add("Beratungsart = 'Allgem. LB'");
                    break;
                case "cbSGB8":
                    filters.Add("Beratungsart = 'SGB VIII'");
                    break;
                case "cbSchwanger":
                    filters.Add("Beratungsart = 'MuKi + allgem. Sgs'");
                    filters.Add("Beratungsart = 'Beratung n. pränatal'");
                    break;
                case "cbRA":
                    filters.Add("Beratungsart = 'RA'");
                    break;

                case "cbBurgwedel":
                    filters.Add("Wohnort = '30938'");
                    break;
                case "cbWedemark":
                    filters.Add("Wohnort = '30916'");
                    break;
                case "cbIsernhagen":
                    filters.Add("Wohnort = '30900'");
                    break;

                case "cbMale":
                    filters.Add("Gender = 'male'");
                    break;
                case "cbFemale":
                    filters.Add("Gender = 'female'");
                    break;
                case "cbNonBin":
                    filters.Add("Gender = 'nonbinary'");
                    break;
            }

        if (filters.Count == 0)
            return CollectAgesUnfiltered();

        StringBuilder query = new();

        query.Append("SELECT * FROM Allgemein WHERE ");

        for (var i = 0; i < filters.Count; i++)
        {
            if (i > 0)
            {
                if (filters[i - 1].StartsWith("Jahr") && filters[i].StartsWith("Jahr"))
                    query.Append(" OR ");
                else if (
                    filters[i - 1].StartsWith("Beratungsart")
                    && filters[i].StartsWith("Beratungsart")
                )
                    query.Append(" OR ");
                else if (filters[i - 1].StartsWith("Wohnort") && filters[i].StartsWith("Wohnort"))
                    query.Append(" OR ");
                else
                    query.Append(" AND ");
            }

            query.Append(filters[i]);
        }

        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.SendQuery(query.ToString());
        db.Disconnect();

        return AgeListFromTable(dataTable);
    }

    public List<CheckBox> CollectionCheckedBoxes()
    {
        List<CheckBox> boxes = new();

        foreach (Control control in filterPanel.Controls)
        {
            if (control is not GroupBox)
                continue;

            foreach (Control box in control.Controls)
            {
                if (box is not CheckBox checkbox)
                    continue;
                if (checkbox.Checked)
                    boxes.Add(checkbox);
            }
        }

        return boxes;
    }

    public static DataTable CreateTableFromList(List<int> ages)
    {
        var ageList = new Dictionary<int, int>();

        foreach (var age in ages)
            if (ageList.ContainsKey(age))
                ageList[age]++;
            else
                ageList.Add(age, 1);

        var table = new DataTable();

        table.Columns.Add("Alter", typeof(int));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var age in ageList)
            table.Rows.Add(age.Key, age.Value);

        table.DefaultView.Sort = "Alter ASC";
        table = table.DefaultView.ToTable();

        return table;
    }

    public void UpdateGrid()
    {
        gridAge.DataSource = CreateTableFromList(CollectAgesUnfiltered());
    }

    private void OnLoad(object sender, EventArgs e)
    {
        UpdateGrid();

        for (var i = 0; i < checkListStats.Items.Count; i++)
        {
            checkListStats.SetItemChecked(i, true);
        }
    }

    private static DataTable StatistikNeuBeratungsart()
    {
        var neuanmeldungDict = new Dictionary<string, int>
        {
            { "Ehe- und Lebensberatung", 0 },
            { "SGB VIII / Erziehungsberatung (KJHG-Fälle)", 0 },
            { "Schwangeren- und Schwangerschaftskonfliktberatungen", 0 },
            { "Rechtsanwaltliche Erstberatung", 0 }
        };

        var filter = new Dictionary<string, string> { { "Wiederanmeldung", "Neu" } };
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetDataFiltered("Allgemein", filter);
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
            if (row.ItemArray[3].ToString() == "Allgem. LB")
                neuanmeldungDict["Ehe- und Lebensberatung"]++;
            else if (row.ItemArray[3].ToString() == "SGB VIII")
                neuanmeldungDict["SGB VIII / Erziehungsberatung (KJHG-Fälle)"]++;
            else if (
                row.ItemArray[3].ToString() == "MuKi + allgem. Sgs"
                || row.ItemArray[3].ToString() == "Beratung n. pränatal"
            )
                neuanmeldungDict["Schwangeren- und Schwangerschaftskonfliktberatungen"]++;
            else if (row.ItemArray[3].ToString() == "RA")
                neuanmeldungDict["Rechtsanwaltliche Erstberatung"]++;

        var table = new DataTable();
        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var entry in neuanmeldungDict)
            table.Rows.Add(entry.Key, entry.Value);

        table.TableName = "Neuanmeldungen";
        return table;
    }
    private static DataTable StatistikAltBeratungsart()
    {
        var neuanmeldungDict = new Dictionary<string, int>
        {
            { "Ehe- und Lebensberatung", 0 },
            { "SGB VIII / Erziehungsberatung (KJHG-Fälle)", 0 },
            { "Schwangeren- und Schwangerschaftskonfliktberatungen", 0 },
            { "Rechtsanwaltliche Erstberatung", 0 }
        };

        var filter = new Dictionary<string, string> { { "Wiederanmeldung", "Wiederanmeldung" } };
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetDataFiltered("Allgemein", filter);
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
            if (row.ItemArray[3].ToString() == "Allgem. LB")
                neuanmeldungDict["Ehe- und Lebensberatung"]++;
            else if (row.ItemArray[3].ToString() == "SGB VIII")
                neuanmeldungDict["SGB VIII / Erziehungsberatung (KJHG-Fälle)"]++;
            else if (
                row.ItemArray[3].ToString() == "MuKi + allgem. Sgs"
                || row.ItemArray[3].ToString() == "Beratung n. pränatal"
            )
                neuanmeldungDict["Schwangeren- und Schwangerschaftskonfliktberatungen"]++;
            else if (row.ItemArray[3].ToString() == "RA")
                neuanmeldungDict["Rechtsanwaltliche Erstberatung"]++;

        var table = new DataTable();
        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var entry in neuanmeldungDict)
            table.Rows.Add(entry.Key, entry.Value);

        table.TableName = "Wiederanmeldungen";
        return table;
    }
    private static DataTable StatistikBeratungsart()
    {
        var neuanmeldungDict = new Dictionary<string, int>
        {
            { "Ehe- und Lebensberatung", 0 },
            { "SGB VIII / Erziehungsberatung (KJHG-Fälle)", 0 },
            { "Schwangeren- und Schwangerschaftskonfliktberatungen", 0 },
            { "Rechtsanwaltliche Erstberatung", 0 }
        };

        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
            if (row.ItemArray[3].ToString() == "Allgem. LB")
                neuanmeldungDict["Ehe- und Lebensberatung"]++;
            else if (row.ItemArray[3].ToString() == "SGB VIII")
                neuanmeldungDict["SGB VIII / Erziehungsberatung (KJHG-Fälle)"]++;
            else if (
                row.ItemArray[3].ToString() == "MuKi + allgem. Sgs"
                || row.ItemArray[3].ToString() == "Beratung n. pränatal"
            )
                neuanmeldungDict["Schwangeren- und Schwangerschaftskonfliktberatungen"]++;
            else if (row.ItemArray[3].ToString() == "RA")
                neuanmeldungDict["Rechtsanwaltliche Erstberatung"]++;

        var table = new DataTable();
        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var entry in neuanmeldungDict)
            table.Rows.Add(entry.Key, entry.Value);

        table.TableName = "Gesamt";
        return table;
    }
    private static DataTable StatistikOrt()
    {
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        Dictionary<string, int> ortAnzahlDict = new();

        foreach (DataRow row in dataTable.Rows)
        {
            var key = row[7].ToString();
            if (ortAnzahlDict.ContainsKey(key))
                ortAnzahlDict[key]++;
            else
                ortAnzahlDict.Add(key, 1);
        }

        var table = new DataTable();
        table.Columns.Add("Ort", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var pair in ortAnzahlDict)
            table.Rows.Add(pair.Key, pair.Value);

        table.TableName = "Nach Wohnort";
        return table;
    }
    private static DataTable StatistikGründeEheUndLeben()
    {
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetColumn("Ehe und Leben", "Anmeldegründe");
        db.Disconnect();

        Dictionary<string, int> grundAnzahlDict = new();

        foreach (DataRow row in dataTable.Rows)
        {
            var entry = row[0].ToString();
            var reasons = entry.Split('\n');

            foreach (var reason in reasons)
                if (grundAnzahlDict.ContainsKey(reason))
                    grundAnzahlDict[reason]++;
                else
                    grundAnzahlDict.Add(reason, 1);
        }

        var table = new DataTable();
        table.Columns.Add("Grund", typeof(string));
        table.Columns.Add("Häufigkeit", typeof(int));

        foreach (var pair in grundAnzahlDict)
            table.Rows.Add(pair.Key, pair.Value);

        table.TableName = "Ehe- und Leben Gründe";
        return table;
    }
    private static DataTable StatistikGründeSgb8()
    {
        var grundSgb8Dict = new Dictionary<string, string>
        {
            { "1", "Unversorgtheit des jungen Menschen" },
            { "2", "Unzureichende Förderung" },
            { "3", "Gefährdung des Kindeswohls" },
            { "4", "Eingeschränkte Erziehungskompetenz der Eltern" },
            { "5", "Belastung des jungen Menschen durch Eltern" },
            { "6", "Belastung des jungen Menschen durch Familie" },
            { "7", "Auffälligkeiten im sozialen Verhalten des jungen Menschen" },
            { "8", "Entwicklungsauffälligkeiten / seelische Probleme" },
            { "9", "Schulische / berufliche Probleme" },
            { "10", "Andere Gründe" }
        };

        var grundSgb8Anzahl = new Dictionary<string, int>();
        var grundSgb8Index = new Dictionary<string, string>();

        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetColumn("SGB VIII", "Hilfe Nr.");
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
        {
            var c = row[0].ToString()[0].ToString();
            grundSgb8Index.Add(c, grundSgb8Dict[c]);
        }

        foreach (var pair in grundSgb8Index)
        {
            if (grundSgb8Anzahl.ContainsKey(pair.Value)) grundSgb8Anzahl[pair.Value]++; 
            else grundSgb8Anzahl.Add(pair.Value, 1);
        }

        var table = new DataTable();
        table.Columns.Add("Grund", typeof(string));
        table.Columns.Add("Häufigkeit", typeof(int));

        foreach (var pair in grundSgb8Anzahl)
        {
            table.Rows.Add(pair.Key, pair.Value);
        }

        table.TableName = "SGB VII Gründe";

        return table;
    }
    private static DataTable StatistikSchwanger()
    {
        DB db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));

        var table = new DataTable();

        db.Connect();
        var anzahlSchwangerDict = new Dictionary<string, int>
        {
            { "Mutter-Kind-Antragsstellung", db.GetNumberOfRows("Mutter Kind") },
            { "Allg. Schwangerschaftsberatung", db.GetNumberOfRows("Allgemeine Schwangerschaft") },
            { "Schwangerschaftskonfliktberatung §218", db.GetNumberOfRows("§ 218") }
        };
        db.Disconnect();

        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var pair in anzahlSchwangerDict)
            table.Rows.Add(pair.Key, pair.Value);

        table.TableName = "Schwangerenberatung";

        return table;
    }

    private void ExportToXlsx(List<DataTable> tableList)
    {
        if (tableList.Count == 0)
        {
            MessageBox.Show("Bitte mindestens einen Eintrag anwählen.", "Keine Auswahl", MessageBoxButtons.OK);
            return;
        }

        exportStatisticsFileSave.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

        if (exportStatisticsFileSave.ShowDialog() == DialogResult.OK)
        {
            var excel = new Application();
            Workbook workbook = null;
            try
            {
                workbook = excel.Workbooks.Add();
                var worksheet = workbook.Worksheets.Add() as Worksheet;
                worksheet.Name = $"Statistik {DateTime.Now.Year.ToString()}";

                var rowIndex = 2;

                foreach (var dt in tableList)
                {
                    worksheet.Range[worksheet.Cells[rowIndex, 2], worksheet.Cells[rowIndex, 3]].Merge();

                    worksheet.Cells[rowIndex, 2] = dt.TableName;
                    var heading = worksheet.Cells[rowIndex, 2] as Excel.Range;
                    heading.Interior.Color = Color.LightGreen;
                    

                    rowIndex++;

                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        for (var j = 0; j < dt.Columns.Count; j++)
                            worksheet.Cells[rowIndex, j + 2] = dt.Rows[i][j];

                        rowIndex++;
                    }

                    var columns = worksheet.UsedRange.Columns;
                    columns.AutoFit();
                    rowIndex += 2;
                }

                workbook.SaveAs(exportStatisticsFileSave.FileName);
                workbook.Close();
                excel.Quit();
            }
            catch (COMException ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                if (workbook != null)
                    workbook.Close(false);

                excel.Quit();
            }
        }
    }

    private void OnCheckedChanged(object sender, EventArgs e)
    {
        gridAge.DataSource = CreateTableFromList(CollectAgesFiltered());
    }

    private void OnButtonExport(object sender, EventArgs e)
    {
        var tableList = new List<DataTable>();
        var checkedList = new List<string>();

        foreach (var item in checkListStats.CheckedItems)
            checkedList.Add(item.ToString());
        

        if (checkedList.Contains("Neuanmeldungen nach Beratungsart")) tableList.Add(StatistikNeuBeratungsart());
        if (checkedList.Contains("Fortführungen nach Beratungsart")) tableList.Add(StatistikAltBeratungsart());
        if (checkedList.Contains("Gesamt nach Beratungsart")) tableList.Add(StatistikBeratungsart());
        if (checkedList.Contains("Gesamt nach Ort")) tableList.Add(StatistikOrt());
        if (checkedList.Contains("Anmeldegründe LB")) tableList.Add(StatistikGründeEheUndLeben());
        if (checkedList.Contains("Anmeldegründe SGB VIII")) tableList.Add(StatistikGründeSgb8());
        if (checkedList.Contains("Art der Beratung für Schwangere")) tableList.Add(StatistikSchwanger());



        ExportToXlsx(tableList);
    }
}
