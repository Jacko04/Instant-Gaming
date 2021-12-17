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
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_öffnen = new System.Windows.Forms.Button();
            this.Uberschrift = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Rechnungen = new System.Windows.Forms.DataGridView();
            this.RiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rechnungen)).BeginInit();
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
            this.panel1.Controls.Add(this.btn_öffnen);
            this.panel1.Controls.Add(this.Uberschrift);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 691);
            this.panel1.TabIndex = 1;
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
            this.btn_öffnen.Click += new System.EventHandler(this.btn_öffnen_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Rechnungen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(369, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 691);
            this.panel2.TabIndex = 2;
            // 
            // dgv_Rechnungen
            // 
            this.dgv_Rechnungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Rechnungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rechnungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RiD});
            this.dgv_Rechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Rechnungen.Location = new System.Drawing.Point(0, 0);
            this.dgv_Rechnungen.Name = "dgv_Rechnungen";
            this.dgv_Rechnungen.ReadOnly = true;
            this.dgv_Rechnungen.RowHeadersWidth = 62;
            this.dgv_Rechnungen.RowTemplate.Height = 28;
            this.dgv_Rechnungen.Size = new System.Drawing.Size(910, 691);
            this.dgv_Rechnungen.TabIndex = 0;
            // 
            // RiD
            // 
            this.RiD.HeaderText = "Rechnung";
            this.RiD.MinimumWidth = 8;
            this.RiD.Name = "RiD";
            this.RiD.ReadOnly = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Uberschrift;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Rechnungen;
        private System.Windows.Forms.Button btn_öffnen;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiD;
    }
}