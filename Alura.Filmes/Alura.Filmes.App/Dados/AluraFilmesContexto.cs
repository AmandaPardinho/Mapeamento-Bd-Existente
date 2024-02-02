using Alura.Filmes.App.Negocio;
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

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>(e =>
            {
                e.ToTable("actor");

                e.Property(a => a.Id)
                .HasColumnName("actor_id");

                e.Property(a => a.PrimeiroNome)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(45)")
                    .IsRequired();

                e.Property(a => a.UltimoNome)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(45)")
                    .IsRequired();

                e.Property<DateTime>("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()"); //trigger
            });
        }
    }
}
