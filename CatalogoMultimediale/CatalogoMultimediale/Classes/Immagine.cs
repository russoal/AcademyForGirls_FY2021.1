using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoMultimediale.Interfaces;

namespace CatalogoMultimediale.Classes
{
    public class Immagine : ElementoMultimediale , IMostrabile
    {
        private int luminosita;
        public int Luminosita { get => luminosita; set => luminosita = value; }


        public Immagine()
        {

        }
        public Immagine(string pTitolo, int pLuminosita) : base(pTitolo)
        {
            this.luminosita = pLuminosita;
        }

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
            for (int i = 0; i < luminosita; i++)
            {
                s += "*";
            }
            return s;
        }

        public override string Play()
        {
            return base.Titolo + this.StampaLuminosita();
        }


    }
}
