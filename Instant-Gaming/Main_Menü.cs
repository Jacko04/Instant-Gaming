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
        int ID;
        string Tabelle;
        bool admin;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Einkauf eink = new Einkauf(ID,Tabelle);
            eink.Show();
            this.Visible = false; 
        }

       
    }
}
