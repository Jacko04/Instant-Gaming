namespace Instant_Gaming
{
    partial class Einkauf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einkauf));
            this.dgv_Einkauftabelle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Produkte = new System.Windows.Forms.DataGridView();
            this.PiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Produkte = new System.Windows.Forms.Panel();
            this.panel_NeueProdukte = new System.Windows.Forms.Panel();
            this.lbl_NeueProdukte_Gesamtkosten = new System.Windows.Forms.Label();
            this.nup_NeueProdukte_Anzahl = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_NeueProdukte_Name = new System.Windows.Forms.TextBox();
            this.txt_NeueProdukte_Preis = new System.Windows.Forms.TextBox();
            this.txt_NeueProdukte_Kategorie = new System.Windows.Forms.TextBox();
            this.panel_Produkte_Kaufen = new System.Windows.Forms.Panel();
            this.lbl_Gesamtkosten = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PiD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric_Anzahl = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Preis = new System.Windows.Forms.TextBox();
            this.txt_Kategorie = new System.Windows.Forms.TextBox();
            this.txt_Anzahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Einkauf = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_Einkauf_Verwaltung = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Einkauf_Verwaltung_MiD = new System.Windows.Forms.TextBox();
            this.txt_Verwaltung_Einkauf_Gesamtkosten = new System.Windows.Forms.TextBox();
            this.txt_Einkauf_Verwaltung_Anzahl = new System.Windows.Forms.TextBox();
            this.txt_Einkauf_Verwaltung_PiD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Uhrzeit = new System.Windows.Forms.Timer(this.components);
            this.btn_Hinzufügen = new System.Windows.Forms.Button();
            this.btn_NeueProdukte = new System.Windows.Forms.Button();
            this.btn_Einkaufen = new System.Windows.Forms.Button();
            this.btn_Produkte_kaufen = new System.Windows.Forms.Button();
            this.btn_Verwaltung = new System.Windows.Forms.Button();
            this.btn_Produkte = new System.Windows.Forms.Button();
            this.btn_Einkaufstabelle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pb_InstantGaming = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Einkauftabelle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produkte)).BeginInit();
            this.panel_Produkte.SuspendLayout();
            this.panel_NeueProdukte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_NeueProdukte_Anzahl)).BeginInit();
            this.panel_Produkte_Kaufen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Anzahl)).BeginInit();
            this.panel_Einkauf.SuspendLayout();
            this.panel_Einkauf_Verwaltung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_InstantGaming)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Einkauftabelle
            // 
            this.dgv_Einkauftabelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Einkauftabelle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Einkauftabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Einkauftabelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_Einkauftabelle.Location = new System.Drawing.Point(26, 67);
            this.dgv_Einkauftabelle.Name = "dgv_Einkauftabelle";
            this.dgv_Einkauftabelle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Einkauftabelle.Size = new System.Drawing.Size(597, 252);
            this.dgv_Einkauftabelle.TabIndex = 0;
            this.dgv_Einkauftabelle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Einkauftabelle_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PiD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Anzahl";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gesamtkosten";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MiD";
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_DateTime);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Produkte);
            this.panel1.Controls.Add(this.btn_Einkaufstabelle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 647);
            this.panel1.TabIndex = 2;
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(3, 594);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(76, 23);
            this.lbl_DateTime.TabIndex = 6;
            this.lbl_DateTime.Text = "label22";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(279, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 504);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funktion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_Produkte
            // 
            this.dgv_Produkte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produkte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiD,
            this.Bezeichnung,
            this.Preis,
            this.Column5,
            this.Kategorie});
            this.dgv_Produkte.Location = new System.Drawing.Point(13, 56);
            this.dgv_Produkte.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Produkte.Name = "dgv_Produkte";
            this.dgv_Produkte.ReadOnly = true;
            this.dgv_Produkte.RowHeadersWidth = 62;
            this.dgv_Produkte.RowTemplate.Height = 28;
            this.dgv_Produkte.Size = new System.Drawing.Size(563, 483);
            this.dgv_Produkte.TabIndex = 3;
            this.dgv_Produkte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Produkte_CellClick);
            // 
            // PiD
            // 
            this.PiD.HeaderText = "PiD";
            this.PiD.MinimumWidth = 8;
            this.PiD.Name = "PiD";
            this.PiD.ReadOnly = true;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.HeaderText = "Name";
            this.Bezeichnung.MinimumWidth = 8;
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.ReadOnly = true;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.MinimumWidth = 8;
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Anzahl";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Kategorie
            // 
            this.Kategorie.HeaderText = "Kategorie";
            this.Kategorie.MinimumWidth = 8;
            this.Kategorie.Name = "Kategorie";
            this.Kategorie.ReadOnly = true;
            // 
            // panel_Produkte
            // 
            this.panel_Produkte.BackColor = System.Drawing.Color.Linen;
            this.panel_Produkte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Produkte.Controls.Add(this.panel_NeueProdukte);
            this.panel_Produkte.Controls.Add(this.btn_NeueProdukte);
            this.panel_Produkte.Controls.Add(this.panel_Produkte_Kaufen);
            this.panel_Produkte.Controls.Add(this.btn_Produkte_kaufen);
            this.panel_Produkte.Controls.Add(this.label1);
            this.panel_Produkte.Controls.Add(this.dgv_Produkte);
            this.panel_Produkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Produkte.Location = new System.Drawing.Point(0, 0);
            this.panel_Produkte.Name = "panel_Produkte";
            this.panel_Produkte.Size = new System.Drawing.Size(1037, 643);
            this.panel_Produkte.TabIndex = 4;
            // 
            // panel_NeueProdukte
            // 
            this.panel_NeueProdukte.BackColor = System.Drawing.Color.White;
            this.panel_NeueProdukte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_NeueProdukte.Controls.Add(this.lbl_NeueProdukte_Gesamtkosten);
            this.panel_NeueProdukte.Controls.Add(this.btn_Hinzufügen);
            this.panel_NeueProdukte.Controls.Add(this.nup_NeueProdukte_Anzahl);
            this.panel_NeueProdukte.Controls.Add(this.label15);
            this.panel_NeueProdukte.Controls.Add(this.label16);
            this.panel_NeueProdukte.Controls.Add(this.label17);
            this.panel_NeueProdukte.Controls.Add(this.label18);
            this.panel_NeueProdukte.Controls.Add(this.label19);
            this.panel_NeueProdukte.Controls.Add(this.txt_NeueProdukte_Name);
            this.panel_NeueProdukte.Controls.Add(this.txt_NeueProdukte_Preis);
            this.panel_NeueProdukte.Controls.Add(this.txt_NeueProdukte_Kategorie);
            this.panel_NeueProdukte.Location = new System.Drawing.Point(610, 155);
            this.panel_NeueProdukte.Name = "panel_NeueProdukte";
            this.panel_NeueProdukte.Size = new System.Drawing.Size(641, 460);
            this.panel_NeueProdukte.TabIndex = 20;
            this.panel_NeueProdukte.Visible = false;
            // 
            // lbl_NeueProdukte_Gesamtkosten
            // 
            this.lbl_NeueProdukte_Gesamtkosten.AutoSize = true;
            this.lbl_NeueProdukte_Gesamtkosten.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NeueProdukte_Gesamtkosten.Location = new System.Drawing.Point(20, 252);
            this.lbl_NeueProdukte_Gesamtkosten.Name = "lbl_NeueProdukte_Gesamtkosten";
            this.lbl_NeueProdukte_Gesamtkosten.Size = new System.Drawing.Size(153, 23);
            this.lbl_NeueProdukte_Gesamtkosten.TabIndex = 16;
            this.lbl_NeueProdukte_Gesamtkosten.Text = "Gesamtkosten : ";
            // 
            // nup_NeueProdukte_Anzahl
            // 
            this.nup_NeueProdukte_Anzahl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_NeueProdukte_Anzahl.Location = new System.Drawing.Point(119, 153);
            this.nup_NeueProdukte_Anzahl.Name = "nup_NeueProdukte_Anzahl";
            this.nup_NeueProdukte_Anzahl.Size = new System.Drawing.Size(183, 27);
            this.nup_NeueProdukte_Anzahl.TabIndex = 15;
            this.nup_NeueProdukte_Anzahl.ValueChanged += new System.EventHandler(this.nup_NeueProdukte_Anzahl_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 30);
            this.label15.TabIndex = 12;
            this.label15.Text = "Neue Produkte";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 23);
            this.label16.TabIndex = 14;
            this.label16.Text = "Preis";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 23);
            this.label17.TabIndex = 13;
            this.label17.Text = "Anzahl";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 23);
            this.label18.TabIndex = 12;
            this.label18.Text = "Kategorie";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(20, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 23);
            this.label19.TabIndex = 11;
            this.label19.Text = "Name";
            // 
            // txt_NeueProdukte_Name
            // 
            this.txt_NeueProdukte_Name.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NeueProdukte_Name.Location = new System.Drawing.Point(119, 67);
            this.txt_NeueProdukte_Name.Name = "txt_NeueProdukte_Name";
            this.txt_NeueProdukte_Name.Size = new System.Drawing.Size(183, 27);
            this.txt_NeueProdukte_Name.TabIndex = 7;
            // 
            // txt_NeueProdukte_Preis
            // 
            this.txt_NeueProdukte_Preis.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NeueProdukte_Preis.Location = new System.Drawing.Point(119, 110);
            this.txt_NeueProdukte_Preis.Name = "txt_NeueProdukte_Preis";
            this.txt_NeueProdukte_Preis.Size = new System.Drawing.Size(183, 27);
            this.txt_NeueProdukte_Preis.TabIndex = 10;
            this.txt_NeueProdukte_Preis.TextChanged += new System.EventHandler(this.txt_NeueProdukte_Preis_TextChanged);
            // 
            // txt_NeueProdukte_Kategorie
            // 
            this.txt_NeueProdukte_Kategorie.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NeueProdukte_Kategorie.Location = new System.Drawing.Point(119, 195);
            this.txt_NeueProdukte_Kategorie.Name = "txt_NeueProdukte_Kategorie";
            this.txt_NeueProdukte_Kategorie.Size = new System.Drawing.Size(183, 27);
            this.txt_NeueProdukte_Kategorie.TabIndex = 8;
            // 
            // panel_Produkte_Kaufen
            // 
            this.panel_Produkte_Kaufen.BackColor = System.Drawing.Color.White;
            this.panel_Produkte_Kaufen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Produkte_Kaufen.Controls.Add(this.lbl_Gesamtkosten);
            this.panel_Produkte_Kaufen.Controls.Add(this.label9);
            this.panel_Produkte_Kaufen.Controls.Add(this.txt_PiD);
            this.panel_Produkte_Kaufen.Controls.Add(this.btn_Einkaufen);
            this.panel_Produkte_Kaufen.Controls.Add(this.label8);
            this.panel_Produkte_Kaufen.Controls.Add(this.numeric_Anzahl);
            this.panel_Produkte_Kaufen.Controls.Add(this.label7);
            this.panel_Produkte_Kaufen.Controls.Add(this.label6);
            this.panel_Produkte_Kaufen.Controls.Add(this.label5);
            this.panel_Produkte_Kaufen.Controls.Add(this.label4);
            this.panel_Produkte_Kaufen.Controls.Add(this.label3);
            this.panel_Produkte_Kaufen.Controls.Add(this.txt_name);
            this.panel_Produkte_Kaufen.Controls.Add(this.txt_Preis);
            this.panel_Produkte_Kaufen.Controls.Add(this.txt_Kategorie);
            this.panel_Produkte_Kaufen.Controls.Add(this.txt_Anzahl);
            this.panel_Produkte_Kaufen.Location = new System.Drawing.Point(610, 165);
            this.panel_Produkte_Kaufen.Name = "panel_Produkte_Kaufen";
            this.panel_Produkte_Kaufen.Size = new System.Drawing.Size(641, 460);
            this.panel_Produkte_Kaufen.TabIndex = 11;
            this.panel_Produkte_Kaufen.Visible = false;
            // 
            // lbl_Gesamtkosten
            // 
            this.lbl_Gesamtkosten.AutoSize = true;
            this.lbl_Gesamtkosten.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gesamtkosten.Location = new System.Drawing.Point(329, 56);
            this.lbl_Gesamtkosten.Name = "lbl_Gesamtkosten";
            this.lbl_Gesamtkosten.Size = new System.Drawing.Size(171, 25);
            this.lbl_Gesamtkosten.TabIndex = 19;
            this.lbl_Gesamtkosten.Text = "Gesamtkosten : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "PiD";
            // 
            // txt_PiD
            // 
            this.txt_PiD.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PiD.Location = new System.Drawing.Point(117, 58);
            this.txt_PiD.Name = "txt_PiD";
            this.txt_PiD.ReadOnly = true;
            this.txt_PiD.Size = new System.Drawing.Size(183, 27);
            this.txt_PiD.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Anzahl erhöhen";
            // 
            // numeric_Anzahl
            // 
            this.numeric_Anzahl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_Anzahl.Location = new System.Drawing.Point(180, 303);
            this.numeric_Anzahl.Name = "numeric_Anzahl";
            this.numeric_Anzahl.Size = new System.Drawing.Size(120, 27);
            this.numeric_Anzahl.TabIndex = 15;
            this.numeric_Anzahl.ValueChanged += new System.EventHandler(this.numeric_Anzahl_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Produkte kaufen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anzahl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(117, 105);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(183, 27);
            this.txt_name.TabIndex = 7;
            // 
            // txt_Preis
            // 
            this.txt_Preis.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Preis.Location = new System.Drawing.Point(117, 148);
            this.txt_Preis.Name = "txt_Preis";
            this.txt_Preis.ReadOnly = true;
            this.txt_Preis.Size = new System.Drawing.Size(183, 27);
            this.txt_Preis.TabIndex = 10;
            // 
            // txt_Kategorie
            // 
            this.txt_Kategorie.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Kategorie.Location = new System.Drawing.Point(117, 233);
            this.txt_Kategorie.Name = "txt_Kategorie";
            this.txt_Kategorie.ReadOnly = true;
            this.txt_Kategorie.Size = new System.Drawing.Size(183, 27);
            this.txt_Kategorie.TabIndex = 8;
            // 
            // txt_Anzahl
            // 
            this.txt_Anzahl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Anzahl.Location = new System.Drawing.Point(117, 190);
            this.txt_Anzahl.Name = "txt_Anzahl";
            this.txt_Anzahl.ReadOnly = true;
            this.txt_Anzahl.Size = new System.Drawing.Size(183, 27);
            this.txt_Anzahl.TabIndex = 9;
            this.txt_Anzahl.TextChanged += new System.EventHandler(this.txt_Anzahl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produkte";
            // 
            // panel_Einkauf
            // 
            this.panel_Einkauf.BackColor = System.Drawing.Color.Linen;
            this.panel_Einkauf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Einkauf.Controls.Add(this.panel_Produkte);
            this.panel_Einkauf.Controls.Add(this.btn_Verwaltung);
            this.panel_Einkauf.Controls.Add(this.dgv_Einkauftabelle);
            this.panel_Einkauf.Controls.Add(this.label10);
            this.panel_Einkauf.Controls.Add(this.panel_Einkauf_Verwaltung);
            this.panel_Einkauf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Einkauf.Location = new System.Drawing.Point(273, 0);
            this.panel_Einkauf.Name = "panel_Einkauf";
            this.panel_Einkauf.Size = new System.Drawing.Size(1041, 647);
            this.panel_Einkauf.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 6;
            this.label10.Text = "Einkauf";
            // 
            // panel_Einkauf_Verwaltung
            // 
            this.panel_Einkauf_Verwaltung.BackColor = System.Drawing.Color.White;
            this.panel_Einkauf_Verwaltung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Einkauf_Verwaltung.Controls.Add(this.label21);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.label20);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.label14);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.label13);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.txt_Einkauf_Verwaltung_MiD);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.txt_Verwaltung_Einkauf_Gesamtkosten);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.txt_Einkauf_Verwaltung_Anzahl);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.txt_Einkauf_Verwaltung_PiD);
            this.panel_Einkauf_Verwaltung.Controls.Add(this.label12);
            this.panel_Einkauf_Verwaltung.Location = new System.Drawing.Point(227, 342);
            this.panel_Einkauf_Verwaltung.Name = "panel_Einkauf_Verwaltung";
            this.panel_Einkauf_Verwaltung.Size = new System.Drawing.Size(566, 247);
            this.panel_Einkauf_Verwaltung.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(28, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 23);
            this.label21.TabIndex = 15;
            this.label21.Text = "MiD";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(28, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 23);
            this.label20.TabIndex = 14;
            this.label20.Text = "Gesamtkosten";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "Anzahl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "PiD";
            // 
            // txt_Einkauf_Verwaltung_MiD
            // 
            this.txt_Einkauf_Verwaltung_MiD.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Einkauf_Verwaltung_MiD.Location = new System.Drawing.Point(173, 172);
            this.txt_Einkauf_Verwaltung_MiD.Name = "txt_Einkauf_Verwaltung_MiD";
            this.txt_Einkauf_Verwaltung_MiD.ReadOnly = true;
            this.txt_Einkauf_Verwaltung_MiD.Size = new System.Drawing.Size(161, 27);
            this.txt_Einkauf_Verwaltung_MiD.TabIndex = 11;
            // 
            // txt_Verwaltung_Einkauf_Gesamtkosten
            // 
            this.txt_Verwaltung_Einkauf_Gesamtkosten.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Verwaltung_Einkauf_Gesamtkosten.Location = new System.Drawing.Point(173, 130);
            this.txt_Verwaltung_Einkauf_Gesamtkosten.Name = "txt_Verwaltung_Einkauf_Gesamtkosten";
            this.txt_Verwaltung_Einkauf_Gesamtkosten.ReadOnly = true;
            this.txt_Verwaltung_Einkauf_Gesamtkosten.Size = new System.Drawing.Size(161, 27);
            this.txt_Verwaltung_Einkauf_Gesamtkosten.TabIndex = 10;
            // 
            // txt_Einkauf_Verwaltung_Anzahl
            // 
            this.txt_Einkauf_Verwaltung_Anzahl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Einkauf_Verwaltung_Anzahl.Location = new System.Drawing.Point(173, 95);
            this.txt_Einkauf_Verwaltung_Anzahl.Name = "txt_Einkauf_Verwaltung_Anzahl";
            this.txt_Einkauf_Verwaltung_Anzahl.ReadOnly = true;
            this.txt_Einkauf_Verwaltung_Anzahl.Size = new System.Drawing.Size(161, 27);
            this.txt_Einkauf_Verwaltung_Anzahl.TabIndex = 9;
            // 
            // txt_Einkauf_Verwaltung_PiD
            // 
            this.txt_Einkauf_Verwaltung_PiD.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Einkauf_Verwaltung_PiD.Location = new System.Drawing.Point(173, 60);
            this.txt_Einkauf_Verwaltung_PiD.Name = "txt_Einkauf_Verwaltung_PiD";
            this.txt_Einkauf_Verwaltung_PiD.ReadOnly = true;
            this.txt_Einkauf_Verwaltung_PiD.Size = new System.Drawing.Size(161, 27);
            this.txt_Einkauf_Verwaltung_PiD.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(146, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 30);
            this.label12.TabIndex = 7;
            this.label12.Text = "Einzelne Daten einsehen";
            // 
            // Uhrzeit
            // 
            this.Uhrzeit.Interval = 1000;
            this.Uhrzeit.Tick += new System.EventHandler(this.Uhrzeit_Tick);
            // 
            // btn_Hinzufügen
            // 
            this.btn_Hinzufügen.BackColor = System.Drawing.Color.Linen;
            this.btn_Hinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hinzufügen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hinzufügen.ForeColor = System.Drawing.Color.Black;
            this.btn_Hinzufügen.Image = global::Instant_Gaming.Properties.Resources.Hinzufügen;
            this.btn_Hinzufügen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hinzufügen.Location = new System.Drawing.Point(25, 369);
            this.btn_Hinzufügen.Name = "btn_Hinzufügen";
            this.btn_Hinzufügen.Size = new System.Drawing.Size(182, 62);
            this.btn_Hinzufügen.TabIndex = 12;
            this.btn_Hinzufügen.Text = "Hinzufügen";
            this.btn_Hinzufügen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Hinzufügen.UseVisualStyleBackColor = false;
            this.btn_Hinzufügen.Click += new System.EventHandler(this.btn_Hinzufügen_Click);
            // 
            // btn_NeueProdukte
            // 
            this.btn_NeueProdukte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_NeueProdukte.FlatAppearance.BorderSize = 0;
            this.btn_NeueProdukte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NeueProdukte.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NeueProdukte.ForeColor = System.Drawing.Color.Black;
            this.btn_NeueProdukte.Image = global::Instant_Gaming.Properties.Resources.Neue_Produkte;
            this.btn_NeueProdukte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NeueProdukte.Location = new System.Drawing.Point(808, 56);
            this.btn_NeueProdukte.Name = "btn_NeueProdukte";
            this.btn_NeueProdukte.Size = new System.Drawing.Size(151, 62);
            this.btn_NeueProdukte.TabIndex = 12;
            this.btn_NeueProdukte.Text = "Neue Produkte";
            this.btn_NeueProdukte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NeueProdukte.UseVisualStyleBackColor = false;
            this.btn_NeueProdukte.Click += new System.EventHandler(this.btn_NeueProdukte_Click);
            // 
            // btn_Einkaufen
            // 
            this.btn_Einkaufen.BackColor = System.Drawing.Color.Linen;
            this.btn_Einkaufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Einkaufen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Einkaufen.ForeColor = System.Drawing.Color.Black;
            this.btn_Einkaufen.Image = global::Instant_Gaming.Properties.Resources.Einkaufen;
            this.btn_Einkaufen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Einkaufen.Location = new System.Drawing.Point(25, 369);
            this.btn_Einkaufen.Name = "btn_Einkaufen";
            this.btn_Einkaufen.Size = new System.Drawing.Size(163, 62);
            this.btn_Einkaufen.TabIndex = 12;
            this.btn_Einkaufen.Text = "Einkaufen";
            this.btn_Einkaufen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Einkaufen.UseVisualStyleBackColor = false;
            this.btn_Einkaufen.Click += new System.EventHandler(this.btn_Einkaufen_Click);
            // 
            // btn_Produkte_kaufen
            // 
            this.btn_Produkte_kaufen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Produkte_kaufen.FlatAppearance.BorderSize = 0;
            this.btn_Produkte_kaufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produkte_kaufen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produkte_kaufen.ForeColor = System.Drawing.Color.Black;
            this.btn_Produkte_kaufen.Image = global::Instant_Gaming.Properties.Resources.produkte_kaufen;
            this.btn_Produkte_kaufen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Produkte_kaufen.Location = new System.Drawing.Point(610, 56);
            this.btn_Produkte_kaufen.Name = "btn_Produkte_kaufen";
            this.btn_Produkte_kaufen.Size = new System.Drawing.Size(151, 62);
            this.btn_Produkte_kaufen.TabIndex = 6;
            this.btn_Produkte_kaufen.Text = "Produkte kaufen";
            this.btn_Produkte_kaufen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Produkte_kaufen.UseVisualStyleBackColor = false;
            this.btn_Produkte_kaufen.Click += new System.EventHandler(this.btn_Produkte_kaufen_Click);
            // 
            // btn_Verwaltung
            // 
            this.btn_Verwaltung.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Verwaltung.FlatAppearance.BorderSize = 0;
            this.btn_Verwaltung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verwaltung.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verwaltung.Image = global::Instant_Gaming.Properties.Resources.Verwalten;
            this.btn_Verwaltung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Verwaltung.Location = new System.Drawing.Point(26, 342);
            this.btn_Verwaltung.Name = "btn_Verwaltung";
            this.btn_Verwaltung.Size = new System.Drawing.Size(161, 49);
            this.btn_Verwaltung.TabIndex = 7;
            this.btn_Verwaltung.Text = "Verwalten";
            this.btn_Verwaltung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Verwaltung.UseVisualStyleBackColor = false;
            this.btn_Verwaltung.Click += new System.EventHandler(this.btn_Verwaltung_Click);
            // 
            // btn_Produkte
            // 
            this.btn_Produkte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Produkte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produkte.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produkte.ForeColor = System.Drawing.Color.Black;
            this.btn_Produkte.Image = global::Instant_Gaming.Properties.Resources.Produkte;
            this.btn_Produkte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Produkte.Location = new System.Drawing.Point(41, 167);
            this.btn_Produkte.Name = "btn_Produkte";
            this.btn_Produkte.Size = new System.Drawing.Size(178, 54);
            this.btn_Produkte.TabIndex = 5;
            this.btn_Produkte.Text = "Produkte";
            this.btn_Produkte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Produkte.UseVisualStyleBackColor = false;
            this.btn_Produkte.Click += new System.EventHandler(this.btn_Produkte_Click);
            // 
            // btn_Einkaufstabelle
            // 
            this.btn_Einkaufstabelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Einkaufstabelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Einkaufstabelle.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Einkaufstabelle.ForeColor = System.Drawing.Color.Black;
            this.btn_Einkaufstabelle.Image = global::Instant_Gaming.Properties.Resources.Einkauf;
            this.btn_Einkaufstabelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Einkaufstabelle.Location = new System.Drawing.Point(41, 87);
            this.btn_Einkaufstabelle.Name = "btn_Einkaufstabelle";
            this.btn_Einkaufstabelle.Size = new System.Drawing.Size(178, 54);
            this.btn_Einkaufstabelle.TabIndex = 4;
            this.btn_Einkaufstabelle.Text = "Einkauf";
            this.btn_Einkaufstabelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Einkaufstabelle.UseVisualStyleBackColor = false;
            this.btn_Einkaufstabelle.Click += new System.EventHandler(this.btn_Einkaufstabelle_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(273, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1041, 555);
            this.label11.TabIndex = 6;
            this.label11.Text = "Instant Gaming Einkauf";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_InstantGaming
            // 
            this.pb_InstantGaming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_InstantGaming.Image = global::Instant_Gaming.Properties.Resources.unnamed;
            this.pb_InstantGaming.Location = new System.Drawing.Point(721, 144);
            this.pb_InstantGaming.Name = "pb_InstantGaming";
            this.pb_InstantGaming.Size = new System.Drawing.Size(132, 131);
            this.pb_InstantGaming.TabIndex = 7;
            this.pb_InstantGaming.TabStop = false;
            // 
            // Einkauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 647);
            this.Controls.Add(this.panel_Einkauf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pb_InstantGaming);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Einkauf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einkauf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Einkauftabelle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produkte)).EndInit();
            this.panel_Produkte.ResumeLayout(false);
            this.panel_Produkte.PerformLayout();
            this.panel_NeueProdukte.ResumeLayout(false);
            this.panel_NeueProdukte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_NeueProdukte_Anzahl)).EndInit();
            this.panel_Produkte_Kaufen.ResumeLayout(false);
            this.panel_Produkte_Kaufen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Anzahl)).EndInit();
            this.panel_Einkauf.ResumeLayout(false);
            this.panel_Einkauf.PerformLayout();
            this.panel_Einkauf_Verwaltung.ResumeLayout(false);
            this.panel_Einkauf_Verwaltung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_InstantGaming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Einkauftabelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Einkaufstabelle;
        private System.Windows.Forms.Button btn_Produkte;
        private System.Windows.Forms.DataGridView dgv_Produkte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Produkte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Produkte_Kaufen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Preis;
        private System.Windows.Forms.TextBox txt_Kategorie;
        private System.Windows.Forms.TextBox txt_Anzahl;
        private System.Windows.Forms.Button btn_Produkte_kaufen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numeric_Anzahl;
        private System.Windows.Forms.Button btn_Einkaufen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PiD;
        private System.Windows.Forms.Panel panel_Einkauf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Verwaltung;
        private System.Windows.Forms.Label lbl_Gesamtkosten;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorie;
        private System.Windows.Forms.Panel panel_NeueProdukte;
        private System.Windows.Forms.Button btn_Hinzufügen;
        private System.Windows.Forms.NumericUpDown nup_NeueProdukte_Anzahl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_NeueProdukte_Name;
        private System.Windows.Forms.TextBox txt_NeueProdukte_Preis;
        private System.Windows.Forms.TextBox txt_NeueProdukte_Kategorie;
        private System.Windows.Forms.Button btn_NeueProdukte;
        private System.Windows.Forms.Label lbl_NeueProdukte_Gesamtkosten;
        private System.Windows.Forms.Panel panel_Einkauf_Verwaltung;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Einkauf_Verwaltung_MiD;
        private System.Windows.Forms.TextBox txt_Verwaltung_Einkauf_Gesamtkosten;
        private System.Windows.Forms.TextBox txt_Einkauf_Verwaltung_Anzahl;
        private System.Windows.Forms.TextBox txt_Einkauf_Verwaltung_PiD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Timer Uhrzeit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pb_InstantGaming;
    }
}