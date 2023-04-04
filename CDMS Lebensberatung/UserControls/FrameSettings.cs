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

namespace CDMS_Lebensberatung.UserControls
{
    public partial class FrameSettings : UserControl
    {
        public static string? ConnectionString { get; set; }

        public FrameSettings()
        {
            InitializeComponent();
        }

        private void OnFrameLoad(object sender, EventArgs e)
        {
            Reload();
        }

        private void OnSaveConnectionString(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings.Set("ConnectionString", tbConnectionString.Texts);

            Reload();
        }

        public void Reload()
        {
            tbConnectionString.Texts = ConfigurationManager.AppSettings.Get("ConnectionString");
            tbConnectionString.BorderColor = Color.Green;
            tbConnectionString.BorderFocusColor = Color.Green;

        }

        private void OnTextChange(object sender, EventArgs e)
        {
            tbConnectionString.BorderColor = Color.Red;
            tbConnectionString.BorderFocusColor = Color.Red;
            
        }
    }
}
