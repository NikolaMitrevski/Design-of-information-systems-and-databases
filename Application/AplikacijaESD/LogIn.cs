using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaESD
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxKorisnickoIme.Text.Equals("admin"))
            {
                if (txtboxLozinka.Text.Equals("12345"))
                {
                    txtboxKorisnickoIme.Text = "";
                    txtboxLozinka.Text = "";
                    this.Hide();
                    Admin admin = new Admin();
                    admin.ShowDialog();
                    admin = null;
                    try { 
                        this.Show();
                    }
                    catch(Exception ex)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Greška! Proveri lozinku.");
                }
            }
            else
            {
                MessageBox.Show("Greška! Proveri korisničko ime.");
            }
        }

        private void pictureBoxIzlaz1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
