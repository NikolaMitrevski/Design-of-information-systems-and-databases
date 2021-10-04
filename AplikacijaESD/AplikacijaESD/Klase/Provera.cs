using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaESD.Klase
{
    class Provera
    {
        private static bool isStringOnlySlova(string str)
        {

            if (str != null && str.Length > 0)
            {
                string slova = " AaBbCcČčĆćDdĐđEeFfGgHhIiJjKkLlMmNnOoPpRrSsŠšTtUuVvZzŽžWwQqYy";
                //string[] str2 = str.Split();    // nisam siguran za Split()
                char[] str2 = str.ToCharArray();

                for (int i = 0; i < str2.Length; i++)
                {
                    if (!slova.Contains(str2[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        private static bool isStringOnlyBrojevi(string str)
        {
            if (str != null && str.Length > 0)
            {

                string brojevi = " 0123456789";
                //string[] str2 = str.Split();    // nisam siguran za Split()
                char[] str2 = str.ToCharArray();

                for (int i = 0; i < str2.Length; i++)
                {
                    if (!brojevi.Contains(str2[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        private static bool isStringOnlyBrojeviIslova(string str)
        {
            if (str != null && str.Length > 0)
            {

                string brojeviSlova = " 0123456789AaBbCcČčĆćDdĐđEeFfGgHhIiJjKkLlMmNnOoPpRrSsŠšTtUuVvZzŽžWwQqYy";
                //string[] str2 = str.Split();    // nisam siguran za Split()
                char[] str2 = str.ToCharArray();

                for (int i = 0; i < str2.Length; i++)
                {
                    if (!brojeviSlova.Contains(str2[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        private static bool proveraMaila(string str)
        {
            if (str != null && str.Length > 0)
            {
                bool state1 = false, state2 = false;
                string brojeviSlova = "0123456789AaBbCcČčĆćDdĐđEeFfGgHhIiJjKkLlMmNnOoPpRrSsŠšTtUuVvZzŽžWwQqYy@.";
                //string[] str2 = str.Split();    // nisam siguran za Split()
                char[] str2 = str.ToCharArray();

                for (int i = 0; i < str2.Length; i++)
                {
                    if (!brojeviSlova.Contains(str2[i]))
                    {
                        return false;
                    }
                    if (str2[i].Equals('@'))
                    {
                        state1 = true;
                    }
                    if (str2[i].Equals('.'))
                    {
                        state2 = true;
                    }
                }

                if (state1 && state2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool proveraGrada(string PTT, string nazivGrada, string nazivDrzave)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(PTT))
            {
                state = true;
                rezultat += "U polju 'PTT' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(nazivGrada))
            {
                state = true;
                rezultat += "U polju 'Naziv grada' unesi samo slova.\n";
            }
            if (!isStringOnlySlova(nazivDrzave))
            {
                state = true;
                rezultat += "U polju 'Naziv države' unesi samo slova.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }

        public static bool proveraNastavnika(string JMBG, string zvanje, string IDodeljenja)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(JMBG))
            {
                state = true;
                rezultat += "U polju 'JMBG nastavnika' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(zvanje))
            {
                state = true;
                rezultat += "U polju 'Zvanje' unesi samo slova.\n";
            }
            if (!isStringOnlyBrojevi(IDodeljenja))
            {
                state = true;
                rezultat += "U polju 'ID odeljenja' unesi samo brojeve.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }

        public static bool proveraOdeljenja(string IDodeljenja, string nazivOdeljenja, string razred, string idSKole)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(IDodeljenja))
            {
                state = true;
                rezultat += "U polju 'ID odeljenja' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(nazivOdeljenja))
            {
                state = true;
                rezultat += "U polju 'Naziv odeljenja' unesi samo slova.\n";
            }
            if (!isStringOnlyBrojevi(razred))
            {
                state = true;
                rezultat += "U polju 'Razred' unesi samo brojeve.\n";
            }
            if (!isStringOnlyBrojevi(idSKole))
            {
                state = true;
                rezultat += "U polju 'ID škole' unesi samo brojeve.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }

        public static bool proveraOsobe(string jmbg, string ime, string prezime, string pol, string datumRodjenja, string adresa, string email, string telefon, string ptt)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(jmbg))
            {
                state = true;
                rezultat += "U polju 'JMBG' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(ime))
            {
                state = true;
                rezultat += "U polju 'Ime' unesi samo slova.\n";
            }
            if (!isStringOnlySlova(prezime))
            {
                state = true;
                rezultat += "U polju 'Prezime' unesi samo slova.\n";
            }
            if (!isStringOnlySlova(pol))
            {
                state = true;
                rezultat += "U polju 'Pol' unesi samo slova.\n";
            }
            DateTime dateValue;
            if (!DateTime.TryParseExact(datumRodjenja, "dd.MM.yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
            {
                state = true;
                rezultat += "Polje 'Datum rodjenja' mora biti sledećeg formata: 'dd.MM.yyyy'.\n";
            }
            if (!isStringOnlyBrojeviIslova(adresa))
            {
                state = true;
                rezultat += "U polju 'Adresa' unesi samo brojeve i slova.\n";
            }
            if (!proveraMaila(email))
            {
                state = true;
                rezultat += "U polju 'Email' unesi samo brojeve, slova, '@' i '.'. Struktura emaila, mora da sadrži '@' i '.'.\n";
            }
            if (!isStringOnlyBrojevi(telefon))
            {
                state = true;
                rezultat += "U polju 'Telefon' unesi samo brojeve.\n";
            }
            if (!isStringOnlyBrojevi(ptt))
            {
                state = true;
                rezultat += "U polju 'PTT' unesi samo brojeve.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }

        public static bool proveraSkole(string idSkole, string nazivSkole, string tipSkole, string nivoSkole, string ptt)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(idSkole))
            {
                state = true;
                rezultat += "U polju 'ID škole' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(nazivSkole))
            {
                state = true;
                rezultat += "U polju 'Naziv škole' unesi samo slova.\n";
            }
            if (!isStringOnlySlova(tipSkole))
            {
                state = true;
                rezultat += "U polju 'Tip škole' unesi samo slova.\n";
            }
            if (!isStringOnlySlova(nivoSkole))
            {
                state = true;
                rezultat += "U polju 'Nivo škole' unesi samo slova.\n";
            }
            if (!isStringOnlyBrojevi(ptt))
            {
                state = true;
                rezultat += "U polju 'PTT' unesi samo brojeve.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }

        public static bool proveraSmera(string idSmera, string nazivSmera, string idSkole)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(idSmera))
            {
                state = true;
                rezultat += "U polju 'ID smera' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(nazivSmera))
            {
                state = true;
                rezultat += "U polju 'Naziv smera' unesi samo slova.\n";
            }
            if (!isStringOnlyBrojevi(idSkole))
            {
                state = true;
                rezultat += "U polju 'ID škole' unesi samo brojeve.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }


        public static bool proveraUcenika(string jmbgUcenika, string idVladanja, string idOdeljenja, string idSmera)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(jmbgUcenika))
            {
                state = true;
                rezultat += "U polju 'JMBG učenika' unesi samo brojeve.\n";
            }
            if (!isStringOnlyBrojevi(idVladanja))
            {
                state = true;
                rezultat += "U polju 'ID vladanja' unesi samo brojeve.\n";
            }
            if (!isStringOnlyBrojevi(idOdeljenja))
            {
                state = true;
                rezultat += "U polju 'ID odeljenja' unesi samo brojeve.\n";
            }
            if (!isStringOnlyBrojevi(idSmera))
            {
                state = true;
                rezultat += "U polju 'ID smera' unesi samo brojeve.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }

        public static bool proveraVladanja(string idVladanja, string ocenaVladanja, string opisVladanja)
        {
            string rezultat = "Greška!\n";
            bool state = false;

            if (!isStringOnlyBrojevi(idVladanja))
            {
                state = true;
                rezultat += "U polju 'ID vladanja' unesi samo brojeve.\n";
            }
            if (!isStringOnlyBrojevi(ocenaVladanja))
            {
                state = true;
                rezultat += "U polju 'Ocena vladanja' unesi samo brojeve.\n";
            }
            if (!isStringOnlySlova(opisVladanja))
            {
                state = true;
                rezultat += "U polju 'Opis vladanja' unesi samo slova.\n";
            }

            if (state)
            {
                MessageBox.Show(rezultat);
                return false;
            }

            return true;
        }


    }
}
