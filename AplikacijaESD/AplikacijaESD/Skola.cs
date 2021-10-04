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
    public partial class Skola : Form
    {
        public Skola()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Skola_Load(object sender, EventArgs e)
        {
            DataTable dt1 = databaseHelper.SelectDataFromSkola();
            dataGridViewSkola.DataSource = dt1;

            DataTable dt2 = databaseHelper.SelectDataFromGrad();
            dgvPretragaPTTgrada.DataSource = dt2;
        }

        public void Clear()
        {
            txtboxIDSkole.Text = "";
            txtboxNazivSkole.Text = "";
            txtboxTipSkole.Text = "";
            txtboxNivoSkole.Text = "";
            txtboxPTT2.Text = "";
        }

        private void btnDodajSkolu_Click(object sender, EventArgs e)
        {
            if (Provera.proveraSkole(txtboxIDSkole.Text, txtboxNazivSkole.Text, txtboxTipSkole.Text, txtboxNivoSkole.Text, txtboxPTT2.Text)) {
                //  1
                int idSkole = int.Parse(txtboxIDSkole.Text);
                string nazivSkole = txtboxNazivSkole.Text;
                string tipSkole = txtboxTipSkole.Text;
                string nivoSkole = txtboxNivoSkole.Text;
                int ptt = int.Parse(txtboxPTT2.Text);

                //  2
                bool success = databaseHelper.InsertDataInSkola(idSkole, nazivSkole, tipSkole, nivoSkole, ptt);
                if (success == true)
                {
                    MessageBox.Show("Škola je uspešno dodata.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja škole! Pokušaj opet.");
                }

                //  3
                DataTable dt = databaseHelper.SelectDataFromSkola();
                dataGridViewSkola.DataSource = dt;
            }
        }

        private void btnAzurirajSkolu_Click(object sender, EventArgs e)
        {
            if (Provera.proveraSkole(txtboxIDSkole.Text, txtboxNazivSkole.Text, txtboxTipSkole.Text, txtboxNivoSkole.Text, txtboxPTT2.Text))
            {
                //  1
                int idSkole = int.Parse(txtboxIDSkole.Text);
                string nazivSkole = txtboxNazivSkole.Text;
                string tipSkole = txtboxTipSkole.Text;
                string nivoSkole = txtboxNivoSkole.Text;
                int ptt = int.Parse(txtboxPTT2.Text);

                //  2
                bool success = databaseHelper.UpdateDataInSkola(idSkole, nazivSkole, tipSkole, nivoSkole, ptt);
                if (success == true)
                {
                    MessageBox.Show("Škola je uspešno ažurirana.");

                    DataTable dt = databaseHelper.SelectDataFromSkola();
                    dataGridViewSkola.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja škole! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewSkola_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxIDSkole.Text = dataGridViewSkola.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxNazivSkole.Text = dataGridViewSkola.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxTipSkole.Text = dataGridViewSkola.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxNivoSkole.Text = dataGridViewSkola.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxPTT2.Text = dataGridViewSkola.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void buttonOcistiSkolu_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiSkolu_Click(object sender, EventArgs e)
        {
            if (Provera.proveraSkole(txtboxIDSkole.Text, "pr", "pr", "pr", "123"))
            {
                //  1
                int idSkole = int.Parse(txtboxIDSkole.Text);

                //  2
                bool success = databaseHelper.DeleteDataInSkola(idSkole);
                if (success == true)
                {
                    MessageBox.Show("Škola je uspešno obrisana.");

                    DataTable dt = databaseHelper.SelectDataFromSkola();
                    dataGridViewSkola.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja škole! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaSkole_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaSkole.Text;

            DataTable dt = databaseHelper.SearchDataInSkola(keyword);

            dataGridViewSkola.DataSource = dt;
        }

        private void txtboxPretragaPTTgrada_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaPTTgrada.Text;

            DataTable dt = databaseHelper.SearchDataInGrad(keyword);

            dgvPretragaPTTgrada.DataSource = dt;
        }
    }
}
