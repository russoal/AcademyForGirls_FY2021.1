

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class ConsoleTools
    {
        public static string ReadString(string label)
        {
            Console.Write(label);
            string tmpVal = Console.ReadLine();
            return tmpVal;
        }

        public static int ReadInt(string label)
        {
            try
            {
                Console.Write(label);
                int tmpVal = int.Parse(Console.ReadLine());
                return tmpVal;
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero intero.");
                return ReadInt(label);
            }
        }

        public static float ReadFloat(string label)
        {
            try
            {
                Console.Write(label);
                float tmpVal = float.Parse(Console.ReadLine());
                return tmpVal;
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero.");
                return ReadFloat(label);
            }
        }
        public static double ReadDouble(string label)
        {
            try
            {
                Console.Write(label);
                double tmpVal = double.Parse(Console.ReadLine());
                return tmpVal;
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero.");
                return ReadDouble(label);
            }
        }

        public static decimal ReadDecimal(string label)
        {
            try
            {
                Console.Write(label);
                decimal tmpVal = decimal.Parse(Console.ReadLine());
                return tmpVal;
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero.");
                return ReadDecimal(label);
            }
        }

        public static DateTime ReadDate(string label)
        {
            try
            {
                Console.Write(label);
                DateTime tmpVal = DateTime.Parse(Console.ReadLine());
                return tmpVal;
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire una data.");
                return ReadDate(label);
            }
        }
        public static bool ReadBool(string label, string trueVal, string falseVal)
        {
            string key = ReadString($" {label} ({trueVal}/{falseVal})  ");
            if (key.ToLower() == trueVal.ToLower())
                return true;
            else if (key.ToLower() == falseVal.ToLower())
                return false;
            else
                Console.WriteLine($"Valore inserito non valido. Inserire {trueVal} oppure {falseVal} ");
            return ReadBool(label, trueVal, falseVal);
        }




        //  Esempi Overload
        public static void ReadFromKeyboard(string label, out int retVal)
        {
            try
            {
                Console.Write(label);
                retVal = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero intero.");
                ReadFromKeyboard(label, out retVal);
            }
        }

        public static void ReadFromKeyboard(string label, out float retVal)
        {
            try
            {
                Console.Write(label);
                retVal = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero intero.");
                ReadFromKeyboard(label, out retVal);
            }
        }

        public static void ReadFromKeyboard(string label, out double retVal)
        {
            try
            {
                Console.Write(label);
                retVal = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valore inserito non valido. Inserire un numero intero.");
                ReadFromKeyboard(label, out retVal);
            }
        }

        public static int[] ReadIntArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = ReadInt($"Inserisci il valore in posizione {i} : ");
            }
            return array;
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"L'elemento in posizione {i} è: {array[i]}");
            }
        }

    }

}
