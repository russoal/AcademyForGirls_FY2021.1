using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoMultimediale.Classes
{
    public abstract class Riproducibile : ElementoMultimediale
    {
        private int durata;
        private int volume;
        public int Durata { get => durata; set => durata = value; }
        public int Volume { get => volume; set => volume = value; }

        public Riproducibile()
        {
        }

        public Riproducibile(string pTitolo, int pDurata, int pVolume)
            :base(pTitolo)
        {
            Durata = pDurata;
            Volume = pVolume;
        }



        public override abstract  string Play();

        public void AlzaVolume()
        {
            volume++;
        }
        public void AbbassaVolume()
        {
            volume--;
        }

        public string StampaVolume()
        {
            string s = "";
            for(int i = 0; i < volume; i++)
            {
                s += "!";
            }
            return s;
        }

    }

}
