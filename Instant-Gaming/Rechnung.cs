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
    public partial class Rechnung : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader;
        string sql;
        int Kid = 1;
        int ID;
        string Tab;
        List<int> Ridload = new List<int>();

        private System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();

        public Rechnung(int id ,string Tabelle)
        {
            InitializeComponent();
            ID = id;
            Tab = Tabelle;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Verkauf Verkauf = new Verkauf(ID, Tab);
            Verkauf.Show();
            this.Hide();
        }

        private void Rechnung_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < dgv_Rechnungen.Rows.Count + 1; i++)
            //{
                sql = "select DISTINCT RiD from Rechnung where KiD =" + Kid;
                Verbinden(sql);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                //Ridload.Add(reader.GetInt32(0));
                dgv_Rechnungen.Rows.Add(reader.GetInt32(0));
                }
                con.Close();
                reader.Close();
                //sql = "select Datum from Rechnung where KiD =" + Kid;
                //Verbinden(sql);
                //reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    dgv_Rechnungen.Rows.Add(Ridload[i], reader.GetDateTime(0));
                //}
                //con.Close();
                //reader.Close();
            //}

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

        private void btn_öffnen_Click(object sender, EventArgs e)
        {
            PrintDialog1.Document = docToPrint;

            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        // The PrintDialog will print the document
        // by handling the document's PrintPage event.
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
    }
}
