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
    public partial class Rechnung : Form
    {
        public Rechnung()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Verkauf Verkauf = new Verkauf();
            Verkauf.Show();
            this.Hide();
        }

        private void Rechnung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "instant_Gaming_VerkaufDataSet1.Rechnung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.rechnungTableAdapter1.Fill(this.instant_Gaming_VerkaufDataSet1.Rechnung);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "instant_Gaming_VerkaufDataSet.Rechnung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.rechnungTableAdapter.Fill(this.instant_Gaming_VerkaufDataSet.Rechnung);

        }
    }
}
