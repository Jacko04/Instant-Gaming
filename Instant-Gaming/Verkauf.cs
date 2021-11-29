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
        decimal Gespreis;
        decimal Minuspreis;

        public Verkauf()
        {
            InitializeComponent();
            Einlesen();
        }

        public void Verbinden(string sql)
        {
            //Methode zum Verbinden
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb";
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
            
        }

        public void Einlesen()
        {
            //Daten in Datagridview einlesen
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

        private void dgv_Verkauf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Daten werden in den Warenkorb gelesen
            int Row = e.RowIndex;
            lst_Warenkorb.Items.Add(dgv_Verkauf.Rows[Row].Cells[1].Value.ToString());
            Gespreis += Convert.ToDecimal(dgv_Verkauf.Rows[Row].Cells[2].Value);
            lbl_Gespreis.Text = Gespreis.ToString();
        }
    }
}
