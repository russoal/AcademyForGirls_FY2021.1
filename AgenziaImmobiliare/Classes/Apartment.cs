using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare.Classes
{

    public class Apartment : House
    {
        public const int ApartmentCost = 1500;
        public int EnergyLevel { get; set; }

        public Apartment() { }

        public Apartment(string code, int surface, int rooms, int energyLevel) : base(code, surface, rooms)
        {
            EnergyLevel = energyLevel;
        }

        public override int GetCost()
        {
            return (Surface * ApartmentCost) + (Rooms * EnergyLevel);
        }

        public override string GetInfo()
        {
            string ret = base.GetInfo();
            ret += $"Livello energetico : {this.EnergyLevel}";

            return ret;
        }

    }

}

