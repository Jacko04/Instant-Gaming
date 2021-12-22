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
        Registration_Form registration;
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
        bool Fehler = false;


        string Vorname;
        string Nachname;
        string Email;
        string Adresse;
        int TelNr;
        string Reg_Passwort; 

        public Anmelde_formular( )
        {
            InitializeComponent();
            
        }
        
        private void lbl_Registrieren_Click(object sender, EventArgs e)
        {
            Registration_Form registration = new Registration_Form();
            registration.Show();
            this.Visible = false;

        }

        private void btn_Bestätigen_Click(object sender, EventArgs e)
        {
            Überprüfen();
        }

        
        //Methoden
        //Methode für Anmelden#
        public void Überprüfen()
        {   //for schleife zu überprüfung der 2 Tabellen
            try
            {
                Fehler = true;
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
                        if (ID == reader.GetInt32(0) && Passwort == reader.GetString(Zahlen[i]))
                        {
                            if (i == 0)
                            {
                                if (reader.GetBoolean(6) == true)
                                {
                                    Ladenvorgang = true;
                                    Admin = true;
                                    Tabelle = "Mitarbeiter";
                                    Main_menü = new Main_Menü(ID, Tabelle, Admin);
                                    Main_menü.Visible = true;
                                    Fehler = false; 
                                    this.Visible = false;
                                    
                                }
                                else
                                {
                                    Ladenvorgang = true;
                                    Admin = false;
                                    Tabelle = "Mitarbeiter";
                                    Main_menü = new Main_Menü(ID, Tabelle, Admin);
                                    Main_menü.Visible = true;
                                    Fehler = false; 
                                    this.Visible = false;
                                    

                                }
                            }
                            else if (i == 1)
                            {
                                Tabelle = "Kunden";
                                Ladenvorgang = true;
                                Admin = false;
                                Main_menü = new Main_Menü(ID, Tabelle, Admin);
                                Main_menü.Visible = true;
                                Fehler = false; 
                                this.Visible = false;
                                
                                
                            }
                        }
                        
                    }
                    reader.Close();
                    con.Close();
                }
                if (Fehler == true)
                {
                    MessageBox.Show("Es wurde wohl etwas falsch eingegeben , überprüfen sie nochmal ihre eingaben");
                    con.Close();
                }

            }
            catch(Exception)
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

        private void Kunden_Hinzufügen()
        {
            //Zusatz werte 
            int ID;
            try
            {
                Vorname = Convert.ToString(txt_Vorname.Text);
                Nachname = Convert.ToString(txt_Nachname.Text);
                Email = Convert.ToString(txt_Email.Text);
                Adresse = Convert.ToString(txt_Adresse.Text);
                TelNr = Convert.ToInt32(txt_TelNr.Text);
                Passwort = Convert.ToString(txt_Reg_Passwort.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //Werte für Den Sql befehl werden geholt
         
            try
            {
                  con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb ";
                  cmd.Connection = con;

                   //Kunden Hinzufügen SQL befehl 
                    con.Open();
                   cmd.CommandText = "INSERT INTO Kunden ([Vorname] , [Nachname] , [E-Mail] , [Adresse] , [Tel-Nr] , [passwort]) VALUES ('" + Vorname + "' , '" + Nachname + "', '" + Email + "' ,'" + Adresse + "', " + TelNr + " ,'" + Reg_Passwort + "')  ";
                    cmd.ExecuteNonQuery();
                   con.Close();


                   // ID Ausgabe für den Kunden 
                    //SQL Befehl
                    cmd.CommandText = "Select * from Kunden where `E-Mail` = '" + Email + "' and passwort = '" + Reg_Passwort + "'";

                     //Auslesen des Wertes
                     con.Open();
                     reader = cmd.ExecuteReader();


                    reader.Read();

                    ID = reader.GetInt32(0);

                    //Ausgabe der ID an den Kunden
                    MessageBox.Show("Ihre ID ist = " + ID);

                    reader.Close();
                    panel_Registrieren.Visible = false;
                    panel_Anmelden.Visible = true;

            }
            catch
            {
                MessageBox.Show("Da ist wohl etwas schief gelaufen , beachten sie das die Telefon nummer nicht länger als 8 zeichen beihalten darf");
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reg_Bestätigen_Click(object sender, EventArgs e)
        {
            Kunden_Hinzufügen();
            
        }

        private void btn_Anmeldenoffnen_Click(object sender, EventArgs e)
        {
            panel_Registrieren.Visible = false;
            panel_Anmelden.Visible = true;
        }

        private void btn_Passwort_zeigen_Click(object sender, EventArgs e)
        {
            int Zähler = 0;
            if (Zähler == 0)
            {
                txt_Passwort.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Passwort.UseSystemPasswordChar = true;
            }
            Zähler++;
            if (Zähler == 2)
            {
                Zähler = 0;
            }
           
        }

        private void Anmelde_formular_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Passwort_zeigen_Click_1(object sender, EventArgs e)
        {
            if (txt_Passwort.UseSystemPasswordChar == true)
            {
                txt_Passwort.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Passwort.UseSystemPasswordChar = true;
            }
        }
    }
}
