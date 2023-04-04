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
    public partial class AllgSgs : UserControl
    {
        public AllgSgs()
        {
            InitializeComponent();
        }

        private void AllgSgs_Load(object sender, EventArgs e)
        {
            dropErwerb.DataSource = LSTS.AllgSgsErwerb;
            dropStand.DataSource = LSTS.AllgSgsLebensstand;
            dropStaat.DataSource = LSTS.AllgSgsStaat;
            dropAlter.DataSource = LSTS.AllgSgsAlter;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            DICT.AllgSgs.Clear();

            var betroffen = dropAlter.SelectedItem.ToString();
            
            DICT.AllgSgs.Add("Jahr", DICT.Allgemein["Jahr"]);
            DICT.AllgSgs.Add("Alter", DICT.Allgemein[betroffen][..2]);

            DSTR.StoreTextBoxContent(this, DICT.AllgSgs);
            DSTR.StoreDropDownContent(this, DICT.AllgSgs);
            DSTR.StoreNumBoxContent(this, DICT.AllgSgs);

            var result = DSTR.ValidateEntries(DICT.AllgSgs);
            if (result != DialogResult.OK) return;

            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.InsertStringDict("Allgemeine Schwangerschaft", DICT.AllgSgs);
            database.Disconnect();
        }
        

    }
}
