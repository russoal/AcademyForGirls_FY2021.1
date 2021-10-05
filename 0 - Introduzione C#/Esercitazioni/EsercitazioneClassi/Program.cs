using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneClassi
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            Console.Write("Insrisci Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Insrisci Cognome: ");
            p.Cognome = Console.ReadLine();

            Console.Write("Insrisci Residenza: ");
            p.Residenza = Console.ReadLine();

            Console.Write("Insrisci Data di Nascita: ");
            p.DataNascita = DateTime.Parse(Console.ReadLine());

            //-----------------------------------//
            Console.WriteLine("\n");
            Console.WriteLine("Definizione di una nuova istanza della classe Persona ");

            Console.Write("Insrisci Data di Nascita per la nuova istanza: ");
            string dn = Console.ReadLine();
            //DateTime data = DateTime.Parse(dn);
            Person p2 = new Person(DateTime.Parse(dn));

            //-----------------------------------//
            Console.WriteLine("\n");
            Console.WriteLine("Definizione di una nuova istanza della classe Persona ");

            Console.Write("Insrisci Data di Nascita per la nuova istanza: ");
            Person p3 = new Person(Console.ReadLine());
            p3.

            //-----------------------------------//
            Console.WriteLine("\n");



        }
    }
}
