// MILESTONE 1

using GestoreEventi;

Evento evento = new Evento("Trapani Comics", "29/05/2023", 1000);

Console.WriteLine(evento);

evento.Prenota(10);
evento.Disdici(5);