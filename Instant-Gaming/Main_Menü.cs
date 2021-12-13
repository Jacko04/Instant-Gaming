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
        //Variabeln
        int ID;
        string Tabelle;
        bool admin;
        Einkauf einkauf;
        Verkauf verkauf;
        Rechnung rechnung;
        string bearbeitung = "Diese Funktion ist noch in beartbeitung";

        public Main_Menü(int id , string tb, bool Admin)
        {
            InitializeComponent();
            ID = id;
            Tabelle = tb;
            admin = Admin;
            panel_Admin.Visible = false;
            panel_Mitarbeiter.Visible = false;
            panel_Kunden.Visible = false; 
        }

        private void Main_Menü_Load(object sender, EventArgs e)
        {
            if (Tabelle == "Mitarbeiter")
            {
                if (admin ==  true)
                {
                    panel_Kunden.Visible = false;
                    panel_Mitarbeiter.Visible = false;
                    panel_Admin.Visible = true; 
                }
                else
                {
                    panel_Admin.Visible = false;
                    panel_Kunden.Visible = false;
                    panel_Mitarbeiter.Visible = true; 
                }
            
            }
            else
            {
                panel_Admin.Visible = false;
                panel_Mitarbeiter.Visible = false;
                panel_Kunden.Visible = true; 

            }
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            Einkauf eink = new Einkauf(ID,Tabelle);
            eink.Show();
            this.Visible = false; 
        }

        private void btn_Mitarbeiter_Verkauf_Click(object sender, EventArgs e)
        {
            Einkauf();
        }

        private void btn_Mitarbeiter_Einkauf_Click(object sender, EventArgs e)
        {
            Einkauf();
        }

        private void btn_Mitarbeiter_Verwaltung_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bearbeitung);
        }

        private void btn_Mitarbeiter_Rechnung_Click(object sender, EventArgs e)
        {
            Rechnung();
        }

        private void btn_Admin_Verkauf_Click(object sender, EventArgs e)
        {
            Verkauf();
        }

        private void btn_Admin_Einkauf_Click(object sender, EventArgs e)
        {
            Einkauf();
        }

        private void btn_Admin_Verwaltung_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bearbeitung);
        }

        private void btn_Admin_Rechnung_Click(object sender, EventArgs e)
        {
            Rechnung();
        }

        private void btn_Kunden_Profil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bearbeitung);
        }

        private void btn_Kunden_Einkauf_Click(object sender, EventArgs e)
        {
            Verkauf();
        }

        private void btn_Kunden_Rechnung_Click(object sender, EventArgs e)
        {
            Rechnung();
        }

        //Methoden

        //öffnen der Einkaufs form
        public void Einkauf()
        {
            einkauf = new Einkauf(ID, Tabelle);
            einkauf.Visible = true;
            einkauf.Show();
            this.Visible = false;
        }

        //öffnen der Verkaufs form
        public void Verkauf()
        {
           verkauf = new Verkauf(ID , Tabelle);
            einkauf.Visible = true;
            verkauf.Show();
            this.Visible = true;

        }

        public void Rechnung()
        {
            rechnung = new Rechnung( ID , Tabelle);
            einkauf.Visible = true;
            rechnung.Show();
            this.Visible = false;
        }   
    }
}
