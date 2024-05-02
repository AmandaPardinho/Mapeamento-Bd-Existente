using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("film");

            builder.Property(f => f.ID)
                .HasColumnName("film_id");

            builder.Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(f => f.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");

            builder.Property(f => f.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            builder.Property(f => f.Duracao)
                .HasColumnName("length")
                .HasColumnType("smallint");

            builder.Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();  
            
            builder.Property<byte>("language_id");

            builder.Property<byte?>("original_language_id");

            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(i => i.FilmesFalados)
                .HasForeignKey("language_id");

            builder
                .HasOne(f => f.IdiomaOriginal)
                .WithMany(i => i.FilmesOriginais)
                .HasForeignKey("original_language_id");

            builder
                .Property(f => f.Classificação)
                .HasColumnName("rating")
                .HasColumnType("varchar(10)");
        }
    }
}
