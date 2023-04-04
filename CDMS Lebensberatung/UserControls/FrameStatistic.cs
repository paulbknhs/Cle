﻿using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using CDMS_Lebensberatung.cs;
using Application = Microsoft.Office.Interop.Excel.Application;
using CheckBox = System.Windows.Forms.CheckBox;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using Excel = Microsoft.Office.Interop.Excel;


namespace CDMS_Lebensberatung.UserControls;

public partial class FrameStatistics : UserControl
{
    public FrameStatistics()
    {
        InitializeComponent();
    }

    public static List<int> CollectAgesUnfiltered()
    {
        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.GetFullTable("Allgemein");
        db.Disconnect();

        return Statistics.TabelleZuListeAlter(dataTable);
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

        SQL db = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        db.Connect();
        var dataTable = db.SendQuery(query.ToString());
        db.Disconnect();

        return Statistics.TabelleZuListeAlter(dataTable);
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

    public void UpdateGrid()
    {
        gridAge.DataSource = Statistics.ListeZuTabelle(CollectAgesUnfiltered());
    }

    private void OnLoad(object sender, EventArgs e)
    {
        UpdateGrid();

        for (var i = 0; i < checkListStats.Items.Count; i++)
        {
            checkListStats.SetItemChecked(i, true);
        }
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
            Workbook? workbook = null;
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
        gridAge.DataSource = Statistics.ListeZuTabelle(CollectAgesFiltered());
    }

    private void OnButtonExport(object sender, EventArgs e)
    {
        var tableList = new List<DataTable>();
        var checkedList = new List<string>();

        foreach (var item in checkListStats.CheckedItems)
            checkedList.Add(item.ToString());
        

        if (checkedList.Contains("Neuanmeldungen nach Beratungsart")) tableList.Add(Statistics.BeratungAlsNeu());
        if (checkedList.Contains("Fortführungen nach Beratungsart")) tableList.Add(Statistics.BeratungAlsAlt());
        if (checkedList.Contains("Gesamt nach Beratungsart")) tableList.Add(Statistics.Beratung());
        if (checkedList.Contains("Gesamt nach Ort")) tableList.Add(Statistics.Wohnort());
        if (checkedList.Contains("Anmeldegründe LB")) tableList.Add(Statistics.GründeFürEheUndLeben());
        if (checkedList.Contains("Anmeldegründe SGB VIII")) tableList.Add(Statistics.GründeFürErziehung());
        if (checkedList.Contains("Art der Beratung für Schwangere")) tableList.Add(Statistics.SchwangerschaftAufteilung());



        ExportToXlsx(tableList);
    }
}
