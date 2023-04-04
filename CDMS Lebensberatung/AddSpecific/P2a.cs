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
using CDMS_Lebensberatung.Resources.classes;

namespace CDMS_Lebensberatung.AddSpecific
{
    public partial class P2a : UserControl
    {
        public P2a()
        {
            InitializeComponent();
        }

        private void P2a_Load(object sender, EventArgs e)
        {
            dropErwerb.DataSource = LSTS.P2aErwerb;
            dropStand.DataSource = LSTS.P2aStand;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            DICT.P2a.Clear();
            
            DICT.P2a.Add("Jahr", DICT.Allgemein["Jahr"]);
            DSTR.StoreDropDownContent(this, DICT.P2a);
            DSTR.StoreNumBoxContent(this, DICT.P2a);

            var result = DSTR.ValidateEntries(DICT.P2a);
            if (result != DialogResult.OK) return;

            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.InsertStringDict("§ 2a", DICT.P2a);
            database.Disconnect();
        }
    }
}
