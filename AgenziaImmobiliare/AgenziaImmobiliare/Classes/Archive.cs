using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare.Classes
{
    public class Archive
    {

        public List<House> HousesList { get; set; } = new List<House>();


        public void AddHouse(House element)
        {
            HousesList.Add(element);
        }



        public int AverageCost(int minimumSurface)
        {
            int sum = 0;
            int count = 0;

            foreach (House h in HousesList)
            {
                if (h.Surface >= minimumSurface)
                {
                    sum += h.GetCost();
                    count++;
                }
            }
            return sum / count;
        }

    }

}
