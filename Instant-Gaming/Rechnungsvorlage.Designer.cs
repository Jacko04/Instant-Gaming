namespace Instant_Gaming
{
    partial class Rechnungsvorlage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnungsvorlage));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kosten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_KiD = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.Produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_rechnungsnr = new System.Windows.Forms.Label();
            this.dgv_Produkte = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl_uberschrift = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_pdf = new System.Windows.Forms.Panel();
            this.pic_drucken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produkte)).BeginInit();
            this.p_pdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drucken)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.MinimumWidth = 8;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            // 
            // Kosten
            // 
            this.Kosten.HeaderText = "Kosten";
            this.Kosten.MinimumWidth = 8;
            this.Kosten.Name = "Kosten";
            this.Kosten.ReadOnly = true;
            // 
            // lbl_tel
            // 
            this.lbl_tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(230, 308);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(72, 33);
            this.lbl_tel.TabIndex = 16;
            this.lbl_tel.Text = "Test";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 33);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telefon:";
            // 
            // lbl_KiD
            // 
            this.lbl_KiD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_KiD.AutoSize = true;
            this.lbl_KiD.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KiD.Location = new System.Drawing.Point(230, 178);
            this.lbl_KiD.Name = "lbl_KiD";
            this.lbl_KiD.Size = new System.Drawing.Size(72, 33);
            this.lbl_KiD.TabIndex = 14;
            this.lbl_KiD.Text = "Test";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 33);
            this.label11.TabIndex = 13;
            this.label11.Text = "ID:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(230, 275);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(72, 33);
            this.lbl_mail.TabIndex = 12;
            this.lbl_mail.Text = "Test";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "E-mail:";
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adresse.Location = new System.Drawing.Point(230, 242);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(72, 33);
            this.lbl_Adresse.TabIndex = 10;
            this.lbl_Adresse.Text = "Test";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Adresse:";
            // 
            // lbl_datum
            // 
            this.lbl_datum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.Location = new System.Drawing.Point(919, 178);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(72, 33);
            this.lbl_datum.TabIndex = 8;
            this.lbl_datum.Text = "Test";
            // 
            // Produkt
            // 
            this.Produkt.HeaderText = "Produkt";
            this.Produkt.MinimumWidth = 8;
            this.Produkt.Name = "Produkt";
            this.Produkt.ReadOnly = true;
            // 
            // PiD
            // 
            this.PiD.HeaderText = "Produkt Nr.";
            this.PiD.MinimumWidth = 8;
            this.PiD.Name = "PiD";
            this.PiD.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(790, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datum:";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(230, 209);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(72, 33);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Test";
            // 
            // lbl_rechnungsnr
            // 
            this.lbl_rechnungsnr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_rechnungsnr.AutoSize = true;
            this.lbl_rechnungsnr.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rechnungsnr.Location = new System.Drawing.Point(330, 402);
            this.lbl_rechnungsnr.Name = "lbl_rechnungsnr";
            this.lbl_rechnungsnr.Size = new System.Drawing.Size(72, 33);
            this.lbl_rechnungsnr.TabIndex = 4;
            this.lbl_rechnungsnr.Text = "Test";
            // 
            // dgv_Produkte
            // 
            this.dgv_Produkte.AllowUserToAddRows = false;
            this.dgv_Produkte.AllowUserToDeleteRows = false;
            this.dgv_Produkte.AllowUserToResizeColumns = false;
            this.dgv_Produkte.AllowUserToResizeRows = false;
            this.dgv_Produkte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Produkte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produkte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiD,
            this.Produkt,
            this.Kosten,
            this.Key});
            this.dgv_Produkte.EnableHeadersVisualStyles = false;
            this.dgv_Produkte.Location = new System.Drawing.Point(336, 470);
            this.dgv_Produkte.MultiSelect = false;
            this.dgv_Produkte.Name = "dgv_Produkte";
            this.dgv_Produkte.ReadOnly = true;
            this.dgv_Produkte.RowHeadersVisible = false;
            this.dgv_Produkte.RowHeadersWidth = 62;
            this.dgv_Produkte.RowTemplate.Height = 28;
            this.dgv_Produkte.Size = new System.Drawing.Size(645, 288);
            this.dgv_Produkte.TabIndex = 3;
            // 
            // lbl_uberschrift
            // 
            this.lbl_uberschrift.AutoSize = true;
            this.lbl_uberschrift.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uberschrift.Location = new System.Drawing.Point(524, 137);
            this.lbl_uberschrift.Name = "lbl_uberschrift";
            this.lbl_uberschrift.Size = new System.Drawing.Size(233, 57);
            this.lbl_uberschrift.TabIndex = 4;
            this.lbl_uberschrift.Text = "Vorschau";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produkte:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechnungsnummer:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechnung";
            // 
            // p_pdf
            // 
            this.p_pdf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p_pdf.BackColor = System.Drawing.Color.White;
            this.p_pdf.Controls.Add(this.lbl_tel);
            this.p_pdf.Controls.Add(this.label13);
            this.p_pdf.Controls.Add(this.lbl_KiD);
            this.p_pdf.Controls.Add(this.label11);
            this.p_pdf.Controls.Add(this.lbl_mail);
            this.p_pdf.Controls.Add(this.label9);
            this.p_pdf.Controls.Add(this.lbl_Adresse);
            this.p_pdf.Controls.Add(this.label6);
            this.p_pdf.Controls.Add(this.lbl_datum);
            this.p_pdf.Controls.Add(this.label7);
            this.p_pdf.Controls.Add(this.lbl_name);
            this.p_pdf.Controls.Add(this.label4);
            this.p_pdf.Controls.Add(this.lbl_rechnungsnr);
            this.p_pdf.Controls.Add(this.dgv_Produkte);
            this.p_pdf.Controls.Add(this.label3);
            this.p_pdf.Controls.Add(this.label2);
            this.p_pdf.Controls.Add(this.label1);
            this.p_pdf.Location = new System.Drawing.Point(41, 244);
            this.p_pdf.Name = "p_pdf";
            this.p_pdf.Size = new System.Drawing.Size(1062, 878);
            this.p_pdf.TabIndex = 5;
            // 
            // pic_drucken
            // 
            this.pic_drucken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_drucken.Image = global::Instant_Gaming.Properties.Resources.PDF;
            this.pic_drucken.Location = new System.Drawing.Point(1038, 144);
            this.pic_drucken.Name = "pic_drucken";
            this.pic_drucken.Size = new System.Drawing.Size(65, 73);
            this.pic_drucken.TabIndex = 3;
            this.pic_drucken.TabStop = false;
            // 
            // Rechnungsvorlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1258, 775);
            this.Controls.Add(this.lbl_uberschrift);
            this.Controls.Add(this.pic_drucken);
            this.Controls.Add(this.p_pdf);
            this.Name = "Rechnungsvorlage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnungsvorlage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produkte)).EndInit();
            this.p_pdf.ResumeLayout(false);
            this.p_pdf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drucken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kosten;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_KiD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_rechnungsnr;
        private System.Windows.Forms.DataGridView dgv_Produkte;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbl_uberschrift;
        private System.Windows.Forms.PictureBox pic_drucken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_pdf;
    }
}