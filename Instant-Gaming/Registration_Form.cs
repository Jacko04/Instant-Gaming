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
    public partial class Registration_Form : Form
    {
        Anmelde_formular anmelde_formular; 

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        string Vorname;
        string Nachname;
        string Email;
        string Adresse;
        int TelNr;
        string Passwort;
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btn_Anmeldenoffnen_Click(object sender, EventArgs e)
        {
            Anmelde_formular anmelde_formular = new Anmelde_formular();
            anmelde_formular.Show();
            this.Visible = false;
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
                cmd.CommandText = "INSERT INTO Kunden ([Vorname] , [Nachname] , [E-Mail] , [Adresse] , [Tel-Nr] , [passwort]) VALUES ('" + Vorname + "' , '" + Nachname + "', '" + Email + "' ,'" + Adresse + "', " + TelNr + " ,'" + Passwort + "')  ";
                cmd.ExecuteNonQuery();
                con.Close();


                // ID Ausgabe für den Kunden 
                //SQL Befehl
                cmd.CommandText = "Select * from Kunden where `E-Mail` = '" + Email + "' and passwort = '" + Passwort + "'";

                //Auslesen des Wertes
                con.Open();
                reader = cmd.ExecuteReader();


                reader.Read();

                ID = reader.GetInt32(0);

                //Ausgabe der ID an den Kunden
                MessageBox.Show("Ihre ID ist = " + ID);

                reader.Close();

                Anmelde_formular anmelde_formular = new Anmelde_formular();
                anmelde_formular.Show();
                this.Visible = false;

            }
            catch
            {
                MessageBox.Show("Da ist wohl etwas schief gelaufen , beachten sie das die Telefon nummer nicht länger als 8 zeichen beihalten darf");
            }
        }

        private void btn_Reg_Bestätigen_Click(object sender, EventArgs e)
        {
            Kunden_Hinzufügen(); 
        }

        private void Registration_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
