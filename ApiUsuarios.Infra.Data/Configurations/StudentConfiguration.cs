using ApiUsuarios.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Infra.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>

    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Definindo a chave primária
            builder.HasKey(s => s.Id);

            // Definindo o mapeamento das propriedades
            builder.Property(s => s.Nome)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(s => s.Idade)
                .IsRequired(false);

            builder.Property(s => s.Serie)
                .IsRequired(false);

            builder.Property(s => s.NotaMedia)
                .IsRequired(false);

            builder.Property(s => s.Endereco)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(s => s.NomePai)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(s => s.NomeMae)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(s => s.DataNascimento)
                .IsRequired(false);

            // Nome da tabela (opcional)
            builder.ToTable("Students");
        }
    }
}
