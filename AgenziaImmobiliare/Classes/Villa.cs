using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare.Classes
{
    public class Villa : House
    {
        private const int VillaCost = 2000;
        private const int HasPoolFactor = 20000;
        private const int RoomsFactor = 10000;
        public bool HasPool { get; set; }

        public Villa() { }

        public Villa(string code, int surface, int rooms, bool hasPool) : base(code, surface, rooms)
        {
            HasPool = hasPool;
        }

        public override int GetCost()
        {
            return (Surface * VillaCost) + (HasPool ? HasPoolFactor : 0) + (Rooms >= 10 ? RoomsFactor : 0);
        }

        public override string GetInfo()
        {
            string ret = base.GetInfo();
            ret += HasPool ? " Con piscina " : "";

            return ret;
        }

    }
}


////////////////////////////////////////////////////////////////////////////////////////
//// NOTARE l'operatore "?"  
//// chiamato OPERATORE CONDIZIONALE TERNARIO
//// 
////
//    int poolValue = HasPool ? HasPoolFactor : 0;
//
////     equivale a:
//
//     int poolValue;
//     if (HasPool)
//         poolValue = 20000;
//     else
//         poolValue = 0;
//
////  E' un operatore, quindi restituisce un valore. 
////  Nel nostro esempio restituisce il valore 20000 se HasPool è true, restituisce 0 se Haspool è false 
////  Il risultato viene memorizzato nella variabile poolValue.
////   
////  Attenzione: il valore del ramo true ed il valore del ramo false devono essere dello stesso tipo
////              altrimenti si avrà un errore di compilazione! 
////
////////////////////////////////////////////////////////////////////////////////////////
////  
////  Esiste anche l'operatore "??" chiamato NULL COALESCING che viene utilizzato
////  per valutare se il valore di una variabile è null   
//// 
////  Ad esempio 
//       int x = y ?? -1;
////  equivale a:
//       int x = y != null ? y : -1
////  ovvero:
//       int x; 
//       if( y != null)
//       {
//          x = y;
//       }
//       else
//       {
//          x = -1;
//       }
//
////////////////////////////////////////////////////////////////////////////////////////
