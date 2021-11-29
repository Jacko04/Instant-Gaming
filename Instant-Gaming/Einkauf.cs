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
        OleDbDataReader reader;
        int anzahl;
        int anzahlerhöhen;



        public Einkauf()
        {
            InitializeComponent();
            panel_Produkte.Visible = false; 
        }
        public void Produkte()
        {
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.Connection = con;
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
            cmd.CommandText = "Select * from Produkt";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Produkte.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2) + " €", reader.GetInt32(3), reader.GetString(4));
            }
            reader.Close();
            con.Close();
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
            int zeilenindex = e.RowIndex;
            txt_name.Text = dgv_Produkte.Rows[zeilenindex].Cells[1].Value.ToString();
            txt_Preis.Text = dgv_Produkte.Rows[zeilenindex].Cells[2].Value.ToString();
            txt_Anzahl.Text = dgv_Produkte.Rows[zeilenindex].Cells[3].Value.ToString();
            txt_Kategorie.Text = dgv_Produkte.Rows[zeilenindex].Cells[4].Value.ToString();
             anzahl = int.Parse(txt_Anzahl.Text);
        }

        private void btn_Produkte_kaufen_Click(object sender, EventArgs e)
        {
            // Panel um produkte zu kaufen zu erhöhen anzeigen
            
            if (panel_Produkte_Kaufen.Visible == false)
            {
                panel_Produkte_Kaufen.Visible = true;
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
            anzahlerhöhen = int.Parse(numeric_Anzahl.Value.ToString());
        }
    }
}
