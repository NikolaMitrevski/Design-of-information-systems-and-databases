namespace AplikacijaESD
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBoxGrb = new System.Windows.Forms.PictureBox();
            this.txtboxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtboxLozinka = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblNaslov1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxIzlaz1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGrb
            // 
            this.pictureBoxGrb.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrb.Image")));
            this.pictureBoxGrb.Location = new System.Drawing.Point(75, 21);
            this.pictureBoxGrb.Name = "pictureBoxGrb";
            this.pictureBoxGrb.Size = new System.Drawing.Size(108, 76);
            this.pictureBoxGrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGrb.TabIndex = 0;
            this.pictureBoxGrb.TabStop = false;
            // 
            // txtboxKorisnickoIme
            // 
            this.txtboxKorisnickoIme.Location = new System.Drawing.Point(75, 175);
            this.txtboxKorisnickoIme.Name = "txtboxKorisnickoIme";
            this.txtboxKorisnickoIme.Size = new System.Drawing.Size(108, 20);
            this.txtboxKorisnickoIme.TabIndex = 1;
            // 
            // txtboxLozinka
            // 
            this.txtboxLozinka.Location = new System.Drawing.Point(75, 221);
            this.txtboxLozinka.Name = "txtboxLozinka";
            this.txtboxLozinka.Size = new System.Drawing.Size(108, 20);
            this.txtboxLozinka.TabIndex = 2;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(72, 159);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 3;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(72, 205);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 4;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblNaslov1
            // 
            this.lblNaslov1.AutoSize = true;
            this.lblNaslov1.Location = new System.Drawing.Point(62, 100);
            this.lblNaslov1.Name = "lblNaslov1";
            this.lblNaslov1.Size = new System.Drawing.Size(135, 13);
            this.lblNaslov1.TabIndex = 5;
            this.lblNaslov1.Text = "Elektronski školski dnevnik";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(65, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRIJAVITE SE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxIzlaz1
            // 
            this.pictureBoxIzlaz1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIzlaz1.Image")));
            this.pictureBoxIzlaz1.Location = new System.Drawing.Point(223, 12);
            this.pictureBoxIzlaz1.Name = "pictureBoxIzlaz1";
            this.pictureBoxIzlaz1.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxIzlaz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIzlaz1.TabIndex = 7;
            this.pictureBoxIzlaz1.TabStop = false;
            this.pictureBoxIzlaz1.Click += new System.EventHandler(this.pictureBoxIzlaz1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 346);
            this.Controls.Add(this.pictureBoxIzlaz1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNaslov1);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtboxLozinka);
            this.Controls.Add(this.txtboxKorisnickoIme);
            this.Controls.Add(this.pictureBoxGrb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzlaz1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGrb;
        private System.Windows.Forms.TextBox txtboxKorisnickoIme;
        private System.Windows.Forms.TextBox txtboxLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblNaslov1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxIzlaz1;
    }
}

