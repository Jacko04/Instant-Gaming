﻿namespace Instant_Gaming
{
    partial class Anmelde_formular
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.lbl_Registrieren = new System.Windows.Forms.Label();
            this.btn_Bestätigen = new System.Windows.Forms.Button();
            this.panel_Anmelden = new System.Windows.Forms.Panel();
            this.panel_Registrieren = new System.Windows.Forms.Panel();
            this.btn_Reg_Bestätigen = new System.Windows.Forms.Button();
            this.txt_Reg_Passwort = new System.Windows.Forms.TextBox();
            this.txt_TelNr = new System.Windows.Forms.TextBox();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Anmeldenoffnen = new System.Windows.Forms.Button();
            this.p_registrationsfarbe = new System.Windows.Forms.Panel();
            this.p_anmeldenfarbe = new System.Windows.Forms.Panel();
            this.panel_Anmelden.SuspendLayout();
            this.panel_Registrieren.SuspendLayout();
            this.p_registrationsfarbe.SuspendLayout();
            this.p_anmeldenfarbe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmelden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passwort";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(696, 217);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(148, 46);
            this.txt_ID.TabIndex = 5;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Passwort.Location = new System.Drawing.Point(696, 278);
            this.txt_Passwort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(148, 46);
            this.txt_Passwort.TabIndex = 6;
            this.txt_Passwort.TextChanged += new System.EventHandler(this.txt_Passwort_TextChanged);
            // 
            // lbl_Registrieren
            // 
            this.lbl_Registrieren.AutoSize = true;
            this.lbl_Registrieren.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registrieren.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Registrieren.Location = new System.Drawing.Point(570, 485);
            this.lbl_Registrieren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Registrieren.Name = "lbl_Registrieren";
            this.lbl_Registrieren.Size = new System.Drawing.Size(166, 28);
            this.lbl_Registrieren.TabIndex = 7;
            this.lbl_Registrieren.Text = "Registrierien ";
            this.lbl_Registrieren.Click += new System.EventHandler(this.lbl_Registrieren_Click);
            // 
            // btn_Bestätigen
            // 
            this.btn_Bestätigen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Bestätigen.FlatAppearance.BorderSize = 0;
            this.btn_Bestätigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bestätigen.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bestätigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Bestätigen.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Bestätigen.Location = new System.Drawing.Point(492, 377);
            this.btn_Bestätigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Bestätigen.Name = "btn_Bestätigen";
            this.btn_Bestätigen.Size = new System.Drawing.Size(352, 78);
            this.btn_Bestätigen.TabIndex = 8;
            this.btn_Bestätigen.Text = "Bestätigen";
            this.btn_Bestätigen.UseVisualStyleBackColor = false;
            this.btn_Bestätigen.Click += new System.EventHandler(this.btn_Bestätigen_Click);
            // 
            // panel_Anmelden
            // 
            this.panel_Anmelden.BackColor = System.Drawing.Color.Linen;
            this.panel_Anmelden.Controls.Add(this.panel_Registrieren);
            this.panel_Anmelden.Controls.Add(this.p_anmeldenfarbe);
            this.panel_Anmelden.Controls.Add(this.btn_Bestätigen);
            this.panel_Anmelden.Controls.Add(this.lbl_Registrieren);
            this.panel_Anmelden.Controls.Add(this.txt_Passwort);
            this.panel_Anmelden.Controls.Add(this.txt_ID);
            this.panel_Anmelden.Controls.Add(this.label3);
            this.panel_Anmelden.Controls.Add(this.label2);
            this.panel_Anmelden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Anmelden.Location = new System.Drawing.Point(0, 0);
            this.panel_Anmelden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Anmelden.Name = "panel_Anmelden";
            this.panel_Anmelden.Size = new System.Drawing.Size(1326, 709);
            this.panel_Anmelden.TabIndex = 9;
            // 
            // panel_Registrieren
            // 
            this.panel_Registrieren.BackColor = System.Drawing.Color.Linen;
            this.panel_Registrieren.Controls.Add(this.p_registrationsfarbe);
            this.panel_Registrieren.Controls.Add(this.btn_Anmeldenoffnen);
            this.panel_Registrieren.Controls.Add(this.btn_Reg_Bestätigen);
            this.panel_Registrieren.Controls.Add(this.txt_Reg_Passwort);
            this.panel_Registrieren.Controls.Add(this.txt_TelNr);
            this.panel_Registrieren.Controls.Add(this.txt_Adresse);
            this.panel_Registrieren.Controls.Add(this.txt_Email);
            this.panel_Registrieren.Controls.Add(this.txt_Nachname);
            this.panel_Registrieren.Controls.Add(this.txt_Vorname);
            this.panel_Registrieren.Controls.Add(this.label10);
            this.panel_Registrieren.Controls.Add(this.label9);
            this.panel_Registrieren.Controls.Add(this.label8);
            this.panel_Registrieren.Controls.Add(this.label7);
            this.panel_Registrieren.Controls.Add(this.label6);
            this.panel_Registrieren.Controls.Add(this.label5);
            this.panel_Registrieren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Registrieren.Location = new System.Drawing.Point(0, 0);
            this.panel_Registrieren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Registrieren.Name = "panel_Registrieren";
            this.panel_Registrieren.Size = new System.Drawing.Size(1326, 709);
            this.panel_Registrieren.TabIndex = 9;
            // 
            // btn_Reg_Bestätigen
            // 
            this.btn_Reg_Bestätigen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Reg_Bestätigen.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Bestätigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Bestätigen.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Bestätigen.ForeColor = System.Drawing.Color.Black;
            this.btn_Reg_Bestätigen.Location = new System.Drawing.Point(505, 460);
            this.btn_Reg_Bestätigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reg_Bestätigen.Name = "btn_Reg_Bestätigen";
            this.btn_Reg_Bestätigen.Size = new System.Drawing.Size(292, 92);
            this.btn_Reg_Bestätigen.TabIndex = 13;
            this.btn_Reg_Bestätigen.Text = "Bestätigen";
            this.btn_Reg_Bestätigen.UseVisualStyleBackColor = false;
            this.btn_Reg_Bestätigen.Click += new System.EventHandler(this.btn_Reg_Bestätigen_Click);
            // 
            // txt_Reg_Passwort
            // 
            this.txt_Reg_Passwort.Location = new System.Drawing.Point(648, 397);
            this.txt_Reg_Passwort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Reg_Passwort.Name = "txt_Reg_Passwort";
            this.txt_Reg_Passwort.Size = new System.Drawing.Size(148, 26);
            this.txt_Reg_Passwort.TabIndex = 12;
            // 
            // txt_TelNr
            // 
            this.txt_TelNr.Location = new System.Drawing.Point(648, 357);
            this.txt_TelNr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TelNr.Name = "txt_TelNr";
            this.txt_TelNr.Size = new System.Drawing.Size(148, 26);
            this.txt_TelNr.TabIndex = 11;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Location = new System.Drawing.Point(648, 317);
            this.txt_Adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(148, 26);
            this.txt_Adresse.TabIndex = 10;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(648, 277);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(148, 26);
            this.txt_Email.TabIndex = 9;
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(648, 230);
            this.txt_Nachname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(148, 26);
            this.txt_Nachname.TabIndex = 8;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(648, 187);
            this.txt_Vorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(148, 26);
            this.txt_Vorname.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(498, 397);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 6;
            this.label10.Text = "Passwort";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(498, 352);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tel-Nr";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nachname";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 87);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registration";
            // 
            // btn_Anmeldenoffnen
            // 
            this.btn_Anmeldenoffnen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Anmeldenoffnen.FlatAppearance.BorderSize = 0;
            this.btn_Anmeldenoffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anmeldenoffnen.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anmeldenoffnen.ForeColor = System.Drawing.Color.Black;
            this.btn_Anmeldenoffnen.Location = new System.Drawing.Point(13, 642);
            this.btn_Anmeldenoffnen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Anmeldenoffnen.Name = "btn_Anmeldenoffnen";
            this.btn_Anmeldenoffnen.Size = new System.Drawing.Size(159, 53);
            this.btn_Anmeldenoffnen.TabIndex = 14;
            this.btn_Anmeldenoffnen.Text = "Zurück";
            this.btn_Anmeldenoffnen.UseVisualStyleBackColor = false;
            this.btn_Anmeldenoffnen.Click += new System.EventHandler(this.btn_Anmeldenoffnen_Click);
            // 
            // p_registrationsfarbe
            // 
            this.p_registrationsfarbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_registrationsfarbe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.p_registrationsfarbe.Controls.Add(this.label4);
            this.p_registrationsfarbe.Location = new System.Drawing.Point(0, 0);
            this.p_registrationsfarbe.Name = "p_registrationsfarbe";
            this.p_registrationsfarbe.Size = new System.Drawing.Size(1326, 138);
            this.p_registrationsfarbe.TabIndex = 15;
            // 
            // p_anmeldenfarbe
            // 
            this.p_anmeldenfarbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_anmeldenfarbe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.p_anmeldenfarbe.Controls.Add(this.label1);
            this.p_anmeldenfarbe.Location = new System.Drawing.Point(0, 0);
            this.p_anmeldenfarbe.Name = "p_anmeldenfarbe";
            this.p_anmeldenfarbe.Size = new System.Drawing.Size(1326, 138);
            this.p_anmeldenfarbe.TabIndex = 16;
            // 
            // Anmelde_formular
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 709);
            this.Controls.Add(this.panel_Anmelden);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Anmelde_formular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelde Formular";
            this.panel_Anmelden.ResumeLayout(false);
            this.panel_Anmelden.PerformLayout();
            this.panel_Registrieren.ResumeLayout(false);
            this.panel_Registrieren.PerformLayout();
            this.p_registrationsfarbe.ResumeLayout(false);
            this.p_registrationsfarbe.PerformLayout();
            this.p_anmeldenfarbe.ResumeLayout(false);
            this.p_anmeldenfarbe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.Label lbl_Registrieren;
        private System.Windows.Forms.Button btn_Bestätigen;
        private System.Windows.Forms.Panel panel_Anmelden;
        private System.Windows.Forms.Panel panel_Registrieren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Reg_Passwort;
        private System.Windows.Forms.TextBox txt_TelNr;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Reg_Bestätigen;
        private System.Windows.Forms.Panel p_registrationsfarbe;
        private System.Windows.Forms.Button btn_Anmeldenoffnen;
        private System.Windows.Forms.Panel p_anmeldenfarbe;
    }
}