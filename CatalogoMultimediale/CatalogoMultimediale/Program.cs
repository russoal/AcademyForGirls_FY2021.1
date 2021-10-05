using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CatalogoMultimediale.Classes;
using CatalogoMultimediale.Interfaces;

namespace CatalogoMultimediale
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ElementoMultimediale> playList = new List<ElementoMultimediale>();

            ///  playList.Add(new ElementoMultimediale()); ERRORE!!! 
               
            playList.Add(new Audio("Pink Floyd - Money", 5, 20));

            playList.Add(new Audio("Pink Floyd - Wish you were here", 7, 20));
            
            playList.Add(new Immagine("Brazil 2007 - Foto 1", 10));
            
            playList.Add(new Immagine("Brazil 2007 - Foto 2", 10));
            
            playList.Add(new Video("Matrix", 7, 16, 44));
            
            playList.Add(new Immagine("Brazil 2007 - Foto 3", 6));
            
            playList.Add(new Video("Star Wars", 34, 20, 35));
            
            playList.Add(new Audio("Beatles - Back in the USSR", 4, 30));

            foreach (ElementoMultimediale em in playList)
            {
                Console.Clear();
                Console.WriteLine(em.Play());
                Console.WriteLine("\n Premi un tasto per continuare....");
                Console.ReadKey();
            }
            Console.WriteLine("\n Premi un tasto per chiudere il lettore multimediale....");
            Console.ReadKey();



        }
    }
}
