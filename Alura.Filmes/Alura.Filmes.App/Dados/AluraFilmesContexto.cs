﻿using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto: DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MIHQT5G;Database=AluraFilmes;user=sa;password=amanda03;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}