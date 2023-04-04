using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDMS_Lebensberatung.Resources.classes;

namespace CDMS_Lebensberatung.AddSpecific
{
    public partial class ARGE : UserControl
    {
        public ARGE()
        {
            InitializeComponent();
        }

        private void ARGE_Load(object sender, EventArgs e)
        {
            dropBasis.DataSource = LSTS.ARGEBasis;
            dropBasisAbbruch.DataSource = LSTS.ARGEAbbruch;
            dropKomplett.DataSource = LSTS.ARGEKomplett;
            dropKomplettAbbruch.DataSource = LSTS.ARGEKomplettAbbruch;
            dropEinsZwei.DataSource = LSTS.ARGE12;
            dropBelastung.DataSource = LSTS.ARGEBelastung;
            dropWartezeit.DataSource = LSTS.ARGEWochen;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            DICT.ARGE.Clear();

            Dictionary<string, string> toAdd =
                new()
                {
                    { "Jahr", "" },
                    { "Anmeldenummer", "" },
                    { "Abgeschlossen", "" },
                    { "Wohnort", "" },
                    { "Alter", "" },
                    { "Geschlecht", "" },
                    { "Migrationshintergrund", "" }
                };
            foreach (KeyValuePair<string, string> pair in toAdd)
            {
                if (DICT.Allgemein.ContainsKey(pair.Key))
                {
                    DICT.ARGE.Add(pair.Key, DICT.Allgemein[pair.Key]);
                }
            }

            DICT.ARGE.Add("Alter", DICT.Allgemein["Erwachsene*r 1"][..2]);

            var gender = Regex.Replace(DICT.Allgemein["Erwachsene*r 1"], "[^a-z.]", "");
            DICT.ARGE.Add("Geschlecht", gender);

            DSTR.StoreDropDownContent(this, DICT.ARGE);

            var result = DSTR.ValidateEntries(DICT.ARGE);
            if (result != DialogResult.OK) return;

            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.InsertStringDict("ARGE", DICT.ARGE);
            database.Disconnect();
        }
    }
}
