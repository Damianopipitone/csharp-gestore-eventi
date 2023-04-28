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
        private readonly int capienzaMax;
        private int postiPrenotati;
        private int postiDisponibili;

        // COSTRUTTORE 

        public Evento(string titolo,string data, int capienzaMax)
        {   
            if (titolo == "")
            {
                throw new ArgumentException("Non hai inserito il titolo dell'evento!");
            }
            if (data != "29/05/2023")
            {
                throw new ArgumentException("In tale data indicata non sono previsti eventi");
            }

            this.titolo = titolo;
            this.data = DateTime.Parse(data);       
            this.capienzaMax = capienzaMax;
            this.postiPrenotati = 0;
            this.postiDisponibili = 1000;
            
        }

        public Evento(string titolo)
        {
            this.titolo = titolo;
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
                int nuoviPostiDisponibili = capienzaMax;
            }
        }

       
        // METODI 

        public void Prenota(int postiDaPrenotare)
        {
            if(postiDaPrenotare > postiDisponibili)
            {
                throw new ArgumentException("Non ci sono più posti disponibili per questo evento"); ;
            } 

            this.postiDisponibili = postiDisponibili - postiDaPrenotare;
            this.postiPrenotati += postiDaPrenotare;
            Console.Write("Hai prenotato: " + postiDaPrenotare + " posti \n");
            Console.WriteLine("Sono rimasti disponibili: " + this.postiDisponibili + " posti\n");
            
        }

        public void Disdici(int disdiciPosti)
        {   
            if(postiPrenotati < disdiciPosti)
            {
                throw new ArgumentException("I posti da disdire sono insufficienti!");
            }

            this.postiPrenotati -= disdiciPosti;
            this.postiDisponibili += disdiciPosti;
            Console.WriteLine("Hai disdetto: " + disdiciPosti + " posti");
            Console.WriteLine("I posti disponibili ora sono: " + this.postiDisponibili);
            
        }

        public override string ToString()
        {   
            string rapprString = "\t" + data.ToString("dd/MM/yyyy") + " - " + this.titolo + "\n";
            rapprString += "\tPosti disponibili: " + this.capienzaMax + "\n";
            rapprString += "\tPosti prenotati: " + postiPrenotati + "\n";
            return rapprString; 
        }
    }
}
