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
        bool Admin;
        int ID;
        string Tab;
        List<int> Ridload = new List<int>();

        int selectedRiD;
        string selectedDatum;

        public Rechnung(int id ,string Tabelle, bool admin)
        {
            InitializeComponent();
            ID = id;
            Tab = Tabelle;
            Admin = admin;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Verkauf Verkauf = new Verkauf(ID, Tab, Admin);
            Verkauf.Show();
            this.Hide();
        }

        private void Rechnung_Load(object sender, EventArgs e)
        {
            dgv_Rechnungen.Rows.Clear();
            sql = "select DISTINCT RiD from Rechnung where KiD = " + Kid;
            Verbinden(sql);
            reader = cmd.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                Ridload.Add(reader.GetInt32(0));
            }
            con.Close();
            reader.Close();

            for (int i = 0; i < Ridload.Count(); i++)
            {
                sql = "select DISTINCT Datum from Rechnung where RiD = " + Ridload[i];
                Verbinden(sql);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgv_Rechnungen.Rows.Add(Ridload[i],reader.GetDateTime(0));
                }
            }
            con.Close();
            reader.Close();
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
            Rechnungsvorlage Rnvorlage = new Rechnungsvorlage(ID,selectedRiD,selectedDatum);
            Rnvorlage.ShowDialog();
        }
        private void dgv_Rechnungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            selectedRiD = Convert.ToInt32(dgv_Rechnungen.Rows[Row].Cells[0].Value);
            selectedDatum = dgv_Rechnungen.Rows[Row].Cells[1].Value.ToString();
        }
    }
}
