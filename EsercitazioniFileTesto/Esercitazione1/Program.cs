using System;
using System.Collections.Generic;
using System.IO;

namespace Esercitazione1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;

            if (File.Exists("stringhe.txt"))
            {
                sw = File.AppendText("stringhe.txt");
            }
            else
            {
                sw = File.CreateText("stringhe.txt");
            }

            Console.Write("Inserisci una stringa: ");
            string consoleText = Console.ReadLine();

            //while (consoleText != "")
            while (consoleText != string.Empty)
            {
                sw.WriteLine(consoleText);
                Console.Write("Inserisci un'altra stringa: ");
                consoleText = Console.ReadLine();
            }

            sw.Close();
            Console.WriteLine("Scrittura sul file di testo avvenuta con successo!");

            StreamReader sr = File.OpenText("stringhe.txt");
            List<string> righeLette = new List<string>();

            string riga = sr.ReadLine();

            while (riga != null)
            {
                righeLette.Add(riga);
                riga = sr.ReadLine();
            }

            sr.Close();

            Console.WriteLine("File letto con successo!");

            for(int i = righeLette.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($" Elemento {i} della lista : {righeLette[i]}");
            }
            
            /* Equivalente a.....
               
            for (int i = righeLette.Count; i > 0; i--)
            {
                Console.WriteLine($" Elemento {i-1} della lista : {righeLette[i-1]}");
            }
            
            */

            Console.ReadKey();
        }
    }
}
