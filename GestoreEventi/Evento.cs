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
        private int postiDisponibili = 200;

        // COSTRUTTORE 

        public Evento(string titolo,DateTime data, int postiDisponibili)
        {
            this.titolo = titolo;
            this.data = data;       
            this.postiDisponibili = postiDisponibili;
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
            data.ToString("dd/MM/yyyy");
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

        // METODI 

        public void Prenota(int prenotaPosti)
        {
            int postiPrenotati = postiDisponibili - prenotaPosti;
            
        }

        public void Disdici(int disdiciPosti)
        {
            int postiDisdetti = postiDisponibili + disdiciPosti;
        }

        public override string ToString()
        {   
            string rapprString = "\t" + data + " - " + titolo;
            return rapprString;
        }
    }
}
