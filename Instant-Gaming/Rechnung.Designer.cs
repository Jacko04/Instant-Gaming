namespace Instant_Gaming
{
    partial class Rechnung
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
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Uberschrift = new System.Windows.Forms.Label();
            this.dgv_Rechnungen = new System.Windows.Forms.DataGridView();
            this.btn_öffnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_vorschau = new System.Windows.Forms.PictureBox();
            this.riDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kostenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instant_Gaming_VerkaufDataSet1 = new Instant_Gaming.Instant_Gaming_VerkaufDataSet1();
            this.rechnungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rechnungTableAdapter1 = new Instant_Gaming.Instant_Gaming_VerkaufDataSet1TableAdapters.RechnungTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rechnungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vorschau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instant_Gaming_VerkaufDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechnungBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_back.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(23, 634);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 45);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_vorschau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_öffnen);
            this.panel1.Controls.Add(this.Uberschrift);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 691);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Rechnungen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(369, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 691);
            this.panel2.TabIndex = 2;
            // 
            // Uberschrift
            // 
            this.Uberschrift.AutoSize = true;
            this.Uberschrift.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uberschrift.Location = new System.Drawing.Point(35, 27);
            this.Uberschrift.Name = "Uberschrift";
            this.Uberschrift.Size = new System.Drawing.Size(300, 57);
            this.Uberschrift.TabIndex = 1;
            this.Uberschrift.Text = "Rechnungen";
            // 
            // dgv_Rechnungen
            // 
            this.dgv_Rechnungen.AutoGenerateColumns = false;
            this.dgv_Rechnungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rechnungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.riDDataGridViewTextBoxColumn,
            this.piDDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.kostenDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.keyDataGridViewTextBoxColumn});
            this.dgv_Rechnungen.DataSource = this.rechnungBindingSource1;
            this.dgv_Rechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Rechnungen.Location = new System.Drawing.Point(0, 0);
            this.dgv_Rechnungen.Name = "dgv_Rechnungen";
            this.dgv_Rechnungen.ReadOnly = true;
            this.dgv_Rechnungen.RowHeadersWidth = 62;
            this.dgv_Rechnungen.RowTemplate.Height = 28;
            this.dgv_Rechnungen.Size = new System.Drawing.Size(910, 691);
            this.dgv_Rechnungen.TabIndex = 0;
            // 
            // btn_öffnen
            // 
            this.btn_öffnen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_öffnen.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_öffnen.Location = new System.Drawing.Point(23, 553);
            this.btn_öffnen.Name = "btn_öffnen";
            this.btn_öffnen.Size = new System.Drawing.Size(312, 59);
            this.btn_öffnen.TabIndex = 2;
            this.btn_öffnen.Text = "Rechnung öffnen";
            this.btn_öffnen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vorschau:";
            // 
            // pb_vorschau
            // 
            this.pb_vorschau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_vorschau.Location = new System.Drawing.Point(45, 155);
            this.pb_vorschau.Name = "pb_vorschau";
            this.pb_vorschau.Size = new System.Drawing.Size(280, 392);
            this.pb_vorschau.TabIndex = 4;
            this.pb_vorschau.TabStop = false;
            // 
            // riDDataGridViewTextBoxColumn
            // 
            this.riDDataGridViewTextBoxColumn.DataPropertyName = "RiD";
            this.riDDataGridViewTextBoxColumn.HeaderText = "RiD";
            this.riDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.riDDataGridViewTextBoxColumn.Name = "riDDataGridViewTextBoxColumn";
            this.riDDataGridViewTextBoxColumn.Width = 150;
            // 
            // piDDataGridViewTextBoxColumn
            // 
            this.piDDataGridViewTextBoxColumn.DataPropertyName = "PiD";
            this.piDDataGridViewTextBoxColumn.HeaderText = "PiD";
            this.piDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.piDDataGridViewTextBoxColumn.Name = "piDDataGridViewTextBoxColumn";
            this.piDDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // kostenDataGridViewTextBoxColumn
            // 
            this.kostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten";
            this.kostenDataGridViewTextBoxColumn.HeaderText = "Kosten";
            this.kostenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kostenDataGridViewTextBoxColumn.Name = "kostenDataGridViewTextBoxColumn";
            this.kostenDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 150;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.Width = 150;
            // 
            // instant_Gaming_VerkaufDataSet1
            // 
            this.instant_Gaming_VerkaufDataSet1.DataSetName = "Instant_Gaming_VerkaufDataSet1";
            this.instant_Gaming_VerkaufDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rechnungBindingSource1
            // 
            this.rechnungBindingSource1.DataMember = "Rechnung";
            this.rechnungBindingSource1.DataSource = this.instant_Gaming_VerkaufDataSet1;
            // 
            // rechnungTableAdapter1
            // 
            this.rechnungTableAdapter1.ClearBeforeFill = true;
            // 
            // Rechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Rechnung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rechnung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rechnungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vorschau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instant_Gaming_VerkaufDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechnungBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Uberschrift;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Rechnungen;
        private System.Windows.Forms.PictureBox pb_vorschau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_öffnen;
        private System.Windows.Forms.DataGridViewTextBoxColumn riDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kostenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private Instant_Gaming_VerkaufDataSet1 instant_Gaming_VerkaufDataSet1;
        private System.Windows.Forms.BindingSource rechnungBindingSource1;
        private Instant_Gaming_VerkaufDataSet1TableAdapters.RechnungTableAdapter rechnungTableAdapter1;
    }
}