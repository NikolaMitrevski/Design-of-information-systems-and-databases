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
    public partial class Vladanje : Form
    {
        public Vladanje()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Vladanje_Load(object sender, EventArgs e)
        {
            DataTable dt = databaseHelper.SelectDataFromVladanje();
            dataGridViewVladanje.DataSource = dt;
        }

        public void Clear()
        {
            txtboxIDVladanja.Text = "";
            txtboxOcenaVladanja.Text = "";
            txtboxOpisVladanja.Text = "";
        }

        private void btnDodajVladanje_Click(object sender, EventArgs e)
        {
            if (Provera.proveraVladanja(txtboxIDVladanja.Text, txtboxOcenaVladanja.Text, txtboxOpisVladanja.Text)) {
                //  1
                int idVladanja = int.Parse(txtboxIDVladanja.Text);
                int ocenaVladanja = int.Parse(txtboxOcenaVladanja.Text);
                string opisVladanja = txtboxOpisVladanja.Text;

                //  2
                bool success = databaseHelper.InsertDataInVladanje(idVladanja, ocenaVladanja, opisVladanja);
                if (success == true)
                {
                    MessageBox.Show("Vladanje je uspešno dodato.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja vladanja! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromVladanje();
                dataGridViewVladanje.DataSource = dt;
            }
        }

        private void btnAzurirajVladanje_Click(object sender, EventArgs e)
        {
            if (Provera.proveraVladanja(txtboxIDVladanja.Text, txtboxOcenaVladanja.Text, txtboxOpisVladanja.Text))
            {
                //  1
                int idVladanja = int.Parse(txtboxIDVladanja.Text);
                int ocenaVladanja = int.Parse(txtboxOcenaVladanja.Text);
                string opisVladanja = txtboxOpisVladanja.Text;

                //  2
                bool success = databaseHelper.UpdateDataInVladanje(idVladanja, ocenaVladanja, opisVladanja);
                if (success == true)
                {
                    MessageBox.Show("Vladanje je uspešno ažurirano.");

                    DataTable dt = databaseHelper.SelectDataFromVladanje();
                    dataGridViewVladanje.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja vladanja! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewVladanje_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxIDVladanja.Text = dataGridViewVladanje.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxOcenaVladanja.Text = dataGridViewVladanje.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxOpisVladanja.Text = dataGridViewVladanje.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void buttonOcistiVladanje_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiVladanje_Click(object sender, EventArgs e)
        {
            if (Provera.proveraVladanja(txtboxIDVladanja.Text, "1", "pr"))
            {
                //  1
                int idVladanja = int.Parse(txtboxIDVladanja.Text);

                //  2
                bool success = databaseHelper.DeleteDataInVladanje(idVladanja);
                if (success == true)
                {
                    MessageBox.Show("Vladanje je uspešno obrisan.");

                    DataTable dt = databaseHelper.SelectDataFromVladanje();
                    dataGridViewVladanje.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja vladanja! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaVladanja_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaVladanja.Text;

            DataTable dt = databaseHelper.SearchDataInVladanje(keyword);

            dataGridViewVladanje.DataSource = dt;
        }
    }
}
