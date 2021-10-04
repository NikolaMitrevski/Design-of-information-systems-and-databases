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
    public partial class Smer : Form
    {
        public Smer()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Smer_Load(object sender, EventArgs e)
        {
            DataTable dt1 = databaseHelper.SelectDataFromSmer();
            dataGridViewSmer.DataSource = dt1;

            DataTable dt2 = databaseHelper.SelectDataFromSkola();
            dgvPretragaIDskole.DataSource = dt2;
        }

        public void Clear()
        {
            txtboxIDSmera.Text = "";
            txtboxNazivSmera.Text = "";
            txtboxIDSkole2.Text = "";
        }

        private void btnDodajSmer_Click(object sender, EventArgs e)
        {
            if (Provera.proveraSmera(txtboxIDSmera.Text, txtboxNazivSmera.Text, txtboxIDSkole2.Text)) {
                //  1
                int idSmera = int.Parse(txtboxIDSmera.Text);
                string nazivSmera = txtboxNazivSmera.Text; 
                int idSkole = int.Parse(txtboxIDSkole2.Text);

                //  2
                bool success = databaseHelper.InsertDataInSmer(idSmera, nazivSmera, idSkole);
                if (success == true)
                {
                    MessageBox.Show("Smer je uspešno dodat.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja smera! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromSmer();
                dataGridViewSmer.DataSource = dt;
            }
        }

        private void btnAzurirajSmer_Click(object sender, EventArgs e)
        {
            if (Provera.proveraSmera(txtboxIDSmera.Text, txtboxNazivSmera.Text, txtboxIDSkole2.Text))
            {
                //  1
                int idSmera = int.Parse(txtboxIDSmera.Text);
                string nazivSmera = txtboxNazivSmera.Text;
                int idSkole = int.Parse(txtboxIDSkole2.Text);

                //  2
                bool success = databaseHelper.UpdateDataInSmer(idSmera, nazivSmera, idSkole);
                if (success == true)
                {
                    MessageBox.Show("Smer je uspešno ažuriran.");

                    DataTable dt = databaseHelper.SelectDataFromSmer();
                    dataGridViewSmer.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja smera! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewSmer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxIDSmera.Text = dataGridViewSmer.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxNazivSmera.Text = dataGridViewSmer.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxIDSkole2.Text = dataGridViewSmer.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void buttonOcistiSmer_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiSmer_Click(object sender, EventArgs e)
        {
            if (Provera.proveraSmera(txtboxIDSmera.Text, "pr", "123"))
            {
                //  1
                int idSmera = int.Parse(txtboxIDSmera.Text);

                //  2
                bool success = databaseHelper.DeleteDataInSmer(idSmera);
                if (success == true)
                {
                    MessageBox.Show("Smer je uspešno obrisan.");

                    DataTable dt = databaseHelper.SelectDataFromSmer();
                    dataGridViewSmer.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja smera! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaSmera_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaSmera.Text;

            DataTable dt = databaseHelper.SearchDataInSmer(keyword);

            dataGridViewSmer.DataSource = dt;
        }

        private void txtboxPretragaIDskole_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaIDskole.Text;

            DataTable dt = databaseHelper.SearchDataInSkola(keyword);

            dgvPretragaIDskole.DataSource = dt;
        }
    }
}
