using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
