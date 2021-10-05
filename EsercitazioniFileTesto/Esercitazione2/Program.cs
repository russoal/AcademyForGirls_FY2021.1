using System;
using System.Collections.Generic;
using System.IO;
using ToolsLibrary;



namespace Esercitazione2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;

            if (File.Exists("numeri.txt"))
            {
                sw = File.AppendText("numeri.txt");
            }
            else
            {
                sw = File.CreateText("numeri.txt");
            }


            int tmpInt = ConsoleTools.ReadInt("Inserisci un valore intero");

            while (tmpInt != 0)
            {
                sw.WriteLine(tmpInt);
                tmpInt = ConsoleTools.ReadInt("Inserisci un valore intero");
            }

            sw.Close();
            Console.WriteLine("Inserimento avvenuto con successo");
            Console.WriteLine("\n");

            StreamReader sr = File.OpenText("numeri.txt");
            string rigaLetta = sr.ReadLine();
            while (rigaLetta != null)
            {
                Console.WriteLine(rigaLetta);
                rigaLetta = Console.ReadLine();
            }
            sr.Close();


            Console.ReadKey();

        }
    }
}
