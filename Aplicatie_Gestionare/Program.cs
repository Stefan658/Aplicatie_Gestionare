using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Aplicatie_Gestionare; // !!!
using Produse; // !!!

namespace Aplicatie_Gestionare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrP = 0;
            Produs[] produse = new Produs[nrP];
            Produs s1 = new Produs();
            int idProdus = 1;

            
           /* Console.Write("Introdu nr de produse de introdus ");
            int nrProduse = Int32.Parse(Console.ReadLine());


             for(int index = 1; index<=nrProduse;index++)
             {
                 Console.WriteLine("Introdu titlul produsului cu id {0} : ", idProdus);
                 string titlu = Console.ReadLine();
                 Console.WriteLine("Introdu numele artistului - produs cu id {0} : ", idProdus);
                 string artist = Console.ReadLine();
                 s1 = new Produs(idProdus, titlu, artist);
                 produse[idProdus++] = s1;


             }*/




            Console.WriteLine("Produse disponibile pe stoc: ");
            Console.WriteLine();
            Produs p1 = new Produs (5,"Abbey Road","The_Beatles");
          //  produse[idProdus++] = p1;
             Console.WriteLine("Title: {0}",p1.GetTitlu());
              Console.WriteLine("Artist: {0}", p1.GetArtist());
              Console.WriteLine("ID: {0}", p1.GetIdProdus());

            Produs p2 = new Produs();
            p2.SetTitlu("Selling England by the Pound");
            p2.SetArtist("Genesis");
            p2.SetIdProdus(6);
            produse[idProdus++] = p2;

         //   Console.WriteLine();
            Console.WriteLine("Title: {0}", p2.GetTitlu());
            Console.WriteLine("Artist: {0}", p2.GetArtist());
            Console.WriteLine("ID: {0}", p2.GetIdProdus());
            InfoProduse(produse);

             void InfoProduse(Produs[] produs)
            {
                Console.WriteLine("Produse disponibile:");
                for (int contor = 0; contor < idProdus; contor++)
            {
                string infoProd = string.Format("Produsul cu id-ul #{0}:\n Titlu: {1}\nArtist: {2}",
                   produs[contor].GetIdProdus(),
                   produs[contor].GetTitlu() ?? " NECUNOSCUT ",
                   produs[contor].GetArtist() ?? " NECUNOSCUT ");

                Console.WriteLine(infoProd);
            }



        }

            if (args.Length == 0)
                Console.Write("Nu sunt argumente in linia de comanda!");
            else
            {
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);

                foreach (string param in args)
                    Console.WriteLine(param);

               switch (args[0])
                {
                    case "Genesis":
                    case "The_Beatles":
                        Console.WriteLine("Produsele acestui artist se gasesc in stoc");
                        break;
                    default:
                        Console.WriteLine("Indisponibil");
                        break;
                }
            }
            Console.ReadKey();



        }
            }
}
   