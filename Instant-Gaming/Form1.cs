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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        public Form1()
        {
            InitializeComponent();
            //testfunktion();
        }
        //private void testfunktion()
        //{
        //    int ID;
        //    string Email = "Jkonietzny@mymail.none";
        //    string Passwort = "1";

        //    con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Instant Gaming Verkauf.mdb ";
        //    cmd.Connection = con;
        //    //cmd.CommandText = "Select KiD from Kunden where 'E-Mail' = '" + Email + "' and passwort = '" + Passwort + "'";
        //    cmd.CommandText = "select * from Kunden where E-Mail = '" + Email + "'" ;
        //    con.Open();
        //    reader = cmd.ExecuteReader();


        //    while (reader.Read())
        //    {
        //        ID = reader.GetInt32(0);
        //        MessageBox.Show("Ihre ID ist = " + ID);
        //    }
        //    reader.Close();

        //    con.Close();
        //}
    }
}
