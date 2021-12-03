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
        Main_Menü Main_menü;
        //Variablen
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        Int64 ID;
        string Passwort;
        bool Admin;
        string Tabelle;
        

        public Anmelde_formular()
        {
            InitializeComponent();
            
        }

        private void lbl_Registrieren_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bestätigen_Click(object sender, EventArgs e)
        {
            Überprüfen();
        }

        
        //Methoden
        //Methode für Anmelden#
        public void Überprüfen()
        {   //for schleife zu überprüfung der 2 Tabellen
            try{
                for (int i = 0; i < 2; i++)
                {
                    //Array zum Speichern der Tabellen
                    string[] Tabellen = {"Mitarbeiter", "Kunden" };
                    //Array zum Definieren der Abfrage
                    string[] Kennung = { "MiD", "KiD" };
                    //Array If Bedingugen
                    int[] Zahlen = { 6, 8 };
               
                    //Converten der Infromation aus der Form
                    ID = Convert.ToInt64(txt_ID.Text);
                    Passwort = Convert.ToString(txt_Passwort.Text);

                    //Datenbankverbindung und Abfrage
                    con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb ";
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "SELECT * FROM " + Tabellen[i] + " WHERE " + Kennung[i] + "= " + ID  + "' AND passwort = '" + Passwort + "'";
                    reader = cmd.ExecuteReader();
                    
                
                 
                
                
                        while (reader.Read())
                        {
                            if (ID == reader.GetInt64(0) && Passwort == reader.GetString(Zahlen[i]) )
                            {
                                if(i == 0)
                                {
                                    if (reader.GetBoolean(6) == true )
                                    {
                                        Admin = true; 
                                        Tabelle = "Mitarbeiter";
                                        Main_menü = new Main_Menü();
                                        Main_menü.Visible = true;
                                        this.Visible = false;
                                    }
                                    else
                                    {
                                        Admin = false;
                                        Tabelle = "Mitarbeiter";
                                        Main_menü = new Main_Menü();
                                        Main_menü.Visible = true;
                                        this.Visible = false;
                                    }
                                }
                                else if (i == 1)
                                {
                                    Tabelle = "Kunden";
                                    Main_menü = new Main_Menü();
                                    Main_menü.Visible = true;
                                    this.Visible = false;
                                }
                            }
                        }
                 }
                

            }
            catch (Exception)
            {

                MessageBox.Show("Es wurde wohl etwas falsch eingegeben , über prüfen sie nochmal ihre eingaben");
                con.Close();
            }
        }

        public Int64 get_ID()
        {
            return ID;
        }
        public string get_Tabelle()
        {
            return Tabelle;
        }

        public bool get_Admin()
        {
            return Admin;
        }
        
    }
}
