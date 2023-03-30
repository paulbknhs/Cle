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
    public partial class P218 : UserControl
    {
        public P218()
        {
            InitializeComponent();
        }

        private void P218_Load(object sender, EventArgs e)
        {
            dropErwerb.DataSource = LSTS.P218Erwerb;
            dropStaat.DataSource = LSTS.P218Staat;
            dropStand.DataSource = LSTS.P218Stand;
            dropVerhütung.DataSource = LSTS.P218Verhütung;
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            DICT.P218.Clear();

            DICT.P218.Add("Jahr", DICT.Allgemein["Erwachsene*r 1"][..2]);
            DICT.P218.Add("Alter", DICT.Allgemein["Jahr"]);
            
            DSTR.StoreDropDownContent(this, DICT.P218);
            DSTR.StoreTextBoxContent(this, DICT.P218);
            DSTR.StoreNumBoxContent(this, DICT.P218);
            DSTR.StoreToggleContent(this, DICT.P218);
            DSTR.StoreCheckBoxContent(grpAnm, DICT.P218);

            DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            database.Connect();
            database.InsertData("§ 218", DICT.P218);
            database.Disconnect();
        }
    }
}
