using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Exceptions.Student
{
    /// <summary>
    /// Exceção customizada para student não encontrado.
    /// </summary>
    public class StudentNaoEncontradoException : Exception
    {
        public override string Message => "Estudante não encontrado.";
    }
}
