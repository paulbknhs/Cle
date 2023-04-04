using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDMS_Lebensberatung.cs;
using static System.DateTime;

namespace CDMS_Lebensberatung.UserControls
{
    public partial class FrameHome : UserControl
    {
        public FrameHome()
        {
            InitializeComponent();
        }

        private void OnFrameLoad(object sender, EventArgs e)
        {
            var name = Environment.UserName;
            var wochentag = Lists.Wochentage[(int)Now.DayOfWeek];

            labelHallo.Text = $"Hallo {name}!";

            labelDatum.Text = $"{wochentag}, der {Now.Day}.{Now.Month}.{Now.Year}";
        }
    }
}
