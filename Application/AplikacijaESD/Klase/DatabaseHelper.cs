using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaESD.Klase
{
    class DatabaseHelper
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // Selecting data from database
        public DataTable SelectDataFromGrad()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Grad";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromNastavnik()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Nastavnik";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromOdeljenje()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Odeljenje";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromOsoba()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Osoba";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromSkola()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Skola";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromSmer()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Smer";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromUcenik()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Ucenik";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable SelectDataFromVladanje()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Vladanje";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // Inserting data into database
        public bool InsertDataInGrad(int ptt, string nazivGrada, string nazivDrzave)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Grad (ptt, nazivGrada, nazivDrzave) VALUES (@ptt, @nazivGrada, @nazivDrzave)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ptt", ptt);
                cmd.Parameters.AddWithValue("@nazivGrada", nazivGrada);
                cmd.Parameters.AddWithValue("@nazivDrzave", nazivDrzave);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInNastavnik(int jmbgNastavnika, string zvanje, int idOdeljenja)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Nastavnik (jmbgNastavnika, zvanje, idOdeljenja) VALUES (@jmbgNastavnika, @zvanje, @idOdeljenja)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbgNastavnika", jmbgNastavnika);
                cmd.Parameters.AddWithValue("@zvanje", zvanje);
                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInOdeljenje(int idOdeljenja, string nazivOdeljenja, int razred, int idSkole)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Odeljenje (idOdeljenja, nazivOdeljenja, razred, idSkole) VALUES (@idOdeljenja, @nazivOdeljenja, @razred, @idSkole)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);
                cmd.Parameters.AddWithValue("@nazivOdeljenja", nazivOdeljenja);
                cmd.Parameters.AddWithValue("@razred", razred);
                cmd.Parameters.AddWithValue("@idSkole", idSkole);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInOsoba(int jmbg, string ime, string prezime, string pol, DateTime datumRodjenja, string adresa, string email, long telefon, int ptt)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Osoba (jmbg, ime, prezime, pol, datumRodjenja, adresa, email, telefon, ptt) VALUES (@jmbg, @ime, @prezime, @pol, @datumRodjenja, @adresa, @email, @telefon, @ptt)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbg", jmbg);
                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@pol", pol);
                cmd.Parameters.AddWithValue("@datumRodjenja", datumRodjenja);
                cmd.Parameters.AddWithValue("@adresa", adresa);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@ptt", ptt);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInSkola(int idSkole, string nazivSkole, string tipSkole, string nivoSkole, int ptt)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Skola (idSkole, nazivSkole, tipSkole, nivoSkole, ptt) VALUES (@idSkole, @nazivSkole, @tipSkole, @nivoSkole, @ptt)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idSkole", idSkole);
                cmd.Parameters.AddWithValue("@nazivSkole", nazivSkole);
                cmd.Parameters.AddWithValue("@tipSkole", tipSkole);
                cmd.Parameters.AddWithValue("@nivoSkole", nivoSkole);
                cmd.Parameters.AddWithValue("@ptt", ptt);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInSmer(int idSmera, string nazivSmera, int idSkole)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Smer (idSmera, nazivSmera, idSkole) VALUES (@idSmera, @nazivSmera, @idSkole)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idSmera", idSmera);
                cmd.Parameters.AddWithValue("@nazivSmera", nazivSmera);
                cmd.Parameters.AddWithValue("@idSkole", idSkole);
                
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInUcenik(int jmbgUcenika, int idVladanja, int idOdeljenja, int idSmera)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Ucenik (jmbgUcenika, idVladanja, idOdeljenja, idSmera) VALUES (@jmbgUcenika, @idVladanja, @idOdeljenja, @idSmera)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbgUcenika", jmbgUcenika);
                cmd.Parameters.AddWithValue("@idVladanja", idVladanja);
                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);
                cmd.Parameters.AddWithValue("@idSmera", idSmera);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool InsertDataInVladanje(int idVladanja, int ocenaVladanja, string opisVladanja)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Vladanje (idVladanja, ocenaVladanja, opisVladanja) VALUES (@idVladanja, @ocenaVladanja, @opisVladanja)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idVladanja", idVladanja);
                cmd.Parameters.AddWithValue("@ocenaVladanja", ocenaVladanja);
                cmd.Parameters.AddWithValue("@opisVladanja", opisVladanja);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // Updating data into database
        public bool UpdateDataInGrad(int ptt, string nazivGrada, string nazivDrzave)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Grad SET ptt = @ptt, nazivGrada = @nazivGrada, nazivDrzave = @nazivDrzave WHERE ptt = @ptt";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ptt", ptt);
                cmd.Parameters.AddWithValue("@nazivGrada", nazivGrada);
                cmd.Parameters.AddWithValue("@nazivDrzave", nazivDrzave);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInNastavnik(int jmbgNastavnika, string zvanje, int idOdeljenja)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Nastavnik SET jmbgNastavnika = @jmbgNastavnika, zvanje = @zvanje, idOdeljenja = @idOdeljenja WHERE jmbgNastavnika = @jmbgNastavnika";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbgNastavnika", jmbgNastavnika);
                cmd.Parameters.AddWithValue("@zvanje", zvanje);
                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInOdeljenje(int idOdeljenja, string nazivOdeljenja, int razred, int idSkole)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Odeljenje SET idOdeljenja = @idOdeljenja, nazivOdeljenja = @nazivOdeljenja, razred = @razred, idSkole =@idSkole WHERE idOdeljenja = @idOdeljenja";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);
                cmd.Parameters.AddWithValue("@nazivOdeljenja", nazivOdeljenja);
                cmd.Parameters.AddWithValue("@razred", razred);
                cmd.Parameters.AddWithValue("@idSkole", idSkole);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInOsoba(int jmbg, string ime, string prezime, string pol, DateTime datumRodjenja, string adresa, string email, long telefon, int ptt)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Osoba SET jmbg = @jmbg, ime = @ime, prezime = @prezime, pol = @pol, datumRodjenja = @datumRodjenja, adresa = @adresa, email = @email, telefon = @telefon, ptt = @ptt WHERE jmbg = @jmbg";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbg", jmbg);
                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@pol", pol);
                cmd.Parameters.AddWithValue("@datumRodjenja", datumRodjenja);
                cmd.Parameters.AddWithValue("@adresa", adresa);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@ptt", ptt);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInSkola(int idSkole, string nazivSkole, string tipSkole, string nivoSkole, int ptt)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Skola SET idSkole = @idSkole, nazivSkole = @nazivSkole, tipSkole = @tipSkole, nivoSkole = @nivoSkole, ptt = @ptt WHERE idSkole = @idSkole";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idSkole", idSkole);
                cmd.Parameters.AddWithValue("@nazivSkole", nazivSkole);
                cmd.Parameters.AddWithValue("@tipSkole", tipSkole);
                cmd.Parameters.AddWithValue("@nivoSkole", nivoSkole);
                cmd.Parameters.AddWithValue("@ptt", ptt);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInSmer(int idSmera, string nazivSmera, int idSkole)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Smer SET idSmera = @idSmera, nazivSmera = @nazivSmera, idSkole = @idSkole WHERE idSmera = @idSmera";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idSmera", idSmera);
                cmd.Parameters.AddWithValue("@nazivSmera", nazivSmera);
                cmd.Parameters.AddWithValue("@idSkole", idSkole);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInUcenik(int jmbgUcenika, int idVladanja, int idOdeljenja, int idSmera)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Ucenik SET jmbgUcenika = @jmbgUcenika, idVladanja = @idVladanja, idOdeljenja = @idOdeljenja, idSmera = @idSmera WHERE jmbgUcenika = @jmbgUcenika";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbgUcenika", jmbgUcenika);
                cmd.Parameters.AddWithValue("@idVladanja", idVladanja);
                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);
                cmd.Parameters.AddWithValue("@idSmera", idSmera);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool UpdateDataInVladanje(int idVladanja, int ocenaVladanja, string opisVladanja)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Vladanje SET idVladanja = @idVladanja, ocenaVladanja = @ocenaVladanja, opisVladanja = @opisVladanja WHERE idVladanja = @idVladanja";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idVladanja", idVladanja);
                cmd.Parameters.AddWithValue("@ocenaVladanja", ocenaVladanja);
                cmd.Parameters.AddWithValue("@opisVladanja", opisVladanja);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // Deleting data into database
        public bool DeleteDataInGrad(int ptt)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Grad WHERE ptt = @ptt";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ptt", ptt);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInNastavnik(int jmbgNastavnika)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Nastavnik WHERE jmbgNastavnika = @jmbgNastavnika";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbgNastavnika", jmbgNastavnika);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInOdeljenje(int idOdeljenja)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Odeljenje WHERE idOdeljenja = @idOdeljenja";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idOdeljenja", idOdeljenja);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInOsoba(int jmbg)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Osoba WHERE jmbg = @jmbg";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbg", jmbg);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInSkola(int idSkole)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Skola WHERE idSkole = @idSkole";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idSkole", idSkole);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInSmer(int idSmera)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Smer WHERE idSmera = @idSmera";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idSmera", idSmera);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInUcenik(int jmbgUcenika)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Ucenik WHERE jmbgUcenika = @jmbgUcenika";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@jmbgUcenika", jmbgUcenika);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool DeleteDataInVladanje(int idVladanja)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Vladanje WHERE idVladanja = @idVladanja";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idVladanja", idVladanja);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // Searching data into database
        public DataTable SearchDataInGrad(string ptt)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Grad WHERE ptt LIKE '%" + ptt + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }
        
        public DataTable SearchDataInNastavnik(string jmbgNastavnika)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Nastavnik WHERE jmbgNastavnika LIKE '%" + jmbgNastavnika + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        public DataTable SearchDataInOdeljenje(string idOdeljenja)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Odeljenje WHERE idOdeljenja LIKE '%" + idOdeljenja + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        public DataTable SearchDataInOsoba(string jmbg)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Osoba WHERE jmbg LIKE '%" + jmbg + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        public DataTable SearchDataInSkola(string idSkole)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Skola WHERE idSkole LIKE '%" + idSkole + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        public DataTable SearchDataInSmer(string idSmera)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Smer WHERE idSmera LIKE '%" + idSmera + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        public DataTable SearchDataInUcenik(string jmbgUcenika)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Ucenik WHERE jmbgUcenika LIKE '%" + jmbgUcenika + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        public DataTable SearchDataInVladanje(string idVladanja)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vladanje WHERE idVladanja LIKE '%" + idVladanja + "%'", conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }

        
    }
}
