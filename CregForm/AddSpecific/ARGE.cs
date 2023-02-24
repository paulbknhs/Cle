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
    public partial class ARGE : UserControl
    {
        public ARGE()
        {
            InitializeComponent();
        }

        private void ARGE_Load(object sender, EventArgs e)
        {
            dropBasis.DataSource = LSTS.ARGEBasis;
            dropBasisAbbruch.DataSource = LSTS.ARGEAbbruch;
            dropKomplett.DataSource = LSTS.ARGEKomplett;
            dropKomplettAbbruch.DataSource = LSTS.ARGEKomplettAbbruch;
            dropEinsZwei.DataSource = LSTS.ARGE12;
            dropBelastung.DataSource = LSTS.ARGEBelastung;
            dropWochen.DataSource = LSTS.ARGEWochen;
        }
    }
}
