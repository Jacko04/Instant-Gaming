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
        List<int> Pnr = new List<int>();
       

        public Rechnungsvorlage(int KiD,int RiD,string Datum)
        {
            InitializeComponent();
            knr = KiD;
            Rnr = RiD;
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
                Pnr.Add(reader.GetInt32(0));
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

            for (int i = 0; i < Pnr.Count; i++)
            {
                sql = "select PiD,Name,Preis from Produkt where PiD = " + Pnr[i] + ";";
                Verbinden(sql);
                while (reader.Read())
                {
                    dgv_Produkte.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), pkey);
                }
                con.Close();
                reader.Close();
            }

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
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void pic_drucken_Click(object sender, EventArgs e)
        {
            Print(this.p_pdf);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.p_pdf.Width / 2), this.p_pdf.Location.Y);
        }

        private void Rechnungsvorlage_Load(object sender, EventArgs e)
        {

        }

        private void Rechnungsvorlage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
