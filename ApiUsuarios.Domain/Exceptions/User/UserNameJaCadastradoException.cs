using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Exceptions.User
{
    /// <summary>
    /// Exceção customizada para usuário já cadastrado
    /// </summary>
    public class UserNameJaCadastradoException : Exception
    {
        public override string Message
        => "UserName já cadastrado.";

    }
}
