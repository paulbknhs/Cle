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
        }
    }
}
