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
    }
}
