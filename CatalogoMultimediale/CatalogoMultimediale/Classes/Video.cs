using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoMultimediale.Interfaces;

namespace CatalogoMultimediale.Classes
{
    public class Video : Riproducibile , IMostrabile
    {
        private int luminosita;

        public Video()
        {
        }

        public Video(string pTitolo, int pDurata, int pVolume, int pLuminosita) : base(pTitolo, pDurata, pVolume)
        {
            luminosita = pLuminosita;
        }

        public int Luminosita { get => luminosita; set => luminosita = value; }


        public void Brighter() 
        {
            luminosita++;
        }
        public void Darker() 
        { 
            luminosita--;
        }
        public string StampaLuminosita()
        {
            string s = "";
            for (int i = 0; i < luminosita; i ++)
            {
                s += "*";
            }
            return s;
        }

        public override string Play()
        {
            string s = "";
            for(int i = 0; i < Durata;i++) 
            {
                s += Titolo + "\n";
            }
            s += base.StampaVolume();
            s += this.StampaLuminosita();

            return s;
        }

    }

}
