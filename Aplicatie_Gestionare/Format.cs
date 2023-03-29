using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produse
{
    class Format
    {
        // formate disponibile (cd, vinyl, digital download)
       private string[] formatePosibile= { "CD", "Vinyl", "MC", "Digital Download"};
       private int NrTracks;
        private string format;

       public Format(string format)
       {
            foreach(string form in formatePosibile)
            {
                if(format == form)
                    this.format = format;
                else Console.WriteLine("{0} nu exista!\n",form );

            }
       }

        public void SetNrTracks(int NrTracks)
        {
            if (NrTracks != 0 && NrTracks <100)
                this.NrTracks = NrTracks;
            else Console.WriteLine("O inregistrare/box set nu poate avea mai mult de 100 de piese!\n");
        }

    }

   


   
}



