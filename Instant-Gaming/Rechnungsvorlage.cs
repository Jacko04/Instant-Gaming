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
    public partial class Rechnungsvorlage : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader;
        string sql;

        int Rnr;
        int knr;
        string Adress;
        string datum;
        string name;
        string mail;
        string tel;
        int Pnr;
       

        public Rechnungsvorlage(int RiD,int KiD,string Datum)
        {
            InitializeComponent();
            Rnr = RiD;
            knr = KiD;
            datum = Datum;
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
            sql = "select Vornamename,Nachname from Kunden where KiD = "+ knr +";";
            Verbinden(sql);
            while (reader.Read())
            {
                name = reader.GetString(0) + reader.GetString(1);
            }
            con.Close();
            reader.Close();

            sql = "select ´E-Mail´ from Kunden where KiD = " + knr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                mail = reader.GetString(0);
            }
            con.Close();
            reader.Close();

            sql = "select ´Tel-Nr´ from Kunden where KiD = " + knr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                tel = reader.GetString(0);
            }
            con.Close();
            reader.Close();

            sql = "select Adresse from Kunden where KiD = " + knr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                Adress = reader.GetString(0);
            }
            con.Close();
            reader.Close();

            sql = "select PiD from Rechnung where RiD = " + Rnr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                Pnr = reader.GetInt32(0);
            }
            con.Close();
            reader.Close();

            sql = "select * from Produkte where PiD = " + Pnr + ";";
            Verbinden(sql);
            while (reader.Read())
            {
                dgv_Produkte.Rows.Add(reader.GetInt32(0),reader.GetString(1),reader.GetDecimal(2),reader.GetString(3));
            }
            con.Close();
            reader.Close();

            lbl_rechnungsnr.Text = Rnr.ToString();
            lbl_KiD.Text = knr.ToString();
            lbl_name.Text = name;
            lbl_Adresse.Text = Adress;
            lbl_mail.Text = mail;
            lbl_tel.Text = tel;
            lbl_datum.Text = datum;
        }
    }
}
