using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi : Evento
    {
        public string titolo;
        public DateTime data;
        public List<Evento> eventi;

        // COSTRUTTORE

        public ProgrammaEventi(string titolo, string data) : base(titolo)
        {
            this.titolo = titolo;
            this.eventi = new List<Evento>();
            this.data = DateTime.Parse(data);
        }

        // GETTERS

        public string GetoTitolo()
        {
            return this.titolo;
        }

        public DateTime GetData()
        {
            return this.data;
        }

        public List<Evento> Geteventi()
        {
            return this.eventi;
        }

        // SETTERS  

        public void SetData(string data)
        {
            this.data = DateTime.Parse(data);
        }

        // METODI   

        public void aggiungiEvento(Evento nuovoEvento)
        {
            this.eventi.Add(nuovoEvento);
        }

        public override string ToString()
        {
            string rapprString = "Nome evento: " + this.titolo + " - " + data.ToString("dd/MM/yyyy") +"\n";
            return rapprString;
        }
    }
}
