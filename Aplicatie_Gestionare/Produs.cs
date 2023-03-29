using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produse
{

    class Produs
    {
        private int idProdus;
        private string titlu;
        private string artist;
        private string[] status = { "IN STOC", "INDISPONIBIL", "LA PRE-COMANDA" };
        private const char SEPARATOR_DE_FISIER = ';';

        // constructor implicit
        public Produs()
        {
            titlu = artist = string.Empty;
        }

        // constructor de initializare
        public Produs(int idProdus, string titlu, string artist)
        {
            this.idProdus = idProdus;
            this.titlu = titlu;
            this.artist = artist;
        }

        public void SetIdProdus(int idProdus)
        {
            this.idProdus = idProdus;
        }

        public void SetTitlu(string titlu)
        {
            this.titlu = titlu;
        }

        public void SetArtist(string artist)
        {
            this.artist = artist;
        }
        public int GetIdProdus()
        {
            return idProdus;
        }

        public string GetTitlu()
        {
            return titlu;
        }

        public string GetArtist()
        {
            return artist;
        }

        public void Valabilitate(string current_status)
        {
            foreach (string val in status)
            {
                if (current_status == val)
                    Console.WriteLine("Produsul este" + val);
            }
        }



    }
}
