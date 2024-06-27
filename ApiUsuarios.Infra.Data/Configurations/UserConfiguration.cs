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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.UserName)
            .HasMaxLength(150)
            .IsRequired();

            builder.Property(u => u.Password)
            .HasMaxLength(40)
            .IsRequired();


            // Nome da tabela (opcional)
            builder.ToTable("User");

        }
    }
}
