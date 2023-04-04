using System.Configuration;
using CDMS_Lebensberatung.Resources.classes;

namespace CDMS_Lebensberatung.Views
{
    public partial class SearchView : UserControl
    {
        public static Dictionary<string, string> Filters = new();

        public SearchView()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            dropTabelle.DataSource = LSTS.Tabellen;
            dropTabelle.SelectedIndex = 0;
            dropFilter.DataSource = gridData.Columns.Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToList();
        }

        private void OnSelection(object sender, EventArgs e)
        {
            GetData();


            if (dropTabelle.SelectedItem.ToString() != "Ehe und Leben") return;

            foreach (DataGridViewColumn col in gridData.Columns)
            {
                var column  = gridData.Columns.Cast<DataGridViewColumn>()
                    .FirstOrDefault(x => x.HeaderText is "Stunden" or "Anmeldegründe");
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
          
        }

        
        private void OnDelete(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in gridData.SelectedCells)
                cell.OwningRow.Selected = true;

            if (MessageBox.Show($"Ausgewählten Eintrag unwiderruflich aus Tabelle \"{dropTabelle.SelectedItem}\" entfernen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            var row = gridData.SelectedCells[0].OwningRow;
            var data = new Dictionary<string, string>();
            
            foreach (DataGridViewCell cell in row.Cells)
                data.Add(cell.OwningColumn.HeaderText, cell.Value.ToString());

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);


            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.DeleteData(dropTabelle.SelectedItem.ToString(), data);

            GetData();
        }
        private void GetData()
        {
            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();

            var table = database.GetFullTable(dropTabelle.SelectedItem.ToString());
            database.Disconnect();

            if (table.Columns.Contains("Age"))
                table.Columns.Remove("Age");

            if (table.Columns.Contains("Gender"))
                table.Columns.Remove("Gender");

            gridData.DataSource = table;
        }

        private void GetDataFiltered()
        {
            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            var table = database.GetDataFiltered(dropTabelle.SelectedItem.ToString(), Filters);
            database.Disconnect();

            if (table.Columns.Contains("Age"))
                table.Columns.Remove("Age");

            if (table.Columns.Contains("Gender"))
                table.Columns.Remove("Gender");

            gridData.DataSource = table;
        }

        private void OnFilterAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Texts))
                return;
            if (Filters.ContainsKey(dropFilter.SelectedItem.ToString()))
                Filters.Remove(dropFilter.SelectedItem.ToString());
            
            Filters.Add(dropFilter.SelectedItem.ToString(), tbFilter.Texts);
            GetDataFiltered();
            UpdateFiltered();

        }

        private void UpdateFiltered()
        {
            tbFilter.Text = "";
            tbListFilters.Texts = "";

            foreach (var item in Filters)
                if (tbListFilters.Texts == "") tbListFilters.Texts += $"[{item.Key}]: {item.Value}";
                else tbListFilters.Texts += $", {item.Key}: {item.Value}";

            GetDataFiltered();
        }

        private void OnReset(object sender, EventArgs e)
        {
            tbListFilters.Texts = "";
            Filters.Clear();
            GetData();
        }

        private void OnButtonShow(object sender, EventArgs e)
        {

        }
    }
}
