using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class MenuTools
    {
        public static string SelectMenuVoice(string titolo, string[] vociMenu, string terminatore)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(titolo);
            Console.WriteLine("\n");
            for (int i = 0; i < vociMenu.Length; i++)
            {
                Console.WriteLine($" {i} ----> {vociMenu[i]}");
            }
            Console.WriteLine($" {terminatore} ----> Uscita dal programma  ");
            Console.WriteLine("\n");
            string tmpSelect = Console.ReadKey().KeyChar.ToString();

            return tmpSelect;
        }


    }
}
