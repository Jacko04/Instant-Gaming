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
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader; 
        public Profiel_Übersicht(int Id)
        {
           
            InitializeComponent();
            KiD = Id;


        }
        public void Kunden()
        {
            // Methode um die Tabelle Produkte zu laden
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * from Kunden where KiD = " + KiD;
            try
            {
                con.Open();
                Kundeneinlesen();
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void Kundeneinlesen()
        {
            // Mehtode um Daten aus der Datenbank zu lesen
            
            reader = cmd.ExecuteReader();
            reader.Read();
            txt_KiD.Text = reader.GetInt32(0).ToString();
            txt_Vorname.Text = reader.GetString(1).ToString();
            txt_Nachname.Text = reader.GetString(2).ToString();
            txt_Email.Text = reader.GetString(3).ToString();
            txt_Adresse.Text = reader.GetString(4).ToString();
            txt_TelNr.Text = reader.GetInt32(5).ToString();
            txt_Passwort.Text = reader.GetString(6).ToString();
           
         

        }

        private void Profiel_Übersicht_Load(object sender, EventArgs e)
        {

            Kunden();
        }
        //Metoden

        //Dataggridview abfrage



    }
}
