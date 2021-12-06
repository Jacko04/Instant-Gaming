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
    public partial class Main_Menü : Form
    {
        Einkauf einkauf;
        Verkauf verkauf;
        Anmelde_formular anmelde_Formular;
        public Main_Menü()
        {
            InitializeComponent();
           
        }

     
           

        private void Main_Menü_Load(object sender, EventArgs e)
        {
           


                if (anmelde_Formular.get_Tabelle() == "Mitarbeiter")
                {
                    if (anmelde_Formular.get_Admin() == true)
                    {
                        panel_Kunden.Visible = false;
                        panel_Mitarbeiter.Visible = false;
                    }
                    else
                    {
                        panel_Admin.Visible = false;
                        panel_Kunden.Visible = false;
                    }
                }
                else if (anmelde_Formular.get_Tabelle() == "Kunden")
                {
                    panel_Admin.Visible = false;
                    panel_Mitarbeiter.Visible = false;
                }
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (anmelde_Formular.get_Ladevorgang() == true)
        //    {


        //        if (anmelde_Formular.get_Tabelle() == "Mitarbeiter")
        //        {
        //            if (anmelde_Formular.get_Admin() == true)
        //            {
        //                panel_Kunden.Visible = false;
        //                panel_Mitarbeiter.Visible = false;
        //            }
        //            else
        //            {
        //                panel_Admin.Visible = false;
        //                panel_Kunden.Visible = false;
        //            }
        //        }
        //        else if (anmelde_Formular.get_Tabelle() == "Kunden")
        //        {
        //            panel_Admin.Visible = false;
        //            panel_Mitarbeiter.Visible = false;
        //        }
        //    }
        //}
    }
}
