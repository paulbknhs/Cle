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
    }
}
