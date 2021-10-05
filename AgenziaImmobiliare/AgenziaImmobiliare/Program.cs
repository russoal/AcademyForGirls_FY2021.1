using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenziaImmobiliare.Classes;
using ToolsLibrary;


namespace AgenziaImmobiliare
{
    class Program
    {
        static void Main(string[] args)
        {
            Archive archivio = InitArchive();
            string titolo = " GESTIONE AGENZIA IMMOBILIARE ";

            string[] vociMenu = { "Visualizza tutti gli Immobili ",
                                  "Visualizza immobili con superficie maggiore di...",
                                  "Visualizza costo medio degli immobili con superficie maggiore di...",
                                  "Inserisci nuovo immobile"
            };
            string terminatore = "q";
            string selezione = "";
            while (selezione != terminatore)
            {
                selezione = MenuTools.SelectMenuVoice(titolo, vociMenu, terminatore);
                if (selezione != terminatore)
                {
                    Console.Clear();
                    switch (selezione)
                    {
                        case "0":
                            ConsoleServices.ShowAllHouses(archivio);
                            break;
                        case "1":
                            ConsoleServices.ShowHousesMinmq(archivio);
                            break;
                        case "2":
                            ConsoleServices.ShowAverageCost(archivio);
                            break;
                        case "3":
                            ConsoleServices.InsertHouse(archivio);
                            break;
                        default:
                            Console.WriteLine("Selezione errata");
                            Console.ReadKey(true);
                            break;

                    } // End Switch
                }

            }// End While

            Console.WriteLine("\n\n Hasta la vista baby!!");
            Console.ReadKey(true);
        }

        private static Archive InitArchive()
        {
            Archive archivio = new Archive();

            // archivio.HousesList = new List<House>();

            archivio.AddHouse(new Apartment("A0078", 120, 5, 20));
            archivio.AddHouse(new Apartment("A0027", 92, 4, 20));
            archivio.AddHouse(new Apartment("A0271", 125, 5, 10));
            archivio.AddHouse(new Apartment("A0056", 60, 3, 30));
            archivio.AddHouse(new Apartment("A0544", 90, 4, 20));
            archivio.AddHouse(new Apartment("A0011", 150, 6, 50));
            archivio.AddHouse(new Villa("V0087", 250, 6, false));
            archivio.AddHouse(new Villa("V0012", 305, 7, true));
            archivio.AddHouse(new Villa("V0752", 400, 12, false));
            archivio.AddHouse(new Villa("V0099", 201, 6, true));
            archivio.AddHouse(new Villa("V0007", 700, 15, true));
            return archivio;
        }

    }
}
