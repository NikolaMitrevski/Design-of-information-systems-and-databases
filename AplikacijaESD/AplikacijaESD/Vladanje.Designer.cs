namespace AplikacijaESD
{
    partial class Vladanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vladanje));
            this.btnAzurirajVladanje = new System.Windows.Forms.Button();
            this.btnDodajVladanje = new System.Windows.Forms.Button();
            this.buttonOcistiVladanje = new System.Windows.Forms.Button();
            this.btnObrisiVladanje = new System.Windows.Forms.Button();
            this.dataGridViewVladanje = new System.Windows.Forms.DataGridView();
            this.lblPretragaVladanja = new System.Windows.Forms.Label();
            this.txtboxPretragaVladanja = new System.Windows.Forms.TextBox();
            this.lblVladanje = new System.Windows.Forms.Label();
            this.lblOpisVladanja = new System.Windows.Forms.Label();
            this.txtboxOpisVladanja = new System.Windows.Forms.TextBox();
            this.lblOcenaVladanja = new System.Windows.Forms.Label();
            this.lblIDVladanja = new System.Windows.Forms.Label();
            this.txtboxOcenaVladanja = new System.Windows.Forms.TextBox();
            this.txtboxIDVladanja = new System.Windows.Forms.TextBox();
            this.pictureBoxNazad10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIzlaz10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVladanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzurirajVladanje
            // 
            this.btnAzurirajVladanje.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAzurirajVladanje.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajVladanje.Location = new System.Drawing.Point(612, 91);
            this.btnAzurirajVladanje.Name = "btnAzurirajVladanje";
            this.btnAzurirajVladanje.Size = new System.Drawing.Size(108, 23);
            this.btnAzurirajVladanje.TabIndex = 65;
            this.btnAzurirajVladanje.Text = "AŽURIRAJTE";
            this.btnAzurirajVladanje.UseVisualStyleBackColor = false;
            this.btnAzurirajVladanje.Click += new System.EventHandler(this.btnAzurirajVladanje_Click);
            // 
            // btnDodajVladanje
            // 
            this.btnDodajVladanje.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajVladanje.ForeColor = System.Drawing.Color.White;
            this.btnDodajVladanje.Location = new System.Drawing.Point(612, 62);
            this.btnDodajVladanje.Name = "btnDodajVladanje";
            this.btnDodajVladanje.Size = new System.Drawing.Size(108, 23);
            this.btnDodajVladanje.TabIndex = 64;
            this.btnDodajVladanje.Text = "DODAJTE";
            this.btnDodajVladanje.UseVisualStyleBackColor = false;
            this.btnDodajVladanje.Click += new System.EventHandler(this.btnDodajVladanje_Click);
            // 
            // buttonOcistiVladanje
            // 
            this.buttonOcistiVladanje.BackColor = System.Drawing.Color.Yellow;
            this.buttonOcistiVladanje.ForeColor = System.Drawing.Color.Black;
            this.buttonOcistiVladanje.Location = new System.Drawing.Point(612, 149);
            this.buttonOcistiVladanje.Name = "buttonOcistiVladanje";
            this.buttonOcistiVladanje.Size = new System.Drawing.Size(108, 23);
            this.buttonOcistiVladanje.TabIndex = 63;
            this.buttonOcistiVladanje.Text = "OČISTITE";
            this.buttonOcistiVladanje.UseVisualStyleBackColor = false;
            this.buttonOcistiVladanje.Click += new System.EventHandler(this.buttonOcistiVladanje_Click);
            // 
            // btnObrisiVladanje
            // 
            this.btnObrisiVladanje.BackColor = System.Drawing.Color.Red;
            this.btnObrisiVladanje.ForeColor = System.Drawing.Color.White;
            this.btnObrisiVladanje.Location = new System.Drawing.Point(612, 120);
            this.btnObrisiVladanje.Name = "btnObrisiVladanje";
            this.btnObrisiVladanje.Size = new System.Drawing.Size(108, 23);
            this.btnObrisiVladanje.TabIndex = 62;
            this.btnObrisiVladanje.Text = "OBRIŠITE";
            this.btnObrisiVladanje.UseVisualStyleBackColor = false;
            this.btnObrisiVladanje.Click += new System.EventHandler(this.btnObrisiVladanje_Click);
            // 
            // dataGridViewVladanje
            // 
            this.dataGridViewVladanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVladanje.Location = new System.Drawing.Point(165, 49);
            this.dataGridViewVladanje.Name = "dataGridViewVladanje";
            this.dataGridViewVladanje.Size = new System.Drawing.Size(423, 133);
            this.dataGridViewVladanje.TabIndex = 61;
            this.dataGridViewVladanje.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVladanje_RowHeaderMouseClick);
            // 
            // lblPretragaVladanja
            // 
            this.lblPretragaVladanja.AutoSize = true;
            this.lblPretragaVladanja.Location = new System.Drawing.Point(162, 24);
            this.lblPretragaVladanja.Name = "lblPretragaVladanja";
            this.lblPretragaVladanja.Size = new System.Drawing.Size(104, 13);
            this.lblPretragaVladanja.TabIndex = 60;
            this.lblPretragaVladanja.Text = "Pretraga ID vladanja";
            // 
            // txtboxPretragaVladanja
            // 
            this.txtboxPretragaVladanja.Location = new System.Drawing.Point(272, 21);
            this.txtboxPretragaVladanja.Name = "txtboxPretragaVladanja";
            this.txtboxPretragaVladanja.Size = new System.Drawing.Size(316, 20);
            this.txtboxPretragaVladanja.TabIndex = 59;
            this.txtboxPretragaVladanja.TextChanged += new System.EventHandler(this.txtboxPretragaVladanja_TextChanged);
            // 
            // lblVladanje
            // 
            this.lblVladanje.AutoSize = true;
            this.lblVladanje.Location = new System.Drawing.Point(10, 14);
            this.lblVladanje.Name = "lblVladanje";
            this.lblVladanje.Size = new System.Drawing.Size(48, 13);
            this.lblVladanje.TabIndex = 58;
            this.lblVladanje.Text = "Vladanje";
            // 
            // lblOpisVladanja
            // 
            this.lblOpisVladanja.AutoSize = true;
            this.lblOpisVladanja.Location = new System.Drawing.Point(38, 146);
            this.lblOpisVladanja.Name = "lblOpisVladanja";
            this.lblOpisVladanja.Size = new System.Drawing.Size(71, 13);
            this.lblOpisVladanja.TabIndex = 57;
            this.lblOpisVladanja.Text = "Opis vladanja";
            // 
            // txtboxOpisVladanja
            // 
            this.txtboxOpisVladanja.Location = new System.Drawing.Point(41, 162);
            this.txtboxOpisVladanja.Multiline = true;
            this.txtboxOpisVladanja.Name = "txtboxOpisVladanja";
            this.txtboxOpisVladanja.Size = new System.Drawing.Size(108, 87);
            this.txtboxOpisVladanja.TabIndex = 56;
            // 
            // lblOcenaVladanja
            // 
            this.lblOcenaVladanja.AutoSize = true;
            this.lblOcenaVladanja.Location = new System.Drawing.Point(38, 95);
            this.lblOcenaVladanja.Name = "lblOcenaVladanja";
            this.lblOcenaVladanja.Size = new System.Drawing.Size(82, 13);
            this.lblOcenaVladanja.TabIndex = 55;
            this.lblOcenaVladanja.Text = "Ocena vladanja";
            // 
            // lblIDVladanja
            // 
            this.lblIDVladanja.AutoSize = true;
            this.lblIDVladanja.Location = new System.Drawing.Point(38, 49);
            this.lblIDVladanja.Name = "lblIDVladanja";
            this.lblIDVladanja.Size = new System.Drawing.Size(61, 13);
            this.lblIDVladanja.TabIndex = 54;
            this.lblIDVladanja.Text = "ID vladanja";
            // 
            // txtboxOcenaVladanja
            // 
            this.txtboxOcenaVladanja.Location = new System.Drawing.Point(41, 111);
            this.txtboxOcenaVladanja.Name = "txtboxOcenaVladanja";
            this.txtboxOcenaVladanja.Size = new System.Drawing.Size(108, 20);
            this.txtboxOcenaVladanja.TabIndex = 53;
            // 
            // txtboxIDVladanja
            // 
            this.txtboxIDVladanja.Location = new System.Drawing.Point(41, 65);
            this.txtboxIDVladanja.Name = "txtboxIDVladanja";
            this.txtboxIDVladanja.Size = new System.Drawing.Size(108, 20);
            this.txtboxIDVladanja.TabIndex = 52;
            // 
            // pictureBoxNazad10
            // 
            this.pictureBoxNazad10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad10.Image")));
            this.pictureBoxNazad10.Location = new System.Drawing.Point(662, 21);
            this.pictureBoxNazad10.Name = "pictureBoxNazad10";
            this.pictureBoxNazad10.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxNazad10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNazad10.TabIndex = 67;
            this.pictureBoxNazad10.TabStop = false;
            this.pictureBoxNazad10.Click += new System.EventHandler(this.pictureBoxNazad10_Click);
            // 
            // pictureBoxIzlaz10
            // 
            this.pictureBoxIzlaz10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIzlaz10.Image")));
            this.pictureBoxIzlaz10.Location = new System.Drawing.Point(694, 21);
            this.pictureBoxIzlaz10.Name = "pictureBoxIzlaz10";
            this.pictureBoxIzlaz10.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxIzlaz10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIzlaz10.TabIndex = 66;
            this.pictureBoxIzlaz10.TabStop = false;
            this.pictureBoxIzlaz10.Click += new System.EventHandler(this.pictureBoxIzlaz10_Click);
            // 
            // Vladanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 259);
            this.Controls.Add(this.pictureBoxNazad10);
            this.Controls.Add(this.pictureBoxIzlaz10);
            this.Controls.Add(this.btnAzurirajVladanje);
            this.Controls.Add(this.btnDodajVladanje);
            this.Controls.Add(this.buttonOcistiVladanje);
            this.Controls.Add(this.btnObrisiVladanje);
            this.Controls.Add(this.dataGridViewVladanje);
            this.Controls.Add(this.lblPretragaVladanja);
            this.Controls.Add(this.txtboxPretragaVladanja);
            this.Controls.Add(this.lblVladanje);
            this.Controls.Add(this.lblOpisVladanja);
            this.Controls.Add(this.txtboxOpisVladanja);
            this.Controls.Add(this.lblOcenaVladanja);
            this.Controls.Add(this.lblIDVladanja);
            this.Controls.Add(this.txtboxOcenaVladanja);
            this.Controls.Add(this.txtboxIDVladanja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vladanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vladanje";
            this.Load += new System.EventHandler(this.Vladanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVladanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajVladanje;
        private System.Windows.Forms.Button btnDodajVladanje;
        private System.Windows.Forms.Button buttonOcistiVladanje;
        private System.Windows.Forms.Button btnObrisiVladanje;
        private System.Windows.Forms.DataGridView dataGridViewVladanje;
        private System.Windows.Forms.Label lblPretragaVladanja;
        private System.Windows.Forms.TextBox txtboxPretragaVladanja;
        private System.Windows.Forms.Label lblVladanje;
        private System.Windows.Forms.Label lblOpisVladanja;
        private System.Windows.Forms.TextBox txtboxOpisVladanja;
        private System.Windows.Forms.Label lblOcenaVladanja;
        private System.Windows.Forms.Label lblIDVladanja;
        private System.Windows.Forms.TextBox txtboxOcenaVladanja;
        private System.Windows.Forms.TextBox txtboxIDVladanja;
        private System.Windows.Forms.PictureBox pictureBoxNazad10;
        private System.Windows.Forms.PictureBox pictureBoxIzlaz10;
    }
}