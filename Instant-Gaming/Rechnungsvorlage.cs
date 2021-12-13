using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instant_Gaming
{
    public partial class Rechnungsvorlage : Form
    {
        public Rechnungsvorlage()
        {
            InitializeComponent();
        }

        private void dgv_Produkte_SelectionChanged(object sender, EventArgs e)
        {
            dgv_Produkte.ClearSelection();
        }
    }
}
