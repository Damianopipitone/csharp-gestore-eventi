// MILESTONE 1

using GestoreEventi;

try
{
    Evento evento = new Evento("Trapani Comics", "29/05/2023", 1000);


    Console.WriteLine(evento);


    Console.WriteLine("Vuoi prenotare per questo evento?");

    string utenteHaPrenotato = Console.ReadLine();

    if (utenteHaPrenotato == "Si")
    {
        Console.WriteLine("Qaunte prenotazioni vuoi fare?");
        string numeroPrenotazioniUtente = Console.ReadLine();
        int numeroInteroPrenotazioni = int.Parse(numeroPrenotazioniUtente);
        
        for (int i = 0; i < numeroInteroPrenotazioni; i++) 
        {
            evento.Prenota(10);
        }
    }else
    {
        Console.WriteLine("Grazie e arrivederci!");
    }

    if (utenteHaPrenotato == "Si")
    {
        Console.WriteLine("Vuoi disdire la prenotazione?");

        string utenteHaDisdetto = Console.ReadLine();
        
            if (utenteHaDisdetto == "Si")
        {
            Console.WriteLine("Indica i posti che vuoi disdire");
            evento.Disdici(3);
        } else
        {
            Console.WriteLine("Grazie, buon divertimento!");
        }
    }

    
    
    
} catch (ArgumentException ex)
{
    Console.Write(ex.Message);
}

ProgrammaEventi Comicon = new ProgrammaEventi("Comicon", "24/04/2024");
ProgrammaEventi GamesWeek = new ProgrammaEventi("Milan Games Week", "26/11/2024");
Comicon.aggiungiEvento(Comicon);

Console.WriteLine(Comicon);
Console.Write(GamesWeek);
