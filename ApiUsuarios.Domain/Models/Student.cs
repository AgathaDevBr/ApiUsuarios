using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Models
{
    public class Student
    {
        // Identificador único do estudante
        public int Id { get; set; }

        // Nome do estudante
        public string? Nome { get; set; }

        // Idade do estudante
        public int? Idade { get; set; }

        // Série do estudante
        public int? Serie { get; set; }

        // Nota média do estudante
        public double? NotaMedia { get; set; }

        // Endereço do estudante
        public string? Endereco { get; set; }

        // Nome do pai do estudante
        public string? NomePai { get; set; }

        // Nome da mãe do estudante
        public string? NomeMae { get; set; }

        // Data de nascimento do estudante
        public DateTime? DataNascimento { get; set; }
    }
}
