using AplikacijaESD.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaESD
{
    public partial class Grad : Form
    {
        public Grad()
        {
            InitializeComponent();
        }

        private void pictureBoxNazad3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxIzlaz3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////
        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void Grad_Load(object sender, EventArgs e)
        {
            DataTable dt = databaseHelper.SelectDataFromGrad();
            dataGridViewGrad.DataSource = dt;
        }

        public void Clear()
        {
            txtboxPTT.Text = "";
            txtboxNazivGrada.Text = "";
            txtboxNazivDrzave.Text = "";
        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {
            if (Provera.proveraGrada(txtboxPTT.Text, txtboxNazivGrada.Text, txtboxNazivDrzave.Text))
            {
                //  1
                int ptt = int.Parse(txtboxPTT.Text);
                string nazivGrada = txtboxNazivGrada.Text;
                string nazivDrzave = txtboxNazivDrzave.Text;

                //  2
                bool success = databaseHelper.InsertDataInGrad(ptt, nazivGrada, nazivDrzave);
                if (success == true)
                {
                    MessageBox.Show("Grad je uspešno dodat.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja grada! Pokušaj opet.");
                }

                // 3
                DataTable dt = databaseHelper.SelectDataFromGrad();
                dataGridViewGrad.DataSource = dt;
            }
        }

        private void btnAzurirajGrad_Click(object sender, EventArgs e)
        {
            if (Provera.proveraGrada(txtboxPTT.Text, txtboxNazivGrada.Text, txtboxNazivDrzave.Text))
            {
                //  1
                int ptt = int.Parse(txtboxPTT.Text);
                string nazivGrada = txtboxNazivGrada.Text;
                string nazivDrzave = txtboxNazivDrzave.Text;

                //  2
                bool success = databaseHelper.UpdateDataInGrad(ptt, nazivGrada, nazivDrzave);
                if (success == true)
                {
                    MessageBox.Show("Grad je uspešno ažuriran.");

                    DataTable dt = databaseHelper.SelectDataFromGrad();
                    dataGridViewGrad.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom ažuriranja grada! Pokušaj opet.");
                }
            }
        }
        //  3
        private void dataGridViewGrad_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxPTT.Text = dataGridViewGrad.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxNazivGrada.Text = dataGridViewGrad.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxNazivDrzave.Text = dataGridViewGrad.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void buttonOcistiGrad_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnObrisiGrad_Click(object sender, EventArgs e)
        {
            if (Provera.proveraGrada(txtboxPTT.Text, "pr", "pr"))
            {
                //  1
                int ptt = int.Parse(txtboxPTT.Text);

                //  2
                bool success = databaseHelper.DeleteDataInGrad(ptt);
                if (success == true)
                {
                    MessageBox.Show("Grad je uspešno obrisan.");

                    DataTable dt = databaseHelper.SelectDataFromGrad();
                    dataGridViewGrad.DataSource = dt;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja grada! Pokušaj opet.");
                }
            }
        }

        private void txtboxPretragaGrada_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxPretragaGrada.Text;

            DataTable dt = databaseHelper.SearchDataInGrad(keyword);

            dataGridViewGrad.DataSource = dt;
        }

        
    }
}
