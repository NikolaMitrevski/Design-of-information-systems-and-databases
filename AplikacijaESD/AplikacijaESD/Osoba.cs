using AplikacijaESD.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaESD
{
    public partial class Osoba : Form
    {
        public Osoba()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Osoba_Load(object sender, EventArgs e)
        {
            DataTable dt1 = databaseHelper.SelectDataFromOsoba();
            dataGridViewOsoba.DataSource = dt1;

            DataTable dt2 = databaseHelper.SelectDataFromGrad();
            dgvPretragaPTTgrada.DataSource = dt2;
        }

        public void Clear()
        {
            txtboxJMBG.Text = "";
            txtboxIme.Text = "";
            txtboxPrezime.Text = "";
            cmbboxPol.Text = "";
            txtboxDatumRodjenja.Text = "";
            txtboxAdresa.Text = "";
            txtboxEmail.Text = "";
            txtboxTelefon.Text = "";
            txtboxPTT4.Text = "";
        }

        private void btnDodajOsobu_Click(object sender, EventArgs e)
        {
            if (Provera.proveraOsobe(txtboxJMBG.Text, txtboxIme.Text, txtboxPrezime.Text, cmbboxPol.Text, txtboxDatumRodjenja.Text, txtboxAdresa.Text, txtboxEmail.Text, txtboxTelefon.Text, txtboxPTT4.Text)) {
                //  1
                int jmbg = int.Parse(txtboxJMBG.Text);
                string ime = txtboxIme.Text;
                string prezime = txtboxPrezime.Text;
                string pol = cmbboxPol.Text;
                DateTime datumRodjenja = DateTime.ParseExact(txtboxDatumRodjenja.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string adresa = txtboxAdresa.Text;
                string email = txtboxEmail.Text;
                long telefon = long.Parse(txtboxTelefon.Text);
                int ptt = int.Parse(txtboxPTT4.Text);

                //  2
                bool success = databaseHelper.InsertDataInOsoba(jmbg, ime, prezime, pol, datumRodjenja, adresa, email, telefon, ptt);
                if (success == true)
                {
                    MessageBox.Show("Osoba je uspešno dodat.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja osobe! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromOsoba();
                dataGridViewOsoba.DataSource = dt;
            }
        }

        private void btnAzurirajOsobu_Click(object sender, EventArgs e)
        {
            if (Provera.proveraOsobe(txtboxJMBG.Text, txtboxIme.Text, txtboxPrezime.Text, cmbboxPol.Text, txtboxDatumRodjenja.Text, txtboxAdresa.Text, txtboxEmail.Text, txtboxTelefon.Text, txtboxPTT4.Text))
            {
                //  1
                int jmbg = int.Parse(txtboxJMBG.Text);
                string ime = txtboxIme.Text;
                string prezime = txtboxPrezime.Text;
                string pol = cmbboxPol.Text;
                DateTime datumRodjenja = DateTime.ParseExact(txtboxDatumRodjenja.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string adresa = txtboxAdresa.Text;
                string email = txtboxEmail.Text;
                long telefon = long.Parse(txtboxTelefon.Text);
                int ptt = int.Parse(txtboxPTT4.Text);

                //  2
                bool success = databaseHelper.UpdateDataInOsoba(jmbg, ime, prezime, pol, datumRodjenja, adresa, email, telefon, ptt);
                if (success == true)
                {
                    MessageBox.Show("Osoba je uspešno ažurirana.");

                    DataTable dt = databaseHelper.SelectDataFromOsoba();
                    dataGridViewOsoba.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja osobe! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewOsoba_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxJMBG.Text = dataGridViewOsoba.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxIme.Text = dataGridViewOsoba.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxPrezime.Text = dataGridViewOsoba.Rows[rowIndex].Cells[2].Value.ToString();
            cmbboxPol.Text = dataGridViewOsoba.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxDatumRodjenja.Text = dataGridViewOsoba.Rows[rowIndex].Cells[4].Value.ToString();
            txtboxAdresa.Text = dataGridViewOsoba.Rows[rowIndex].Cells[5].Value.ToString();
            txtboxEmail.Text = dataGridViewOsoba.Rows[rowIndex].Cells[6].Value.ToString();
            txtboxTelefon.Text = dataGridViewOsoba.Rows[rowIndex].Cells[7].Value.ToString();
            txtboxPTT4.Text = dataGridViewOsoba.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void buttonOcistiOsobu_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiOsobu_Click(object sender, EventArgs e)
        {
            if (Provera.proveraOsobe(txtboxJMBG.Text, "pr", "pr", "pr", "09.08.1923", "pr123", "pr123@gmail.com", "123", "123"))
            {
                //  1
                int jmbg = int.Parse(txtboxJMBG.Text);

                //  2
                bool success = databaseHelper.DeleteDataInOsoba(jmbg);
                if (success == true)
                {
                    MessageBox.Show("Osoba je uspešno obrisana.");

                    DataTable dt = databaseHelper.SelectDataFromOsoba();
                    dataGridViewOsoba.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja osobe! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaOsobe_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaOsobe.Text;

            DataTable dt = databaseHelper.SearchDataInOsoba(keyword);

            dataGridViewOsoba.DataSource = dt;
        }

        private void txtboxPretragaPTTgrada_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaPTTgrada.Text;

            DataTable dt = databaseHelper.SearchDataInGrad(keyword);

            dgvPretragaPTTgrada.DataSource = dt;
        }
    }
}
