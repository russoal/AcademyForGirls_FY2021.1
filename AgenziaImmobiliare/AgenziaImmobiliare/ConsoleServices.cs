using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenziaImmobiliare.Classes;
using ToolsLibrary;

namespace AgenziaImmobiliare
{
    class ConsoleServices
    {

        public static void InsertHouse(Archive archivio)
        {
            Console.Clear();
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine("*      INSERIMENTO NUOVI IMMOBILI     *");
            Console.WriteLine("*-------------------------------------*");
            string tipoImmobile = "";

            while (tipoImmobile != "q")
            {
                while (tipoImmobile.ToLower() != "v" && tipoImmobile.ToLower() != "a" && tipoImmobile.ToLower() != "q")
                {
                    Console.Clear();
                    tipoImmobile = ConsoleTools.ReadString("Inserisci tipo di immobile (v: Villa; a: Appartamento; q: esci) ==> ");
                }
                if (tipoImmobile != "q")
                {
                    Console.WriteLine("\n");
                    string codice = ConsoleTools.ReadString("    Codice        ==> ");
                    int supMq = ConsoleTools.ReadInt("    Superficie mq ==> ");
                    int rooms = ConsoleTools.ReadInt("    Numero Stanze ==> ");
                    bool hasPool;
                    int energyLevel;
                    switch (tipoImmobile)
                    {
                        case "v":
                            hasPool = ConsoleTools.ReadBool("    E' presente una piscina? ==> ", "s", "n");
                            archivio.AddHouse(new Villa(codice, supMq, rooms, hasPool));
                            Console.WriteLine("\n  Nuova villa inserita in archivio");
                            break;

                        case "a":
                            energyLevel = ConsoleTools.ReadInt("    Livello energetico ==> ");
                            archivio.AddHouse(new Apartment(codice, supMq, rooms, energyLevel));
                            Console.WriteLine("\n  Nuovo appartamento inserito in archivio");
                            break;

                        default:
                            Console.WriteLine($" [{tipoImmobile}] : Tipologia di immobile non gestita!!");
                            break;
                    }
                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                    tipoImmobile = "";
                }
            }
            Console.WriteLine(" Fine inserimento.... Premi un tasto per tornare al menu....");
            Console.ReadKey();
        }


        public static void ShowAverageCost(Archive archivio)
        {
            Console.Clear();
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine("*      COSTO MEDIO DEGLI IMMOBILI     *");
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine();
            int minMq = ConsoleTools.ReadInt("Inserisci il limite min. in mq --> ");
            Console.WriteLine($"La media del costo degli immobili in archivio che superano i {minMq} mq è {archivio.AverageCost(minMq)}");
            Console.WriteLine();
            Console.WriteLine($"La media del costo degli immobili in archivio è {archivio.AverageCost(0)}");
            Console.WriteLine();
            Console.WriteLine("Premi un tasto per tornare al menu...");
            Console.ReadKey();
        }

        public static void ShowAllHouses(Archive archivio)
        {
            Console.Clear();
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine("*         IMMOBILI IN ARCHIVIO        *");
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine();
            foreach (House h in archivio.HousesList)
            {
                ShowHouseInfo(h);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Premi un tasto per tornare al menu...");
            Console.ReadKey();
        }


        public static void ShowHousesMinmq(Archive archivio)
        {
            Console.Clear();
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine("*         IMMOBILI IN ARCHIVIO        *");
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine();
            int minMq = ConsoleTools.ReadInt("Inserisci il limite min. in mq --> ");

            Console.WriteLine($"Questi sono gli immobili che hanno una superficie superiore a {minMq} mq: ");
            foreach (House h in archivio.HousesList)
            {
                if (h.Surface > minMq)
                {
                    ShowHouseInfo(h);
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            Console.WriteLine("Premi un tasto per tornare al menu...");
            Console.ReadKey();
        }

        public static void ShowHouseInfo(House h)
        {

            Console.WriteLine(h.GetInfo()); 

            //Console.Write($" Tipologia : {h.GetType().Name} \t");
            //Console.Write($" Cod: {h.HouseCode} \t");
            //Console.Write($" Superficie: {h.Surface}  \t");
            //Console.Write($" Numero stanze: {h.Rooms}  \t");
            //Console.Write($" Costo immobile: {h.GetCost()} ");
            //
            ////Informazione "caratteristica" di Villa o Apartment
            //
            //if(h.GetType().Name == "Villa")
            //{
            //    Villa v = (Villa)h;
            //    Console.Write($"{(v.HasPool ? " Con piscina " : "")}");
            //}
            //else
            //{
            //    Apartment a = (Apartment)h;
            //    Console.Write($"Livello energetico : {a.EnergyLevel}");
            //}

        }
    }
}
