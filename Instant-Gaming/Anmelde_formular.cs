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
    public partial class Anmelde_formular : Form
    {

        //Variablen
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        Int64 ID;
        string Passwort;

        

        public Anmelde_formular()
        {
            InitializeComponent();
            
        }

        private void lbl_Registrieren_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bestätigen_Click(object sender, EventArgs e)
        {

        }

        
        //Methoden
        //Methode für Anmelden#
        public void Überprüfen()
        {   //for schleife zu überprüfung der 2 Tabellen
            for (int i = 0; i < 2; i++)
            {
                //Array zum Speichern der Tabellen
                string[] Tabellen = {"Mitarbeiter", "Kunden" };
                //Array zum Definieren der Abfrage
                string[] Kennung = { "MiD", "PiD" };
                //Array If Bedingugen
                int[] Zahlen = { 6, 8 };
                
                //Converten der Infromation aus der Form
                ID = Convert.ToInt64(txt_ID.Text);
                Passwort = Convert.ToString(txt_Passwort.Text);

                //Datenbankverbindung und Abfrage
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb ";
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM " + Tabellen[i] + " WHERE" + Kennung[i] +  "= '" + ID + "' AND passwort = '" + Passwort + "'";
                con.Open();

                try
                {
                    while (reader.Read())
                    {
                        if (ID == reader.GetInt64(0)) ;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
