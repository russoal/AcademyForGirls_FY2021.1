using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!!");

            string myName;

            myName = Console.ReadLine();

            Console.WriteLine($"HELLO {myName}");
            Console.WriteLine("HELLO " + myName);

            int x = 15;

            Console.WriteLine($"Oggi ci sono {x} gradi");

            Console.Write("Oggi ci sono ");
            Console.Write(x);
            Console.WriteLine(" gradi");



            Console.ReadKey();

            

        }
    }
}
