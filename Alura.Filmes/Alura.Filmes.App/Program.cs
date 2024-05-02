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
                //foreach(var filme in contexto.Filmes)
                //{
                //    Console.WriteLine(filme);
                //}

                //foreach (var item in contexto.Elenco)
                //{
                //    var entidade = contexto.Entry(item);
                //    var filmId = entidade.Property("film_id").CurrentValue;
                //    var actorId = entidade.Property("actor_id").CurrentValue;
                //    Console.WriteLine($"Filme: {filmId} - Ator: {actorId}");
                //}

                //var filme = contexto.Filmes
                //    .Include(f => f.Atores)
                //    .ThenInclude(fa => fa.Ator)
                //    .First();

                //Console.WriteLine(filme);

                //var categoria = contexto.Categorias
                //    .Include(c => c.Filmes)
                //    .ThenInclude(fc => fc.Filme);

                //foreach (var c in categoria)
                //{
                //    Console.WriteLine("");
                //    Console.WriteLine($"Filmes da categoria {c}:");
                //    foreach (var fc in c.Filmes)
                //    {
                //        Console.WriteLine(fc.Filme);
                //    }
                //}

                //Console.WriteLine("Elenco: ");

                //foreach (var ator in filme.Atores)
                //{
                //    Console.WriteLine(ator.Ator);
                //}

                //foreach(var idioma in contexto.Idiomas)
                //{
                //    Console.WriteLine(idioma);
                //}

                //var idiomas = contexto.Idiomas
                //    .Include(i => i.FilmesFalados);

                //foreach (var idioma in idiomas)
                //{
                //    Console.WriteLine(idioma);
                //}

                //var filmes = contexto.Filmes
                //    .Include(f => f.IdiomaFalado);

                //foreach (var filme in filmes)
                //{
                //    Console.WriteLine(filme);
                //    Console.WriteLine(filme.IdiomaFalado);
                //}

                var idiomas = contexto.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine(idioma);
                    foreach (var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}