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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.lbl_Registrieren = new System.Windows.Forms.Label();
            this.btn_Bestätigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmelden";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passwort";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ID.Location = new System.Drawing.Point(469, 131);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 5;
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Passwort.Location = new System.Drawing.Point(469, 171);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(100, 20);
            this.txt_Passwort.TabIndex = 6;
            // 
            // lbl_Registrieren
            // 
            this.lbl_Registrieren.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Registrieren.AutoSize = true;
            this.lbl_Registrieren.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registrieren.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Registrieren.Location = new System.Drawing.Point(405, 258);
            this.lbl_Registrieren.Name = "lbl_Registrieren";
            this.lbl_Registrieren.Size = new System.Drawing.Size(77, 15);
            this.lbl_Registrieren.TabIndex = 7;
            this.lbl_Registrieren.Text = "Registrierien ";
            this.lbl_Registrieren.Click += new System.EventHandler(this.lbl_Registrieren_Click);
            // 
            // btn_Bestätigen
            // 
            this.btn_Bestätigen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Bestätigen.FlatAppearance.BorderSize = 0;
            this.btn_Bestätigen.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bestätigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Bestätigen.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Bestätigen.Location = new System.Drawing.Point(334, 204);
            this.btn_Bestätigen.Name = "btn_Bestätigen";
            this.btn_Bestätigen.Size = new System.Drawing.Size(235, 51);
            this.btn_Bestätigen.TabIndex = 8;
            this.btn_Bestätigen.Text = "Bestätigen";
            this.btn_Bestätigen.UseVisualStyleBackColor = true;
            this.btn_Bestätigen.Click += new System.EventHandler(this.btn_Bestätigen_Click);
            // 
            // Anmelde_formular
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btn_Bestätigen);
            this.Controls.Add(this.lbl_Registrieren);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Anmelde_formular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelde Formular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.Label lbl_Registrieren;
        private System.Windows.Forms.Button btn_Bestätigen;
    }
}