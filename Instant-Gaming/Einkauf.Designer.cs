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
            this.dgv_Einkauftabelle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Produkte = new System.Windows.Forms.Button();
            this.btn_Einkaufstabelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Produkte = new System.Windows.Forms.DataGridView();
            this.PiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Produkte = new System.Windows.Forms.Panel();
            this.panel_Produkte_Kaufen = new System.Windows.Forms.Panel();
            this.btn_Einkaufen = new System.Windows.Forms.Button();
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
            this.btn_Produkte_kaufen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PiD = new System.Windows.Forms.TextBox();
            this.panel_Einkauf = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Einkauftabelle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produkte)).BeginInit();
            this.panel_Produkte.SuspendLayout();
            this.panel_Produkte_Kaufen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Anzahl)).BeginInit();
            this.panel_Einkauf.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Produkte);
            this.panel1.Controls.Add(this.btn_Einkaufstabelle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 621);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(279, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 504);
            this.panel2.TabIndex = 4;
            // 
            // btn_Produkte
            // 
            this.btn_Produkte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produkte.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produkte.ForeColor = System.Drawing.Color.White;
            this.btn_Produkte.Location = new System.Drawing.Point(58, 167);
            this.btn_Produkte.Name = "btn_Produkte";
            this.btn_Produkte.Size = new System.Drawing.Size(151, 62);
            this.btn_Produkte.TabIndex = 5;
            this.btn_Produkte.Text = "Produkte";
            this.btn_Produkte.UseVisualStyleBackColor = true;
            this.btn_Produkte.Click += new System.EventHandler(this.btn_Produkte_Click);
            // 
            // btn_Einkaufstabelle
            // 
            this.btn_Einkaufstabelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Einkaufstabelle.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Einkaufstabelle.ForeColor = System.Drawing.Color.White;
            this.btn_Einkaufstabelle.Location = new System.Drawing.Point(58, 67);
            this.btn_Einkaufstabelle.Name = "btn_Einkaufstabelle";
            this.btn_Einkaufstabelle.Size = new System.Drawing.Size(151, 62);
            this.btn_Einkaufstabelle.TabIndex = 4;
            this.btn_Einkaufstabelle.Text = "Einkauf";
            this.btn_Einkaufstabelle.UseVisualStyleBackColor = true;
            this.btn_Einkaufstabelle.Click += new System.EventHandler(this.btn_Einkaufstabelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funktion";
            // 
            // dgv_Produkte
            // 
            this.dgv_Produkte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produkte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiD,
            this.Bezeichnung,
            this.Preis,
            this.Anzahl,
            this.Kategorie});
            this.dgv_Produkte.Location = new System.Drawing.Point(13, 56);
            this.dgv_Produkte.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Produkte.Name = "dgv_Produkte";
            this.dgv_Produkte.ReadOnly = true;
            this.dgv_Produkte.RowHeadersWidth = 62;
            this.dgv_Produkte.RowTemplate.Height = 28;
            this.dgv_Produkte.Size = new System.Drawing.Size(577, 445);
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
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.MinimumWidth = 8;
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
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
            this.panel_Produkte.Controls.Add(this.panel_Produkte_Kaufen);
            this.panel_Produkte.Controls.Add(this.btn_Produkte_kaufen);
            this.panel_Produkte.Controls.Add(this.label1);
            this.panel_Produkte.Controls.Add(this.dgv_Produkte);
            this.panel_Produkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Produkte.Location = new System.Drawing.Point(0, 0);
            this.panel_Produkte.Name = "panel_Produkte";
            this.panel_Produkte.Size = new System.Drawing.Size(1006, 617);
            this.panel_Produkte.TabIndex = 4;
            // 
            // panel_Produkte_Kaufen
            // 
            this.panel_Produkte_Kaufen.BackColor = System.Drawing.Color.White;
            this.panel_Produkte_Kaufen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel_Produkte_Kaufen.Location = new System.Drawing.Point(610, 149);
            this.panel_Produkte_Kaufen.Name = "panel_Produkte_Kaufen";
            this.panel_Produkte_Kaufen.Size = new System.Drawing.Size(641, 460);
            this.panel_Produkte_Kaufen.TabIndex = 11;
            this.panel_Produkte_Kaufen.Visible = false;
            // 
            // btn_Einkaufen
            // 
            this.btn_Einkaufen.BackColor = System.Drawing.Color.Linen;
            this.btn_Einkaufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Einkaufen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Einkaufen.ForeColor = System.Drawing.Color.Black;
            this.btn_Einkaufen.Location = new System.Drawing.Point(25, 369);
            this.btn_Einkaufen.Name = "btn_Einkaufen";
            this.btn_Einkaufen.Size = new System.Drawing.Size(151, 62);
            this.btn_Einkaufen.TabIndex = 12;
            this.btn_Einkaufen.Text = "Einkaufen";
            this.btn_Einkaufen.UseVisualStyleBackColor = false;
            this.btn_Einkaufen.Click += new System.EventHandler(this.btn_Einkaufen_Click);
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
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 28);
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
            // btn_Produkte_kaufen
            // 
            this.btn_Produkte_kaufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produkte_kaufen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produkte_kaufen.ForeColor = System.Drawing.Color.Black;
            this.btn_Produkte_kaufen.Location = new System.Drawing.Point(610, 56);
            this.btn_Produkte_kaufen.Name = "btn_Produkte_kaufen";
            this.btn_Produkte_kaufen.Size = new System.Drawing.Size(151, 62);
            this.btn_Produkte_kaufen.TabIndex = 6;
            this.btn_Produkte_kaufen.Text = "Produkte kaufen";
            this.btn_Produkte_kaufen.UseVisualStyleBackColor = true;
            this.btn_Produkte_kaufen.Click += new System.EventHandler(this.btn_Produkte_kaufen_Click);
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
            // panel_Einkauf
            // 
            this.panel_Einkauf.BackColor = System.Drawing.Color.Linen;
            this.panel_Einkauf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Einkauf.Controls.Add(this.panel_Produkte);
            this.panel_Einkauf.Controls.Add(this.dgv_Einkauftabelle);
            this.panel_Einkauf.Controls.Add(this.label10);
            this.panel_Einkauf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Einkauf.Location = new System.Drawing.Point(273, 0);
            this.panel_Einkauf.Name = "panel_Einkauf";
            this.panel_Einkauf.Size = new System.Drawing.Size(1010, 621);
            this.panel_Einkauf.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 28);
            this.label10.TabIndex = 6;
            this.label10.Text = "Funktion";
            // 
            // Einkauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 621);
            this.Controls.Add(this.panel_Einkauf);
            this.Controls.Add(this.panel1);
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
            this.panel_Produkte_Kaufen.ResumeLayout(false);
            this.panel_Produkte_Kaufen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Anzahl)).EndInit();
            this.panel_Einkauf.ResumeLayout(false);
            this.panel_Einkauf.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorie;
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
    }
}