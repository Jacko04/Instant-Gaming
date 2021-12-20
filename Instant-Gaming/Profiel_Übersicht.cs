using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Instant_Gaming
{
    public partial class Profiel_Übersicht : Form
    {
        int KiD;
        public Profiel_Übersicht(int Id)
        {
            KiD = Id;
            InitializeComponent();
        }


        //Metoden

        //Dataggridview abfrage
        public void dgv_Befehl(int ID)
        {

        }


    }
}
