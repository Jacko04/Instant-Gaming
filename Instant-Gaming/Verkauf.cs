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
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader;
        string sql;

        public Verkauf()
        {
            InitializeComponent();
            Einlesen();
        }

        public void Verbinden(string sql)
        {
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
            
        }

        public void Einlesen()
        {
            sql = "select * from Produkt";
            Verbinden(sql);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv_Verkauf.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2) + " €", reader.GetInt32(3), reader.GetString(4));
            }
            reader.Close();
            con.Close();
        }
    }
}
