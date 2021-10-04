using AplikacijaESD.Klase;

namespace AplikacijaESD
{
    partial class Osoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osoba));
            this.lblPol = new System.Windows.Forms.Label();
            this.btnAzurirajOsobu = new System.Windows.Forms.Button();
            this.btnDodajOsobu = new System.Windows.Forms.Button();
            this.buttonOcistiOsobu = new System.Windows.Forms.Button();
            this.btnObrisiOsobu = new System.Windows.Forms.Button();
            this.dataGridViewOsoba = new System.Windows.Forms.DataGridView();
            this.lblPretragaOsobe = new System.Windows.Forms.Label();
            this.txtboxPretragaOsobe = new System.Windows.Forms.TextBox();
            this.lblOsoba = new System.Windows.Forms.Label();
            this.lblIPrezime = new System.Windows.Forms.Label();
            this.txtboxPrezime = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.txtboxIme = new System.Windows.Forms.TextBox();
            this.txtboxJMBG = new System.Windows.Forms.TextBox();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtboxAdresa = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtboxTelefon = new System.Windows.Forms.TextBox();
            this.lblPTT4 = new System.Windows.Forms.Label();
            this.txtboxPTT4 = new System.Windows.Forms.TextBox();
            this.cmbboxPol = new System.Windows.Forms.ComboBox();
            this.pictureBoxNazad6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIzlaz6 = new System.Windows.Forms.PictureBox();
            this.txtboxDatumRodjenja = new System.Windows.Forms.TextBox();
            this.lblPretragaPTTgrada = new System.Windows.Forms.Label();
            this.txtboxPretragaPTTgrada = new System.Windows.Forms.TextBox();
            this.dgvPretragaPTTgrada = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaPTTgrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(36, 190);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(22, 13);
            this.lblPol.TabIndex = 83;
            this.lblPol.Text = "Pol";
            // 
            // btnAzurirajOsobu
            // 
            this.btnAzurirajOsobu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAzurirajOsobu.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajOsobu.Location = new System.Drawing.Point(610, 86);
            this.btnAzurirajOsobu.Name = "btnAzurirajOsobu";
            this.btnAzurirajOsobu.Size = new System.Drawing.Size(108, 23);
            this.btnAzurirajOsobu.TabIndex = 81;
            this.btnAzurirajOsobu.Text = "AŽURIRAJTE";
            this.btnAzurirajOsobu.UseVisualStyleBackColor = false;
            this.btnAzurirajOsobu.Click += new System.EventHandler(this.btnAzurirajOsobu_Click);
            // 
            // btnDodajOsobu
            // 
            this.btnDodajOsobu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajOsobu.ForeColor = System.Drawing.Color.White;
            this.btnDodajOsobu.Location = new System.Drawing.Point(610, 57);
            this.btnDodajOsobu.Name = "btnDodajOsobu";
            this.btnDodajOsobu.Size = new System.Drawing.Size(108, 23);
            this.btnDodajOsobu.TabIndex = 80;
            this.btnDodajOsobu.Text = "DODAJTE";
            this.btnDodajOsobu.UseVisualStyleBackColor = false;
            this.btnDodajOsobu.Click += new System.EventHandler(this.btnDodajOsobu_Click);
            // 
            // buttonOcistiOsobu
            // 
            this.buttonOcistiOsobu.BackColor = System.Drawing.Color.Yellow;
            this.buttonOcistiOsobu.ForeColor = System.Drawing.Color.Black;
            this.buttonOcistiOsobu.Location = new System.Drawing.Point(610, 144);
            this.buttonOcistiOsobu.Name = "buttonOcistiOsobu";
            this.buttonOcistiOsobu.Size = new System.Drawing.Size(108, 23);
            this.buttonOcistiOsobu.TabIndex = 79;
            this.buttonOcistiOsobu.Text = "OČISTITE";
            this.buttonOcistiOsobu.UseVisualStyleBackColor = false;
            this.buttonOcistiOsobu.Click += new System.EventHandler(this.buttonOcistiOsobu_Click);
            // 
            // btnObrisiOsobu
            // 
            this.btnObrisiOsobu.BackColor = System.Drawing.Color.Red;
            this.btnObrisiOsobu.ForeColor = System.Drawing.Color.White;
            this.btnObrisiOsobu.Location = new System.Drawing.Point(610, 115);
            this.btnObrisiOsobu.Name = "btnObrisiOsobu";
            this.btnObrisiOsobu.Size = new System.Drawing.Size(108, 23);
            this.btnObrisiOsobu.TabIndex = 78;
            this.btnObrisiOsobu.Text = "OBRIŠITE";
            this.btnObrisiOsobu.UseVisualStyleBackColor = false;
            this.btnObrisiOsobu.Click += new System.EventHandler(this.btnObrisiOsobu_Click);
            // 
            // dataGridViewOsoba
            // 
            this.dataGridViewOsoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsoba.Location = new System.Drawing.Point(163, 44);
            this.dataGridViewOsoba.Name = "dataGridViewOsoba";
            this.dataGridViewOsoba.Size = new System.Drawing.Size(423, 133);
            this.dataGridViewOsoba.TabIndex = 77;
            this.dataGridViewOsoba.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOsoba_RowHeaderMouseClick);
            // 
            // lblPretragaOsobe
            // 
            this.lblPretragaOsobe.AutoSize = true;
            this.lblPretragaOsobe.Location = new System.Drawing.Point(160, 19);
            this.lblPretragaOsobe.Name = "lblPretragaOsobe";
            this.lblPretragaOsobe.Size = new System.Drawing.Size(111, 13);
            this.lblPretragaOsobe.TabIndex = 76;
            this.lblPretragaOsobe.Text = "Pretraga JMBG osobe";
            // 
            // txtboxPretragaOsobe
            // 
            this.txtboxPretragaOsobe.Location = new System.Drawing.Point(269, 16);
            this.txtboxPretragaOsobe.Name = "txtboxPretragaOsobe";
            this.txtboxPretragaOsobe.Size = new System.Drawing.Size(317, 20);
            this.txtboxPretragaOsobe.TabIndex = 75;
            this.txtboxPretragaOsobe.TextChanged += new System.EventHandler(this.txtboxPretragaOsobe_TextChanged);
            // 
            // lblOsoba
            // 
            this.lblOsoba.AutoSize = true;
            this.lblOsoba.Location = new System.Drawing.Point(8, 9);
            this.lblOsoba.Name = "lblOsoba";
            this.lblOsoba.Size = new System.Drawing.Size(38, 13);
            this.lblOsoba.TabIndex = 74;
            this.lblOsoba.Text = "Osoba";
            // 
            // lblIPrezime
            // 
            this.lblIPrezime.AutoSize = true;
            this.lblIPrezime.Location = new System.Drawing.Point(36, 141);
            this.lblIPrezime.Name = "lblIPrezime";
            this.lblIPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblIPrezime.TabIndex = 73;
            this.lblIPrezime.Text = "Prezime";
            // 
            // txtboxPrezime
            // 
            this.txtboxPrezime.Location = new System.Drawing.Point(39, 157);
            this.txtboxPrezime.Name = "txtboxPrezime";
            this.txtboxPrezime.Size = new System.Drawing.Size(108, 20);
            this.txtboxPrezime.TabIndex = 72;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(36, 90);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 71;
            this.lblIme.Text = "Ime";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(36, 44);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(36, 13);
            this.lblJMBG.TabIndex = 70;
            this.lblJMBG.Text = "JMBG";
            // 
            // txtboxIme
            // 
            this.txtboxIme.Location = new System.Drawing.Point(39, 106);
            this.txtboxIme.Name = "txtboxIme";
            this.txtboxIme.Size = new System.Drawing.Size(108, 20);
            this.txtboxIme.TabIndex = 69;
            // 
            // txtboxJMBG
            // 
            this.txtboxJMBG.Location = new System.Drawing.Point(39, 60);
            this.txtboxJMBG.Name = "txtboxJMBG";
            this.txtboxJMBG.Size = new System.Drawing.Size(108, 20);
            this.txtboxJMBG.TabIndex = 68;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(36, 426);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(148, 13);
            this.lblDatumRodjenja.TabIndex = 85;
            this.lblDatumRodjenja.Text = "Datum rodjenja(\"dd.mm.yyyy\")";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(36, 285);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 87;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtboxAdresa
            // 
            this.txtboxAdresa.Location = new System.Drawing.Point(39, 301);
            this.txtboxAdresa.Name = "txtboxAdresa";
            this.txtboxAdresa.Size = new System.Drawing.Size(108, 20);
            this.txtboxAdresa.TabIndex = 86;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 332);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 89;
            this.lblEmail.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(39, 348);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(108, 20);
            this.txtboxEmail.TabIndex = 88;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(36, 379);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 91;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtboxTelefon
            // 
            this.txtboxTelefon.Location = new System.Drawing.Point(39, 395);
            this.txtboxTelefon.Name = "txtboxTelefon";
            this.txtboxTelefon.Size = new System.Drawing.Size(108, 20);
            this.txtboxTelefon.TabIndex = 90;
            // 
            // lblPTT4
            // 
            this.lblPTT4.AutoSize = true;
            this.lblPTT4.Location = new System.Drawing.Point(36, 237);
            this.lblPTT4.Name = "lblPTT4";
            this.lblPTT4.Size = new System.Drawing.Size(28, 13);
            this.lblPTT4.TabIndex = 93;
            this.lblPTT4.Text = "PTT";
            // 
            // txtboxPTT4
            // 
            this.txtboxPTT4.Location = new System.Drawing.Point(39, 253);
            this.txtboxPTT4.Name = "txtboxPTT4";
            this.txtboxPTT4.Size = new System.Drawing.Size(108, 20);
            this.txtboxPTT4.TabIndex = 92;
            // 
            // cmbboxPol
            // 
            this.cmbboxPol.FormattingEnabled = true;
            this.cmbboxPol.Items.AddRange(new object[] {
            "m",
            "ž"});
            this.cmbboxPol.Location = new System.Drawing.Point(39, 205);
            this.cmbboxPol.Name = "cmbboxPol";
            this.cmbboxPol.Size = new System.Drawing.Size(108, 21);
            this.cmbboxPol.TabIndex = 94;
            // 
            // pictureBoxNazad6
            // 
            this.pictureBoxNazad6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad6.Image")));
            this.pictureBoxNazad6.Location = new System.Drawing.Point(660, 16);
            this.pictureBoxNazad6.Name = "pictureBoxNazad6";
            this.pictureBoxNazad6.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxNazad6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNazad6.TabIndex = 96;
            this.pictureBoxNazad6.TabStop = false;
            this.pictureBoxNazad6.Click += new System.EventHandler(this.pictureBoxNazad6_Click);
            // 
            // pictureBoxIzlaz6
            // 
            this.pictureBoxIzlaz6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIzlaz6.Image")));
            this.pictureBoxIzlaz6.Location = new System.Drawing.Point(692, 16);
            this.pictureBoxIzlaz6.Name = "pictureBoxIzlaz6";
            this.pictureBoxIzlaz6.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxIzlaz6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIzlaz6.TabIndex = 95;
            this.pictureBoxIzlaz6.TabStop = false;
            this.pictureBoxIzlaz6.Click += new System.EventHandler(this.pictureBoxIzlaz6_Click);
            // 
            // txtboxDatumRodjenja
            // 
            this.txtboxDatumRodjenja.Location = new System.Drawing.Point(39, 442);
            this.txtboxDatumRodjenja.Name = "txtboxDatumRodjenja";
            this.txtboxDatumRodjenja.Size = new System.Drawing.Size(108, 20);
            this.txtboxDatumRodjenja.TabIndex = 97;
            // 
            // lblPretragaPTTgrada
            // 
            this.lblPretragaPTTgrada.AutoSize = true;
            this.lblPretragaPTTgrada.Location = new System.Drawing.Point(160, 208);
            this.lblPretragaPTTgrada.Name = "lblPretragaPTTgrada";
            this.lblPretragaPTTgrada.Size = new System.Drawing.Size(101, 13);
            this.lblPretragaPTTgrada.TabIndex = 105;
            this.lblPretragaPTTgrada.Text = "Pretraga PTT grada";
            // 
            // txtboxPretragaPTTgrada
            // 
            this.txtboxPretragaPTTgrada.Location = new System.Drawing.Point(269, 205);
            this.txtboxPretragaPTTgrada.Name = "txtboxPretragaPTTgrada";
            this.txtboxPretragaPTTgrada.Size = new System.Drawing.Size(317, 20);
            this.txtboxPretragaPTTgrada.TabIndex = 104;
            this.txtboxPretragaPTTgrada.TextChanged += new System.EventHandler(this.txtboxPretragaPTTgrada_TextChanged);
            // 
            // dgvPretragaPTTgrada
            // 
            this.dgvPretragaPTTgrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretragaPTTgrada.Location = new System.Drawing.Point(163, 237);
            this.dgvPretragaPTTgrada.Name = "dgvPretragaPTTgrada";
            this.dgvPretragaPTTgrada.Size = new System.Drawing.Size(423, 133);
            this.dgvPretragaPTTgrada.TabIndex = 103;
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 476);
            this.Controls.Add(this.lblPretragaPTTgrada);
            this.Controls.Add(this.txtboxPretragaPTTgrada);
            this.Controls.Add(this.dgvPretragaPTTgrada);
            this.Controls.Add(this.txtboxDatumRodjenja);
            this.Controls.Add(this.pictureBoxNazad6);
            this.Controls.Add(this.pictureBoxIzlaz6);
            this.Controls.Add(this.cmbboxPol);
            this.Controls.Add(this.lblPTT4);
            this.Controls.Add(this.txtboxPTT4);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtboxTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtboxAdresa);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.btnAzurirajOsobu);
            this.Controls.Add(this.btnDodajOsobu);
            this.Controls.Add(this.buttonOcistiOsobu);
            this.Controls.Add(this.btnObrisiOsobu);
            this.Controls.Add(this.dataGridViewOsoba);
            this.Controls.Add(this.lblPretragaOsobe);
            this.Controls.Add(this.txtboxPretragaOsobe);
            this.Controls.Add(this.lblOsoba);
            this.Controls.Add(this.lblIPrezime);
            this.Controls.Add(this.txtboxPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.txtboxIme);
            this.Controls.Add(this.txtboxJMBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Osoba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaPTTgrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Button btnAzurirajOsobu;
        private System.Windows.Forms.Button btnDodajOsobu;
        private System.Windows.Forms.Button buttonOcistiOsobu;
        private System.Windows.Forms.Button btnObrisiOsobu;
        private System.Windows.Forms.DataGridView dataGridViewOsoba;
        private System.Windows.Forms.Label lblPretragaOsobe;
        private System.Windows.Forms.TextBox txtboxPretragaOsobe;
        private System.Windows.Forms.Label lblOsoba;
        private System.Windows.Forms.Label lblIPrezime;
        private System.Windows.Forms.TextBox txtboxPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.TextBox txtboxIme;
        private System.Windows.Forms.TextBox txtboxJMBG;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtboxAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtboxTelefon;
        private System.Windows.Forms.Label lblPTT4;
        private System.Windows.Forms.TextBox txtboxPTT4;
        private System.Windows.Forms.ComboBox cmbboxPol;
        private System.Windows.Forms.PictureBox pictureBoxNazad6;
        private System.Windows.Forms.PictureBox pictureBoxIzlaz6;
        private System.Windows.Forms.TextBox txtboxDatumRodjenja;
        private System.Windows.Forms.Label lblPretragaPTTgrada;
        private System.Windows.Forms.TextBox txtboxPretragaPTTgrada;
        private System.Windows.Forms.DataGridView dgvPretragaPTTgrada;
    }
}