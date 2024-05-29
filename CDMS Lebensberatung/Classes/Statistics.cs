using System.Configuration;
using System.Data;
using Microsoft.IdentityModel.Tokens;

namespace CDMS_Lebensberatung.cs;

public static class Statistics
{
    public static List<int> TabelleZuListeAlter(DataTable table)
    {
        List<int> ageList = new();

        foreach (DataRow row in table.Rows)
            if (int.TryParse(row["Age"].ToString(), out var age))
                ageList.Add(age);
        return ageList;
    }

    public static DataTable ListeZuTabelle(List<int> ages)
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

    public static DataTable BeratungAlsNeu()
    {
        var neuanmeldungDict = new Dictionary<string, int>
        {
            { "Ehe- und Lebensberatung", 0 },
            { "SGB VIII / Erziehungsberatung (KJHG-Fälle)", 0 },
            { "Schwangeren- und Schwangerschaftskonfliktberatungen", 0 },
            { "Rechtsanwaltliche Erstberatung", 0 }
        };

        var filter = new Dictionary<string, string> { { "Wieder", "Nein" } };
        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetDataFiltered("Allgemein", filter);
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
            switch (row["Beratungsart"].ToString())
            {
                case "Allgem. LB":
                    neuanmeldungDict["Ehe- und Lebensberatung"]++;
                    break;
                case "SGB VIII":
                    neuanmeldungDict["SGB VIII / Erziehungsberatung (KJHG-Fälle)"]++;
                    break;
                case "MuKi + allgem. Sgs":
                case "Beratung n. pränatal":
                    neuanmeldungDict["Schwangeren- und Schwangerschaftskonfliktberatungen"]++;
                    break;
                case "RA":
                    neuanmeldungDict["Rechtsanwaltliche Erstberatung"]++;
                    break;
            }

        var table = new DataTable();
        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var entry in neuanmeldungDict)
            table.Rows.Add(entry.Key, entry.Value);

        table.TableName = "Neuanmeldungen";
        return table;
    }

    public static DataTable BeratungAlsAlt()
    {
        var neuanmeldungDict = new Dictionary<string, int>
        {
            { "Ehe- und Lebensberatung", 0 },
            { "SGB VIII / Erziehungsberatung (KJHG-Fälle)", 0 },
            { "Schwangeren- und Schwangerschaftskonfliktberatungen", 0 },
            { "Rechtsanwaltliche Erstberatung", 0 }
        };

        var filter = new Dictionary<string, string> { { "Wieder", "Ja" } };
        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetDataFiltered("Allgemein", filter);
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
            switch (row["Beratungsart"].ToString())
            {
                case "Allgem. LB":
                    neuanmeldungDict["Ehe- und Lebensberatung"]++;
                    break;
                case "SGB VIII":
                    neuanmeldungDict["SGB VIII / Erziehungsberatung (KJHG-Fälle)"]++;
                    break;
                case "MuKi + allgem. Sgs":
                case "Beratung n. pränatal":
                    neuanmeldungDict["Schwangeren- und Schwangerschaftskonfliktberatungen"]++;
                    break;
                case "RA":
                    neuanmeldungDict["Rechtsanwaltliche Erstberatung"]++;
                    break;
            }

        var table = new DataTable();
        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var entry in neuanmeldungDict)
            table.Rows.Add(entry.Key, entry.Value);

        table.TableName = "Wiederanmeldungen";
        return table;
    }

    public static DataTable Beratung()
    {
        var neuanmeldungDict = new Dictionary<string, int>
        {
            { "Ehe- und Lebensberatung", 0 },
            { "SGB VIII / Erziehungsberatung (KJHG-Fälle)", 0 },
            { "Schwangeren- und Schwangerschaftskonfliktberatungen", 0 },
            { "Rechtsanwaltliche Erstberatung", 0 }
        };

        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        foreach (DataRow row in dataTable.Rows)
            switch (row["Beratungsart"].ToString())
            {
                case "Allgem. LB":
                    neuanmeldungDict["Ehe- und Lebensberatung"]++;
                    break;
                case "SGB VIII":
                    neuanmeldungDict["SGB VIII / Erziehungsberatung (KJHG-Fälle)"]++;
                    break;
                case "MuKi + allgem. Sgs":
                case "Beratung n. pränatal":
                    neuanmeldungDict["Schwangeren- und Schwangerschaftskonfliktberatungen"]++;
                    break;
                case "RA":
                    neuanmeldungDict["Rechtsanwaltliche Erstberatung"]++;
                    break;
            }

        var table = new DataTable();
        table.Columns.Add("Art", typeof(string));
        table.Columns.Add("Anzahl", typeof(int));

        foreach (var entry in neuanmeldungDict)
            table.Rows.Add(entry.Key, entry.Value);

        table.TableName = "Gesamt";
        return table;
    }

    public static DataTable Wohnort()
    {
        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        Dictionary<string, int> ortAnzahlDict = new();

        foreach (DataRow row in dataTable.Rows)
        {
            if (row["Wohnort"].ToString() is "") continue;
            
            var key = row["Wohnort"].ToString() ?? "00000";
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

    public static DataTable GründeFürEheUndLeben()
    {
        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
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

    public static DataTable GründeFürErziehung()
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

        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetColumn("SGB VIII", "Hilfe");
        db.Disconnect();

        var grundSgb8Index = (from DataRow row in dataTable.Rows select row[0].ToString()[0].ToString()).ToDictionary(c => c, c => grundSgb8Dict[c]);

        foreach (var pair in grundSgb8Index)
            if (grundSgb8Anzahl.ContainsKey(pair.Value))
                grundSgb8Anzahl[pair.Value]++;
            else
                grundSgb8Anzahl.Add(pair.Value, 1);

        var table = new DataTable();
        table.Columns.Add("Grund", typeof(string));
        table.Columns.Add("Häufigkeit", typeof(int));

        foreach (var pair in grundSgb8Anzahl) table.Rows.Add(pair.Key, pair.Value);

        table.TableName = "SGB VII Gründe";

        return table;
    }

    public static DataTable SchwangerschaftAufteilung()
    {
        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));

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
}