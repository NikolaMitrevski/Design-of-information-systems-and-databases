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
    public partial class Odeljenje : Form
    {
        public Odeljenje()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Odeljenje_Load(object sender, EventArgs e)
        {
            DataTable dt1 = databaseHelper.SelectDataFromOdeljenje();
            dataGridViewOdeljenje.DataSource = dt1;

            DataTable dt2 = databaseHelper.SelectDataFromSkola();
            dgvPretragaIDskole.DataSource = dt2;
        }

        public void Clear()
        {
            txtboxIDOdeljenja.Text = "";
            txtboxNazivOdeljenja.Text = "";
            txtboxRazred.Text = "";
            txtboxIDSkole3.Text = "";
        }

        private void btnDodajOdeljenje_Click(object sender, EventArgs e)
        {
            if (Provera.proveraOdeljenja(txtboxIDOdeljenja.Text, txtboxNazivOdeljenja.Text, txtboxRazred.Text, txtboxIDSkole3.Text))
            {
                //  1
                int idOdeljenja = int.Parse(txtboxIDOdeljenja.Text);
                string nazivOdeljenja = txtboxNazivOdeljenja.Text;
                int razred = int.Parse(txtboxRazred.Text);
                int idSkole = int.Parse(txtboxIDSkole3.Text);

                //  2
                bool success = databaseHelper.InsertDataInOdeljenje(idOdeljenja, nazivOdeljenja, razred, idSkole);
                if (success == true)
                {
                    MessageBox.Show("Odeljenje je uspešno dodat.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja odeljenja! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromOdeljenje();
                dataGridViewOdeljenje.DataSource = dt;
            }
        }

        private void btnAzurirajOdeljenje_Click(object sender, EventArgs e)
        {
            if (Provera.proveraOdeljenja(txtboxIDOdeljenja.Text, txtboxNazivOdeljenja.Text, txtboxRazred.Text, txtboxIDSkole3.Text))
            {
                //  1
                int idOdeljenja = int.Parse(txtboxIDOdeljenja.Text);
                string nazivOdeljenja = txtboxNazivOdeljenja.Text;
                int razred = int.Parse(txtboxRazred.Text);
                int idSkole = int.Parse(txtboxIDSkole3.Text);

                //  2
                bool success = databaseHelper.UpdateDataInOdeljenje(idOdeljenja, nazivOdeljenja, razred, idSkole);
                if (success == true)
                {
                    MessageBox.Show("Odeljenje je uspešno ažurirano.");

                    DataTable dt = databaseHelper.SelectDataFromOdeljenje();
                    dataGridViewOdeljenje.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja odeljenja! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewOdeljenje_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxIDOdeljenja.Text = dataGridViewOdeljenje.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxNazivOdeljenja.Text = dataGridViewOdeljenje.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxRazred.Text = dataGridViewOdeljenje.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxIDSkole3.Text = dataGridViewOdeljenje.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void buttonOcistiOdeljenje_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiOdeljenje_Click(object sender, EventArgs e)
        {
            if (Provera.proveraOdeljenja(txtboxIDOdeljenja.Text, "pr", "123", "123"))
            {
                //  1
                int idOdeljenja = int.Parse(txtboxIDOdeljenja.Text);

                //  2
                bool success = databaseHelper.DeleteDataInOdeljenje(idOdeljenja);
                if (success == true)
                {
                    MessageBox.Show("Odeljenje je uspešno obrisano.");

                    DataTable dt = databaseHelper.SelectDataFromOdeljenje();
                    dataGridViewOdeljenje.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja odeljenja! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaOdeljenja_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaOdeljenja.Text;

            DataTable dt = databaseHelper.SearchDataInOdeljenje(keyword);

            dataGridViewOdeljenje.DataSource = dt;
        }

        private void txtboxPretragaIDskole_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaIDskole.Text;

            DataTable dt = databaseHelper.SearchDataInSkola(keyword);

            dgvPretragaIDskole.DataSource = dt;
        }
    }
}
