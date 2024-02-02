using System;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //select * from actor
            using(var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                //foreach (var ator in contexto.Atores) 
                //{
                //    Console.WriteLine(ator);
                //}

                var ator = new Ator();
                ator.PrimeiroNome = "Chris";
                ator.UltimoNome = "Evans";

                //contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;
                contexto.Atores.Add(ator);
                contexto.SaveChanges();

                Console.WriteLine(ator);
            }
        }
    }
}