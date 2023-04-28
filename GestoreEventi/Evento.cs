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
        private int postiDisponibili = 1000;

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

        public void Prenota(int prenotaPosti)
        {
            if(postiPrenotati < 1000)
            {
                this.postiPrenotati = postiDisponibili - prenotaPosti;
            } else
            {
                throw new ArgumentException("Non ci sono più posti disponibili per questo evento");
            }
            this.postiDisponibili = postiDisponibili - prenotaPosti;
            Console.Write("Hai prenotato: " + prenotaPosti + " posti \n");
            Console.WriteLine("Sono rimasti disponibili: " + this.postiDisponibili + " posti");
        }

        public void Disdici(int disdiciPosti)
        {   
            
        }

        public override string ToString()
        {   
            string rapprString = "\t" + data.ToString("dd/MM/yyyy") + " - " + this.titolo + "\n";
            rapprString += "\tPosti disponibili: " + capienzaMax + "\n";
            rapprString += "\tPosti prenotati: " + postiPrenotati + "\n";
            return rapprString; 
        }
    }
}
