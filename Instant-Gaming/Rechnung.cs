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
            int Anzahleinträge = 0;
            sql = "select MAX(RiD) from Rechnung";
            Verbinden(sql);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Anzahleinträge = reader.GetInt32(0);
            }
            con.Close();
            reader.Close();
            sql = "select DISTINCT RiD from Rechnung where KiD = " + Kid;
            Verbinden(sql);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Rechnungen.Rows.Add(reader.GetInt32(0));
                //Ridload.Add(reader.GetInt32(0));
            }
            con.Close();
            reader.Close();

            //for (int i = 0; i < Anzahleinträge; i++)
            //{
            //    sql = "select DESTINCT CONVERT( date, GETDATE() ) from Rechnung where KiD =" + Kid;
            //    Verbinden(sql);
            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        dgv_Rechnungen.Rows.Add(Ridload[i], reader.GetDateTime(0));
            //    }
            //    con.Close();
            //    reader.Close();
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
           
        }
    }
}
