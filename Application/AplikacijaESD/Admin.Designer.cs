namespace AplikacijaESD
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.cmbboxAdmin = new System.Windows.Forms.ComboBox();
            this.lblIzbor = new System.Windows.Forms.Label();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.pictureBoxIzlaz2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNazad2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbboxAdmin
            // 
            this.cmbboxAdmin.FormattingEnabled = true;
            this.cmbboxAdmin.Items.AddRange(new object[] {
            "Grad",
            "Smer",
            "Škola",
            "Nastavnik",
            "Odeljenje",
            "Osoba",
            "Učenik",
            "Vladanje"});
            this.cmbboxAdmin.Location = new System.Drawing.Point(57, 89);
            this.cmbboxAdmin.Name = "cmbboxAdmin";
            this.cmbboxAdmin.Size = new System.Drawing.Size(139, 21);
            this.cmbboxAdmin.TabIndex = 0;
            // 
            // lblIzbor
            // 
            this.lblIzbor.AutoSize = true;
            this.lblIzbor.Location = new System.Drawing.Point(71, 63);
            this.lblIzbor.Name = "lblIzbor";
            this.lblIzbor.Size = new System.Drawing.Size(111, 13);
            this.lblIzbor.TabIndex = 1;
            this.lblIzbor.Text = "Izaberite jednu stavku";
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPotvrda.ForeColor = System.Drawing.Color.White;
            this.btnPotvrda.Location = new System.Drawing.Point(58, 277);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(139, 33);
            this.btnPotvrda.TabIndex = 7;
            this.btnPotvrda.Text = "POTVRDITE";
            this.btnPotvrda.UseVisualStyleBackColor = false;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // pictureBoxIzlaz2
            // 
            this.pictureBoxIzlaz2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIzlaz2.Image")));
            this.pictureBoxIzlaz2.Location = new System.Drawing.Point(223, 12);
            this.pictureBoxIzlaz2.Name = "pictureBoxIzlaz2";
            this.pictureBoxIzlaz2.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxIzlaz2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIzlaz2.TabIndex = 8;
            this.pictureBoxIzlaz2.TabStop = false;
            this.pictureBoxIzlaz2.Click += new System.EventHandler(this.pictureBoxIzlaz2_Click);
            // 
            // pictureBoxNazad2
            // 
            this.pictureBoxNazad2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad2.Image")));
            this.pictureBoxNazad2.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxNazad2.Name = "pictureBoxNazad2";
            this.pictureBoxNazad2.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxNazad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNazad2.TabIndex = 9;
            this.pictureBoxNazad2.TabStop = false;
            this.pictureBoxNazad2.Click += new System.EventHandler(this.pictureBoxNazad2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 346);
            this.Controls.Add(this.pictureBoxNazad2);
            this.Controls.Add(this.pictureBoxIzlaz2);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.lblIzbor);
            this.Controls.Add(this.cmbboxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxAdmin;
        private System.Windows.Forms.Label lblIzbor;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.PictureBox pictureBoxIzlaz2;
        private System.Windows.Forms.PictureBox pictureBoxNazad2;
    }
}