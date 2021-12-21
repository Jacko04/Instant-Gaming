namespace Instant_Gaming
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
            this.panel_Anmelden = new System.Windows.Forms.Panel();
            this.btn_Passwort_zeigen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.lbl_Registrieren = new System.Windows.Forms.Label();
            this.btn_Bestätigen = new System.Windows.Forms.Button();
            this.p_anmeldenfarbe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Anmelden.SuspendLayout();
            this.p_anmeldenfarbe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Anmelden
            // 
            this.panel_Anmelden.BackColor = System.Drawing.Color.Linen;
            this.panel_Anmelden.Controls.Add(this.p_anmeldenfarbe);
            this.panel_Anmelden.Controls.Add(this.btn_Bestätigen);
            this.panel_Anmelden.Controls.Add(this.lbl_Registrieren);
            this.panel_Anmelden.Controls.Add(this.txt_Passwort);
            this.panel_Anmelden.Controls.Add(this.txt_ID);
            this.panel_Anmelden.Controls.Add(this.label3);
            this.panel_Anmelden.Controls.Add(this.label2);
            this.panel_Anmelden.Controls.Add(this.btn_Passwort_zeigen);
            this.panel_Anmelden.Location = new System.Drawing.Point(0, 0);
            this.panel_Anmelden.Name = "panel_Anmelden";
            this.panel_Anmelden.Size = new System.Drawing.Size(884, 461);
            this.panel_Anmelden.TabIndex = 9;
            // 
            // btn_Passwort_zeigen
            // 
            this.btn_Passwort_zeigen.Location = new System.Drawing.Point(579, 183);
            this.btn_Passwort_zeigen.Name = "btn_Passwort_zeigen";
            this.btn_Passwort_zeigen.Size = new System.Drawing.Size(37, 32);
            this.btn_Passwort_zeigen.TabIndex = 17;
            this.btn_Passwort_zeigen.Text = "btn_Passwort_zeigen";
            this.btn_Passwort_zeigen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passwort";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(464, 141);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 33);
            this.txt_ID.TabIndex = 5;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Passwort.Location = new System.Drawing.Point(464, 181);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(100, 33);
            this.txt_Passwort.TabIndex = 6;
            this.txt_Passwort.UseSystemPasswordChar = true;
            this.txt_Passwort.TextChanged += new System.EventHandler(this.txt_Passwort_TextChanged);
            // 
            // lbl_Registrieren
            // 
            this.lbl_Registrieren.AutoSize = true;
            this.lbl_Registrieren.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registrieren.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Registrieren.Location = new System.Drawing.Point(380, 315);
            this.lbl_Registrieren.Name = "lbl_Registrieren";
            this.lbl_Registrieren.Size = new System.Drawing.Size(110, 20);
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
            this.btn_Bestätigen.Location = new System.Drawing.Point(328, 245);
            this.btn_Bestätigen.Name = "btn_Bestätigen";
            this.btn_Bestätigen.Size = new System.Drawing.Size(235, 51);
            this.btn_Bestätigen.TabIndex = 8;
            this.btn_Bestätigen.Text = "Bestätigen";
            this.btn_Bestätigen.UseVisualStyleBackColor = false;
            this.btn_Bestätigen.Click += new System.EventHandler(this.btn_Bestätigen_Click);
            // 
            // p_anmeldenfarbe
            // 
            this.p_anmeldenfarbe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.p_anmeldenfarbe.Controls.Add(this.label1);
            this.p_anmeldenfarbe.Location = new System.Drawing.Point(0, 0);
            this.p_anmeldenfarbe.Margin = new System.Windows.Forms.Padding(2);
            this.p_anmeldenfarbe.Name = "p_anmeldenfarbe";
            this.p_anmeldenfarbe.Size = new System.Drawing.Size(884, 90);
            this.p_anmeldenfarbe.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmelden";
            // 
            // Anmelde_formular
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel_Anmelden);
            this.Name = "Anmelde_formular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelde Formular";
            this.panel_Anmelden.ResumeLayout(false);
            this.panel_Anmelden.PerformLayout();
            this.p_anmeldenfarbe.ResumeLayout(false);
            this.p_anmeldenfarbe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Anmelden;
        private System.Windows.Forms.Panel p_anmeldenfarbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bestätigen;
        private System.Windows.Forms.Label lbl_Registrieren;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Passwort_zeigen;
    }
}