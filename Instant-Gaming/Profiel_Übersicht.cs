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
        bool Admin = false; 
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader; 
        public Profiel_Übersicht(int Id)
        {
           
            InitializeComponent();
            KiD = Id;


        }
        // Methoden um auf die Daten aus der Datenbank zu zugreifen 
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
        public void Rechnungen()
        {
            // Methode um die Tabelle Produkte zu laden
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * from Rechnung where KiD = " + KiD;
            try
            {
                con.Open();
                Rechnungeneinlesen();
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        
        public void Rechnungeneinlesen()
        {

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Rechnungen.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetDecimal(4), reader.GetString(5), reader.GetString(6));
            }
            reader.Close();
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

        // Methoden benutzen um die Daten einzulesen
        private void Profiel_Übersicht_Load(object sender, EventArgs e)
        {
            lbl_DateTime.Text = "Aktuelle Uhrzeit : " + DateTime.Now.ToLongTimeString();
            Uhrzeit.Start();
            Rechnungen();
            Kunden();
        }

        private void btn_Rechnungsvorlageerstellen_Click(object sender, EventArgs e)
        {
            // verweist auf die Rechnungsform 
            Rechnung rng = new Rechnung(KiD,"Kunden",Admin);
            rng.Show();
            this.Visible = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verweist auf Main Menü und ist der Zurück Button
            Main_Menü mn = new Main_Menü(KiD, "Kunden", Admin);
            mn.Show();
            this.Visible = false; 
        }

        private void Uhrzeit_Tick(object sender, EventArgs e)
        {
            lbl_DateTime.Text = "Aktuelle Uhrzeit : " + DateTime.Now.ToLongTimeString();
        }
        //Metoden

        //Dataggridview abfrage



    }
}
