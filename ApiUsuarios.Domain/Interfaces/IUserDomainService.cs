using ApiUsuarios.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Interfaces
{
    /// <summary>
    /// Interface para abstração das operações de regras de negócio de Usuario
    /// </summary>
    public interface IUserDomainService
    {
        User Auth(string userName, string password);
        void CreateAccount(User user);
    }
}
