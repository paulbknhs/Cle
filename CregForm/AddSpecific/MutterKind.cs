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
using CregForm.Resources.classes;

namespace CregForm.AddSpecific
{
    public partial class MutterKind : UserControl
    {
        public MutterKind()
        {
            InitializeComponent();
        }

        private void MutterKind_Load(object sender, EventArgs e)
        {
            dropAntrag.DataSource = LSTS.MuKiAntrag;
            dropErwerb.DataSource = LSTS.MuKiErwerb;
            dropKommu.DataSource = LSTS.MuKiKommunikation;
            dropStaat.DataSource = LSTS.MuKiStaat;
            dropStand.DataSource = LSTS.MuKiLebensstand;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            DICT.MutterKind.Clear();

            Dictionary<string, string> toAdd =
                new()
                {
                    { "Jahr", "" },
                    { "Anmeldenummer", "" }
                };
            foreach (KeyValuePair<string, string> pair in toAdd)
            {
                if (DICT.Allgemein.ContainsKey(pair.Key))
                {
                    DICT.MutterKind.Add(pair.Key, DICT.Allgemein[pair.Key]);
                }
            }

            DICT.MutterKind.Add("Alter", DICT.Allgemein["Erwachsene*r 1"][..2]);

            DSTR.StoreDropDownContent(this, DICT.MutterKind);
            DSTR.StoreNumBoxContent(this, DICT.MutterKind);

            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.InsertData("Mutter Kind", DICT.MutterKind);
            database.Disconnect();
        }
    }
}
