using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoMultimediale.Classes
{
    public abstract class ElementoMultimediale
    {
        private string titolo;

        public ElementoMultimediale(string pTitolo)
        {
            titolo = pTitolo;
        }

        public ElementoMultimediale()
        {
        }

        public string Titolo { get => titolo; set => titolo = value; }

        public abstract string Play();

    }
}
