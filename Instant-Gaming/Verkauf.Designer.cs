namespace Instant_Gaming
{
    partial class Verkauf
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
            this.pn_funktion = new System.Windows.Forms.Panel();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.btn_entfernen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Gespreis = new System.Windows.Forms.Label();
            this.btn_kaufen = new System.Windows.Forms.Button();
            this.lst_Warenkorb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Verkauf = new System.Windows.Forms.DataGridView();
            this.PiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rechnungsform = new System.Windows.Forms.Button();
            this.pn_funktion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verkauf)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_funktion
            // 
            this.pn_funktion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pn_funktion.Controls.Add(this.btn_rechnungsform);
            this.pn_funktion.Controls.Add(this.lbl_euro);
            this.pn_funktion.Controls.Add(this.btn_entfernen);
            this.pn_funktion.Controls.Add(this.label2);
            this.pn_funktion.Controls.Add(this.lbl_Gespreis);
            this.pn_funktion.Controls.Add(this.btn_kaufen);
            this.pn_funktion.Controls.Add(this.lst_Warenkorb);
            this.pn_funktion.Controls.Add(this.label1);
            this.pn_funktion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_funktion.Location = new System.Drawing.Point(0, 0);
            this.pn_funktion.Name = "pn_funktion";
            this.pn_funktion.Size = new System.Drawing.Size(410, 802);
            this.pn_funktion.TabIndex = 0;
            // 
            // lbl_euro
            // 
            this.lbl_euro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_euro.Location = new System.Drawing.Point(358, 646);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(38, 42);
            this.lbl_euro.TabIndex = 6;
            this.lbl_euro.Text = "€";
            // 
            // btn_entfernen
            // 
            this.btn_entfernen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_entfernen.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entfernen.Location = new System.Drawing.Point(13, 579);
            this.btn_entfernen.Name = "btn_entfernen";
            this.btn_entfernen.Size = new System.Drawing.Size(107, 54);
            this.btn_entfernen.TabIndex = 5;
            this.btn_entfernen.Text = "Entfernen";
            this.btn_entfernen.UseVisualStyleBackColor = true;
            this.btn_entfernen.Click += new System.EventHandler(this.btn_entfernen_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gesamtpreis:";
            // 
            // lbl_Gespreis
            // 
            this.lbl_Gespreis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Gespreis.AutoSize = true;
            this.lbl_Gespreis.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gespreis.Location = new System.Drawing.Point(258, 646);
            this.lbl_Gespreis.Name = "lbl_Gespreis";
            this.lbl_Gespreis.Size = new System.Drawing.Size(38, 42);
            this.lbl_Gespreis.TabIndex = 3;
            this.lbl_Gespreis.Text = "0";
            // 
            // btn_kaufen
            // 
            this.btn_kaufen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kaufen.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaufen.Location = new System.Drawing.Point(13, 708);
            this.btn_kaufen.Name = "btn_kaufen";
            this.btn_kaufen.Size = new System.Drawing.Size(384, 57);
            this.btn_kaufen.TabIndex = 2;
            this.btn_kaufen.Text = "Kaufen";
            this.btn_kaufen.UseVisualStyleBackColor = true;
            this.btn_kaufen.Click += new System.EventHandler(this.btn_kaufen_Click);
            // 
            // lst_Warenkorb
            // 
            this.lst_Warenkorb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Warenkorb.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Warenkorb.FormattingEnabled = true;
            this.lst_Warenkorb.ItemHeight = 42;
            this.lst_Warenkorb.Location = new System.Drawing.Point(13, 107);
            this.lst_Warenkorb.Name = "lst_Warenkorb";
            this.lst_Warenkorb.Size = new System.Drawing.Size(383, 466);
            this.lst_Warenkorb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verkauf";
            // 
            // dgv_Verkauf
            // 
            this.dgv_Verkauf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Verkauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Verkauf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiD,
            this.Bezeichnung,
            this.Preis,
            this.Anzahl,
            this.Kategorie});
            this.dgv_Verkauf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Verkauf.Location = new System.Drawing.Point(410, 0);
            this.dgv_Verkauf.Name = "dgv_Verkauf";
            this.dgv_Verkauf.ReadOnly = true;
            this.dgv_Verkauf.RowHeadersVisible = false;
            this.dgv_Verkauf.RowHeadersWidth = 62;
            this.dgv_Verkauf.RowTemplate.Height = 28;
            this.dgv_Verkauf.Size = new System.Drawing.Size(865, 802);
            this.dgv_Verkauf.TabIndex = 1;
            this.dgv_Verkauf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Verkauf_CellContentClick);
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
            // btn_rechnungsform
            // 
            this.btn_rechnungsform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rechnungsform.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechnungsform.Location = new System.Drawing.Point(183, 579);
            this.btn_rechnungsform.Name = "btn_rechnungsform";
            this.btn_rechnungsform.Size = new System.Drawing.Size(213, 54);
            this.btn_rechnungsform.TabIndex = 7;
            this.btn_rechnungsform.Text = "Rechnungen anzeigen";
            this.btn_rechnungsform.UseVisualStyleBackColor = true;
            // 
            // Verkauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 802);
            this.Controls.Add(this.dgv_Verkauf);
            this.Controls.Add(this.pn_funktion);
            this.Name = "Verkauf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verkauf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pn_funktion.ResumeLayout(false);
            this.pn_funktion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verkauf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_funktion;
        private System.Windows.Forms.DataGridView dgv_Verkauf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorie;
        private System.Windows.Forms.Label lbl_Gespreis;
        private System.Windows.Forms.Button btn_kaufen;
        private System.Windows.Forms.ListBox lst_Warenkorb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_entfernen;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Button btn_rechnungsform;
    }
}