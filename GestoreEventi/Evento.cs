using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        public string titolo;
        public DateTime data;
        private int capienzaMax;
        private int postiPrenotati;

        // COSTRUTTORE 

        public Evento(string titolo, int capienzaMax, int postiPrenotati)
        {
            this.titolo = titolo;
            this.capienzaMax = capienzaMax;
            this.postiPrenotati = postiPrenotati;
        }

        // GETTERS

        public string GetTitolo()
        {
            return titolo;
        }

        public DateTime GetData()
        {
            return data;
        }

        public int GetcapienzaMax()
        {
            return capienzaMax;
        }

        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }

        // SETTERS 

        public void SetTitolo(string titolo)
        {
            if(titolo == "")
            {
                throw new ArgumentException("Devi inserire il titolo dell'evento");
            } else
            {
                this.titolo = titolo;
            }
        }

        public void SetData(DateTime data)
        {
            
        }

        public void SetCapienzaMax(int capienzaMax)
        {
            if (capienzaMax < 0)
            {
                throw new ArgumentException("Inserire un numero positivo...");
            } else
            {
                this.capienzaMax = capienzaMax;
            }
        }
    }
}
