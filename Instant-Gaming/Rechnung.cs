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
        List<int> Ridload = new List<int>();    

        public Rechnung()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Verkauf Verkauf = new Verkauf();
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
    }
}
