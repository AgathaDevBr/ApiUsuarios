using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Exceptions.User
{
    /// <summary>
    /// Exceção customizada para usuário não encontrado
    /// </summary>
    public class UserNaoEncontradoException : Exception
    {
        public override string Message
        => "User não encontrado.";
    }
}
