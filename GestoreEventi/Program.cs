// MILESTONE 1

using GestoreEventi;
using System.Linq.Expressions;

try
{
    Evento evento = new Evento("Trapani Comics", "29/05/2023", 1000);


    Console.WriteLine(evento);

    evento.Prenota(10);
    evento.Disdici(8);
} catch (ArgumentException ex)
{
    Console.Write(ex.Message);
}
