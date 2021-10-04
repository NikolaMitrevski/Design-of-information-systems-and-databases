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
    public partial class Ucenik : Form
    {
        public Ucenik()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Ucenik_Load(object sender, EventArgs e)
        {
            DataTable dt1 = databaseHelper.SelectDataFromUcenik();
            dataGridViewUcenik.DataSource = dt1;

            DataTable dt2 = databaseHelper.SelectDataFromOsoba();
            dgvPretragaJMBGosobe.DataSource = dt2;

            DataTable dt3 = databaseHelper.SelectDataFromVladanje();
            dgvPretragaIDvladanja.DataSource = dt3;

            DataTable dt4 = databaseHelper.SelectDataFromOdeljenje();
            dgvPretragaIDodeljenja.DataSource = dt4;

            DataTable dt5 = databaseHelper.SelectDataFromSmer();
            dgvPretragaIDsmera.DataSource = dt5;
        }

        public void Clear()
        {
            txtboxJMBGUcenika.Text = "";
            txtboxIDVladanja2.Text = "";
            txtboxIDOdeljenja22.Text = "";
            txtboxIDSmera22.Text = "";
        }

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            if (Provera.proveraUcenika(txtboxJMBGUcenika.Text, txtboxIDVladanja2.Text, txtboxIDOdeljenja22.Text, txtboxIDSmera22.Text)) {
                //  1
                int jmbgUcenika = int.Parse(txtboxJMBGUcenika.Text);
                int idVladanja = int.Parse(txtboxIDVladanja2.Text);
                int idOdeljenja = int.Parse(txtboxIDOdeljenja22.Text);
                int idSmera = int.Parse(txtboxIDSmera22.Text);

                //  2
                bool success = databaseHelper.InsertDataInUcenik(jmbgUcenika, idVladanja, idOdeljenja, idSmera);
                if (success == true)
                {
                    MessageBox.Show("Učenik je uspešno dodat.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja učenika! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromUcenik();
                dataGridViewUcenik.DataSource = dt;
            }
        }

        private void btnAzurirajUcenika_Click(object sender, EventArgs e)
        {
            if (Provera.proveraUcenika(txtboxJMBGUcenika.Text, txtboxIDVladanja2.Text, txtboxIDOdeljenja22.Text, txtboxIDSmera22.Text))
            {
                //  1
                int jmbgUcenika = int.Parse(txtboxJMBGUcenika.Text);
                int idVladanja = int.Parse(txtboxIDVladanja2.Text);
                int idOdeljenja = int.Parse(txtboxIDOdeljenja22.Text);
                int idSmera = int.Parse(txtboxIDSmera22.Text);

                //  2
                bool success = databaseHelper.UpdateDataInUcenik(jmbgUcenika, idVladanja, idOdeljenja, idSmera);
                if (success == true)
                {
                    MessageBox.Show("Učenik je uspešno ažuriran.");

                    DataTable dt = databaseHelper.SelectDataFromUcenik();
                    dataGridViewUcenik.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja učenika! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewUcenik_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxJMBGUcenika.Text = dataGridViewUcenik.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxIDVladanja2.Text = dataGridViewUcenik.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxIDOdeljenja22.Text = dataGridViewUcenik.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxIDSmera22.Text = dataGridViewUcenik.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void buttonOcistiUcenika_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiUcenika_Click(object sender, EventArgs e)
        {
            if (Provera.proveraUcenika(txtboxJMBGUcenika.Text, "123", "123", "123"))
            {
                //  1
                int jmbgUcenika = int.Parse(txtboxJMBGUcenika.Text);

                //  2
                bool success = databaseHelper.DeleteDataInUcenik(jmbgUcenika);
                if (success == true)
                {
                    MessageBox.Show("Učenik je uspešno obrisan.");

                    DataTable dt = databaseHelper.SelectDataFromUcenik();
                    dataGridViewUcenik.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja učenika! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaUcenika_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaUcenika.Text;

            DataTable dt = databaseHelper.SearchDataInUcenik(keyword);

            dataGridViewUcenik.DataSource = dt;
        }

        private void txtBoxPretragaJMBGosobe_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxPretragaJMBGosobe.Text;

            DataTable dt = databaseHelper.SearchDataInOsoba(keyword);

            dgvPretragaJMBGosobe.DataSource = dt;
        }

        private void txtboxPretragaIDvladanja_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaIDvladanja.Text;

            DataTable dt = databaseHelper.SearchDataInVladanje(keyword);

            dgvPretragaIDvladanja.DataSource = dt;
        }

        private void txtboxPretragaIDodeljenja_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaIDodeljenja.Text;

            DataTable dt = databaseHelper.SearchDataInOdeljenje(keyword);

            dgvPretragaIDodeljenja.DataSource = dt;
        }

        private void txtboxPretragaIDsmera_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaIDsmera.Text;

            DataTable dt = databaseHelper.SearchDataInSmer(keyword);

            dgvPretragaIDsmera.DataSource = dt;
        }
    }
}
