namespace AplikacijaESD
{
    partial class Odeljenje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeljenje));
            this.btnAzurirajOdeljenje = new System.Windows.Forms.Button();
            this.btnDodajOdeljenje = new System.Windows.Forms.Button();
            this.buttonOcistiOdeljenje = new System.Windows.Forms.Button();
            this.btnObrisiOdeljenje = new System.Windows.Forms.Button();
            this.dataGridViewOdeljenje = new System.Windows.Forms.DataGridView();
            this.lblPretragaOdeljenja = new System.Windows.Forms.Label();
            this.txtboxPretragaOdeljenja = new System.Windows.Forms.TextBox();
            this.lblSmer = new System.Windows.Forms.Label();
            this.lblIRazred = new System.Windows.Forms.Label();
            this.txtboxRazred = new System.Windows.Forms.TextBox();
            this.lblNazivOdeljenja = new System.Windows.Forms.Label();
            this.lblIOdeljenja = new System.Windows.Forms.Label();
            this.txtboxNazivOdeljenja = new System.Windows.Forms.TextBox();
            this.txtboxIDOdeljenja = new System.Windows.Forms.TextBox();
            this.lblIDSkole3 = new System.Windows.Forms.Label();
            this.txtboxIDSkole3 = new System.Windows.Forms.TextBox();
            this.pictureBoxNazad5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIzlaz5 = new System.Windows.Forms.PictureBox();
            this.lblPretragaIDskole = new System.Windows.Forms.Label();
            this.txtboxPretragaIDskole = new System.Windows.Forms.TextBox();
            this.dgvPretragaIDskole = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdeljenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaIDskole)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzurirajOdeljenje
            // 
            this.btnAzurirajOdeljenje.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAzurirajOdeljenje.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajOdeljenje.Location = new System.Drawing.Point(610, 89);
            this.btnAzurirajOdeljenje.Name = "btnAzurirajOdeljenje";
            this.btnAzurirajOdeljenje.Size = new System.Drawing.Size(108, 23);
            this.btnAzurirajOdeljenje.TabIndex = 65;
            this.btnAzurirajOdeljenje.Text = "AŽURIRAJTE";
            this.btnAzurirajOdeljenje.UseVisualStyleBackColor = false;
            this.btnAzurirajOdeljenje.Click += new System.EventHandler(this.btnAzurirajOdeljenje_Click);
            // 
            // btnDodajOdeljenje
            // 
            this.btnDodajOdeljenje.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajOdeljenje.ForeColor = System.Drawing.Color.White;
            this.btnDodajOdeljenje.Location = new System.Drawing.Point(610, 60);
            this.btnDodajOdeljenje.Name = "btnDodajOdeljenje";
            this.btnDodajOdeljenje.Size = new System.Drawing.Size(108, 23);
            this.btnDodajOdeljenje.TabIndex = 64;
            this.btnDodajOdeljenje.Text = "DODAJTE";
            this.btnDodajOdeljenje.UseVisualStyleBackColor = false;
            this.btnDodajOdeljenje.Click += new System.EventHandler(this.btnDodajOdeljenje_Click);
            // 
            // buttonOcistiOdeljenje
            // 
            this.buttonOcistiOdeljenje.BackColor = System.Drawing.Color.Yellow;
            this.buttonOcistiOdeljenje.ForeColor = System.Drawing.Color.Black;
            this.buttonOcistiOdeljenje.Location = new System.Drawing.Point(610, 147);
            this.buttonOcistiOdeljenje.Name = "buttonOcistiOdeljenje";
            this.buttonOcistiOdeljenje.Size = new System.Drawing.Size(108, 23);
            this.buttonOcistiOdeljenje.TabIndex = 63;
            this.buttonOcistiOdeljenje.Text = "OČISTITE";
            this.buttonOcistiOdeljenje.UseVisualStyleBackColor = false;
            this.buttonOcistiOdeljenje.Click += new System.EventHandler(this.buttonOcistiOdeljenje_Click);
            // 
            // btnObrisiOdeljenje
            // 
            this.btnObrisiOdeljenje.BackColor = System.Drawing.Color.Red;
            this.btnObrisiOdeljenje.ForeColor = System.Drawing.Color.White;
            this.btnObrisiOdeljenje.Location = new System.Drawing.Point(610, 118);
            this.btnObrisiOdeljenje.Name = "btnObrisiOdeljenje";
            this.btnObrisiOdeljenje.Size = new System.Drawing.Size(108, 23);
            this.btnObrisiOdeljenje.TabIndex = 62;
            this.btnObrisiOdeljenje.Text = "OBRIŠITE";
            this.btnObrisiOdeljenje.UseVisualStyleBackColor = false;
            this.btnObrisiOdeljenje.Click += new System.EventHandler(this.btnObrisiOdeljenje_Click);
            // 
            // dataGridViewOdeljenje
            // 
            this.dataGridViewOdeljenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdeljenje.Location = new System.Drawing.Point(163, 47);
            this.dataGridViewOdeljenje.Name = "dataGridViewOdeljenje";
            this.dataGridViewOdeljenje.Size = new System.Drawing.Size(423, 133);
            this.dataGridViewOdeljenje.TabIndex = 61;
            this.dataGridViewOdeljenje.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOdeljenje_RowHeaderMouseClick);
            // 
            // lblPretragaOdeljenja
            // 
            this.lblPretragaOdeljenja.AutoSize = true;
            this.lblPretragaOdeljenja.Location = new System.Drawing.Point(160, 22);
            this.lblPretragaOdeljenja.Name = "lblPretragaOdeljenja";
            this.lblPretragaOdeljenja.Size = new System.Drawing.Size(106, 13);
            this.lblPretragaOdeljenja.TabIndex = 60;
            this.lblPretragaOdeljenja.Text = "Pretraga ID odeljenja";
            // 
            // txtboxPretragaOdeljenja
            // 
            this.txtboxPretragaOdeljenja.Location = new System.Drawing.Point(272, 19);
            this.txtboxPretragaOdeljenja.Name = "txtboxPretragaOdeljenja";
            this.txtboxPretragaOdeljenja.Size = new System.Drawing.Size(314, 20);
            this.txtboxPretragaOdeljenja.TabIndex = 59;
            this.txtboxPretragaOdeljenja.TextChanged += new System.EventHandler(this.txtboxPretragaOdeljenja_TextChanged);
            // 
            // lblSmer
            // 
            this.lblSmer.AutoSize = true;
            this.lblSmer.Location = new System.Drawing.Point(8, 12);
            this.lblSmer.Name = "lblSmer";
            this.lblSmer.Size = new System.Drawing.Size(51, 13);
            this.lblSmer.TabIndex = 58;
            this.lblSmer.Text = "Odeljenje";
            // 
            // lblIRazred
            // 
            this.lblIRazred.AutoSize = true;
            this.lblIRazred.Location = new System.Drawing.Point(36, 144);
            this.lblIRazred.Name = "lblIRazred";
            this.lblIRazred.Size = new System.Drawing.Size(41, 13);
            this.lblIRazred.TabIndex = 57;
            this.lblIRazred.Text = "Razred";
            // 
            // txtboxRazred
            // 
            this.txtboxRazred.Location = new System.Drawing.Point(39, 160);
            this.txtboxRazred.Name = "txtboxRazred";
            this.txtboxRazred.Size = new System.Drawing.Size(108, 20);
            this.txtboxRazred.TabIndex = 56;
            // 
            // lblNazivOdeljenja
            // 
            this.lblNazivOdeljenja.AutoSize = true;
            this.lblNazivOdeljenja.Location = new System.Drawing.Point(36, 93);
            this.lblNazivOdeljenja.Name = "lblNazivOdeljenja";
            this.lblNazivOdeljenja.Size = new System.Drawing.Size(79, 13);
            this.lblNazivOdeljenja.TabIndex = 55;
            this.lblNazivOdeljenja.Text = "Naziv odeljenja";
            // 
            // lblIOdeljenja
            // 
            this.lblIOdeljenja.AutoSize = true;
            this.lblIOdeljenja.Location = new System.Drawing.Point(36, 47);
            this.lblIOdeljenja.Name = "lblIOdeljenja";
            this.lblIOdeljenja.Size = new System.Drawing.Size(63, 13);
            this.lblIOdeljenja.TabIndex = 54;
            this.lblIOdeljenja.Text = "ID odeljenja";
            // 
            // txtboxNazivOdeljenja
            // 
            this.txtboxNazivOdeljenja.Location = new System.Drawing.Point(39, 109);
            this.txtboxNazivOdeljenja.Name = "txtboxNazivOdeljenja";
            this.txtboxNazivOdeljenja.Size = new System.Drawing.Size(108, 20);
            this.txtboxNazivOdeljenja.TabIndex = 53;
            // 
            // txtboxIDOdeljenja
            // 
            this.txtboxIDOdeljenja.Location = new System.Drawing.Point(39, 63);
            this.txtboxIDOdeljenja.Name = "txtboxIDOdeljenja";
            this.txtboxIDOdeljenja.Size = new System.Drawing.Size(108, 20);
            this.txtboxIDOdeljenja.TabIndex = 52;
            // 
            // lblIDSkole3
            // 
            this.lblIDSkole3.AutoSize = true;
            this.lblIDSkole3.Location = new System.Drawing.Point(36, 193);
            this.lblIDSkole3.Name = "lblIDSkole3";
            this.lblIDSkole3.Size = new System.Drawing.Size(46, 13);
            this.lblIDSkole3.TabIndex = 67;
            this.lblIDSkole3.Text = "ID škole";
            // 
            // txtboxIDSkole3
            // 
            this.txtboxIDSkole3.Location = new System.Drawing.Point(39, 209);
            this.txtboxIDSkole3.Name = "txtboxIDSkole3";
            this.txtboxIDSkole3.Size = new System.Drawing.Size(108, 20);
            this.txtboxIDSkole3.TabIndex = 66;
            // 
            // pictureBoxNazad5
            // 
            this.pictureBoxNazad5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad5.Image")));
            this.pictureBoxNazad5.Location = new System.Drawing.Point(660, 19);
            this.pictureBoxNazad5.Name = "pictureBoxNazad5";
            this.pictureBoxNazad5.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxNazad5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNazad5.TabIndex = 69;
            this.pictureBoxNazad5.TabStop = false;
            this.pictureBoxNazad5.Click += new System.EventHandler(this.pictureBoxNazad5_Click);
            // 
            // pictureBoxIzlaz5
            // 
            this.pictureBoxIzlaz5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIzlaz5.Image")));
            this.pictureBoxIzlaz5.Location = new System.Drawing.Point(692, 19);
            this.pictureBoxIzlaz5.Name = "pictureBoxIzlaz5";
            this.pictureBoxIzlaz5.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxIzlaz5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIzlaz5.TabIndex = 68;
            this.pictureBoxIzlaz5.TabStop = false;
            this.pictureBoxIzlaz5.Click += new System.EventHandler(this.pictureBoxIzlaz5_Click);
            // 
            // lblPretragaIDskole
            // 
            this.lblPretragaIDskole.AutoSize = true;
            this.lblPretragaIDskole.Location = new System.Drawing.Point(160, 212);
            this.lblPretragaIDskole.Name = "lblPretragaIDskole";
            this.lblPretragaIDskole.Size = new System.Drawing.Size(89, 13);
            this.lblPretragaIDskole.TabIndex = 102;
            this.lblPretragaIDskole.Text = "Pretraga ID škole";
            // 
            // txtboxPretragaIDskole
            // 
            this.txtboxPretragaIDskole.Location = new System.Drawing.Point(272, 209);
            this.txtboxPretragaIDskole.Name = "txtboxPretragaIDskole";
            this.txtboxPretragaIDskole.Size = new System.Drawing.Size(314, 20);
            this.txtboxPretragaIDskole.TabIndex = 101;
            this.txtboxPretragaIDskole.TextChanged += new System.EventHandler(this.txtboxPretragaIDskole_TextChanged);
            // 
            // dgvPretragaIDskole
            // 
            this.dgvPretragaIDskole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretragaIDskole.Location = new System.Drawing.Point(163, 238);
            this.dgvPretragaIDskole.Name = "dgvPretragaIDskole";
            this.dgvPretragaIDskole.Size = new System.Drawing.Size(423, 133);
            this.dgvPretragaIDskole.TabIndex = 100;
            // 
            // Odeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 390);
            this.Controls.Add(this.lblPretragaIDskole);
            this.Controls.Add(this.txtboxPretragaIDskole);
            this.Controls.Add(this.dgvPretragaIDskole);
            this.Controls.Add(this.pictureBoxNazad5);
            this.Controls.Add(this.pictureBoxIzlaz5);
            this.Controls.Add(this.lblIDSkole3);
            this.Controls.Add(this.txtboxIDSkole3);
            this.Controls.Add(this.btnAzurirajOdeljenje);
            this.Controls.Add(this.btnDodajOdeljenje);
            this.Controls.Add(this.buttonOcistiOdeljenje);
            this.Controls.Add(this.btnObrisiOdeljenje);
            this.Controls.Add(this.dataGridViewOdeljenje);
            this.Controls.Add(this.lblPretragaOdeljenja);
            this.Controls.Add(this.txtboxPretragaOdeljenja);
            this.Controls.Add(this.lblSmer);
            this.Controls.Add(this.lblIRazred);
            this.Controls.Add(this.txtboxRazred);
            this.Controls.Add(this.lblNazivOdeljenja);
            this.Controls.Add(this.lblIOdeljenja);
            this.Controls.Add(this.txtboxNazivOdeljenja);
            this.Controls.Add(this.txtboxIDOdeljenja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Odeljenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeljenje";
            this.Load += new System.EventHandler(this.Odeljenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdeljenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaIDskole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajOdeljenje;
        private System.Windows.Forms.Button btnDodajOdeljenje;
        private System.Windows.Forms.Button buttonOcistiOdeljenje;
        private System.Windows.Forms.Button btnObrisiOdeljenje;
        private System.Windows.Forms.DataGridView dataGridViewOdeljenje;
        private System.Windows.Forms.Label lblPretragaOdeljenja;
        private System.Windows.Forms.TextBox txtboxPretragaOdeljenja;
        private System.Windows.Forms.Label lblSmer;
        private System.Windows.Forms.Label lblIRazred;
        private System.Windows.Forms.TextBox txtboxRazred;
        private System.Windows.Forms.Label lblNazivOdeljenja;
        private System.Windows.Forms.Label lblIOdeljenja;
        private System.Windows.Forms.TextBox txtboxNazivOdeljenja;
        private System.Windows.Forms.TextBox txtboxIDOdeljenja;
        private System.Windows.Forms.Label lblIDSkole3;
        private System.Windows.Forms.TextBox txtboxIDSkole3;
        private System.Windows.Forms.PictureBox pictureBoxNazad5;
        private System.Windows.Forms.PictureBox pictureBoxIzlaz5;
        private System.Windows.Forms.Label lblPretragaIDskole;
        private System.Windows.Forms.TextBox txtboxPretragaIDskole;
        private System.Windows.Forms.DataGridView dgvPretragaIDskole;
    }
}