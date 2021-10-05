using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneClassi
{
    public class Person
    {
        //Attributi: nome, cognome, residenza, dataNascita 
        private string nome;
        private string cognome;
        private string residenza;
        private DateTime dataNascita;

        //Properties
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Cognome
        {
            get
            {
                return Cognome;
            }
            set
            {
                Cognome = value;
            }
        }
        public string Residenza
        {
            get
            {
                return residenza;
            }
            set
            {
                residenza= value;
            }
        }
        public DateTime DataNascita
        {
            set
            {
                dataNascita = value;
            }
        }
        public int Eta
        {
            get
            {
                TimeSpan tsAge = DateTime.Now - dataNascita;
                int eta = (int)tsAge.TotalDays / 365;
                return eta;
            }
        }

        //Costruttore
        public Person()
        {
            nome = "";
            cognome = "";
            residenza = "";
            dataNascita = new DateTime(1800, 1, 1);
        }
        // Overload del costruttore
        public Person(DateTime pDataNascita)
        {
            nome = "";
            cognome = "";
            residenza = "";
            dataNascita = pDataNascita;
        }
        public Person(string pDataNascita)
        {
            nome = "";
            cognome = "";
            residenza = "";
            dataNascita = DateTime.Parse(pDataNascita);
        }
        public Person (string pNome, string pCognome)
        {
            nome = pNome;
            cognome = pCognome;
            residenza = "";
            dataNascita= new DateTime(1900, 1, 1);
        }


        //Metodi
        public string CalcolaCodiceFiscale()
        {
            throw new NotImplementedException();
        }




    }

}
