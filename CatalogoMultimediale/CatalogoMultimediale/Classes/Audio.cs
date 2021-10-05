using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoMultimediale.Classes
{
    public class Audio : Riproducibile
    {
        public Audio()
        {
        }

        public Audio(string pTitolo, int pDurata, int pVolume) : base(pTitolo, pDurata, pVolume)
        {
        }

        public override string Play()
        {
            string s = "";
            for (int i = 0; i < Durata; i++)
            {
                s += Titolo + "\n";
            }
            s += base.StampaVolume();

            return s;
        }


    }
}
