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
       // Einkauf enk = new Einkauf();
        
        int ID;
        string Passwort;
        bool Admin;
        string Tabelle;
        bool Ladenvorgang;
        

        public Anmelde_formular( )
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
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb ";
                cmd.Connection = con;
                for (int i = 0; i < 2; i++)
                {
                    //Array zum Speichern der Tabellen
                    string[] Tabellen = {"Mitarbeiter", "Kunden" };
                    //Array zum Definieren der Abfrage
                    string[] Kennung = { "MiD", "KiD" };
                    //Array If Bedingugen
                    int[] Zahlen = { 8, 6 };
               
                    //Converten der Infromation aus der Form
                    ID = Convert.ToInt32(txt_ID.Text);
                    Passwort = Convert.ToString(txt_Passwort.Text);

                    //Datenbankverbindung und Abfrage
                    cmd.CommandText = "SELECT * FROM " + Tabellen[i] + " WHERE " + Kennung[i] + "= " + ID + " AND passwort = '" + Passwort + "'";
                    con.Open();
                   
                    reader = cmd.ExecuteReader();
                
               
                
                        while (reader.Read())
                        {
                            if (ID == reader.GetInt32(0) && Passwort == reader.GetString(Zahlen[i]) )
                            {
                                if(i == 0)
                                {
                                    if (reader.GetBoolean(6) == true )
                                    {
                                        Ladenvorgang = true;    
                                        Admin = true; 
                                        Tabelle = "Mitarbeiter";
                                        Main_menü = new Main_Menü(ID,Tabelle, Admin);
                                        Main_menü.Visible = true;
                                        this.Visible = false;
                                }
                                    else
                                    {
                                        Ladenvorgang = true;
                                        Admin = false;
                                        Tabelle = "Mitarbeiter";
                                        Main_menü = new Main_Menü(ID,Tabelle, Admin);
                                        Main_menü.Visible = true;
                                        this.Visible = false;

                                }
                                }
                                else if (i == 1)
                                {
                                    Tabelle = "Kunden";
                                    Ladenvorgang = true;
                                    Admin = false; 
                                    Main_menü = new Main_Menü(ID,Tabelle, Admin);
                                    Main_menü.Visible = true;
                                    this.Visible = false;   
                               
                                }
                            }
                        }
                
                   
                    reader.Close();
                    con.Close();
                 }
      

            }
            catch (Exception)
            {

                MessageBox.Show("Es wurde wohl etwas falsch eingegeben , über prüfen sie nochmal ihre eingaben");
                con.Close();
            }
        }

        public int get_ID()
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

        public bool get_Ladevorgang()
        {
            return Ladenvorgang;
        }
        public void WerteÜbermitteln(int id, string tabelle) 
        {
            id = ID;
            tabelle = Tabelle;
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(txt_ID.Text);
            }
            catch (Exception)
            {
                txt_ID.Clear(); 
            }
        }

        private void txt_Passwort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Passwort = Convert.ToString(txt_Passwort.Text);
            }
            catch (Exception)
            {
                txt_Passwort.Clear();
            }
        }
    }
}
