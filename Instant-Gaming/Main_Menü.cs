﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instant_Gaming
{
    public partial class Main_Menü : Form
    {
        int ID;
        string Tabelle; 
        public Main_Menü(int id , string tb, bool Admin)
        {
            InitializeComponent();
            ID = id;
            Tabelle = tb; 
        }

        private void Main_Menü_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Einkauf eink = new Einkauf(ID,Tabelle);
            eink.Show();
            this.Visible = false; 
        }
    }
}
