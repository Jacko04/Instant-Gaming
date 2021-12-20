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
using System.Drawing.Printing;

namespace Instant_Gaming
{
    public partial class Rechnungsvorlage : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader;
        string sql;

        public Image img = null;
        

        int Rnr;
        int knr;
        string Adress;
        string datum;
        string name;
        string mail;
        string pkey;
        int tel;
        int Pnr;
       

        public Rechnungsvorlage(int RiD,int KiD,string Datum)
        {
            InitializeComponent();
            Rnr = RiD;
            knr = KiD;
            datum = Datum;
            Labelladen();
        }

        public void Verbinden(string sql)
        {
            //Methode zum Verbinden
            con.Close();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
        }

        private void Labelladen()
        {
            //Kundenname suchen
            sql = "select Vorname,Nachname from Kunden where KiD = "+ knr +";";
            Verbinden(sql);
            while (reader.Read())
            {
                name = reader.GetString(0) + " " + reader.GetString(1);
            }
            con.Close();
            reader.Close();

            //email suchen
            sql = "select `E-Mail` from Kunden where KiD = " + knr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                mail = reader.GetString(0);
            }
            con.Close();
            reader.Close();

            //telefonnummer suchen
            sql = "select `Tel-Nr` from Kunden where KiD = " + knr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                tel = reader.GetInt32(0);
            }
            con.Close();
            reader.Close();

            //Adresse suchen
            sql = "select Adresse from Kunden where KiD = " + knr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                Adress = reader.GetString(0);
            }
            con.Close();
            reader.Close();

            //Produkte suche
            sql = "select PiD from Rechnung where RiD = " + Rnr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                Pnr = reader.GetInt32(0);
            }
            con.Close();
            reader.Close();

            //Key suche
            sql = "select [Key] from Rechnung where RiD = " + Rnr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                pkey = reader.GetString(0);
            }
            con.Close();
            reader.Close();

            sql = "select PiD,Name,Preis,Kategorie from Produkt where PiD = " + Pnr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                dgv_Produkte.Rows.Add(reader.GetInt32(0),reader.GetString(1),reader.GetDecimal(2),pkey);
            }
            con.Close();
            reader.Close();

            lbl_rechnungsnr.Text = Rnr.ToString();
            lbl_KiD.Text = knr.ToString();
            lbl_name.Text = name;
            lbl_Adresse.Text = Adress;
            lbl_mail.Text = mail;
            lbl_tel.Text = tel.ToString();
            lbl_datum.Text = datum;
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            p_pdf = pnl;
            
        }

        private void pic_drucken_Click(object sender, EventArgs e)
        {

        }
    }
}
