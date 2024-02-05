using System;
using System.Linq;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //select * from actor
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                //foreach (var ator in contexto.Atores) 
                //{
                //    Console.WriteLine(ator);
                //}

                //var ator = contexto.Atores.First();

                //contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;
                //contexto.Atores.Add(ator);

                //Console.WriteLine(ator);
                //Console.WriteLine(contexto.Entry(ator).Property("last_update").CurrentValue);

                //contexto.SaveChanges();

                //listar 10 atores que foram modificados recentemente
                //var atores = contexto.Atores
                //    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                //    .Take(10);

                //foreach (var ator in atores)
                //{
                //    Console.WriteLine(ator + " - " + contexto.Entry(ator).Property("last_update").CurrentValue);
                //}
            foreach(var filme in contexto.Filmes)
                {
                    Console.WriteLine(filme);
                }
                
            }
        }
    }
}