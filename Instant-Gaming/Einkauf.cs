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
    public partial class Einkauf : Form
    {
        // DB Connection Variablen 
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

       
        Anmelde_formular amf = new Anmelde_formular();
       
        OleDbDataReader reader;
        int anzahl;
        int anzahlerhöhen;
        int zeilenindex;
        decimal Gesamtkosten;
        decimal halbenPreis;
        //Variablen für neue Produkte 
        int NeueProdukte_anzahl;
        string NeueProdukte_Name;
        decimal NeueProdukte_Preis;
        string NeueProdukte_Kategorie;





        public Einkauf()
        {

            InitializeComponent();
            // Die meisten panels werden zum Anfang hin versteckt
            panel_Produkte.Visible = false;
            panel_Einkauf.Visible = false;
            panel_NeueProdukte.Visible = false;
            panel_Produkte_Kaufen.Visible = false;
            panel_Einkauf_Verwaltung.Visible = false;
            lbl_DateTime.Text = "Aktuelle Uhrzeit : " + DateTime.Now.ToLongTimeString();
            Uhrzeit.Start();

        }
        public void Produkte()
        {
            // Methode um die Tabelle Produkte zu laden
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * from Produkt";
            try
            {
                con.Open();
                ProdukteEinlesen();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public void ProdukteEinlesen()
        {
            // Mehtode um Daten aus der Datenbank zu lesen
            dgv_Produkte.Rows.Clear();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Produkte.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetInt32(3), reader.GetString(4));
            }
            reader.Close();
          
        }
        // Methode um die Datensätze der Einkaufstabelle anzuzeigen
        public void Einkauftabelle()
        {
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * from Einkauf";
            try
            {
                con.Open();
                Einkaufsdaten();
                con.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Einkaufsdaten()
        {
            // Die Daten von der Einkaufs Access Tabelle werden eingefügt mit Hilfe eines Readers 
            dgv_Einkauftabelle.Rows.Clear();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Einkauftabelle.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetDecimal(2), reader.GetInt32(3));
            }
            reader.Close();
        }

        private void btn_Produkte_Click(object sender, EventArgs e)
        {
            //  Produkt panel anzeigen und die Daten einfügen
            panel_Produkte.Visible = true;
            Produkte(); 
        }

        private void dgv_Produkte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Produkte in die einzelnen Textboxen aufteilen
            zeilenindex = e.RowIndex;
            txt_PiD.Text = dgv_Produkte.Rows[zeilenindex].Cells[0].Value.ToString();
            txt_name.Text = dgv_Produkte.Rows[zeilenindex].Cells[1].Value.ToString();
            txt_Preis.Text = dgv_Produkte.Rows[zeilenindex].Cells[2].Value.ToString();
            txt_Anzahl.Text = dgv_Produkte.Rows[zeilenindex].Cells[3].Value.ToString();
            txt_Kategorie.Text = dgv_Produkte.Rows[zeilenindex].Cells[4].Value.ToString();
             anzahl = int.Parse(txt_Anzahl.Text);
            anzahlerhöhen = 0;
            numeric_Anzahl.Value = anzahlerhöhen;
            halbenPreis = Convert.ToDecimal(dgv_Produkte.Rows[zeilenindex].Cells[2].Value) / 2;
          
  
            
        }

        private void btn_Produkte_kaufen_Click(object sender, EventArgs e)
        {
            // Panel um produkte zu kaufen zu erhöhen anzeigen
            
            if (panel_Produkte_Kaufen.Visible == false)
            {
                panel_Produkte_Kaufen.Visible = true;
                panel_NeueProdukte.Visible = false; 
                
            }
            else
            {
                panel_Produkte_Kaufen.Visible = false;
                
            }
        }

        private void txt_Anzahl_TextChanged(object sender, EventArgs e)
        {
            // Variablen anzahl in der Txt_Anzahl deklariert 
            try
            {
                anzahl = Convert.ToInt32(txt_Anzahl.Text.ToString());

            }
            catch (Exception)
            {
                txt_Anzahl.Clear();
            }
        }

        private void numeric_Anzahl_ValueChanged(object sender, EventArgs e)
        {
            // Gesamtkosten werden berechnet, wo die Anzahl der Produkte aufgefüllt werden
            anzahlerhöhen = int.Parse(numeric_Anzahl.Value.ToString());
            Gesamtkosten = halbenPreis * anzahlerhöhen;
            lbl_Gesamtkosten.Text = "Gesamtkosten : " + Gesamtkosten;
        }

        private void btn_Einkaufen_Click(object sender, EventArgs e)
        {

            //Anzahl der Spiele erhöhen um den Laden wieder mit Spielen aufzufüllen
            int id = Convert.ToInt32(txt_PiD.Text);
            anzahl = anzahl + anzahlerhöhen;
            DialogResult dr = MessageBox.Show("Möchtest du das Produkt : " + txt_name.Text + " in der Anzahl : " + anzahlerhöhen + " erhöhen", "Eilemeldung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Anwendung um die Produkt Tabelle zu aktualisieren und einen neuen Datensatz 
                // in die Einkaufstabelle hinzuzufügen
                con.Open();
                cmd.CommandText = "Update Produkt Set Anzahl = " + anzahl + " Where PiD = " + id;
                cmd.ExecuteNonQuery();
                con.Close();
                Produkte();
               
                con.Open();
                cmd.CommandText = "Insert Into Einkauf (PiD,Anzahl,Gesamtkosten,MiD) Values( " + txt_PiD.Text + ", " + anzahlerhöhen + ", " + Gesamtkosten + ", " + amf.get_ID() + ");";
                cmd.ExecuteNonQuery();
                con.Close();
                Einkauftabelle();
                anzahlerhöhen = 0;
                numeric_Anzahl.Value = anzahlerhöhen;

            }
            if (dr == DialogResult.No)
            {
                anzahlerhöhen = 0;
                numeric_Anzahl.Value = anzahlerhöhen;
               
            }



        }

        private void btn_Einkaufstabelle_Click(object sender, EventArgs e)
        {
            // Panels werden sichtbar oder versteckt
            panel_Produkte.Visible = false;
            panel_Einkauf.Visible = true;
        }

        private void btn_Hinzufügen_Click(object sender, EventArgs e)
        {
            // Variablen deklaration und Neue Produkte hinzufügen können
            decimal Gesamtkosten; 
            NeueProdukte_Name = Convert.ToString(txt_NeueProdukte_Name.Text);
            NeueProdukte_anzahl = Convert.ToInt32(nup_NeueProdukte_Anzahl.Value);
            NeueProdukte_Kategorie = Convert.ToString(txt_NeueProdukte_Kategorie.Text);
            Gesamtkosten = NeueProdukte_Preis * NeueProdukte_anzahl;

            con.Open();
            cmd.CommandText = "Insert Into Produkt (Name,Preis,Anzahl,Kategorie) Values ( '" + NeueProdukte_Name + "' , " + NeueProdukte_Preis + ", " + NeueProdukte_anzahl + ", '" + NeueProdukte_Kategorie + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            Produkte();
            txt_NeueProdukte_Kategorie.Clear();
            txt_NeueProdukte_Name.Clear();
            txt_NeueProdukte_Preis.Clear();

            con.Open(); 
            cmd.CommandText = "Insert Into Einkauf (PiD,Anzahl,Gesamtkosten,MiD) Values ( " + dgv_Produkte.Rows.Count + ", "+ NeueProdukte_anzahl + ", " + Gesamtkosten + ", " + 1 + ");";
            cmd.ExecuteNonQuery();
            con.Close();
            Einkauftabelle();
            nup_NeueProdukte_Anzahl.Value = 0;


        }

        private void btn_NeueProdukte_Click(object sender, EventArgs e)
        {
            panel_Produkte_Kaufen.Visible = false;
            panel_NeueProdukte.Visible = true; 
        }

        private void nup_NeueProdukte_Anzahl_ValueChanged(object sender, EventArgs e)
        {
            // Gesamtkosten werden berechnet , für neue Produkte
            NeueProdukte_anzahl = Convert.ToInt32(nup_NeueProdukte_Anzahl.Value);
            Gesamtkosten = NeueProdukte_Preis * NeueProdukte_anzahl;
            lbl_NeueProdukte_Gesamtkosten.Text = "Gesamtkosten : " + Gesamtkosten;
        }

        private void txt_NeueProdukte_Preis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NeueProdukte_Preis = Convert.ToDecimal(txt_NeueProdukte_Preis.Text);
            }
            catch (Exception)
            {
                txt_NeueProdukte_Preis.Clear(); 
            }
        }

        private void btn_Verwaltung_Click(object sender, EventArgs e)
        {
            if (panel_Einkauf_Verwaltung.Visible == false)
            {
                panel_Einkauf_Verwaltung.Visible = true;
            }
            else
            {
                panel_Einkauf_Verwaltung.Visible = false; 
            }
        }

        private void dgv_Einkauftabelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int zeilenindex = e.RowIndex;
            txt_Einkauf_Verwaltung_PiD.Text = dgv_Einkauftabelle.Rows[zeilenindex].Cells[0].Value.ToString();
            txt_Einkauf_Verwaltung_Anzahl.Text = dgv_Einkauftabelle.Rows[zeilenindex].Cells[1].Value.ToString();
            txt_Verwaltung_Einkauf_Gesamtkosten.Text = dgv_Einkauftabelle.Rows[zeilenindex].Cells[2].Value.ToString();
            txt_Einkauf_Verwaltung_MiD.Text = dgv_Einkauftabelle.Rows[zeilenindex].Cells[3].Value.ToString();

        }

        private void Uhrzeit_Tick(object sender, EventArgs e)
        {
            DateTime Uhrzeit = DateTime.Now;
            lbl_DateTime.Text = "Aktuelle Uhrzeit : " + Uhrzeit.ToLongTimeString();
        }
    }
}
