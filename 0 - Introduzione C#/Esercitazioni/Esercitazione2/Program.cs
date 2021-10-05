using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercitazione1;

namespace Esercitazione2
{
    class Program
    {
        static void Main(string[] args)
        {

            //*********************************//
            //  DEFINIZIONE DI UN ARRAY IN C#  //
            //*********************************//
            /*
            int[] array = new int[5]; // Array di interi formato da 5 elementi;

            string[] stringArray = new string[6];  //Array di stringhe formato da 6 elementi

            int[] array1 = new int[] { 11, 3, 5, 27, 9, 12 }; // Array di interi di 6 elementi contenente i valori  11, 3, 5, 27, 9, 12

            string[] weekDays2 = { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica" };

            long[] longArr = {12321321312321,54542542,566546546534653465346534653,635465563};

            Console.WriteLine(longArr[2]);

            */

            //1) Dati due vettori di 10 elementi, visualizzare gli elementi dei due vettori. 
            int[] array1 = new int[] { 12, 5, 7, 15, 27, 66, 57, 32, 21, 19 };
            int[] array2 = new int[] { 21, 25, 37, 51, 72, 166, 75, 23, 12, 91 };

            Console.WriteLine($"Il primo elemento di array1 è { array1[0]}");
            Console.WriteLine($"L'ultimo elemento di array1 è { array1[9]}");

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine($"L'elemento in posizione {i} è {array1[i]}");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"L'elemento in posizione {i} di array2 è {array2[i]}");
            }

            Console.ReadKey();

            //2) Dati due vettori di 10 elementi, visualizzare il vettore somma.

            int[] arraySomma = new int[10];

            for(int i = 0; i < 10; i++)
            {
                arraySomma[i] = array1[i] + array2[i];
            }

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine($"L'elemento in posizione {i} dell'array somma è {arraySomma[i]}");
            }

            Console.ReadKey();

            //3) Creare un nuovo vettore di 12 elementi (interi)
            //   facendo inserire i valori da un operatore,
            //   quindi calcolarne la somma degli elementi inseriti.

            int[] myArray = new int[12];
            int somma = 0;

            for(int i = 0; i < 12; i++)
            {
                int elem = Esercitazione1.Program.GetIntFromKeyboard("Inserisci un elemento del vettore...", 0);
                myArray[i] = elem;
                somma += myArray[i];
            }

            /*
             * NO! poco efficiente!!!
            int somma=0;
            for(int i = 0; i < 12; i++)
            {
                somma += myArray[i];
            }
            */
            
            Console.WriteLine($"La somma degli elementi inseriti è {somma}");


            // 4) Dato un vettore di 10 elementi, visualizzare gli elementi inseriti in ordine inverso all'inserimento.
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"L'elemento in posizione {i} di myArray è {myArray[i]} ");
            }
            Console.ReadKey();

            // 5) Dato un vettore visualizzare solo gli elementi in posizione pari
            for (int i = 1; i < 10; i += 2) 
            {
                Console.WriteLine($"L'elemento in posizione {i} di myArray è {myArray[i]} ");
            }



            // TO DO List....
            //

            // 5) Calcolare il minimo ed il massimo di un vettore di 10 elementi.
            // 6) Calcolare la media di un insieme di numeri digitati sequenzialmente da un operatore. 
            //    Non è noto a priori quanti siano i numeri di cui deve essere calcolata la media.
            //    Pertanto verranno inseriti numeri fino a che l'operatore non inserisca il numero 0 (zero). 
            //    Comunque al massimo possono essere inseriti 20 numeri.
            // 7) Dato un vettore di 10 elementi,  visualizzare gli elementi inseriti in ordine inverso all'inserimento.    



        }
    }
}
