using ApiUsuarios.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Add(User usuario);
        void Update(User usuario);
        User Get(string? userName);
        User Get(string? userName, string? password);
    }
}
