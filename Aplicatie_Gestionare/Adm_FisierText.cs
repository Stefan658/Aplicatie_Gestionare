using Produse;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Aplicatie_Gestionare;
using Produse;


namespace Aplicatie_Gestionare
{
     class Adm_FisierText 
    {
        Produs p1 = new Produs();
            private string numeFisier;

            void FisierText(string numeFisier)
            {
                this.numeFisier = numeFisier;
                Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
                streamFisierText.Close();
            }
            string ConversieSirFisier()
            {
                string obiectProdus = string.Format("{1}{0}{2}{0}{3}{0}", ";", p1.GetIdProdus().ToString(),
                    (p1.GetTitlu() ?? " NECUNOSCUT "),
                    (p1.GetArtist() ?? " NECUNOSCUT "));

                return obiectProdus;
            }


            void AddProdusLaFisier(Produs prod)
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    streamWriterFisierText.WriteLine(ConversieSirFisier());
                }
            }

        

    }
}

