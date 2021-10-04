using AplikacijaESD.Klase;
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
    public partial class Nastavnik : Form
    {
        public Nastavnik()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Nastavnik_Load(object sender, EventArgs e)
        {
            DataTable dt1 = databaseHelper.SelectDataFromNastavnik();
            dataGridViewNastavnik.DataSource = dt1;

            DataTable dt2 = databaseHelper.SelectDataFromOsoba();
            dgvPretragaJMBGosobe.DataSource = dt2;

            DataTable dt3 = databaseHelper.SelectDataFromOdeljenje();
            dgvPretragaIDodeljenja.DataSource = dt3;
        }

        public void Clear()
        {
            txtboxJMBGNastavnika.Text = "";
            txtboxZvanje.Text = "";
            txtboxIDOdeljenja23.Text = "";
        }

        private void btnDodajNastavnika_Click(object sender, EventArgs e)
        {
            if (Provera.proveraNastavnika(txtboxJMBGNastavnika.Text, txtboxZvanje.Text, txtboxIDOdeljenja23.Text))
            {
                //  1
                int jmbgNastavnika = int.Parse(txtboxJMBGNastavnika.Text);
                string zvanje = txtboxZvanje.Text;
                int idOdeljenja = int.Parse(txtboxIDOdeljenja23.Text);

                //  2
                bool success = databaseHelper.InsertDataInNastavnik(jmbgNastavnika, zvanje, idOdeljenja);
                if (success == true)
                {
                    MessageBox.Show("Nastavnik je uspešno dodat.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja nastavnika! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromNastavnik();
                dataGridViewNastavnik.DataSource = dt;
            }
        }

        private void btnAzurirajNastavnika_Click(object sender, EventArgs e)
        {
            if (Provera.proveraNastavnika(txtboxJMBGNastavnika.Text, txtboxZvanje.Text, txtboxIDOdeljenja23.Text))
            {
                //  1
                int jmbgNastavnika = int.Parse(txtboxJMBGNastavnika.Text);
                string zvanje = txtboxZvanje.Text;
                int idOdeljenja = int.Parse(txtboxIDOdeljenja23.Text);

                //  2
                bool success = databaseHelper.UpdateDataInNastavnik(jmbgNastavnika, zvanje, idOdeljenja);
                if (success == true)
                {
                    MessageBox.Show("Nastavnik je uspešno ažuriran.");

                    DataTable dt = databaseHelper.SelectDataFromNastavnik();
                    dataGridViewNastavnik.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja nastavnika! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewNastavnik_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxJMBGNastavnika.Text = dataGridViewNastavnik.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxZvanje.Text = dataGridViewNastavnik.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxIDOdeljenja23.Text = dataGridViewNastavnik.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void buttonOcistiNastavnika_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiNastavnika_Click(object sender, EventArgs e)
        {
            if (Provera.proveraNastavnika(txtboxJMBGNastavnika.Text, "pr", "123"))
            {
                //  1
                int jmbgNastavnika = int.Parse(txtboxJMBGNastavnika.Text);


                //  2
                bool success = databaseHelper.DeleteDataInNastavnik(jmbgNastavnika);
                if (success == true)
                {
                    MessageBox.Show("Nastavnik je uspešno obrisan.");

                    DataTable dt = databaseHelper.SelectDataFromNastavnik();
                    dataGridViewNastavnik.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja nastavnika! Pokušaj opet.");
                }
            }
        }

        
        private void txtboxPretragaNastavnika_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaNastavnika.Text;

            DataTable dt = databaseHelper.SearchDataInNastavnik(keyword);

            dataGridViewNastavnik.DataSource = dt;
        }

        private void txtboxPretragaJMBGosobe_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaJMBGosobe.Text;

            DataTable dt = databaseHelper.SearchDataInOsoba(keyword);

            dgvPretragaJMBGosobe.DataSource = dt;
        }

        private void txtboxPretragaIDodeljenja_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaIDodeljenja.Text;

            DataTable dt = databaseHelper.SearchDataInOdeljenje(keyword);

            dgvPretragaIDodeljenja.DataSource = dt;
        }
    }
}
