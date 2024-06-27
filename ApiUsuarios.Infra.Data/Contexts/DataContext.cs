using ApiUsuarios.Domain.Models;
using ApiUsuarios.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método que define o banco de dados acessado pelo EntityFramework
        /// </summary>
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseInMemoryDatabase
            (databaseName: "BDApiUsuarios");

        }

        /// <summary>
        /// Método para adicionar as classes de mapeamento do projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }

        /// <summary>
        /// Propriedade para fornecer os métodos do repositório
        /// </summary>
        public DbSet<User>? Users { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
