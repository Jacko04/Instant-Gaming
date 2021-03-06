
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
    public partial class Verkauf : Form
    {
        //Anmelde_formular A = new Anmelde_formular();
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader;
        string sql;
        decimal Gespreis;
        decimal Minuspreis;
        bool Admin;
        int Row;
        int KiD;
        string Tab;
        int anzahl = 0;

        public Verkauf(int id, string Tabelle,bool admin)
        {
            InitializeComponent();
            KiD = id;
            Tab = Tabelle;
            Admin = admin;
            Einlesen();
            foreach (DataGridViewColumn colum in dgv_Verkauf.Columns)
            {
                colum.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (Tab == "Kunde")
            {
                lbl_uberschrift.Text = "Einkauf";
            }
            else
            {
                lbl_uberschrift.Text = "Verkauf";
            }
        }

        public void Verbinden(string sql)
        {
            //Methode zum Verbinden
            con.Close();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
        }

        public void Einlesen()
        {
            //Daten in Datagridview einlesen
            dgv_Verkauf.Rows.Clear();
            sql = "select * from Produkt";
            Verbinden(sql);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Verkauf.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetInt32(3), reader.GetString(4));
            }
            reader.Close();
            con.Close();
        }

        private void btn_kaufen_Click(object sender, EventArgs e)
        {
            if (Tab == "Kunden")
            {
                int RiD = 0;
                //RiD erstellen
                sql = "select MAX(RiD) from Rechnung";
                Verbinden(sql);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RiD = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
                RiD++;

                for (int i = 0; i < lst_Warenkorb.Items.Count; i++)
                {

                    
                    int PiD = 0;
                    decimal Kosten = 0;
                    string Adresse = "";
                    string Key;

                    //Kosten aus datenbank lesen
                    sql = "select Preis from Produkt where Name = '" + lst_Warenkorb.Items[i] + "'";
                    Verbinden(sql);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Kosten = reader.GetDecimal(0);
                    }
                    reader.Close();
                    con.Close();

                    //bestellungsanzahl
                    sql = "select Anzahl from Produkt where Name = '" + lst_Warenkorb.Items[i] + "'";
                    Verbinden(sql);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        anzahl = reader.GetInt32(0);
                    }
                    reader.Close();
                    con.Close();

                    //PiD aus datenbank lesen
                    sql = "select PiD from Produkt where Name = '" + lst_Warenkorb.Items[i] + "'";
                    Verbinden(sql);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PiD = reader.GetInt32(0);
                    }
                    reader.Close();
                    con.Close();

                    //Adresse aus datenbank lesen
                    sql = "select Adresse from Kunden where KiD = " + KiD;
                    Verbinden(sql);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Adresse = reader.GetString(0);
                    }
                    reader.Close();
                    con.Close();

                    //Keygenerator
                    var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var Charsarr = new char[8];
                    var random = new Random();

                    for (int u = 0; u < Charsarr.Length; u++)
                    {
                        Charsarr[u] = characters[random.Next(characters.Length)];
                    }

                    var resultString = new String(Charsarr);
                    Key = resultString;

                    if (anzahl > 0)
                    {

                        //Bestand wird aktuallisiert 
                        anzahl--;
                        sql = "UPDATE Produkt SET Anzahl = " + anzahl + " where Name = '" + lst_Warenkorb.Items[i].ToString() + "'";
                        Verbinden(sql);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Einlesen();

                        //DB eintrag Rechnung
                        sql = "INSERT INTO Rechnung (RiD, PiD, KiD, Datum, Kosten, Adresse, [Key]) VALUES (" + RiD + "," + PiD + "," + KiD + ",DATE(),'" + Kosten + "','" + Adresse + "','" + Key + "');";
                        Verbinden(sql);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (anzahl > 0)
                {
                    lst_Warenkorb.Items.Clear();
                    lbl_Gespreis.Text = "0";
                }
            }
        }

        private void btn_entfernen_Click(object sender, EventArgs e)
        {
            //Daten werden aus dem Warenkorb entfernt
            if (lst_Warenkorb.SelectedItem != null)
            {
                sql = "select Preis from Produkt where Name = '" + lst_Warenkorb.SelectedItem.ToString() + "' ";
                Verbinden(sql);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Minuspreis = reader.GetDecimal(0);
                }
                reader.Close();
                con.Close();
                Gespreis -= Minuspreis;
                lbl_Gespreis.Text = Gespreis.ToString();
                lst_Warenkorb.Items.RemoveAt(lst_Warenkorb.SelectedIndex);
            }
        }

        private void dgv_Verkauf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Daten werden in den Warenkorb gelesen
            Row = e.RowIndex;
            lst_Warenkorb.Items.Add(dgv_Verkauf.Rows[Row].Cells[1].Value.ToString());
            Gespreis += Convert.ToDecimal(dgv_Verkauf.Rows[Row].Cells[2].Value);
            lbl_Gespreis.Text = Gespreis.ToString();
        }

        private void btn_rechnungsform_Click(object sender, EventArgs e)
        {
            if (Tab == "Kunden")
            {
                Rechnung Rechnung = new Rechnung(KiD, Tab,Admin);
                Rechnung.Show();
                this.Hide();
            }
        }

        private void btn_zurück_Click(object sender, EventArgs e)
        {
            Main_Menü mn = new Main_Menü(KiD, Tab, Admin);
            mn.Show();
            this.Visible = false; 
        }

        private void Verkauf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
