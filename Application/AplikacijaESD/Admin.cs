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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBoxIzlaz2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxNazad2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            string rez = cmbboxAdmin.Text;
            if(rez != null)
            {
                if (rez == "Grad")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Grad grad = new Grad();
                    grad.ShowDialog();
                    grad = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if (rez == "Smer")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Smer smer = new Smer();
                    smer.ShowDialog();
                    smer = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if (rez == "Škola")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Skola skola = new Skola();
                    skola.ShowDialog();
                    skola = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if (rez == "Nastavnik")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Nastavnik nastavnik = new Nastavnik();
                    nastavnik.ShowDialog();
                    nastavnik = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if(rez == "Odeljenje")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Odeljenje odeljenje = new Odeljenje();
                    odeljenje.ShowDialog();
                    odeljenje = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if(rez == "Osoba")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Osoba osoba = new Osoba();
                    osoba.ShowDialog();
                    osoba = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if(rez == "Učenik")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Ucenik ucenik = new Ucenik();
                    ucenik.ShowDialog();
                    ucenik = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else if(rez == "Vladanje")
                {
                    cmbboxAdmin.Text = "";
                    this.Hide();
                    Vladanje vladanje = new Vladanje();
                    vladanje.ShowDialog();
                    vladanje = null;
                    try
                    {
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Greška! Loš izbor stavke.");
                }
            }
         }

        
    }
}
