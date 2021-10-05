

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Commenta il testo che si trova sulla destra
            /*
             * 
             * Commenta 
             *        righe
             * 
             */

            //Somma di due numeri immessi da tastiera.
            //Si accettano solo numeri maggiori di 10
            // Parse e' un metodo statico che viene applicato sulla stringa
            Console.WriteLine("Somma di due numeri inseriti da tastiera"); // gfsf
            int numero1 = GetIntFromKeyboard("Inserisci il primo numero: ", 10);
            int numero2 = GetIntFromKeyboard("Inserisci il secondo numero: ", 25);
            Console.WriteLine($"La somma di {numero1} + {numero2} e': + {numero1 + numero2} ");


            //calcolo l'area di un rettangolo
            Console.WriteLine("\n");
            AreaRettantolo();

            Console.WriteLine($"Il valore massimo della sequnza inserita è {GetMaxFromKeybord(5)}");

            Console.ReadKey();
        }

        //creo una funzione
        public static int GetIntFromKeyboard(string label, int minVal)
        {
            int numero1 = 0;
            do
            {
                Console.WriteLine(label);
                string numeroInserito1 = Console.ReadLine();
                try
                {
                    numero1 = int.Parse(numeroInserito1);
                    if (numero1 < minVal)
                    {
                        Console.WriteLine($"Inserisci un numero maggiore di {minVal}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Devi inserire un numero intero");
                }

            } while (numero1 <= minVal);
            return numero1;
        }

        public static int AreaRettantolo()
        {
            Console.WriteLine("Calcola area del rettangolo");
            int numero1 = GetIntFromKeyboard("Inserisci la base (con un minimo di 10): ", 10);
            int numero2 = GetIntFromKeyboard("Inserisci l'altezza (con un minimo di 25): ", 25);

            int areaRettangolo = numero1 * numero2;
            Console.WriteLine($"L'area del rettangolo e' + {areaRettangolo}");
            return areaRettangolo;
        }


        // Creare una funzione che restituisca il massimo di due numeri interi inseriti da tastiera

        // NEXT STEP:
        // Modificare la funzione GetMaxFromKeyboard in modo che possa accettare una sequenza di numeri
        // definita da un parametro (anzichè solo due numeri come è ora).

        public static int GetMaxFromKeybord()
        {
            int ret;
            Console.WriteLine("Calcola Massimo");
            int n = GetIntFromKeyboard(" Inserisci un numero", 0);
            int k = GetIntFromKeyboard(" Inserisci un numero", 0);
            if (n > k)
            {
                Console.WriteLine($"Il massimo è {n}");
                ret = n;
            }
            else if (k > n)
            {
                Console.WriteLine($"Il massimo è {k}");
                ret = k;
            }
            else
            {
                Console.WriteLine("I numeri inseriti sono uguali");
                ret = 0;
            }

            return ret;
        }

        public static int GetMaxFromKeybord(int nInt)
        {
            Console.WriteLine("Calcola Massimo");
            int max = 0;
            for (int i = 0; i < nInt; i++)
            {
                int n = GetIntFromKeyboard(" Inserisci un numero", 0);
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }











    }

}

