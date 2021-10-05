using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare.Classes
{
    public abstract class House
    {
        public string HouseCode { get; set; } = "";
        public int Surface { get; set; } = 0;
        public int Rooms { get; set; } = 1;

        public House() { }


        public House(string code)
        {
            HouseCode = code;
        }

        public House(string code, int surface, int rooms)
        {
            HouseCode = code;
            Surface = surface;
            Rooms = rooms;
        }

        public abstract int GetCost();


        public virtual string GetInfo()
        {
            string ret =  $" Tipologia : { this.GetType().Name} \t";
            ret += $" Cod: {this.HouseCode} \t";
            ret += $" Superficie: {this.Surface}  \t";
            ret += $" Numero stanze: {this.Rooms}  \t";
            ret += $" Costo immobile: {this.GetCost()} \t";

            return ret;
        }

    }
}
