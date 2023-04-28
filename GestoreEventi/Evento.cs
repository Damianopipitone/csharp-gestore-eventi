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
        private int postiPrenotati = 300;
        private int postiDisponibili = 700;

        // COSTRUTTORE 

        public Evento(string titolo,string data, int capienzaMax)
        {
            this.titolo = titolo;
            this.data = DateTime.Parse(data);       
            this.capienzaMax = capienzaMax;
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

        public void SetData(string data)
        {
            this.data = DateTime.Parse(data);
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
            int nuoviPostiPrenotati = postiPrenotati + prenotaPosti;
            Console.WriteLine("Hai prenotato: " + prenotaPosti + " posti");
            Console.WriteLine("Posti prenotati in totale: " + nuoviPostiPrenotati + " posti");
        }

        public void Disdici(int disdiciPosti)
        {
           int nuoviPostiDisponibili = postiDisponibili + disdiciPosti;
            Console.WriteLine("Hai disdetto: " + disdiciPosti + " posti");
            Console.WriteLine("Posti disponibili :" + nuoviPostiDisponibili + " posti");
        }

        public override string ToString()
        {   
            string rapprString = "\t" + data.ToString("dd/MM/yyyy") + " - " + this.titolo + "\n";
            rapprString += "\tPosti disponibili: " + postiDisponibili + "\n";
            rapprString += "\tPosti prenotati: " + postiPrenotati + "\n";
            return rapprString; 
        }
    }
}
