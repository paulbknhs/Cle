using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCodeAdvance.RJControls;
using CregForm.Resources.classes;

namespace CregForm.AddSpecific
{
    public partial class EheUndLeben : UserControl
    {
        private readonly List<string> _arten =
            new()
            {
                "Anmeldungen",
                "Sprechstunde",
                "Fallverteilung",
                "SV",
                "Weitere Fall.",
                "Gruppensitzung",
                "Beratung",
                "Summe"
            };

        public EheUndLeben()
        {
            InitializeComponent();
        }

        private void EheUndLeben_Load(object sender, EventArgs e)
        {
            dropLeistung.DataSource = LSTS.EheUndLebenLeistung;
            dropWirtschaft.DataSource = LSTS.EheUndLebenWirtschaft;

            foreach (var item in _arten)
                gridStunden.Rows.Add(item, 0);
            gridStunden.Rows[7].ReadOnly = true;
            gridStunden.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            gridStunden.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void OnValueChange(object sender, DataGridViewCellEventArgs e)
        {
            var rowCount = gridStunden.RowCount;
            var sum = 0;

            if (e.RowIndex == 7 || rowCount < 8)
                return;

            for (var i = 0; i < 7; i++)
                if (int.TryParse(gridStunden[1, i].Value?.ToString(), out var value))
                    sum += value;

            gridStunden[1, 7].Value = sum;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            DICT.EheUndLeben.Clear();

            Dictionary<string, string> toAdd =
                new()
                {
                    { "Jahr", "" },
                    { "Anmeldenummer", "" },
                    { "Abgeschlossen", "" }
                };
            foreach (KeyValuePair<string, string> pair in toAdd)
            {
                if (DICT.Allgemein.ContainsKey(pair.Key))
                {
                    DICT.EheUndLeben.Add(pair.Key, DICT.Allgemein[pair.Key]);
                }
            }
            DSTR.StoreTextBoxContent(this, DICT.EheUndLeben);
            DSTR.StoreDropDownContent(this, DICT.EheUndLeben);

            if (!toggleUnbekannt.Checked)
            {
                if (togglePartnerschaft.Checked)
                    DICT.EheUndLeben.Add("Sozialer Hintergrund", toggleKinder.Checked ? "Verpartnert mit Kind" : "Verpartnert ohne Kind");
               
                else if (!togglePartnerschaft.Checked) DICT.EheUndLeben.Add("Sozialer Hintergrund",
                    toggleKinder.Checked ? "Alleinstehend mit Kind" : "Alleinstehend ohne Kind");
                else if (toggleSonstige.Checked) DICT.EheUndLeben.Add("Sozialer Hintergrund", "Sonstige");
            }
            else
                DICT.EheUndLeben.Add("Sozialer Hintergrund", "Unbekannt");

            DSTR.StoreStundenGridContent(this, DICT.EheUndLeben);
            DSTR.StoreCheckBoxContent(groupAnmeldung, DICT.EheUndLeben);

            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.InsertData("Ehe und Leben", DICT.EheUndLeben);
            database.Disconnect();
        }

        private void onToggleUnbekannt(object sender, EventArgs e)
        {
            
            foreach (Control control in Controls)
                if (control.Name != "toggleUnbekannt" && control is RJCodeAdvance.RJControls.RJToggleButton toggle)
                {
                    if (toggleUnbekannt.Checked)
                    {
                        toggle.Checked = false;
                        toggle.Enabled = false;
                    }
                    else
                    {
                        toggle.Enabled = true;
                    }

                }
        }
    }
}
