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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Verkauf = new System.Windows.Forms.DataGridView();
            this.PiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_funktion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verkauf)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_funktion
            // 
            this.pn_funktion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pn_funktion.Controls.Add(this.label1);
            this.pn_funktion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_funktion.Location = new System.Drawing.Point(0, 0);
            this.pn_funktion.Name = "pn_funktion";
            this.pn_funktion.Size = new System.Drawing.Size(410, 685);
            this.pn_funktion.TabIndex = 0;
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
            this.dgv_Verkauf.RowHeadersWidth = 62;
            this.dgv_Verkauf.RowTemplate.Height = 28;
            this.dgv_Verkauf.Size = new System.Drawing.Size(865, 685);
            this.dgv_Verkauf.TabIndex = 1;
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
            // Verkauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 685);
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
    }
}